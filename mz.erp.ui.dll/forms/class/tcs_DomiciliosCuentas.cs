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

	public class tcs_DomiciliosCuentas : IDisposable, IGridDocument
	{
		public tcs_DomiciliosCuentas()
		{
		}

		public tcs_DomiciliosCuentas( string[] fieldList )
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
			
			if ( fl.Contains( "idDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "idDomicilio", "idDomicilio" ) );
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tcs_DomiciliosCuentas.GetList().tcs_DomiciliosCuentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tcs_DomiciliosCuentas.Update( ( tcs_DomiciliosCuentasDataset.tcs_DomiciliosCuentasDataTable )dataTable );
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

		[ SearchMember( "tcs_DomiciliosCuentas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "idDomicilio" ) ] string  idDomicilio, 
			[ SearchParameterInfo( "IdCuenta" ) ] string IdCuenta
			)
		{
			tcs_DomiciliosCuentasDataset data = mz.erp.businessrules.tcs_DomiciliosCuentas.GetList( idDomicilio, IdCuenta);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


