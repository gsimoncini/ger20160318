namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_VariablesPerfiles : IDisposable
	{
	
		#region Custom Members

		//German 20090804

		public static object GetValue( string IdVariable, int IdPerfil, string IdTransaction)
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil, IdTransaction );
			if (row != null) 
			{
				return row.Valor;				
			}
			else 
			{
				return null;
			}
		}

		public static object GetValue( string IdVariable, int IdPerfil )
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil );
			if (row != null) 
			{
				return row.Valor;				
			}
			else 
			{
				return null;
			}
		}

		
		/*
		public static object GetValue( string IdVariable )
		{
			return GetValue( IdVariable, ( int )Security.IdPerfil );
		}
		*/

		//Fin German 20090804

		/*
		public static object GetValue( string IdVariable, int IdPerfil )
		{
			sy_VariablesPerfilesDataset data = sy_VariablesPerfiles.GetList( IdVariable, IdPerfil );
			
			if ( data != null && data.sy_VariablesPerfiles.Rows.Count == 1 )
			{
				return ( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow ) data.sy_VariablesPerfiles.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}
		}

		public static object GetValue( string IdVariable )
		{
			return GetValue( IdVariable, ( int )Security.IdPerfil );
		}
		*/

		public static object GetValuePK( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil );
			
			if ( row != null )
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
			return GetValuePK( IdVariable, Security.IdPerfil );
		}

		public static sy_VariablesPerfilesDataset GetListByCola( string IdVariable)
		{
			return mz.erp.dataaccess.sy_VariablesPerfiles.GetListByCola( IdVariable, long.MinValue );
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
			
			DataTable tableVariablesPerfiles = mz.erp.dataaccess.sy_VariablesPerfiles.GetListByCola(IdVariable, long.MinValue).sy_VariablesPerfiles;
			foreach (DataRow rowP in tableVariablesPerfiles.Rows)
			{
				string idVar = (string)rowP["IdVariable"];
				sy_VariablesDataset.sy_VariablesRow rowSV = sy_Variables.GetByPk(idVar);
				DataRow rowPC = table.NewRow();
				rowPC["IdVariable"] = rowP["IdVariable"];
				rowPC["ValorDefault"] = rowP["ValorDefault"];
				rowPC["Perfil"] = rowP["Perfil"];
				rowPC["Puesto"] = "";
				rowPC["Usuario"] = "";
				if(rowSV != null)
				{
					rowPC["Descripcion"] = rowSV["Descripcion"];
					rowPC["Tipo"] = rowSV["IdTipoVariable"];
				}
				else
				{
					rowPC["Descripcion"] = "";
					rowPC["Tipo"] = "";
				}
				rowPC["IdPerfil"] = rowP["IdPerfil"];
				table.Rows.Add(rowPC);

			}
			return table;
		}
		#endregion
		
		public sy_VariablesPerfiles()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_VariablesPerfiles
		/// </summary>
		public static sy_VariablesPerfilesDataset GetList()
		{
			return mz.erp.dataaccess.sy_VariablesPerfiles.GetList();
		}

        /* Silvina 20101021 - Tarea 902 */
        public static sy_VariablesPerfilesDataset GetListBy(string IdVariable)
        {
            return mz.erp.dataaccess.sy_VariablesPerfiles.GetListBy(IdVariable);
        }
        /* Fin Silvina */

		/// <summary>
		/// Obtiene tabla sy_VariablesPerfiles filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_VariablesPerfilesDataset GetList( string IdVariable, long IdPerfil )
		{
			return mz.erp.dataaccess.sy_VariablesPerfiles.GetList( IdVariable, IdPerfil );
		}
		public static sy_VariablesPerfilesDataset GetList( string IdVariable )
		{
			return mz.erp.dataaccess.sy_VariablesPerfiles.GetList( IdVariable , long.MinValue);
		}

		/// <summary>
		/// Crea un sy_VariablesPerfilesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_VariablesPerfiles.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_VariablesPerfiles que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow GetByPk( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = mz.erp.dataaccess.sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil  );
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

		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow GetByPk( string IdVariable, long IdPerfil, string IdTransaction )
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = mz.erp.dataaccess.sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil, IdTransaction  );
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
		/// Obtiene un registro de la tabla sy_VariablesPerfiles que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow GetByPk( object IdVariable, object IdPerfil )
		{
			return GetByPk( ( string )IdVariable, ( long )IdPerfil );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_VariablesPerfilesRow.
		/// </summary>
		public static sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow SetRowDefaultValues( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row )
		{
			row.IdVariable = Util.NewStringId(); 
			row.IdPerfil = 0; 
			row.Valor = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}

		public static DataRow SetRowDefaultValues( DataRow row )
		{
			row["IdVariable"] = Util.NewStringId(); 
			row["IdPerfil"] = 0; 
			row["Valor"] = string.Empty;
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["RowId"] = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPerfilesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPerfilesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPerfilesRow a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPerfiles.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_VariablesPerfilesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPerfilesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_VariablesPerfiles.Rows.Count > 0, "La tabla dataSet.sy_VariablesPerfilesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPerfiles.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_VariablesPerfiles.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_VariablesPerfilesRow.
		/// </summary>
		public static bool RowIsValid( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVariableIsValid( row.IdVariable, out mensaje) )
			{ 
				row.SetColumnError( "IdVariable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPerfilIsValid( row.IdPerfil, out mensaje) )
			{ 
				row.SetColumnError( "IdPerfil" , mensaje);
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
						
			/*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
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
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPerfil. Metodo Sobrecargado
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil)
		{
			string mensaje;
			return IdPerfilIsValid( IdPerfil, out mensaje );
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

