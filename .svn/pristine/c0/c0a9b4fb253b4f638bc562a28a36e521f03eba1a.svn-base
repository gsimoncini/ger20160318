namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_CoeficientesCostosIndirectos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_CoeficientesCostosIndirectos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_CoeficientesCostosIndirectos
		/// </summary>
		public static tsh_CoeficientesCostosIndirectosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.GetList();
		}

		public static DataSet GetListEx()
		{
			return mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.GetListEx();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_CoeficientesCostosIndirectos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_CoeficientesCostosIndirectosDataset GetList( string IdCoeficienteCostoIndirecto, string Descripcion, decimal Valor, bool Tipo, string IdMoneda, string IdFuenteDeCambio, long Orden, bool Activo )
		{
			return mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.GetList( IdCoeficienteCostoIndirecto, Descripcion, Valor, Tipo, IdMoneda, IdFuenteDeCambio, Orden, Activo );
		}

		/// <summary>
		/// Crea un tsh_CoeficientesCostosIndirectosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_CoeficientesCostosIndirectos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow GetByPk( string IdCoeficienteCostoIndirecto )
		{
			tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row = mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.GetByPk( IdCoeficienteCostoIndirecto  );
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
		/// Obtiene un registro de la tabla tsh_CoeficientesCostosIndirectos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow GetByPk( object IdCoeficienteCostoIndirecto )
		{
			return GetByPk( ( string )IdCoeficienteCostoIndirecto );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_CoeficientesCostosIndirectosRow.
		/// </summary>
		public static tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow SetRowDefaultValues( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row )
		{
			row.IdCoeficienteCostoIndirecto = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = null;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.Descripcion = string.Empty;
			row.Valor = 0;
			row.Tipo = false;
			row.IdMoneda = string.Empty;
			row.IdFuenteDeCambio = string.Empty;
			row.Orden = 0;
			row.Activo = false;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CoeficientesCostosIndirectosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CoeficientesCostosIndirectosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CoeficientesCostosIndirectosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_CoeficientesCostosIndirectosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_CoeficientesCostosIndirectosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_CoeficientesCostosIndirectos.Rows.Count > 0, "La tabla dataSet.tsh_CoeficientesCostosIndirectosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CoeficientesCostosIndirectos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_CoeficientesCostosIndirectosRow.
		/// </summary>
		public static bool RowIsValid( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
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
						
			if ( !IdCoeficienteCostoIndirectoIsValid( row.IdCoeficienteCostoIndirecto, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !TipoIsValid( row.Tipo, out mensaje) )
			{ 
				row.SetColumnError( "Tipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdFuenteDeCambioIsValid( row.IdFuenteDeCambio, out mensaje) )
			{ 
				row.SetColumnError( "IdFuenteDeCambio" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenIsValid( row.Orden, out mensaje) )
			{ 
				row.SetColumnError( "Orden" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		public static bool RowIdIsValid( string RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( string RowId)
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
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto.
		/// </summary>
		public static bool IdCoeficienteCostoIndirectoIsValid( string IdCoeficienteCostoIndirecto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirectoIsValid( string IdCoeficienteCostoIndirecto)
		{
			string mensaje;
			return IdCoeficienteCostoIndirectoIsValid( IdCoeficienteCostoIndirecto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( decimal Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( decimal Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Tipo.
		/// </summary>
		public static bool TipoIsValid( bool Tipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tipo. Metodo Sobrecargado
		/// </summary>
		public static bool TipoIsValid( bool Tipo)
		{
			string mensaje;
			return TipoIsValid( Tipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda)
		{
			string mensaje;
			return IdMonedaIsValid( IdMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio.
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio. Metodo Sobrecargado
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio)
		{
			string mensaje;
			return IdFuenteDeCambioIsValid( IdFuenteDeCambio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( long Orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenIsValid( long Orden)
		{
			string mensaje;
			return OrdenIsValid( Orden, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}


