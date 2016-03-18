namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_Conceptos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_Conceptos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_Conceptos
		/// </summary>
		public static tsy_ConceptosDataset GetList()
		{
			return mz.erp.dataaccess.tsy_Conceptos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_Conceptos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_ConceptosDataset GetList( long IdConcepto, string Descripcion, long IdTipoConcepto, decimal Valor, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsy_Conceptos.GetList( IdConcepto, Descripcion, IdTipoConcepto, Valor, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsy_ConceptosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ConceptosDataset.tsy_ConceptosRow NewRow()
		{
			return mz.erp.dataaccess.tsy_Conceptos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_Conceptos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ConceptosDataset.tsy_ConceptosRow GetByPk( long IdConcepto )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_Conceptos.GetByPk( IdConcepto ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ConceptosRow.
		/// </summary>
		public static tsy_ConceptosDataset.tsy_ConceptosRow SetRowDefaultValues( tsy_ConceptosDataset.tsy_ConceptosRow row )
		{
			row.IdConcepto = 0; 
			row.Descripcion = string.Empty;
			row.IdTipoConcepto = 0;
			row.Valor = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_ConceptosDataset.tsy_ConceptosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosDataset.tsy_ConceptosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Conceptos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ConceptosDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_Conceptos.Rows.Count > 0, "La tabla dataSet.tsy_ConceptosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Conceptos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ConceptosDataset.tsy_ConceptosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ConceptosDataset.tsy_ConceptosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_Conceptos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ConceptosRow.
		/// </summary>
		public static bool RowIsValid( tsy_ConceptosDataset.tsy_ConceptosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdConceptoIsValid( row.IdConcepto ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdTipoConceptoIsValid( row.IdTipoConcepto ) )
			{ 
				return false;
			}
						
			if ( !ValorIsValid( row.Valor ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConcepto.
		/// </summary>
		public static bool IdConceptoIsValid( long IdConcepto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoConcepto.
		/// </summary>
		public static bool IdTipoConceptoIsValid( long IdTipoConcepto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( decimal Valor )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}

