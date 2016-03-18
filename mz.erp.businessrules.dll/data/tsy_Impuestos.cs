namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_Impuestos : IDisposable
	{
	
		#region Custom Members
		public static tsy_ImpuestosDataset.tsy_ImpuestosDataTable NewTableInitialized()
		{
			mz.erp.commontypes.data.tsy_ImpuestosDataset.tsy_ImpuestosDataTable _table = ((mz.erp.commontypes.data.tsy_ImpuestosDataset)mz.erp.dataaccess.tsy_Impuestos.GetList()).tsy_Impuestos;
			return _table;
		}
		public static tsy_ImpuestosDataset.tsy_ImpuestosDataTable NewTable()
		{
			return new mz.erp.commontypes.data.tsy_ImpuestosDataset().tsy_Impuestos;
		}

        //German 20110602 - Tarea 0000149
        public static tsy_ImpuestosDataset GetListImpuestosInternos()
        {
            return mz.erp.dataaccess.tsy_Impuestos.GetListImpuestosInternos();
        }

        public static System.Collections.ArrayList GetListImpuestosInternosList()
        {
            System.Collections.ArrayList aux = new System.Collections.ArrayList();
            tsy_ImpuestosDataset data = mz.erp.dataaccess.tsy_Impuestos.GetListImpuestosInternos();
            foreach (tsy_ImpuestosDataset.tsy_ImpuestosRow row in data.tsy_Impuestos.Rows)
            {
                aux.Add(row.Impuesto);
            }
            return aux;
        }

        public static string  GetListImpuestosInternosString()
        {
            string aux = string.Empty;
            tsy_ImpuestosDataset data = mz.erp.dataaccess.tsy_Impuestos.GetListImpuestosInternos();
            string separator = ",";
            foreach (tsy_ImpuestosDataset.tsy_ImpuestosRow row in data.tsy_Impuestos.Rows)
            {
                aux = aux + row.Impuesto;
                aux = aux + separator;
            }
            if (aux != string.Empty)
                return aux.Remove(aux.Length - 1, 1);
            else return string.Empty;
        }

        public static void Update(tsy_ImpuestosDataset.tsy_ImpuestosDataTable dataTable,  sy_VariablesDataset.sy_VariablesDataTable dataTableVariables)
        {
            ApplicationAssert.Check(dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber);
            ApplicationAssert.Check(dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber);

            mz.erp.dataaccess.tsy_Impuestos.Update(dataTable, dataTableVariables);
        }
        //Fin German 20110602 - Tarea 0000149
		
		/// <summary>
		/// Obtiene el codigo de impuesto a partir del campo "Descripcion"
		/// </summary>
		public static string GetDescripcionCorta(string Impuesto) 
		{
			string descripcion = "";
			tsy_ImpuestosDataset data = dataaccess.tsy_Impuestos.GetList(null, Impuesto, null);
			if (data.tsy_Impuestos.Rows.Count > 0)
			{
				tsy_ImpuestosDataset.tsy_ImpuestosRow row = (tsy_ImpuestosDataset.tsy_ImpuestosRow) data.tsy_Impuestos.Rows[0];
				descripcion = row.DescripcionCorta;
			}
			
			return descripcion;
		}


		public static string GetIdImpuesto(string Impuesto) 
		{
			string IdImpuesto = "";
			tsy_ImpuestosDataset data = dataaccess.tsy_Impuestos.GetList(null, Impuesto, null);
			if (data.tsy_Impuestos.Rows.Count > 0)
			{
				tsy_ImpuestosDataset.tsy_ImpuestosRow row = (tsy_ImpuestosDataset.tsy_ImpuestosRow) data.tsy_Impuestos.Rows[0];
				IdImpuesto = row.IdImpuesto;
			}
			
			return IdImpuesto;
		}

		public static tsy_ImpuestosDataset.tsy_ImpuestosRow GetByImpuesto(string Impuesto) 
		{
			tsy_ImpuestosDataset.tsy_ImpuestosRow row = null;
			tsy_ImpuestosDataset data = dataaccess.tsy_Impuestos.GetList(null, Impuesto, null);
			if (data.tsy_Impuestos.Rows.Count > 0)
				row = (tsy_ImpuestosDataset.tsy_ImpuestosRow) data.tsy_Impuestos.Rows[0];
			return row;
		}
		#endregion
		
		public tsy_Impuestos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_Impuestos
		/// </summary>
		public static tsy_ImpuestosDataset GetList()
		{
			return mz.erp.dataaccess.tsy_Impuestos.GetList();
		}

		public static tsy_ImpuestosDataset GetList(string IdImpuesto)
		{
			long IdEmpresa = long.MinValue;
			long IdSucursal = long.MinValue;
			return mz.erp.dataaccess.tsy_Impuestos.GetList(IdImpuesto,null,null);
		}

		
		/// <summary>
		/// Crea un tsy_ImpuestosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_ImpuestosDataset.tsy_ImpuestosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_Impuestos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_Impuestos que luego puede ser persistido en la base de datos.
		/// </summary>
		/// 
		public static tsy_ImpuestosDataset.tsy_ImpuestosRow GetByPk( string IdImpuesto )
		{
			tsy_ImpuestosDataset.tsy_ImpuestosRow row = mz.erp.dataaccess.tsy_Impuestos.GetByPk( IdImpuesto  );
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
		/// Obtiene un registro de la tabla tsy_Impuestos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_ImpuestosDataset.tsy_ImpuestosRow GetByPk( object IdImpuesto )
		{
			return GetByPk( ( string )IdImpuesto );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ImpuestosRow.
		/// </summary>
		public static tsy_ImpuestosDataset.tsy_ImpuestosRow SetRowDefaultValues( tsy_ImpuestosDataset.tsy_ImpuestosRow row )
		{
			row.IdImpuesto = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.IdTipoDeConcepto = string.Empty;
			row.FormulaDeCalculo = string.Empty;
			row.MetodoDeComparacion = string.Empty;
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_ImpuestosDataset.tsy_ImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_ImpuestosDataset.tsy_ImpuestosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosDataset.tsy_ImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Impuestos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ImpuestosDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_Impuestos.Rows.Count > 0, "La tabla dataSet.tsy_ImpuestosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Impuestos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosDataset.tsy_ImpuestosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosDataset.tsy_ImpuestosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Impuestos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ImpuestosRow.
		/// </summary>
		public static bool RowIsValid( tsy_ImpuestosDataset.tsy_ImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdImpuestoIsValid( row.IdImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdImpuesto" , mensaje);
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

