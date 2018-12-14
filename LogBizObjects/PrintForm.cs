using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Печатная форма (PrintForm)
/// </summary>
/// 
namespace LogBizObjects
{

#region PrintForm

	public class PrintForm : BizObject
	{
		#region Поля, свойства

		protected string _PF_Name;
		/// <summary>
		/// Наименование (PrintForms.PF_Name)
		/// </summary>
		[Description("Наименование (PrintForms.PF_Name)")]
		public string PF_Name { get { return _PF_Name; } set { _PF_Name = value; } }

		protected string _PF_Type;
		/// <summary>
		/// Тип (PrintForms.PF_Type)
		/// </summary>
		[Description("Тип (PrintForms.PF_Type)")]
		public string PF_Type { get { return _PF_Type; } set { _PF_Type = value; } }

		protected string _PF_XMLTemplateText;
		/// <summary>
		/// XML-текст шаблона (PrintForms.PF_XMLTemplateText)
		/// </summary>
		[Description("XML-текст шаблона (PrintForms.PF_XMLTemplateText)")]
		public string PF_XMLTemplateText { get { return _PF_XMLTemplateText; } set { _PF_XMLTemplateText = value; } }

		protected int _LinesInPage;
		/// <summary>
		/// Число строк на странице (PrintForms.LinesInPage)
		/// </summary>
		[Description("Число строк на странице (PrintForms.LinesInPage)")]
		public int LinesInPage { get { return _LinesInPage; } set { _LinesInPage = value; } }
		
		protected string _Note;
		/// <summary>
		/// Примечания (PrintForms.Note)
		/// </summary>
		[Description("Примечания (PrintForms.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код печатной формы в host-системе (PrintForms.ERPCode)
		/// </summary>
		[Description("Код печатной формы в host-системе (PrintForms.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterPF_Name;
		/// <summary>
		/// Фильтр-поле: контекст названия (PrintForms.PF_Name)
		/// </summary>
		[Description("Фильтр-поле: контекст названия (PrintForms.PF_Name)")]
		public string FilterPF_Name { get { return _FilterPF_Name; } set { _FilterPF_Name = value; _NeedRequery = true; } }

		protected string _FilterPF_Type;
		/// <summary>
		/// Фильтр-поле: контекст типа (PrintForms.PF_Type)
		/// </summary>
		[Description("Фильтр-поле: контекст типа (PrintForms.PF_Type)")]
		public string FilterPF_Type { get { return _FilterPF_Type; } set { _FilterPF_Type = value; _NeedRequery = true; } }

		#endregion Фильтры

		// ----------------------------

		public PrintForm()
			: base()
		{
			_MainTableName = "PrintForms";
			_ColumnID = "ID";
			_ColumnName = "PF_Name";
		}


		#region FillData

		/// <summary>
		/// получение списка печатных форм
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_PrintFormsFill @nID, " +
									"@cPF_Type, " +
									"@cPF_Name ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PrintFormsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_ID != null)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPF_Type", SqlDbType.VarChar);
			if (_FilterPF_Type != null)
				_oParameter.Value = _FilterPF_Type;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPF_Name", SqlDbType.VarChar);
			if (_FilterPF_Name != null)
				_oParameter.Value = _FilterPF_Name;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка печатных форм..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка фильтр-полей
		/// </summary>
		public void ClearFilters()
		{
			_FilterPF_Name = null;
			_FilterPF_Type = null;
			//_NeedRequery = true;
		}

		#endregion FillData

		#region FillOne

		// собственно заполнение свойств экземпляра объекта данными строки 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);
					_PF_Name = r["PF_Name"].ToString();
					_PF_Type = r["PF_Type"].ToString();

					_PF_XMLTemplateText = r["PF_XMLTemplateText"].ToString();

					_LinesInPage = Convert.ToInt32(r["LinesInPage"]);

					_Note = r["Note"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о печатной форме...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о печатной форме (нет данных)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка свойств экземпляра
		/// </summary>
		public void ClearOne()
		{
			_ID = null;
			_PF_Name = null;
			_PF_Type = null;
			_PF_XMLTemplateText = null;
			_LinesInPage = 0;
			_Note = null;
			_ERPCode = null; 
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// сохранение данных о печатной форме
		/// </summary>
		public bool Save()
		{
			string _sqlCommand = "execute up_PrintFormsSave @nPrintFormID output, " +
						"@cPF_Type, " +
						"@cPF_Name, " +
						"@cPF_XMLTemplateText, " +
						"@nLinesInPage, " +
						"@cNote, " +
						"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PrintFormsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPrintFormID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPF_Type", SqlDbType.VarChar);
			if (_PF_Type != null)
				_oParameter.Value = PF_Type;
			else
				_oParameter.Value = DBNull.Value;
			
			_oParameter = _oCommand.Parameters.Add("@cPF_Name", SqlDbType.VarChar);
			if (_PF_Name != null)
				_oParameter.Value = PF_Name;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPF_XMLTemplateText", SqlDbType.VarChar);
			if (_PF_XMLTemplateText != null)
				_oParameter.Value = _PF_XMLTemplateText;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nLinesInPage", SqlDbType.VarChar);
			_oParameter.Value = _LinesInPage;

            _oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке сохранения данных о печатной форме...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при сохранении данных о печатной форме...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}

				// при создании новой записи - получим ее код 
				if ((!_ID.HasValue || (int)_ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nPrintFormID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nPrintFormID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление печатной формы
		/// </summary>
		public bool Delete(int nPrintFormID)
		{
			string _sqlCommand = "execute up_PrintFormsDelete @nPrintFormID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PrintFormsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPrintFormID", SqlDbType.Int);
			_oParameter.Value = nPrintFormID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке удаления данных о печатной форме...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при удалении данных о печатной форме...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

	}

#endregion PrintForm

}
