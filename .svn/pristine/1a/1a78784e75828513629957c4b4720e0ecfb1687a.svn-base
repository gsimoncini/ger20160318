namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesPuestos : IDisposable
	{
	
		#region Custom Members

		public static sy_VariablesPuestosDataset GetList( string IdVariable )
		{
			return mz.erp.dataaccess.sy_VariablesPuestos.GetList( IdVariable, long.MinValue, long.MinValue, long.MinValue );
		}

		public static DataTable GetListByColaCompleto( string IdVariable)
		{
			DataTable table = new DataTable("");
			DataColumn columna1=new DataColumn("IdVariable");
			DataColumn columna2=new DataColumn("ValorDefault");
			DataColumn columna3=new DataColumn("Perfil");
			DataColumn columna4=new DataColumn("Puesto");
			DataColumn columna5=new DataColumn("Usuario");
			DataColumn columna6=new DataColumn("Descripcion");
			DataColumn columna7=new DataColumn("Tipo");
			DataColumn columna8=new DataColumn("IdUsuario");
			DataColumn columna9=new DataColumn("IdPerfil");
			DataColumn columna10=new DataColumn("IdPuesto");
			columna1.DataType =typeof (string); 
			columna2.DataType =typeof (string); 
			columna3.DataType =typeof (string); 
			columna4.DataType =typeof (string); 
			columna5.DataType =typeof (string); 
			columna6.DataType =typeof (string); 
			columna7.DataType =typeof (string); 
			columna8.DataType =typeof (string); 
			columna9.DataType =typeof (long); 
			columna10.DataType =typeof (long); 
			table.Columns.Add(columna1);
			table.Columns.Add(columna2);
			table.Columns.Add(columna3);
			table.Columns.Add(columna4);
			table.Columns.Add(columna5);
			table.Columns.Add(columna6);
			table.Columns.Add(columna7);
			table.Columns.Add(columna8);
			table.Columns.Add(columna9);
			table.Columns.Add(columna10);
			
			DataTable tableVariablesPuestos = mz.erp.dataaccess.sy_VariablesPuestos.GetListByCola( IdVariable, long.MinValue, long.MinValue, long.MinValue ).sy_VariablesPuestos;
			foreach (DataRow rowPU in tableVariablesPuestos.Rows)
			{
				string idVar = (string)rowPU["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowPUC = table.NewRow();
				rowPUC["IdVariable"] = rowPU["IdVariable"];
				rowPUC["ValorDefault"] = rowPU["ValorDefault"];
				rowPUC["Perfil"] = "";
				rowPUC["Puesto"] = rowPU["Puesto"];
				rowPUC["Usuario"] = "";
				if(rowSV != null)
				{
					rowPUC["Descripcion"] = rowSV["Descripcion"];
					rowPUC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowPUC["Descripcion"] = "";
					rowPUC["Tipo"] = "";
				}
				rowPUC["IdPuesto"] = rowPU["IdPuesto"];
				table.Rows.Add(rowPUC);

			}
			return table;
		}


		public static sy_VariablesPuestosDataset GetListByCola( string IdVariable)
		{
			return mz.erp.dataaccess.sy_VariablesPuestos.GetListByCola( IdVariable, long.MinValue, long.MinValue, long.MinValue );
		}

		public static object GetValue( string IdVariable, int IdEmpresa, int IdSucursal, int IdPuesto )
		{
			/*sy_VariablesPuestosDataset data = sy_VariablesPuestos.GetList( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
			if ( data != null && data.sy_VariablesPuestos.Rows.Count == 1 )
			{
				return ( ( sy_VariablesPuestosDataset.sy_VariablesPuestosRow ) data.sy_VariablesPuestos.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}*/
			sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = dataaccess.sy_VariablesPuestos.GetByPk( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
			if (row != null) 
			{
				return row.Valor;				
			}
			else 
			{
				return null;
			}						
		}
		
		public static object GetValuePK( string IdVariable, long IdEmpresa, long IdSucursal, long IdPuesto )
		{
			sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = dataaccess.sy_VariablesPuestos.GetByPk( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
			if (row != null) 
			{
				return row.Valor;				
			}
			else 
			{
				return null;
			}						
		}
	
		public static object GetValuePK( string IdVariable )
		{
			return GetValuePK( IdVariable, Security.IdEmpresa, Security.IdSucursal, Security.IdPuesto );

		}
		

		public static object GetValue( string IdVariable )
		{
			return GetValue( IdVariable, Int32.Parse( ApplicationConfiguration.Empresa ), Int32.Parse( ApplicationConfiguration.Sucursal ), Int32.Parse( ApplicationConfiguration.Puesto ) );

		}
		
		#endregion
		
		public sy_VariablesPuestos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesPuestos
		/// </summary>
		public static sy_VariablesPuestosDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesPuestos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesPuestos filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesPuestosDataset GetList( string IdVariable, long IdEmpresa, long IdSucursal, long IdPuesto )
		{
			return mz.erp.dataaccess.sy_VariablesPuestos.GetList( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
		}

		/// <summary>
		/// Crea un sy_VariablesPuestosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesPuestosDataset.sy_VariablesPuestosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesPuestos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesPuestos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesPuestosDataset.sy_VariablesPuestosRow GetByPk( string IdVariable, long IdEmpresa, long IdSucursal, long IdPuesto )
		{
			sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = mz.erp.dataaccess.sy_VariablesPuestos.GetByPk( IdVariable, IdEmpresa, IdSucursal, IdPuesto  );
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
		/// Obtiene un registro de la tabla sy_VariablesPuestos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesPuestosDataset.sy_VariablesPuestosRow GetByPk( object IdVariable, object IdEmpresa, object IdSucursal, object IdPuesto )
		{
			return GetByPk( ( string )IdVariable, ( long )IdEmpresa, ( long )IdSucursal, ( long )IdPuesto );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesPuestosRow.
		/// </summary>
		public static sy_VariablesPuestosDataset.sy_VariablesPuestosRow SetRowDefaultValues( sy_VariablesPuestosDataset.sy_VariablesPuestosRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa; 
			row.IdSucursal = Security.IdSucursal; 
			row.IdPuesto = 0; 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPuestosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesPuestosDataset.sy_VariablesPuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPuestosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesPuestosDataset.sy_VariablesPuestosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPuestosRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPuestosDataset.sy_VariablesPuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPuestos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesPuestosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPuestosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesPuestos.Rows.Count > 0, "La tabla dataSet.sy_VariablesPuestosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPuestos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPuestosDataset.sy_VariablesPuestosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPuestosDataset.sy_VariablesPuestosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPuestos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesPuestosRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesPuestosDataset.sy_VariablesPuestosRow row )
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
						
			if ( !IdPuestoIsValid( row.IdPuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdPuesto" , mensaje);
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
		/// Valida el campo IdPuesto.
		/// </summary>
		public static bool IdPuestoIsValid( long IdPuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPuesto. Metodo Sobrecargado
		/// </summary>
		public static bool IdPuestoIsValid( long IdPuesto)
		{
			string mensaje;
			return IdPuestoIsValid( IdPuesto, out mensaje );
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

