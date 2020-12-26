﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sample")]
	public partial class SampleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertEmployees(Employees instance);
    partial void InsertDepartments(Departments instance);
    partial void UpdateDepartments(Departments instance);
    partial void DeleteDepartments(Departments instance);
    #endregion
		
		public SampleDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employees> Employees
		{
			get
			{
				return this.GetTable<Employees>();
			}
		}
		
		public System.Data.Linq.Table<Departments> Departments
		{
			get
			{
				return this.GetTable<Departments>();
			}
		}
		
		private void UpdateEmployees(Employees obj)
		{
			this.UpdateEmployee(((System.Nullable<int>)(obj.ID)), obj.FirstName, obj.LastName, obj.Gender, ((System.Nullable<int>)(obj.Salary)), ((System.Nullable<int>)(obj.DepartmentId)));
		}
		
		private void DeleteEmployees(Employees obj)
		{
			this.DeleteEmployee(((System.Nullable<int>)(obj.ID)));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteEmployee")]
		public int DeleteEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmployee")]
		public int InsertEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, gender, salary, departmentId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateEmployee")]
		public int UpdateEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="NVarChar(50)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Salary", DbType="Int")] System.Nullable<int> salary, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, firstName, lastName, gender, salary, departmentId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployees")]
		public ISingleResult<GetEmployeesResult1> GetEmployees()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetEmployeesResult1>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetEmployeesByDepartment")]
		public ISingleResult<Employees> GetEmployeesByDepartment([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentId", DbType="Int")] System.Nullable<int> departmentId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DepartmentName", DbType="NVarChar(50)")] ref string departmentName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), departmentId, departmentName);
			departmentName = ((string)(result.GetParameterValue(1)));
			return ((ISingleResult<Employees>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employees : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Gender;
		
		private System.Nullable<int> _Salary;
		
		private System.Nullable<int> _DepartmentId;
		
		private EntityRef<Departments> _Departments;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnSalaryChanging(System.Nullable<int> value);
    partial void OnSalaryChanged();
    partial void OnDepartmentIdChanging(System.Nullable<int> value);
    partial void OnDepartmentIdChanged();
    #endregion
		
		public Employees()
		{
			this._Departments = default(EntityRef<Departments>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
		public System.Nullable<int> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
		public System.Nullable<int> DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					if (this._Departments.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departments_Employees", Storage="_Departments", ThisKey="DepartmentId", OtherKey="ID", IsForeignKey=true)]
		public Departments Departments
		{
			get
			{
				return this._Departments.Entity;
			}
			set
			{
				Departments previousValue = this._Departments.Entity;
				if (((previousValue != value) 
							|| (this._Departments.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departments.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Departments.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DepartmentId = value.ID;
					}
					else
					{
						this._DepartmentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Departments");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
	public partial class Departments : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Location;
		
		private EntitySet<Employees> _Employees;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
		
		public Departments()
		{
			this._Employees = new EntitySet<Employees>(new Action<Employees>(this.attach_Employees), new Action<Employees>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departments_Employees", Storage="_Employees", ThisKey="ID", OtherKey="DepartmentId")]
		public EntitySet<Employees> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
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
		
		private void attach_Employees(Employees entity)
		{
			this.SendPropertyChanging();
			entity.Departments = this;
		}
		
		private void detach_Employees(Employees entity)
		{
			this.SendPropertyChanging();
			entity.Departments = null;
		}
	}
	
	public partial class GetEmployeesResult1
	{
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Gender;
		
		private System.Nullable<int> _Salary;
		
		private System.Nullable<int> _DepartmentId;
		
		public GetEmployeesResult1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
		public System.Nullable<int> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int")]
		public System.Nullable<int> DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					this._DepartmentId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591