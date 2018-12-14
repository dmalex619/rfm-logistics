using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ �����-�������� (Good, Packing)
/// </summary>

namespace LogBizObjects
{

#region Good

	public class Good : BizObject 
	{
		protected int? _GoodID;
		/// <summary>
		/// ��� ID ������ (Goods.ID)
		/// </summary>
		[Description("��� ID ������ (Goods.ID)")]
		public int? GoodID { get { return _GoodID; } set { _GoodID = value; _NeedRequery = true; } }

		protected int? _PackingID;
		/// <summary>
		/// ��� ID �������� (Packings.ID)
		/// </summary>
		[Description("��� ID �������� (Packings.ID)")]
		public int? PackingID { get { return _PackingID; } set { _PackingID = value; _NeedRequery = true; } }

		protected string _GoodsIDList;
		/// <summary>
		/// ������ ����� ID ������� (Goods.ID)
		/// </summary>
		[Description("������ ����� ID ������� (Goods.ID)")]
		public string GoodsIDList { get { return _GoodsIDList; } set { _GoodsIDList = value; _NeedRequery = true; } }
		
		protected string _PackingsIDList;
		/// <summary>
		/// ������ ����� ID �������� (Packings.ID)
		/// </summary>
		[Description("������ ����� ID �������� (Packings.ID)")]
		public string PackingsIDList { get { return _PackingsIDList; } set { _PackingsIDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _GoodName;
		/// <summary>
		/// ������������ ������ (Goods.Name)
		/// </summary>
		[Description("������������ ������ (Goods.Name)")]
		public string GoodName { get { return _GoodName; } set { _GoodName = value; } }

		protected string _GoodAlias;
		/// <summary>
		/// ������� ������������ ������ (Goods.Alias)
		/// </summary>
		[Description("������� ������������ ������ (Goods.Alias)")]
		public string GoodAlias { get { return _GoodAlias; } set { _GoodAlias = value; } }

		protected string _PackingName;
		/// <summary>
		/// ������������ ��������-������ (Packings.Name)
		/// </summary>
		[Description("������������ ��������-������ (Packings.Name)")]
		public string PackingName { get { return _PackingName; } set { _PackingName = value; } }

		protected string _PackingAlias;
		/// <summary>
		/// ������� ������������ ��������-������ (Packings.Alias)
		/// </summary>
		[Description("������� ������������ ��������-������ (Packings.Alias)")]
		public string PackingAlias { get { return _PackingAlias; } set { _PackingAlias = value; } }

		protected string _GoodBarCode;
		/// <summary>
		/// �����-��� ������ (Goods.BarCode)
		/// </summary>
		[Description("�����-��� ������ (Goods.BarCode)")]
		public string GoodBarCode { get { return _GoodBarCode; } set { _GoodBarCode = value; } }

		protected string _PackingBarCode;
		/// <summary>
		/// �����-��� �������� (Packings.BarCode)
		/// </summary>
		[Description("�����-��� �������� (Packings.BarCode)")]
		public string PackingBarCode { get { return _PackingBarCode; } set { _PackingBarCode = value; } }

		protected string _Articul;
		/// <summary>
		/// ������� ������ (Goods.Articul)
		/// </summary>
		[Description("������� ������ (Goods.Articul)")]
		public string Articul { get { return _Articul; } set { _Articul = value; } }

		protected int _Retention;
		/// <summary>
		/// ���� ��������, ���� (Goods.Retention)
		/// </summary>
		[Description("���� ��������, ���� (Goods.Retention)")]
		public int Retention { get { return _Retention; } set { _Retention = value; } }

		protected bool _Weighting;
		/// <summary>
		/// ������� ����� (Goods.Weighting)?
		/// </summary>
		[Description("������� �����? (Goods.Weighting)")]
		public bool Weighting { get { return _Weighting; } set { _Weighting = value; } }

		protected decimal _Netto;
		/// <summary>
		/// ��� ����� ������� ������, �� (Goods.Netto)
		/// </summary>
		[Description("��� ����� ������� ������, �� (Goods.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// ��� ������ ������� ������, �� (Goods.Brutto)
		/// </summary>
		[Description("��� ������ ������� ������, �� (Goods.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected int _GoodGroupID;
		/// <summary>
		/// �������� ������ - ��� (Goods.GoodGroupID)
		/// </summary>
		[Description("�������� ������ - ��� (Goods.GoodGroupID)")]
		public int GoodGroupID { get { return _GoodGroupID; } set { _GoodGroupID = value; } }

		protected string _GoodGroupName;
		/// <summary>
		/// �������� ������ - ������������ (Goods.GoodGroupID -> GoodsGroups.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (Goods.GoodGroupID -> GoodsGroups.Name)")]
		public string GoodGroupName { get { return _GoodGroupName; } set { _GoodGroupName = value; } }

		protected int _GoodBrandID;
		/// <summary>
		/// �������� ����� - ��� (Goods.GoodBrandID)
		/// </summary>
		[Description("�������� ����� - ��� (Goods.GoodBrandID)")]
		public int GoodBrandID { get { return _GoodBrandID; } set { _GoodBrandID = value; } }

		protected string _GoodBrandName;
		/// <summary>
		/// �������� ����� - ������������ (Goods.GoodBrandID -> GoodsBrands.Name)
		/// </summary>
		[Description("�������� ����� - ������������ (Goods.GoodBrandID -> GoodsBrands.Name)")]
		public string GoodBrandName { get { return _GoodBrandName; } set { _GoodBrandName = value; } }

		protected bool _GoodActual;
		/// <summary>
		/// ����� �������� (Goods.Actual)?
		/// </summary>
		[Description("����� �������� (Goods.Actual)?")]
		public bool GoodActual { get { return _GoodActual; } set { _GoodActual = value; } }

		protected bool _PackingActual;
		/// <summary>
		/// �������� ��������� (Packings.Actual)?
		/// </summary>
		[Description("�������� ��������� (Packings.Actual)?")]
		public bool PackingActual { get { return _PackingActual; } set { _PackingActual = value; } }

		protected decimal _InBox;
		/// <summary>
		/// ���������� ������ ������ � ������� (Packings.InBox)
		/// </summary>
		[Description("���������� ������ ������ � ������� (Packings.InBox)")]
		public decimal InBox { get { return _InBox; } set { _InBox = value; } }

		protected int _BoxInPal;
		/// <summary>
		/// ���������� ������� �� ������� (Packings.BoxInPal)
		/// </summary>
		[Description("���������� ������� �� ������� (Packings.BoxInPal)")]
		public int BoxInPal { get { return _BoxInPal; } set { _BoxInPal = value; } }

		protected int _BoxInRow;
		/// <summary>
		/// ���������� ������� � ���� �� ������� (Packings.BoxInRow)
		/// </summary>
		[Description("���������� ������� � ���� �� ������� (Packings.BoxInRow)")]
		public int BoxInRow { get { return _BoxInRow; } set { _BoxInRow = value; } }

		protected decimal _BoxWeight;
		/// <summary>
		/// ��� ������ �������, �� (Packings.BoxWeight)
		/// </summary>
		[Description("��� ������ �������, �� (Packings.BoxWeight)")]
		public decimal BoxWeight { get { return _BoxWeight; } set { _BoxWeight = value; } }

		protected decimal _BoxLength;
		/// <summary>
		/// ����� �������, � (Packings.BoxLength)
		/// </summary>
		[Description("����� �������, � (Packings.BoxLength)")]
		public decimal BoxLength { get { return _BoxLength; } set { _BoxLength = value; } }

		protected decimal _BoxWidth;
		/// <summary>
		/// ������ �������, � (Packings.BoxWidth)
		/// </summary>
		[Description("������ �������, � (Packings.BoxWidth)")]
		public decimal BoxWidth { get { return _BoxWidth; } set { _BoxWidth = value; } }

		protected decimal _BoxHeight;
		/// <summary>
		/// ������ �������, � (Packings.BoxHeight)
		/// </summary>
		[Description("������ �������, � (Packings.BoxHeight)")]
		public decimal BoxHeight { get { return _BoxHeight; } set { _BoxHeight = value; } }

		protected int _PalletTypeID;
		/// <summary>
		/// ��� ������� - ��� (Packings.PalletTypeID)
		/// </summary>
		[Description("��� ������� - ��� (Packings.PalletTypeID)")]
		public int PalletTypeID { get { return _PalletTypeID; } set { _PalletTypeID = value; } }

		protected string _PalletTypeName;
		/// <summary>
		/// ��� ������� - ������������ (Packings.PalletTypeID -> PalletsTypes.Name)
		/// </summary>
		[Description("��� ������� - ������������ (Packings.PalletTypeID -> PalletsTypes.Name)")]
		public string PalletTypeName { get { return _PalletTypeName; } set { _PalletTypeName = value; } }

		protected decimal _PalletWeight;
		/// <summary>
		/// ��� �������, �� (Packings.PalletWeight)
		/// </summary>
		[Description("��� �������, �� (Packings.PalletWeight)")]
		public decimal PalletWeight { get { return _PalletWeight; } set { _PalletWeight = value; } }

		protected decimal _PalletLength;
		/// <summary>
		/// ����� �������, � (Packings.PalletLength)
		/// </summary>
		[Description("����� �������, � (Packings.PalletLength)")]
		public decimal PalletLength { get { return _PalletLength; } set { _PalletLength = value; } }

		protected decimal _PalletWidth;
		/// <summary>
		/// ������ �������, � (Packings.PalletWidth)
		/// </summary>
		[Description("������ �������, � (Packings.PalletWidth)")]
		public decimal PalletWidth { get { return _PalletWidth; } set { _PalletWidth = value; } }

		protected decimal _PalletHeight;
		/// <summary>
		/// ������ �������, � (Packings.PalletHeight)
		/// </summary>
		[Description("������ �������, � (Packings.PalletHeight)")]
		public decimal PalletHeight { get { return _PalletHeight; } set { _PalletHeight = value; } }

		protected int _CountryID;
		/// <summary>
		/// ������-������������� ������ - ��� (Goods.CountryID)
		/// </summary>
		[Description("������-������������� ������ - ��� (Goods.CountryID)")]
		public int CountryID { get { return _CountryID; } set { _CountryID = value; } }

		protected string _CountryName;
		/// <summary>
		/// ������ - ������������ (Goods.CountryID -> Countries.Name)
		/// </summary>
		[Description("������ - ������������ (Goods.CountryID -> Countries.Name)")]
		public string CountryName { get { return _CountryName; } set { _CountryName = value; } }

		protected string _Pack;
		/// <summary>
		/// ��������� �������� (Goods.Pack)
		/// </summary>
		[Description("��������� �������� (Goods.Pack)")]
		public string Pack { get { return _Pack; } set { _Pack = value; } }

		protected string _OkpCode;
		/// <summary>
		/// ��� ��� (Goods.OKPCode)
		/// </summary>
		[Description("��� ��� (Goods.OKPCode)")]
		public string OkpCode { get { return _OkpCode; } set { _OkpCode = value; } }

		protected bool _StickerNeed;
		/// <summary>
		/// ����� ������ (Goods.Actual)?
		/// </summary>
		[Description("����� ������ (Goods.Actual)?")]
		public bool StickerNeed { get { return _StickerNeed; } set { _StickerNeed = value; } }

		protected string _GoodNote;
		/// <summary>
		/// ���������� � ������ (Goods.Note)
		/// </summary>
		[Description("���������� � ������ (Goods.Note)")]
		public string GoodNote { get { return _GoodNote; } set { _GoodNote = value; } }

		protected string _PackingNote;
		/// <summary>
		/// ���������� � �������� (Packings.Note)
		/// </summary>
		[Description("���������� � �������� (Packings.Note)")]
		public string PackingNote { get { return _PackingNote; } set { _PackingNote = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (Goods.HostID)
		/// </summary>
		[Description("Host  - ��� (Goods.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (Goods.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (Goods.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _GoodERPCode;
		/// <summary>
		/// ��� ������ � host-������� (Goods.ERPCode)
		/// </summary>
		[Description("��� ������ � host-������� (Goods.ERPCode)")]
		public string GoodERPCode { get { return _GoodERPCode; } set { _GoodERPCode = value; } }

		protected string _PackingERPCode;
		/// <summary>
		/// ��� �������� � host-������� (Packings.ERPCode)
		/// </summary>
		[Description("��� �������� � host-������� (Packings.ERPCode)")]
		public string PackingERPCode { get { return _PackingERPCode; } set { _PackingERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (Goods.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (Goods.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected bool? _FilterGoodsActual;
		/// <summary>
		/// ������-����: ���������� ������?
		/// </summary>
		[Description("������-����: ���������� ������ (Goods.Actual)?")]
		public bool? FilterGoodsActual { get { return _FilterGoodsActual; } set { _FilterGoodsActual = value; _NeedRequery = true; } }

		protected bool? _FilterPackingsActual;
		/// <summary>
		/// ������-����: ���������� ��������?
		/// </summary>
		[Description("������-����: ���������� �������� (Packings.Actual)?")]
		public bool? FilterPackingsActual { get { return _FilterPackingsActual; } set { _FilterPackingsActual = value; _NeedRequery = true; } }

		protected string _FilterGoodBarCode;
		/// <summary>
		/// ������-����: �����-��� ������, �������� (Goods.BarCode)
		/// </summary>
		[Description("������-����: �����-��� ������, �������� (Goods.BarCode)")]
		public string FilterGoodBarCode { get { return _FilterGoodBarCode; } set { _FilterGoodBarCode = value; _NeedRequery = true; }	}

		protected string _FilterPackingBarCode;
		/// <summary>
		/// ������-����: �����-��� �������� (Packings.BarCode)
		/// </summary>
		[Description("������-����: �����-��� �������� (Packings.BarCode)")]
		public string FilterPackingBarCode { get { return _FilterPackingBarCode; } set { _FilterPackingBarCode = value; _NeedRequery = true; } }

		protected string _FilterGoodNameContext;
		/// <summary>
		/// ������-����: �������� ������, �������� (Goods.Name, Goods.Alias)
		/// </summary>
		[Description("������-����: �������� ������, �������� (Goods.Name, Goods.Alias)")]
		public string FilterGoodNameContext { get { return _FilterGoodNameContext; } set { _FilterGoodNameContext = value; _NeedRequery = true; } }

		protected string _FilterGoodsGroupsList;
		/// <summary>
		/// ������-����: ������ ����� �������� �����, ����� ������� (Goods.GoodGroupID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (Goods.GoodGroupID)")]
		public string FilterGoodsGroupsList { get { return _FilterGoodsGroupsList; } set { _FilterGoodsGroupsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsBrandsList;
		/// <summary>
		/// ������-����: ������ ����� �������� �������, ����� ������� (Goods.GoodBrandID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �������, ����� ������� (Goods.GoodBrandID)")]
		public string FilterGoodsBrandsList { get { return _FilterGoodsBrandsList; } set { _FilterGoodsBrandsList = value; _NeedRequery = true; } }

        protected string _FilterCountriesList;
        /// <summary>
        /// ������-����: ������ ����� ������������, ����� ������� (Goods.CountryID)
        /// </summary>
        [Description("������-����: ������ ����� ������������, ����� ������� (Goods.CountryID)")]
        public string FilterCountriesList { get { return _FilterCountriesList; } set { _FilterCountriesList = value; _NeedRequery = true; } }

        protected bool? _FilterQualitiesExists;
        /// <summary>
        /// ������-����: ���������� ������������ ����������?
        /// </summary>
        [Description("������-����: ���������� ������������ ����������?")]
        public bool? FilterQualitiesExists { get { return _FilterQualitiesExists; } set { _FilterQualitiesExists = value; _NeedRequery = true; } }

        protected bool? _FilterVeterinariesExists;
        /// <summary>
        /// ������-����: ������������ ������������� ����������?
        /// </summary>
        [Description("������-����: ������������ ������������� ����������?")]
        public bool? FilterVeterinariesExists { get { return _FilterVeterinariesExists; } set { _FilterVeterinariesExists = value; _NeedRequery = true; } }

        #endregion �������

		#region �������

		protected DataTable _TableGoodsGroups;
		/// <summary>
		/// ������� �������� ����� GoodsGroups
		/// </summary>
		[Description("������� �������� ����� GoodsGroups")]
		public DataTable TableGoodsGroups { get { return _TableGoodsGroups; } }

		protected DataTable _TableGoodsBrands;
		/// <summary>
		/// ������� �������� ������� GoodsBrands
		/// </summary>
		[Description("������� �������� ������� GoodsBrands")]
		public DataTable TableGoodsBrands { get { return _TableGoodsBrands; } }

		protected DataTable _TablePalletsTypes;
		/// <summary>
		/// ������� ����� �������� PalletsTypes
		/// </summary>
		[Description("������� ����� �������� PalletsTypes")]
		public DataTable TablePalletsTypes { get { return _TablePalletsTypes; } }

		protected DataTable _TableGoodsQualities;
		/// <summary>
		/// ������� ������ � ����������� ������������ TableGoodsQualities
		/// </summary>
        [Description("������� ������ � ����������� ������������ TableGoodsQualities")]
		public DataTable TableGoodsQualities { get { return _TableGoodsQualities; } }

		protected DataTable _TableGoodsQualitiesMapping;
		/// <summary>
        /// ������� ������ � ����������� ������������ � �������� TableGoodsQualitiesMapping
		/// </summary>
        [Description("������� ������ � ����������� ������������ � �������� TableGoodsQualitiesMapping")]
		public DataTable TableGoodsQualitiesMapping { get { return _TableGoodsQualitiesMapping; } }

        protected DataTable _TableGoodsQualitiesForSelect;
        /// <summary>
        /// ������� ������ ��� ������ ����� ��������� �������� � ����������� ������������ TableGoodsQualitiesForSelect
        /// </summary>
        [Description("������� ������ ��� ������ ����� ��������� �������� � ����������� ������������ TableGoodsQualitiesForSelect")]
        public DataTable TableGoodsQualitiesForSelect { get { return _TableGoodsQualitiesForSelect; } }

		protected DataTable _TableGoodsVeterinaries;
		/// <summary>
		/// ������� ������ � ������������ �������������� TableGoodsVeterinaries
		/// </summary>
		[Description("������� ������ � ������������ �������������� TableGoodsVeterinaries")]
		public DataTable TableGoodsVeterinaries { get { return _TableGoodsVeterinaries; } }

		protected DataTable _TableGoodsVeterinariesMapping;
		/// <summary>
		/// ������� ������ � ������������ �������������� TableGoodsVeterinariesMapping
		/// </summary>
		[Description("������� ������ � ������������ �������������� TableGoodsVeterinariesMapping")]
		public DataTable TableGoodsVeterinariesMapping { get { return _TableGoodsVeterinariesMapping; } }

		protected DataTable _TableGoodsCustoms;
		/// <summary>
		/// ������� ������ � ��� TableGoodsCustoms
		/// </summary>
		[Description("������� ������ � ��� TableGoodsCustoms")]
		public DataTable TableGoodsCustoms { get { return _TableGoodsCustoms; } }

		protected DataTable _TableGoodsQualitiesList;
		/// <summary>
        /// �������-������ ���������� ������������
		/// </summary>
        [Description("�������-������ ���������� ������������ TableGoodsQualitiesList")]
		public DataTable TableGoodsQualitiesList { get { return _TableGoodsQualitiesList; } }

        protected DataTable _TableCountries;
        /// <summary>
        /// ������� ����� ������������ Countries
        /// </summary>
        [Description("������� ����� ������������ Countries")]
        public DataTable TableCountries { get { return _TableCountries; } }


		#region ������� ��� ������

		protected bool? _Filter_TableGoodsGroups_Actual;
		/// <summary>
		/// ������-���� ��� ������� �������� �����: ���������? (GoodsGroups.Actual)
		/// </summary>
		[Description("������-���� ��� ������� �������� �����: ���������? (GoodsGroups.Actual)")]
		public bool? Filter_TableGoodsGroups_Actual { get { return _Filter_TableGoodsGroups_Actual; } set { _Filter_TableGoodsGroups_Actual = value; _NeedRequery = true; } }

		protected string _Filter_TableGoodsGroups_NameContext;
		/// <summary>
		/// ������-���� ��� ������� �������� �����: �������� �������� (GoodsGroups.Name)
		/// </summary>
		[Description("������-���� ��� ������� �������� �����: �������� �������� (GoodsGroups.Name)")]
		public string Filter_TableGoodsGroups_NameContext { get { return _Filter_TableGoodsGroups_NameContext; } set { _Filter_TableGoodsGroups_NameContext = value; _NeedRequery = true; } }

		protected bool? _Filter_TableGoodsBrands_Actual;
		/// <summary>
		/// ������-���� ��� ������� �������� �������: ���������? (GoodsBrands.Actual)
		/// </summary>
		[Description("������-���� ��� ������� ������� : ���������? (GoodsBrands.Actual)")]
		public bool? Filter_TableGoodsBrands_Actual { get { return _Filter_TableGoodsBrands_Actual; } set { _Filter_TableGoodsBrands_Actual = value; _NeedRequery = true; } }

		protected string _Filter_TableGoodsBrands_NameContext;
		/// <summary>
		/// ������-���� ��� ������� �������� �������: �������� �������� (GoodsBrands.Name)
		/// </summary>
		[Description("������-���� ��� ������� �������: �������� �������� (GoodsBrands.Name)")]
		public string Filter_TableGoodsBrands_NameContext { get { return _Filter_TableGoodsBrands_NameContext; } set { _Filter_TableGoodsBrands_NameContext = value; _NeedRequery = true; } }

		#endregion ������� ��� ������

		#endregion �������

		// -------------------
		
		public Good() : base()
		{
			_MainTableName = "Goods";
			_ColumnID = "PackingID";
			_ColumnName = "GoodAlias"; 
		}

		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������� � ���������� ����������, c����� �������� � ������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_GoodsFill @nGoodID, @nPackingID, " +
									"@cGoodsIDList, @cPackingsIDList, " + 
									"@cHostsList, " + 
									"@cGoodBarCode, @cPackingBarCode, " + 
									"@bGoodsActual, @bPackingsActual, " + 
									"@cGoodNameContext, " +
                                    "@cGoodsGroupsList, @cGoodsBrandsList, @cCountriesList, " +
                                    "@bQualitiesExists, @bVeterinariesExists";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsFill Parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodID", SqlDbType.Int);
			if (_GoodID != null)
				_oParameter.Value = _GoodID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPackingID", SqlDbType.Int);
			if (_PackingID != null)
				_oParameter.Value = _PackingID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsIDList", SqlDbType.VarChar);
			if (_GoodsIDList != null)
				_oParameter.Value = _GoodsIDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPackingsIDList", SqlDbType.VarChar);
			if (_PackingsIDList != null)
				_oParameter.Value = _PackingsIDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
			if (_FilterHostsList != null)
				_oParameter.Value = _FilterHostsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodBarCode", SqlDbType.VarChar, 20);
			if (_FilterGoodBarCode != null)
				_oParameter.Value = _FilterGoodBarCode;
			else
				_oParameter.Value = DBNull.Value;
	
			_oParameter = _oCommand.Parameters.Add("@cPackingBarCode", SqlDbType.VarChar, 20);
			if (_FilterPackingBarCode != null)
				_oParameter.Value = _FilterPackingBarCode;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bGoodsActual", SqlDbType.Bit);
			if (_FilterGoodsActual != null)
				_oParameter.Value = _FilterGoodsActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPackingsActual", SqlDbType.Bit);
			if (_FilterPackingsActual != null)
				_oParameter.Value = _FilterPackingsActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodNameContext", SqlDbType.VarChar, 200);
			if (_FilterGoodNameContext != null)
				_oParameter.Value = _FilterGoodNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsGroupsList", SqlDbType.VarChar);
			if (_FilterGoodsGroupsList != null)
				_oParameter.Value = _FilterGoodsGroupsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsBrandsList", SqlDbType.VarChar);
			if (_FilterGoodsBrandsList != null)
				_oParameter.Value = _FilterGoodsBrandsList;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cCountriesList", SqlDbType.VarChar);
            if (_FilterCountriesList != null)
                _oParameter.Value = _FilterCountriesList;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bQualitiesExists", SqlDbType.Bit);
            if (_FilterQualitiesExists != null)
                _oParameter.Value = _FilterQualitiesExists;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bVeterinariesExists", SqlDbType.Bit);
            if (_FilterVeterinariesExists != null)
                _oParameter.Value = _FilterVeterinariesExists;
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
				_ErrorStr = "������ ��� ��������� ������ ������ �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public void ClearFilters()
		{
			_GoodsIDList = null;
			_PackingsIDList = null;

			_FilterHostsList = null;
			_FilterGoodBarCode = null;
			_FilterGoodNameContext = null;
			_FilterGoodsActual = null;
			_FilterPackingBarCode = null;
			_FilterPackingsActual = null;
			_FilterGoodsBrandsList = null;
			_FilterGoodsGroupsList = null;
            _FilterCountriesList = null;
            _FilterQualitiesExists = null;
            _FilterVeterinariesExists = null;
		}

		#endregion FillData

		#region FillOne

		// ���������� ���������� ������� ���������� ������� ������� ������ 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);

					_GoodID = Convert.ToInt32(r["GoodID"]);
					_PackingID = Convert.ToInt32(r["PackingID"]);

					_GoodAlias = r["GoodAlias"].ToString();
					_GoodName = r["GoodName"].ToString();

					_PackingAlias = r["PackingAlias"].ToString();
					_PackingName = r["PackingName"].ToString();

					_GoodBarCode = r["GoodBarCode"].ToString();
					_PackingBarCode = r["PackingBarCode"].ToString();

					_GoodActual = Convert.ToBoolean(r["GoodActual"]);
					_PackingActual = Convert.ToBoolean(r["PackingActual"]);

					_GoodGroupID = Convert.ToInt32(r["GoodGroupID"]);
					_GoodGroupName = r["GoodGroupName"].ToString();

					_GoodBrandID = Convert.ToInt32(r["GoodBrandID"]);
					_GoodBrandName = r["GoodBrandName"].ToString();

					_Articul = r["Articul"].ToString();
					_Retention = Convert.ToInt32(r["Retention"]);
					_Weighting = Convert.ToBoolean(r["Weighting"]);

					_Netto = Convert.ToDecimal(r["Netto"]);
					_Brutto = Convert.ToDecimal(r["Brutto"]);

					_InBox = Convert.ToDecimal(r["InBox"]);
					_BoxInPal = Convert.ToInt32(r["BoxInPal"]);
					_BoxInRow = Convert.ToInt32(r["BoxInRow"]);

					_BoxWeight = Convert.ToDecimal(r["BoxWeight"]);
					_BoxLength = Convert.ToDecimal(r["BoxLength"]);
					_BoxWidth = Convert.ToDecimal(r["BoxWidth"]);
					_BoxHeight = Convert.ToDecimal(r["BoxHeight"]);

					_PalletTypeID = Convert.ToInt32(r["PalletTypeID"]);
					_PalletTypeName = r["PalletTypeName"].ToString();

					_PalletWeight = Convert.ToDecimal(r["PalletWeight"]);
					_PalletLength = Convert.ToDecimal(r["PalletLength"]);
					_PalletWidth = Convert.ToDecimal(r["PalletWidth"]);
					_PalletHeight = Convert.ToDecimal(r["PalletHeight"]);

					_CountryID = Convert.ToInt32(r["CountryID"]);
					_CountryName = r["CountryName"].ToString();

					_Pack = r["Pack"].ToString();
					_OkpCode = r["OkpCode"].ToString();
					_StickerNeed = Convert.ToBoolean(r["StickerNeed"]);

					_GoodNote = r["GoodNote"].ToString();
					_PackingNote = r["PackingNote"].ToString();

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					_GoodERPCode = r["GoodERPCode"].ToString();
					_PackingERPCode = r["PackingERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � �������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ������� (��� ������)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������� ����������
		/// </summary>
		public void ClearOne()
		{
			_ID = null;

			_GoodID = null;
			_PackingID = null;

			_GoodAlias = "";
			_GoodName = "";

			_PackingAlias = "";
			_PackingName = "";

			_GoodBarCode = "";
			_PackingBarCode = "";

			_GoodActual = false;
			_PackingActual = false;

			_GoodGroupID = 0;
			_GoodGroupName = "";

			_GoodBrandID = 0;
			_GoodBrandName = "";

			_Articul = "";
			_Retention = 0;
			_Weighting = false;

			_Netto = 0;
			_Brutto = 0;

			_InBox = 0;
			_BoxInPal = 0;
			_BoxInRow = 0;

			_BoxWeight = 0;
			_BoxLength = 0;
			_BoxWidth = 0;
			_BoxHeight = 0;

			_PalletTypeID = 0;
			_PalletTypeName = "";

			_PalletWeight = 0;
			_PalletLength = 0;
			_PalletWidth = 0;
			_PalletHeight = 0;

			_CountryID = 0;
			_CountryName = "";

			_Pack = "";
			_OkpCode = "";
			_StickerNeed = false;

			_GoodNote = "";
			_PackingNote = "";

			_HostID = null;
			_HostName = null;

			_GoodERPCode = null;
			_PackingERPCode = null;
		}

		#endregion FillOne

		#region �������

		/// <summary>
		/// ��������� ������� �������� ����� (TableGoodsGroups)
		/// </summary>
		public bool FillTableGoodsGroups()
		{
			string sqlSelect = "select GG.ID, GG.Name, GG.Actual, " + 
					"GG.HostID, HS.Name as HostName, " + 
					"GG.ERPCode " + 
				"from GoodsGroups GG with (nolock) " + 
				"left join Hosts HS with (nolock) on GG.HostID = HS.ID " + 
				"where 1 = 1 ";
			if (_FilterHostsList != null)
				sqlSelect += " and GG.HostID in (" + RFMUtilities.NormalizeList(_FilterHostsList) + ") ";
			if (_Filter_TableGoodsGroups_Actual != null)
				sqlSelect += " and GG.Actual = " + (Convert.ToBoolean(_Filter_TableGoodsGroups_Actual) ? "1" : "0");
			if (_Filter_TableGoodsGroups_NameContext != null)
				sqlSelect += " and charindex(upper('" + _Filter_TableGoodsGroups_NameContext + "'), upper(GG.Name)) > 0";
			if (_FilterGoodsGroupsList != null)
				sqlSelect += " and charindex(',' + ltrim(str(GG.ID)) + ',', ',' + '" + _FilterGoodsGroupsList + "' + ',') > 0";
			sqlSelect += " order by GG.Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableGoodsGroups = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsGroups, "TableGoodsGroups");
				_TableGoodsGroups.PrimaryKey = new DataColumn[] { _TableGoodsGroups.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ �������� �����..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� �������� ������� (TableGoodsBrands)
		/// </summary>
		public bool FillTableGoodsBrands()
		{
			string sqlSelect = "select GB.ID, GB.Name, GB.Actual, " +
					"GB.HostID, HS.Name as HostName, " +
					"GB.ERPCode " +
				"from GoodsBrands GB with (nolock) " +
				"left join Hosts HS with (nolock) on GB.HostID = HS.ID " +
				"where 1 = 1 ";
			if (_FilterHostsList != null)
				sqlSelect += " and GB.HostID in (" + RFMUtilities.NormalizeList(_FilterHostsList) + ") ";
			if (_Filter_TableGoodsBrands_Actual != null)
				sqlSelect += " where GB.Actual = " + (Convert.ToBoolean(_Filter_TableGoodsBrands_Actual) ? "1" : "0");
			if (_Filter_TableGoodsBrands_NameContext != null)
				sqlSelect += " and charindex(upper('" + _Filter_TableGoodsBrands_NameContext + "'), upper(GB.Name)) > 0";
			if (_FilterGoodsBrandsList != null)
				sqlSelect += " and charindex(',' + ltrim(str(GB.ID)) + ',', ',' + '" + _FilterGoodsBrandsList + "' + ',') > 0";
			sqlSelect += " order by GB.Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableGoodsBrands = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsBrands, "TableGoodsBrands");
				_TableGoodsBrands.PrimaryKey = new DataColumn[] { _TableGoodsBrands.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ��������� ������ �������� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ����� �������� (TablePalletsTypes)
		/// </summary>
		public bool FillTablePalletsTypes()
		{
			string sqlSelect = 
				"select ID, Name, " +
						"PalletWeight, PalletLength, PalletWidth, PalletHeight, " +
						"Actual " + 
				   "from PalletsTypes " + 
				   "where 1 = 1 ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TablePalletsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TablePalletsTypes, "TablePalletsTypes");
				_TablePalletsTypes.PrimaryKey = new DataColumn[] { _TablePalletsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -13;
				_ErrorStr = "������ ��� ��������� ������ ����� ��������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// ��������� ������� ����� ������������ (TableCountries)
        /// </summary>
        public bool FillTableCountries()
        {
            string sqlSelect = "select ID, Name from Countries where 1 = 1 ";
            sqlSelect += " order by Name";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                _TableCountries = FillReadings(new SqlDataAdapter(_oCommand), _TableCountries, "TableCountries");
                _TableCountries.PrimaryKey = new DataColumn[] { _TableCountries.Columns[0] };
            }
            catch (Exception ex)
            {
                _ErrorNumber = -11;
                _ErrorStr = "������ ��� ��������� ������ ����� ������������..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
		/// ������� ������-����� ��� ������
		/// </summary>
		public void ClearFilters_Tables()
		{
			_Filter_TableGoodsBrands_Actual = null;
			_Filter_TableGoodsBrands_NameContext = null;
			_Filter_TableGoodsGroups_Actual = null;
			_Filter_TableGoodsGroups_NameContext = null;
		}

		#region Additional 

		#region Quality 

		/// <summary>
        /// ������ � ����������� ������������
		/// </summary>
		public bool FillTableGoodsQualities(int? nGoodQualityID, string sGoodsQualitiesIDList)
		{
			string sqlSelect = "execute up_GoodsQualitiesFill @nGoodQualityID, @cGoodsQualitiesIDList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsQualitiesFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodQualityID", SqlDbType.Int);
			if (nGoodQualityID.HasValue)
				_oParameter.Value = nGoodQualityID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsQualitiesIDList", SqlDbType.VarChar);
			if (sGoodsQualitiesIDList != null)
				_oParameter.Value = sGoodsQualitiesIDList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableGoodsQualities = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsQualities, "TableGoodsQualities");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ � ����������� ������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
        /// ������ � ����������� ������������ - � ��������
		/// </summary>
		public bool FillTableGoodsQualitiesMapping(int? nGoodQualityID, int? nGoodID, string sGoodsIDList)
		{
			string sqlSelect = "execute up_GoodsQualitiesMappingFill @nGoodQualityID, @nGoodID, @cGoodsIDList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsQualitiesMappingFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodQualityID", SqlDbType.Int);
			if (nGoodQualityID.HasValue)
				_oParameter.Value = nGoodQualityID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nGoodID", SqlDbType.Int);
			if (nGoodID.HasValue)
				_oParameter.Value = nGoodID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsIDList", SqlDbType.VarChar);
			if (sGoodsIDList != null)
				_oParameter.Value = sGoodsIDList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableGoodsQualitiesMapping = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsQualitiesMapping, "TableGoodsQualitiesMapping");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
                _ErrorStr = "������ ��� ��������� ������ � ����������� ������������ ��� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// ������ � ����������� ������������ - ����� ��������� ��������
        /// </summary>
        public bool FillTableGoodsQualitiesForSelect(string sValue)
        {
            if (sValue != "Issuer" && sValue != "Holder")
            {
                _ErrorNumber = -11;
                _ErrorStr = "������ ��� ��������� ������ � ����� ��������� ��������� � ����������� ������������..." + Convert.ToChar(13) + "�������� ��������";
                RFMMessage.MessageBoxError(_ErrorStr);
                return false;
            }

            string sqlSelect = "if object_id('Tempdb.dbo.#ForSelect') is not Null drop table #ForSelect; " +
                "create table #ForSelect (ID int identity(1,1), Value varchar(max)); " +
                "insert #ForSelect (Value) " +
                    "select distinct Quality" + sValue + " as Value " + 
                    "from GoodsQualities GQ with (nolock) " + 
                    "where len(Quality" + sValue + ") > 0; " +
                    "select * from #ForSelect order by Value";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                _TableGoodsQualitiesForSelect = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsQualitiesForSelect, "TableGoodsQualitiesForSelect");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -11;
                _ErrorStr = "������ ��� ��������� ������ � ����� ��������� ��������� � ����������� ������������..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

		#endregion Quality

		#region Veterinary

		/// <summary>
		/// ������ � ������������ ��������������
		/// </summary>
		public bool FillTableGoodsVeterinaries(int? nGoodVeterinaryID, string sGoodsVeterinariesIDList)
		{
			string sqlSelect = "execute up_GoodsVeterinariesFill @nGoodVeterinaryID, @cGoodsVeterinariesIDList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsVeterinariesFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodVeterinaryID", SqlDbType.Int);
			if (nGoodVeterinaryID.HasValue)
				_oParameter.Value = nGoodVeterinaryID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsVeterinariesIDList", SqlDbType.VarChar);
			if (sGoodsVeterinariesIDList != null)
				_oParameter.Value = sGoodsVeterinariesIDList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableGoodsVeterinaries = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsVeterinaries, "TableGoodsVeterinaries");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ � ������������ ��������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ � ������������ �������������� - � ��������
		/// </summary>
		public bool FillTableGoodsVeterinariesMapping(int? nGoodVeterinaryID, int? nGoodID, string sGoodsIDList)
		{
			string sqlSelect = "execute up_GoodsVeterinariesMappingFill @nGoodVeterinaryID, @nGoodID, @cGoodsIDList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsVeterinariesMappingFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodVeterinaryID", SqlDbType.Int);
			if (nGoodVeterinaryID.HasValue)
				_oParameter.Value = nGoodVeterinaryID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nGoodID", SqlDbType.Int);
			if (nGoodID.HasValue)
				_oParameter.Value = nGoodID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsIDList", SqlDbType.VarChar);
			if (sGoodsIDList != null)
				_oParameter.Value = sGoodsIDList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableGoodsVeterinariesMapping = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsVeterinariesMapping, "TableGoodsVeterinariesMapping");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ � ������������ �������������� ��� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Veterinary

		#region Customs
		
		/// <summary>
		/// ������ � ���
		/// </summary>
		public bool FillTableGoodsCustoms(string sCustomNumber, DateTime? dDateBeg, string sGoodsIDList, bool bDistinct)
		{
			string sqlSelect = "execute up_GoodsCustomsFill @cCustomNumber, @dDateBeg, @cGoodsIDList, @bDistinct";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsCustomsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cCustomNumber", SqlDbType.VarChar);
			if (sCustomNumber != null)
				_oParameter.Value = sCustomNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg.HasValue)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsIDList", SqlDbType.VarChar);
			if (sGoodsIDList != null)
				_oParameter.Value = sGoodsIDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDistinct", SqlDbType.Bit);
			_oParameter.Value = bDistinct;

			#endregion

			try
			{
				_TableGoodsCustoms = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsCustoms, "TableGoodsCustoms");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ � ���..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}
        
		#endregion Customs

		#endregion Additional

		#endregion �������

		#region ������

		/// <summary>
		/// ��������� ������ � �������-��������� ��� ������ (TableDataTree)
		/// sMode: "brand" - �� �������� �������, "group" � ������ - �� �������� �������
		/// </summary>
		public bool FillDataTree(string sMode, bool? bActual)
		{
			string sqlSelect = "";
			if (_FilterHostsList != null)
				sqlSelect = "select * " +
					"from .dbo.GoodsTreeHost('" + sMode + "', " + 
						(bActual.HasValue ? (((bool)bActual) ? "1" : "0") : "Null") + ", " + 
						"'" + _FilterHostsList + "') " +
					"order by ParentID, Name";
			else 
				sqlSelect = "select * " + 
					"from .dbo.GoodsTree('" + sMode + "', " + 
						(bActual.HasValue ? ((bool)bActual ? "1" : "0") : "Null") + ") " +  
					"order by ParentID, Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableDataTree");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "������ ��� ��������� �������������� ������ (������) �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion ������

		#region GoodQuality

		/// <summary>
		/// ���������� ������ � ���������� ������������
		/// </summary>
		public bool SaveGoodQuality(ref int? nGoodQualityID,
                string sQualityLicence, string sQualityIssuer, string sQualityHolder, 
				DateTime? dDateBeg, DateTime? dDateEnd, 
				DataTable tGoodsQualities)
		{
			string _sqlCommand = "execute up_GoodsQualitiesSave @nGoodQualityID output, " +
                    "@cQualityLicence, @cQualityIssuer, @cQualityHolder, " +
					"@dDateBeg, @dDateEnd, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GoodsQualitiesSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodQualityID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (nGoodQualityID.HasValue)
				_oParameter.Value = nGoodQualityID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cQualityLicence", SqlDbType.VarChar);
			if (sQualityLicence.Length > 0)
				_oParameter.Value = sQualityLicence;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cQualityIssuer", SqlDbType.VarChar);
			if (sQualityIssuer.Length > 0)
				_oParameter.Value = sQualityIssuer;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cQualityHolder", SqlDbType.VarChar);
            if (sQualityHolder.Length > 0)
                _oParameter.Value = sQualityHolder;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg.HasValue)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd.HasValue)
				_oParameter.Value = dDateEnd;
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
				if (tGoodsQualities != null)
					RFMUtilities.DataTableToTempTable(tGoodsQualities, "#GoodsQualities", _Connect);
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ������ � ���������� ������������...\r\n" + ex.Message;
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
                    _ErrorStr = "������ ��� ���������� ������ � ���������� ������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
                // ��� �������� ������ ���������� ������������ - ������� �� ���
				if ((!nGoodQualityID.HasValue || nGoodQualityID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nGoodQualityID"].Value))
				{
					nGoodQualityID = (int)_oCommand.Parameters["@nGoodQualityID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
        /// �������� ������ � ���������� ������������
		/// </summary>
		public bool DeleteGoodQuality(int nGoodQualityID)
		{
			String _sqlCommand = "execute up_GoodsQualitiesDelete @nGoodQualityID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GoodsQualitiesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodQualityID", SqlDbType.Int);
			_oParameter.Value = nGoodQualityID;

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
                _ErrorStr = "������ ��� �������� ������ � ���������� ������������ ��� �������...\r\n" + ex.Message;
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
                    _ErrorStr = "������ ��� �������� ������ � ���������� ������������ ��� �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

	/// <summary>
    /// ���������� ������ � ���������� ������������
	/// </summary>
	public bool FillTableGoodsQualititiesList(bool bValid, DataTable dT)
		{
		string _sqlCommand = "execute up_GoodsQualitiesList @bValid, " +
				"@nError output, @cErrorText output";
		SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

		#region up_GoodsQualitiesList parameters

		SqlParameter _oParameter = _oCommand.Parameters.Add("@bValid", SqlDbType.Bit);
		_oParameter.Value = bValid;

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
 			RFMUtilities.DataTableToTempTable(dT, "#GoodsQualities", _Connect);
			_TableGoodsQualitiesList = FillReadings(new SqlDataAdapter(_oCommand), _TableGoodsQualitiesList, "TableGoodsQualitiesList");
			}
		catch (Exception ex)
			{
			_ErrorNumber = -10;
            _ErrorStr = "������ ��� ��������� ������ ���������� ������������...\r\n" + ex.Message;
			RFMMessage.MessageBoxError(_ErrorStr);
			}
		finally
			{
				_Connect.Close();
			}
		return (_ErrorNumber == 0);
		}

		#endregion GoodQuality

		#region GoodVeterinary

		/// <summary>
		/// ���������� ������ � ������������ �������������
		/// </summary>
		public bool SaveGoodVeterinary(ref int? nGoodVeterinaryID,
				string sVeterinaryLicence, string sProducer,
				string sName, string sNote, 
				string sMark, string sLaboratory, 
                string sDateOfProducing, 
				DateTime? dDateBeg, 
                string sExportXML, 
				DataTable tGoodsVeterinaries)
		{
			string _sqlCommand = "execute up_GoodsVeterinariesSave @nGoodVeterinaryID output, " +
                    "@cVeterinaryLicence, @cProducer, @cName, @cNote, @cMark, @cLaboratory, @cDateOfProducing, " +
                    "@dDateBeg, @cExportXML, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GoodsVeterinariesSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodVeterinaryID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (nGoodVeterinaryID.HasValue)
				_oParameter.Value = nGoodVeterinaryID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cVeterinaryLicence", SqlDbType.VarChar);
			if (sVeterinaryLicence.Length > 0)
				_oParameter.Value = sVeterinaryLicence;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cProducer", SqlDbType.VarChar);
			if (sProducer.Length > 0)
				_oParameter.Value = sProducer;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cName", SqlDbType.VarChar);
			if (sName.Length > 0)
				_oParameter.Value = sName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (sNote.Length > 0)
				_oParameter.Value = sNote;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cMark", SqlDbType.VarChar);
			if (sMark.Length > 0)
				_oParameter.Value = sMark;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cLaboratory", SqlDbType.VarChar);
            if (sLaboratory.Length > 0)
                _oParameter.Value = sLaboratory;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cDateOfProducing", SqlDbType.VarChar);
            if (sDateOfProducing.Length > 0)
                _oParameter.Value = sDateOfProducing;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg.HasValue)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cExportXML", SqlDbType.VarChar);
            if (sExportXML.Length > 0)
                _oParameter.Value = sExportXML;
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
				if (tGoodsVeterinaries != null)
					RFMUtilities.DataTableToTempTable(tGoodsVeterinaries, "#GoodsVeterinaries", _Connect);
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ������ � ������������ �������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ � ������������ �������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
                // ��� �������� ����� ���������� ������������ - ������� �� ���
				if ((!nGoodVeterinaryID.HasValue || nGoodVeterinaryID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nGoodVeterinaryID"].Value))
				{
					nGoodVeterinaryID = (int)_oCommand.Parameters["@nGoodVeterinaryID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������ � ������������ �������������
		/// </summary>
		public bool DeleteGoodVeterinary(int nGoodVeterinaryID)
		{
			String _sqlCommand = "execute up_GoodsVeterinariesDelete @nGoodVeterinaryID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GoodsVeterinariesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGoodVeterinaryID", SqlDbType.Int);
			_oParameter.Value = nGoodVeterinaryID;

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
				_ErrorStr = "������ ��� �������� ������ � ������������ �������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � ������������ �������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion GoodVeterinary

		#region GoodCustom

        /// <summary>
        /// ���������� ������ � ���
        /// </summary>
		public bool SaveGoodCustom(string sCustomNumber, DateTime? dDateBeg, DataTable tableGoodsCustoms)
        {
            string _sqlCommand = "execute up_GoodsCustomsSave @cCustomNumber, " +
                    "@dDateBeg, @nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

            #region  up_GoodsCustomsSave parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@cCustomNumber", SqlDbType.VarChar);
            _oParameter.Direction = ParameterDirection.Input;
            if (sCustomNumber.Length > 0)
                _oParameter.Value = sCustomNumber;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
            if (dDateBeg.HasValue)
                _oParameter.Value = dDateBeg;
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
				if (tableGoodsCustoms != null)
				{
					RFMUtilities.DataTableToTempTable(tableGoodsCustoms, "#GoodsCustoms", _Connect);
				}
                _oCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                _ErrorNumber = -10;
                _ErrorStr = "������ ��� ������� ���������� ������ � ���...\r\n" + ex.Message;
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
                    _ErrorStr = "������ ��� ���������� ������ � ���...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            return (_ErrorNumber == 0);
        }

		/// <summary>
		/// �������� ������ � ���
		/// </summary>
		public bool DeleteGoodCustom(string sCustomNumber)
		{
            String _sqlCommand = "delete GoodsCustomsNumbers " + 
				"where CustomNumber = '" + sCustomNumber + "'";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorStr = "������ ��� �������� ������ � ���...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion GoodCustom

	}

#endregion Good

}
