namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_EstadisticaOrdenReparacionDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_EstadisticaOrdenReparacionDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_EstadisticaOrdenReparacionDet
		/// </summary>
		public static st_EstadisticaOrdenReparacionDetDataset GetList()
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_EstadisticaOrdenReparacionDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_EstadisticaOrdenReparacionDetDataset GetList( long IdOrdenReparacion, long IdInstaciaOrdenReparacion, decimal Cantidad, long IdTarea, string Complejidad, decimal ValorTecnico, decimal ValorTecnicoProvisorio, decimal ValorCliente, decimal Subtotal )
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.GetList( IdOrdenReparacion, IdInstaciaOrdenReparacion, Cantidad, IdTarea, Complejidad, ValorTecnico, ValorTecnicoProvisorio, ValorCliente, Subtotal );
		}

		/// <summary>
		/// Crea un st_EstadisticaOrdenReparacionDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow GetByPk( long IdOrdenReparacion, long IdInstaciaOrdenReparacion, long IdTarea )
		{
			st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row = mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.GetByPk( IdOrdenReparacion, IdInstaciaOrdenReparacion, IdTarea  );
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
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow GetByPk( object IdOrdenReparacion, object IdInstaciaOrdenReparacion, object IdTarea )
		{
			return GetByPk( ( long )IdOrdenReparacion, ( long )IdInstaciaOrdenReparacion, (long) IdTarea );
		}

		/// <summary>
		/// Establece los valores por defecto de st_EstadisticaOrdenReparacionDetRow.
		/// </summary>
		public static st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow SetRowDefaultValues( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row )
		{
			row.IdOrdenReparacion = 0; 
			row.IdInstaciaOrdenReparacion = 0; 
			row.Cantidad = 0;
			row.IdTarea = 0;
			row.Complejidad = string.Empty;
			row.ValorTecnico = 0;
			row.ValorTecnicoProvisorio = 0;
			row.ValorCliente = 0;
			row.Subtotal = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDetRow a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDetDataset a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_EstadisticaOrdenReparacionDet.Rows.Count > 0, "La tabla dataSet.st_EstadisticaOrdenReparacionDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_EstadisticaOrdenReparacionDetRow.
		/// </summary>
		public static bool RowIsValid( st_EstadisticaOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdInstaciaOrdenReparacionIsValid( row.IdInstaciaOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdInstaciaOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComplejidadIsValid( row.Complejidad, out mensaje) )
			{ 
				row.SetColumnError( "Complejidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorTecnicoIsValid( row.ValorTecnico, out mensaje) )
			{ 
				row.SetColumnError( "ValorTecnico" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorTecnicoProvisorioIsValid( row.ValorTecnicoProvisorio, out mensaje) )
			{ 
				row.SetColumnError( "ValorTecnicoProvisorio" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorClienteIsValid( row.ValorCliente, out mensaje) )
			{ 
				row.SetColumnError( "ValorCliente" , mensaje);
				isValid=false;
			
			}
						
			if ( !SubtotalIsValid( row.Subtotal, out mensaje) )
			{ 
				row.SetColumnError( "Subtotal" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion.
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion)
		{
			string mensaje;
			return IdOrdenReparacionIsValid( IdOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdInstaciaOrdenReparacion.
		/// </summary>
		public static bool IdInstaciaOrdenReparacionIsValid( long IdInstaciaOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstaciaOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstaciaOrdenReparacionIsValid( long IdInstaciaOrdenReparacion)
		{
			string mensaje;
			return IdInstaciaOrdenReparacionIsValid( IdInstaciaOrdenReparacion, out mensaje );
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
		/// Valida el campo IdTarea.
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea)
		{
			string mensaje;
			return IdTareaIsValid( IdTarea, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Complejidad.
		/// </summary>
		public static bool ComplejidadIsValid( string Complejidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Complejidad. Metodo Sobrecargado
		/// </summary>
		public static bool ComplejidadIsValid( string Complejidad)
		{
			string mensaje;
			return ComplejidadIsValid( Complejidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorTecnico.
		/// </summary>
		public static bool ValorTecnicoIsValid( decimal ValorTecnico , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorTecnico. Metodo Sobrecargado
		/// </summary>
		public static bool ValorTecnicoIsValid( decimal ValorTecnico)
		{
			string mensaje;
			return ValorTecnicoIsValid( ValorTecnico, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorTecnicoProvisorio.
		/// </summary>
		public static bool ValorTecnicoProvisorioIsValid( decimal ValorTecnicoProvisorio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorTecnicoProvisorio. Metodo Sobrecargado
		/// </summary>
		public static bool ValorTecnicoProvisorioIsValid( decimal ValorTecnicoProvisorio)
		{
			string mensaje;
			return ValorTecnicoProvisorioIsValid( ValorTecnicoProvisorio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorCliente.
		/// </summary>
		public static bool ValorClienteIsValid( decimal ValorCliente , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorCliente. Metodo Sobrecargado
		/// </summary>
		public static bool ValorClienteIsValid( decimal ValorCliente)
		{
			string mensaje;
			return ValorClienteIsValid( ValorCliente, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Subtotal.
		/// </summary>
		public static bool SubtotalIsValid( decimal Subtotal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Subtotal. Metodo Sobrecargado
		/// </summary>
		public static bool SubtotalIsValid( decimal Subtotal)
		{
			string mensaje;
			return SubtotalIsValid( Subtotal, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

