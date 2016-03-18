namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Zonas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Zonas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Zonas
		/// </summary>
		public static tlg_ZonasDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Zonas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Zonas filtrada por las condiciones de búsqueda
		/// </summary>
		public static tlg_ZonasDataset GetList( string IdZona, string Descripcion, string Valor1, string Valor2, string Valor3 )
		{
			return mz.erp.dataaccess.tlg_Zonas.GetList( IdZona, Descripcion, Valor1, Valor2, Valor3 );
		}

		/// <summary>
		/// Crea un tlg_ZonasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_ZonasDataset.tlg_ZonasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Zonas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Zonas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_ZonasDataset.tlg_ZonasRow GetByPk( string IdZona )
		{
		   tlg_ZonasDataset.tlg_ZonasRow row = mz.erp.dataaccess.tlg_Zonas.GetByPk( IdZona  );
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
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Zonas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_ZonasDataset.tlg_ZonasRow GetByPk( object IdZona )
		{
			return GetByPk( ( string )IdZona );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_ZonasRow.
		/// </summary>
		public static tlg_ZonasDataset.tlg_ZonasRow SetRowDefaultValues( tlg_ZonasDataset.tlg_ZonasRow row )
		{
			row.IdZona = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Valor1 = string.Empty;
			row.Valor2 = string.Empty;
			row.Valor3 = string.Empty;
			row.FormulaDeCalculo = string.Empty;
			row.IdConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ZonasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_ZonasDataset.tlg_ZonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ZonasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_ZonasDataset.tlg_ZonasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ZonasRow a la base de datos.
		/// </summary>
		public static void Update( tlg_ZonasDataset.tlg_ZonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Zonas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_ZonasDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_ZonasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Zonas.Rows.Count > 0, "La tabla dataSet.tlg_ZonasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Zonas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ZonasDataset.tlg_ZonasDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_ZonasDataset.tlg_ZonasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Zonas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_ZonasRow.
		/// </summary>
		public static bool RowIsValid( tlg_ZonasDataset.tlg_ZonasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdZonaIsValid( row.IdZona, out mensaje) )
			{ 
				row.SetColumnError( "IdZona" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
						
			/*
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
			*/			
			
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
		/// Valida el campo IdZona.
		/// </summary>
		public static bool IdZonaIsValid( string IdZona , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdZona. Metodo Sobrecargado
		/// </summary>
		public static bool IdZonaIsValid( string IdZona)
		{
			string mensaje;
			return IdZonaIsValid( IdZona, out mensaje );
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

