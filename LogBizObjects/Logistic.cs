using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Логистика (Logistic)
/// </summary>
/// 
namespace LogBizObjects
{

#region Logistic
	
	public class Logistic: BizObject
	{
		#region Поля, свойства
		#endregion Поля, свойства

		#region Фильтры
		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableLogisticsSettings;
		/// <summary>
		/// Список настроек для работы с логистикой TableLogisticsSettings
		/// </summary>
		[Description("Список настроек для работы с логистикой TableLogisticsSettings")]
		public DataTable TableLogisticsSettings { get { return _TableLogisticsSettings; } }

		#endregion Таблицы

		// ----------------------------

		public Logistic()
			: base()
		{
			_MainTableName = "Logistic";
			_ColumnID = "ID";
			_ColumnName = "ID";
		}


		#region FillData

		/// <summary>
		/// получение полного списка рейсов с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();
			return (_ErrorNumber == 0);
		}

		#endregion FillData

		#region FillOne

		// собственно заполнение свойств экземпляра объекта данными строки 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка свойств экземпляра
		/// </summary>
		public void ClearOne()
		{
			_ID = null;
		}

		#endregion FillOne


		#region LogisticsSettings

		#region Fill

		public bool FillTableLogisticsSettings(int nUserID)
		{
			string sqlSelect = "execute up_LogisticsSettingsFill @nUserID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_LogisticsSettingsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Value = nUserID;

			#endregion

			try
			{
				_TableLogisticsSettings = FillReadings(new SqlDataAdapter(_oCommand), _TableLogisticsSettings, "TableLogisticsSettings");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении настроек для работы с логистикой..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Fill

		#region Save

		/// <summary>
		/// сохранение настроек логистики
		/// </summary>
		public bool Save(int? nUserID, 
				bool bAutoJoinDocumentsInCar, bool bAutoJoinDocumentsInStorage, 
				bool? bWeightControl, bool? bVolumeControl,
				bool? bPalletsControl, bool? bPassengerCarControl, bool? bPosternControl,
				bool? bLoadLiftControl, bool? bPermitLevelControl, bool? bMaxPointsQntControl,
				bool? bMaxDurationControl)   
		{
			string _sqlCommand = "execute up_LogisticsSettingsSave @nUserID, " +
						"@bAutoJoinDocumentsInCar, @bAutoJoinDocumentsInStorage, " + 
						"@bWeightControl, @bVolumeControl, @bPalletsControl, " + 
						"@bPassengerCarControl, @bPosternControl, @bLoadLiftControl, " + 
						"@bPermitLevelControl, " +
						"@bMaxPointsQntControl, @bMaxDurationControl, " +
						"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_LogisticsSettingsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			if (nUserID.HasValue)
				_oParameter.Value = nUserID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bAutoJoinDocumentsInCar", SqlDbType.Bit);
			_oParameter.Value = bAutoJoinDocumentsInCar;

			_oParameter = _oCommand.Parameters.Add("@bAutoJoinDocumentsInStorage", SqlDbType.Bit);
			_oParameter.Value = bAutoJoinDocumentsInStorage;

			_oParameter = _oCommand.Parameters.Add("@bWeightControl", SqlDbType.Bit);
			if (bWeightControl.HasValue)
				_oParameter.Value = bWeightControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bVolumeControl", SqlDbType.Bit);
			if (bVolumeControl.HasValue)
				_oParameter.Value = bVolumeControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPalletsControl", SqlDbType.Bit);
			if (bPalletsControl.HasValue)
				_oParameter.Value = bPalletsControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPassengerCarControl", SqlDbType.Bit);
			if (bPassengerCarControl.HasValue)
				_oParameter.Value = bPassengerCarControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPosternControl", SqlDbType.Bit);
			if (bPosternControl.HasValue)
				_oParameter.Value = bPosternControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bLoadLiftControl", SqlDbType.Bit);
			if (bLoadLiftControl.HasValue)
				_oParameter.Value = bLoadLiftControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPermitLevelControl", SqlDbType.Bit);
			if (bPermitLevelControl.HasValue)
				_oParameter.Value = bPermitLevelControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bMaxPointsQntControl", SqlDbType.Bit);
			if (bMaxPointsQntControl.HasValue)
				_oParameter.Value = bMaxPointsQntControl;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bMaxDurationControl", SqlDbType.Bit);
			if (bMaxDurationControl.HasValue)
				_oParameter.Value = bMaxDurationControl;
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
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при сохранении настроек для работы с логистикой...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении настроек для работы с логистикой...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#endregion LogisticsSettings

	}

#endregion Logistic

}
