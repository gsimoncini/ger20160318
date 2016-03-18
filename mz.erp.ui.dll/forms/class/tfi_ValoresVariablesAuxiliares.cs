namespace mz.erp.ui
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;

	public class tfi_ValoresVariablesAuxiliares //: IDisposable, IGridDocument
	{
		public tfi_ValoresVariablesAuxiliares()
		{
		}

	/*	public tfi_ValoresVariablesAuxiliares( string[] fieldList )
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
			
			if ( fl.Contains( "IdValorVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValorVariable", "IdValorVariable" ) );
			if ( fl.Contains( "IdVariableAuxiliarTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariableAuxiliarTDCompTesoreria", "IdVariableAuxiliarTDCompTesoreria" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_ValoresVariablesAuxiliares.GetList().tfi_ValoresVariablesAuxiliares;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_ValoresVariablesAuxiliares.Update( ( tfi_ValoresVariablesAuxiliaresDataset.tfi_ValoresVariablesAuxiliaresDataTable )dataTable );
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

		[ SearchMember( "tfi_ValoresVariablesAuxiliares" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdValorVariable" ) ] string IdValorVariable, 
			[ SearchParameterInfo( "IdVariableAuxiliarTDCompTesoreria" ) ] string IdVariableAuxiliarTDCompTesoreria, 
			[ SearchParameterInfo( "Valor" ) ] string Valor
			)
		{
			tfi_ValoresVariablesAuxiliaresDataset data = mz.erp.businessrules.tfi_ValoresVariablesAuxiliares.GetList( IdValorVariable, IdVariableAuxiliarTDCompTesoreria, Valor );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		*/
	}
}

