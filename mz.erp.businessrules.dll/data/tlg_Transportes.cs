namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;



	public class tlg_Transportes : IDisposable
	{
	
	 	public tlg_Transportes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Transportes
		/// </summary>
		public static tlg_TransportesDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Transportes.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Transportes filtrada por las condiciones de búsqueda
		/// </summary>
		public static tlg_TransportesDataset GetList( string IdTransporte, string Descripcion, string IdResponsable, string IdProveedor )
		{
			return mz.erp.dataaccess.tlg_Transportes.GetList( IdTransporte, Descripcion, IdResponsable, IdProveedor );
		}

		/// <summary>
		/// Crea un tlg_TransportesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_TransportesDataset.tlg_TransportesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Transportes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Transportes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_TransportesDataset.tlg_TransportesRow GetByPk( string IdTransporte )
		{
		    tlg_TransportesDataset.tlg_TransportesRow row = mz.erp.dataaccess.tlg_Transportes.GetByPk( IdTransporte );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" ) //despues sacarlo, no se por que se cuelga este campo
						{ 
							row[dc] = Util.DefaultValue( dc.DataType ); //esta linea dejarla
						}					
					}
				
				}
			}
			return row;
		}
		
		/// <summary>
		/// Obtiene un registro de la tabla tlg_Transportes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_TransportesDataset.tlg_TransportesRow GetByPk( object IdTransporte )
		{
			return GetByPk( ( string )IdTransporte );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_TransportesRow.
		/// </summary>
		public static tlg_TransportesDataset.tlg_TransportesRow SetRowDefaultValues( tlg_TransportesDataset.tlg_TransportesRow row )
		{
			row.IdTransporte = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
			row.IdProveedor = string.Empty;
			row.Valor1 = "0";
			row.Valor2 = "0";
			row.Valor3 = "0";
			row.FormulaDeCalculo = string.Empty;
			row.IdConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransportesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_TransportesDataset.tlg_TransportesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );			
		
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransportesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_TransportesDataset.tlg_TransportesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransportesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_TransportesDataset.tlg_TransportesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Transportes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_TransportesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_TransportesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Transportes.Rows.Count > 0, "La tabla dataSet.tlg_TransportesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Transportes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransportesDataset.tlg_TransportesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_TransportesDataset.tlg_TransportesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Transportes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_TransportesRow.
		/// </summary>
		public static bool RowIsValid( tlg_TransportesDataset.tlg_TransportesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTransporteIsValid( row.IdTransporte, out mensaje) )
			{ 
				row.SetColumnError( "IdTransporte" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor1IsValid( row.Valor1, out mensaje) )
			{ 
				row.SetColumnError( "Valor1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor2IsValid( row.Valor2, out mensaje) )
			{ 
				row.SetColumnError( "Valor2" , mensaje);
				isValid=false;
			
			}
						
			if ( !Valor3IsValid( row.Valor3, out mensaje) )
			{ 
				row.SetColumnError( "Valor3" , mensaje);
				isValid=false;
			
			}
						
			if ( !FormulaDeCalculoIsValid( row.FormulaDeCalculo, out mensaje) )
			{ 
				row.SetColumnError( "FormulaDeCalculo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
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
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}*/
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTransporte.
		/// </summary>
		public static bool IdTransporteIsValid( string IdTransporte , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTransporte. Metodo Sobrecargado
		/// </summary>
		public static bool IdTransporteIsValid( string IdTransporte)
		{
			string mensaje;
			return IdTransporteIsValid( IdTransporte, out mensaje );
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
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor)
		{
			string mensaje;
			return IdProveedorIsValid( IdProveedor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor1.
		/// </summary>
		public static bool Valor1IsValid( string Valor1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor1. Metodo Sobrecargado
		/// </summary>
		public static bool Valor1IsValid( string Valor1)
		{
			string mensaje;
			return Valor1IsValid( Valor1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor2.
		/// </summary>
		public static bool Valor2IsValid( string Valor2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor2. Metodo Sobrecargado
		/// </summary>
		public static bool Valor2IsValid( string Valor2)
		{
			string mensaje;
			return Valor2IsValid( Valor2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor3.
		/// </summary>
		public static bool Valor3IsValid( string Valor3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor3. Metodo Sobrecargado
		/// </summary>
		public static bool Valor3IsValid( string Valor3)
		{
			string mensaje;
			return Valor3IsValid( Valor3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FormulaDeCalculo.
		/// </summary>
		public static bool FormulaDeCalculoIsValid( string FormulaDeCalculo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FormulaDeCalculo. Metodo Sobrecargado
		/// </summary>
		public static bool FormulaDeCalculoIsValid( string FormulaDeCalculo)
		{
			string mensaje;
			return FormulaDeCalculoIsValid( FormulaDeCalculo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexion.
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion)
		{
			string mensaje;
			return IdConexionIsValid( IdConexion, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

