using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Text;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class VeterinaryBlankSingle : DataDynamics.ActiveReports.ActiveReport3
	{
		private DateTime dDate = DateTime.Now.Date;
		private string cDay = "", cMonth = "", cYear = "";
        private string[] aMonthes = { 
            "������", "�������", "�����", "������", "���", "����", 
            "����", "�������", "��������", "�������", "������", "�������" 
        };

		public VeterinaryBlankSingle()
		{
			InitializeComponent();

			cDay = dDate.Day.ToString("00");
            cMonth = aMonthes[dDate.Month - 1];
            cYear = ((int)(dDate.Year - 2000)).ToString("00"); //  ;)
        }

		private void Detail_Format(object sender, EventArgs e)
		{
            // ���������� ������� ������ ������ ������� �����
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 50; i++) sb.Append(" ");
            txtVeterinaryNames.Text = sb.ToString() + Fields["VeterinaryNames"].Value.ToString();
            txtVeterinaryProducers.Text = sb.ToString() + Fields["VeterinaryProducers"].Value.ToString();

            try
			{
				dDate = Convert.ToDateTime(Fields["DateOutput"].Value);
			}
			catch { }

            // ������ 2-�� ��������
            if (!Convert.ToBoolean(Fields["IsPrintSecondPage"].Value))
            {
                pbFirst.Visible =
                    tb21.Visible = tb22.Visible = tb23.Visible =
                    tb24.Visible = tb25.Visible = tb26.Visible =
                    tb27.Visible = tb28.Visible = tb29.Visible = false;
                Detail.Height = (float)(28.0 / 2.54); // �����
            }

			cDay = dDate.Day.ToString("00");
            cMonth = aMonthes[dDate.Month - 1];
            cYear = ((int)(dDate.Year - 2000)).ToString("00");

			txtDay1.Text = cDay;
			txtMonth1.Text = cMonth;
			txtYear1.Text = cYear;
		}
	}
}
