namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionGrillaEstilosCondicionalesDet : IDisposable
	{
	
		#region Custom Members
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow GetCondicion( long IdConfiguracion, string Columna, string Condicion, string Valor, string ValorColumna)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
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

		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset GetList( long IdConfiguracion)
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList( IdConfiguracion, long.MinValue, string.Empty, string.Empty, string.Empty, string.Empty, long.MinValue, long.MinValue );
		}


		#endregion
		
		public tui_ConfiguracionGrillaEstilosCondicionalesDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDet
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionGrillaEstilosCondicionalesDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset GetList( long IdConfiguracion, long IdCondicion, string Columna, string Condicion, string Valor, string ValorColumna, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetList( IdConfiguracion, IdCondicion, Columna, Condicion, Valor, ValorColumna, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionGrillaEstilosCondicionalesDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow GetByPk( long IdConfiguracion, long IdCondicion )
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row = mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.GetByPk( IdConfiguracion, IdCondicion  );
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

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionGrillaEstilosCondicionalesDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow GetByPk( object IdConfiguracion, object IdCondicion )
		{
			return GetByPk( ( long )IdConfiguracion, ( long )IdCondicion );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionGrillaEstilosCondicionalesDetRow.
		/// </summary>
		public static tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow SetRowDefaultValues( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row )
		{
			row.IdConfiguracion = Util.NewLongId(); 
			row.IdCondicion = Util.NewLongId(); 
			row.Columna = string.Empty;
			row.Condicion = string.Empty;
			row.Valor = string.Empty;
			row.ValorColumna = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionGrillaEstilosCondicionalesDet.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionGrillaEstilosCondicionalesDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionGrillaEstilosCondicionalesDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionGrillaEstilosCondicionalesDetRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdConfiguracionIsValid( row.IdConfiguracion, out mensaje) )
			{ 
				row.SetColumnError( "IdConfiguracion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCondicionIsValid( row.IdCondicion, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ColumnaIsValid( row.Columna, out mensaje) )
			{ 
				row.SetColumnError( "Columna" , mensaje);
				isValid=false;
			
			}
						
			if ( !CondicionIsValid( row.Condicion, out mensaje) )
			{ 
				row.SetColumnError( "Condicion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorColumnaIsValid( row.ValorColumna, out mensaje) )
			{ 
				row.SetColumnError( "ValorColumna" , mensaje);
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
		/// Valida el campo IdConfiguracion.
		/// </summary>
		public static bool IdConfiguracionIsValid( long IdConfiguracion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConfiguracion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConfiguracionIsValid( long IdConfiguracion)
		{
			string mensaje;
			return IdConfiguracionIsValid( IdConfiguracion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCondicion.
		/// </summary>
		public static bool IdCondicionIsValid( long IdCondicion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicion. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionIsValid( long IdCondicion)
		{
			string mensaje;
			return IdCondicionIsValid( IdCondicion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Columna.
		/// </summary>
		public static bool ColumnaIsValid( string Columna , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Columna. Metodo Sobrecargado
		/// </summary>
		public static bool ColumnaIsValid( string Columna)
		{
			string mensaje;
			return ColumnaIsValid( Columna, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Condicion.
		/// </summary>
		public static bool CondicionIsValid( string Condicion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Condicion. Metodo Sobrecargado
		/// </summary>
		public static bool CondicionIsValid( string Condicion)
		{
			string mensaje;
			return CondicionIsValid( Condicion, out mensaje );
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
		/// Valida el campo ValorColumna.
		/// </summary>
		public static bool ValorColumnaIsValid( string ValorColumna , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorColumna. Metodo Sobrecargado
		/// </summary>
		public static bool ValorColumnaIsValid( string ValorColumna)
		{
			string mensaje;
			return ValorColumnaIsValid( ValorColumna, out mensaje );
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

