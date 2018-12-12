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
	public partial class frmUsersEdit : RFMFormChild
	{
		private int ID;
		private User oUser;
		private Employee oEmployee;
		private Host oHost;

		protected string filePhotoPath = "";
		protected bool bClearPhoto = false;


		public frmUsersEdit(int? _ID)
		{
			if (_ID.HasValue)
			{
				ID = (int)_ID;
			}

			oUser = new User();
			if (oUser.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oEmployee = new Employee();
				if (oEmployee.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oHost = new Host();
				if (oHost.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmUsersEdit_Load (object sender, EventArgs e)
		{
			cboHost.Enabled = (oHost.Count() > 1);

			bool bResult = cboEmployee_Restore() && cboHost_Restore();

			if (bResult)
			{
				oUser.ID = ID;
				oUser.FillDataAsync();
				if (oUser.ErrorNumber != 0 || oUser.MainTable == null)
				{
					//RFMMessage.MessageBoxError("Ошибка при получении данных о пользователе...");
					bResult = false;
				}
			}

			if (bResult)
			{
				if (ID != 0 && oUser.MainTable.Rows.Count != 1)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о пользователе...");
					bResult = false;
				}
			}

			if (bResult)
			{
				if (!dgvUserRoles_Restore())
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о ролях...");
					bResult = false;
				}
			}

			if (bResult)
			{
				if (!((RFMFormMain)Application.OpenForms[0]).UserInfo.UserIsAdmin)
				{
					txtPassword.PasswordChar = '*';
					chkIsAdmin.Enabled = false;
					cboEmployee.SelectedIndex =
					cboHost.SelectedIndex = 
						-1;  
				}

				if (ID != 0)
				{
					// существующий пользователь
					oUser.FillOne();
					txtUserNаme.Text = oUser.Name;
					txtPassword.Text = oUser.Password;
					txtAlias.Text = oUser.Alias;
					txtLocPath.Text = oUser.LocPath;
					txtNetPath.Text = oUser.NetPath;
					chkIsAdmin.Checked = oUser.IsAdmin;
					chkActual.Checked = oUser.Actual;
					if (oUser.EmployeeID.HasValue)
						cboEmployee.SelectedValue = (int)oUser.EmployeeID;
					else
						cboEmployee.SelectedIndex = -1;
					if (oUser.HostID.HasValue)
						cboHost.SelectedValue = (int)oUser.HostID;
					else
						cboHost.SelectedIndex = -1;

					if (oUser.Photo != null && !Convert.IsDBNull(oUser.Photo))
					{
						byte[] bsPhoto = oUser.Photo;
						MemoryStream ms = new MemoryStream(bsPhoto);
						try
						{
							picPhoto.Image = new Bitmap(ms);
						}
						catch (Exception ex)
						{
							RFMMessage.MessageBoxError("Ошибка загрузки фото: " + ex.Message);
						}
					}
				}
				else
				{
					cboEmployee.SelectedIndex = 
					cboHost.SelectedIndex = 
						-1;
				}
			}
			else
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
			if (txtUserNаme.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("Укажите имя пользователя!");
				txtUserNаme.Select();
				return;
			}

			if (txtPassword.Text.Trim().Length == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Пароль пуст.\nВсе-таки сохранить?") != DialogResult.Yes)
				{
					txtPassword.Select();
					return;
				}
			}

			if (txtLocPath.Text.Trim().Length == 0)
			{
				//RFMMessage.MessageBoxError("Укажите локальный каталог!");
				//txtLocPath.Select();
				//return;
			}
			if (txtNetPath.Text.Trim().Length == 0)
			{
				//RFMMessage.MessageBoxError("Укажите сетевой каталог!");
				//txtNetPath.Select();
				//return;
			}

			oUser.Name     = txtUserNаme.Text.Trim();
			oUser.Password = txtPassword.Text.Trim();
			oUser.Alias	   = txtAlias.Text.Trim();
			oUser.LocPath  = txtLocPath.Text.Trim();
			oUser.NetPath  = txtNetPath.Text.Trim();
			oUser.IsAdmin  = chkIsAdmin.Checked;
			if (cboEmployee.SelectedValue != null && cboEmployee.SelectedIndex >= 0)
				oUser.EmployeeID = (int)cboEmployee.SelectedValue;
			else
				oUser.EmployeeID = null;
			if (cboHost.SelectedValue != null && cboHost.SelectedIndex >= 0)
				oUser.HostID = (int)cboHost.SelectedValue;
			else
				oUser.HostID = null; 
			oUser.Actual = chkActual.Checked;

			oUser.ClearError();
			oUser.SaveOne();

			if (oUser.ErrorNumber == 0)
			{
				// код добавленного пользователя
				if (ID == 0 && oUser.ID.HasValue && oUser.ID != 0)
				{
					ID = (int)oUser.ID;
				}

				// сохранить фото
				if (filePhotoPath != "")
				{
					FileStream fs = new FileStream(filePhotoPath, FileMode.Open, FileAccess.Read);
					BinaryReader br = new BinaryReader(fs);
					oUser.Photo = br.ReadBytes((int)fs.Length);
					br.Close();
					fs.Close();
					oUser.SaveOnePhoto();
				}
				else
				{
					if (bClearPhoto)
					{
						oUser.Photo = null;
						oUser.SaveOnePhoto();
					}
				}

				if (oUser.ErrorNumber == 0)
				{
					MotherForm.GotParam = new object[] { (int)oUser.ID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}


		#region Restore 

		private bool cboEmployee_Restore()
		{
			cboEmployee.DataSource = null;
			oEmployee.ClearError();
			if (oEmployee.FillDataAsync())
			{
				cboEmployee.ValueMember = oEmployee.ColumnID;
				cboEmployee.DisplayMember = oEmployee.ColumnName;
				cboEmployee.Restore(oEmployee.MainTable);
			}
			return (oEmployee.ErrorNumber == 0);
		}

		private bool cboHost_Restore()
		{
			cboHost.DataSource = null;
			if (Utilities.FillData_Hosts(oHost))
			{
				cboHost.ValueMember = oHost.ColumnID;
				cboHost.DisplayMember = oHost.ColumnName;
				cboHost.Restore(oHost.MainTable);
			}
			return (oHost.ErrorNumber == 0);
		}

		private bool dgvUserRoles_Restore()
		{
			oUser.FillTableRolesForUser(ID);
			dgvUserRoles.Restore(oUser.TableRolesForUser);
			return (oUser.ErrorNumber == 0);
		}

		#endregion Restore

		#region Photo 

		private void btnLoadPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Загрузить фото";
			dlg.Filter = "Изображения JPEG (*.jpg)|*.jpg" +
							"|Все файлы (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					filePhotoPath = dlg.FileName;
					picPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (Exception ex)
				{
					RFMMessage.MessageBoxError("Ошибка загрузки фото: " + ex.Message);
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
	}
}
