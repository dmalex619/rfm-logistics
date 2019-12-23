using System;
using System.Data;
using System.Windows.Forms;

using DataDynamics.ActiveReports;

using LogBizObjects;

using RFMBaseClasses;

using RFMPublic;

namespace Logistics
{
	public partial class frmOutputsDocumentsTTNData : RFMFormChild
	{
		DataTable dt;
		private OutputDocument oOutputDocument;
		private Output oOutput;

		public frmOutputsDocumentsTTNData(DataTable _dt)
		{
			if (_dt == null)
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				dt = _dt;
				InitializeComponent();
			}
		}

		public frmOutputsDocumentsTTNData(OutputDocument _oOutputDocument)
		{
			if (_oOutputDocument == null ||
				(!_oOutputDocument.ID.HasValue && _oOutputDocument.IDList == null))
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				oOutputDocument = _oOutputDocument;
				InitializeComponent();
			}
		}

		public frmOutputsDocumentsTTNData(Output _oOutput)
		{
			if (_oOutput == null ||
				(!_oOutput.ID.HasValue && _oOutput.IDList == null))
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				oOutput = _oOutput;
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsTTNData_Load(object sender, EventArgs e)
		{
			bool bOK = true;

			if (dt == null)
			{
				if (oOutputDocument != null)
				{
					if (FillOutputsDocuments_dt())
					{
						if (dt == null || dt.Rows.Count == 0)
						{
							RFMMessage.MessageBoxInfo("Нет расходных документов...");
							bOK = false;
						}
					}
				}

				if (oOutput != null)
				{
					if (FillOutputs_dt())
					{
						if (dt == null || dt.Rows.Count == 0)
						{
							RFMMessage.MessageBoxInfo("Нет расходов...");
							bOK = false;
						}
					}
				}
			}

			if (bOK)
			{
				grdData.IsCheckerShow = true;
				grdData_Restore();
			}
			else
			{
				Dispose();
				return;
			}
		}

		private bool FillOutputsDocuments_dt()
		{
			bool bOK = true;

			dt = null;

			oOutputDocument.FillData();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
				bOK = false;

			if (bOK)
			{
				oOutputDocument.FillTTNTableOutputsDocuments("-1");
				if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
					bOK = false;
			}
			if (bOK)
			{
				dt = CopyTable(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"], "dt", "", "");

				DataTable dtOutputsDocuments = CopyTable(oOutputDocument.MainTable, "dtOutputsDocuments", "",
					"PartnerDetailBayerID, PartnerDetailShipperID, BillNumber");
				int nPartnerDetailBayerID = 0;
				int nPartnerDetailShipperID = 0;
				string sOutputsDocumentsIDTempList = "";
				foreach (DataRow r in dtOutputsDocuments.Rows)
				{
					if (((int)r["PartnerDetailBayerID"] != nPartnerDetailBayerID ||
						 (int)r["PartnerDetailShipperID"] != nPartnerDetailShipperID) &&
						sOutputsDocumentsIDTempList.Length > 0)
					{
						oOutputDocument.FillTTNTableOutputsDocuments(sOutputsDocumentsIDTempList);
						if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
						{
							bOK = false;
							break;
						}

						dt.Merge(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"]);
						sOutputsDocumentsIDTempList = "";
					}

					sOutputsDocumentsIDTempList += r["ID"].ToString() + ",";
					nPartnerDetailBayerID = (int)r["PartnerDetailBayerID"];
					nPartnerDetailShipperID = (int)r["PartnerDetailShipperID"];
				}
				if (sOutputsDocumentsIDTempList.Length > 0)
				{
					oOutputDocument.FillTTNTableOutputsDocuments(sOutputsDocumentsIDTempList);
					if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
						bOK = false;
					else
						dt.Merge(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"]);
				}
			}
			return (bOK);
		}

		private bool FillOutputs_dt()
		{
			bool bOK = true;

			dt = null;

			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				bOK = false;

			if (bOK)
			{
				oOutput.FillTTNTableOutputs("-1");
				if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
					bOK = false;
			}
			if (bOK)
			{
				dt = CopyTable(oOutput.DS.Tables["TableOutputsTTN"], "dt", "", "");

				DataTable dtOutputs = CopyTable(oOutput.MainTable, "dtOutputs", "",
					"PartnerID, OwnerID, ID");
				int nPartnerID = 0;
				int nOwnerID = 0;
				string sOutputsIDTempList = "";
				foreach (DataRow r in dtOutputs.Rows)
				{
					if (((int)r["PartnerID"] != nPartnerID ||
						 (int)r["OwnerID"] != nOwnerID) &&
						sOutputsIDTempList.Length > 0)
					{
						oOutput.FillTTNTableOutputs(sOutputsIDTempList);
						if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
						{
							bOK = false;
							break;
						}

						dt.Merge(oOutput.DS.Tables["TableOutputsTTN"]);
						sOutputsIDTempList = "";
					}

					sOutputsIDTempList += r["ID"].ToString() + ",";
					nPartnerID = (int)r["PartnerID"];
					nOwnerID = (int)r["OwnerID"];
				}
				if (sOutputsIDTempList.Length > 0)
				{
					oOutput.FillTTNTableOutputs(sOutputsIDTempList);
					if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
						bOK = false;
					else
						dt.Merge(oOutput.DS.Tables["TableOutputsTTN"]);
				}
			}
			return (bOK);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private bool grdData_Restore()
		{
			if (dt.Rows.Count > 0)
			{
				DataRow r = dt.Rows[0];
				txtShipperInfo.Text = r["ShipperInfo"].ToString();
				txtPointCharge.Text = r["PointCharge"].ToString();
			}

			grdData.Restore(dt);

			return (true);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 || grdData.CurrentRow == null)
				return;

			DataTable dtRep = CopyTable(dt, "dtRep", "IsMarked = true", "");
			if (dtRep.Rows.Count == 0)
			{
				// текущая запись
				DataRow dr = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
				DataTable dtRepTemp = CopyTable(dt, "dtRep", "IDList = '" + dr["IDList"].ToString() + "'", "");
				dtRep.Merge(dtRepTemp);
			}

			// При печати из складских заданий, если задание не имеет связанных расх. документов, 
			// след. столбцы отсутствуют: OrderNumbersList, FactureNumbersList.
			// Создаем их вручную
			bool onl = false, fnl = false;
			foreach (DataColumn col in dtRep.Columns)
			{
				if (col.ColumnName == "OrderNumbersList")
					onl = true;
				if (col.ColumnName == "FactureNumbersList")
					fnl = true;
			}
			if (onl == false)
				dtRep.Columns.Add("OrderNumbersList", typeof(string));
			if (fnl == false)
				dtRep.Columns.Add("FactureNumbersList", typeof(string));

			foreach (DataRow r in dtRep.Rows)
			{
				//r["ShipperInfo"] = txtShipperInfo.Text;
				r["PointCharge"] = txtPointCharge.Text;

				// Убираем лишние пробелы
				r["BillNumbersList"] = r["BillNumbersList"].ToString().Trim();
				r["OrderNumbersList"] = r["OrderNumbersList"].ToString().Trim();
				r["FactureNumbersList"] = r["FactureNumbersList"].ToString().Trim();
			}

			// 2019-11-19
			// Формируем общую транспортную накладную на перевозчика
			// Заказ от БО, письма Пакина от 28.10 и 14.11 2019
			if (optTransportBill_Plus1.Checked)
			{
				// Новые данные: Организация-перевозчик, наименование товаров, адрес промежуточного склада
				Setting oProdTrans = new Setting();
				string newOrganizationInfo = oProdTrans.FillVariable("BoCarrier");
				string newWarehouseAddress = oProdTrans.FillVariable("BoAddress");
				string newGoodName = oProdTrans.FillVariable("BoGoodName");
				/*
				string newOrganizationInfo = "ООО \"ПродТранс\", ИНН 7724726640, " +
					"143007, Московская обл., г.Одинцово, ул. Советская, дом 9, оф. 4, тел. +7(495)980-08-91, " +
					"р/с 40702809000001634487, в банке ВТБ 24 (ПАО), БИК 044525716, к/с 30101810100000000716";
				string newWarehouseAddress = "Московская обл., Раменский р-н, пос.Родники, ул. Трудовая, дом 10";
				string newGoodName = dtRep.Rows[0]["GoodName"].ToString();
				*/

				// Создаем новую пустую таблицу для суммарных записей
				DataTable dtSummary = CopyTable(dtRep, "dtSummary", "ID = 0", "");

				// Сортируем исходную таблицу
				DataView dv = dtRep.DefaultView;
				dv.Sort = "ShipperInfo";
				dtRep = dv.ToTable();

				// Переменные для подсчета суммирующих значений
				string oldShipperInfo = "*";
				decimal sBoxes = 0, sNetto = 0, sBrutto = 0, sAmount = 0, sVAT = 0;
				int rCount = -1;

				// Цикл по старой таблице для суммирования значений
				foreach (DataRow r in dtRep.Rows)
				{
					// Новая организация-владелец товара?
					if (oldShipperInfo != r["ShipperInfo"].ToString())
					{
						oldShipperInfo = r["ShipperInfo"].ToString();
						rCount++;
						sBoxes = sNetto = sBrutto = sAmount = sVAT = 0;

						// Создаем строку для новой таблицы
						DataRow newRow = dtSummary.NewRow();

						// Копируем все поля старой таблицы в новую
						for (int i = 0; i < dtRep.Columns.Count; i++)
							newRow[i] = r[i];

						newRow["IDList"] = (rCount + 1).ToString();
						newRow["ID"] = rCount + 1;

						newRow["ConsigneeInfo"] = newOrganizationInfo;
						newRow["PayerTransportInfo"] = oldShipperInfo;
						//newRow["PayerTransportInfo"] = newRow["OrganizationInfo"];
						newRow["PointDisCharge"] = newWarehouseAddress;
						newRow["GoodName"] = newGoodName;

						newRow["BillNumbersList"] = "";
						newRow["OrderNumbersList"] = "";
						newRow["FactureNumbersList"] = "";

						// Добавляем строку в новую таблицу
						dtSummary.Rows.Add(newRow);
					}

					// Подсчитываем суммовые данные
					sBoxes += (decimal)r["SBoxes"];
					sNetto += (decimal)r["SNetto"];
					sBrutto += (decimal)r["SBrutto"];
					sAmount += (decimal)r["SAmount"];
					sVAT += (decimal)r["SVAT"];

					// Заполняем их в новой таблице
					DataRow nr = dtSummary.Rows[rCount];

					nr["SBoxes"] = sBoxes;
					nr["SNetto"] = sNetto;
					nr["SBrutto"] = sBrutto;
					nr["SAmount"] = sAmount;
					nr["SVAT"] = sVAT;

					nr["BillNumbersList"] += (nr["BillNumbersList"].ToString().Length == 0 ? "" : ",") +
						r["BillNumbersList"].ToString().Trim();
					nr["OrderNumbersList"] += (nr["OrderNumbersList"].ToString().Length == 0 ? "" : ",") +
						r["OrderNumbersList"].ToString().Trim();
					nr["FactureNumbersList"] += (nr["FactureNumbersList"].ToString().Length == 0 ? "" : ",") +
						r["FactureNumbersList"].ToString().Trim();

					// Меняем данные в старой таблице
					r["OrganizationInfo"] = newOrganizationInfo;
					r["ShipperInfo"] = newOrganizationInfo;
					r["PointCharge"] = newWarehouseAddress;
				}

				// Отображаем форму печати
				ActiveReport3 repTransportBill_Plus1 = new TransportBill();
				ActiveReport3 repTransportBill_All = new TransportBill();
				StartForm(new frmActiveReport(
					new DataTable[] { dtSummary, dtRep },
					new ActiveReport3[] { repTransportBill_Plus1, repTransportBill_All },
					(int)numCopies.Value));
			}
			else
			{
				if (optPrintTTNOnly.Checked || optPrintTTNandTransportBill.Checked)
				{
					ActiveReport3 repTTN = new TtnOneLine();
					StartForm(new frmActiveReport(dtRep, repTTN, (int)numCopies.Value));
				}
				if (optPrintTransportBillOnly.Checked || optPrintTTNandTransportBill.Checked)
				{
					ActiveReport3 repTransportBill = new TransportBill();
					StartForm(new frmActiveReport(dtRep, repTransportBill, (int)numCopies.Value));
				}
			}
		}
	}
}
