using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;

namespace Logistics 
{
	// форма для выбора одной или нескольких записей о товарах-упаковках 
	// возвращает в родительскую форму:
	// с пометкой:  string _SelectedPackingsIDList (список кодов отмеченных записей, через запятую, вида: 1,2,23,) 
	// без пометки: int _SelectedPackingID (код текущей записи)
	// string _SelectedPackingsAliasText (список алиасов первых 3-х отмеченных товаров)

	public partial class frmSelectOnePacking : RFMFormChild
	{
		private Form parentForm;
		bool bFromParentForm = false;

		private RFMSelectRecordIDForm ucSelect = null;

		private bool useCheck;

		private Good oGoods = new Good();
		private Good oGoodsTree = new Good();

		private Host oHost = new Host();
		private int? nHostID = null;
		private int? nUserHostID = null;

		private int? nOwnerID = null;

		string sSelectedGoodsBrandsIDList = null;

		public frmSelectOnePacking()
		{
			InitializeComponent();

			parentForm = Application.OpenForms[0];
			useCheck = true;
		}


		#region parentForm

		public frmSelectOnePacking(Form _parentForm)
		{
			InitializeComponent();
			
			parentForm = _parentForm;
			bFromParentForm = true;

			useCheck = false;
		}

		public frmSelectOnePacking(Form _parentForm, bool _useCheck)
		{
			InitializeComponent();

			parentForm = _parentForm;
			bFromParentForm = true;

			useCheck = _useCheck;
		}

		public frmSelectOnePacking(Form _parentForm, bool _useCheck, int? _nOwnerID)
		{
			InitializeComponent();

			parentForm = _parentForm;
			bFromParentForm = true;

			useCheck = _useCheck;
			nOwnerID = _nOwnerID;
		}

		public frmSelectOnePacking(Form _parentForm, bool _useCheck, int? _nOwnerID, int? _nHostID)
		{
			InitializeComponent();

			parentForm = _parentForm;
			bFromParentForm = true;

			useCheck = _useCheck;
			nOwnerID = _nOwnerID;
			nHostID = _nHostID;
		}

		#endregion parentForm

		#region RFMSelectRecordIDForm

		public frmSelectOnePacking(RFMSelectRecordIDForm uc)
		{
			InitializeComponent();

			ucSelect = uc;

			useCheck = false;
		}

		public frmSelectOnePacking(RFMSelectRecordIDForm uc, bool _useCheck)
		{
			InitializeComponent();

			ucSelect = uc;
			
			useCheck = _useCheck;
		}

		public frmSelectOnePacking(RFMSelectRecordIDForm uc, bool _useCheck, int? _nOwnerID)
		{
			InitializeComponent();

			ucSelect = uc;
			
			useCheck = _useCheck;
			nOwnerID = _nOwnerID;
		}

		public frmSelectOnePacking(RFMSelectRecordIDForm uc, bool _useCheck, int? _nOwnerID, int? _nHostID)
		{
			InitializeComponent();

			ucSelect = uc;
			
			useCheck = _useCheck;
			nOwnerID = _nOwnerID;
			nHostID = _nHostID;
		}

		#endregion RFMSelectRecordIDForm


