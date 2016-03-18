namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesUsuarios : IDisposable
	{
	
		#region Custom Members

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
			
			DataTable tableVariablesUsuarios = mz.erp.dataaccess.sy_VariablesUsuarios.GetListByCola( IdVariable, string.Empty ).sy_VariablesUsuarios;
			foreach (DataRow rowU in tableVariablesUsuarios.Rows)
			{
				string idVar = (string)rowU["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowUC = table.NewRow();
				rowUC["IdVariable"] = rowU["IdVariable"];
				rowUC["ValorDefault"] = rowU["ValorDefault"];
				rowUC["Perfil"] = "";
				rowUC["Puesto"] = "";
				rowUC["Usuario"] = rowU["Usuario"];
				if(rowSV != null)
				{
					rowUC["Descripcion"] = rowSV["Descripcion"];
					rowUC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowUC["Descripcion"] = "";
					rowUC["Tipo"] = "";
				}
				rowUC["IdUsuario"] = rowU["IdUsuario"];
				table.Rows.Add(rowUC);

			}
			return table;
		}


		public static sy_VariablesUsuariosDataset GetListByCola( string IdVariable)
		{
			return mz.erp.dataaccess.sy_VariablesUsuarios.GetListByCola( IdVariable, string.Empty );
		}

		public static object GetValue( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset data = sy_VariablesUsuarios.GetList( IdVariable, IdUsuario );
			if ( data != null && data.sy_VariablesUsuarios.Rows.Count == 1 )
			{
				return ( ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow ) data.sy_VariablesUsuarios.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}
		}

        /* Silvina 20111230 - Tarea 0000245 */

        public static string GetValue(string IdVariable, string IdUsuario, string IdTransaction)
        {
            sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = sy_VariablesUsuarios.GetByPk(IdVariable, IdUsuario, IdTransaction);
            if (row != null)
            {
                return row.Valor;
            }
            else
            {
                return string.Empty;
            }
        }

        public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow GetByPk(string IdVariable, string IdUsuario, string IdTransaction)
        {
            sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = mz.erp.dataaccess.sy_VariablesUsuarios.GetByPk(IdVariable, IdUsuario, IdTransaction);
            if (row != null)
            {
                foreach (DataColumn dc in row.Table.Columns)
                {
                    if (!dc.Caption.ToUpper().Equals("ROWID"))
                    {
                        if (row[dc] == System.DBNull.Value)
                        {
                            row[dc] = Util.DefaultValue(dc.DataType);
                        }
                    }
                }
            }
            return row;

        }
        /* Fin Silvina 20111230 - Tarea 0000245 */

		public static object GetValuePK( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = sy_VariablesUsuarios.GetByPk(IdVariable, IdUsuario );
			if ( row != null)
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
			return GetValuePK( IdVariable, Security.IdUsuario );

		}
		

		public static object GetValue( string IdVariable )
		{
			return GetValue( IdVariable, Security.IdUsuario );

		}

		public static sy_VariablesUsuariosDataset GetList( string IdVariable )
		{
			return mz.erp.dataaccess.sy_VariablesUsuarios.GetList( IdVariable, string.Empty );
		}
		
		#endregion
		
		public sy_VariablesUsuarios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesUsuarios
		/// </summary>
		public static sy_VariablesUsuariosDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesUsuarios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_VariablesUsuarios filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesUsuariosDataset GetList( string IdVariable, string IdUsuario )
		{
			return mz.erp.dataaccess.sy_VariablesUsuarios.GetList( IdVariable, IdUsuario );
		}

		/// <summary>
		/// Crea un sy_VariablesUsuariosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesUsuarios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesUsuarios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow GetByPk( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = mz.erp.dataaccess.sy_VariablesUsuarios.GetByPk( IdVariable, IdUsuario  );
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
				return row;
			}
			else return null;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesUsuarios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow GetByPk( object IdVariable, string IdUsuario )
		{
			return GetByPk( ( string )IdVariable, ( string )IdUsuario );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesUsuariosRow.
		/// </summary>
		public static sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow SetRowDefaultValues( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdUsuario = Util.NewStringId(); 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesUsuariosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesUsuariosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesUsuariosRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesUsuarios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesUsuariosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesUsuariosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesUsuarios.Rows.Count > 0, "La tabla dataSet.sy_VariablesUsuariosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesUsuarios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesUsuarios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesUsuariosRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVariableIsValid( row.IdVariable, out mensaje) )
			{ 
				row.SetColumnError( "IdVariable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdUsuarioIsValid( row.IdUsuario, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
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
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario)
		{
			string mensaje;
			return IdUsuarioIsValid( IdUsuario, out mensaje );
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

