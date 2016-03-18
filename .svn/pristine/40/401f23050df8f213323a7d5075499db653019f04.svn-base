namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesEmpresas : IDisposable
	{
	
		#region Custom Members
		public static object GetValue( string IdVariable, int IdEmpresa )
		{
			sy_VariablesEmpresasDataset data = sy_VariablesEmpresas.GetList( IdVariable, IdEmpresa );
			if ( data != null && data.sy_VariablesEmpresas.Rows.Count == 1 )
			{
				return ( ( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow ) data.sy_VariablesEmpresas.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}
		}		
		public static object GetValue( string IdVariable)
		{
			return GetValue( IdVariable, Int32.Parse( ApplicationConfiguration.Empresa ) );
		}


		public static object GetValuePK( string IdVariable, long IdEmpresa )
		{
			sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow  row = sy_VariablesEmpresas.GetByPk( IdVariable, IdEmpresa );
			if ( row != null )
			{
				return row.Valor;
			}
			else
			{
				return null;
			}
		}		
		public static object GetValuePK( string IdVariable)
		{
			return GetValuePK( IdVariable, Security.IdEmpresa );
		}
		
		#endregion
		
		public sy_VariablesEmpresas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesEmpresas
		/// </summary>
		public static sy_VariablesEmpresasDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesEmpresas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesEmpresas filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesEmpresasDataset GetList( string IdVariable, long IdEmpresa )
		{
			return mz.erp.dataaccess.sy_VariablesEmpresas.GetList( IdVariable, IdEmpresa );
		}

		/// <summary>
		/// Crea un sy_VariablesEmpresasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesEmpresas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesEmpresas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow GetByPk( string IdVariable, long IdEmpresa )
		{
			sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow row = mz.erp.dataaccess.sy_VariablesEmpresas.GetByPk( IdVariable, IdEmpresa  );
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
		/// Obtiene un registro de la tabla sy_VariablesEmpresas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow GetByPk( object IdVariable, object IdEmpresa )
		{
			return GetByPk( ( string )IdVariable, ( long )IdEmpresa );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesEmpresasRow.
		/// </summary>
		public static sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow SetRowDefaultValues( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa; 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesEmpresasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesEmpresasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesEmpresasRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesEmpresas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesEmpresasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesEmpresasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesEmpresas.Rows.Count > 0, "La tabla dataSet.sy_VariablesEmpresasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesEmpresas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesEmpresasDataset.sy_VariablesEmpresasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesEmpresasDataset.sy_VariablesEmpresasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesEmpresas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesEmpresasRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow row )
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

