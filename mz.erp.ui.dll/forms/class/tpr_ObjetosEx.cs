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

	public class tpr_ObjetosEx : IDisposable, IGridDocument
	{
		#region Custom Members
		[ SearchMember( "Pr_tpr_Objetos_Search" ) ]
		public static DataSet GetListEx( [ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "NumeroDeSerie" ) ] string NumeroDeSerie
			)
		{
		    tpr_ObjetosExDataset data = mz.erp.businessrules.tpr_Objetos.GetListEx( IdProducto, Descripcion, NumeroDeSerie );
			return ( DataSet )data;
		}
		
		#endregion
		public tpr_ObjetosEx()
		{
		}

		public tpr_ObjetosEx( string[] fieldList )
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
			
			if ( fl.Contains( "IdObjeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdObjeto", "IdObjeto", true ) );
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true ) );
			if ( fl.Contains( "NumeroDeSerie" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Numero De Serie",100 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion Elemento",250 ) );
			if ( fl.Contains( "CodigoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoProducto", "C.Prod", 100 ) );
			if ( fl.Contains( "DescripcionProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionProducto", "Descripcion Producto", 250 ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones",true ) );
			if ( fl.Contains( "InformacionAdicional1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InformacionAdicional1", "InformacionAdicional1",true ) );
			if ( fl.Contains( "InformacionAdicional2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InformacionAdicional2", "InformacionAdicional2",true ) );
			if ( fl.Contains( "InformacionAdicional3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InformacionAdicional3", "InformacionAdicional3",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpr_Objetos.GetList().tpr_Objetos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpr_Objetos.Update( ( tpr_ObjetosDataset.tpr_ObjetosDataTable )dataTable );
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

		public void Dispose()
		{
		}
		
	}
}

