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

namespace BudgetBuddy.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BudgetBuddy")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttransaction(transaction instance);
    partial void Updatetransaction(transaction instance);
    partial void Deletetransaction(transaction instance);
    partial void Insertusers_bank_account(users_bank_account instance);
    partial void Updateusers_bank_account(users_bank_account instance);
    partial void Deleteusers_bank_account(users_bank_account instance);
    partial void Insertuser_detail(user_detail instance);
    partial void Updateuser_detail(user_detail instance);
    partial void Deleteuser_detail(user_detail instance);
    partial void Insertuser_todo(user_todo instance);
    partial void Updateuser_todo(user_todo instance);
    partial void Deleteuser_todo(user_todo instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::BudgetBuddy.Properties.Settings.Default.BudgetBuddyConnectionString3, mappingSource)
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
		
		public System.Data.Linq.Table<transaction> transactions
		{
			get
			{
				return this.GetTable<transaction>();
			}
		}
		
		public System.Data.Linq.Table<users_bank_account> users_bank_accounts
		{
			get
			{
				return this.GetTable<users_bank_account>();
			}
		}
		
		public System.Data.Linq.Table<user_detail> user_details
		{
			get
			{
				return this.GetTable<user_detail>();
			}
		}
		
		public System.Data.Linq.Table<user_todo> user_todos
		{
			get
			{
				return this.GetTable<user_todo>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.transactions")]
	public partial class transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _transaction_id;
		
		private string _receiver_account_number;
		
		private string _transaction_type;
		
		private string _transaction_name;
		
		private decimal _amount;
		
		private System.DateTime _transaction_date;
		
		private System.Nullable<int> _sender_account;
		
		private EntityRef<users_bank_account> _users_bank_account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontransaction_idChanging(int value);
    partial void Ontransaction_idChanged();
    partial void Onreceiver_account_numberChanging(string value);
    partial void Onreceiver_account_numberChanged();
    partial void Ontransaction_typeChanging(string value);
    partial void Ontransaction_typeChanged();
    partial void Ontransaction_nameChanging(string value);
    partial void Ontransaction_nameChanged();
    partial void OnamountChanging(decimal value);
    partial void OnamountChanged();
    partial void Ontransaction_dateChanging(System.DateTime value);
    partial void Ontransaction_dateChanged();
    partial void Onsender_accountChanging(System.Nullable<int> value);
    partial void Onsender_accountChanged();
    #endregion
		
		public transaction()
		{
			this._users_bank_account = default(EntityRef<users_bank_account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transaction_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int transaction_id
		{
			get
			{
				return this._transaction_id;
			}
			set
			{
				if ((this._transaction_id != value))
				{
					this.Ontransaction_idChanging(value);
					this.SendPropertyChanging();
					this._transaction_id = value;
					this.SendPropertyChanged("transaction_id");
					this.Ontransaction_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receiver_account_number", DbType="VarChar(255)")]
		public string receiver_account_number
		{
			get
			{
				return this._receiver_account_number;
			}
			set
			{
				if ((this._receiver_account_number != value))
				{
					this.Onreceiver_account_numberChanging(value);
					this.SendPropertyChanging();
					this._receiver_account_number = value;
					this.SendPropertyChanged("receiver_account_number");
					this.Onreceiver_account_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transaction_type", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string transaction_type
		{
			get
			{
				return this._transaction_type;
			}
			set
			{
				if ((this._transaction_type != value))
				{
					this.Ontransaction_typeChanging(value);
					this.SendPropertyChanging();
					this._transaction_type = value;
					this.SendPropertyChanged("transaction_type");
					this.Ontransaction_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transaction_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string transaction_name
		{
			get
			{
				return this._transaction_name;
			}
			set
			{
				if ((this._transaction_name != value))
				{
					this.Ontransaction_nameChanging(value);
					this.SendPropertyChanging();
					this._transaction_name = value;
					this.SendPropertyChanged("transaction_name");
					this.Ontransaction_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Decimal(9,2) NOT NULL")]
		public decimal amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transaction_date", DbType="Date NOT NULL")]
		public System.DateTime transaction_date
		{
			get
			{
				return this._transaction_date;
			}
			set
			{
				if ((this._transaction_date != value))
				{
					this.Ontransaction_dateChanging(value);
					this.SendPropertyChanging();
					this._transaction_date = value;
					this.SendPropertyChanged("transaction_date");
					this.Ontransaction_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sender_account", DbType="Int")]
		public System.Nullable<int> sender_account
		{
			get
			{
				return this._sender_account;
			}
			set
			{
				if ((this._sender_account != value))
				{
					if (this._users_bank_account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsender_accountChanging(value);
					this.SendPropertyChanging();
					this._sender_account = value;
					this.SendPropertyChanged("sender_account");
					this.Onsender_accountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_bank_account_transaction", Storage="_users_bank_account", ThisKey="sender_account", OtherKey="usersBA_id", IsForeignKey=true)]
		public users_bank_account users_bank_account
		{
			get
			{
				return this._users_bank_account.Entity;
			}
			set
			{
				users_bank_account previousValue = this._users_bank_account.Entity;
				if (((previousValue != value) 
							|| (this._users_bank_account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._users_bank_account.Entity = null;
						previousValue.transactions.Remove(this);
					}
					this._users_bank_account.Entity = value;
					if ((value != null))
					{
						value.transactions.Add(this);
						this._sender_account = value.usersBA_id;
					}
					else
					{
						this._sender_account = default(Nullable<int>);
					}
					this.SendPropertyChanged("users_bank_account");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users_bank_accounts")]
	public partial class users_bank_account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usersBA_id;
		
		private string _account_number;
		
		private string _account_type;
		
		private string _owner_name;
		
		private System.DateTime _expiry_date;
		
		private System.Nullable<int> _user_id;
		
		private EntitySet<transaction> _transactions;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusersBA_idChanging(int value);
    partial void OnusersBA_idChanged();
    partial void Onaccount_numberChanging(string value);
    partial void Onaccount_numberChanged();
    partial void Onaccount_typeChanging(string value);
    partial void Onaccount_typeChanged();
    partial void Onowner_nameChanging(string value);
    partial void Onowner_nameChanged();
    partial void Onexpiry_dateChanging(System.DateTime value);
    partial void Onexpiry_dateChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public users_bank_account()
		{
			this._transactions = new EntitySet<transaction>(new Action<transaction>(this.attach_transactions), new Action<transaction>(this.detach_transactions));
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usersBA_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usersBA_id
		{
			get
			{
				return this._usersBA_id;
			}
			set
			{
				if ((this._usersBA_id != value))
				{
					this.OnusersBA_idChanging(value);
					this.SendPropertyChanging();
					this._usersBA_id = value;
					this.SendPropertyChanged("usersBA_id");
					this.OnusersBA_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_number", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string account_number
		{
			get
			{
				return this._account_number;
			}
			set
			{
				if ((this._account_number != value))
				{
					this.Onaccount_numberChanging(value);
					this.SendPropertyChanging();
					this._account_number = value;
					this.SendPropertyChanged("account_number");
					this.Onaccount_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_type", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string account_type
		{
			get
			{
				return this._account_type;
			}
			set
			{
				if ((this._account_type != value))
				{
					this.Onaccount_typeChanging(value);
					this.SendPropertyChanging();
					this._account_type = value;
					this.SendPropertyChanged("account_type");
					this.Onaccount_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_owner_name", DbType="VarChar(50)")]
		public string owner_name
		{
			get
			{
				return this._owner_name;
			}
			set
			{
				if ((this._owner_name != value))
				{
					this.Onowner_nameChanging(value);
					this.SendPropertyChanging();
					this._owner_name = value;
					this.SendPropertyChanged("owner_name");
					this.Onowner_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expiry_date", DbType="Date NOT NULL")]
		public System.DateTime expiry_date
		{
			get
			{
				return this._expiry_date;
			}
			set
			{
				if ((this._expiry_date != value))
				{
					this.Onexpiry_dateChanging(value);
					this.SendPropertyChanging();
					this._expiry_date = value;
					this.SendPropertyChanged("expiry_date");
					this.Onexpiry_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="users_bank_account_transaction", Storage="_transactions", ThisKey="usersBA_id", OtherKey="sender_account")]
		public EntitySet<transaction> transactions
		{
			get
			{
				return this._transactions;
			}
			set
			{
				this._transactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_users_bank_account", Storage="_user", ThisKey="user_id", OtherKey="user_id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.users_bank_accounts.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.users_bank_accounts.Add(this);
						this._user_id = value.user_id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
		
		private void attach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.users_bank_account = this;
		}
		
		private void detach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.users_bank_account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_details")]
	public partial class user_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userDetails_id;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _profile_src;
		
		private System.Nullable<int> _user_id;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserDetails_idChanging(int value);
    partial void OnuserDetails_idChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void Onprofile_srcChanging(string value);
    partial void Onprofile_srcChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public user_detail()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userDetails_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userDetails_id
		{
			get
			{
				return this._userDetails_id;
			}
			set
			{
				if ((this._userDetails_id != value))
				{
					this.OnuserDetails_idChanging(value);
					this.SendPropertyChanging();
					this._userDetails_id = value;
					this.SendPropertyChanged("userDetails_id");
					this.OnuserDetails_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_profile_src", DbType="VarChar(64)")]
		public string profile_src
		{
			get
			{
				return this._profile_src;
			}
			set
			{
				if ((this._profile_src != value))
				{
					this.Onprofile_srcChanging(value);
					this.SendPropertyChanging();
					this._profile_src = value;
					this.SendPropertyChanged("profile_src");
					this.Onprofile_srcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_user_detail", Storage="_user", ThisKey="user_id", OtherKey="user_id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.user_details.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.user_details.Add(this);
						this._user_id = value.user_id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_todo")]
	public partial class user_todo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _todo_id;
		
		private string _todo_name;
		
		private System.DateTime _date;
		
		private System.Nullable<int> _user_id;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontodo_idChanging(int value);
    partial void Ontodo_idChanged();
    partial void Ontodo_nameChanging(string value);
    partial void Ontodo_nameChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public user_todo()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_todo_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int todo_id
		{
			get
			{
				return this._todo_id;
			}
			set
			{
				if ((this._todo_id != value))
				{
					this.Ontodo_idChanging(value);
					this.SendPropertyChanging();
					this._todo_id = value;
					this.SendPropertyChanged("todo_id");
					this.Ontodo_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_todo_name", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string todo_name
		{
			get
			{
				return this._todo_name;
			}
			set
			{
				if ((this._todo_name != value))
				{
					this.Ontodo_nameChanging(value);
					this.SendPropertyChanging();
					this._todo_name = value;
					this.SendPropertyChanged("todo_name");
					this.Ontodo_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_user_todo", Storage="_user", ThisKey="user_id", OtherKey="user_id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.user_todos.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.user_todos.Add(this);
						this._user_id = value.user_id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private string _email;
		
		private string _password_hash;
		
		private string _password_salt;
		
		private EntitySet<users_bank_account> _users_bank_accounts;
		
		private EntitySet<user_detail> _user_details;
		
		private EntitySet<user_todo> _user_todos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Onpassword_hashChanging(string value);
    partial void Onpassword_hashChanged();
    partial void Onpassword_saltChanging(string value);
    partial void Onpassword_saltChanged();
    #endregion
		
		public user()
		{
			this._users_bank_accounts = new EntitySet<users_bank_account>(new Action<users_bank_account>(this.attach_users_bank_accounts), new Action<users_bank_account>(this.detach_users_bank_accounts));
			this._user_details = new EntitySet<user_detail>(new Action<user_detail>(this.attach_user_details), new Action<user_detail>(this.detach_user_details));
			this._user_todos = new EntitySet<user_todo>(new Action<user_todo>(this.attach_user_todos), new Action<user_todo>(this.detach_user_todos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
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
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password_hash", DbType="Char(64) NOT NULL", CanBeNull=false)]
		public string password_hash
		{
			get
			{
				return this._password_hash;
			}
			set
			{
				if ((this._password_hash != value))
				{
					this.Onpassword_hashChanging(value);
					this.SendPropertyChanging();
					this._password_hash = value;
					this.SendPropertyChanged("password_hash");
					this.Onpassword_hashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password_salt", DbType="Char(64) NOT NULL", CanBeNull=false)]
		public string password_salt
		{
			get
			{
				return this._password_salt;
			}
			set
			{
				if ((this._password_salt != value))
				{
					this.Onpassword_saltChanging(value);
					this.SendPropertyChanging();
					this._password_salt = value;
					this.SendPropertyChanged("password_salt");
					this.Onpassword_saltChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_users_bank_account", Storage="_users_bank_accounts", ThisKey="user_id", OtherKey="user_id")]
		public EntitySet<users_bank_account> users_bank_accounts
		{
			get
			{
				return this._users_bank_accounts;
			}
			set
			{
				this._users_bank_accounts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_user_detail", Storage="_user_details", ThisKey="user_id", OtherKey="user_id")]
		public EntitySet<user_detail> user_details
		{
			get
			{
				return this._user_details;
			}
			set
			{
				this._user_details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_user_todo", Storage="_user_todos", ThisKey="user_id", OtherKey="user_id")]
		public EntitySet<user_todo> user_todos
		{
			get
			{
				return this._user_todos;
			}
			set
			{
				this._user_todos.Assign(value);
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
		
		private void attach_users_bank_accounts(users_bank_account entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_users_bank_accounts(users_bank_account entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
		
		private void attach_user_details(user_detail entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_user_details(user_detail entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
		
		private void attach_user_todos(user_todo entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_user_todos(user_todo entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
}
#pragma warning restore 1591
