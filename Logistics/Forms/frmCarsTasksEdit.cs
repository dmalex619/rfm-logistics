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
	public partial class frmCarsTasksEdit : RFMFormChild
	{
		private int? nCarTaskID = null;
		
        private CarTask oCarTask;

        private CarTaskUnit oCarTaskUnit;
        private Partner oPartner;
        private Zone oZone;

		private DateTime dEmptyDate = new DateTime(1900, 1, 1, 0, 0, 0);

        private int nUserID;
        private bool isCopy = false;

        public frmCarsTasksEdit(int? _nCarTaskID) : this(_nCarTaskID, false)
        {
        }

        public frmCarsTasksEdit(int? _nCarTaskID, bool _isCopy)
        {
            isCopy = _isCopy;

            nUserID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID;

            if (_nCarTaskID.HasValue)
            {
                nCarTaskID = (int)_nCarTaskID;
            }

            oCarTask = new CarTask();
            if (oCarTask.ErrorNumber != 0)
            {
                IsValid = false;
            }

            if (IsValid)
            {
                oPartner = new Partner();
                oZone = new Zone();
                oCarTaskUnit = new CarTaskUnit();
                if (oPartner.ErrorNumber != 0 || oZone.ErrorNumber != 0 || oCarTaskUnit.ErrorNumber != 0)
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                InitializeComponent();
            }
        }

        private void frmCarsTasksEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			oCarTask.ID = nCarTaskID;

			// классификаторы
			bResult = cboPartner_Restore() && 
                        cboZone_Restore() &&
                        cboCarTaskUnit_Restore();

			if (bResult)
			{
				if (nCarTaskID.HasValue && (int)nCarTaskID != 0)
				{
					// существующее или копируемое задание
					bResult = oCarTask.ReFillOne((int)nCarTaskID) && (oCarTask.ErrorNumber == 0);
					if (bResult)
					{
                        #region Поля, заполняемые одинаково в режимах редактирования и копирования
                        cboPartner.SelectedValue = oCarTask.PartnerID;
                        txtDeliveryAddress.Text = oCarTask.DeliveryAddress;

                        if (oCarTask.ZoneID.HasValue)
                            cboZone.SelectedValue = oCarTask.ZoneID;
                        else
                            cboZone.SelectedValue = -1;

                        if (oCarTask.Longitude.HasValue)
                            txtLongitude.Text = oCarTask.Longitude.ToString();
                        if (oCarTask.Latitude.HasValue)
                            txtLatitude.Text = oCarTask.Latitude.ToString();

                        numDistance.Value = oCarTask.Distance;
                        #endregion

                        #region Поля, заполняемые по-разному в режимах редактирования и копирования
                        if (isCopy) {
                            // пересоздаем задание (очищаем данные)
                            oCarTask = new CarTask();

                            Text += " (копирование с " + nCarTaskID.ToString() + ")";

                            dtpDateTask.Value = DateTime.Today.AddDays(1);

                            cboUnit.SelectedValue = -1;
                        }
                        else
                        {
                            Text += " (" + nCarTaskID.ToString() + ")";

                            dtpDateTask.Value = oCarTask.DateTask;

                            if (oCarTask.CarTaskUnitID.HasValue)
                                cboUnit.SelectedValue = oCarTask.CarTaskUnitID;
                            else
                                cboUnit.SelectedValue = -1;

                            numNetto.Value = oCarTask.Netto;
                            numBrutto.Value = oCarTask.Brutto;
                            numPalletsQnt.Value = oCarTask.PalletsQnt;

                            numTaskInnerCost.Value = oCarTask.TaskInnerCost;
                            numTaskOuterCost.Value = oCarTask.TaskOuterCost;

                            numUnitsQnt.Value = oCarTask.UnitsQnt;
                            numPrice.Value = oCarTask.Price;
                            numTaskAmount.Value = oCarTask.TaskAmount;

                            txtNote.Text = oCarTask.Note;
                        }
                        #endregion
					}
				}
				else
				{
					// новое задание
                    cboPartner.SelectedValue = 
                        cboZone.SelectedValue =
                        cboUnit.SelectedValue = 
                        -1;

                    dtpDateTask.Value = DateTime.Today.AddDays(1);
				}
			}
			
			if (!bResult)
			{
				Dispose();
			}
		}

        #region Buttons

        private void btnLocate_Click(object sender, EventArgs e)
        {
            if (txtDeliveryAddress.Text.Length == 0)
            {
                RFMMessage.MessageBoxAttention("Пустой адрес!");
                return;
            }

            Partner tempPartner = new Partner();
            tempPartner.Name = "Точка доставки";
            tempPartner.DeliveryAddress = txtDeliveryAddress.Text;
            if (txtLongitude.Text.Length > 0 && txtLatitude.Text.Length > 0)
            {
                tempPartner.Longitude = Convert.ToDecimal(txtLongitude.Text);
                tempPartner.Latitude = Convert.ToDecimal(txtLatitude.Text);
            }

            frmShowMap frmShowMap = new frmShowMap(tempPartner);
            if (frmShowMap != null)
            {
                // Отображение карты
                StartForm(frmShowMap);

                // Переотображение данных о координатах и расстоянии
                // Эти данные переприсваиваются в форме frmShowMap!
                if (tempPartner.Longitude.HasValue && tempPartner.Latitude.HasValue) {
                    txtLongitude.Text = tempPartner.Longitude.ToString();
                    txtLatitude.Text = tempPartner.Latitude.ToString();
                }
                if (tempPartner.Distance > 0) numDistance.Value = tempPartner.Distance;
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
			// проверки 

            // Изменение от 02.12.2018, Александров
            // Проверка на дату снята по просьбе Головкина (письмо Буркина от 27.11.2018)
            /*
            if (dtpDateTask.Value < DateTime.Today.AddDays(-7))
            {
                RFMMessage.MessageBoxError("Слишком старая дата задания...");
                dtpDateTask.Select();
                return;
            }
            */
            if (cboPartner.SelectedValue == null || cboPartner.SelectedIndex < 0)
            {
                RFMMessage.MessageBoxError("Не указан владелец задания...");
                cboPartner.Select();
                return;
            }
            if (cboZone.SelectedValue == null || cboZone.SelectedIndex < 0)
            {
                RFMMessage.MessageBoxError("Не указана зона...");
                cboZone.Select();
                return;
            }
            if (txtDeliveryAddress.Text.Length == 0)
            {
                RFMMessage.MessageBoxError("Не указан адрес доставки...");
                txtDeliveryAddress.Select();
                return;
            }
            if (txtNote.Text.Length == 0)
            {
                RFMMessage.MessageBoxError("Пустое примечание...");
                txtNote.Select();
                return;
            }

			// собираем данные в свойства объекта oCarTask
            oCarTask.DateTask = dtpDateTask.Value;
            oCarTask.DeliveryAddress = txtDeliveryAddress.Text.Trim();
            oCarTask.PartnerID = Convert.ToInt32(cboPartner.SelectedValue);
            oCarTask.ZoneID = Convert.ToInt32(cboZone.SelectedValue);

            if (txtLongitude.Text.Length > 0 && txtLatitude.Text.Length > 0)
            {
                oCarTask.Longitude = Convert.ToDecimal(txtLongitude.Text);
                oCarTask.Latitude = Convert.ToDecimal(txtLatitude.Text);
            }
            oCarTask.Distance = Convert.ToInt32(numDistance.Value);

            oCarTask.Netto = numNetto.Value;
            oCarTask.Brutto = numBrutto.Value;
            oCarTask.PalletsQnt = numPalletsQnt.Value;

            oCarTask.TaskInnerCost = numTaskInnerCost.Value;
            oCarTask.TaskOuterCost = numTaskOuterCost.Value;

            if (cboUnit.SelectedValue != null && cboUnit.SelectedIndex >= 0)
                oCarTask.CarTaskUnitID = Convert.ToInt32(cboUnit.SelectedValue);
            else
                oCarTask.CarTaskUnitID = null;
            oCarTask.UnitsQnt = numUnitsQnt.Value;
            oCarTask.Price = numPrice.Value;
            oCarTask.IsCach = chkIsCash.Checked;

			oCarTask.Note = txtNote.Text.Trim();

            oCarTask.UserIndentID = nUserID;

			// собственно сохранение 
			oCarTask.SaveOne();
			if (oCarTask.ErrorNumber == 0)
			{
				// код добавленной записи 
				if ((!nCarTaskID.HasValue || nCarTaskID == 0) && oCarTask.ID.HasValue && oCarTask.ID != null)
				{
					nCarTaskID = (int)oCarTask.ID;
				}

				if (nCarTaskID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nCarTaskID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

        private void btnHelp_Click(object sender, EventArgs e)
        {
            RFMHelpUtilities.HelpShow(this, hpHelp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion Buttons

		#region Restore

		private bool cboPartner_Restore()
		{
			cboPartner.DataSource = null;
			oPartner.ClearError();
            oPartner.FilterIsOwner = true;
            if (oPartner.FillData())
			{
                cboPartner.DataSource = new DataView(oPartner.MainTable);
                cboPartner.ValueMember = oPartner.ColumnID;
                cboPartner.DisplayMember = oPartner.ColumnName;
                cboPartner.Restore();
			}
			return (oCarTask.ErrorNumber == 0);
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

        private bool cboCarTaskUnit_Restore()
        {
            cboUnit.DataSource = null;
            oCarTaskUnit.ClearError();
            if (oCarTaskUnit.FillData())
            {
                cboUnit.DataSource = new DataView(oCarTaskUnit.MainTable);
                cboUnit.ValueMember = oCarTaskUnit.ColumnID;
                cboUnit.DisplayMember = oCarTaskUnit.ColumnName;
                cboUnit.Restore();
            }
            return (oCarTaskUnit.ErrorNumber == 0);
        }

		#endregion Restore

        private void RecalcTaskAmount(object sender, EventArgs e)
        {
            numTaskAmount.Value = numUnitsQnt.Value * numPrice.Value;
        }

        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            if (control != null)
                control.Select(0, control.Text.Length);
        }
	}
}
