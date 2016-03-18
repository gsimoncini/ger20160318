//Matias - 20110905 - Tarea 0000131
namespace mz.erp.businessrules
{
    using System;
    using System.Data;
    using System.Text.RegularExpressions;
    using mz.erp.systemframework;
    using mz.erp.commontypes;
    using mz.erp.commontypes.data;
    using mz.erp.dataaccess;

    class tsy_AfipTiposDeComprobantes: IDisposable
    {
        #region Custom Members
		
		#endregion

        public tsy_AfipTiposDeComprobantes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_AfipTiposDeComprobantes
		/// </summary>
        public static tsy_AfipTiposDeComprobantesDataset GetList()
		{
			return mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.GetList();
		}

        public static DataRow GetByIdTipoDeComprobante(string IdTipoDeComprobante)
        {
            return mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.GetByIdTipoDeComprobante(IdTipoDeComprobante);
        }

		/// <summary>
		/// Crea un tsy_AfipTiposDeComprobantesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_AfipTiposDeComprobantes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow GetByPk( string Codigo )
		{
            tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row = mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.GetByPk(Codigo);
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_AfipTiposDeComprobantes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow GetByPk( object Codigo )
		{
            return GetByPk((string)Codigo);
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_AfipTiposDeComprobantesRow.
		/// </summary>
		public static tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow SetRowDefaultValues( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row )
		{
            row.Codigo = string.Empty; 
            row.Descripcion = string.Empty;
			
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_AfipTiposDeComprobantesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_AfipTiposDeComprobantesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_AfipTiposDeComprobantesRow a la base de datos.
		/// </summary>
		public static void Update( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_AfipTiposDeComprobantesDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_AfipTiposDeComprobantesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_AfipTiposDeComprobantes.Rows.Count > 0, "La tabla dataSet.tsy_AfipTiposDeComprobantesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_AfipTiposDeComprobantes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_AfipTiposDeComprobantesRow.
		/// </summary>
		public static bool RowIsValid( tsy_AfipTiposDeComprobantesDataset.tsy_AfipTiposDeComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;


            if (!CodigoIsValid(row.Codigo, out mensaje))
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}

			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva.
		/// </summary>
        public static bool CodigoIsValid(string Codigo, out string mensaje)
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva. Metodo Sobrecargado
		/// </summary>
        public static bool CodigoIsValid(string Codigo)
		{
			string mensaje;
            return CodigoIsValid(Codigo, out mensaje);
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
		
		public void Dispose()
		{
		}
    }
}
//FinMatias - 20110905 - Tarea 0000131