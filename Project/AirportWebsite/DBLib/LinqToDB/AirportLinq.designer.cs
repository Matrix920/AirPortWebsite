#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLib.LinqToDB
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AriportDb")]
	public partial class AirportLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCity(City instance);
    partial void UpdateCity(City instance);
    partial void DeleteCity(City instance);
    partial void InsertPlane(Plane instance);
    partial void UpdatePlane(Plane instance);
    partial void DeletePlane(Plane instance);
    partial void InsertCompany(Company instance);
    partial void UpdateCompany(Company instance);
    partial void DeleteCompany(Company instance);
    #endregion
		
		public AirportLinqDataContext() : 
				base(global::DBLib.Properties.Settings.Default.AriportDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AirportLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
		
		public System.Data.Linq.Table<Plane> Planes
		{
			get
			{
				return this.GetTable<Plane>();
			}
		}
		
		public System.Data.Linq.Table<Company> Companies
		{
			get
			{
				return this.GetTable<Company>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.City")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CityID;
		
		private string _CityCode;
		
		private string _CityName;
		
		private string _Position;
		
		private EntitySet<Plane> _Planes;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCityIDChanging(int value);
    partial void OnCityIDChanged();
    partial void OnCityCodeChanging(string value);
    partial void OnCityCodeChanged();
    partial void OnCityNameChanging(string value);
    partial void OnCityNameChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    #endregion
		
		public City()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int CityID
		{
			get
			{
				return this._CityID;
			}
			set
			{
				if ((this._CityID != value))
				{
					this.OnCityIDChanging(value);
					this.SendPropertyChanging();
					this._CityID = value;
					this.SendPropertyChanged("CityID");
					this.OnCityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string CityCode
		{
			get
			{
				return this._CityCode;
			}
			set
			{
				if ((this._CityCode != value))
				{
					this.OnCityCodeChanging(value);
					this.SendPropertyChanging();
					this._CityCode = value;
					this.SendPropertyChanged("CityCode");
					this.OnCityCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string CityName
		{
			get
			{
				return this._CityName;
			}
			set
			{
				if ((this._CityName != value))
				{
					this.OnCityNameChanging(value);
					this.SendPropertyChanging();
					this._CityName = value;
					this.SendPropertyChanged("CityName");
					this.OnCityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Plane", Storage="_Planes", ThisKey="CityID", OtherKey="CityID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5, EmitDefaultValue=false)]
		public EntitySet<Plane> Planes
		{
			get
			{
				if ((this.serializing 
							&& (this._Planes.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Planes;
			}
			set
			{
				this._Planes.Assign(value);
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
		
		private void attach_Planes(Plane entity)
		{
			this.SendPropertyChanging();
			entity.City = this;
		}
		
		private void detach_Planes(Plane entity)
		{
			this.SendPropertyChanging();
			entity.City = null;
		}
		
		private void Initialize()
		{
			this._Planes = new EntitySet<Plane>(new Action<Plane>(this.attach_Planes), new Action<Plane>(this.detach_Planes));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Plane")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Plane : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlaneID;
		
		private int _CompanyID;
		
		private int _CityID;
		
		private string _PlaneName;
		
		private string _CurrentState;
		
		private string _Type;
		
		private int _Speed;
		
		private string _Direction;
		
		private string _CurrentPosition;
		
		private EntityRef<City> _City;
		
		private EntityRef<Company> _Company;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlaneIDChanging(int value);
    partial void OnPlaneIDChanged();
    partial void OnCompanyIDChanging(int value);
    partial void OnCompanyIDChanged();
    partial void OnCityIDChanging(int value);
    partial void OnCityIDChanged();
    partial void OnPlaneNameChanging(string value);
    partial void OnPlaneNameChanged();
    partial void OnCurrentStateChanging(string value);
    partial void OnCurrentStateChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSpeedChanging(int value);
    partial void OnSpeedChanged();
    partial void OnDirectionChanging(string value);
    partial void OnDirectionChanged();
    partial void OnCurrentPositionChanging(string value);
    partial void OnCurrentPositionChanged();
    #endregion
		
		public Plane()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaneID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int PlaneID
		{
			get
			{
				return this._PlaneID;
			}
			set
			{
				if ((this._PlaneID != value))
				{
					this.OnPlaneIDChanging(value);
					this.SendPropertyChanging();
					this._PlaneID = value;
					this.SendPropertyChanged("PlaneID");
					this.OnPlaneIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyID", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int CompanyID
		{
			get
			{
				return this._CompanyID;
			}
			set
			{
				if ((this._CompanyID != value))
				{
					if (this._Company.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._CompanyID = value;
					this.SendPropertyChanged("CompanyID");
					this.OnCompanyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityID", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public int CityID
		{
			get
			{
				return this._CityID;
			}
			set
			{
				if ((this._CityID != value))
				{
					if (this._City.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCityIDChanging(value);
					this.SendPropertyChanging();
					this._CityID = value;
					this.SendPropertyChanged("CityID");
					this.OnCityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaneName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string PlaneName
		{
			get
			{
				return this._PlaneName;
			}
			set
			{
				if ((this._PlaneName != value))
				{
					this.OnPlaneNameChanging(value);
					this.SendPropertyChanging();
					this._PlaneName = value;
					this.SendPropertyChanged("PlaneName");
					this.OnPlaneNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentState", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string CurrentState
		{
			get
			{
				return this._CurrentState;
			}
			set
			{
				if ((this._CurrentState != value))
				{
					this.OnCurrentStateChanging(value);
					this.SendPropertyChanging();
					this._CurrentState = value;
					this.SendPropertyChanged("CurrentState");
					this.OnCurrentStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public int Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direction", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public string Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				if ((this._Direction != value))
				{
					this.OnDirectionChanging(value);
					this.SendPropertyChanging();
					this._Direction = value;
					this.SendPropertyChanged("Direction");
					this.OnDirectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentPosition", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public string CurrentPosition
		{
			get
			{
				return this._CurrentPosition;
			}
			set
			{
				if ((this._CurrentPosition != value))
				{
					this.OnCurrentPositionChanging(value);
					this.SendPropertyChanging();
					this._CurrentPosition = value;
					this.SendPropertyChanged("CurrentPosition");
					this.OnCurrentPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Plane", Storage="_City", ThisKey="CityID", OtherKey="CityID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public City City
		{
			get
			{
				return this._City.Entity;
			}
			set
			{
				City previousValue = this._City.Entity;
				if (((previousValue != value) 
							|| (this._City.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._City.Entity = null;
						previousValue.Planes.Remove(this);
					}
					this._City.Entity = value;
					if ((value != null))
					{
						value.Planes.Add(this);
						this._CityID = value.CityID;
					}
					else
					{
						this._CityID = default(int);
					}
					this.SendPropertyChanged("City");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_Plane", Storage="_Company", ThisKey="CompanyID", OtherKey="CompanyID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Company Company
		{
			get
			{
				return this._Company.Entity;
			}
			set
			{
				Company previousValue = this._Company.Entity;
				if (((previousValue != value) 
							|| (this._Company.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Company.Entity = null;
						previousValue.Planes.Remove(this);
					}
					this._Company.Entity = value;
					if ((value != null))
					{
						value.Planes.Add(this);
						this._CompanyID = value.CompanyID;
					}
					else
					{
						this._CompanyID = default(int);
					}
					this.SendPropertyChanged("Company");
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
		
		private void Initialize()
		{
			this._City = default(EntityRef<City>);
			this._Company = default(EntityRef<Company>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Company")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Company : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CompanyID;
		
		private string _CompanyCode;
		
		private string _CompanyName;
		
		private string _Nationality;
		
		private EntitySet<Plane> _Planes;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCompanyIDChanging(int value);
    partial void OnCompanyIDChanged();
    partial void OnCompanyCodeChanging(string value);
    partial void OnCompanyCodeChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnNationalityChanging(string value);
    partial void OnNationalityChanged();
    #endregion
		
		public Company()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int CompanyID
		{
			get
			{
				return this._CompanyID;
			}
			set
			{
				if ((this._CompanyID != value))
				{
					this.OnCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._CompanyID = value;
					this.SendPropertyChanged("CompanyID");
					this.OnCompanyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string CompanyCode
		{
			get
			{
				return this._CompanyCode;
			}
			set
			{
				if ((this._CompanyCode != value))
				{
					this.OnCompanyCodeChanging(value);
					this.SendPropertyChanging();
					this._CompanyCode = value;
					this.SendPropertyChanged("CompanyCode");
					this.OnCompanyCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nationality", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Nationality
		{
			get
			{
				return this._Nationality;
			}
			set
			{
				if ((this._Nationality != value))
				{
					this.OnNationalityChanging(value);
					this.SendPropertyChanging();
					this._Nationality = value;
					this.SendPropertyChanged("Nationality");
					this.OnNationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Company_Plane", Storage="_Planes", ThisKey="CompanyID", OtherKey="CompanyID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5, EmitDefaultValue=false)]
		public EntitySet<Plane> Planes
		{
			get
			{
				if ((this.serializing 
							&& (this._Planes.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Planes;
			}
			set
			{
				this._Planes.Assign(value);
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
		
		private void attach_Planes(Plane entity)
		{
			this.SendPropertyChanging();
			entity.Company = this;
		}
		
		private void detach_Planes(Plane entity)
		{
			this.SendPropertyChanging();
			entity.Company = null;
		}
		
		private void Initialize()
		{
			this._Planes = new EntitySet<Plane>(new Action<Plane>(this.attach_Planes), new Action<Plane>(this.detach_Planes));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
}
#pragma warning restore 1591
