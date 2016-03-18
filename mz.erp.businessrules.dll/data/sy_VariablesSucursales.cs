namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesSucursales : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_VariablesSucursales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesSucursales
		/// </summary>
		public static sy_VariablesSucursalesDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesSucursales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesSucursales filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesSucursalesDataset GetList( string IdVariable, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.sy_VariablesSucursales.GetList( IdVariable, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un sy_VariablesSucursalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesSucursales.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesSucursales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow GetByPk( string IdVariable, long IdEmpresa, long IdSucursal )
		{
			sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row = mz.erp.dataaccess.sy_VariablesSucursales.GetByPk( IdVariable, IdEmpresa, IdSucursal  );
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
		/// Obtiene un registro de la tabla sy_VariablesSucursales que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow GetByPk( object IdVariable, long IdEmpresa, long IdSucursal )
		{
			return GetByPk( ( string )IdVariable, ( long )IdEmpresa, ( long )IdSucursal );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesSucursalesRow.
		/// </summary>
		public static sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow SetRowDefaultValues( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa; 
			row.IdSucursal = Security.IdSucursal; 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConecxionCreacion = 0;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesSucursales.Rows.Count > 0, "La tabla dataSet.sy_VariablesSucursalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesSucursalesDataset.sy_VariablesSucursalesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesSucursalesDataset.sy_VariablesSucursalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesSucursales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesSucursalesRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesSucursalesDataset.sy_VariablesSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVariableIsValid( row.IdVariable, out mensaje) )
			{ 
				row.SetColumnError( "IdVariable" , mensaje);
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
						
			if ( !IdConecxionCreacionIsValid( row.IdConecxionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConecxionCreacion" , mensaje);
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
		/// Valida el campo IdVariable.
		/// </summary>
		public static bool IdVariableIsValid( string IdVariable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVariable. Metodo Sobrecargado
		/// </summary>
		public static bool IdVariableIsValid( string IdVariable)
		{
			string mensaje;
			return IdVariableIsValid( IdVariable, out mensaje );
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
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( string Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( string Valor)
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
		/// Valida el campo IdConecxionCreacion.
		/// </summary>
		public static bool IdConecxionCreacionIsValid( long IdConecxionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConecxionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConecxionCreacionIsValid( long IdConecxionCreacion)
		{
			string mensaje;
			return IdConecxionCreacionIsValid( IdConecxionCreacion, out mensaje );
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

