using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;
using System.Data.SqlClient;

namespace Logistics 
{
	public partial class frmTripsCostAmountEdit : RFMFormChild
	{
        private int nTripID;
		private DataTable dtSource;
        private DataTable dtUnits;

		public frmTripsCostAmountEdit(int TripID, DataTable dt)
		{
            nTripID = TripID;
			dtSource = dt;
			if (dtSource == null || dtSource.Rows.Count == 0)
				IsValid = false;

			if (IsValid)
			{
				InitializeComponent();
			}
		}
	
		private void frmTripsCostAmountEdit_Load(object sender, EventArgs e)
		{
            CarTaskUnit ctUnit = new CarTaskUnit();
            if (!ctUnit.FillData())
            {
                Dispose();
                return;
            }
            dtUnits = ctUnit.MainTable;

            dgvcCarTskUnitID.DataSource = dtUnits;
            dgvcCarTskUnitID.DisplayMember = "Name";
            dgvcCarTskUnitID.ValueMember = "ID";
            dgvcCarTskUnitID.DataPropertyName = "CarTaskUnitID";

            // назначение суммирования на колонки
            foreach (Control ctrl in Controls)
            {
                Utilities.ctrl_AgrTypeSet(ctrl);
            }
            dgvcTaskInnerCost.AgrType = 
            dgvcTaskOuterCost.AgrType = 
            dgvcTaskAmount.AgrType = 
            dgvcBrutto.AgrType =
                EnumAgregate.Sum;
            dgvJobs.IsStatusShow = true;

			if (dgvJobs.Rows.Count > 0)
			{
				dgvJobs.CurrentCell = dgvJobs.Rows[0].Cells[0];
			}

            if (!dgvTrips_Restore())
            {
                Dispose();
                return;
            }
        }

	#region Restore

		private bool dgvTrips_Restore()
		{
			dgvJobs.Restore(dtSource);
			return true;
		}	

	#endregion

	#region Cells

		private void dgvTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null || grd.Rows.Count == 0)
				return;

			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

            if (sColumnName.Contains("IMAGE"))
			{
                String sType = r["Type"].ToString();
                switch (sType)
                {
                    case "O":
                        e.Value = Properties.Resources.Minus;
                        break;
                    case "I":
                        e.Value = Properties.Resources.Plus;
                        break;
                    case "$":
                        e.Value = Properties.Resources.Car_Red;
                        break;
                }
			}
		}


        private void dgvJobs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RFMDataGridView grd = (RFMDataGridView)sender;
            if (grd.DataSource == null || grd.Rows.Count == 0)
                return;

            // строка данных
            DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

            DataGridViewColumn c = grd.Columns[e.ColumnIndex];
            string sColumnName = c.Name.ToUpper();

            if (sColumnName.Equals("dgvcUnitsQnt".ToUpper()) || sColumnName.Equals("dgvcPrice".ToUpper()))
            {
                decimal nUnitsQnt, nPrice;
                try
                {
                    nUnitsQnt = Decimal.Parse(r["UnitsQnt"].ToString());
                    nPrice = Decimal.Parse(r["Price"].ToString());
                }
                catch 
                {
                    nUnitsQnt = nPrice = 0;
                }
                r["TaskAmount"] = nUnitsQnt * nPrice;
                grd.Refresh();
            }
        }

    #endregion Cells
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			dgvJobs.GridSource.Filter = "";
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
            decimal nTripOuterCostSum = 0;
            String sqlCommand, sTableName, sID;
			DataRow r;
			for (int i = 0; i < dtSource.Rows.Count; i++)
			{
				r = dtSource.Rows[i];

                sTableName = sID = "";
                switch (r["Type"].ToString()){
                    case "O":
                        sTableName = "Outputs";
                        sID = r["OutputID"].ToString();
                        break;
                    case "I":
                        sTableName = "Inputs";
                        sID = r["InputID"].ToString();
                        break;
                    case "$":
                        sTableName = "CarsTasks";
                        sID = r["CarTaskID"].ToString();
                        break;
                    default:
                        sID = String.Empty;
                        break;
                }

                if (sID.Length == 0)
                    continue;

                decimal nTaskInnerCost, nTaskOuterCost, nUnitsQnt, nPrice;
                int? nCarTaskUnitID;
                try
                {
                    nTaskInnerCost = Decimal.Parse(r["TaskInnerCost"].ToString());
                    nTaskOuterCost = Decimal.Parse(r["TaskOuterCost"].ToString());
                    nCarTaskUnitID = Int32.Parse(r["CarTaskUnitID"].ToString());
                    nUnitsQnt = Decimal.Parse(r["UnitsQnt"].ToString());
                    nPrice = Decimal.Parse(r["Price"].ToString());
                    nTripOuterCostSum += nTaskOuterCost;
                }
                catch (Exception ex)
                {
                    nTaskInnerCost = nTaskOuterCost = nUnitsQnt = nPrice = 0;
                    nCarTaskUnitID = null;
                    nTripOuterCostSum += 0;
                    RFMMessage.MessageBoxError("Ошибка при заполнении данных о стоимости заданий...\r\n" + ex.Message);
                    return;
                }

                if (sTableName.Length > 0 && sID.Length > 0) 
                {
                    sqlCommand = "update " + sTableName + " set " +
                        "TaskInnerCost = @nTaskInnerCost, " +
                        "TaskOuterCost = @nTaskOuterCost, " +
                        "CarTaskUnitID = @nCarTaskUnitID, " +
                        "UnitsQnt = @nUnitsQnt, " +
                        "Price = @nPrice " +
                        "where ID = " + sID;
                    SqlConnection connect = this.GetMainConnect();
                    SqlCommand oCommand = new SqlCommand(sqlCommand, connect);

                    SqlParameter oParameter = oCommand.Parameters.Add("@nTaskInnerCost", SqlDbType.Decimal);
                    oParameter.Value = nTaskInnerCost;
                    oParameter = oCommand.Parameters.Add("@nTaskOuterCost", SqlDbType.Decimal);
                    oParameter.Value = nTaskOuterCost;

                    oParameter = oCommand.Parameters.Add("@nCarTaskUnitID", SqlDbType.Int);
                    if (nCarTaskUnitID.HasValue)
                        oParameter.Value = nCarTaskUnitID;
                    else
                        oParameter.Value = DBNull.Value;

                    oParameter = oCommand.Parameters.Add("@nUnitsQnt", SqlDbType.Decimal);
                    oParameter.Value = nUnitsQnt;
                    oParameter = oCommand.Parameters.Add("@nPrice", SqlDbType.Decimal);
                    oParameter.Value = nPrice;

                    try
                    {
                        connect.Open();
                        oCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        RFMMessage.MessageBoxError("Ошибка при попытке записи данных о стоимости заданий...\r\n" + ex.Message);
                        return;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
			}

            sqlCommand = "update Trips set Cost = @nTripOuterCostSum where ID = " + nTripID;
            SqlConnection tConnect = this.GetMainConnect();
            SqlCommand tCommand = new SqlCommand(sqlCommand, tConnect);
            SqlParameter tParameter = tCommand.Parameters.Add("@nTripOuterCostSum", SqlDbType.Decimal);
            tParameter.Value = nTripOuterCostSum;

            try
            {
                tConnect.Open();
                tCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("Ошибка при попытке записи данных о стоимости рейса...\r\n" + ex.Message);
                return;
            }
            finally
            {
                tConnect.Close();
            }

            Dispose();
		}
	}
}