		private void frmSelectOnePacking_Load(object sender, EventArgs e)
		{
			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			grdData.IsCheckerInclude = useCheck;
			grdData.IsCheckerShow = useCheck;

			if (useCheck)
				Text = "Выберите несколько товаров";
			else
				Text = "Выберите товар";


			if (nOwnerID.HasValue)
			{
				// а будет это так:
				// oGoods.FilterOwnersList = nOwnerID.ToString();

				// а пока - через бренд
				oGoods.FillTableGoodsBrands();

				string sPrefix = "TM";

				sSelectedGoodsBrandsIDList = "";
				string sSelectedGoodsBrandsNames = "";
				Partner oOwner = new Partner();
				oOwner.ReFillOne((int)nOwnerID);
				int i = 0;
				int nSelCount = 3;
				foreach(DataRow gb in oGoods.TableGoodsBrands.Rows)
				{
					if (gb["ERPCode"].ToString().ToUpper().Contains(sPrefix) == oOwner.ERPCode.Contains(sPrefix))
					{
						// отметить 
						sSelectedGoodsBrandsIDList += gb["ID"].ToString() + ",";
						i++;
						if (i <= nSelCount)
						{
							sSelectedGoodsBrandsNames += gb["Name"] + ", "; 
						}
						else
						{
							if (i == nSelCount + 1)
							{
								sSelectedGoodsBrandsNames += "...";
							}
						}
					}
				}
				sSelectedGoodsBrandsNames = sSelectedGoodsBrandsNames.Trim();
				if (sSelectedGoodsBrandsNames.Substring(sSelectedGoodsBrandsNames.Length - 1, 1) == ",")
				{
					sSelectedGoodsBrandsNames = sSelectedGoodsBrandsNames.Substring(0, sSelectedGoodsBrandsNames.Length - 1);
				}
				ucSelectRecordID_GoodsBrands.txtData.Text = sSelectedGoodsBrandsNames;
			}

			oHost.FillDataAsync();
			if (nHostID.HasValue)
			{
				DataRow rh = oHost.MainTable.Rows.Find(nHostID);
				if (rh != null)
				{
					ucSelectRecordID_Hosts.txtData.Text = rh["Name"].ToString();
					ucSelectRecordID_Hosts.LstMarked = nHostID.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				}
			}
			if (nUserHostID.HasValue)
			{
				DataRow rh = oHost.MainTable.Rows.Find(nUserHostID);
				if (rh != null)
				{
					ucSelectRecordID_Hosts.txtData.Text = rh["Name"].ToString();
					ucSelectRecordID_Hosts.LstMarked = nUserHostID.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				}
			}
			
			if (oHost.Count() <= 1 || nUserHostID.HasValue)
			{
				lblHosts.Visible = 
				ucSelectRecordID_Hosts.Visible =
				ucSelectRecordID_Hosts.Enabled = 
					false;
			}

			cntData.SplitterDistance = 0;
			cntData.Panel1MinSize = 0;
			//lblTreeWait.Visible = false;

			txtName.Select();
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			WaitOn(this);

			oGoods.ClearError();
			oGoods.ClearFilters();

			// собираем условия
			if (ucSelectRecordID_GoodsGroups.IsSelectedExist)
				oGoods.FilterGoodsGroupsList = ucSelectRecordID_GoodsGroups.GetIdString();
			if (ucSelectRecordID_GoodsBrands.IsSelectedExist)
				oGoods.FilterGoodsBrandsList = ucSelectRecordID_GoodsBrands.GetIdString();

			if (txtGoodBarCode.Text.Trim().Length > 0)
				oGoods.FilterGoodBarCode = txtGoodBarCode.Text.Trim();
			if (txtName.Text.Trim().Length > 0)
				oGoods.FilterGoodNameContext = txtName.Text.Trim();

			if (chkGoodsActual.Checked)
				oGoods.FilterGoodsActual = true;
			if (chkPackingsActual.Checked)
				oGoods.FilterPackingsActual = true;

			if (nHostID.HasValue || nUserHostID.HasValue)
			{
				if (nHostID.HasValue) 
					oGoods.FilterHostsList = nHostID.ToString();
				if (nUserHostID.HasValue)
					oGoods.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oGoods.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}

			if (tvwGoods.Visible && tvwGoods.TreeSource != null && tvwGoods.GetMarkedNodes() > 0)
			{
				tvwGoods.TreeSource.Filter = "IsMarked";
				tvwGoods.TreeSource.MoveFirst();
				for (int i = 0; i < tvwGoods.TreeSource.Count; i++)
				{
					oGoods.GoodsIDList = oGoods.GoodsIDList + "," + ((DataRowView)tvwGoods.TreeSource.Current)["ID"];
					tvwGoods.TreeSource.MoveNext();
				}
				tvwGoods.TreeSource.RemoveFilter();
			}

			grdData.DataSource = null;

			oGoods.FillDataAsync();

			if ((chkWeightNot.Checked) || (chkWeight.Checked))
			{
				DataTable dt = CopyTable(oGoods.MainTable, "dt", ((chkWeightNot.Checked) ? "not " : "") + "Weighting", "GoodAlias, GoodID, PackingID");
				oGoods.MainTable.Clear();
				oGoods.MainTable.Merge(dt);
			}

			grdData.Restore(oGoods.MainTable);

			WaitOff(this);

			/* // восстановить отмеченные записи
			if (ucSelect != null)
			{
				if (ucSelect.IsSaveMark)
					ucSelect.RestoreMarks(grdData);
			}
			*/

			grdData.Select();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ucSelectRecordID_GoodsGroups.ClearData();
			ucSelectRecordID_GoodsBrands.ClearData();
			txtGoodBarCode.Text = "";
			txtName.Text = "";
			if (ucSelectRecordID_Hosts.Visible && ucSelectRecordID_Hosts.Enabled)
				ucSelectRecordID_Hosts.ClearData();
			tvwGoods.MarkAllItems(false);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			// возвращаем код выбранного товара/упаковки в родительскую форму, поле _SelectedPackingID

			string _SelectedPackingsIDList = null;
			int? _SelectedPackingID = null;
			string _SelectedPackingsAliasText = "";

			if (grdData.Rows.Count > 0)
			{
				if (ucSelect != null)
				{
					ucSelect.SaveData(grdData, "GoodAlias", useCheck);
				}
				else
				{
					if (useCheck && grdData.IsCheckerShow)
					{
						// список ID 
						_SelectedPackingsIDList = "";
						_SelectedPackingsAliasText = "";

						DataView dMarked = new DataView(oGoods.MainTable);
						dMarked.RowFilter = "IsMarked = true";
						dMarked.Sort = grdData.GridSource.Sort;
						int i = 0;
						int nFirstCntRecords = 3; // количество первых записей для наборного текстового значения
						foreach (DataRowView r in dMarked)
						{
							if (!Convert.IsDBNull(r["PackingID"]))
							{
								_SelectedPackingsIDList += r["PackingID"].ToString() + ",";

								if (i < nFirstCntRecords)
								{
									_SelectedPackingsAliasText += r["PackingAlias"].ToString().Trim() + ", ";
								}
								else
								{
									if (i == nFirstCntRecords)
									{
										_SelectedPackingsAliasText += "...";
									}
								}
								i++;
							}
						}
						if (_SelectedPackingsIDList.Length == 0)
						{
							// нет отметок - берем текущую запись
							if (grdData.CurrentRow != null)
							{
								_SelectedPackingsIDList = grdData.CurrentRow.Cells["grcPackingID"].Value.ToString() + ",";
								_SelectedPackingsAliasText = grdData.CurrentRow.Cells["grcGoodAlias"].Value.ToString().Trim();
							}
						}

						// приводим наборное текстовое поле к виду: (5) раз, два, три, ...
						if (_SelectedPackingsIDList.Length == 0)
						{
							_SelectedPackingsIDList = null;
							_SelectedPackingsAliasText = "";
						}
						else
						{
							_SelectedPackingsAliasText = _SelectedPackingsAliasText.Trim();
							if (_SelectedPackingsAliasText.Substring(_SelectedPackingsAliasText.Length - 1, 1) == ",")
							{
								_SelectedPackingsAliasText = _SelectedPackingsAliasText.Substring(0, _SelectedPackingsAliasText.Length - 1);
							}
							_SelectedPackingsAliasText = "(" + RFMUtilities.Occurs(_SelectedPackingsIDList, ",").ToString() + "): " +
								_SelectedPackingsAliasText;
						}

						if (bFromParentForm && parentForm != null)
						{
							RFMUtilities.SetFormField(parentForm, "_SelectedPackingsIDList", _SelectedPackingsIDList);
							RFMUtilities.SetFormField(parentForm, "_SelectedPackingsAliasText", _SelectedPackingsAliasText);
						}
					}
					else
					{
						// ID текущей строки
						if (grdData.CurrentRow != null)
						{
							_SelectedPackingID = (int)grdData.CurrentRow.Cells["grcPackingID"].Value;
							_SelectedPackingsAliasText = grdData.CurrentRow.Cells["grcGoodAlias"].Value.ToString().Trim();
						}

						if (bFromParentForm && parentForm != null)
						{
							RFMUtilities.SetFormField(parentForm, "_SelectedPackingID", _SelectedPackingID);
							RFMUtilities.SetFormField(parentForm, "_SelectedPackingsAliasText", _SelectedPackingsAliasText);
						}
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxInfo("Не выбрано ни одного товара...");
			}

			DialogResult = DialogResult.Yes;
			Dispose();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (oGoods.MainTable == null || oGoods.MainTable.Rows.Count == 0)
				return; 

			DataTable tGoodTable;

			if (useCheck)
			{
				DataView dMarked = new DataView(oGoods.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				if (dMarked.Count > 0)
				{
					// есть отмеченные записи
					tGoodTable = oGoods.MainTable.Clone();
					DataRow[] rows = oGoods.MainTable.Select("IsMarked = true", grdData.GridSource.Sort);
					foreach (DataRow r in rows)
					{
						tGoodTable.ImportRow(r);
					}
				}
				else
				{
					// нет отмеченных записей. выводим все
					tGoodTable = oGoods.MainTable;
				}
			}
			else
			{
				tGoodTable = oGoods.MainTable;
			}

			repPackings rep = new repPackings();
			StartForm(new frmActiveReport(tGoodTable, rep));
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

	#region Tree

		private void btnTree_Click(object sender, EventArgs e)
		{
			WaitOn(this);
			tvwGoods_Restore();
			cntData.SplitterDistance = 200;
			WaitOff(this);
		}

		private void tvwGoods_Restore()
		{
			if (tvwGoods.TreeSource != null)
				((DataTable)tvwGoods.TreeSource.DataSource).DataSet.Tables.Remove("dtTree");

			oGoods.FilterHostsList = null;
			if (nHostID.HasValue || nUserHostID.HasValue)
			{
				if (nHostID.HasValue) 
					oGoods.FilterHostsList = nHostID.ToString();
				if (nUserHostID.HasValue)
					oGoods.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oGoods.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}

			oGoods.FillDataTree("GROUP", tvwGoods.IsActualOnly);
			tvwGoods.Restore(oGoods.DS.Tables["TableDataTree"]);
			tvwGoods.SelectedNode = tvwGoods.TopNode;
			tvwGoods.Refresh();
		}

	#endregion 

	#region Grid CellFormat

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			if (grdData.IsStatusRow(e.RowIndex))
			{
				e.CellStyle.BackColor = Color.Silver;
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				return;
			}

			// неактуальные - курсивом
			DataGridViewRow r = grdData.Rows[e.RowIndex];
			if (!Convert.ToBoolean(r.Cells["grcGoodActual"].Value) || !Convert.ToBoolean(r.Cells["grcPackingActual"].Value))
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);

			// весовые товары или товары с нецелым вложением в коробоку
			switch (grdData.Columns[e.ColumnIndex].Name)
			{
				case "grcInBox":
					if (!Convert.IsDBNull(r.Cells["grcWeighting"].Value) &&
						Convert.ToBoolean(r.Cells["grcWeighting"].Value) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
					{
						e.CellStyle.Format = "### ###.000";
					}
					else
					{
						e.CellStyle.Format = "### ###";
					}
					break;
			}
		}

	#endregion 

	#region Form keys

		private void frmSelectOnePacking_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F5:
					btnFilter_Click(null, null);
					break;
				case Keys.F1:
					btnHelp_Click(null, null);
					break;
				case Keys.W:
				case Keys.S:
					if (e.Modifiers == Keys.Control)
					{
						btnGo_Click(null, null);
					}
					break;
				case Keys.Escape:
					btnExit_Click(null, null);
					break;
			}
		}


		private void grdData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnGo_Click(null, null);
		}

