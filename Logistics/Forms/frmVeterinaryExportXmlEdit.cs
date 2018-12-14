using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RFMBaseClasses;
using RFMPublic;

namespace Logistics
{
    public partial class frmVeterinaryExportXmlEdit : RFMFormChild
    {
        private string sExportXML = "";
        private DataSet ds = new DataSet("studies");
        private DataTable tbl = new DataTable("stady");

        public frmVeterinaryExportXmlEdit(string SExportXML)
        {
            InitializeComponent();

            sExportXML = SExportXML;

            tbl.Columns.Add("number", typeof(string));
            tbl.Columns.Add("text", typeof(string));
            tbl.Columns.Add("date", typeof(DateTime));
            tbl.Columns.Add("datestring", typeof(string));      // ������ ������� ��� �������������� ������ ����� ���������
            tbl.Columns.Add("result", typeof(string));
            tbl.Columns.Add("laboratory", typeof(string));
            ds.Tables.Add(tbl);
        }

        private void frmVeterinaryExportXmlEdit_Load(object sender, EventArgs e)
        {
            // ��������� ������� �� XML
            if (sExportXML.Length > 0)
            {
                try
                {
                    tbl.ReadXml(new System.IO.StringReader(sExportXML));
                }
                catch (Exception ex)
                {
                    RFMMessage.MessageBoxAttention("���������� ��������� ������� ����������!\n ������� ������ ������!\r\n" + ex.Message);
                }
            }

            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = tbl;
            dgvData.AllowUserToAddRows = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // �������� ������� �������
            if (tbl.Rows.Count == 0)
            {
                RFMMessage.MessageBoxError("������ �������, ������ ���������!");
                return;
            }

            // �������������� ���� � ��������� ������, ����� �������� �����
            foreach (DataRow r in tbl.Rows) 
                r["datestring"] = Convert.ToDateTime(r["date"]).ToString("yyyy-MM-dd");
            tbl.Columns.Remove("date");
            tbl.Columns["datestring"].ColumnName = "date";

            // ����������� ������� � XML
            System.IO.StringWriter writer = new System.IO.StringWriter();
            tbl.WriteXml(writer);

            // �������������� �������������� � XML ������� �������� � ���� <study><number>12345</number></study>
            // � ��� �������� ����� ���: <study number="12345"></study>
            // ������� ������� ������
            /*StringBuilder sb = new StringBuilder();
            sb.Append("<studies rec_count=\"" + tbl.Rows.Count.ToString() + "\">\n");
            foreach (DataRow r in tbl.Rows)
            {
                sb.Append("\t<study " +
                    "number=\"" + r["number"].ToString() + "\" " +
                    "text=\"" + r["text"].ToString() + "\" " +
                    "date=\"" + Convert.ToDateTime(r["date"]).ToString("yyyyMMdd") + "\" " +
                    "result=\"" + r["result"].ToString() + "\">\n" +
                    "\t</study>\n");
            }
            sb.Append("</studies>\n");*/

            // ����� � ��������� XML
            this.DialogResult = DialogResult.OK;
            if (MotherForm != null)
                MotherForm.GotParam = new object[] { /*sb.ToString()*/ writer.ToString() };
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvData_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dtcNumber"].Value = 0;
            e.Row.Cells["dtcText"].Value = "";
            e.Row.Cells["dtcDate"].Value = DateTime.Today;
            e.Row.Cells["dtcResult"].Value = "���.";
            e.Row.Cells["dtcLaboratory"].Value = "";
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}