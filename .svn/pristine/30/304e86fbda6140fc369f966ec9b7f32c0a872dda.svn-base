namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
	using mz.erp.ui.controllers;

	public class tlg_Transportes : IDisposable, IGridDocument
	{
		public tlg_Transportes()
		{
		}

		public tlg_Transportes( string[] fieldList )
		{
			_fieldList = fieldList;
		}

		[ atMethodLayoutData ]
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdTransporte" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTransporte", "Transporte" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción" ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "Responsable" ) );
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "Proveedor" ) );
			if ( fl.Contains( "Valor1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor1", "Costo de Flete" ) );
			/*if ( fl.Contains( "Valor2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor2", "Valor2" ) );
			if ( fl.Contains( "Valor3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor3", "Valor3" ) );
			if ( fl.Contains( "FormulaDeCalculo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FormulaDeCalculo", "FormulaDeCalculo" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tlg_Transportes.GetList().tlg_Transportes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_Transportes.Update( ( tlg_TransportesDataset.tlg_TransportesDataTable )dataTable );
		}
		
		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		
		[ SearchMember( "tlg_Transportes" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTransporte", IsAlternativePrimaryKey = true ) ] string IdTransporte, 
									   [ SearchParameterInfo( "Descripcion" , IsDescription = true )] string Descripcion, 
									   [ SearchParameterInfo( "IdResponsable" ) ] string IdResponsable, 
									   [ SearchParameterInfo( "IdProveedor" ) ] string IdProveedor 
			                         )
		{
			tlg_TransportesDataset data = mz.erp.businessrules.tlg_Transportes.GetList( IdTransporte, Descripcion, IdResponsable, IdProveedor );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

