namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_GruposProductos : IDisposable
	{
	
		#region Custom Members
		public static System.Collections.ArrayList BuscarPadresNoDuplicados( string IdProducto )
		{
			System.Collections.ArrayList padres = new System.Collections.ArrayList();
			System.Data.DataTable tabla = mz.erp.dataaccess.tsh_GruposProductos.BuscarPadresNoDuplicados(IdProducto);
			foreach ( System.Data.DataRow row in tabla.Rows)
			{
				padres.Add( (string)row["IdPadre"] );
			}
			return padres;
		}
		#endregion
		
		public tsh_GruposProductos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_GruposProductos
		/// </summary>
		public static tsh_GruposProductosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_GruposProductos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_GruposProductos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_GruposProductosDataset GetList( string IdProducto, string IdPadre )
		{
			return mz.erp.dataaccess.tsh_GruposProductos.GetList( IdProducto, IdPadre );
		}

		/// <summary>
		/// Crea un tsh_GruposProductosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_GruposProductosDataset.tsh_GruposProductosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_GruposProductos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_GruposProductos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_GruposProductosDataset.tsh_GruposProductosRow GetByPk( string IdProducto, string IdPadre, int Orden )
		{
			tsh_GruposProductosDataset.tsh_GruposProductosRow row = mz.erp.dataaccess.tsh_GruposProductos.GetByPk( IdProducto, IdPadre, Orden  );
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
		/// Obtiene un registro de la tabla tsh_GruposProductos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_GruposProductosDataset.tsh_GruposProductosRow GetByPk( object IdProducto, object IdPadre, object Orden )
		{
			return GetByPk( ( string )IdProducto, ( string )IdPadre, ( int )Orden );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_GruposProductosRow.
		/// </summary>
		public static tsh_GruposProductosDataset.tsh_GruposProductosRow SetRowDefaultValues( tsh_GruposProductosDataset.tsh_GruposProductosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdPadre = Util.NewStringId(); 
			row.Orden = 0; 
			row.Cantidad = 0;
			row.BonificacionVisual = 0;
			row.FormulaDeCalculoCantidad = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_GruposProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_GruposProductosDataset.tsh_GruposProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_GruposProductosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_GruposProductosDataset.tsh_GruposProductosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_GruposProductosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_GruposProductosDataset.tsh_GruposProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_GruposProductos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_GruposProductosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_GruposProductosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_GruposProductos.Rows.Count > 0, "La tabla dataSet.tsh_GruposProductosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_GruposProductos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_GruposProductosDataset.tsh_GruposProductosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_GruposProductosDataset.tsh_GruposProductosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_GruposProductos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_GruposProductosRow.
		/// </summary>
		public static bool RowIsValid( tsh_GruposProductosDataset.tsh_GruposProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPadreIsValid( row.IdPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdPadre" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenIsValid( row.Orden, out mensaje) )
			{ 
				row.SetColumnError( "Orden" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionVisualIsValid( row.BonificacionVisual, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionVisual" , mensaje);
				isValid=false;
			
			}
						
			if ( !FormulaDeCalculoCantidadIsValid( row.FormulaDeCalculoCantidad, out mensaje) )
			{ 
				row.SetColumnError( "FormulaDeCalculoCantidad" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPadre.
		/// </summary>
		public static bool IdPadreIsValid( string IdPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdPadreIsValid( string IdPadre)
		{
			string mensaje;
			return IdPadreIsValid( IdPadre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( int Orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenIsValid( int Orden)
		{
			string mensaje;
			return OrdenIsValid( Orden, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionVisual.
		/// </summary>
		public static bool BonificacionVisualIsValid( decimal BonificacionVisual , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionVisual. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionVisualIsValid( decimal BonificacionVisual)
		{
			string mensaje;
			return BonificacionVisualIsValid( BonificacionVisual, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FormulaDeCalculoCantidad.
		/// </summary>
		public static bool FormulaDeCalculoCantidadIsValid( string FormulaDeCalculoCantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FormulaDeCalculoCantidad. Metodo Sobrecargado
		/// </summary>
		public static bool FormulaDeCalculoCantidadIsValid( string FormulaDeCalculoCantidad)
		{
			string mensaje;
			return FormulaDeCalculoCantidadIsValid( FormulaDeCalculoCantidad, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

