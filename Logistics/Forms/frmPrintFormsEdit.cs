using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmPrintFormsEdit : RFMFormChild
	{
		private int? nPrintFormID = null;
		private PrintForm oPrintForm;

		string sTemplateText = "";


		public frmPrintFormsEdit(int? _nPrintFormID)
		{
			oPrintForm = new PrintForm();
			if (oPrintForm.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (_nPrintFormID.HasValue)
			{
				nPrintFormID = _nPrintFormID;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmPrintFormsEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			if (nPrintFormID.HasValue)
			{
				oPrintForm.ReFillOne((int)nPrintFormID);

				txtPF_Type.Text = oPrintForm.PF_Type;
				txtPF_Name.Text = oPrintForm.PF_Name;
				numLinesInPage.Value = oPrintForm.LinesInPage;
				txtNote.Text = oPrintForm.Note;
				sTemplateText = oPrintForm.PF_XMLTemplateText;
				if (sTemplateText != null && sTemplateText.Length > 0)
				{
					btnTemplateClear.Enabled =
					btnTemplateGet.Enabled =
						true;
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
			if (txtPF_Name.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("Не указано название шаблона!");
				return;
			}

			if (sTemplateText == null || sTemplateText.Length == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не загружен файл шаблона!\nВсе-таки сохранить запись о спец.шаблоне?") != DialogResult.Yes)
					return;
			}

			// нет ли уже такой формы?
			PrintForm oPrintFormTemp = new PrintForm();
			oPrintFormTemp.FilterPF_Name = txtPF_Name.Text.Trim();
			oPrintFormTemp.FilterPF_Type = txtPF_Type.Text.Trim();
			oPrintFormTemp.FillData();
			if (oPrintFormTemp.ErrorNumber == 0 && oPrintFormTemp.MainTable != null &&
				oPrintFormTemp.MainTable.Rows.Count > 0)
			{
				foreach (DataRow r in oPrintFormTemp.MainTable.Rows)
				{
					if (nPrintFormID.HasValue && (int)r["ID"] == (int)nPrintFormID)
						continue;
					if (r["PF_Type"].ToString().ToUpper() == txtPF_Type.Text.Trim().ToUpper() &&
						r["PF_Name"].ToString().ToUpper() == txtPF_Name.Text.Trim().ToUpper())
					{
						RFMMessage.MessageBoxError("Уже есть печатная форма с таким типом и именем...");
						return;
					}
				}
			}

			// можно сохранять

			oPrintForm.PF_Type = txtPF_Type.Text;
			oPrintForm.PF_Name = txtPF_Name.Text;
			oPrintForm.LinesInPage = (int)numLinesInPage.Value;
			oPrintForm.Note = txtNote.Text;
			if (sTemplateText != null && sTemplateText != "")
			{
				oPrintForm.PF_XMLTemplateText = sTemplateText;
			}
			else
			{
				oPrintForm.PF_XMLTemplateText = null;
			}

			// собственно сохранение 
			oPrintForm.ClearError();
			if (oPrintForm.Save() && oPrintForm.ErrorNumber == 0)
			{
				MotherForm.GotParam = new object[] { (int)oPrintForm.ID };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		#region Templates Set, Clear, Get

		private void btnTemplateSet_Click(object sender, EventArgs e)
		{
			TemplateSet();
		}

		private void btnTemplateClear_Click(object sender, EventArgs e)
		{
			TemplateClear(); 
		}

		private void btnTemplateGet_Click(object sender, EventArgs e)
		{
			TemplateGet();
		}

		private bool TemplateSet()
		{
			if (sTemplateText != null && sTemplateText.Length > 0)
			{
				if (RFMMessage.MessageBoxYesNo("Шаблон уже загружен...\n\n" +
					"Все-таки загрузить новый шаблон?") != DialogResult.Yes)
					return (false); 
			}

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Выберите файл-шаблон";
			dlg.Filter = "Шаблоны rpx(*.rpx)|*.rpx" +
							"|Все файлы (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(dlg.FileName))
				{
					StreamReader sr = new StreamReader(dlg.FileName);
					sTemplateText = sr.ReadToEnd();
					sr.Close();

					if (txtPF_Name.Text.Trim() == "")
					{
						FileInfo fl = new FileInfo(dlg.FileName);
						txtPF_Name.Text = fl.Name.Replace(fl.Extension, "");
					}

					if (sTemplateText != null && sTemplateText.Length > 0)
					{
						btnTemplateClear.Enabled =
						btnTemplateGet.Enabled =
						true;
					}
				}
			}
			return (oPrintForm.ErrorNumber == 0);
		}

		private bool TemplateClear()
		{
			if (sTemplateText != null && sTemplateText.Length > 0)
			{
				if (RFMMessage.MessageBoxYesNo("Шаблон уже загружен...\n\n" +
					"Все-таки очистить шаблон?") != DialogResult.Yes)
					return (false);
			}

			sTemplateText = null;
			btnTemplateClear.Enabled =
			btnTemplateGet.Enabled = 
				false;
			return (true);
		}

		private bool TemplateGet()
		{
			if (sTemplateText == null || sTemplateText.Length == 0)
			{
				RFMMessage.MessageBoxError("Шаблон не загружен...");
				return (false);
			}

			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Title = "Сохранить шаблон в файле файл-шаблон";
			dlg.Filter = "Шаблоны rpx(*.rpx)|*.rpx" +
				"|Все файлы (*.*)|*.*";
			dlg.DefaultExt = "rpx";
			dlg.AddExtension = true;

			dlg.FileName = txtPF_Name.Text.Trim();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string sFileNameGet = dlg.FileName;
				try 
				{
					StreamWriter sw = new StreamWriter(sFileNameGet, false, Encoding.UTF8);
					sw.Write(sTemplateText);
					sw.Close();
					//File.WriteAllText(sFileNameGet, sTemplateText, Encoding.Default);
					
					/*
					string sFileNameGet_ = "_" + sFileNameGet;
					StreamWriter s = new StreamWriter(sFileNameGet_);
					s.Write(sTemplateText);
					s.Close();

					ActiveReport3 rep = new ActiveReport3();
					rep.LoadLayout(sFileNameGet_);
					rep.SaveLayout(sFileNameGet);
					*/ 
				}
				catch (Exception ex)
				{
					RFMMessage.MessageBoxError("Ошибка при сохранении шаблона...\n" + ex.Message);
					return (false); 
				}
				if (!File.Exists(sFileNameGet))
				{
					RFMMessage.MessageBoxError("Ошибка при сохранении шаблона в файл...\n");
					return (false);
				}
			}
			return (oPrintForm.ErrorNumber == 0);
		}

		#endregion Templates Set, Clear, Get

	}
}
