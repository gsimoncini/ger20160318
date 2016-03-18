namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpr_Objetos : IDisposable
	{
	
		#region Custom Members
		
		/// <summary>
		/// Obtiene el resultado del store tpr_ObjetosGetlist una vez filtrada la busqueda
		/// </summary>
		public static tpr_ObjetosExDataset GetListEx( string IdProducto, string Descripcion, string NumeroDeSerie )
		{
			return mz.erp.dataaccess.tpr_Objetos.GetListEx( IdProducto, Descripcion, NumeroDeSerie );
		}

		#endregion
		
		public tpr_Objetos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpr_Objetos
		/// </summary>
		public static mz.erp.commontypes.data.tpr_ObjetosDataset GetList()
		{
			return mz.erp.dataaccess.tpr_Objetos.GetList();
		}

		/// <summary>
		/// Crea un tpr_ObjetosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpr_ObjetosDataset.tpr_ObjetosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpr_Objetos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpr_Objetos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpr_ObjetosDataset.tpr_ObjetosRow GetByPk( string IdObjeto )
		{
			tpr_ObjetosDataset.tpr_ObjetosRow row = mz.erp.dataaccess.tpr_Objetos.GetByPk( IdObjeto  );
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
		/// Obtiene un registro de la tabla tpr_Objetos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpr_ObjetosDataset.tpr_ObjetosRow GetByPk( object IdObjeto )
		{
			return GetByPk( ( string )IdObjeto );
		}

		/// <summary>
		/// Establece los valores por defecto de tpr_ObjetosRow.
		/// </summary>
		public static tpr_ObjetosDataset.tpr_ObjetosRow SetRowDefaultValues( tpr_ObjetosDataset.tpr_ObjetosRow row )
		{
			row.IdObjeto = Util.NewStringId(); 
			row.IdProducto = string.Empty;
			row.Descripcion = string.Empty;
			row.NumeroDeSerie = string.Empty;
			row.Observaciones = string.Empty;
			row.InformacionAdicional1 = string.Empty;
			row.InformacionAdicional2 = string.Empty;
			row.InformacionAdicional3 = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpr_ObjetosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpr_ObjetosDataset.tpr_ObjetosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpr_ObjetosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpr_ObjetosDataset.tpr_ObjetosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpr_ObjetosRow a la base de datos.
		/// </summary>
		public static void Update( tpr_ObjetosDataset.tpr_ObjetosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_Objetos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpr_ObjetosDataset a la base de datos.
		/// </summary>
		public static void Update( tpr_ObjetosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpr_Objetos.Rows.Count > 0, "La tabla dataSet.tpr_ObjetosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_Objetos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpr_ObjetosDataset.tpr_ObjetosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpr_ObjetosDataset.tpr_ObjetosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpr_Objetos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpr_ObjetosRow.
		/// </summary>
		public static bool RowIsValid( tpr_ObjetosDataset.tpr_ObjetosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdObjetoIsValid( row.IdObjeto, out mensaje) )
			{ 
				row.SetColumnError( "IdObjeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroDeSerieIsValid( row.NumeroDeSerie, out mensaje) )
			{ 
				row.SetColumnError( "NumeroDeSerie" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !InformacionAdicional1IsValid( row.InformacionAdicional1, out mensaje) )
			{ 
				row.SetColumnError( "InformacionAdicional1" , mensaje);
				isValid=false;
			
			}
						
			if ( !InformacionAdicional2IsValid( row.InformacionAdicional2, out mensaje) )
			{ 
				row.SetColumnError( "InformacionAdicional2" , mensaje);
				isValid=false;
			
			}
						
			if ( !InformacionAdicional3IsValid( row.InformacionAdicional3, out mensaje) )
			{ 
				row.SetColumnError( "InformacionAdicional3" , mensaje);
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}*/
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdObjeto.
		/// </summary>
		public static bool IdObjetoIsValid( string IdObjeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdObjeto. Metodo Sobrecargado
		/// </summary>
		public static bool IdObjetoIsValid( string IdObjeto)
		{
			string mensaje;
			return IdObjetoIsValid( IdObjeto, out mensaje );
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
		/// Valida el campo NumeroDeSerie.
		/// </summary>
		public static bool NumeroDeSerieIsValid( string NumeroDeSerie , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroDeSerie. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroDeSerieIsValid( string NumeroDeSerie)
		{
			string mensaje;
			return NumeroDeSerieIsValid( NumeroDeSerie, out mensaje );
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
		/// Valida el campo InformacionAdicional1.
		/// </summary>
		public static bool InformacionAdicional1IsValid( string InformacionAdicional1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo InformacionAdicional1. Metodo Sobrecargado
		/// </summary>
		public static bool InformacionAdicional1IsValid( string InformacionAdicional1)
		{
			string mensaje;
			return InformacionAdicional1IsValid( InformacionAdicional1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo InformacionAdicional2.
		/// </summary>
		public static bool InformacionAdicional2IsValid( string InformacionAdicional2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo InformacionAdicional2. Metodo Sobrecargado
		/// </summary>
		public static bool InformacionAdicional2IsValid( string InformacionAdicional2)
		{
			string mensaje;
			return InformacionAdicional2IsValid( InformacionAdicional2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo InformacionAdicional3.
		/// </summary>
		public static bool InformacionAdicional3IsValid( string InformacionAdicional3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo InformacionAdicional3. Metodo Sobrecargado
		/// </summary>
		public static bool InformacionAdicional3IsValid( string InformacionAdicional3)
		{
			string mensaje;
			return InformacionAdicional3IsValid( InformacionAdicional3, out mensaje );
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

