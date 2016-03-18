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
	/// <summary>
	/// Descripción breve de tpu_ProveedoresObservacionesEstados.
	/// </summary>
	public class tpu_ProveedoresObservacionesEstados
	{
		public tpu_ProveedoresObservacionesEstados()
		{
		}
		public tpu_ProveedoresObservacionesEstados( string[] fieldList )
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
			
			if ( fl.Contains( "IdProveedorObservacionEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedorObservacionEstado", "IdProveedorObservacionEstado", true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" , 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.GetList().tpu_ProveedoresObservacionesEstados;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.Update( ( tpu_ProveedoresObservacionesEstadosDataset.tpu_ProveedoresObservacionesEstadosDataTable )dataTable );
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

		[ SearchMember( "tpu_ProveedoresObservacionesEstados" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProveedorObservacionEstado", IsAlternativePrimaryKey = true ) ] string IdProveedorObservacionEstado, 
			[ SearchParameterInfo( "Descripcion" , IsDescription = true ) ] string Descripcion, 
			[ SearchParameterInfo( "Activo" ) ] bool Activo

			)
		{
			tpu_ProveedoresObservacionesEstadosDataset data = mz.erp.businessrules.tpu_ProveedoresObservacionesEstados.GetList( IdProveedorObservacionEstado, Descripcion, Activo);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
	}
}
