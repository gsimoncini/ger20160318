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

	public class sy_VariablesPuestos : IDisposable, IGridDocument
	{
		public sy_VariablesPuestos()
		{
		}

		public sy_VariablesPuestos( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
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
			
			if ( fl.Contains( "IdVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariable", "IdVariable" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdPuesto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPuesto", "IdPuesto" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_VariablesPuestos.GetList().sy_VariablesPuestos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_VariablesPuestos.Update( ( sy_VariablesPuestosDataset.sy_VariablesPuestosDataTable )dataTable );
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

		[ SearchMember( "sy_VariablesPuestos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdVariable" ) ] string IdVariable, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "IdPuesto" ) ] long IdPuesto
			)
		{
			sy_VariablesPuestosDataset data = mz.erp.businessrules.sy_VariablesPuestos.GetList( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

