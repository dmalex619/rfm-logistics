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
	public partial class frmCarsTypesEdit : RFMFormChild
	{
		private int? nCarTypeID;
		private CarType oCarType;

		public frmCarsTypesEdit(int? _nCarTypeID)
		{
			if (_nCarTypeID.HasValue)
			{
				nCarTypeID = (int)_nCarTypeID;
			}

			oCarType = new CarType();
			if (oCarType.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmCarsTypesEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true; 

			oCarType.ID = nCarTypeID;

			if (nCarTypeID.HasValue && (int)nCarTypeID != 0)
			{
				// ������������ ��� 
				bResult = oCarType.ReFillOne((int)nCarTypeID) && (oCarType.ErrorNumber == 0);
				if (bResult)
				{
					txtCarTypeN�me.Text = oCarType.Name;
					chkActual.Checked = oCarType.Actual;
				}
			}
			else
			{
				// ����� ���
				chkActual.Checked = true;
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
			if (txtCarTypeN�me.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("������� ������������ ���� ������!");
				txtCarTypeN�me.Select();
				return;
			}

			if (!chkActual.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("��������� ������ ��� ������������?") != DialogResult.Yes)
				{
					chkActual.Select();
					return;
				}
			}

			oCarType.Name = txtCarTypeN�me.Text.Trim();
			oCarType.Actual = chkActual.Checked;

			oCarType.ClearError();
			oCarType.SaveOne();
			if (oCarType.ErrorNumber == 0)
			{
				// ��� ����������� ������ 
				if ((!nCarTypeID.HasValue || nCarTypeID == 0) && oCarType.ID.HasValue && oCarType.ID != null)
				{
					nCarTypeID = (int)oCarType.ID;
				}

				if (nCarTypeID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nCarTypeID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}
	}
}
