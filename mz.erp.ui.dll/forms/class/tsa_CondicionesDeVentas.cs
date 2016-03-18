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

	public class tsa_CondicionesDeVentas : IDisposable, IGridDocument
	{
		public tsa_CondicionesDeVentas()
		{
		}

		public tsa_CondicionesDeVentas( string[] fieldList )
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
			
			if ( fl.Contains( "IdCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "Código")); //20, true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",200 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",100, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
//			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",!fl.Contains( "FechaCreacion" ) ) );
//			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",!fl.Contains( "IdConexionCreacion" ) ) );
//			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",!fl.Contains( "UltimaModificacion" ) ) );
//			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",!fl.Contains( "IdConexionUltimaModificacion" ) ) );
//			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",!fl.Contains( "IdReservado" ) ) );
//			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",!fl.Contains( "RowId" ) ) );
//			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",!fl.Contains( "IdEmpresa" ) ) );
			if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Porcentaje de Recargo",200 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_CondicionesDeVentas.GetList().tsa_CondicionesDeVentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_CondicionesDeVentas.Update( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable )dataTable );
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

		[ SearchMember( "tsa_CondicionesDeVentas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCondicionDeVenta", IsAlternativePrimaryKey=true ) ] string IdCondicionDeVenta, 
			[ SearchParameterInfo( "Descripcion", IsDescription= true ) ] string Descripcion , [ SearchParameterInfo( "Activo" ) ] bool Activo 
			)
		{
			tsa_CondicionesDeVentasDataset data = mz.erp.businessrules.tsa_CondicionesDeVentas.GetList( IdCondicionDeVenta, Descripcion, Activo );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

