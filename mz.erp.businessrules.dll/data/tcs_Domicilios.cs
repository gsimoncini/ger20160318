namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	public class Domicilio
	{
		public Domicilio()
		{
		}
			
		public virtual string DomicilioTexto
		{
			get 
			{ 
				string cadena = "";
				cadena += systemframework.Util.CutSpace(_calle);
				cadena += systemframework.Util.CutSpace(_numero);
				cadena += systemframework.Util.CutSpace(_sector);
				cadena += systemframework.Util.CutSpace(_torre);
				cadena += systemframework.Util.CutSpace(_piso);
				cadena += systemframework.Util.CutSpace(_departamento);
				cadena += systemframework.Util.CutSpace(_manzana);
				cadena += systemframework.Util.CutSpace(_localidad);
				return cadena;
			}
		}
		private bool _checked = false;
		public virtual bool Checked
		{
			set { _checked = value ;}
			get { return _checked ; }
		}
		private string _calle = string.Empty;
		public string Calle
		{
			set { _calle = value; }
			get { return _calle; }
		}
		private string _numero = string.Empty;
		public string Numero
		{
			set { _numero = value ;} 
			get {return _numero ; }
		}
		private string _localidad = string.Empty;
		public string Localidad
		{
			set {_localidad = value ; }
			get {return _localidad ; }
		}
		private string _telefono = string.Empty;
		public string Telefono
		{
			set {_telefono = value ; }
			get {return _telefono ; }
		}		
		private string _tipoDomicilio = string.Empty;
		public string TipoDomicilio
		{
			set {_tipoDomicilio = value ; }
			get {return _tipoDomicilio ; }
		}
        //Cristian Tarea 890
        private string _codigoPostal = string.Empty;
        public string CodigoPostal
        {
            set { _codigoPostal = value; }
            get { return _codigoPostal; }
        }
        //Fin Tarea 890
		private string _sector = string.Empty;
		public string Sector
		{
			set {_sector = value ; }
			get {return _sector ; }
		}
		private string _torre = string.Empty;
		public string Torre
		{
			set {_torre = value ; }
			get { return _torre ;}
		}
		private string _piso = string.Empty;
		public string Piso
		{
			set {_piso = value ;}
			get { return _piso ;}
		}
		private string _departamento = string.Empty;
		public string Departamento
		{
			set { _departamento = value ; }
			get { return _departamento ; }
		}
		private string _manzana = string.Empty;
		public string Manzana
		{
			set { _manzana = value ;}
			get { return _manzana ; }
		}
		private string _idDomicilio = string.Empty;
		public string IdDomicilio 
		{
			get{return _idDomicilio;}
			set{_idDomicilio = value;}
		}

		//German 20100118 SP6 647
		private string _idTipoDomicilio = string.Empty;
		public string IdTipoDomicilio 
		{
			get{return _idTipoDomicilio;}
			set{_idTipoDomicilio = value;}
		}
		//Fin German 20100118 SP6 647
			
			
	}

	public class tcs_Domicilios : IDisposable
	{
	
		#region Custom Members

		
		#endregion
		
		public tcs_Domicilios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_Domicilios
		/// </summary>
		public static tcs_DomiciliosDataset GetList()
		{
			return mz.erp.dataaccess.tcs_Domicilios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_Domicilios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_DomiciliosDataset GetList( string IdDomicilio, long IdTipoDomicilio, string Calle, string Numero, string IdLocalidad, string Partido, string IdProvincia, string IdPais )
		{
			return mz.erp.dataaccess.tcs_Domicilios.GetList( IdDomicilio, IdTipoDomicilio, Calle, Numero, IdLocalidad, Partido, IdProvincia, IdPais );
		}

		/// <summary>
		/// Crea un tcs_DomiciliosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tcs_DomiciliosDataset.tcs_DomiciliosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tcs_Domicilios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_Domicilios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_DomiciliosDataset.tcs_DomiciliosRow GetByPk( string IdDomicilio )
		{
			tcs_DomiciliosDataset.tcs_DomiciliosRow row = mz.erp.dataaccess.tcs_Domicilios.GetByPk( IdDomicilio  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_Domicilios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tcs_DomiciliosDataset.tcs_DomiciliosRow GetByPk( object IdDomicilio )
		{
			return GetByPk( ( string  )IdDomicilio );
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_DomiciliosRow.
		/// </summary>
		public static tcs_DomiciliosDataset.tcs_DomiciliosRow SetRowDefaultValues( tcs_DomiciliosDataset.tcs_DomiciliosRow row )
		{
			row.IdDomicilio = Util.NewStringId(); 
			row.IdTipoDomicilio = 1;
			row.Calle = string.Empty;
			row.Numero = "S/N";
			row.Sector = string.Empty;
			row.Torre = string.Empty;
			row.Piso = string.Empty;
			row.Departamento = string.Empty;
			row.Manzana = string.Empty;
			row.CodigoPostal = string.Empty;
			row.IdLocalidad = "1";
			row.Partido = string.Empty;
			row.IdProvincia = 1;
			row.IdPais = 1;
			row.IdResponsable = Security.IdPersona;
			row.Telefono = null;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.SetIdGeneradoNull();
			row.SetRowIdGeneradoNull();

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tcs_DomiciliosDataset.tcs_DomiciliosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tcs_DomiciliosDataset.tcs_DomiciliosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosRow a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosDataset.tcs_DomiciliosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Domicilios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_DomiciliosDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_Domicilios.Rows.Count > 0, "La tabla dataSet.tcs_DomiciliosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Domicilios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_DomiciliosDataset.tcs_DomiciliosDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_DomiciliosDataset.tcs_DomiciliosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Domicilios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_DomiciliosRow.
		/// </summary>
		public static bool RowIsValid( System.Data.DataRow row )
		{
			
			
			

			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			/*if ( !IdDomicilioIsValid( row.IdDomicilio, out mensaje) )
			{ 
				row.SetColumnError( "IdDomicilio" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDomicilioIsValid( row.IdTipoDomicilio, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDomicilio" , mensaje);
				isValid=false;
			
			}
			*/			
			if ( !CalleIsValid( Convert.ToString(row["Calle"]), out mensaje) )
			{ 
				row.SetColumnError( "Calle" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( Convert.ToString(row["Numero"]), out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
			/*			
			if ( !SectorIsValid( row.Sector, out mensaje) )
			{ 
				row.SetColumnError( "Sector" , mensaje);
				isValid=false;
			
			}
						
			if ( !TorreIsValid( row.Torre, out mensaje) )
			{ 
				row.SetColumnError( "Torre" , mensaje);
				isValid=false;
			
			}
						
			if ( !PisoIsValid( row.Piso, out mensaje) )
			{ 
				row.SetColumnError( "Piso" , mensaje);
				isValid=false;
			
			}
						
			if ( !DepartamentoIsValid( row.Departamento, out mensaje) )
			{ 
				row.SetColumnError( "Departamento" , mensaje);
				isValid=false;
			
			}
						
			if ( !ManzanaIsValid( row.Manzana, out mensaje) )
			{ 
				row.SetColumnError( "Manzana" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoPostalIsValid( row.CodigoPostal, out mensaje) )
			{ 
				row.SetColumnError( "CodigoPostal" , mensaje);
				isValid=false;
			
			}*/
						
			/*if ( !IdLocalidadIsValid( Convert.ToString(row["IdLocalidad"]), out mensaje) )
			{ 
				row.SetColumnError( "IdLocalidad" , mensaje);
				isValid=false;
			
			}*/
			/*			
			if ( !PartidoIsValid( row.Partido, out mensaje) )
			{ 
				row.SetColumnError( "Partido" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProvinciaIsValid( row.IdProvincia, out mensaje) )
			{ 
				row.SetColumnError( "IdProvincia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPaisIsValid( row.IdPais, out mensaje) )
			{ 
				row.SetColumnError( "IdPais" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !TelefonoIsValid( row.Telefono, out mensaje) )
			{ 
				row.SetColumnError( "Telefono" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;*/
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdDomicilio.
		/// </summary>
		public static bool IdDomicilioIsValid( string  IdDomicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDomicilio. Metodo Sobrecargado
		/// </summary>
		public static bool IdDomicilioIsValid( string  IdDomicilio)
		{
			string mensaje;
			return IdDomicilioIsValid( IdDomicilio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDomicilio.
		/// </summary>
		public static bool IdTipoDomicilioIsValid( long IdTipoDomicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDomicilio. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDomicilioIsValid( long IdTipoDomicilio)
		{
			string mensaje;
			return IdTipoDomicilioIsValid( IdTipoDomicilio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Calle.
		/// </summary>
		public static bool CalleIsValid( string Calle , out string mensaje )
		{
			if(Calle == null || Calle.Equals(string.Empty))
			{
				mensaje = "El domicilio debe contener una calle. Ingrese el nombre o numero de calle";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Calle. Metodo Sobrecargado
		/// </summary>
		public static bool CalleIsValid( string Calle)
		{
			string mensaje;
			return CalleIsValid( Calle, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			/*
			if(Numero == null || Numero.Equals(string.Empty))
			{
				mensaje = "El numero no puede ser vacio. Si no posee un numero ingrese S/N";
				return false;
			}
			else
			{
				bool ok = mz.erp.systemframework.Util.IsValidNumeroDomicilio(Numero);
				if(!ok)
				{
					mensaje = "El Numero de calle no es Valido. Debe ser numerico o ingrese S/N en caso de no poseer numero";
					return false;
				}
			}
			*/
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Sector.
		/// </summary>
		public static bool SectorIsValid( string Sector , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sector. Metodo Sobrecargado
		/// </summary>
		public static bool SectorIsValid( string Sector)
		{
			string mensaje;
			return SectorIsValid( Sector, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Torre.
		/// </summary>
		public static bool TorreIsValid( string Torre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Torre. Metodo Sobrecargado
		/// </summary>
		public static bool TorreIsValid( string Torre)
		{
			string mensaje;
			return TorreIsValid( Torre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Piso.
		/// </summary>
		public static bool PisoIsValid( string Piso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Piso. Metodo Sobrecargado
		/// </summary>
		public static bool PisoIsValid( string Piso)
		{
			string mensaje;
			return PisoIsValid( Piso, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Departamento.
		/// </summary>
		public static bool DepartamentoIsValid( string Departamento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Departamento. Metodo Sobrecargado
		/// </summary>
		public static bool DepartamentoIsValid( string Departamento)
		{
			string mensaje;
			return DepartamentoIsValid( Departamento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Manzana.
		/// </summary>
		public static bool ManzanaIsValid( string Manzana , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Manzana. Metodo Sobrecargado
		/// </summary>
		public static bool ManzanaIsValid( string Manzana)
		{
			string mensaje;
			return ManzanaIsValid( Manzana, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodigoPostal.
		/// </summary>
		public static bool CodigoPostalIsValid( string CodigoPostal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoPostal. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoPostalIsValid( string CodigoPostal)
		{
			string mensaje;
			return CodigoPostalIsValid( CodigoPostal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdLocalidad.
		/// </summary>
		public static bool IdLocalidadIsValid( string IdLocalidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			if(IdLocalidad == null ||IdLocalidad.Equals(string.Empty))
			{
				mensaje = "Debe seleccionar una localidad para el Domicilio";
				return false;
			}
			mensaje = "";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdLocalidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdLocalidadIsValid( string IdLocalidad)
		{
			string mensaje;
			return IdLocalidadIsValid( IdLocalidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Partido.
		/// </summary>
		public static bool PartidoIsValid( string Partido , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Partido. Metodo Sobrecargado
		/// </summary>
		public static bool PartidoIsValid( string Partido)
		{
			string mensaje;
			return PartidoIsValid( Partido, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProvincia.
		/// </summary>
		public static bool IdProvinciaIsValid( string IdProvincia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProvincia. Metodo Sobrecargado
		/// </summary>
		public static bool IdProvinciaIsValid( string IdProvincia)
		{
			string mensaje;
			return IdProvinciaIsValid( IdProvincia, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPais.
		/// </summary>
		public static bool IdPaisIsValid( string IdPais , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPais. Metodo Sobrecargado
		/// </summary>
		public static bool IdPaisIsValid( string IdPais)
		{
			string mensaje;
			return IdPaisIsValid( IdPais, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Telefono.
		/// </summary>
		public static bool TelefonoIsValid( string  Telefono , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Telefono. Metodo Sobrecargado
		/// </summary>
		public static bool TelefonoIsValid(string  Telefono)
		{
			string mensaje;
			return TelefonoIsValid( Telefono, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

