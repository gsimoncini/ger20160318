namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_AgrupProductos : IDisposable
	{
	
		#region Custom Members

		public static tsh_AgrupProductosExDataset GetList(string IdProducto)
		{			
			return mz.erp.dataaccess.tsh_AgrupProductos.GetList(IdProducto, Security.IdEmpresa);			
		}

		[ atMethodDeleteRow]
		public static void Delete(tsh_AgrupProductosDataset.tsh_AgrupProductosRow row)			
		{			
			row.Delete();
			Update(row);
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdProducto","No se ha podido eliminar el item");
				}
				else
				{
					row.SetColumnError("IdProducto","No se ha podido eliminar el item porque existen tablas relacionadas. Se ha procede a desactivar");
				}
			}
		}

		#endregion
		
		public tsh_AgrupProductos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_AgrupProductos
		/// </summary>
		public static tsh_AgrupProductosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_AgrupProductos.GetList();
		}

		
		/// <summary>
		/// Obtiene tabla tsh_AgrupProductos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_AgrupProductosExDataset GetList( string IdProducto, string Jerarquia, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{			
			//return mz.erp.dataaccess.tsh_AgrupProductos.GetList( IdProducto, Jerarquia, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
			return mz.erp.dataaccess.tsh_AgrupProductos.GetList( IdProducto, IdEmpresa );
		}

		public static tsh_AgrupProductosDataset GetList( string IdProducto, string Jerarquia)
		{			
			//return mz.erp.dataaccess.tsh_AgrupProductos.GetList( IdProducto, Jerarquia, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
			return mz.erp.dataaccess.tsh_AgrupProductos.GetList( IdProducto, Jerarquia );
		}

		/// <summary>
		/// Crea un tsh_AgrupProductosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_AgrupProductos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_AgrupProductos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow GetByPk( string IdProducto, string Jerarquia )
		{
			tsh_AgrupProductosDataset.tsh_AgrupProductosRow row = mz.erp.dataaccess.tsh_AgrupProductos.GetByPk( IdProducto, Jerarquia  );
			if (row != null)
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
		/// Obtiene un registro de la tabla tsh_AgrupProductos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow GetByPk( object IdProducto, object Jerarquia)
		{
			return GetByPk( ( string )IdProducto, ( string )Jerarquia );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_AgrupProductosRow.
		/// </summary>
		public static tsh_AgrupProductosDataset.tsh_AgrupProductosRow SetRowDefaultValues( tsh_AgrupProductosDataset.tsh_AgrupProductosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.Jerarquia = Util.NewStringId(); 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = 0;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static bool UpdateWithValidation( tsh_AgrupProductosDataset.tsh_AgrupProductosRow row )
		{				
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
				return true;
			}
			else 
			{ return false;}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupProductosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static bool UpdateWithValidation( System.Data.DataRow row )
		{
			return UpdateWithValidation( ( tsh_AgrupProductosDataset.tsh_AgrupProductosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupProductosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupProductosDataset.tsh_AgrupProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_AgrupProductos";
			mz.erp.dataaccess.tsh_AgrupProductos.Replicacion = replication;	

			mz.erp.dataaccess.tsh_AgrupProductos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_AgrupProductosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupProductosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_AgrupProductos.Rows.Count > 0, "La tabla dataSet.tsh_AgrupProductosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_AgrupProductos";
			mz.erp.dataaccess.tsh_AgrupProductos.Replicacion = replication;	
			
			mz.erp.dataaccess.tsh_AgrupProductos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupProductosDataset.tsh_AgrupProductosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupProductosDataset.tsh_AgrupProductosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_AgrupProductos";
			mz.erp.dataaccess.tsh_AgrupProductos.Replicacion = replication;	

			mz.erp.dataaccess.tsh_AgrupProductos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_AgrupProductosRow.
		/// </summary>
		public static bool RowIsValid( tsh_AgrupProductosDataset.tsh_AgrupProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;			
			}
					
			if ( !JerarquiaIsValid( row.Jerarquia, out mensaje) )
			{ 	
				row.SetColumnError( "Jerarquia" , mensaje);
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
			}*/
						
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
			
			tsh_AgrupProductosExDataset data = dataaccess.tsh_AgrupProductos.GetList(row.IdProducto, row.IdEmpresa);
			string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20)", "'" + row.Jerarquia + "'");			
			DataView dv = new DataView( data.tsh_AgrupProductos, filtro, "", System.Data.DataViewRowState.Unchanged );
			if (dv.Count != 0) 
			{
				isValid=false;
				row.SetColumnError( "Jerarquia" , "Ya fue ingresado un item de esta jerarquía");
			} 			
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
		/// Valida el campo Jerarquia.
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Jerarquia. Metodo Sobrecargado
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia)
		{
			string mensaje;
			return JerarquiaIsValid( Jerarquia, out mensaje );
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

