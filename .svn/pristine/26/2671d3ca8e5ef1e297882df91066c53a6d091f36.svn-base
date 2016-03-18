namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_ImpuestosProductos : IDisposable
	{
	
		#region Custom Members


		public static tsy_ImpuestosProductosDataset GetListByIdProducto( string IdProducto)
		{
			return mz.erp.dataaccess.tsy_ImpuestosProductos.GetListByIdProducto(IdProducto);
		}


		public static mz.erp.commontypes.data.tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable NewTableInitialized()
		{
			mz.erp.commontypes.data.tsy_ImpuestosDataset.tsy_ImpuestosDataTable _table = mz.erp.businessrules.tsy_Impuestos.NewTableInitialized();
			mz.erp.commontypes.data.tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable _tableImpuestosProductos = NewTable();
			foreach( System.Data.DataRow _row in _table.Rows)
			{
				mz.erp.commontypes.data.tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow _impuestosProductosRow = SetRowDefaultValues(_tableImpuestosProductos.Newtsy_ImpuestosProductosRow());
				_impuestosProductosRow.IdImpuesto = Convert.ToString(_row["IdImpuesto"]);
			}
			return _tableImpuestosProductos;
		

		}
		public static mz.erp.commontypes.data.tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable NewTable()
		{
			mz.erp.commontypes.data.tsy_ImpuestosProductosDataset _data = new tsy_ImpuestosProductosDataset();
			return _data.tsy_ImpuestosProductos;
		}
		
		public static bool Find( string IdProducto, string IdImpuesto)
		{
			/*long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = 19;*/
			tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row = dataaccess.tsy_ImpuestosProductos.GetByPk(IdProducto, IdImpuesto);						
			return (row != null);
		}
		
		#endregion
		
		public tsy_ImpuestosProductos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_ImpuestosProductos
		/// </summary>
		public static tsy_ImpuestosProductosDataset GetList()
		{
			return mz.erp.dataaccess.tsy_ImpuestosProductos.GetList();
		}

		public static tsy_ImpuestosProductosDataset GetList(string IdProducto)
		{
			string IdImpuesto = null;
			long IdEmpresa = long.MinValue;
			long IdSucursal = long.MinValue;
			return mz.erp.dataaccess.tsy_ImpuestosProductos.GetList(IdProducto, IdImpuesto, IdEmpresa, IdSucursal);
		}

		
		/// <summary>
		/// Crea un tsy_ImpuestosProductosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_ImpuestosProductos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_ImpuestosProductos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow GetByPk( string IdProducto, string IdImpuesto )
		{
			tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row = mz.erp.dataaccess.tsy_ImpuestosProductos.GetByPk( IdProducto, IdImpuesto  );
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
		/// Obtiene un registro de la tabla tsy_ImpuestosProductos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow GetByPk( object IdProducto, object IdImpuesto )
		{
			return GetByPk( ( string )IdProducto, ( string )IdImpuesto );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ImpuestosProductosRow.
		/// </summary>
		public static tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow SetRowDefaultValues( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdImpuesto = Util.NewStringId(); 
			row.MetodoDeAsignacion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;			
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosProductosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosProductosRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosProductos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ImpuestosProductosDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosProductosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_ImpuestosProductos.Rows.Count > 0, "La tabla dataSet.tsy_ImpuestosProductosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosProductos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosProductos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ImpuestosProductosRow.
		/// </summary>
		public static bool RowIsValid( tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdImpuestoIsValid( row.IdImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdImpuesto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MetodoDeAsignacionIsValid( row.MetodoDeAsignacion, out mensaje) )
			{ 
				row.SetColumnError( "MetodoDeAsignacion" , mensaje);
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
		/// Valida el campo IdImpuesto.
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto)
		{
			string mensaje;
			return IdImpuestoIsValid( IdImpuesto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion.
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion. Metodo Sobrecargado
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion)
		{
			string mensaje;
			return MetodoDeAsignacionIsValid( MetodoDeAsignacion, out mensaje );
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

