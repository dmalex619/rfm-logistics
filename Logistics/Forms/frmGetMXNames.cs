using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Logistics
{
    public partial class frmGetMXNames : RFMBaseClasses.RFMFormChild
    {
        private DataTable dtCompanies;

        public frmGetMXNames(DataTable TCompanies)
        {
            InitializeComponent();

            dtCompanies = TCompanies;
        }

        private void frmGetMXNames_Load(object sender, EventArgs e)
        {
            // Заполнение комбобоксов
            foreach (DataRow r in dtCompanies.Rows)
            {
                cboPayer.Items.Add(r[0]);
                cboPayee.Items.Add(r[0]);
            }

            // В таблице будет как минимум две записи
            cboPayer.SelectedIndex = 0;
            cboPayee.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Пометка выбранных значений
            foreach (DataRow r in dtCompanies.Rows)
            {
                if (r[0] == cboPayer.SelectedItem)
                    r[1] = true;
                if (r[0] == cboPayee.SelectedItem)
                    r[2] = true;
            }

            DialogResult = DialogResult.Yes;
            Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Dispose();
        }
    }
}

