﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="adminPC")]
	public partial class DataDiagramDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDuAn(DuAn instance);
    partial void UpdateDuAn(DuAn instance);
    partial void DeleteDuAn(DuAn instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhanCong(PhanCong instance);
    partial void UpdatePhanCong(PhanCong instance);
    partial void DeletePhanCong(PhanCong instance);
    partial void InsertPhongBan(PhongBan instance);
    partial void UpdatePhongBan(PhongBan instance);
    partial void DeletePhongBan(PhongBan instance);
    #endregion
		
		public DataDiagramDataContext() : 
				base(global::DAL.Properties.Settings.Default.adminPCConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataDiagramDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDiagramDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDiagramDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataDiagramDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DuAn> DuAns
		{
			get
			{
				return this.GetTable<DuAn>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<PhanCong> PhanCongs
		{
			get
			{
				return this.GetTable<PhanCong>();
			}
		}
		
		public System.Data.Linq.Table<PhongBan> PhongBans
		{
			get
			{
				return this.GetTable<PhongBan>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DuAn")]
	public partial class DuAn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDA;
		
		private string _TenDA;
		
		private string _DiaDiem;
		
		private string _MaPB;
		
		private EntitySet<PhanCong> _PhanCongs;
		
		private EntityRef<PhongBan> _PhongBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDAChanging(string value);
    partial void OnMaDAChanged();
    partial void OnTenDAChanging(string value);
    partial void OnTenDAChanged();
    partial void OnDiaDiemChanging(string value);
    partial void OnDiaDiemChanged();
    partial void OnMaPBChanging(string value);
    partial void OnMaPBChanged();
    #endregion
		
		public DuAn()
		{
			this._PhanCongs = new EntitySet<PhanCong>(new Action<PhanCong>(this.attach_PhanCongs), new Action<PhanCong>(this.detach_PhanCongs));
			this._PhongBan = default(EntityRef<PhongBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDA", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDA
		{
			get
			{
				return this._MaDA;
			}
			set
			{
				if ((this._MaDA != value))
				{
					this.OnMaDAChanging(value);
					this.SendPropertyChanging();
					this._MaDA = value;
					this.SendPropertyChanged("MaDA");
					this.OnMaDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDA", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string TenDA
		{
			get
			{
				return this._TenDA;
			}
			set
			{
				if ((this._TenDA != value))
				{
					this.OnTenDAChanging(value);
					this.SendPropertyChanging();
					this._TenDA = value;
					this.SendPropertyChanged("TenDA");
					this.OnTenDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaDiem", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DiaDiem
		{
			get
			{
				return this._DiaDiem;
			}
			set
			{
				if ((this._DiaDiem != value))
				{
					this.OnDiaDiemChanging(value);
					this.SendPropertyChanging();
					this._DiaDiem = value;
					this.SendPropertyChanged("DiaDiem");
					this.OnDiaDiemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPB", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string MaPB
		{
			get
			{
				return this._MaPB;
			}
			set
			{
				if ((this._MaPB != value))
				{
					if (this._PhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPBChanging(value);
					this.SendPropertyChanging();
					this._MaPB = value;
					this.SendPropertyChanged("MaPB");
					this.OnMaPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DuAn_PhanCong", Storage="_PhanCongs", ThisKey="MaDA", OtherKey="MaDA")]
		public EntitySet<PhanCong> PhanCongs
		{
			get
			{
				return this._PhanCongs;
			}
			set
			{
				this._PhanCongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_DuAn", Storage="_PhongBan", ThisKey="MaPB", OtherKey="MaPB", IsForeignKey=true)]
		public PhongBan PhongBan
		{
			get
			{
				return this._PhongBan.Entity;
			}
			set
			{
				PhongBan previousValue = this._PhongBan.Entity;
				if (((previousValue != value) 
							|| (this._PhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PhongBan.Entity = null;
						previousValue.DuAns.Remove(this);
					}
					this._PhongBan.Entity = value;
					if ((value != null))
					{
						value.DuAns.Add(this);
						this._MaPB = value.MaPB;
					}
					else
					{
						this._MaPB = default(string);
					}
					this.SendPropertyChanged("PhongBan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.DuAn = this;
		}
		
		private void detach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.DuAn = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NS;
		
		private System.Nullable<bool> _GT;
		
		private System.Nullable<int> _Luong;
		
		private string _MaNGS;
		
		private string _MaPB;
		
		private EntitySet<PhanCong> _PhanCongs;
		
		private EntityRef<PhongBan> _PhongBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNSChanging(System.Nullable<System.DateTime> value);
    partial void OnNSChanged();
    partial void OnGTChanging(System.Nullable<bool> value);
    partial void OnGTChanged();
    partial void OnLuongChanging(System.Nullable<int> value);
    partial void OnLuongChanged();
    partial void OnMaNGSChanging(string value);
    partial void OnMaNGSChanged();
    partial void OnMaPBChanging(string value);
    partial void OnMaPBChanged();
    #endregion
		
		public NhanVien()
		{
			this._PhanCongs = new EntitySet<PhanCong>(new Action<PhanCong>(this.attach_PhanCongs), new Action<PhanCong>(this.detach_PhanCongs));
			this._PhongBan = default(EntityRef<PhongBan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NS", DbType="Date")]
		public System.Nullable<System.DateTime> NS
		{
			get
			{
				return this._NS;
			}
			set
			{
				if ((this._NS != value))
				{
					this.OnNSChanging(value);
					this.SendPropertyChanging();
					this._NS = value;
					this.SendPropertyChanged("NS");
					this.OnNSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GT", DbType="Bit")]
		public System.Nullable<bool> GT
		{
			get
			{
				return this._GT;
			}
			set
			{
				if ((this._GT != value))
				{
					this.OnGTChanging(value);
					this.SendPropertyChanging();
					this._GT = value;
					this.SendPropertyChanged("GT");
					this.OnGTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Luong", DbType="Int")]
		public System.Nullable<int> Luong
		{
			get
			{
				return this._Luong;
			}
			set
			{
				if ((this._Luong != value))
				{
					this.OnLuongChanging(value);
					this.SendPropertyChanging();
					this._Luong = value;
					this.SendPropertyChanged("Luong");
					this.OnLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNGS", DbType="NChar(10)")]
		public string MaNGS
		{
			get
			{
				return this._MaNGS;
			}
			set
			{
				if ((this._MaNGS != value))
				{
					this.OnMaNGSChanging(value);
					this.SendPropertyChanging();
					this._MaNGS = value;
					this.SendPropertyChanged("MaNGS");
					this.OnMaNGSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPB", DbType="NChar(10)")]
		public string MaPB
		{
			get
			{
				return this._MaPB;
			}
			set
			{
				if ((this._MaPB != value))
				{
					if (this._PhongBan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaPBChanging(value);
					this.SendPropertyChanging();
					this._MaPB = value;
					this.SendPropertyChanged("MaPB");
					this.OnMaPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_PhanCong", Storage="_PhanCongs", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<PhanCong> PhanCongs
		{
			get
			{
				return this._PhanCongs;
			}
			set
			{
				this._PhanCongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_NhanVien", Storage="_PhongBan", ThisKey="MaPB", OtherKey="MaPB", IsForeignKey=true)]
		public PhongBan PhongBan
		{
			get
			{
				return this._PhongBan.Entity;
			}
			set
			{
				PhongBan previousValue = this._PhongBan.Entity;
				if (((previousValue != value) 
							|| (this._PhongBan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PhongBan.Entity = null;
						previousValue.NhanViens.Remove(this);
					}
					this._PhongBan.Entity = value;
					if ((value != null))
					{
						value.NhanViens.Add(this);
						this._MaPB = value.MaPB;
					}
					else
					{
						this._MaPB = default(string);
					}
					this.SendPropertyChanged("PhongBan");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_PhanCongs(PhanCong entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhanCong")]
	public partial class PhanCong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _MaDA;
		
		private System.Nullable<decimal> _SoGio;
		
		private EntityRef<DuAn> _DuAn;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnMaDAChanging(string value);
    partial void OnMaDAChanged();
    partial void OnSoGioChanging(System.Nullable<decimal> value);
    partial void OnSoGioChanged();
    #endregion
		
		public PhanCong()
		{
			this._DuAn = default(EntityRef<DuAn>);
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDA", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDA
		{
			get
			{
				return this._MaDA;
			}
			set
			{
				if ((this._MaDA != value))
				{
					if (this._DuAn.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDAChanging(value);
					this.SendPropertyChanging();
					this._MaDA = value;
					this.SendPropertyChanged("MaDA");
					this.OnMaDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoGio", DbType="Decimal(3,1)")]
		public System.Nullable<decimal> SoGio
		{
			get
			{
				return this._SoGio;
			}
			set
			{
				if ((this._SoGio != value))
				{
					this.OnSoGioChanging(value);
					this.SendPropertyChanging();
					this._SoGio = value;
					this.SendPropertyChanged("SoGio");
					this.OnSoGioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DuAn_PhanCong", Storage="_DuAn", ThisKey="MaDA", OtherKey="MaDA", IsForeignKey=true)]
		public DuAn DuAn
		{
			get
			{
				return this._DuAn.Entity;
			}
			set
			{
				DuAn previousValue = this._DuAn.Entity;
				if (((previousValue != value) 
							|| (this._DuAn.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DuAn.Entity = null;
						previousValue.PhanCongs.Remove(this);
					}
					this._DuAn.Entity = value;
					if ((value != null))
					{
						value.PhanCongs.Add(this);
						this._MaDA = value.MaDA;
					}
					else
					{
						this._MaDA = default(string);
					}
					this.SendPropertyChanged("DuAn");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_PhanCong", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.PhanCongs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.PhanCongs.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhongBan")]
	public partial class PhongBan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPB;
		
		private string _TenPB;
		
		private string _DiaDiem;
		
		private string _MaTP;
		
		private EntitySet<DuAn> _DuAns;
		
		private EntitySet<NhanVien> _NhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPBChanging(string value);
    partial void OnMaPBChanged();
    partial void OnTenPBChanging(string value);
    partial void OnTenPBChanged();
    partial void OnDiaDiemChanging(string value);
    partial void OnDiaDiemChanged();
    partial void OnMaTPChanging(string value);
    partial void OnMaTPChanged();
    #endregion
		
		public PhongBan()
		{
			this._DuAns = new EntitySet<DuAn>(new Action<DuAn>(this.attach_DuAns), new Action<DuAn>(this.detach_DuAns));
			this._NhanViens = new EntitySet<NhanVien>(new Action<NhanVien>(this.attach_NhanViens), new Action<NhanVien>(this.detach_NhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPB", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPB
		{
			get
			{
				return this._MaPB;
			}
			set
			{
				if ((this._MaPB != value))
				{
					this.OnMaPBChanging(value);
					this.SendPropertyChanging();
					this._MaPB = value;
					this.SendPropertyChanged("MaPB");
					this.OnMaPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenPB", DbType="NVarChar(MAX)")]
		public string TenPB
		{
			get
			{
				return this._TenPB;
			}
			set
			{
				if ((this._TenPB != value))
				{
					this.OnTenPBChanging(value);
					this.SendPropertyChanging();
					this._TenPB = value;
					this.SendPropertyChanged("TenPB");
					this.OnTenPBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaDiem", DbType="NVarChar(MAX)")]
		public string DiaDiem
		{
			get
			{
				return this._DiaDiem;
			}
			set
			{
				if ((this._DiaDiem != value))
				{
					this.OnDiaDiemChanging(value);
					this.SendPropertyChanging();
					this._DiaDiem = value;
					this.SendPropertyChanged("DiaDiem");
					this.OnDiaDiemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTP", DbType="NChar(10)")]
		public string MaTP
		{
			get
			{
				return this._MaTP;
			}
			set
			{
				if ((this._MaTP != value))
				{
					this.OnMaTPChanging(value);
					this.SendPropertyChanging();
					this._MaTP = value;
					this.SendPropertyChanged("MaTP");
					this.OnMaTPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_DuAn", Storage="_DuAns", ThisKey="MaPB", OtherKey="MaPB")]
		public EntitySet<DuAn> DuAns
		{
			get
			{
				return this._DuAns;
			}
			set
			{
				this._DuAns.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhongBan_NhanVien", Storage="_NhanViens", ThisKey="MaPB", OtherKey="MaPB")]
		public EntitySet<NhanVien> NhanViens
		{
			get
			{
				return this._NhanViens;
			}
			set
			{
				this._NhanViens.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DuAns(DuAn entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = this;
		}
		
		private void detach_DuAns(DuAn entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = null;
		}
		
		private void attach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = this;
		}
		
		private void detach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.PhongBan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan
	{
		
		private string _username;
		
		private string _password;
		
		private string _name;
		
		private string _phone;
		
		private string _email;
		
		public TaiKhoan()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NChar(20)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(MAX)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this._phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(MAX)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
	}
}
#pragma warning restore 1591