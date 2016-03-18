namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using System.Data.SqlClient;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_CierresFiscales : IDisposable
	{
	
		#region Custom Members
		public static void Update( tsa_CierresFiscalesDataset data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{					
			mz.erp.dataaccess.tsa_CierresFiscales.Update((DataTable) data.tsa_CierresFiscales, trx, replicacion );		
		}

		
		#endregion
		
		public tsa_CierresFiscales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CierresFiscales
		/// </summary>
		public static tsa_CierresFiscalesDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CierresFiscales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_CierresFiscales filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_CierresFiscalesDataset GetList(  )
		{
			return mz.erp.dataaccess.tsa_CierresFiscales.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_CierresFiscalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CierresFiscales.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CierresFiscales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow GetByPk( string IdCierreFiscal )
		{
			tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row = mz.erp.dataaccess.tsa_CierresFiscales.GetByPk( IdCierreFiscal  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CierresFiscales que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow GetByPk( object IdCierreFiscal )
		{
			return GetByPk( ( string )IdCierreFiscal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CierresFiscalesRow.
		/// </summary>
		public static tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow SetRowDefaultValues( tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row )
		{
			row.IdCierreFiscal = Util.NewStringId(); 
			row.Fecha = DateTime.Now;
			row.Sucursal = string.Empty;
			row.Tipo = string.Empty;
			row.Numero = string.Empty;
			row.Comprobantes_Neto = 0;
			row.Comprobantes_IVA = 0;
			row.Comprobantes_II = 0;
			row.Comprobantes_NoGravados = 0;
			row.Comprobantes_Percepciones = 0;
			row.Comprobantes_Emitidos = 0;
			row.Comprobantes_Cancelados = 0;
			row.NC_Neto = 0;
			row.NC_IVA = 0;
			row.NC_II = 0;
			row.NC_NoGravados = 0;
			row.NC_Percepciones = 0;
			row.NC_Emitidos = 0;
			row.NC_Cancelados = 0;
			row.UltimoComprobanteA = 0;
			row.UltimoComprobanteB = 0;
			row.UltimaNCA = 0;
			row.UltimaNCB = 0;
			row.UltimoRemito = 0;
			row.Remitos_Emitidos = 0;
			row.DocumentosNF_Emitidos = 0;
			row.DocumentosNFH_Emitidos = 0;
			row.IdResponsable = string.Empty;
			row.Observacion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CierresFiscalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CierresFiscalesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CierresFiscalesRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CierresFiscales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CierresFiscalesDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CierresFiscalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CierresFiscales.Rows.Count > 0, "La tabla dataSet.tsa_CierresFiscalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CierresFiscales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CierresFiscalesDataset.tsa_CierresFiscalesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CierresFiscalesDataset.tsa_CierresFiscalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CierresFiscales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CierresFiscalesRow.
		/// </summary>
		public static bool RowIsValid( tsa_CierresFiscalesDataset.tsa_CierresFiscalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCierreFiscalIsValid( row.IdCierreFiscal, out mensaje) )
			{ 
				row.SetColumnError( "IdCierreFiscal" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !SucursalIsValid( row.Sucursal, out mensaje) )
			{ 
				row.SetColumnError( "Sucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !TipoIsValid( row.Tipo, out mensaje) )
			{ 
				row.SetColumnError( "Tipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_NetoIsValid( row.Comprobantes_Neto, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_Neto" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_IVAIsValid( row.Comprobantes_IVA, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_IVA" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_NoGravadosIsValid( row.Comprobantes_NoGravados, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_NoGravados" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_PercepcionesIsValid( row.Comprobantes_Percepciones, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_Percepciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_EmitidosIsValid( row.Comprobantes_Emitidos, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_Emitidos" , mensaje);
				isValid=false;
			
			}
						
			if ( !Comprobantes_CanceladosIsValid( row.Comprobantes_Cancelados, out mensaje) )
			{ 
				row.SetColumnError( "Comprobantes_Cancelados" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_NetoIsValid( row.NC_Neto, out mensaje) )
			{ 
				row.SetColumnError( "NC_Neto" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_IVAIsValid( row.NC_IVA, out mensaje) )
			{ 
				row.SetColumnError( "NC_IVA" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_NoGravadosIsValid( row.NC_NoGravados, out mensaje) )
			{ 
				row.SetColumnError( "NC_NoGravados" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_PercepcionesIsValid( row.NC_Percepciones, out mensaje) )
			{ 
				row.SetColumnError( "NC_Percepciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_EmitidosIsValid( row.NC_Emitidos, out mensaje) )
			{ 
				row.SetColumnError( "NC_Emitidos" , mensaje);
				isValid=false;
			
			}
						
			if ( !NC_CanceladosIsValid( row.NC_Cancelados, out mensaje) )
			{ 
				row.SetColumnError( "NC_Cancelados" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimoComprobanteAIsValid( row.UltimoComprobanteA, out mensaje) )
			{ 
				row.SetColumnError( "UltimoComprobanteA" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimoComprobanteBIsValid( row.UltimoComprobanteB, out mensaje) )
			{ 
				row.SetColumnError( "UltimoComprobanteB" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaNCAIsValid( row.UltimaNCA, out mensaje) )
			{ 
				row.SetColumnError( "UltimaNCA" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaNCBIsValid( row.UltimaNCB, out mensaje) )
			{ 
				row.SetColumnError( "UltimaNCB" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimoRemitoIsValid( row.UltimoRemito, out mensaje) )
			{ 
				row.SetColumnError( "UltimoRemito" , mensaje);
				isValid=false;
			
			}
						
			if ( !Remitos_EmitidosIsValid( row.Remitos_Emitidos, out mensaje) )
			{ 
				row.SetColumnError( "Remitos_Emitidos" , mensaje);
				isValid=false;
			
			}
						
			if ( !DocumentosNF_EmitidosIsValid( row.DocumentosNF_Emitidos, out mensaje) )
			{ 
				row.SetColumnError( "DocumentosNF_Emitidos" , mensaje);
				isValid=false;
			
			}
						
			if ( !DocumentosNFH_EmitidosIsValid( row.DocumentosNFH_Emitidos, out mensaje) )
			{ 
				row.SetColumnError( "DocumentosNFH_Emitidos" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionIsValid( row.Observacion, out mensaje) )
			{ 
				row.SetColumnError( "Observacion" , mensaje);
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
		/// Valida el campo IdCierreFiscal.
		/// </summary>
		public static bool IdCierreFiscalIsValid( string IdCierreFiscal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCierreFiscal. Metodo Sobrecargado
		/// </summary>
		public static bool IdCierreFiscalIsValid( string IdCierreFiscal)
		{
			string mensaje;
			return IdCierreFiscalIsValid( IdCierreFiscal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Sucursal.
		/// </summary>
		public static bool SucursalIsValid( string Sucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sucursal. Metodo Sobrecargado
		/// </summary>
		public static bool SucursalIsValid( string Sucursal)
		{
			string mensaje;
			return SucursalIsValid( Sucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Tipo.
		/// </summary>
		public static bool TipoIsValid( string Tipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tipo. Metodo Sobrecargado
		/// </summary>
		public static bool TipoIsValid( string Tipo)
		{
			string mensaje;
			return TipoIsValid( Tipo, out mensaje );
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
		/// Valida el campo Comprobantes_Neto.
		/// </summary>
		public static bool Comprobantes_NetoIsValid( decimal Comprobantes_Neto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_Neto. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_NetoIsValid( decimal Comprobantes_Neto)
		{
			string mensaje;
			return Comprobantes_NetoIsValid( Comprobantes_Neto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comprobantes_IVA.
		/// </summary>
		public static bool Comprobantes_IVAIsValid( decimal Comprobantes_IVA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_IVA. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_IVAIsValid( decimal Comprobantes_IVA)
		{
			string mensaje;
			return Comprobantes_IVAIsValid( Comprobantes_IVA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comprobantes_NoGravados.
		/// </summary>
		public static bool Comprobantes_NoGravadosIsValid( decimal Comprobantes_NoGravados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_NoGravados. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_NoGravadosIsValid( decimal Comprobantes_NoGravados)
		{
			string mensaje;
			return Comprobantes_NoGravadosIsValid( Comprobantes_NoGravados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comprobantes_Percepciones.
		/// </summary>
		public static bool Comprobantes_PercepcionesIsValid( decimal Comprobantes_Percepciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_Percepciones. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_PercepcionesIsValid( decimal Comprobantes_Percepciones)
		{
			string mensaje;
			return Comprobantes_PercepcionesIsValid( Comprobantes_Percepciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comprobantes_Emitidos.
		/// </summary>
		public static bool Comprobantes_EmitidosIsValid( int Comprobantes_Emitidos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_Emitidos. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_EmitidosIsValid( int Comprobantes_Emitidos)
		{
			string mensaje;
			return Comprobantes_EmitidosIsValid( Comprobantes_Emitidos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comprobantes_Cancelados.
		/// </summary>
		public static bool Comprobantes_CanceladosIsValid( int Comprobantes_Cancelados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comprobantes_Cancelados. Metodo Sobrecargado
		/// </summary>
		public static bool Comprobantes_CanceladosIsValid( int Comprobantes_Cancelados)
		{
			string mensaje;
			return Comprobantes_CanceladosIsValid( Comprobantes_Cancelados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_Neto.
		/// </summary>
		public static bool NC_NetoIsValid( decimal NC_Neto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_Neto. Metodo Sobrecargado
		/// </summary>
		public static bool NC_NetoIsValid( decimal NC_Neto)
		{
			string mensaje;
			return NC_NetoIsValid( NC_Neto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_IVA.
		/// </summary>
		public static bool NC_IVAIsValid( decimal NC_IVA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_IVA. Metodo Sobrecargado
		/// </summary>
		public static bool NC_IVAIsValid( decimal NC_IVA)
		{
			string mensaje;
			return NC_IVAIsValid( NC_IVA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_NoGravados.
		/// </summary>
		public static bool NC_NoGravadosIsValid( decimal NC_NoGravados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_NoGravados. Metodo Sobrecargado
		/// </summary>
		public static bool NC_NoGravadosIsValid( decimal NC_NoGravados)
		{
			string mensaje;
			return NC_NoGravadosIsValid( NC_NoGravados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_Percepciones.
		/// </summary>
		public static bool NC_PercepcionesIsValid( decimal NC_Percepciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_Percepciones. Metodo Sobrecargado
		/// </summary>
		public static bool NC_PercepcionesIsValid( decimal NC_Percepciones)
		{
			string mensaje;
			return NC_PercepcionesIsValid( NC_Percepciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_Emitidos.
		/// </summary>
		public static bool NC_EmitidosIsValid( int NC_Emitidos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_Emitidos. Metodo Sobrecargado
		/// </summary>
		public static bool NC_EmitidosIsValid( int NC_Emitidos)
		{
			string mensaje;
			return NC_EmitidosIsValid( NC_Emitidos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NC_Cancelados.
		/// </summary>
		public static bool NC_CanceladosIsValid( int NC_Cancelados , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NC_Cancelados. Metodo Sobrecargado
		/// </summary>
		public static bool NC_CanceladosIsValid( int NC_Cancelados)
		{
			string mensaje;
			return NC_CanceladosIsValid( NC_Cancelados, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimoComprobanteA.
		/// </summary>
		public static bool UltimoComprobanteAIsValid( int UltimoComprobanteA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimoComprobanteA. Metodo Sobrecargado
		/// </summary>
		public static bool UltimoComprobanteAIsValid( int UltimoComprobanteA)
		{
			string mensaje;
			return UltimoComprobanteAIsValid( UltimoComprobanteA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimoComprobanteB.
		/// </summary>
		public static bool UltimoComprobanteBIsValid( int UltimoComprobanteB , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimoComprobanteB. Metodo Sobrecargado
		/// </summary>
		public static bool UltimoComprobanteBIsValid( int UltimoComprobanteB)
		{
			string mensaje;
			return UltimoComprobanteBIsValid( UltimoComprobanteB, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaNCA.
		/// </summary>
		public static bool UltimaNCAIsValid( int UltimaNCA , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaNCA. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaNCAIsValid( int UltimaNCA)
		{
			string mensaje;
			return UltimaNCAIsValid( UltimaNCA, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaNCB.
		/// </summary>
		public static bool UltimaNCBIsValid( int UltimaNCB , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaNCB. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaNCBIsValid( int UltimaNCB)
		{
			string mensaje;
			return UltimaNCBIsValid( UltimaNCB, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimoRemito.
		/// </summary>
		public static bool UltimoRemitoIsValid( int UltimoRemito , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimoRemito. Metodo Sobrecargado
		/// </summary>
		public static bool UltimoRemitoIsValid( int UltimoRemito)
		{
			string mensaje;
			return UltimoRemitoIsValid( UltimoRemito, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Remitos_Emitidos.
		/// </summary>
		public static bool Remitos_EmitidosIsValid( int Remitos_Emitidos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Remitos_Emitidos. Metodo Sobrecargado
		/// </summary>
		public static bool Remitos_EmitidosIsValid( int Remitos_Emitidos)
		{
			string mensaje;
			return Remitos_EmitidosIsValid( Remitos_Emitidos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DocumentosNF_Emitidos.
		/// </summary>
		public static bool DocumentosNF_EmitidosIsValid( int DocumentosNF_Emitidos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DocumentosNF_Emitidos. Metodo Sobrecargado
		/// </summary>
		public static bool DocumentosNF_EmitidosIsValid( int DocumentosNF_Emitidos)
		{
			string mensaje;
			return DocumentosNF_EmitidosIsValid( DocumentosNF_Emitidos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DocumentosNFH_Emitidos.
		/// </summary>
		public static bool DocumentosNFH_EmitidosIsValid( int DocumentosNFH_Emitidos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DocumentosNFH_Emitidos. Metodo Sobrecargado
		/// </summary>
		public static bool DocumentosNFH_EmitidosIsValid( int DocumentosNFH_Emitidos)
		{
			string mensaje;
			return DocumentosNFH_EmitidosIsValid( DocumentosNFH_Emitidos, out mensaje );
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
		/// Valida el campo Observacion.
		/// </summary>
		public static bool ObservacionIsValid( string Observacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observacion. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionIsValid( string Observacion)
		{
			string mensaje;
			return ObservacionIsValid( Observacion, out mensaje );
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

