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
	public partial class AttentionIndustryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public AttentionIndustryDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["iwaywardConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AttentionIndustryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttentionIndustryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttentionIndustryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AttentionIndustryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AttentionIndustry> AttentionIndustry
		{
			get
			{
				return this.GetTable<AttentionIndustry>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AttentionIndustry")]
	public partial class AttentionIndustry
	{
		
		private string _UserID;
		
		private System.Nullable<int> _IndID1;
		
		private string _IndMark1;
		
		private System.Nullable<int> _IndID2;
		
		private string _IndMark2;
		
		private System.Nullable<int> _IndID3;
		
		private string _IndMark3;
		
		public AttentionIndustry()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(50)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndID1", DbType="Int")]
		public System.Nullable<int> IndID1
		{
			get
			{
				return this._IndID1;
			}
			set
			{
				if ((this._IndID1 != value))
				{
					this._IndID1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndMark1", DbType="VarChar(MAX)")]
		public string IndMark1
		{
			get
			{
				return this._IndMark1;
			}
			set
			{
				if ((this._IndMark1 != value))
				{
					this._IndMark1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndID2", DbType="Int")]
		public System.Nullable<int> IndID2
		{
			get
			{
				return this._IndID2;
			}
			set
			{
				if ((this._IndID2 != value))
				{
					this._IndID2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndMark2", DbType="VarChar(MAX)")]
		public string IndMark2
		{
			get
			{
				return this._IndMark2;
			}
			set
			{
				if ((this._IndMark2 != value))
				{
					this._IndMark2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndID3", DbType="Int")]
		public System.Nullable<int> IndID3
		{
			get
			{
				return this._IndID3;
			}
			set
			{
				if ((this._IndID3 != value))
				{
					this._IndID3 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndMark3", DbType="VarChar(MAX)")]
		public string IndMark3
		{
			get
			{
				return this._IndMark3;
			}
			set
			{
				if ((this._IndMark3 != value))
				{
					this._IndMark3 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591