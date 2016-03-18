using System;
using System.Data;

namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_AgrupProveedores : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetList(string IdProveedor)
		{			
			return mz.erp.dataaccess.tpu_AgrupProveedores.GetList(IdProveedor, Security.IdEmpresa);			
		}

		#endregion
		
		public tpu_AgrupProveedores()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_AgrupProveedores
		/// </summary>
		public static tpu_AgrupProveedoresDataset GetList()
		{
			return mz.erp.dataaccess.tpu_AgrupProveedores.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_AgrupProveedores filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_AgrupProveedoresDataset GetList( string IdProveedor, string Jerarquia, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_AgrupProveedores.GetList( IdProveedor, Jerarquia, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_AgrupProveedoresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_AgrupProveedores.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_AgrupProveedores que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow GetByPk( string IdProveedor, string Jerarquia )
		{
			tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row = mz.erp.dataaccess.tpu_AgrupProveedores.GetByPk( IdProveedor, Jerarquia  );
			if (row!=null){
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
					row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
					return row;
			}
			else return null;
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_AgrupProveedores que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow GetByPk( object IdProveedor, object Jerarquia )
		{
			return GetByPk( ( string )IdProveedor, ( string )Jerarquia );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_AgrupProveedoresRow.
		/// </summary>
		public static tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow SetRowDefaultValues( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row )
		{
			row.IdProveedor = Util.NewStringId(); 
			row.Jerarquia = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_AgrupProveedoresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_AgrupProveedoresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_AgrupProveedoresRow a la base de datos.
		/// </summary>
		public static void Update( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_AgrupProveedores.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_AgrupProveedoresDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_AgrupProveedoresDataset dataSet )
		{
			//ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			//ApplicationAssert.Check( dataSet.tpu_AgrupProveedores.Rows.Count > 0, "La tabla dataSet.tpu_AgrupProveedoresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_AgrupProveedores.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresDataTable dataTable )
		{
			//ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			//ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_AgrupProveedores.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_AgrupProveedoresRow.
		/// </summary>
		public static bool RowIsValid( tpu_AgrupProveedoresDataset.tpu_AgrupProveedoresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !JerarquiaIsValid( row.Jerarquia, out mensaje) )
			{ 
				row.SetColumnError( "Jerarquia" , mensaje);
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
			;
			
			return isValid;
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
		/// Valida el campo Jerarquia.
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Jerarquia. Metodo Sobrecargado
		/// </summary>
		public static bool JerarquiaIsValid( string Jerarquia)
		{
			string mensaje;
			return JerarquiaIsValid( Jerarquia, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

