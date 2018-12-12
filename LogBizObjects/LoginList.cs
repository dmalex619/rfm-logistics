using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

namespace LogBizObjects
{
	public class LoginList : BizObject
	{
		/// <summary>
		/// Конструктор объекта "Список пользователей для входа в систему".
		/// </summary>
		[Category("Logistics")]
		[Description("Конструктор объекта SqlLink")]
		public LoginList() : base()
		{
			if (_Connect == null)
				return;
			_MainTableName = "UsersList";
		}

		/// <summary>
		/// Возвращает DataSet со списком пользователей системы.
		/// </summary>
		public override bool FillDataAsync()
		{
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter("select ID, Name, Alias, LocPath, NetPath from _Users where Actual = 1 order by Name", _Connect);
				adapter.Fill(_DS, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка сотрудников..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public override bool FillOneRow(DataRow r)
		{
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Проверяет пароль для заданного пользователя.
		/// </summary>
		public bool CheckPassword(int userId, string userPassword)
		{
			SqlCommand command = new SqlCommand("select Password from _Users where ID = @nUserId", _Connect);
			SqlParameter parameter = new SqlParameter();
			command.Parameters.Add("@nUserId", SqlDbType.Int).Value = userId;
			_Connect.Open();
			object sqlPassword = command.ExecuteScalar();
			_Connect.Close();

			return (sqlPassword.ToString() == userPassword);
		}
	}
}