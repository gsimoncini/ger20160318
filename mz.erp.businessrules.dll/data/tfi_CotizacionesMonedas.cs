namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Collections;
	using mz.erp.businessrules.comprobantes;

	public class tfi_CotizacionesMonedas : IDisposable
	{
	
		#region Custom Members

		public static tfi_CotizacionesMonedasDataset GetList( string IdCotizacionMoneda, string IdMonedaOrigen, string IdMonedaDestino, DateTime FechaDeCambioInicio, DateTime FechaDeCambioFin, decimal Valor , string IdFuenteDeCambio)
		{
			return mz.erp.dataaccess.tfi_CotizacionesMonedas.GetList( IdCotizacionMoneda, IdMonedaOrigen, IdMonedaDestino, FechaDeCambioInicio, FechaDeCambioFin, Valor, IdFuenteDeCambio );
		}
		
		public static Cotizacion GetCoeficienteCotizacion( string IdMonedaOrigen, string IdMonedaDestino)
		{
			System.Data.DataRow row = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetValorCotizacion( IdMonedaOrigen, IdMonedaDestino, null );
			Cotizacion  cotizacion  = null;
			if (row != null)
			{
				cotizacion = Factory.GetCotizacion((string)row["IdCotizacionMoneda"],IdMonedaOrigen,IdMonedaDestino, (decimal) row ["Valor"], Convert.ToString(row["IdFuenteDeCambio"]));
			}
			else
			{
				cotizacion = GetCotizacion(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
			}
			return cotizacion;
		}

		/*No Modificar este metodo pa q devuelva una cotizacion por defecto
		 * El comportamiento de este metodo implementado de esta manera permite verificar exixtencia
		 * de una Cotizacion Actual con IdMonedaOrigen, IdMonedaDestino, IdFuenteDeCambio
		 * */
		public static Cotizacion GetCoeficienteCotizacion( string IdMonedaOrigen, string IdMonedaDestino, string IdFuenteDeCambio)
		{
			System.Data.DataRow row = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetValorCotizacion( IdMonedaOrigen, IdMonedaDestino, IdFuenteDeCambio );
			Cotizacion  cotizacion  = null;
			if (row != null)
			{
				cotizacion = Factory.GetCotizacion((string)row["IdCotizacionMoneda"],IdMonedaOrigen,IdMonedaDestino, (decimal) row ["Valor"], Convert.ToString(row["IdFuenteDeCambio"]));
			}	
			else
			{
				cotizacion = GetCotizacion(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
			}
			return cotizacion;
		}

		

		public static decimal GetCoeficienteCotizacionPorDefecto()
		{
			string IdMonedaOrigen = Variables.GetValueString("Contabilidad.MonedaExtranjeraReferencia");
			string IdMonedaDestino = Variables.GetValueString("Contabilidad.MonedaReferencia");			
			string IdFuenteDeCambio = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
			Cotizacion  cotizacion  = GetCoeficienteCotizacion(IdMonedaOrigen, IdMonedaDestino, IdFuenteDeCambio);			
			if (cotizacion == null) return 0;
			return cotizacion.Valor;
		}
		public static decimal GetCoeficienteCotizacionPorDefecto(int Decimales)
		{
			decimal cotizacion = GetCoeficienteCotizacionPorDefecto();
			cotizacion = Math.Round(cotizacion, Decimales);
			return cotizacion;
		}

		public static System.Data.DataSet  GetCotizaciones (ArrayList cotizaciones, string IdMonedaReferencia)
		{
			System.Data.DataSet data = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetCotizaciones(IdMonedaReferencia);
			System.Data.DataTable tabla= data.Tables[0];
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				Cotizacion cot = Factory.GetCotizacion((string)row["IdCotizacionMoneda"],(string)row["IdMonedaOrigen"],(string)row["IdMonedaDestino"], (decimal) row ["Valor"]);
				cotizaciones.Add(cot);
			}
			return data;

		}

		public static ArrayList GetCotizaciones(string IdMonedaReferencia)
		{
			ArrayList cotizaciones = new ArrayList();
			System.Data.DataSet data = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetCotizaciones(IdMonedaReferencia);
			System.Data.DataTable tabla= data.Tables[0];
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				Cotizacion cot = Factory.GetCotizacion((string)row["IdCotizacionMoneda"],(string)row["IdMonedaOrigen"],(string)row["IdMonedaDestino"], (decimal) row ["Valor"]);
				cotizaciones.Add(cot);
			}
			return cotizaciones;
		}

		public static ArrayList GetCotizaciones()
		{
			ArrayList cotizaciones = new ArrayList();
			System.Data.DataSet data = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetList();
			System.Data.DataTable tabla= data.Tables[0];
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				Cotizacion cot = Factory.GetCotizacion((string)row["IdCotizacionMoneda"],(string)row["IdMonedaOrigen"],(string)row["IdMonedaDestino"], (decimal) row ["Valor"]);
				cotizaciones.Add(cot);
			}
			return cotizaciones;			
		}

		public static Cotizacion GetCotizacion(string IdCotizacion)
		{   
			System.Data.DataRow row = mz.erp.businessrules.tfi_CotizacionesMonedas.GetByPk(IdCotizacion);
			if (row != null)
				return Factory.GetCotizacion((string)row["IdCotizacionMoneda"],(string)row["IdMonedaOrigen"],(string)row["IdMonedaDestino"], (decimal) row ["Valor"], Convert.ToString(row["IdFuenteDeCambio"]));
			else //esto es por q se rompe si el producto no tiene cotizacion, no deberia pasar en una base "bien cargada";
				return tfi_CotizacionesMonedas.GetCotizacion(Variables.GetValueString("Contabilidad.CotizacionReferencia"));
		}


		#endregion
		
		public tfi_CotizacionesMonedas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_CotizacionesMonedas
		/// </summary>
		public static tfi_CotizacionesMonedasDataset GetList()
		{
			return mz.erp.dataaccess.tfi_CotizacionesMonedas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_CotizacionesMonedas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_CotizacionesMonedasDataset GetList( string IdCotizacionMoneda, string IdMonedaOrigen, string IdMonedaDestino, DateTime FechaDeCambioInicio, DateTime FechaDeCambioFin, decimal Valor )
		{
			return mz.erp.dataaccess.tfi_CotizacionesMonedas.GetList( IdCotizacionMoneda, IdMonedaOrigen, IdMonedaDestino, FechaDeCambioInicio, FechaDeCambioFin, Valor, null );
		}

		/// <summary>
		/// Crea un tfi_CotizacionesMonedasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_CotizacionesMonedas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_CotizacionesMonedas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow GetByPk( string IdCotizacionMoneda )
		{
			tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row = mz.erp.dataaccess.tfi_CotizacionesMonedas.GetByPk( IdCotizacionMoneda  );
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

		/// <summary>
		/// Obtiene un registro de la tabla tfi_CotizacionesMonedas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow GetByPk( object IdCotizacionMoneda )
		{
			return GetByPk( ( string )IdCotizacionMoneda );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_CotizacionesMonedasRow.
		/// </summary>
		public static tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow SetRowDefaultValues( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row )
		{
			row.IdCotizacionMoneda = Util.NewStringId(); 
			row.IdMonedaOrigen = string.Empty;
			row.IdMonedaDestino = string.Empty;
			row.FechaDeCambioInicio = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaDeCambioFin = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdFuenteDeCambio = string.Empty;
			row.Valor = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CotizacionesMonedasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CotizacionesMonedasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CotizacionesMonedasRow a la base de datos.
		/// </summary>
		public static void Update( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CotizacionesMonedas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_CotizacionesMonedasDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_CotizacionesMonedasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_CotizacionesMonedas.Rows.Count > 0, "La tabla dataSet.tfi_CotizacionesMonedasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CotizacionesMonedas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CotizacionesMonedas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_CotizacionesMonedasRow.
		/// </summary>
		public static bool RowIsValid( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCotizacionMonedaIsValid( row.IdCotizacionMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaOrigenIsValid( row.IdMonedaOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaDestinoIsValid( row.IdMonedaDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaDeCambioInicioIsValid( row.FechaDeCambioInicio, out mensaje) )
			{ 
				row.SetColumnError( "FechaDeCambioInicio" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaDeCambioFinIsValid( row.FechaDeCambioFin, out mensaje) )
			{ 
				row.SetColumnError( "FechaDeCambioFin" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdFuenteDeCambioIsValid( row.IdFuenteDeCambio, out mensaje) )
			{ 
				row.SetColumnError( "IdFuenteDeCambio" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionMoneda.
		/// </summary>
		public static bool IdCotizacionMonedaIsValid( string IdCotizacionMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionMonedaIsValid( string IdCotizacionMoneda)
		{
			string mensaje;
			return IdCotizacionMonedaIsValid( IdCotizacionMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen.
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen)
		{
			string mensaje;
			return IdMonedaOrigenIsValid( IdMonedaOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaDestino.
		/// </summary>
		public static bool IdMonedaDestinoIsValid( string IdMonedaDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaDestinoIsValid( string IdMonedaDestino)
		{
			string mensaje;
			return IdMonedaDestinoIsValid( IdMonedaDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaDeCambioInicio.
		/// </summary>
		public static bool FechaDeCambioInicioIsValid( DateTime FechaDeCambioInicio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaDeCambioInicio. Metodo Sobrecargado
		/// </summary>
		public static bool FechaDeCambioInicioIsValid( DateTime FechaDeCambioInicio)
		{
			string mensaje;
			return FechaDeCambioInicioIsValid( FechaDeCambioInicio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaDeCambioFin.
		/// </summary>
		public static bool FechaDeCambioFinIsValid( DateTime FechaDeCambioFin , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaDeCambioFin. Metodo Sobrecargado
		/// </summary>
		public static bool FechaDeCambioFinIsValid( DateTime FechaDeCambioFin)
		{
			string mensaje;
			return FechaDeCambioFinIsValid( FechaDeCambioFin, out mensaje );
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

