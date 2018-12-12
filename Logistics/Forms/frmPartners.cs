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
	public partial class frmPartners : RFMFormChild
	{
		private Partner oPartnerList; //список партнеров
		private Partner oPartnerCur; //текущий партнер

		private Partner oPartnerRootList; //список товаров
		private Partner oPartnerRootCur; //текущий товар

		private Partner oPartnerForRoot;

		private PrintForm oPrintFormList; //список печ.форм
		private PrintForm oPrintFormCur; //текущая печ.форма

		private Partner oPartnerForPrintForm;

		private Host oHost;
		private int? nUserHostID = null;


		public frmPartners()
		{
			oPartnerList = new Partner();
			oPartnerCur = new Partner();
			if (oPartnerList.ErrorNumber != 0 ||
				oPartnerCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oPartnerRootList = new Partner();
				oPartnerRootCur = new Partner();
				if (oPartnerRootList.ErrorNumber != 0 ||
					oPartnerRootCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPartnerForRoot = new Partner();
				oPartnerForPrintForm = new Partner();
				if (oPartnerForRoot.ErrorNumber != 0 ||
					oPartnerForPrintForm.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPrintFormList = new PrintForm();
				oPrintFormCur = new PrintForm();
				if (oPrintFormList.ErrorNumber != 0 ||
					oPrintFormCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			oHost = new Host();
			if (oHost.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmPartners_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);

			/*
			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}
			*/ 

			tcList.Init();

			btnClearTerms_Click(null, null);
			txtNameContext.Select();

			RFMCursorWait.Set(false);
		}

	#region Tab restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled = false;

			txtNameContext.Select();
			
			return (true);
        }

        #region tabData (Partners)

        private bool tabData_Restore()
		{
			grdData_Restore();
			btnAdd.Enabled = false; // не исп.
			if (grdData.Rows.Count > 0)
			{
				btnEdit.Enabled = true;
				btnDelete.Enabled = false; // не исп.
				btnPrint.Enabled =
				btnService.Enabled = 
					true;
				grdData.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		private bool tabPartners_Details_Restore()
		{
			return (grdPartnersDetails_Restore());
		}

		private bool tabPartners_PartnersGoods_Restore()
		{
			return (grdPartnersGoods_Restore());
		}

        #endregion tabData (Partners)

        #region tabPartnersRoots

        private bool tabPartnersRoots_Restore()
		{
			grdPartnersRoots_Restore();
			btnAdd.Enabled = false; // не исп. 
			if (grdPartnersRoots.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false; // не исп. 
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdPartnersRoots.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabPartnersRoots_Partners_Restore()
		{
			return (grdPartnersRoots_Partners_Restore());
		}

        #endregion tabPartnersRoots

		#region tabPrintForms

		private bool tabPrintForms_Restore()
		{
			grdPrintForms_Restore();
			btnAdd.Enabled = true;
			btnPrint.Enabled = false;
			if (grdPrintForms.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnService.Enabled =
					true; 
				grdPrintForms.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabPrintForms_Partners_Restore()
		{
			return (grdPrintForms_Partners_Restore());
		}

		#endregion tabPrintForms


		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled = // не исп.
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				btnAdd.Enabled = false;
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdData.Select();
				btnService.ShortCutSet(mnuPartnersService);
				if (grdData.Rows.Count > 0 && grdData.CurrentRow != null)
				{
					if (!tabData.IsNeedRestore)
					{
						if (!grdData.IsStatusRow(grdData.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;
							oPartnerCur.ID = Convert.ToInt32(r["ID"]);
							grdData_CurrentRowChanged(null);
						}
					}
				}
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("ROOTS"))
			{
				btnAdd.Enabled = false;
				btnEdit.Enabled = 
				btnDelete.Enabled =
                    false; // (grdPartnersRoots.Rows.Count > 0);
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdPartnersRoots.Select();
				btnService.ShortCutSet(mnuPartnersRootsService);
				if (grdPartnersRoots.Rows.Count > 0 && grdPartnersRoots.CurrentRow != null)
				{
					if (!tabPartnersRoots.IsNeedRestore)
					{
						if (!grdPartnersRoots.IsStatusRow(grdPartnersRoots.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdPartnersRoots.CurrentRow.DataBoundItem).Row;
							oPartnerRootCur.PartnerRootID = Convert.ToInt32(r["ID"]);
							grdPartnersRoots_CurrentRowChanged(null);
						}
					}
				}
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("PRINT"))
			{
				btnAdd.Enabled = true;
				btnPrint.Enabled = false;
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnService.Enabled =
					true;
				grdPrintForms.Select();
				btnService.ShortCutSet(null);
				if (grdPrintForms.Rows.Count > 0 && grdPrintForms.CurrentRow != null)
				{
					if (!tabPrintForms.IsNeedRestore)
					{
						if (!grdPrintForms.IsStatusRow(grdPrintForms.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdPrintForms.CurrentRow.DataBoundItem).Row;
							oPrintFormCur.ID = Convert.ToInt32(r["ID"]);
							grdPrintForms_CurrentRowChanged(null);
						}
					}
				}
			}
		}

	#endregion TabRestore

	#region PrepareIDList 

		public void PartnerPrepareIDList(Partner oPartner, bool bMultiSelect)
		{
			oPartner.ID = null;
			oPartner.IDList = null;
			int? nPartnerID = 0;
			if (bMultiSelect && grdData.IsCheckerShow)
			{
				oPartner.IDList = "";

				DataView dMarked = new DataView(oPartnerList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdData.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nPartnerID = (int)r["ID"];
						oPartner.IDList = oPartner.IDList + nPartnerID.ToString() + ",";
					}
				}
			}
			else
			{
				nPartnerID = (int?)grdData.CurrentRow.Cells["grcID"].Value;
				if (nPartnerID.HasValue)
				{
					oPartner.ID = nPartnerID;
				}
			}
		}

	#endregion PrepareIDList

	#region RowEnter, CellFormatting

		#region Top Grids

        #region grdData (Partners)

        private void grdData_CurrentRowChanged(object sender)
		{
			if (grdData.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			// статусная строка
			if (grdData.IsStatusRow(e.RowIndex))
			{
				// if (grdData.Columns[e.ColumnIndex].GetType().Name.ToUpper().Contains("IMAGE"))
				if (grdData.Columns[e.ColumnIndex] is RFMDataGridViewImageColumn)
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdData.Columns[e.ColumnIndex];
			switch (c.Name)
			{
                case "grcDistance":
                    if (Convert.IsDBNull(r["Distance"]) || Convert.ToInt32(r["Distance"]) == 0)
                        e.Value = "";
                    break;
                case "grcStayMinutes":
                    if (Convert.IsDBNull(r["StayMinutes"]) || Convert.ToInt32(r["StayMinutes"]) == 0)
                        e.Value = "";
                    break;
            }
			if (c.Name.ToUpper().Contains("CopiesCount".ToUpper()))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
					e.Value = "";
			}
        }

        #endregion grdData (Partners)

        #region grdPartnersRoots

        private void grdPartnersRoots_CurrentRowChanged(object sender)
		{
			if (grdPartnersRoots.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdPartnersRoots_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdPartnersRoots.DataSource == null)
				return;

			// статусная строка
			if (grdPartnersRoots.IsStatusRow(e.RowIndex))
			{
				if (grdPartnersRoots.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			/*
			DataRow r = ((DataRowView)((DataGridViewRow)grdPartnersRoots.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdPartnersRoots.Columns[e.ColumnIndex];
			switch (c.Name)
			{
                case "grcPartnersRoots_XXXImage":
                    if (!Convert.IsDBNull(r["XXX"]))
						e.Value = Properties.Resources.Flag;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
			*/
        }

        #endregion grdPartnersRoots

		#region grdPrintForms

		private void grdPrintForms_CurrentRowChanged(object sender)
		{
			if (grdPrintForms.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		// CellFormatting - не нужен

		#endregion grdPrintForms

		#endregion Top Grids

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			if (tcList.CurrentPage.Name.ToUpper().Contains("DATA"))
			{
				if (grdData.CurrentRow == null)
					return;

				int rowIndex = grdData.CurrentRow.Index;

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				if (grdData.IsStatusRow(rowIndex))
				{
					oPartnerCur.ClearOne();
					btnEdit.Enabled =
					btnDelete.Enabled =
						false;
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[rowIndex]).DataBoundItem).Row;
					oPartnerCur.FillOne(r);
					btnEdit.Enabled = true;
				}
				tcPartners.SetAllNeedRestore(true);
			}

			if (tcList.CurrentPage.Name.ToUpper().Contains("ROOTS"))
			{
				if (grdPartnersRoots.CurrentRow == null)
					return;

				int rowIndex = grdPartnersRoots.CurrentRow.Index;

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				if (grdPartnersRoots.IsStatusRow(rowIndex))
				{
					oPartnerRootCur.PartnerRootID = null;
					btnEdit.Enabled =
					btnDelete.Enabled =
						false;
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdPartnersRoots.Rows[rowIndex]).DataBoundItem).Row;
					if (Convert.IsDBNull(r["ID"]))
						oPartnerRootCur.PartnerRootID = null;
					else 
						oPartnerRootCur.PartnerRootID = Convert.ToInt32(r["ID"]);
					btnEdit.Enabled = false;
				}
				tcPartnersRoots.SetAllNeedRestore(true);
			}

			if (tcList.CurrentPage.Name.ToUpper().Contains("PRINT"))
			{
				if (grdPrintForms.CurrentRow == null)
					return;

				int rowIndex = grdPrintForms.CurrentRow.Index;

				btnAdd.Enabled = true;
				btnPrint.Enabled = false;

				if (grdPrintForms.IsStatusRow(rowIndex))
				{
					btnEdit.Enabled =
					btnDelete.Enabled =
					btnService.Enabled =  
						false;
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdPrintForms.Rows[rowIndex]).DataBoundItem).Row;
					oPrintFormCur.FillOne(r);

					btnEdit.Enabled =
					btnDelete.Enabled =
					btnService.Enabled = 
						true;
				}
				tcPrintForms.SetAllNeedRestore(true);
			}
		}

		#region Bottom grids

		private void grdPartnersGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdPartnersGoods.DataSource == null || grdData.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdData.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdPartnersGoods.IsStatusRow(e.RowIndex))
			{
				if (grdPartnersGoods.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdPartnersGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdPartnersGoods.Columns[e.ColumnIndex];
			if (c.Name.ToUpper().Contains("INBOX"))
			{
				if (!Convert.IsDBNull(r["Weighting"]) && r["Weighting"] != null && (bool)r["Weighting"] ||
					!Convert.IsDBNull(e.Value) && e.Value != null && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
				{
					e.CellStyle.Format = "### ###.000";
				}
				else
				{
					e.CellStyle.Format = "### ###";
				}
			}
		}

		private void grdPartnersRoots_Partners_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdPartnersRoots_Partners.DataSource == null || grdPartnersRoots.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdPartnersRoots.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdPartnersRoots.IsStatusRow(grdPartnersRoots.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdPartnersRoots_Partners.IsStatusRow(e.RowIndex))
			{
				if (grdPartnersRoots_Partners.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			/*
			DataRow r = ((DataRowView)((DataGridViewRow)grdPartnersRoots_Partners.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdPartnersRoots_Partners.Columns[e.ColumnIndex];
			switch (c.Name)
			{
                case "grcPartnersRoots_Partners_XXXImage":
                    if (!Convert.IsDBNull(r["XXX"]))
						e.Value = Properties.Resources.Flag;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
			*/ 
		}

		#endregion Bottom grids

	#endregion 

	#region Restore

        #region Data (Partners)

        private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oPartnerCur.ClearOne();

			oPartnerList.ClearError();
			oPartnerList.ClearFilters();
			oPartnerList.ID = null;
			oPartnerList.IDList = null;

			// собираем условия

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oPartnerList.FilterNameContext = txtNameContext.Text.Trim().ToUpper();
			}
			if (txtInnContext.Text.Trim().Length > 0)
			{
				oPartnerList.FilterInnContext = txtInnContext.Text.Trim().ToUpper();
			}

			// выбор 
			oPartnerList.FilterPartnersRootsList = ucSelectRecordID_PartnersRoots.GetIdString();
			oPartnerList.FilterZonesList = ucSelectRecordID_Zones.GetIdString();
            oPartnerList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();

			// checks
			if (optActual.Checked)
			{
				oPartnerList.FilterActual = true;
			}
			if (optActualNot.Checked)
			{
				oPartnerList.FilterActual = false;
			}

			if (chkIsCustomer.Checked)
			{
				oPartnerList.FilterIsCustomer = true;
			}
			if (chkIsSupplier.Checked)
			{
				oPartnerList.FilterIsSupplier = true;
			}
			if (chkIsTransport.Checked)
			{
				oPartnerList.FilterIsTransport = true;
			}
			if (chkIsOwner.Checked)
			{
				oPartnerList.FilterIsOwner = true;
			}

			if (optPartnersGoodsExists.Checked)
			{
				oPartnerList.FilterPartnersGoodsExists = true;
			}
			if (optPartnersGoodsExistsNot.Checked)
			{
				oPartnerList.FilterPartnersGoodsExists = false;
			}

			// host
            /*
			if (nUserHostID.HasValue)
			{
				oPartnerList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (nUserHostID.HasValue)
				{
					oPartnerList.FilterHostsList = nUserHostID.ToString();
				}
			}
			*/

			grdPartnersDetails.DataSource = null;
			grdPartnersGoods.DataSource = null;

			grdData.GetGridState();

			oPartnerList.FillData();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oPartnerList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oPartnerList.ErrorNumber == 0);
		}

		private bool grdPartnersDetails_Restore()
		{
			grdPartnersDetails.GetGridState();
			grdPartnersDetails.DataSource = null;
			if (grdData.Rows.Count == 0 ||
				!oPartnerCur.ID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			// таблица реквизитов
			oPartnerCur.FillTablePartnersDetails(null, (int)oPartnerCur.ID);
			grdPartnersDetails.Restore(oPartnerCur.TablePartnersDetails);

			return (oPartnerCur.ErrorNumber == 0);
		}

		private bool grdPartnersGoods_Restore()
		{
			grdPartnersGoods.GetGridState();
			grdPartnersGoods.DataSource = null;
			if (grdData.Rows.Count == 0 ||
				!oPartnerCur.ID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			// таблица реквизитов
			oPartnerCur.FillTablePartnersGoods((int)oPartnerCur.ID);
			grdPartnersGoods.Restore(oPartnerCur.TablePartnersGoods);

			return (oPartnerCur.ErrorNumber == 0);
		}
		
		#endregion Data (Partners)

        #region PartnersRoots

        private bool grdPartnersRoots_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oPartnerRootCur.ClearOne();

			oPartnerRootList.ClearError();
			oPartnerRootList.ClearFilters();
			oPartnerRootList.ID = null;
			oPartnerRootList.IDList = null;

			// собираем условия

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oPartnerRootList.FilterNameContext = txtNameContext.Text.Trim().ToUpper();
			}
			if (txtInnContext.Text.Trim().Length > 0)
			{
				oPartnerRootList.FilterInnContext = txtInnContext.Text.Trim().ToUpper();
			}

			// выбор 
			oPartnerRootList.FilterPartnersRootsList = ucSelectRecordID_PartnersRoots.GetIdString();

			// checks
			if (optActual.Checked)
			{
				oPartnerRootList.FilterActual = true;
			}
			if (optActualNot.Checked)
			{
				oPartnerRootList.FilterActual = false;
			}
			//

			grdPartnersRoots_Partners.DataSource = null;

			grdPartnersRoots.GetGridState();

			oPartnerRootList.FillTablePartnersRoots();
			grdPartnersRoots.IsLockRowChanged = true;
			grdPartnersRoots.Restore(oPartnerRootList.TablePartnersRoots); 
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oPartnerRootList.ErrorNumber == 0);
		}

		private bool grdPartnersRoots_Partners_Restore()
		{
			grdPartnersRoots_Partners.GetGridState();
			grdPartnersRoots_Partners.DataSource = null;
			if (grdPartnersRoots.Rows.Count == 0 ||
				!oPartnerRootCur.PartnerRootID.HasValue || 
				(grdPartnersRoots.CurrentRow != null && grdPartnersRoots.IsStatusRow(grdPartnersRoots.CurrentRow.Index)))
				return (true);

			oPartnerForRoot.ClearFilters();
			oPartnerForRoot.FilterPartnersRootsList = oPartnerRootCur.PartnerRootID.ToString();
			oPartnerForRoot.FillData();
			grdPartnersRoots_Partners.Restore(oPartnerForRoot.MainTable);

			return (oPartnerForRoot.ErrorNumber == 0);
		}

        #endregion PartnersRoots

		#region PrintForms

		private bool grdPrintForms_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);
			oPartnerRootCur.ClearOne();

			oPrintFormList.ClearError();
			oPrintFormList.ClearFilters();
			oPrintFormList.ID = null;

			// собираем условия
			grdPrintForms_Partners.DataSource = null;

			grdPrintForms.GetGridState();

			oPrintFormList.FillData();
			grdPrintForms.IsLockRowChanged = true;
			grdPrintForms.Restore(oPrintFormList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oPrintFormList.ErrorNumber == 0);
		}

		private bool grdPrintForms_Partners_Restore()
		{
			grdPrintForms_Partners.GetGridState();
			grdPrintForms_Partners.DataSource = null;
			if (grdPrintForms.Rows.Count == 0 ||
				(grdPrintForms.CurrentRow != null &&
				 grdPrintForms.IsStatusRow(grdPrintForms.CurrentRow.Index)))
				return (true);

			DataRow r = ((DataRowView)((DataGridViewRow)grdPrintForms.Rows[grdPrintForms.CurrentRow.Index]).DataBoundItem).Row;
			string sPF_Name = r["PF_Name"].ToString().Trim();
			string sPF_Type = r["PF_Type"].ToString().Trim();
			if (sPF_Name != null && sPF_Name.Length > 0)
			{
				if (oPartnerForPrintForm.MainTable == null || oPartnerForPrintForm.MainTable.Rows.Count == 0)
				{
					oPartnerForPrintForm.FillData();
				}

				try
				{
					string sFilterCur = sPF_Type + "Name = '" + sPF_Name.ToUpper() + "'";
					DataTable dtTempPartners = CopyTable(oPartnerForPrintForm.MainTable, "dtPartners",
						sFilterCur, "PartnerName");
					grdPrintForms_Partners.Restore(dtTempPartners);
				}
				catch (Exception ex)
				{
					RFMMessage.MessageBoxError("Ошибка при получении списка клиентов, использующих печатную форму...\n" + ex.Message);
					return (false);
				}
			}
			return (oPartnerForPrintForm.ErrorNumber == 0);
		}

		#endregion PrintForms

    #endregion

    #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					if (StartForm(new frmPartnersEdit(null)) == DialogResult.Yes)
					{
						int nPartnerID = (int)GotParam.GetValue(0);
						grdData_Restore();
						if (nPartnerID > 0)
						{
							grdData.GridSource.Position = grdData.GridSource.Find(oPartnerList.ColumnID, nPartnerID);
						}
					}
					break;

                case "tabPartnersRoots":
					break;

				case "tabPrintForms":
					if (StartForm(new frmPrintFormsEdit(null)) == DialogResult.Yes)
					{
						int nPrintFormID = (int)GotParam.GetValue(0);
						grdPrintForms_Restore();
						if (nPrintFormID > 0)
						{
							grdPrintForms.GridSource.Position = grdPrintForms.GridSource.Find("ID", nPrintFormID);
						}
					}
					break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					if (grdData.CurrentRow == null)
						return;
					if (!oPartnerCur.ID.HasValue)
						return;

					// перечитать
					oPartnerCur.ReFillOne((int)oPartnerCur.ID);
					Refresh();

					if (StartForm(new frmPartnersEdit((int)oPartnerCur.ID)) == DialogResult.Yes)
					{
						grdData_Restore();
					}
					break;

                case "tabPartnersRoots":
					break;

				case "tabPrintForms":
					if (grdPrintForms.CurrentRow == null)
						return;

					DataRow r = ((DataRowView)((DataGridViewRow)grdPrintForms.Rows[grdPrintForms.CurrentRow.Index]).DataBoundItem).Row;
					int nPrintFormID = Convert.ToInt32(r["ID"]);

					if (StartForm(new frmPrintFormsEdit(nPrintFormID)) == DialogResult.Yes)
					{
						grdPrintForms_Restore();
					}
					break;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					break;

				case "tabPartnersRoots":
					break;

				case "tabPrintForms":
					if (grdPrintForms.CurrentRow == null)
						return;

					DataRow r = ((DataRowView)((DataGridViewRow)grdPrintForms.Rows[grdPrintForms.CurrentRow.Index]).DataBoundItem).Row;
					int nPrintFormID = Convert.ToInt32(r["ID"]);

					// есть ли клиенты с таким шаблоном...
					if (grdPrintForms_Partners.Rows.Count > 0)
					{
						RFMMessage.MessageBoxError("Если клиенты, использующие данную печатную форму...\n" + 
							"Удаление шаблона печатной формы не выполняется.");
						return;
					}

					if (RFMMessage.MessageBoxYesNo("Удалить текущий шаблон печатной формы?") != DialogResult.Yes)
						return;

					if (oPrintFormCur.Delete(nPrintFormID) && 
						oPrintFormCur.ErrorNumber == 0)
					{
						grdPrintForms_Restore();
					}
					oPrintFormCur.ClearError();
					break;
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

	#endregion

	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

	#endregion

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
        }

        #region PartnersService

		private void PartnersGoodsEdit()
		{
			if (grdData.CurrentRow == null)
				return;
			if (!oPartnerCur.ID.HasValue)
				return;

			if (StartForm(new frmPartnersGoodsEdit((int)oPartnerCur.ID)) == DialogResult.Yes)
			{
				grdData_Restore();
			}
        }

		private void PartnersGoodsCopy()
		{
			if (grdData.CurrentRow == null)
				return;
			if (!oPartnerCur.ID.HasValue)
				return;

			if (!grdData.IsCheckerShow || 
				grdData.MarkedCount == 0)
			{
				RFMMessage.MessageBoxError("Нет отмеченных партнеров...");
				return; 
			}

			int nPartnerID = (int)oPartnerCur.ID;
			if (!oPartnerCur.FillTablePartnersGoods(nPartnerID) ||
				oPartnerCur.TablePartnersGoods == null || oPartnerCur.TablePartnersGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Для текущего партнера нет спец.данных о товарах...");
				return; 
			}

			Partner oPartnerForCopy = new Partner();
			PartnerPrepareIDList(oPartnerForCopy, true);
			if (oPartnerForCopy.IDList != null && oPartnerForCopy.IDList.Length > 0)
			{
				string sText = "," + oPartnerForCopy.IDList + ",";
				if (sText.Contains("," + nPartnerID.ToString().Trim() + ","))
				{
					sText = sText.Replace("," + nPartnerID.ToString().Trim() + ",", ",");
					oPartnerForCopy.IDList = RFMUtilities.NormalizeList(sText);
				}
				if (!oPartnerForCopy.FillData() ||
					oPartnerForCopy.MainTable == null || oPartnerForCopy.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных об отмеченных партнерах...");
					return; 
				}

				if (RFMMessage.MessageBoxYesNo("Выполнить копирование спец.данных о товарах текущего партнера\n" + 
					"\"" + oPartnerCur.Name + "\"\n" + 
					"для всех отмеченных партнеров (" + oPartnerForCopy.MainTable.Rows.Count.ToString().Trim() + ")?\n\n" +
					"ВНИМАНИЕ!\n" + 
					"Существующие спец.данные о товарах для отмеченных партнеров, если таковые имеются, будут удалены и полностью заменены на спец.данные о товарах текущего партнера!") == DialogResult.Yes)
				{
					if (oPartnerForCopy.CopyTablePartnersGoods(nPartnerID, oPartnerForCopy.IDList))
					{
						grdData_Restore();
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxError("Нет данных об отмеченных партнерах...");
				return; 
			}
		}

		private void PartnersPFCopy()
		{
			if (grdData.CurrentRow == null)
				return;
			if (!oPartnerCur.ID.HasValue)
				return;

			if (!grdData.IsCheckerShow ||
				grdData.MarkedCount == 0)
			{
				RFMMessage.MessageBoxError("Нет отмеченных партнеров...");
				return;
			}

			int nPartnerID = (int)oPartnerCur.ID;
			oPartnerCur.ReFillOne(nPartnerID);
			if ( (oPartnerCur.PF_BillName == null || oPartnerCur.PF_BillName.Trim().Length == 0) &&
				  oPartnerCur.PF_BillCopiesCount == 0 && 
			     (oPartnerCur.PF_FactureName == null || oPartnerCur.PF_FactureName.Trim().Length == 0) &&
				  oPartnerCur.PF_FactureCopiesCount == 0 && 
			     (oPartnerCur.PF_PayBillName == null || oPartnerCur.PF_PayBillName.Trim().Length == 0) &&
				  oPartnerCur.PF_PayBillCopiesCount == 0) 
			{
				RFMMessage.MessageBoxError("Для текущего партнера нет данных о специальных печатных формах...");
				return;
			}

			Partner oPartnerForCopy = new Partner();
			PartnerPrepareIDList(oPartnerForCopy, true);
			if (oPartnerForCopy.IDList != null && oPartnerForCopy.IDList.Length > 0)
			{
				string sText = "," + oPartnerForCopy.IDList + ",";
				if (sText.Contains("," + nPartnerID.ToString().Trim() + ","))
				{
					sText = sText.Replace("," + nPartnerID.ToString().Trim() + ",", ",");
					oPartnerForCopy.IDList = RFMUtilities.NormalizeList(sText);
				}
				if (!oPartnerForCopy.FillData() ||
					oPartnerForCopy.MainTable == null || oPartnerForCopy.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных об отмеченных партнерах...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Выполнить копирование данных о специальных печатных формах и нестандартном количестве копий формируемых документов текущего партнера\n" + 
					"\"" + oPartnerCur.Name + "\"\n" + 
					"для всех отмеченных партнеров (" + oPartnerForCopy.MainTable.Rows.Count.ToString().Trim() + ")?\n\n" +
					"ВНИМАНИЕ!\n" +
					"Существующие данные о печатных формах и количестве копий для отмеченных партнеров, если таковые имеются, будут полностью заменены на данные текущего партнера!") == DialogResult.Yes)
				{
					if (oPartnerForCopy.CopyDataPartnersPF(nPartnerID, oPartnerForCopy.IDList))
					{
						grdData_Restore();
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxError("Нет данных об отмеченных партнерах...");
				return;
			}
		}

		#endregion PartnersService

        #region PartnersRootsService

        #endregion PartnersRootsService

		private void mniPartnersGoodsEdit_Click(object sender, EventArgs e)
		{
			PartnersGoodsEdit();
		}

		private void mniPartnersGoodsCopy_Click(object sender, EventArgs e)
		{
			PartnersGoodsCopy();
		}

		private void mniPartnersPFCopy_Click(object sender, EventArgs e)
		{
			PartnersPFCopy();
		}

    #endregion Service

    #region Filters

		#region SelectID

		private void ucSelectRecordID_PartnersRoots_Restore()
		{
			if (ucSelectRecordID_PartnersRoots.sourceData == null)
			{
				RFMCursorWait.Set(true);
				Partner oPartner = new Partner();
				oPartner.FillTablePartnersRoots();
				RFMCursorWait.Set(false);
				if (oPartner.ErrorNumber != 0 || oPartner.TablePartnersRoots == null)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных (объединения партнеров)...");
					return;
				}
				if (oPartner.TablePartnersRoots.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных (объединения партнеров)...");
					return;
				}

				ucSelectRecordID_PartnersRoots.Restore(oPartner.TablePartnersRoots);
			}
			else
			{
				ucSelectRecordID_PartnersRoots.Restore();
			}
		}

		private void ucSelectRecordID_Zones_Restore()
		{
			if (ucSelectRecordID_Zones.sourceData == null)
			{
				Zone oZone = new Zone();
				oZone.FillDataTree(true);
				if (oZone.ErrorNumber != 0 || oZone.DS.Tables["TableDataTree"] == null)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных (зоны)...");
					return;
				}
				if (oZone.DS.Tables["TableDataTree"].Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных (зоны)...");
					return;
				}

				ucSelectRecordID_Zones.Restore(oZone.DS.Tables["TableDataTree"]);
			}
			else
			{
				ucSelectRecordID_Zones.Restore();
			}
		}

		#endregion SelectID

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

	#endregion Filters

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			txtNameContext.Text = "";
			txtInnContext.Text = "";

			ucSelectRecordID_PartnersRoots.ClearData();
			ucSelectRecordID_Zones.ClearData();

			optActual.Checked = true;
			optPartnersGoodsExistsAll.Checked = true;

			chkIsCustomer.Checked =
			chkIsSupplier.Checked =
			chkIsTransport.Checked =
			chkIsOwner.Checked =
				false;

			tabData.IsNeedRestore =
			tabPartnersRoots.IsNeedRestore =    
			tabPrintForms.IsNeedRestore = 
				true;

			ucSelectRecordID_Hosts.ClearData();

		}

	#endregion

	}
}