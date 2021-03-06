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

namespace Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mysqlserver")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertempleado(empleado instance);
    partial void Updateempleado(empleado instance);
    partial void Deleteempleado(empleado instance);
    partial void Insertestudiante(estudiante instance);
    partial void Updateestudiante(estudiante instance);
    partial void Deleteestudiante(estudiante instance);
    partial void Insertmateria(materia instance);
    partial void Updatemateria(materia instance);
    partial void Deletemateria(materia instance);
    partial void Insertmatricula(matricula instance);
    partial void Updatematricula(matricula instance);
    partial void Deletematricula(matricula instance);
    #endregion
		
		public dbDataContext() : 
				base(global::Datos.Properties.Settings.Default.mysqlserverConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<empleado> empleados
		{
			get
			{
				return this.GetTable<empleado>();
			}
		}
		
		public System.Data.Linq.Table<estudiante> estudiantes
		{
			get
			{
				return this.GetTable<estudiante>();
			}
		}
		
		public System.Data.Linq.Table<materia> materias
		{
			get
			{
				return this.GetTable<materia>();
			}
		}
		
		public System.Data.Linq.Table<matricula> matriculas
		{
			get
			{
				return this.GetTable<matricula>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.empleado")]
	public partial class empleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codigo;
		
		private string _nombre;
		
		private string _apellidoMaterno;
		
		private string _apellidoPaterno;
		
		private string _identificacion;
		
		private string _direccion;
		
		private System.DateTime _fechaNace;
		
		private string _email;
		
		private string _telefono;
		
		private int _rol;
		
		private string _usuario;
		
		private string _contrasena;
		
		private string _codigoLog;
		
		private int _estado;
		
		private EntitySet<materia> _materias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(int value);
    partial void OncodigoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoMaternoChanging(string value);
    partial void OnapellidoMaternoChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnidentificacionChanging(string value);
    partial void OnidentificacionChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OnfechaNaceChanging(System.DateTime value);
    partial void OnfechaNaceChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OnrolChanging(int value);
    partial void OnrolChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontrasenaChanging(string value);
    partial void OncontrasenaChanged();
    partial void OncodigoLogChanging(string value);
    partial void OncodigoLogChanged();
    partial void OnestadoChanging(int value);
    partial void OnestadoChanged();
    #endregion
		
		public empleado()
		{
			this._materias = new EntitySet<materia>(new Action<materia>(this.attach_materias), new Action<materia>(this.detach_materias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaterno", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string apellidoMaterno
		{
			get
			{
				return this._apellidoMaterno;
			}
			set
			{
				if ((this._apellidoMaterno != value))
				{
					this.OnapellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaterno = value;
					this.SendPropertyChanged("apellidoMaterno");
					this.OnapellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identificacion", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				if ((this._identificacion != value))
				{
					this.OnidentificacionChanging(value);
					this.SendPropertyChanging();
					this._identificacion = value;
					this.SendPropertyChanged("identificacion");
					this.OnidentificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNace", DbType="DateTime NOT NULL")]
		public System.DateTime fechaNace
		{
			get
			{
				return this._fechaNace;
			}
			set
			{
				if ((this._fechaNace != value))
				{
					this.OnfechaNaceChanging(value);
					this.SendPropertyChanging();
					this._fechaNace = value;
					this.SendPropertyChanged("fechaNace");
					this.OnfechaNaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(12)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol", DbType="Int NOT NULL")]
		public int rol
		{
			get
			{
				return this._rol;
			}
			set
			{
				if ((this._rol != value))
				{
					this.OnrolChanging(value);
					this.SendPropertyChanging();
					this._rol = value;
					this.SendPropertyChanged("rol");
					this.OnrolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasena", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string contrasena
		{
			get
			{
				return this._contrasena;
			}
			set
			{
				if ((this._contrasena != value))
				{
					this.OncontrasenaChanging(value);
					this.SendPropertyChanging();
					this._contrasena = value;
					this.SendPropertyChanged("contrasena");
					this.OncontrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigoLog", DbType="VarChar(50)")]
		public string codigoLog
		{
			get
			{
				return this._codigoLog;
			}
			set
			{
				if ((this._codigoLog != value))
				{
					this.OncodigoLogChanging(value);
					this.SendPropertyChanging();
					this._codigoLog = value;
					this.SendPropertyChanged("codigoLog");
					this.OncodigoLogChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int NOT NULL")]
		public int estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empleado_materia", Storage="_materias", ThisKey="usuario", OtherKey="usuarioEmple")]
		public EntitySet<materia> materias
		{
			get
			{
				return this._materias;
			}
			set
			{
				this._materias.Assign(value);
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
		
		private void attach_materias(materia entity)
		{
			this.SendPropertyChanging();
			entity.empleado = this;
		}
		
		private void detach_materias(materia entity)
		{
			this.SendPropertyChanging();
			entity.empleado = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.estudiante")]
	public partial class estudiante : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombreE;
		
		private string _apellidoMaterno;
		
		private string _apellidoPaterno;
		
		private string _identificacion;
		
		private string _direccion;
		
		private System.Nullable<int> _estado;
		
		private string _email;
		
		private string _usuario;
		
		private string _contrasena;
		
		private string _telefono;
		
		private System.DateTime _fechaNaci;
		
		private int _rol;
		
		private EntitySet<matricula> _matriculas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreEChanging(string value);
    partial void OnnombreEChanged();
    partial void OnapellidoMaternoChanging(string value);
    partial void OnapellidoMaternoChanged();
    partial void OnapellidoPaternoChanging(string value);
    partial void OnapellidoPaternoChanged();
    partial void OnidentificacionChanging(string value);
    partial void OnidentificacionChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OnestadoChanging(System.Nullable<int> value);
    partial void OnestadoChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontrasenaChanging(string value);
    partial void OncontrasenaChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OnfechaNaciChanging(System.DateTime value);
    partial void OnfechaNaciChanged();
    partial void OnrolChanging(int value);
    partial void OnrolChanged();
    #endregion
		
		public estudiante()
		{
			this._matriculas = new EntitySet<matricula>(new Action<matricula>(this.attach_matriculas), new Action<matricula>(this.detach_matriculas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreE", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string nombreE
		{
			get
			{
				return this._nombreE;
			}
			set
			{
				if ((this._nombreE != value))
				{
					this.OnnombreEChanging(value);
					this.SendPropertyChanging();
					this._nombreE = value;
					this.SendPropertyChanged("nombreE");
					this.OnnombreEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaterno", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string apellidoMaterno
		{
			get
			{
				return this._apellidoMaterno;
			}
			set
			{
				if ((this._apellidoMaterno != value))
				{
					this.OnapellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaterno = value;
					this.SendPropertyChanged("apellidoMaterno");
					this.OnapellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaterno", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string apellidoPaterno
		{
			get
			{
				return this._apellidoPaterno;
			}
			set
			{
				if ((this._apellidoPaterno != value))
				{
					this.OnapellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaterno = value;
					this.SendPropertyChanged("apellidoPaterno");
					this.OnapellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identificacion", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				if ((this._identificacion != value))
				{
					this.OnidentificacionChanging(value);
					this.SendPropertyChanging();
					this._identificacion = value;
					this.SendPropertyChanged("identificacion");
					this.OnidentificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int")]
		public System.Nullable<int> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasena", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string contrasena
		{
			get
			{
				return this._contrasena;
			}
			set
			{
				if ((this._contrasena != value))
				{
					this.OncontrasenaChanging(value);
					this.SendPropertyChanging();
					this._contrasena = value;
					this.SendPropertyChanged("contrasena");
					this.OncontrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(12)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNaci", DbType="DateTime NOT NULL")]
		public System.DateTime fechaNaci
		{
			get
			{
				return this._fechaNaci;
			}
			set
			{
				if ((this._fechaNaci != value))
				{
					this.OnfechaNaciChanging(value);
					this.SendPropertyChanging();
					this._fechaNaci = value;
					this.SendPropertyChanged("fechaNaci");
					this.OnfechaNaciChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol", DbType="Int NOT NULL")]
		public int rol
		{
			get
			{
				return this._rol;
			}
			set
			{
				if ((this._rol != value))
				{
					this.OnrolChanging(value);
					this.SendPropertyChanging();
					this._rol = value;
					this.SendPropertyChanged("rol");
					this.OnrolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="estudiante_matricula", Storage="_matriculas", ThisKey="usuario", OtherKey="usuarioEst")]
		public EntitySet<matricula> matriculas
		{
			get
			{
				return this._matriculas;
			}
			set
			{
				this._matriculas.Assign(value);
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
		
		private void attach_matriculas(matricula entity)
		{
			this.SendPropertyChanging();
			entity.estudiante = this;
		}
		
		private void detach_matriculas(matricula entity)
		{
			this.SendPropertyChanging();
			entity.estudiante = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.materia")]
	public partial class materia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codigo;
		
		private string _nombreM;
		
		private string _usuarioEmple;
		
		private int _estado;
		
		private EntitySet<matricula> _matriculas;
		
		private EntityRef<empleado> _empleado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(int value);
    partial void OncodigoChanged();
    partial void OnnombreMChanging(string value);
    partial void OnnombreMChanged();
    partial void OnusuarioEmpleChanging(string value);
    partial void OnusuarioEmpleChanged();
    partial void OnestadoChanging(int value);
    partial void OnestadoChanged();
    #endregion
		
		public materia()
		{
			this._matriculas = new EntitySet<matricula>(new Action<matricula>(this.attach_matriculas), new Action<matricula>(this.detach_matriculas));
			this._empleado = default(EntityRef<empleado>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreM", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreM
		{
			get
			{
				return this._nombreM;
			}
			set
			{
				if ((this._nombreM != value))
				{
					this.OnnombreMChanging(value);
					this.SendPropertyChanging();
					this._nombreM = value;
					this.SendPropertyChanged("nombreM");
					this.OnnombreMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuarioEmple", DbType="VarChar(12) NOT NULL", CanBeNull=false)]
		public string usuarioEmple
		{
			get
			{
				return this._usuarioEmple;
			}
			set
			{
				if ((this._usuarioEmple != value))
				{
					if (this._empleado.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusuarioEmpleChanging(value);
					this.SendPropertyChanging();
					this._usuarioEmple = value;
					this.SendPropertyChanged("usuarioEmple");
					this.OnusuarioEmpleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int NOT NULL")]
		public int estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="materia_matricula", Storage="_matriculas", ThisKey="codigo", OtherKey="codigoMateria")]
		public EntitySet<matricula> matriculas
		{
			get
			{
				return this._matriculas;
			}
			set
			{
				this._matriculas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empleado_materia", Storage="_empleado", ThisKey="usuarioEmple", OtherKey="usuario", IsForeignKey=true)]
		public empleado empleado
		{
			get
			{
				return this._empleado.Entity;
			}
			set
			{
				empleado previousValue = this._empleado.Entity;
				if (((previousValue != value) 
							|| (this._empleado.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._empleado.Entity = null;
						previousValue.materias.Remove(this);
					}
					this._empleado.Entity = value;
					if ((value != null))
					{
						value.materias.Add(this);
						this._usuarioEmple = value.usuario;
					}
					else
					{
						this._usuarioEmple = default(string);
					}
					this.SendPropertyChanged("empleado");
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
		
		private void attach_matriculas(matricula entity)
		{
			this.SendPropertyChanging();
			entity.materia = this;
		}
		
		private void detach_matriculas(matricula entity)
		{
			this.SendPropertyChanging();
			entity.materia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.matricula")]
	public partial class matricula : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _numero;
		
		private System.Nullable<int> _codigoMateria;
		
		private string _usuarioEst;
		
		private EntityRef<materia> _materia;
		
		private EntityRef<estudiante> _estudiante;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnumeroChanging(int value);
    partial void OnnumeroChanged();
    partial void OncodigoMateriaChanging(System.Nullable<int> value);
    partial void OncodigoMateriaChanged();
    partial void OnusuarioEstChanging(string value);
    partial void OnusuarioEstChanged();
    #endregion
		
		public matricula()
		{
			this._materia = default(EntityRef<materia>);
			this._estudiante = default(EntityRef<estudiante>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((this._numero != value))
				{
					this.OnnumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("numero");
					this.OnnumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigoMateria", DbType="Int")]
		public System.Nullable<int> codigoMateria
		{
			get
			{
				return this._codigoMateria;
			}
			set
			{
				if ((this._codigoMateria != value))
				{
					if (this._materia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncodigoMateriaChanging(value);
					this.SendPropertyChanging();
					this._codigoMateria = value;
					this.SendPropertyChanged("codigoMateria");
					this.OncodigoMateriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuarioEst", DbType="VarChar(10)")]
		public string usuarioEst
		{
			get
			{
				return this._usuarioEst;
			}
			set
			{
				if ((this._usuarioEst != value))
				{
					if (this._estudiante.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnusuarioEstChanging(value);
					this.SendPropertyChanging();
					this._usuarioEst = value;
					this.SendPropertyChanged("usuarioEst");
					this.OnusuarioEstChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="materia_matricula", Storage="_materia", ThisKey="codigoMateria", OtherKey="codigo", IsForeignKey=true)]
		public materia materia
		{
			get
			{
				return this._materia.Entity;
			}
			set
			{
				materia previousValue = this._materia.Entity;
				if (((previousValue != value) 
							|| (this._materia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._materia.Entity = null;
						previousValue.matriculas.Remove(this);
					}
					this._materia.Entity = value;
					if ((value != null))
					{
						value.matriculas.Add(this);
						this._codigoMateria = value.codigo;
					}
					else
					{
						this._codigoMateria = default(Nullable<int>);
					}
					this.SendPropertyChanged("materia");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="estudiante_matricula", Storage="_estudiante", ThisKey="usuarioEst", OtherKey="usuario", IsForeignKey=true)]
		public estudiante estudiante
		{
			get
			{
				return this._estudiante.Entity;
			}
			set
			{
				estudiante previousValue = this._estudiante.Entity;
				if (((previousValue != value) 
							|| (this._estudiante.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._estudiante.Entity = null;
						previousValue.matriculas.Remove(this);
					}
					this._estudiante.Entity = value;
					if ((value != null))
					{
						value.matriculas.Add(this);
						this._usuarioEst = value.usuario;
					}
					else
					{
						this._usuarioEst = default(string);
					}
					this.SendPropertyChanged("estudiante");
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
