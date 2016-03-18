namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Cuentas : IDisposable
	{
	
		#region Custom Members

        /* Silvina 20110405 - Tarea 0000047 */

        public static tsa_CuentasDataset.tsa_CuentasRow GetByDocumento(string IdTipoDocumento, string Documento)
        {
            return mz.erp.dataaccess.tsa_Cuentas.GetByDocumento(IdTipoDocumento, Documento);
        }

        /* Fin Silvina 20110405 - Tarea 0000047 */

        /* Silvina 20110712 - Tarea 0000121 */

        public static DataTable GetAlertas(decimal ValorLimite, bool ValidaPorMonto, bool ValidaPorFecha, int CantDias)
        {
            return mz.erp.dataaccess.tsa_Cuentas.GetAlertas(ValorLimite,ValidaPorMonto,ValidaPorFecha,CantDias);
        }

        /* Fin Silvina 20110712 - Tarea 0000121 */

		public static DataSet GetListJerarquias(string IdCuenta,
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8)
		{
			return mz.erp.dataaccess.tsa_Cuentas.GetListJerarquias(IdCuenta,
				Jerarquia1,
				Jerarquia2,
				Jerarquia3,
				Jerarquia4,
				Jerarquia5,
				Jerarquia6,
				Jerarquia7,
				Jerarquia8);
		}
			

		public static DataSet GetListContactos(string IdCuenta)
		{
			return mz.erp.dataaccess.tsa_Cuentas.GetListContactos(IdCuenta);
		}
			

		public static DataSet GetListGeneral(
			string Codigo, 
			string Nombre,  
			string IdTipoDocumento, 
			string Documento, 
			string IdTitular,
			string CampoAuxiliar1,
			string CampoAuxiliar2,
			string CampoAuxiliar3,
			string Calle,
			string IdLocalidad,
			string Telefonos,
			string Email,
			bool Activo,
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8,
			long IdSucursal,
			long IdEmpresa,
			string IdContacto,
			string IdResponsableCreacion,
			DateTime fechaAltaDesde,
			DateTime fechaAltaHasta
            /* Silvina 20110906 - Tarea 0000203 */
            , int Cantidad
            /* Fin Silvina 20110906 - Tarea 0000203 */
            /* Silvina 20111226 - Tarea 0000241 */
            , string CampoAuxiliar6
            , string Separador
            /* Fin Silvina 20111226 - Tarea 0000241 */
			)
		{
			return mz.erp.dataaccess.tsa_Cuentas.GetListGeneral(
				Codigo, 
				Nombre,  
				IdTipoDocumento, 
				Documento, 
				IdTitular,
				CampoAuxiliar1,
				CampoAuxiliar2,
				CampoAuxiliar3,
				Calle,
				IdLocalidad,
				Telefonos,
				Email,
				Activo,
				Jerarquia1,
				Jerarquia2,
				Jerarquia3,
				Jerarquia4,
				Jerarquia5,
				Jerarquia6,
				Jerarquia7,
				Jerarquia8,
				IdSucursal,
				IdEmpresa,
				IdContacto,
				IdResponsableCreacion,
				fechaAltaDesde,
				fechaAltaHasta	
                /* Silvina 20110906 - Tarea 0000203 */
                , Cantidad
            /* Fin Silvina 20110906 - Tarea 0000203 */
                /* Silvina 20111226 - Tarea 0000241 */
                , CampoAuxiliar6
                , Separador
                /* Fin Silvina 20111226 - Tarea 0000241 */
			);
	}

		public static DataSet GetListGeneral(
			string Codigo, 
			string Nombre,  
			string IdTipoDocumento, 
			string Documento, 
			string IdTitular,
			string CampoAuxiliar1,
			string CampoAuxiliar2,
			string CampoAuxiliar3,
			string Calle,
			string IdLocalidad,
			string Telefonos,
			string Email,
			bool Activo,
			string Jerarquia1,
			string Jerarquia2,
			string Jerarquia3,
			string Jerarquia4,
			string Jerarquia5,
			string Jerarquia6,
			string Jerarquia7,
			string Jerarquia8,
			long IdSucursal,
			long IdEmpresa
            /* Silvina 20110906 - Tarea 0000203 */
            , int Cantidad
            /* Fin Silvina 20110906 - Tarea 0000203 */
            /* Silvina 20111226 - Tarea 0000241 */
            , string CampoAuxiliar6
            , string Separador
            /* Fin Silvina 20111226 - Tarea 0000241 */	
			)
		{
			return GetListGeneral(
				Codigo, 
				Nombre,  
				IdTipoDocumento, 
				Documento, 
				IdTitular,
				CampoAuxiliar1,
				CampoAuxiliar2,
				CampoAuxiliar3,
				Calle,
				IdLocalidad,
				Telefonos,
				Email,
				Activo,
				Jerarquia1,
				Jerarquia2,
				Jerarquia3,
				Jerarquia4,
				Jerarquia5,
				Jerarquia6,
				Jerarquia7,
				Jerarquia8,
				IdSucursal,
				IdEmpresa,
				"",
				string.Empty,
				DateTime.MinValue,
				DateTime.MinValue
                /* Silvina 20110906 - Tarea 0000203 */
                , Cantidad
                /* Fin Silvina 20110906 - Tarea 0000203 */
                /* Silvina 20111226 - Tarea 0000241 */
                , CampoAuxiliar6
                , Separador
                /* Fin Silvina 20111226 - Tarea 0000241 */	
				);
		}
		
		public static tsa_CuentasDataset GetListByUK( string Codigo)
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			bool verTodosLosClientes = Variables.GetValueBool("Cuentas.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			bool Activo = false;
			if(!verTodosLosClientes)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			
			return mz.erp.dataaccess.tsa_Cuentas.GetListByUK( Codigo, IdTipoDomicilio ,IdSucursal, IdEmpresa);
		}

		public static string GetPkByUk( string Uk )
		{
			if(Uk != null && !Uk.Equals(string.Empty))
			{
				tsa_CuentasDataset data = GetListByUK(Uk);
				if (data.tsa_Cuentas.Rows.Count == 1)
				{
					return ((tsa_CuentasDataset.tsa_CuentasRow)data.tsa_Cuentas.Rows[0]).IdCuenta;
				}
			}
			return string.Empty;
		
		}
		public static string GetUkByPk( string Pk )
		{
			tsa_CuentasDataset.tsa_CuentasRow row = GetByPk( Pk);
			if (row != null)
			{
				return (row.Codigo);
			}
			return string.Empty;
		
		}
		//Metodos para llamar el stored que no toma las busquedas parciales a izquierda

		
		/// <summary>
		/// Obtiene tabla tsa_Cuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasDataset GetListEx( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular )
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			bool verTodosLosClientes = Variables.GetValueBool("Cuentas.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			bool Activo = false;
			decimal LimiteDeCredito = decimal.MinValue;
			if(!verTodosLosClientes)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			return mz.erp.dataaccess.tsa_Cuentas.GetListEx( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio, IdSucursal, IdEmpresa, Activo, LimiteDeCredito);
			/*foreach (tsa_CuentasDataset.tsa_CuentasRow row in data.tsa_Cuentas.Rows) 
			{				
				row.Nombre = row.Nombre.ToUpper();
				row.Domicilio = row.Domicilio.ToUpper();
				row.HorarioComercial = row.HorarioComercial.ToUpper();
			}*/
			//return data;
		}
		/// <summary>
		/// Obtiene tabla tsa_Cuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasDataset GetListEx( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, bool Activo)
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			bool verTodosLosClientes = Variables.GetValueBool("Cuentas.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			decimal LimiteDeCredito = decimal.MinValue;
			if(!verTodosLosClientes)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			return mz.erp.dataaccess.tsa_Cuentas.GetListEx( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio, IdSucursal, IdEmpresa, Activo, LimiteDeCredito);
		}
		
		//Sabrina 20100615 - Tarea 766
		public static tsa_CuentasDataset SearchCuentasByJerarquia(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa)
		{
			return mz.erp.dataaccess.tsa_Cuentas.SearchCuentasByJerarquia(Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8, IdSucursal, IdEmpresa );
		}
		//Fin Sabrina 20100615 - Tarea 766

		#endregion
		
		public tsa_Cuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Cuentas
		/// </summary>
		public static tsa_CuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Cuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Cuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasDataset GetList( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular )
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			bool verTodosLosClientes = Variables.GetValueBool("Cuentas.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			bool Activo = false;
			decimal LimiteDeCredito = decimal.MinValue;
			if(!verTodosLosClientes)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			
			return mz.erp.dataaccess.tsa_Cuentas.GetList( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio ,IdSucursal, IdEmpresa, Activo, LimiteDeCredito);
		}





		/// <summary>
		/// Obtiene tabla tsa_Cuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasDataset GetList( string Codigo, string Nombre, string Domicilio, string idTipoDocumento, string Documento, string IdTitular, bool Activo )
		{
			long IdTipoDomicilio = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
			bool verTodosLosClientes = Variables.GetValueBool("Cuentas.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;		
			decimal LimiteDeCredito = decimal.MinValue;
			if(!verTodosLosClientes)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			return mz.erp.dataaccess.tsa_Cuentas.GetList( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, IdTipoDomicilio ,IdSucursal, IdEmpresa, Activo, LimiteDeCredito);
		}







		public static System.Data.DataSet GetListDataset( string Codigo, string Nombre )
		{
			long IdEmpresa = long.MinValue;
			long IdSucursal = long.MinValue;

			//Excluyo los inactivos
			bool Activo = true;

			if (Security.IdEmpresa != 0)
			{
				IdEmpresa = Security.IdEmpresa;
			}
			if (Security.IdSucursal != 0)
			{
				IdSucursal = Security.IdSucursal;
			}
			return (System.Data.DataSet)mz.erp.dataaccess.tsa_Cuentas.GetList( Codigo, Nombre, null, null, null, null, long.MinValue, IdSucursal, IdEmpresa, Activo, decimal.MinValue);
		}




















		/// <summary>
		/// Crea un tsa_CuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasDataset.tsa_CuentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_Cuentas.NewRow());
		}

		public static tsa_CuentasDataset.tsa_CuentasRow GetByCodigo( string Codigo )
		{
			tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.dataaccess.tsa_Cuentas.GetByCodigo( Codigo );
			if (row != null)
			{
				
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Cuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasDataset.tsa_CuentasRow GetByPk( string IdCuenta )
		{
			tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.dataaccess.tsa_Cuentas.GetByPk( IdCuenta  );
			if (row != null)
			{
				
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Cuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CuentasDataset.tsa_CuentasRow GetByPk( object IdCuenta )
		{
			return GetByPk( ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasRow.
		/// </summary>
		public static tsa_CuentasDataset.tsa_CuentasRow SetRowDefaultValues( tsa_CuentasDataset.tsa_CuentasRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.Codigo = string.Empty;
			row.Nombre = string.Empty;
			row.Domicilio = string.Empty;
			row.HorarioComercial = string.Empty;
			row.idTipoDocumento = string.Empty;
			row.Documento = string.Empty;
			row.IdCategoriaIva = string.Empty;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.IdTitular = string.Empty;
			row.Observaciones = string.Empty;
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.ExcluyePercepcionIB = true;
			row.AlicuotaPercepcionIngresosBrutos = 0;
			row.SaldoCtaCte = 0;
			row.SaldoCtaCteDV = 0;
			row.IdResponsableCreacion = string.Empty;
			row.DiasLimiteDeCredito = Variables.GetValueDecimal("Momentos.ABMCuentas.DiasLimiteDeCredito.Default");
            /* Silvina 20111104 - Tarea 0000222 */
            row.CampoAuxiliar6 = string.Empty;
            /* Fin Silvina 20111104 - Tarea 0000222 */
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasDataset.tsa_CuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasDataset.tsa_CuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasDataset.tsa_CuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Cuentas.Rows.Count > 0, "La tabla dataSet.tsa_CuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasDataset.tsa_CuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasDataset.tsa_CuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Cuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasDataset.tsa_CuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoIsValid( row.Codigo, out mensaje) )
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !DomicilioIsValid( row.Domicilio, out mensaje) )
			{ 
				row.SetColumnError( "Domicilio" , mensaje);
				isValid=false;
			
			}
						
			if ( !HorarioComercialIsValid( row.HorarioComercial, out mensaje) )
			{ 
				row.SetColumnError( "HorarioComercial" , mensaje);
				isValid=false;
			
			}
						
			if ( !idTipoDocumentoIsValid( row.idTipoDocumento, out mensaje) )
			{ 
				row.SetColumnError( "idTipoDocumento" , mensaje);
				isValid=false;
			
			}
						
			if ( !DocumentoIsValid( row.Documento, out mensaje) )
			{ 
				row.SetColumnError( "Documento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCategoriaIvaIsValid( row.IdCategoriaIva, out mensaje) )
			{ 
				row.SetColumnError( "IdCategoriaIva" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar1IsValid( row.CampoAuxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar2IsValid( row.CampoAuxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar2" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar3IsValid( row.CampoAuxiliar3, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar3" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTitularIsValid( row.IdTitular, out mensaje) )
			{ 
				row.SetColumnError( "IdTitular" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoIsValid( string Codigo)
		{
			string mensaje;
			return CodigoIsValid( Codigo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( string Nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( string Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Domicilio.
		/// </summary>
		public static bool DomicilioIsValid( string Domicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Domicilio. Metodo Sobrecargado
		/// </summary>
		public static bool DomicilioIsValid( string Domicilio)
		{
			string mensaje;
			return DomicilioIsValid( Domicilio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo HorarioComercial.
		/// </summary>
		public static bool HorarioComercialIsValid( string HorarioComercial , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo HorarioComercial. Metodo Sobrecargado
		/// </summary>
		public static bool HorarioComercialIsValid( string HorarioComercial)
		{
			string mensaje;
			return HorarioComercialIsValid( HorarioComercial, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo idTipoDocumento.
		/// </summary>
		public static bool idTipoDocumentoIsValid( string idTipoDocumento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idTipoDocumento. Metodo Sobrecargado
		/// </summary>
		public static bool idTipoDocumentoIsValid( string idTipoDocumento)
		{
			string mensaje;
			return idTipoDocumentoIsValid( idTipoDocumento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Documento.
		/// </summary>
		public static bool DocumentoIsValid( string Documento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Documento. Metodo Sobrecargado
		/// </summary>
		public static bool DocumentoIsValid( string Documento)
		{
			string mensaje;
			return DocumentoIsValid( Documento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCategoriaIva.
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva. Metodo Sobrecargado
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva)
		{
			string mensaje;
			return IdCategoriaIvaIsValid( IdCategoriaIva, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1.
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1)
		{
			string mensaje;
			return CampoAuxiliar1IsValid( CampoAuxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2.
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2)
		{
			string mensaje;
			return CampoAuxiliar2IsValid( CampoAuxiliar2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3.
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3)
		{
			string mensaje;
			return CampoAuxiliar3IsValid( CampoAuxiliar3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTitular.
		/// </summary>
		public static bool IdTitularIsValid( string IdTitular , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTitular. Metodo Sobrecargado
		/// </summary>
		public static bool IdTitularIsValid( string IdTitular)
		{
			string mensaje;
			return IdTitularIsValid( IdTitular, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsableCreacion.
		/// </summary>
		public static bool IdResponsableCreacionIsValid( string IdResponsableCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			if ( IdResponsableCreacion.Equals(string.Empty) )
			{
				mensaje="No seleccionó el Responsable del alta";
				return false;
			}
			else
			{
				mensaje="";
				return true;
			}
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
		

		public void Dispose()
		{
		}
		
	}
}

