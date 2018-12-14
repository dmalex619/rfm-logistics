using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmOutputsDocumentsGuiltyEmployees : RFMFormChild
    {
        #region Properties

        private int nID;
		private OutputDocument oOutputDocument;
		DataTable dt;

		private bool bCarry = false;
		private int nCarryID;

		public int? _SelectedID = null;
		public string _SelectedText = "";

        #endregion Properties
        
        public frmOutputsDocumentsGuiltyEmployees(int _nID)
		{
			nID = _nID;

			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		public frmOutputsDocumentsGuiltyEmployees(int _nID, bool _bCarry)
		{
			bCarry = _bCarry;
			if (bCarry)
			{
				nID = -1;
				nCarryID = _nID;
			}
			else
			{
				nID = _nID;
			}

			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsGuiltyEmployees_Load(object sender, EventArgs e)
		{
			bool bResult = cboOutputDocumentFailReason_Restore();
			if (bResult)
			{
				if (!bCarry)
				{
					// расх_документ
					bResult = oOutputDocument.ReFillOne(nID);
					if (bResult)
					{
						txtGuiltyEmployees.Text = oOutputDocument.GuiltyEmployees;
                        chkIsDriverFoul.Checked = oOutputDocument.IsDriverFoul;

						if (bResult)
						{
							bResult = grdOutputsDocumentsGoods_Restore();
							if (bResult)
							{
								// «апрет контролов в зависимости от уровн€ причины: весь заказ или только отдельные позиции
								if (oOutputDocument.OutputDocumentFailReasonID.HasValue)
								{
									// весь заказ
									cboOutputDocumentFailReason.SelectedValue = (int)oOutputDocument.OutputDocumentFailReasonID;
									lblOutputDocument.Font = new Font(lblOutputDocument.Font, FontStyle.Bold);
									pnlOutputDocumentGoods.Enabled = false;
								}
								else
								{
									// товары
									foreach (DataGridViewColumn c in grdOutputsDocumentsGoods.Columns)
									{
										c.ReadOnly = !(c.Name.Contains("Guilty"));
									}
									cboOutputDocumentFailReason.SelectedIndex = -1;
									lblOutputDocumentGoods.Font = new Font(lblOutputDocument.Font, FontStyle.Bold);
									pnlOutputDocument.Enabled = false;
								}
							}
						}
					}
				}
				else
				{
					// перенос
					oOutputDocument.DateOutput = DateTime.Now.Date;
					bResult = oOutputDocument.FillTableOutputsDocumentsCarries(null, nCarryID) &&
						oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsCarries") &&
						oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"] != null &&
						oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows.Count == 1;
					if (bResult)
					{
						DataRow doc = oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows[0];

						txtGuiltyEmployees.Text = doc["GuiltyEmployees"].ToString();
                        chkIsDriverFoul.Checked = Convert.ToBoolean(doc["IsDriverFoul"]);
						if (!Convert.IsDBNull(doc["OutputDocumentFailReasonID"]))
							cboOutputDocumentFailReason.SelectedValue = Convert.ToInt32(doc["OutputDocumentFailReasonID"]);

						lblOutputDocument.Font = new Font(lblOutputDocument.Font, FontStyle.Bold);
						pnlOutputDocumentGoods.Enabled = false;
						pnlOutputDocumentGoods.Visible = false;
						int nShiftHeight = pnlOutputDocumentGoods.Height;
						pnlOutputDocumentGoods.Height = 0;
						MinimumSize = new Size(Width, Height - nShiftHeight);
						Height = Height - nShiftHeight;
						Refresh();
						CenterToScreen();
					}
				}
			}

			if (!bResult)
			{
				Dispose();
				return;
			}
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			oOutputDocument.ClearError();

			if (!bCarry)
			{
				// дл€ заказа в целом 
				if (pnlOutputDocument.Enabled)
				{
					// причина 
					if (cboOutputDocumentFailReason.SelectedValue == null || cboOutputDocumentFailReason.SelectedIndex < 0)
					{
						RFMMessage.MessageBoxError("Ќе указана причина проблемы дл€ документа в целом...");
						cboOutputDocumentFailReason.Select();
						return;
					}
					oOutputDocument.ChangeOutputDocumentFailReason(nID, (int)cboOutputDocumentFailReason.SelectedValue);

					// виновник-текст				
					if (txtGuiltyEmployees.Text.Trim().Length > 0)
					{
						oOutputDocument.SetGuiltyEmployees(nID, null, txtGuiltyEmployees.Text.Trim(), chkIsDriverFoul.Checked);
					}
					else
					{
						// сохран€ем пустое значение виновника-текста
						if (oOutputDocument.GuiltyEmployees != null && oOutputDocument.GuiltyEmployees.Length > 0)
						{
							// очистка виновника-текста
							if (RFMMessage.MessageBoxYesNo("ќчистить данные о виновниках проблемы дл€ документа в целом?") == DialogResult.Yes)
							{
								oOutputDocument.SetGuiltyEmployees(nID, null, "", false);
							}
						}
					}
				}

				// дл€ товаров
				if (pnlOutputDocumentGoods.Enabled)
				{
					// провер€ем указание причины
					foreach (DataRow rGood in dt.Rows)
					{
						if ((decimal)rGood["QntConfirmed"] != (decimal)rGood["QntWished"])
						{
							if (rGood["ReturnReasonID"] == null || rGood["ReturnReasonID"] == DBNull.Value)
							{
								RFMMessage.MessageBoxError("Ќе указана причина несоответстви€ отгруженного и доставленного количества дл€ товара\n" +
									rGood["GoodName"].ToString() + "...");
								int nGridPosition = ((RFMBindingSource)grdOutputsDocumentsGoods.GridSource).Find("ID", (int)rGood["ID"]);
								if (nGridPosition >= 0)
									grdOutputsDocumentsGoods.GridSource.Position = nGridPosition;
								return;
							}
						}
					}

					foreach (DataRow rGood in dt.Rows)
					{
						int nOutputDocumentGoodID = (int)rGood["ID"];
						// причина
						if (rGood["ReturnReasonID"] != null && rGood["ReturnReasonID"] != DBNull.Value)
						{
							oOutputDocument.ChangeOutputDocumentGoodReturnReason(nOutputDocumentGoodID, (int)rGood["ReturnReasonID"]);
							if (oOutputDocument.ErrorNumber != 0)
								return;
						}
						// виновник-текст
						oOutputDocument.SetGuiltyEmployees(null, nOutputDocumentGoodID, rGood["GuiltyEmployees"].ToString(), false);
						if (oOutputDocument.ErrorNumber != 0)
							return;
					}
				}
			}
			else
			{ 
				// дл€ переноса 
				if (cboOutputDocumentFailReason.SelectedValue == null || cboOutputDocumentFailReason.SelectedIndex < 0)
				{
					RFMMessage.MessageBoxError("Ќе указана причина проблемы (переноса) заказа...");
					cboOutputDocumentFailReason.Select();
					return;
				}
				oOutputDocument.ChangeOutputDocumentCarryFailReasonGuiltyEmployees(nCarryID, (int)cboOutputDocumentFailReason.SelectedValue, txtGuiltyEmployees.Text.Trim(), chkIsDriverFoul.Checked);
			}

			if (oOutputDocument.ErrorNumber == 0)
			{
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		#region Restore

		private bool cboOutputDocumentFailReason_Restore()
		{
			cboOutputDocumentFailReason.DataSource = null;
			oOutputDocument.ClearError();
			if (oOutputDocument.FillTableOutputsDocumentsFailsReasons())
			{
				cboOutputDocumentFailReason.ValueMember = oOutputDocument.TableOutputsDocumentsFailsReasons.Columns[0].Caption;
				cboOutputDocumentFailReason.DisplayMember = oOutputDocument.TableOutputsDocumentsFailsReasons.Columns[1].Caption;
				cboOutputDocumentFailReason.Restore(oOutputDocument.TableOutputsDocumentsFailsReasons);
			}
			return (oOutputDocument.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsGoods_Restore()
		{
			grdOutputsDocumentsGoods.DataSource = null;

			oOutputDocument.FillTableOutputsDocumentsGoods();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.TableOutputsDocumentsGoods == null)
			{
				RFMMessage.MessageBoxError("ќшибка при получении данных о товарах в расходном документе...");
				return (false);
			}

			if (oOutputDocument.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ќет данных о товарах в расходном документе...");
				return (false);
			}

			// только товары с проблемами
			string sFilter = "QntWished <> QntConfirmed";
			if (oOutputDocument.IsBrought)
				sFilter += " or QntWished <> QntBrought or QntConfirmed <> QntBrought";

			dt = null;
			dt = CopyTable(oOutputDocument.TableOutputsDocumentsGoods, "dt", sFilter, "ByOrder, GoodGroupName, GoodAlias");
			if (dt == null)
			{
				RFMMessage.MessageBoxError("ќшибка при получении данных о проблемных товарах в расходном документе...");
				return (false);
			}
			else
			{
				if (dt.Rows.Count == 0)
				{
					RFMMessage.MessageBoxInfo("¬ расходном документе нет проблемных товаров...");
					return (false);
				}
			}

			grdOutputsDocumentsGoods.Restore(dt);

			return(oOutputDocument.ErrorNumber == 0);
		}

		#endregion Restore

		#region Cells

		private void grdOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdOutputsDocumentsGoods.DataSource == null || 
				grdOutputsDocumentsGoods.CurrentRow == null || 
				grdOutputsDocumentsGoods.IsStatusRow(e.RowIndex))
				return;

			DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocumentsGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (r == null)
				return;

			string sColumnName = grdOutputsDocumentsGoods.Columns[e.ColumnIndex].Name; 
			if ((decimal)r["QntWished"] != (decimal)r["QntConfirmed"])
			{
				if (sColumnName.Contains("Confirmed"))
				{
					e.CellStyle.ForeColor = Color.Red;
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if ((decimal)r["QntConfirmed"] != (decimal)r["QntBrought"])
			{
				if (sColumnName.Contains("Brought"))
				{
					e.CellStyle.ForeColor = Color.Cyan; 
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			else
			{
				if ((decimal)r["QntWished"] != (decimal)r["QntBrought"])
				{
					if (sColumnName.Contains("Brought"))
					{
						e.CellStyle.ForeColor = Color.Violet;
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
					}
				}
			}

			switch (grdOutputsDocumentsGoods.Columns[e.ColumnIndex].Name)
			{
				case "grcInBox":
				case "grcQntWished":
				case "grcQntConfirmed":
				case "grcQntBrought":
					if (!Convert.IsDBNull(r["Weighting"]) && Convert.ToBoolean(r["Weighting"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ##0.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		#endregion Cells

		#region Prev values 

		private void btnGuiltyEmloyeeSelect_Click(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);
			// ранее введеные значени€ 
			OutputDocument oOutputDocumentTemp = new OutputDocument();
			oOutputDocumentTemp.FilterDateBeg = oOutputDocument.DateOutput.AddMonths(-1);
			oOutputDocumentTemp.FilterDateEnd = DateTime.Now.Date;
			oOutputDocumentTemp.FillData();
			if (oOutputDocumentTemp.ErrorNumber != 0 || oOutputDocumentTemp.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("ќшибка при получении данных о расходных документах...");
				return;
			}
			if (oOutputDocument.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ќет данных...");
				return;
			}

			DataView dv = new DataView(oOutputDocumentTemp.MainTable, "GuiltyEmployees > ''", "GuiltyEmployees", DataViewRowState.CurrentRows);
			DataTable tdGuiltyEmployees = dv.ToTable(true, "GuiltyEmployees"); 

			/*
			DataTable dtGuiltyEmployeesDistinct = new DataTable();
			dtGuiltyEmployeesDistinct.Columns.Add("GuiltyEmployees");
			System.Collections.Hashtable hash = new System.Collections.Hashtable();
			foreach (DataRow row in oOutputDocumentTemp.MainTable.Rows)
				hash[row["GuiltyEmployees"]] = row["GuiltyEmployees"];
			foreach (object name in hash.Values)
				dtGuiltyEmployeesDistinct.Rows.Add(name);
			DataTable tdGuiltyEmployees = CopyTable(dtGuiltyEmployeesDistinct, "tdGuiltyEmployees", "GuiltyEmployees > ''", "GuiltyEmployees");
			*/
			RFMCursorWait.Set(false);

			if (StartForm(new frmSelectID(this, tdGuiltyEmployees, "GuiltyEmployees", "¬иновник проблем", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				txtGuiltyEmployees.Text = _SelectedText;
			}
			_SelectedID = null;
			_SelectedText = "";

			return;
		}

		#endregion Prev values 

		#region Grid values 

		private void btnReturnReason_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocumentsGoods.CurrentRow == null)
				return;

			DataRow rGoodCurrent = ((DataRowView)grdOutputsDocumentsGoods.CurrentRow.DataBoundItem).Row;
			if (rGoodCurrent == null)
				return;

			bool bMarked = grdOutputsDocumentsGoods.IsCheckerShow && grdOutputsDocumentsGoods.MarkedCount > 0;

			// указать причину возврата товара
			if (oOutputDocument.TableReturnsReasons == null)
			{
				oOutputDocument.FillTableReturnsReasons();
				if (oOutputDocument.ErrorNumber != 0)
				{
					RFMMessage.MessageBoxError("ќшибка при получении возможных причин несоответстви€ отгруженного и доставленного количества товара...");
					oOutputDocument.ClearError();
					return;
				}
			}

			if (StartForm(new frmSelectID(this, oOutputDocument.TableReturnsReasons, "Name,GuiltyName", "ѕричина несоответстви€ количества,¬иновник", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
					return;

				int nReturnReasonID = (int)_SelectedID;

				DataRow rReturnReason = oOutputDocument.TableReturnsReasons.Rows.Find(nReturnReasonID);
				if (rReturnReason != null)
				{
					if (!bMarked)
					{
						rGoodCurrent["ReturnReasonID"] = nReturnReasonID;
						rGoodCurrent["ReturnReasonName"] = _SelectedText;
						rGoodCurrent["GuiltyID"] = rReturnReason["GuiltyID"];
						rGoodCurrent["GuiltyName"] = rReturnReason["GuiltyName"];
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("”становить причину несоответстви€ отгруженного и доставленного количества дл€ всех отмеченных товаров (" + grdOutputsDocumentsGoods.MarkedCount.ToString().Trim() + ")?") != DialogResult.Yes)
							return;

						foreach (DataRow rGood in dt.Rows)
						{
							if ((bool)rGood["IsMarked"])
							{
								rGood["ReturnReasonID"] = nReturnReasonID;
								rGood["ReturnReasonName"] = _SelectedText;
								rGood["GuiltyID"] = rReturnReason["GuiltyID"];
								rGood["GuiltyName"] = rReturnReason["GuiltyName"];
							}
						}
					}
				}
			}

			_SelectedID = null;
			_SelectedText = "";
		}

		private void btnGoodsGultiesFill_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocumentsGoods.DataSource == null ||
				grdOutputsDocumentsGoods.Rows.Count == 0 ||
				grdOutputsDocumentsGoods.CurrentRow == null ||
				grdOutputsDocumentsGoods.IsStatusRow(grdOutputsDocumentsGoods.CurrentRow.Index))
				return;

			DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocumentsGoods.Rows[grdOutputsDocumentsGoods.CurrentRow.Index]).DataBoundItem).Row;

			string sText = grdOutputsDocumentsGoods.CurrentRow.Cells["grcOutputsGoods_GuiltyEmployees"].Value.ToString();
			int? nReturnReasonID = null;
			string sReturnReasonName = null;
			int? nGuiltyID = null;
			string sGuiltyName = null;

			if (r["ReturnReasonID"] != null && r["ReturnReasonID"] != DBNull.Value)
			{
				nReturnReasonID = (int)r["ReturnReasonID"];
				sReturnReasonName = r["ReturnReasonName"].ToString();
				if (r["GuiltyID"] != null && r["GuiltyID"] != DBNull.Value)
				{
					nGuiltyID = (int)r["GuiltyID"];
					sGuiltyName = r["GuiltyName"].ToString();
				}
			}

			if (sText.Length > 0 || nReturnReasonID.HasValue)
			{
				foreach (DataRow rGood in dt.Rows)
				{
					if ((rGood["GuiltyEmployees"] == null || rGood["GuiltyEmployees"] == DBNull.Value || rGood["GuiltyEmployees"].ToString().Length == 0) &&
						sText.Length > 0)
					{
						rGood["GuiltyEmployees"] = sText;
					}

					if ((rGood["ReturnReasonID"] == null || rGood["ReturnReasonID"] == DBNull.Value) &&
						nReturnReasonID.HasValue)
					{
						rGood["ReturnReasonID"] = nReturnReasonID;
						rGood["ReturnReasonName"] = sReturnReasonName;
						if (nGuiltyID.HasValue)
						{
							rGood["GuiltyID"] = nGuiltyID;
							rGood["GuiltyName"] = sGuiltyName;
						}
					}
				}
				grdOutputsDocumentsGoods.Refresh();
			}
		}

		private void btnGoodsGultiesClear_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocumentsGoods.DataSource == null ||
				grdOutputsDocumentsGoods.Rows.Count == 0)
				return;

			if (RFMMessage.MessageBoxYesNo("ќчистить данные о виновниках проблем дл€ всех товаров в расходном документе?") == DialogResult.Yes)
			{
				foreach (DataRow rGood in dt.Rows)
				{
					rGood["GuiltyEmployees"] = "";
				}
				grdOutputsDocumentsGoods.Refresh();
			}
		}

		#endregion Grid values
	}
}
