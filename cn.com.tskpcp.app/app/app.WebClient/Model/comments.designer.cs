﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace app.WebClient.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="iwayward")]
	public partial class commentsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertcomments(comments instance);
    partial void Updatecomments(comments instance);
    partial void Deletecomments(comments instance);
    #endregion
		
		public commentsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["iwaywardConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public commentsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public commentsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public commentsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public commentsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<comments> comments
		{
			get
			{
				return this.GetTable<comments>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comments")]
	public partial class comments : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _commID;
		
		private System.Nullable<int> _serviceID;
		
		private string _context;
		
		private string _commDateTime;
		
		private System.Nullable<int> _UserID;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncommIDChanging(int value);
    partial void OncommIDChanged();
    partial void OnserviceIDChanging(System.Nullable<int> value);
    partial void OnserviceIDChanged();
    partial void OncontextChanging(string value);
    partial void OncontextChanged();
    partial void OncommDateTimeChanging(string value);
    partial void OncommDateTimeChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public comments()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_commID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int commID
		{
			get
			{
				return this._commID;
			}
			set
			{
				if ((this._commID != value))
				{
					this.OncommIDChanging(value);
					this.SendPropertyChanging();
					this._commID = value;
					this.SendPropertyChanged("commID");
					this.OncommIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serviceID", DbType="Int")]
		public System.Nullable<int> serviceID
		{
			get
			{
				return this._serviceID;
			}
			set
			{
				if ((this._serviceID != value))
				{
					this.OnserviceIDChanging(value);
					this.SendPropertyChanging();
					this._serviceID = value;
					this.SendPropertyChanged("serviceID");
					this.OnserviceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_context", DbType="VarChar(MAX)")]
		public string context
		{
			get
			{
				return this._context;
			}
			set
			{
				if ((this._context != value))
				{
					this.OncontextChanging(value);
					this.SendPropertyChanging();
					this._context = value;
					this.SendPropertyChanged("context");
					this.OncontextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_commDateTime", DbType="NVarChar(50)")]
		public string commDateTime
		{
			get
			{
				return this._commDateTime;
			}
			set
			{
				if ((this._commDateTime != value))
				{
					this.OncommDateTimeChanging(value);
					this.SendPropertyChanging();
					this._commDateTime = value;
					this.SendPropertyChanged("commDateTime");
					this.OncommDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
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
