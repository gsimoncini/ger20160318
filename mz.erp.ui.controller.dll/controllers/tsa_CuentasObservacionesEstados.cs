namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	//using mz.erp.ui.controls;

	public class tsa_CuentasObservacionesEstados : IDisposable
	{
		public tsa_CuentasObservacionesEstados()
		{
		}

		public tsa_CuentasObservacionesEstados( string[] fieldList )
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
			
			if ( fl.Contains( "IdCuentaObservacionEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuentaObservacionEstado", "IdCuentaObservacionEstado", true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			//if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			//if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" , 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			//if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			//if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			//if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			//	if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			//	if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			//if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			//if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_CuentasObservacionesEstados.GetList().tsa_CuentasObservacionesEstados;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_CuentasObservacionesEstados.Update( ( tsa_CuentasObservacionesEstadosDataset.tsa_CuentasObservacionesEstadosDataTable )dataTable );
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

		[ SearchMember( "tsa_CuentasObservacionesEstados" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCuentaObservacionEstado", IsAlternativePrimaryKey = true ) ] string IdCuentaObservacionEstado, 
			[ SearchParameterInfo( "Descripcion" , IsDescription = true ) ] string Descripcion, 
			[ SearchParameterInfo( "Activo" ) ] bool Activo

			)
		{
			tsa_CuentasObservacionesEstadosDataset data = mz.erp.businessrules.tsa_CuentasObservacionesEstados.GetList( IdCuentaObservacionEstado, Descripcion, Activo);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

