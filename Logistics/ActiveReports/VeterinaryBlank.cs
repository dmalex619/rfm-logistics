using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Text;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class VeterinaryBlank : DataDynamics.ActiveReports.ActiveReport3
	{
		private DateTime dDate = DateTime.Now.Date;
		private string cDay = "", cMonth = "", cYear = "";
        private string[] aMonthes = { 
            "€нвар€", "феврал€", "марта", "апрел€", "ма€", "июн€", 
            "июл€", "августа", "сент€бр€", "окт€бр€", "но€бр€", "декабр€" 
        };

		public VeterinaryBlank()
		{
			InitializeComponent();

			cDay = dDate.Day.ToString("00");
            //cMonth = dDate.Month.ToString("00");
            cMonth = aMonthes[dDate.Month - 1];
            cYear = ((int)(dDate.Year - 2000)).ToString("00"); //  ;)
		}

		private void Detail_Format(object sender, EventArgs e)
		{
            // ƒополнение длинных данных пустой строкой слева
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 30; i++) sb.Append(" ");
            txtVeterinaryNames1.Text = txtVeterinaryNames2.Text = sb.ToString() + Fields["VeterinaryNames"].Value.ToString();
            txtVeterinaryProducers1.Text = txtVeterinaryProducers2.Text = sb.ToString() + Fields["VeterinaryProducers"].Value.ToString();
            
            try
			{
				dDate = Convert.ToDateTime(Fields["DateOutput"].Value);
			}
			catch { }

			cDay = dDate.Day.ToString("00");
            //cMonth = dDate.Month.ToString("00");
            cMonth = aMonthes[dDate.Month - 1];
            cYear = ((int)(dDate.Year - 2000)).ToString("00");

			txtDay1.Text = txtDay2.Text = cDay;
			txtMonth1.Text = txtMonth2.Text = cMonth;
			txtYear1.Text = txtYear2.Text = cYear;  
		}
	}
}
