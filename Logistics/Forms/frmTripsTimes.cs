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
	public partial class frmTripsTimes : RFMFormChild
	{
		private int nTripID;
		private Trip oTrip;

		DateTime dDate = new DateTime(1900, 1, 1, 0, 0, 0); 
		DateTime dDateTrip = new DateTime(1900, 1, 1, 0, 0, 0);
		DateTime dEmptyDate = new DateTime(1900, 1, 1, 0, 0, 0);
		string sEmptyTime = "";

		int nHour = 0;
		int nMinute = 0;
		int nDay = 0; 

		public frmTripsTimes(int _nTripID)
		{
			nTripID = (int)_nTripID;

			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			sEmptyTime = dEmptyDate.ToString("HH:mm");

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmTripsTimes_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			oTrip.ID = nTripID;
			oTrip.FillData();
			if (oTrip.ErrorNumber != 0 || oTrip.MainTable == null)
			{
				bResult = false;
			}

			if (bResult)
			{
				oTrip.FillOne();
				dDate = oTrip.DateTrip;
				dDateTrip = new DateTime(dDate.Year, dDate.Month, dDate.Day, 0, 0, 0);

				dtpDateTrip.Value = oTrip.DateTrip;
				txtAlias.Text = oTrip.Alias;

				// план
				if (oTrip.DateBegPlan.HasValue)
				{
					dDate = (DateTime)oTrip.DateBegPlan;
					txtTimeBegPlan.Text = dEmptyDate.AddHours(dDate.Hour).AddMinutes(dDate.Minute).ToString("HH:mm");
				}
				else
				{
					txtTimeBegPlan.Text = sEmptyTime;
				}
				if (oTrip.DateEndPlan.HasValue)
				{
					dDate = (DateTime)oTrip.DateEndPlan;
					txtTimeEndPlan.Text = dEmptyDate.AddHours(dDate.Hour).AddMinutes(dDate.Minute).ToString("HH:mm");
				}
				else
				{
					txtTimeEndPlan.Text = sEmptyTime;
				}
				if (oTrip.DurationMinutesPlan.HasValue)
				{
					nHour = Convert.ToInt32(decimal.Floor(((decimal)oTrip.DurationMinutesPlan / 60)));
					nMinute = Convert.ToInt32((decimal)oTrip.DurationMinutesPlan - nHour * 60);
					nDay = 0;
					if (nHour > 24)
					{
						nDay = Convert.ToInt32(decimal.Floor((decimal)nHour / 24));
						nHour = nHour - nDay * 24;
					}
					numDurationDaysPlan.Value = nDay;
					txtDurationPlan.Text = dEmptyDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					txtDurationPlan.Text = sEmptyTime;
				}

				// факт
				if (oTrip.DateBeg.HasValue)
				{
					dDate = (DateTime)oTrip.DateBeg;
					txtTimeBeg.Text = dEmptyDate.AddHours(dDate.Hour).AddMinutes(dDate.Minute).ToString("HH:mm");
				}
				else
				{
					txtTimeBeg.Text = sEmptyTime;
				}
				if (oTrip.DateEnd.HasValue)
				{
					dDate = (DateTime)oTrip.DateEnd;
					txtTimeEnd.Text = dEmptyDate.AddHours(dDate.Hour).AddMinutes(dDate.Minute).ToString("HH:mm");
				}
				else
				{
					txtTimeEnd.Text = sEmptyTime;
				}

				if (oTrip.DurationMinutes.HasValue)
				{
					nHour = Convert.ToInt32(decimal.Floor(((decimal)oTrip.DurationMinutes / 60)));
					nMinute = Convert.ToInt32((decimal)oTrip.DurationMinutes - nHour * 60);
					nDay = 0;
					if (nHour > 24)
					{
						nDay = Convert.ToInt32(decimal.Floor((decimal)nHour / 24));
						nHour = nHour - nDay * 24;
					}
					numDurationDays.Value = nDay;
					txtDuration.Text = dEmptyDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					txtDuration.Text = sEmptyTime;
				}
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
			int nUserID = (int)((RFMFormMain)Application.OpenForms[0]).UserID;

			DateTime dDateTrip = (DateTime)oTrip.DateTrip;
			DateTime? dDateSet;
			dDateSet = null; 

			// план
			int nHour = Convert.ToInt16(txtTimeBegPlan.Text.Substring(0, 2));
			int nMinute = Convert.ToInt16(txtTimeBegPlan.Text.Substring(3, 2));
			if (nHour == 0 && nMinute == 0)
				dDateSet = null;
			else
				dDateSet = dDateTrip.AddHours(nHour).AddMinutes(nMinute);
			oTrip.SetDateTime(nTripID, "BEG", "PLAN", dDateSet, nUserID);

			nHour = Convert.ToInt16(txtTimeEndPlan.Text.Substring(0, 2));
			nMinute = Convert.ToInt16(txtTimeEndPlan.Text.Substring(3, 2));
			if (nHour == 0 && nMinute == 0)
				dDateSet = null;
			else
				dDateSet = dDateTrip.AddDays((double)numDurationDaysPlan.Value).AddHours(nHour).AddMinutes(nMinute);
			oTrip.SetDateTime(nTripID, "END", "PLAN", dDateSet, nUserID);

			// факт
			nHour = Convert.ToInt16(txtTimeBeg.Text.Substring(0, 2));
			nMinute = Convert.ToInt16(txtTimeBeg.Text.Substring(3, 2));
			if (nHour == 0 && nMinute == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не указано время начала рейса.\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
				{
					txtTimeBeg.Select();
					return;
				}
				dDateSet = null;
			}
			else
				dDateSet = dDateTrip.AddHours(nHour).AddMinutes(nMinute);
			oTrip.SetDateTime(nTripID, "BEG", "FACT", dDateSet, nUserID);

			nHour = Convert.ToInt16(txtTimeEnd.Text.Substring(0, 2));
			nMinute = Convert.ToInt16(txtTimeEnd.Text.Substring(3, 2));
			if (nHour == 0 && nMinute == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не указано время окончания рейса.\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
				{
					txtTimeEnd.Select();
					return;
				}
				dDateSet = null;
			}
			else
				dDateSet = dDateTrip.AddDays((double)numDurationDays.Value).AddHours(nHour).AddMinutes(nMinute);
			oTrip.SetDateTime(nTripID, "END", "FACT", dDateSet, nUserID);

			// 
			if (oTrip.ErrorNumber == 0)
			{
				MotherForm.GotParam = new object[] { (int?)nTripID };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		#region Times

		private void txtTimeBeg_Validated(object sender, EventArgs e)
		{
			if (((RFMTextBoxTime)sender).Name.ToUpper().Contains("PLAN"))
			{
				if (txtTimeBegPlan.Text == null || txtTimeBegPlan.Text.Length <= 1)
				{
					txtTimeBegPlan.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeBegPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBegPlan.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtDurationPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtDurationPlan.Text.Substring(3, 2));
				if (nMinute != 0 || nHour != 0)
				{
					txtTimeEndPlan.Text = dDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					nHour = Convert.ToInt16(txtTimeEndPlan.Text.Substring(0, 2));
					nMinute = Convert.ToInt16(txtTimeEndPlan.Text.Substring(3, 2));
					if (nMinute != 0 || nHour != 0)
					{
						txtDurationPlan.Text = dDate.AddHours(-nHour).AddMinutes(-nMinute).ToString("HH:mm");
					}
				}
			}
			else
			{
				if (txtTimeBeg.Text == null || txtTimeBeg.Text.Length <= 1) 
				{
					txtTimeBeg.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeBeg.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBeg.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtDuration.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtDuration.Text.Substring(3, 2));
				if (nMinute != 0 || nHour != 0)
				{
					txtTimeEnd.Text = dDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					nHour = Convert.ToInt16(txtTimeEnd.Text.Substring(0, 2));
					nMinute = Convert.ToInt16(txtTimeEnd.Text.Substring(3, 2));
					if (nMinute != 0 || nHour != 0)
					{
						txtDuration.Text = dDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
					}
				}
			}
		}

		private void txtDuration_Validated(object sender, EventArgs e)
		{
			if (((RFMTextBoxTime)sender).Name.ToUpper().Contains("PLAN"))
			{
				if (txtDurationPlan.Text == null || txtDurationPlan.Text.Length <= 1)
				{
					txtDurationPlan.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeBegPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBegPlan.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtDurationPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtDurationPlan.Text.Substring(3, 2));
				if (nMinute != 0 || nHour != 0)
				{
					txtTimeEndPlan.Text  = dDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					txtTimeEndPlan.Text = sEmptyTime;
				}
			}
			else
			{
				if (txtDuration.Text == null || txtDuration.Text.Length <= 1)
				{
					txtDuration.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeBeg.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBeg.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtDuration.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtDuration.Text.Substring(3, 2));
				if (nMinute != 0 || nHour != 0)
				{
					txtTimeEnd.Text = dDate.AddHours(nHour).AddMinutes(nMinute).ToString("HH:mm");
				}
				else
				{
					txtTimeEnd.Text = sEmptyTime;
				}
			}
		}

		private void txtTimeEnd_Validated(object sender, EventArgs e)
		{
			if (((RFMTextBoxTime)sender).Name.ToUpper().Contains("PLAN"))
			{
				if (txtTimeEndPlan.Text == null || txtTimeEndPlan.Text.Length <= 1)
				{
					txtTimeEndPlan.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeEndPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeEndPlan.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtTimeBegPlan.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBegPlan.Text.Substring(3, 2));
				txtDurationPlan.Text = dDate.AddHours(-nHour).AddMinutes(-nMinute).ToString("HH:mm");
			}
			else
			{
				if (txtTimeEnd.Text == null || txtTimeEnd.Text.Length <= 1)
				{
					txtTimeEnd.Text = sEmptyTime;
				}

				nHour = Convert.ToInt16(txtTimeEnd.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeEnd.Text.Substring(3, 2));
				dDate = dDateTrip.AddHours(nHour).AddMinutes(nMinute);

				nHour = Convert.ToInt16(txtTimeBeg.Text.Substring(0, 2));
				nMinute = Convert.ToInt16(txtTimeBeg.Text.Substring(3, 2));
				txtDuration.Text = dDate.AddHours(-nHour).AddMinutes(-nMinute).ToString("HH:mm");
			}
		}

		#endregion Times

		#region Clear

		private void btnBegClear_Click(object sender, EventArgs e)
		{
			if (((RFMButton)sender).Name.ToUpper().Contains("PLAN"))
				txtTimeBegPlan.Text = sEmptyTime;
			else
				txtTimeBeg.Text = sEmptyTime;
		}

		private void btnEndClear_Click(object sender, EventArgs e)
		{
			if (((RFMButton)sender).Name.ToUpper().Contains("PLAN"))
				txtTimeEndPlan.Text = sEmptyTime;
			else
				txtTimeEnd.Text = sEmptyTime;
		}

		#endregion Clear

		#region Set

		private void btnBegSet_Click(object sender, EventArgs e)
		{
			txtTimeBeg.Text = DateTime.Now.ToString("HH:mm");
		}

		private void btnEndSet_Click(object sender, EventArgs e)
		{
			txtTimeEnd.Text = DateTime.Now.ToString("HH:mm");
		}

		#endregion Set

	}
}
