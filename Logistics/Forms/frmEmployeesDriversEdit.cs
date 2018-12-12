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
	public partial class frmEmployeesDriversEdit : RFMFormChild
	{
		private int? nEmployeeID = null;
		private Employee oEmployee; 
		private Driver oDriver; 
		protected string filePhotoPath = "";
		protected bool bClearPhoto = false;

		// ��� cbo
		private Car oCar;
		private Zone oZone;


		public frmEmployeesDriversEdit(int? _nEmployeeID)
		{
			if (_nEmployeeID.HasValue)
			{
				nEmployeeID = (int)_nEmployeeID;
			}

			oEmployee = new Employee();
			oDriver = new Driver();
			if (oEmployee.ErrorNumber != 0 ||
				oDriver.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (isValid)
			{
				oCar = new Car();
				oZone = new Zone();
				if (oCar.ErrorNumber != 0 ||
					oZone.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmEmployeesDriversEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			oEmployee.ID = oDriver.ID = nEmployeeID;

			// ��������������.
			bResult = cboJobTitle_Restore() &&
						cboCar_Restore() &&
						cboZone_Restore();

			if (bResult)
			{
				if (nEmployeeID.HasValue && nEmployeeID != 0)
				{
					// ������������ ������������
					bResult = oEmployee.ReFillOne((int)nEmployeeID) && (oEmployee.ErrorNumber == 0);

					if (bResult)
					{
						Text += " (" + nEmployeeID.ToString() + ")";

						txtN�me.Text = oEmployee.Name;
						txtAlias.Text = oEmployee.Alias;
						txtPassportSeries.Text = oEmployee.PassportSeries;
						txtPassportNumber.Text = oEmployee.PassportNumber;
						if (oEmployee.PassportDate.HasValue)
						{
							dtpPassportDate.Value = Convert.ToDateTime(oEmployee.PassportDate);
						}
						else
						{
							dtpPassportDate.Value = DateTime.Now.Date;
							dtpPassportDate.HideControl(false);
						}
						txtPassportGranted.Text = oEmployee.PassportGranted;
						if (oEmployee.JobTitleID.HasValue)
							cboJobTitle.SelectedValue = oEmployee.JobTitleID;
						else
							cboJobTitle.SelectedIndex = -1;
						txtMobPhone.Text = oEmployee.MobPhone;

						chkPassConfirmAllowed.Checked = oEmployee.PassConfirmAllowed;
						chkActual.Checked = oEmployee.Actual;

						// ����
						if (oEmployee.Photo != null && !Convert.IsDBNull(oEmployee.Photo))
						{
							byte[] bsPhoto = oEmployee.Photo;
							MemoryStream ms = new MemoryStream(bsPhoto);
							try
							{
								picPhoto.Image = new Bitmap(ms);
							}
							catch (Exception ex)
							{
								RFMMessage.MessageBoxError("������ �������� ����: " + ex.Message);
							}
						}

						// ��������
						if (oEmployee.IsDriver)
						{
							chkIsDriver.Checked = true;
							chkIsDriver_CheckedChanged(null, null);

							bResult = oDriver.ReFillOne((int)nEmployeeID) && (oDriver.ErrorNumber == 0);
							if (bResult)
							{
								chkForGoodsOnly.Checked = oDriver.ForGoodsOnly;
								chkOperable.Checked = oDriver.Operable;
								txtDriverCategory.Text = oDriver.DriverCategory;
								txtDriverLicenceNumber.Text = oDriver.DriverLicenceNumber;
								if (oDriver.CarID.HasValue)
								{
									cboCar.SelectedValue = oDriver.CarID;
								}
								else
								{
									cboCar.SelectedIndex = -1;
								}
								if (oDriver.ZoneID.HasValue)
								{
									cboZone.SelectedValue = oDriver.ZoneID;
								}
								else
								{
									cboZone.SelectedIndex = -1;
								}
							}
						}
						else
						{
							chkIsDriver.Checked = false;

							cboCar.SelectedIndex = -1;
							cboZone.SelectedIndex = -1;
						}
					}
				}
				else
				{
					// ����� ���������
					chkActual.Checked = true;
					cboJobTitle.SelectedIndex = -1;

					dtpPassportDate.Value = DateTime.Now.Date;
					dtpPassportDate.HideControl(false);

					chkIsDriver.Checked = false;

					cboCar.SelectedIndex = -1;
					cboZone.SelectedIndex = -1;
				}
				chkIsDriver_CheckedChanged(null, null);
			}

			if (!bResult)
			{
				Dispose();
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
			if (txtN�me.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("������� ������ ��� ����������!");
				txtN�me.Select();
				return;
			}
			if (txtAlias.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("������� ������� ��� ����������!");
				txtAlias.Select();
				return;
			}
			if (txtN�me.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("������� ��� ���������� � ����������!");
				txtN�me.Select();
				return;
			}
			/*
			if (cboJobTitle.SelectedValue == null || cboJobTitle.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("������� ��������� ����������!");
				cboJobTitle.Select();
				return;
			}
			*/ 

			// ������������
			if (!chkActual.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("��������� ������ � ������������ ����������?") != DialogResult.Yes)
				{
					chkActual.Select();
					return;
				}
			}

			// ������ - �� ����������� �� 
			if (chkIsDriver.Checked && 
				cboCar.SelectedValue != null && cboCar.SelectedIndex >= 0) 
			{
				int nCarID = (int)cboCar.SelectedValue;
				Driver oDriverTemp = new Driver();
				oDriverTemp.FilterActual = true;
				oDriverTemp.FilterCarsList = nCarID.ToString();
				oDriverTemp.FillData(); 
				if (oDriverTemp.ErrorNumber == 0 && oDriverTemp.MainTable.Rows.Count > 0)
				{
					foreach (DataRow dr in oDriverTemp.MainTable.Rows)
					{ 
						if (oEmployee.ID.HasValue && Convert.ToInt32(dr["ID"]) == (int)oEmployee.ID)
						{
							continue;
						}
						RFMPublic.RFMMessage.MessageBoxError("�� �� ������ ���������������� �� ��������� " + dr["Name"].ToString() + "!");
						cboCar.Select();
						return;
					}
				}
			}

			oEmployee.Name = txtN�me.Text.Trim();
			oEmployee.Alias = txtAlias.Text.Trim();
			oEmployee.PassportSeries = txtPassportSeries.Text.Trim();
			oEmployee.PassportNumber = txtPassportNumber.Text.Trim();
			oEmployee.PassportGranted = txtPassportGranted.Text.Trim();
			if (!dtpPassportDate.IsEmpty)
			{
				oEmployee.PassportDate = dtpPassportDate.Value.Date;
			}
			else
			{
				oEmployee.PassportDate = null;
			}
			if (cboJobTitle.SelectedValue != null && cboJobTitle.SelectedIndex >= 0)
				oEmployee.JobTitleID = (int)cboJobTitle.SelectedValue;
			else
				oEmployee.JobTitleID = null;
			oEmployee.MobPhone = txtMobPhone.Text.Trim();
			oEmployee.PassConfirmAllowed = chkPassConfirmAllowed.Checked;
			oEmployee.Actual = chkActual.Checked;

			oEmployee.ClearError();
			oEmployee.SaveOne();

			if (oEmployee.ErrorNumber == 0)
			{
				// ��� ����������� ������ 
				if ((!nEmployeeID.HasValue || nEmployeeID == 0) && oEmployee.ID.HasValue && oEmployee.ID != null)
				{
					nEmployeeID = (int)oEmployee.ID;
				}

				if (nEmployeeID.HasValue)
				{
					nEmployeeID = oEmployee.ID;

					// ����
					if (filePhotoPath != "")
					{
						FileStream fs = new FileStream(filePhotoPath, FileMode.Open, FileAccess.Read);
						BinaryReader br = new BinaryReader(fs);
						oEmployee.Photo = br.ReadBytes((int)fs.Length);
						br.Close();
						fs.Close();
						oEmployee.SaveOnePhoto();
					}
					else
					{
						if (bClearPhoto)
						{
							oEmployee.Photo = null;
							oEmployee.SaveOnePhoto();
						}
					}

					if (oEmployee.ErrorNumber == 0)
					{
						// ��������?
						if (chkIsDriver.Checked)
						{
							// ��������� �������� ��������� 
							// ��������/�������� ������ � �������� ��� ����������� ����������
							oDriver.ID = nEmployeeID;
							oDriver.Operable = chkOperable.Checked;
							oDriver.ForGoodsOnly = chkForGoodsOnly.Checked;
							oDriver.DriverCategory = txtDriverCategory.Text.Trim();
							oDriver.DriverLicenceNumber = txtDriverLicenceNumber.Text.Trim();
							if (cboCar.SelectedValue != null && cboCar.SelectedIndex >= 0)
							{
								oDriver.CarID = (int)cboCar.SelectedValue;
							}
							else
							{
								oDriver.CarID = null;
							}
							if (cboZone.SelectedValue != null && cboZone.SelectedIndex >= 0)
							{
								oDriver.ZoneID = (int)cboZone.SelectedValue;
							}
							else
							{
								oDriver.ZoneID = null;
							}

							oDriver.ClearError();
							oDriver.SaveOneDriver();
						}
						else
						{
							// ��������� ��� ���������, �� ������ �� �� ��������
							// ������� ������ � �������� ��� ����������� ����������
							if (oDriver.IsDriver)
							{
								oDriver.ID = nEmployeeID;
								oDriver.DeleteOneDriver((int)nEmployeeID);
							}
						}
					}
				}
			}

			if (oEmployee.ErrorNumber == 0 && nEmployeeID.HasValue)
			{
				MotherForm.GotParam = new object[] { (int)nEmployeeID };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		private void chkIsDriver_CheckedChanged(object sender, EventArgs e)
		{
			pnlDriver.Enabled = chkIsDriver.Checked;
		}

		#region Restore

		private bool cboJobTitle_Restore()
		{
			cboJobTitle.DataSource = null;
			oEmployee.ClearError();
			if (oEmployee.FillTableJobTitles())
			{
				cboJobTitle.DataSource = new DataView(oEmployee.TableJobTitles);
				cboJobTitle.ValueMember = oEmployee.TableJobTitles.Columns[0].ColumnName;
				cboJobTitle.DisplayMember = oEmployee.TableJobTitles.Columns[1].ColumnName;
				cboJobTitle.Restore();
			}
			return (oEmployee.ErrorNumber == 0);
		}

		private bool cboCar_Restore()
		{
			cboCar.DataSource = null;
			oCar.ClearError();
			if (oCar.FillData())
			{
				cboCar.DataSource = new DataView(oCar.MainTable);
				cboCar.ValueMember = oCar.ColumnID;
				cboCar.DisplayMember = oCar.ColumnName;
				cboCar.Restore();
			}
			return (oCar.ErrorNumber == 0);
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

		#endregion Restore

		#region Photo

		private void btnLoadPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "��������� ����";
			dlg.Filter = "����������� JPEG (*.jpg)|*.jpg" + 
							"|��� ����� (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					filePhotoPath = dlg.FileName;
					picPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (Exception ex)
				{
					RFMMessage.MessageBoxError("������ �������� ����: " + ex.Message);
				}
			}
			dlg.Dispose();
		}

		private void btnClearPhoto_Click(object sender, EventArgs e)
		{
			filePhotoPath = "";
			bClearPhoto = true;
			picPhoto.Image = null;
		}

		#endregion Photo

		private void txtN�me_Validated(object sender, EventArgs e)
		{
			string sAlias = "";
			if (txtN�me.Text.Trim().Length > 0 && txtAlias.Text.Trim().Length == 0)
			{
				string sStr = txtN�me.Text.Trim() + " ";
				sAlias = sStr.Substring(0, sStr.IndexOf(" "));
				sStr = sStr.Substring(sStr.IndexOf(" "), sStr.Length - sAlias.Length);
				string[] sStrs = sStr.Trim().Split(' ');
				foreach (string sString in sStrs)
				{
					if (sString.Length > 0)
					{
						sAlias += " " + sString.Substring(0, 1).ToUpper();
					}
				}

				if (sAlias.Length > 0)
				{
					txtAlias.Text = sAlias.Trim();
				}
			}
		}


	}
}
