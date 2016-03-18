namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_ProductosCoeficientesAplicados : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosCoeficientesAplicados()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosCoeficientesAplicados
		/// </summary>
		public static tsh_ProductosCoeficientesAplicadosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosCoeficientesAplicados filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ProductosCoeficientesAplicadosDataset GetList( string IdProducto, string IdCoeficienteCostoIndirecto1, string IdCoeficienteCostoIndirecto2, string IdCoeficienteCostoIndirecto3, string IdCoeficienteCostoIndirecto4, string IdCoeficienteCostoIndirecto5, string IdCoeficienteCostoIndirecto6, string IdCoeficienteCostoIndirecto7, string IdCoeficienteCostoIndirecto8, string IdCoeficienteCostoIndirecto9, string IdCoeficienteCostoIndirecto10 )
		{
			return mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.GetList( IdProducto, IdCoeficienteCostoIndirecto1, IdCoeficienteCostoIndirecto2, IdCoeficienteCostoIndirecto3, IdCoeficienteCostoIndirecto4, IdCoeficienteCostoIndirecto5, IdCoeficienteCostoIndirecto6, IdCoeficienteCostoIndirecto7, IdCoeficienteCostoIndirecto8, IdCoeficienteCostoIndirecto9, IdCoeficienteCostoIndirecto10 );
		}

		/// <summary>
		/// Crea un tsh_ProductosCoeficientesAplicadosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosCoeficientesAplicados que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow GetByPk( string IdProducto )
		{
			tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row = mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.GetByPk( IdProducto  );
			if ( row != null )
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
                    if (!dc.ColumnName.ToUpper().Equals("ROWID"))
                    {
                        if (row[dc] == System.DBNull.Value)
                        {
                            row[dc] = Util.DefaultValue(dc.DataType);
                        }
                    }
				}
				return row;
			}
			return null;
		}
        //Deprecated - Se rompe si el ROWID es string.empty
        /*
        public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow GetByPk(string IdProducto)
        {
            tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row = mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.GetByPk(IdProducto);
            if (row != null)
            {
                foreach (DataColumn dc in row.Table.Columns)
                {
                    if (row[dc] == System.DBNull.Value)
                    {
                          row[dc] = Util.DefaultValue(dc.DataType);
                    }
                    
                }
                return row;
            }
            return null;
        }
        */
		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosCoeficientesAplicados que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow GetByPk( object IdProducto )
		{
			return GetByPk( ( string )IdProducto );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosCoeficientesAplicadosRow.
		/// </summary>
		public static tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow SetRowDefaultValues( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = null;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.IdCoeficienteCostoIndirecto1 = string.Empty;
			row.Valor1 = 0;
			row.IdCoeficienteCostoIndirecto2 = string.Empty;
			row.Valor2 = 0;
			row.IdCoeficienteCostoIndirecto3 = string.Empty;
			row.Valor3 = 0;
			row.IdCoeficienteCostoIndirecto4 = string.Empty;
			row.Valor4 = 0;
			row.IdCoeficienteCostoIndirecto5 = string.Empty;
			row.Valor5 = 0;
			row.IdCoeficienteCostoIndirecto6 = string.Empty;
			row.Valor6 = 0;
			row.IdCoeficienteCostoIndirecto7 = string.Empty;
			row.Valor7 = 0;
			row.IdCoeficienteCostoIndirecto8 = string.Empty;
			row.Valor8 = 0;
			row.IdCoeficienteCostoIndirecto9 = string.Empty;
			row.Valor9 = 0;
			row.IdCoeficienteCostoIndirecto10 = string.Empty;
			row.Valor10 = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosCoeficientesAplicadosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosCoeficientesAplicadosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosCoeficientesAplicadosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosCoeficientesAplicadosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosCoeficientesAplicadosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosCoeficientesAplicados.Rows.Count > 0, "La tabla dataSet.tsh_ProductosCoeficientesAplicadosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosCoeficientesAplicados.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosCoeficientesAplicadosRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
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
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto1IsValid( row.IdCoeficienteCostoIndirecto1, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor1IsValid( row.Valor1, out mensaje) )
			{ 
				row.SetColumnError( "Valor1" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto2IsValid( row.IdCoeficienteCostoIndirecto2, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto2" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor2IsValid( row.Valor2, out mensaje) )
			{ 
				row.SetColumnError( "Valor2" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto3IsValid( row.IdCoeficienteCostoIndirecto3, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto3" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor3IsValid( row.Valor3, out mensaje) )
			{ 
				row.SetColumnError( "Valor3" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto4IsValid( row.IdCoeficienteCostoIndirecto4, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto4" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor4IsValid( row.Valor4, out mensaje) )
			{ 
				row.SetColumnError( "Valor4" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto5IsValid( row.IdCoeficienteCostoIndirecto5, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto5" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor5IsValid( row.Valor5, out mensaje) )
			{ 
				row.SetColumnError( "Valor5" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto6IsValid( row.IdCoeficienteCostoIndirecto6, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto6" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor6IsValid( row.Valor6, out mensaje) )
			{ 
				row.SetColumnError( "Valor6" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto7IsValid( row.IdCoeficienteCostoIndirecto7, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto7" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor7IsValid( row.Valor7, out mensaje) )
			{ 
				row.SetColumnError( "Valor7" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto8IsValid( row.IdCoeficienteCostoIndirecto8, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto8" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor8IsValid( row.Valor8, out mensaje) )
			{ 
				row.SetColumnError( "Valor8" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto9IsValid( row.IdCoeficienteCostoIndirecto9, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto9" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor9IsValid( row.Valor9, out mensaje) )
			{ 
				row.SetColumnError( "Valor9" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCoeficienteCostoIndirecto10IsValid( row.IdCoeficienteCostoIndirecto10, out mensaje) )
			{ 
				row.SetColumnError( "IdCoeficienteCostoIndirecto10" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor10IsValid( row.Valor10, out mensaje) )
			{ 
				row.SetColumnError( "Valor10" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		public static bool RowIdIsValid( string RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( string RowId)
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
		/// Valida el campo IdCoeficienteCostoIndirecto1.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto1IsValid( string IdCoeficienteCostoIndirecto1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto1. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto1IsValid( string IdCoeficienteCostoIndirecto1)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto1IsValid( IdCoeficienteCostoIndirecto1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor1.
		/// </summary>
		public static bool Valor1IsValid( decimal Valor1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor1. Metodo Sobrecargado
		/// </summary>
		public static bool Valor1IsValid( decimal Valor1)
		{
			string mensaje;
			return Valor1IsValid( Valor1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto2.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto2IsValid( string IdCoeficienteCostoIndirecto2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto2. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto2IsValid( string IdCoeficienteCostoIndirecto2)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto2IsValid( IdCoeficienteCostoIndirecto2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor2.
		/// </summary>
		public static bool Valor2IsValid( decimal Valor2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor2. Metodo Sobrecargado
		/// </summary>
		public static bool Valor2IsValid( decimal Valor2)
		{
			string mensaje;
			return Valor2IsValid( Valor2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto3.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto3IsValid( string IdCoeficienteCostoIndirecto3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto3. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto3IsValid( string IdCoeficienteCostoIndirecto3)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto3IsValid( IdCoeficienteCostoIndirecto3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor3.
		/// </summary>
		public static bool Valor3IsValid( decimal Valor3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor3. Metodo Sobrecargado
		/// </summary>
		public static bool Valor3IsValid( decimal Valor3)
		{
			string mensaje;
			return Valor3IsValid( Valor3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto4.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto4IsValid( string IdCoeficienteCostoIndirecto4 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto4. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto4IsValid( string IdCoeficienteCostoIndirecto4)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto4IsValid( IdCoeficienteCostoIndirecto4, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor4.
		/// </summary>
		public static bool Valor4IsValid( decimal Valor4 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor4. Metodo Sobrecargado
		/// </summary>
		public static bool Valor4IsValid( decimal Valor4)
		{
			string mensaje;
			return Valor4IsValid( Valor4, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto5.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto5IsValid( string IdCoeficienteCostoIndirecto5 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto5. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto5IsValid( string IdCoeficienteCostoIndirecto5)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto5IsValid( IdCoeficienteCostoIndirecto5, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor5.
		/// </summary>
		public static bool Valor5IsValid( decimal Valor5 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor5. Metodo Sobrecargado
		/// </summary>
		public static bool Valor5IsValid( decimal Valor5)
		{
			string mensaje;
			return Valor5IsValid( Valor5, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto6.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto6IsValid( string IdCoeficienteCostoIndirecto6 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto6. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto6IsValid( string IdCoeficienteCostoIndirecto6)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto6IsValid( IdCoeficienteCostoIndirecto6, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor6.
		/// </summary>
		public static bool Valor6IsValid( decimal Valor6 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor6. Metodo Sobrecargado
		/// </summary>
		public static bool Valor6IsValid( decimal Valor6)
		{
			string mensaje;
			return Valor6IsValid( Valor6, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto7.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto7IsValid( string IdCoeficienteCostoIndirecto7 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto7. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto7IsValid( string IdCoeficienteCostoIndirecto7)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto7IsValid( IdCoeficienteCostoIndirecto7, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor7.
		/// </summary>
		public static bool Valor7IsValid( decimal Valor7 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor7. Metodo Sobrecargado
		/// </summary>
		public static bool Valor7IsValid( decimal Valor7)
		{
			string mensaje;
			return Valor7IsValid( Valor7, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto8.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto8IsValid( string IdCoeficienteCostoIndirecto8 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto8. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto8IsValid( string IdCoeficienteCostoIndirecto8)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto8IsValid( IdCoeficienteCostoIndirecto8, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor8.
		/// </summary>
		public static bool Valor8IsValid( decimal Valor8 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor8. Metodo Sobrecargado
		/// </summary>
		public static bool Valor8IsValid( decimal Valor8)
		{
			string mensaje;
			return Valor8IsValid( Valor8, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto9.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto9IsValid( string IdCoeficienteCostoIndirecto9 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto9. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto9IsValid( string IdCoeficienteCostoIndirecto9)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto9IsValid( IdCoeficienteCostoIndirecto9, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor9.
		/// </summary>
		public static bool Valor9IsValid( decimal Valor9 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor9. Metodo Sobrecargado
		/// </summary>
		public static bool Valor9IsValid( decimal Valor9)
		{
			string mensaje;
			return Valor9IsValid( Valor9, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto10.
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto10IsValid( string IdCoeficienteCostoIndirecto10 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCoeficienteCostoIndirecto10. Metodo Sobrecargado
		/// </summary>
		public static bool IdCoeficienteCostoIndirecto10IsValid( string IdCoeficienteCostoIndirecto10)
		{
			string mensaje;
			return IdCoeficienteCostoIndirecto10IsValid( IdCoeficienteCostoIndirecto10, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor10.
		/// </summary>
		public static bool Valor10IsValid( decimal Valor10 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor10. Metodo Sobrecargado
		/// </summary>
		public static bool Valor10IsValid( decimal Valor10)
		{
			string mensaje;
			return Valor10IsValid( Valor10, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