	#endregion
		
	#region Выбор группы, бренда, хоста

		#region GoodsGroups

		private void ucSelectRecordID_GoodsGroups_Restore()
		{
			ucSelectRecordID_GoodsGroups.sourceData = null;
			oGoods.FilterGoodsGroupsList = null;
			oGoods.FilterHostsList = null;
			if (nHostID.HasValue || nUserHostID.HasValue)
			{
				if (nHostID.HasValue)
					oGoods.FilterHostsList = nHostID.ToString();
				if (nUserHostID.HasValue)
					oGoods.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oGoods.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			if (Utilities.FillData_GoodsGroups(oGoods))
			{
				ucSelectRecordID_GoodsGroups.Restore(oGoods.TableGoodsGroups);
			}
		}

		#endregion GoodsGroups

		#region GoodsBrands

		private void ucSelectRecordID_GoodsBrands_Restore()
		{
			ucSelectRecordID_GoodsBrands.sourceData = null;
			oGoods.FilterGoodsBrandsList = null;
			oGoods.FilterHostsList = null;
			if (nHostID.HasValue || nUserHostID.HasValue)
			{
				if (nHostID.HasValue) 
					oGoods.FilterHostsList = nHostID.ToString();
				if (nUserHostID.HasValue) 
					oGoods.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oGoods.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			if (Utilities.FillData_GoodsBrands(oGoods))
			{
				ucSelectRecordID_GoodsBrands.Restore(oGoods.TableGoodsBrands);
			}
		}

		#endregion GoodsBrands

		#region Hosts

		private void ucSelectRecordID_Hosts_Restore()
		{
			if (ucSelectRecordID_Hosts.sourceData == null)
			{
				if (Utilities.FillData_Hosts(oHost))
				{
					ucSelectRecordID_Hosts.Restore(oHost.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Hosts.Restore();
			}
		}

		#endregion Hosts

	#endregion 

	#region Actual 

		private void chkGoodsActual_CheckedChanged(object sender, EventArgs e)
		{
			tvwGoods.IsActualOnly = chkGoodsActual.Checked;
			if (tvwGoods.Visible && tvwGoods.TreeSource != null)
			{
				tvwGoods_Restore();
			}
		}

	#endregion Actual

	#region Weight

		private void chkWeightNot_CheckedChanged(object sender, EventArgs e)
		{
			if (chkWeightNot.Checked) chkWeight.Checked = false;
		}

		private void chkWeight_CheckedChanged(object sender, EventArgs e)
		{
			if (chkWeight.Checked) chkWeightNot.Checked = false;
		}

	#endregion Weight
	}
}
