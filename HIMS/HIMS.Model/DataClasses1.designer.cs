﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HIMS.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HIMS.Data")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertOM_OrdersSet(OM_OrdersSet instance);
    partial void UpdateOM_OrdersSet(OM_OrdersSet instance);
    partial void DeleteOM_OrdersSet(OM_OrdersSet instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HIMS.Model.Properties.Settings.Default.HIMS_DataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<OM_OrdersSet> OM_OrdersSet
		{
			get
			{
				return this.GetTable<OM_OrdersSet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OM_OrdersSet")]
	public partial class OM_OrdersSet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _OrderId;
		
		private int _SID;
		
		private long _AccountId;
		
		private System.DateTime _DateFrom;
		
		private System.DateTime _DateTo;
		
		private System.DateTime _CreateTime;
		
		private long _AM_Accounts_AccountId;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(long value);
    partial void OnOrderIdChanged();
    partial void OnSIDChanging(int value);
    partial void OnSIDChanged();
    partial void OnAccountIdChanging(long value);
    partial void OnAccountIdChanged();
    partial void OnDateFromChanging(System.DateTime value);
    partial void OnDateFromChanged();
    partial void OnDateToChanging(System.DateTime value);
    partial void OnDateToChanged();
    partial void OnCreateTimeChanging(System.DateTime value);
    partial void OnCreateTimeChanged();
    partial void OnAM_Accounts_AccountIdChanging(long value);
    partial void OnAM_Accounts_AccountIdChanged();
    #endregion
		
		public OM_OrdersSet()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				if ((this._OrderId != value))
				{
					this.OnOrderIdChanging(value);
					this.SendPropertyChanging();
					this._OrderId = value;
					this.SendPropertyChanged("OrderId");
					this.OnOrderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="Int NOT NULL")]
		public int SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					this.OnSIDChanging(value);
					this.SendPropertyChanging();
					this._SID = value;
					this.SendPropertyChanged("SID");
					this.OnSIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountId", DbType="BigInt NOT NULL")]
		public long AccountId
		{
			get
			{
				return this._AccountId;
			}
			set
			{
				if ((this._AccountId != value))
				{
					this.OnAccountIdChanging(value);
					this.SendPropertyChanging();
					this._AccountId = value;
					this.SendPropertyChanged("AccountId");
					this.OnAccountIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateFrom", DbType="DateTime NOT NULL")]
		public System.DateTime DateFrom
		{
			get
			{
				return this._DateFrom;
			}
			set
			{
				if ((this._DateFrom != value))
				{
					this.OnDateFromChanging(value);
					this.SendPropertyChanging();
					this._DateFrom = value;
					this.SendPropertyChanged("DateFrom");
					this.OnDateFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTo", DbType="DateTime NOT NULL")]
		public System.DateTime DateTo
		{
			get
			{
				return this._DateTo;
			}
			set
			{
				if ((this._DateTo != value))
				{
					this.OnDateToChanging(value);
					this.SendPropertyChanging();
					this._DateTo = value;
					this.SendPropertyChanged("DateTo");
					this.OnDateToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AM_Accounts_AccountId", DbType="BigInt NOT NULL")]
		public long AM_Accounts_AccountId
		{
			get
			{
				return this._AM_Accounts_AccountId;
			}
			set
			{
				if ((this._AM_Accounts_AccountId != value))
				{
					this.OnAM_Accounts_AccountIdChanging(value);
					this.SendPropertyChanging();
					this._AM_Accounts_AccountId = value;
					this.SendPropertyChanged("AM_Accounts_AccountId");
					this.OnAM_Accounts_AccountIdChanged();
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
}
#pragma warning restore 1591
