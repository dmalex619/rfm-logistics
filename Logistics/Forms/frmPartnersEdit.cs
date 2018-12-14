using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmPartnersEdit : RFMFormChild
	{
		private int? nPartnerID = null;
		private Partner oPartner;

		private Zone oZone;
		private PermitLevel oPermitLevel;

		private PrintForm oPrintForm;

		private bool bNoEdit = false;
		
		private bool bLoaded = false;

        protected string fileDrivingSchemePath = "";
        protected bool bClearDrivingScheme = false;


		public frmPartnersEdit(int? _nPartnerID)
		{
			if (_nPartnerID.HasValue)
			{
				nPartnerID = (int)_nPartnerID;
			}

			oPartner = new Partner();
			if (oPartner.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oZone = new Zone();
				oPermitLevel = new PermitLevel();
				
				if (oZone.ErrorNumber != 0 ||
					oPermitLevel.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPrintForm = new PrintForm ();
				if (oPrintForm.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		public frmPartnersEdit(int? _nPartnerID, bool _bNoEdit) : this(_nPartnerID)
		{
			bNoEdit = _bNoEdit;
		}

		private void frmPartnersEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			oPartner.ID = nPartnerID;

			// классификаторы
            bResult = cboZone_Restore() && cboPermitLevel_Restore(); /*&& cboPartnerRoot_Restore();*/
			if (bResult)
			{
				cboPartnerRoot.SelectedIndex =
				cboZone.SelectedIndex =
				cboPermitLevel.SelectedIndex =
					-1;
				
				if (nPartnerID.HasValue && (int)nPartnerID != 0)
				{
					// существующий клиент
					bResult = oPartner.ReFillOne((int)nPartnerID) && (oPartner.ErrorNumber == 0);
					if (bResult)
					{
						Text += " (код " + nPartnerID.ToString() + ")";

						txtNаme.Text = oPartner.Name;
						chkActual.Checked = oPartner.Actual;
						chkIsCustomer.Checked = oPartner.IsCustomer;
						chkIsSupplier.Checked = oPartner.IsSupplier;
						chkIsTransport.Checked = oPartner.IsTransport;
						chkIsOwner.Checked = oPartner.IsOwner;
						chkSeparatePicking.Checked = oPartner.SeparatePicking;
						chkIsOwner_CheckedChanged(null, null);

						txtContactsInfo.Text = oPartner.ContactsInfo;

						if (oPartner.PartnerRootID.HasValue)
							cboPartnerRoot.SelectedValue = oPartner.PartnerRootID;
						if (oPartner.ZoneID.HasValue)
							cboZone.SelectedValue = oPartner.ZoneID;
						if (oPartner.PermitLevelID.HasValue)
							cboPermitLevel.SelectedValue = oPartner.PermitLevelID;

						txtDeliveryAddress.Text = oPartner.DeliveryAddress;
						txtDeliveryPassage.Text = oPartner.DeliveryPassage;
						txtDeliveryRestriction.Text = oPartner.DeliveryRestriction;

						txtGravity.Text = oPartner.Gravity;

						txtNote.Text = oPartner.Note;

						// CoordinatesX, CoordinatesY
                        txtLatitude.Text = (oPartner.Latitude.HasValue ? oPartner.Latitude.ToString() : "");
                        txtLongitude.Text = (oPartner.Longitude.HasValue ? oPartner.Longitude.ToString() : "");

                        numDistance.Value = oPartner.Distance;

						chkPassengerCarOnly.Checked = oPartner.PassengerCarOnly;
						chkPosternOnly.Checked = oPartner.PosternOnly;
						chkLoadLiftOnly.Checked = oPartner.LoadLiftOnly;

						//  покажем верхнюю запись из PartnersDetail
						oPartner.FillTablePartnersDetails((int)oPartner.ID);
						if (oPartner.TablePartnersDetails.Rows.Count > 0)
						{
							DataRow p = oPartner.TablePartnersDetails.Rows[0];
							
							txtLegalName.Text = p["LegalName"].ToString();
							txtLegalAddress.Text = p["LegalAddress"].ToString();
							txtFactName.Text = p["FactName"].ToString();
							txtFactAddress.Text = p["FactAddress"].ToString();
							txtPhone.Text = p["Phone"].ToString();
							txtInn.Text = p["Inn"].ToString();
							txtKpp.Text = p["Kpp"].ToString();

							txtContractNumber.Text = p["ContractNumber"].ToString();
							if (!Convert.IsDBNull(p["ContractDate"]))
								dtpContractDate.Value = Convert.ToDateTime(p["ContractDate"]);
							else
								dtpContractDate.HideControl(false);

							txtBankName.Text = p["BankName"].ToString();
							txtBankAddress.Text = p["BankAddress"].ToString();
							txtPAccount.Text = p["PAccount"].ToString();
							txtCAccount.Text = p["CAccount"].ToString();
							txtBik.Text = p["Bik"].ToString();
							txtOkonh.Text = p["Okonh"].ToString();
							txtOkpo.Text = p["Okpo"].ToString();

							txtJobTitleDirector.Text = p["JobTitleDirector"].ToString();
							txtFioDirector.Text = p["FioDirector"].ToString();
							txtJobTitleAccountant.Text = p["JobTitleAccountant"].ToString();
							txtFioAccountant.Text = p["FioAccountant"].ToString();
						}
						//

						// стр.Дополнительно
						chkDateValidControl.Checked = oPartner.DateValidControl;
						chkPalletsAgreement.Checked = oPartner.PalletsAgreement;
						chkFactPaymentOnly.Checked = oPartner.FactPaymentOnly;

						txtTimeWork.Text = oPartner.TimeWork;
						txtTimeReceipt.Text = oPartner.TimeReceipt;
						txtTimePay.Text = oPartner.TimePay;
						txtTimeRest.Text = oPartner.TimeRest;
						numStayMinutes.Value = oPartner.StayMinutes;

						// стр.Шаблоны
						if (oPartner.PF_BillName != null && oPartner.PF_BillName.Length > 0)
							txtPF_BillName.Text = oPartner.PF_BillName;
						numPF_BillCopiesCount.Value = oPartner.PF_BillCopiesCount;
						chkPF_Bill.Checked = txtPF_BillName.Text.Trim().Length > 0 || numPF_BillCopiesCount.Value > 0;
						if (oPartner.PF_FactureName != null && oPartner.PF_FactureName.Length > 0)
							txtPF_FactureName.Text = oPartner.PF_FactureName;
						numPF_FactureCopiesCount.Value = oPartner.PF_FactureCopiesCount;
						chkPF_Facture.Checked = txtPF_FactureName.Text.Trim().Length > 0 || numPF_FactureCopiesCount.Value > 0;
						if (oPartner.PF_PayBillName != null && oPartner.PF_PayBillName.Length > 0)
							txtPF_PayBillName.Text = oPartner.PF_PayBillName;
						numPF_PayBillCopiesCount.Value = oPartner.PF_PayBillCopiesCount;
						chkPF_PayBill.Checked = txtPF_PayBillName.Text.Trim().Length > 0 || numPF_PayBillCopiesCount.Value > 0;

						txtShopCode.Text = oPartner.ShopCode;

                        // стр.Ветеринария
                        txtVeterinaryPartnerName.Text = oPartner.VeterinaryPartnerName;
                        txtVeterinaryPermission.Text = oPartner.VeterinaryPermission;

						// not used
						/*
						chkFactureNeed.Checked = oPartner.FactureNeed;
						chkWarrantNeed.Checked = oPartner.WarrantNeed;
						chkPaymentOrderNeed.Checked = oPartner.PaymentOrderNeed;
						chkOtherDocumentsNeed.Checked = oPartner.OtherDocumentsNeed;
						chkQualityLicenceNeed.Checked = oPartner.QualityLicenceNeed;
						chkVeterinaryLicenceNeed.Checked = oPartner.VeterinaryLicenceNeed;
						*/
					}

                    if (oPartner.DrivingScheme != null && !Convert.IsDBNull(oPartner.DrivingScheme))
                    {
                        byte[] bsPhoto = oPartner.DrivingScheme;
                        MemoryStream ms = new MemoryStream(bsPhoto);
                        try
                        {
                            picDrivingScheme.Image = new Bitmap(ms);
                        }
                        catch (Exception ex)
                        {
                            RFMMessage.MessageBoxError("Ошибка загрузки схемы проезда: " + ex.Message);
                        }
                    }
                }
				else
				{
					// новый клиент
					chkActual.Checked = true;
				}

				// только просмотр
				if (bNoEdit)
				{
					RFMPanelGlass pnlGlass = new RFMPanelGlass();
					pnlGlass.Top = pnlData.Top;
					pnlGlass.Left = pnlData.Left;
					pnlGlass.Width = pnlData.Width;
					pnlGlass.Height = pnlData.Height;
					Controls.Add(pnlGlass);
					pnlGlass.BringToFront();

					btnSave.Select();
					btnSave.Enabled = false;
					Text += " - просмотр";
				}
				else
				{ 
					// доступность полей
					DBTable dbTable = new DBTable();
					foreach(Control oControlTemp in Controls)
					{
						ControlEnable(dbTable, oControlTemp);  
					}
				}

				chkPF_Bill_CheckedChanged(null, null);
				chkPF_Facture_CheckedChanged(null, null);
				chkPF_PayBill_CheckedChanged(null, null);
			}

			if (!bResult)
			{
				Dispose();
			}

			bLoaded = true;
		}

		private void ControlEnable(DBTable dbTable, Control oControl)
		{
			if (oControl.Controls.Count > 0)
			{
				foreach (Control oControlIn in oControl.Controls)
				{
					ControlEnable(dbTable, oControlIn);
				}
			}
			else
			{
				if (oControl.Enabled)
				{
					if (oControl is RFMTextBox ||
						oControl is RFMComboBox ||
						oControl is RFMCheckBox ||
						oControl is RFMNumericUpDown ||
						oControl is RFMDateTimePicker)
					{
						string sColumnName = oControl.Name.Substring(3);
						if (oControl.Name.Substring(0, 3) == "cbo")
							sColumnName += "ID";

                        oControl.Enabled = !dbTable.IsFieldInExchange("Partners", sColumnName);
					}
				}
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

        private void btnShowPartnerOnMap_Click(object sender, EventArgs e)
        {
            frmShowMap frmShowMap = new frmShowMap(oPartner);
            if (frmShowMap != null)
            {
                // Отображение карты
                StartForm(frmShowMap);

                // Переотображение данных о координатах и расстоянии
                // Эти данные переприсваиваются в форме frmShowMap!
                if (oPartner.Longitude.HasValue) txtLongitude.Text = oPartner.Longitude.ToString();
                if (oPartner.Latitude.HasValue) txtLatitude.Text = oPartner.Latitude.ToString();
                if (oPartner.Distance > 0) numDistance.Value = oPartner.Distance;
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sName = txtNаme.Text.Trim();

			// проверки 
			if (sName.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указано наименование...");
				txtNаme.Select();
				return;
			}
			if (cboZone.SelectedValue == null || cboZone.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указана зона расположения клиента...");
				cboZone.Select();
				return;
			}

			// уникальность названия
            // Проверка отменена 22.04.2009 в связи с большим количеством двойников у Тимакса
            /*
			WaitOn(this);
			Partner oPartnerTemp = new Partner();
			oPartner.FilterNameContext = sName;
			oPartnerTemp.FillData();
			foreach(DataRow dr in oPartnerTemp.MainTable.Rows)
			{
				if (nPartnerID == null || nPartnerID != Convert.ToInt32(dr["ID"]))
				{
					if (sName.ToUpper() == dr["Name"].ToString().Trim().ToUpper())
					{
						WaitOff(this);
						RFMMessage.MessageBoxError("Партнер с таким названием уже есть...");
						txtNаme.Select();
						return;
					}
				}
			}
			WaitOff(this);
            */

			// актуальность
			if (!chkActual.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("Сохранить данные о неактуальном партнере?") != DialogResult.Yes)
				{
					chkActual.Select();
					return;
				}
			}

			// шаблоны печ.форм. если заданы - есть ли такие шаблоны?
			if (chkPF_Bill.Checked)
			{
				if (txtPF_BillName.Text.Trim().Length == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не задан шаблон накладной...\nСохранить без указания шаблона?") != DialogResult.Yes)
					{
						txtPF_BillName.Select();
						return;
					}
				}
				else
				{
					if (!CheckPF_Form(txtPF_BillName.Text.Trim(), "PF_Bill", "накладной"))
						return;
				}
			}

			if (chkPF_Facture.Checked)
			{
				if (txtPF_FactureName.Text.Trim().Length == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не задан шаблон счета-фактуры...\nСохранить без указания шаблона?") != DialogResult.Yes)
					{
						txtPF_FactureName.Select();
						return;
					}
				}
				else
				{
					if (!CheckPF_Form(txtPF_FactureName.Text.Trim(), "PF_Facture", "счета-фактуры"))
						return;
				}
			}

			if (chkPF_PayBill.Checked)
			{
				if (txtPF_PayBillName.Text.Trim().Length == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не задан шаблон счета на оплату...\nСохранить без указания шаблона?") != DialogResult.Yes)
					{
						txtPF_PayBillName.Select();
						return;
					}
				}
				else
				{
					if (!CheckPF_Form(txtPF_PayBillName.Text.Trim(), "PF_PayBill", "счета на оплату"))
						return;
				}
			}

            // собираем данные в свойства объекта oPartner
			oPartner.Name = txtNаme.Text.Trim();

			oPartner.Actual = chkActual.Checked;
			oPartner.IsCustomer = chkIsCustomer.Checked;
			oPartner.IsSupplier = chkIsSupplier.Checked;
			oPartner.IsTransport = chkIsTransport.Checked;
			oPartner.IsOwner = chkIsOwner.Checked;
			if (oPartner.IsOwner)
				oPartner.SeparatePicking = chkSeparatePicking.Checked;
			else
				oPartner.SeparatePicking = false;

			oPartner.ContactsInfo = txtContactsInfo.Text;

			if (cboPartnerRoot.SelectedIndex >= 0 && cboPartnerRoot.SelectedValue != null)
				oPartner.PartnerRootID = (int)cboPartnerRoot.SelectedValue;
			else
				oPartner.PartnerRootID = null;
			if (cboZone.SelectedIndex >= 0 && cboZone.SelectedValue != null)
				oPartner.ZoneID = (int)cboZone.SelectedValue;
			else
				oPartner.ZoneID = null;

			oPartner.DeliveryAddress = txtDeliveryAddress.Text;
			oPartner.DeliveryPassage = txtDeliveryPassage.Text;
			oPartner.DeliveryRestriction = txtDeliveryRestriction.Text;

			oPartner.Gravity = txtGravity.Text;

			// CoordinatesX, CoordinatesY
            // Географические координаты должны сохраняться только парно!
            if (txtLatitude.Text.Length > 0 && txtLongitude.Text.Length > 0)
            {
                oPartner.Latitude = Convert.ToDecimal(txtLatitude.Text);
                oPartner.Longitude = Convert.ToDecimal(txtLongitude.Text);
            }
            else
            {
                oPartner.Latitude = null;
                oPartner.Longitude = null;
            }

            oPartner.Distance = (int)numDistance.Value;

			oPartner.PassengerCarOnly = chkPassengerCarOnly.Checked;
			oPartner.PosternOnly = chkPosternOnly.Checked;
			oPartner.LoadLiftOnly = chkLoadLiftOnly.Checked;

			oPartner.DateValidControl = chkDateValidControl.Checked;
			oPartner.PalletsAgreement = chkPalletsAgreement.Checked;
			oPartner.FactPaymentOnly = chkFactPaymentOnly.Checked;

			oPartner.ContactsInfo = txtContactsInfo.Text;

			oPartner.Note = txtNote.Text;

			/*
			oPartner.FactureNeed = chkFactureNeed.Checked;
			oPartner.WarrantNeed = chkWarrantNeed.Checked;
			oPartner.PaymentOrderNeed = chkPaymentOrderNeed.Checked;
			oPartner.OtherDocumentsNeed = chkOtherDocumentsNeed.Checked;
			oPartner.QualityLicenceNeed = chkQualityLicenceNeed.Checked;
			oPartner.VeterinaryLicenceNeed = chkVeterinaryLicenceNeed.Checked;
			*/

			// стр.Дополнительно
			oPartner.TimeWork = txtTimeWork.Text;
			oPartner.TimeReceipt = txtTimeReceipt.Text;
			oPartner.TimePay = txtTimePay.Text;
			oPartner.TimeRest = txtTimeRest.Text;
			oPartner.StayMinutes = (int)numStayMinutes.Value;

			// стр.Шаблоны
			if (chkPF_Bill.Checked)
			{
				oPartner.PF_BillName = txtPF_BillName.Text.Trim();
				oPartner.PF_BillCopiesCount = (int)numPF_BillCopiesCount.Value;
			}
			else
			{
				oPartner.PF_BillName = "";
				oPartner.PF_BillCopiesCount = 0;
			}
			if (chkPF_Facture.Checked)
			{
				oPartner.PF_FactureName = txtPF_FactureName.Text.Trim();
				oPartner.PF_FactureCopiesCount = (int)numPF_FactureCopiesCount.Value;
			}
			else
			{
				oPartner.PF_FactureName = "";
				oPartner.PF_FactureCopiesCount = 0;
			}
			if (chkPF_PayBill.Checked)
			{
				oPartner.PF_PayBillName = txtPF_PayBillName.Text.Trim();
				oPartner.PF_PayBillCopiesCount = (int)numPF_PayBillCopiesCount.Value;
			}
			else
			{
				oPartner.PF_PayBillName = "";
				oPartner.PF_PayBillCopiesCount = 0;
			}
			oPartner.ShopCode = txtShopCode.Text.Trim();

            oPartner.VeterinaryPartnerName = txtVeterinaryPartnerName.Text.Trim();
            oPartner.VeterinaryPermission = txtVeterinaryPermission.Text.Trim();

			/*
			oPartner.LegalName = txtLegalName.Text;
			oPartner.LegalAddress = txtLegalAddress.Text;
			oPartner.FactName = txtFactName.Text;
			oPartner.FactAddress = txtFactAddress.Text;
			oPartner.Phone = txtPhone.Text;
			oPartner.Inn = txtInn.Text;
			oPartner.Inn = txtKpp.Text;

			oPartner.ContractNumber = txtContractNumber.Text;
			if (!dtpContractDate.IsEmpty)
				oPartner.ContractDate = dtpContractDate.Value;
			else
				oPartner.ContractDate = null;

			oPartner.BankName = txtBankName.Text;
			oPartner.BankAddress = txtBankAddress.Text;
			oPartner.PAccount = txtPAccount.Text;
			oPartner.CAccount = txtCAccount.Text;
			oPartner.Bik = txtBik.Text;
			oPartner.Okonh = txtOkonh.Text;
			oPartner.Okpo = txtOkpo.Text;

			oPartner.JobTitleDirector = txtJobTitleDirector.Text;
			oPartner.FioDirector = txtFioDirector.Text;
			oPartner.JobTitleAccountant = txtJobTitleAccountant.Text;
			oPartner.FioAccountant = txtFioAccountant.Text;
			*/

			// собственно сохранение 
			oPartner.SaveOne();
			if (oPartner.ErrorNumber == 0)
			{
				// код добавленной записи 
				if ((!nPartnerID.HasValue || nPartnerID == 0) && oPartner.ID.HasValue && oPartner.ID != null)
				{
					nPartnerID = (int)oPartner.ID;
				}


                // сохранить фото
                if (fileDrivingSchemePath != "")
                {
                    FileStream fs = new FileStream(fileDrivingSchemePath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    oPartner.DrivingScheme = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                    oPartner.SaveOneDrivingScheme();
                }
                else
                {
                    if (bClearDrivingScheme)
                    {
                        oPartner.DrivingScheme = null;
                        oPartner.SaveOneDrivingScheme();
                    }
                }
                
                if (nPartnerID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nPartnerID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

        private void linkStartYandexOnBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://maps.yandex.ru/");
        }

		#region Restore

		private bool cboPartnerRoot_Restore()
		{
			cboPartnerRoot.DataSource = null;
			oPartner.ClearError();
			if (oPartner.FillTablePartnersRoots())
			{
				cboPartnerRoot.Restore(oPartner.TablePartnersRoots, 
					oPartner.TablePartnersRoots.Columns[1].ColumnName, 
					oPartner.TablePartnersRoots.Columns[0].ColumnName);
			}
			return (oPartner.ErrorNumber == 0);
		}

		private bool cboZone_Restore()
		{
			cboZone.DataSource = null;
			oZone.ClearError();
			if (oZone.FillData())
			{
				cboZone.DataSource = new DataView(oZone.MainTable);
				cboZone.ValueMember = oZone.ColumnID;
				cboZone.DisplayMember = oZone.ColumnName;
				cboZone.Restore();
			}
			return (oZone.ErrorNumber == 0);
		}

		private bool cboPermitLevel_Restore()
		{
			cboPermitLevel.DataSource = null;
			oPermitLevel.ClearError();
			if (oPermitLevel.FillData())
			{
				cboPermitLevel.DataSource = new DataView(oPermitLevel.MainTable);
				cboPermitLevel.ValueMember = oPermitLevel.ColumnID;
				cboPermitLevel.DisplayMember = oPermitLevel.ColumnName;
				cboPermitLevel.Restore();
			}
			return (oPermitLevel.ErrorNumber == 0);
		}

		#endregion Restore

		#region Combo

		private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!bLoaded)
				return;

			if (cboZone.SelectedIndex < 0 || cboZone.SelectedValue == null)
			{
				cboPermitLevel.SelectedIndex = -1;
			}
			else
			{
				foreach (DataRow r in oZone.MainTable.Rows)
				{
					if ((int)r["ID"] == (int)cboZone.SelectedValue)
					{
						cboPermitLevel.SelectedValue = (int)r["PermitLevelID"];
						break; 
					}
				}
			}
		}

		#endregion Combo

		private void chkIsOwner_CheckedChanged(object sender, EventArgs e)
		{
			if (chkIsOwner.Checked)
			{
				chkSeparatePicking.Enabled = true;
			}
			else
			{
				chkSeparatePicking.Enabled = false;
				chkSeparatePicking.Checked = false;
			}
		}

		#region PF_checkers

		private void chkPF_Bill_CheckedChanged(object sender, EventArgs e)
		{
			if (chkPF_Bill.Checked)
			{
				txtPF_BillName.Enabled =
				numPF_BillCopiesCount.Enabled =
					true;
			}
			else
			{
				txtPF_BillName.Text = "";
				txtPF_BillName.Enabled =
				numPF_BillCopiesCount.Enabled =
					false;
			}
		}

		private void chkPF_Facture_CheckedChanged(object sender, EventArgs e)
		{
			if (chkPF_Facture.Checked)
			{
				txtPF_FactureName.Enabled =
				numPF_FactureCopiesCount.Enabled =
					true;
			}
			else
			{
				txtPF_FactureName.Text = "";
				txtPF_FactureName.Enabled =
				numPF_FactureCopiesCount.Enabled =
					false;
			}
		}

		private void chkPF_PayBill_CheckedChanged(object sender, EventArgs e)
		{
			if (chkPF_PayBill.Checked)
			{
				txtPF_PayBillName.Enabled =
				numPF_PayBillCopiesCount.Enabled =
					true;
			}
			else
			{
				txtPF_PayBillName.Text = "";
				txtPF_PayBillName.Enabled =
				numPF_PayBillCopiesCount.Enabled =
					false;
			}
		}

		private bool CheckPF_Form(string sPF_BillName, string sPF_BillType, string sPF_Type_Text)
		{
			oPrintForm.ClearFilters();
			oPrintForm.FilterPF_Name = sPF_BillName;
			oPrintForm.FilterPF_Type = sPF_BillType;
			oPrintForm.FillData();
			if (oPrintForm.ErrorNumber != 0 || oPrintForm.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о печатных формах...");
				return (false);
			}
			if (oPrintForm.MainTable.Rows.Count == 0)
			{
				if (RFMMessage.MessageBoxYesNo("ВНИМАНИЕ!\n\n" +
						"В списке шаблонов печатных форм не найден шаблон \"" + sPF_BillName + "\" (тип " + sPF_BillType + ")...\n\n" +
						"Все-таки сохранить данные?") != DialogResult.Yes)
					return (false);
			}
			return (true);
		}

		#endregion PF_checkers

        private void btnLoadDrivingScheme_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Загрузить схему проезда";
            dlg.Filter = "Изображения JPEG (*.jpg)|*.jpg" +
                            "|Изображения PNG (*.png)|*.png" + 
                            "|Все файлы (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileDrivingSchemePath = dlg.FileName;
                    picDrivingScheme.Image = new Bitmap(dlg.OpenFile());
                }
                catch (Exception ex)
                {
                    RFMMessage.MessageBoxError("Ошибка загрузки схемы проезда: " + ex.Message);
                }
            }
            dlg.Dispose();
        }

        private void btnClearDrivingScheme_Click(object sender, EventArgs e)
        {
            fileDrivingSchemePath = "";
            bClearDrivingScheme = true;
            picDrivingScheme.Image = null;
        }
	}
}
