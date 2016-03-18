namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_Proveedores : IDisposable
	{
	
		#region Custom Members

        /* Silvina 20110228 - Tarea 0000017 */
        public static tpu_ProveedoresDataset GetByIdCondicionDeCompra(string IdCondicionDeCompra)
        {
            return mz.erp.dataaccess.tpu_Proveedores.GetByIdCondicionDeCompra(IdCondicionDeCompra);
        }

        /* Fin Silvina */

        /* Silvina 20110405 - Tarea 0000047 */

        public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByDocumento(string IdTipoDocumento, string Documento)
        {
            return mz.erp.dataaccess.tpu_Proveedores.GetByDocumento(IdTipoDocumento, Documento);
        }

        /* Fin Silvina 20110405 - Tarea 0000047 */

		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByCodigo( string Codigo )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.dataaccess.tpu_Proveedores.GetByCodigo(Codigo);
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

		public static string GetCodigoByPK( string IdProveedor )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = GetByPk(IdProveedor);
			if(row != null)
				return Convert.ToString(row["Codigo"]);
			return null;
		}

		public static string GetPKByCodigo( string Codigo )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = GetByCodigo(Codigo);
			if(row != null)
				return Convert.ToString(row["IdProveedor"]);
			return null;
		}

		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByNombre( string Nombre )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.dataaccess.tpu_Proveedores.GetByNombre(Nombre);
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

		public static string GetPKByNombre( string Nombre )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = GetByNombre(Nombre);
			if(row != null)
				return Convert.ToString(row["IdProveedor"]);
			return null;
		}

		public static string GetPkByUk( string Uk )
		{
			if(Uk != null && !Uk.Equals(string.Empty))
			{
				tpu_ProveedoresDataset data = GetListByUK(Uk);
				if (data.tpu_Proveedores.Rows.Count == 1)
				{
					return ((tpu_ProveedoresDataset.tpu_ProveedoresRow)data.tpu_Proveedores.Rows[0]).IdProveedor;
				}
			}
			return string.Empty;
		
		}
		public static tpu_ProveedoresDataset GetListByUK( string Codigo)
		{
			bool verTodosLosProveedores = Variables.GetValueBool("Proveedores.Busquedas.TodasLasSucursales");
			long IdSucursal = long.MinValue;
			long IdEmpresa = long.MinValue;
			bool Activo = false;
			if(!verTodosLosProveedores)
			{
				IdSucursal = Security.IdSucursal;
				IdEmpresa = Security.IdEmpresa;
			}
			
			return mz.erp.dataaccess.tpu_Proveedores.GetListByUK( Codigo, IdSucursal, IdEmpresa);
		}


		#endregion
		
		public tpu_Proveedores()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_Proveedores
		/// </summary>
		public static tpu_ProveedoresDataset GetList()
		{
			return mz.erp.dataaccess.tpu_Proveedores.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_Proveedores filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresDataset GetList( string IdProveedor, string Nombre, string IdTitular, string IdLocalidad )
		{
			return mz.erp.dataaccess.tpu_Proveedores.GetList( IdProveedor, Nombre, IdTitular, IdLocalidad );
		}


		public static DataSet GetListGeneral(string Codigo, string Nombre, string CampoAuxiliar1,string CampoAuxiliar2,string CampoAuxiliar3, string CampoAuxiliar4, decimal CampoAuxiliar5, bool CampoAuxiliar5Activo, 
			string Jerarquia1, string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,	string Jerarquia6,string Jerarquia7,string Jerarquia8, string Calle, string TipoDocumento,string Documento, string idTitular, 
			bool Activo, string Email,string IdLocalidad, string Telefonos, string IdTipoMovimiento, string IdSubTipoMovimiento, string IdCondicionDeCompra, long CondicionImpuestoGanancias, bool ExcluyeRetencionIVAActivo, 
			bool ExcluyeRetencionIVA, bool ExcluyeRetencionIIBBActivo, bool ExcluyeRetencionIIBB, string IdResponsableCreacion, DateTime FechaAltaDesde, DateTime FechaAltaHasta )
		{
			return mz.erp.dataaccess.tpu_Proveedores.GetListGeneral(Codigo, Nombre, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5, CampoAuxiliar5Activo
			,Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8, Calle,  TipoDocumento, Documento, idTitular, Activo,  Email, IdLocalidad,  Telefonos, IdTipoMovimiento, IdSubTipoMovimiento, IdCondicionDeCompra, CondicionImpuestoGanancias, ExcluyeRetencionIVAActivo, ExcluyeRetencionIVA, ExcluyeRetencionIIBBActivo, ExcluyeRetencionIIBB, IdResponsableCreacion, FechaAltaDesde, FechaAltaHasta );
		}
		//Viejo
	/*	public static DataSet GetListGeneral(string Codigo, string Nombre, string CampoAuxiliar1,string CampoAuxiliar2,string CampoAuxiliar3, string CampoAuxiliar4, decimal CampoAuxiliar5, bool CampoAuxiliar5Activo
		
			,string Jerarquia1, string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,
			string Jerarquia6,string Jerarquia7,string Jerarquia8
			)
		{
			return mz.erp.dataaccess.tpu_Proveedores.GetListGeneral(Codigo, Nombre, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5, CampoAuxiliar5Activo
				,Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,
				Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8);
		}*/
		/// <summary>
		/// Crea un tpu_ProveedoresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresDataset.tpu_ProveedoresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_Proveedores.NewRow());
		}
		

		/// <summary>
		/// Obtiene un registro de la tabla tpu_Proveedores que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByPk( string IdProveedor )
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row = mz.erp.dataaccess.tpu_Proveedores.GetByPk( IdProveedor  );
			if(row != null)
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

		public static tpu_ProveedoresDataset GetByPkToDataSet( string IdProveedor )
		{			
			return mz.erp.dataaccess.tpu_Proveedores.GetByPkToDataSet( IdProveedor  );
		}
		public static tpu_ProveedoresDataset.tpu_ProveedoresDataTable GetByPkToDataTable( string IdProveedor )
		{			
			return mz.erp.dataaccess.tpu_Proveedores.GetByPkToDataTable( IdProveedor  );
		}
		/// <summary>
		/// Obtiene un registro de la tabla tpu_Proveedores que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresDataset.tpu_ProveedoresRow GetByPk( object IdProveedor )
		{
			return GetByPk( ( string )IdProveedor );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresRow.
		/// </summary>
		public static tpu_ProveedoresDataset.tpu_ProveedoresRow SetRowDefaultValues( tpu_ProveedoresDataset.tpu_ProveedoresRow row )
		{
			row.IdProveedor = Util.NewStringId(); 
			row.Nombre = string.Empty;
			row.IdTitular = string.Empty;
			row.IdCategoriaIva = string.Empty;
			row.idTipoDocumento = string.Empty;
			row.Numero = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.Domicilio = string.Empty;
			row.HorarioComercial = string.Empty;
			row.Observaciones = string.Empty;
			row.Telefonos = string.Empty;
			row.Email = string.Empty;
			row.InstantMessenger = string.Empty;
			row.Web = string.Empty;
			row.BonificacionGeneral = 0;
			row.IdLocalidad = string.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.CampoAuxiliar4 = string.Empty;
			row.CampoAuxiliar5 = 0;
			row.ExcluyeRetencionIVA = false;
			row.ExcluyeRetencionIIBB = false;
			row.CondicionImpuestoGanancias = 0;
			row.AlicuotaRetencionIIBBCompras = 0;
			row.AlicuotaRetencionIIBBServicios = 0;
			
			return row;
		}

		#region replicacion

		private static SentenciasReplicacion GenerateReplication()
		{
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tpu_proveedores";
			return replication;
		}

		#endregion


		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresDataset.tpu_ProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresDataset.tpu_ProveedoresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDataset.tpu_ProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tpu_Proveedores.Update( row, replicacion );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_Proveedores.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tpu_Proveedores.Update( dataSet, replicacion );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDataset.tpu_ProveedoresDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDataset.tpu_ProveedoresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			SentenciasReplicacion replicacion = GenerateReplication();
			mz.erp.dataaccess.tpu_Proveedores.Update( dataTable , replicacion);
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresDataset.tpu_ProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTitularIsValid( row.IdTitular, out mensaje) )
			{ 
				row.SetColumnError( "IdTitular" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCategoriaIvaIsValid( row.IdCategoriaIva, out mensaje) )
			{ 
				row.SetColumnError( "IdCategoriaIva" , mensaje);
				isValid=false;
			
			}
						
			if ( !idTipoDocumentoIsValid( row.idTipoDocumento, out mensaje) )
			{ 
				row.SetColumnError( "idTipoDocumento" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
						
			*/if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
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
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !TelefonosIsValid( row.Telefonos, out mensaje) )
			{ 
				row.SetColumnError( "Telefonos" , mensaje);
				isValid=false;
			
			}
						
			if ( !EmailIsValid( row.Email, out mensaje) )
			{ 
				row.SetColumnError( "Email" , mensaje);
				isValid=false;
			
			}
						
			if ( !InstantMessengerIsValid( row.InstantMessenger, out mensaje) )
			{ 
				row.SetColumnError( "InstantMessenger" , mensaje);
				isValid=false;
			
			}
						
			if ( !WebIsValid( row.Web, out mensaje) )
			{ 
				row.SetColumnError( "Web" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionGeneralIsValid( row.BonificacionGeneral, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionGeneral" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdLocalidadIsValid( row.IdLocalidad, out mensaje) )
			{ 
				row.SetColumnError( "IdLocalidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor)
		{
			string mensaje;
			return IdProveedorIsValid( IdProveedor, out mensaje );
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
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo Telefonos.
		/// </summary>
		public static bool TelefonosIsValid( string Telefonos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Telefonos. Metodo Sobrecargado
		/// </summary>
		public static bool TelefonosIsValid( string Telefonos)
		{
			string mensaje;
			return TelefonosIsValid( Telefonos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Email.
		/// </summary>
		public static bool EmailIsValid( string Email , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Email. Metodo Sobrecargado
		/// </summary>
		public static bool EmailIsValid( string Email)
		{
			string mensaje;
			return EmailIsValid( Email, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo InstantMessenger.
		/// </summary>
		public static bool InstantMessengerIsValid( string InstantMessenger , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo InstantMessenger. Metodo Sobrecargado
		/// </summary>
		public static bool InstantMessengerIsValid( string InstantMessenger)
		{
			string mensaje;
			return InstantMessengerIsValid( InstantMessenger, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Web.
		/// </summary>
		public static bool WebIsValid( string Web , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Web. Metodo Sobrecargado
		/// </summary>
		public static bool WebIsValid( string Web)
		{
			string mensaje;
			return WebIsValid( Web, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionGeneral.
		/// </summary>
		public static bool BonificacionGeneralIsValid( decimal BonificacionGeneral , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionGeneral. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionGeneralIsValid( decimal BonificacionGeneral)
		{
			string mensaje;
			return BonificacionGeneralIsValid( BonificacionGeneral, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdLocalidad.
		/// </summary>
		public static bool IdLocalidadIsValid( string IdLocalidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
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

