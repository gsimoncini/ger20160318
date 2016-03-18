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

	public class tsy_TiposDeRetenciones : IDisposable, IGridDocument
	{
		public tsy_TiposDeRetenciones()
		{
		}

		public tsy_TiposDeRetenciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoDeRetencion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeRetencion", "IdTipoDeRetencion" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			if ( fl.Contains( "Formula" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Formula", "Formula" ) );
			if ( fl.Contains( "Auxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Auxiliar1", "Auxiliar1" ) );
			if ( fl.Contains( "Auxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Auxiliar2", "Auxiliar2" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		[ValueListGridMember]
		public DataTable GetListAmpliado()
		{
			System.Data.DataTable table = mz.erp.businessrules.tsy_TiposDeRetenciones.GetList().tsy_TiposDeRetenciones;
			System.Data.DataRow row = table.NewRow();
			row["IdTipoDeRetencion"] = string.Empty;
			row["Activo"] = 1;
			row["Descripcion"] = "Todas";
			table.Rows.Add(row);
			return table;
		}

		public DataTable GetList()
		{
			return mz.erp.businessrules.tsy_TiposDeRetenciones.GetList().tsy_TiposDeRetenciones;
		}

		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_TiposDeRetenciones.Update( ( tsy_TiposDeRetencionesDataset.tsy_TiposDeRetencionesDataTable )dataTable );
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

		[ SearchMember( "tsy_TiposDeRetenciones" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTipoDeRetencion" ) ] string IdTipoDeRetencion, 
		[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
		[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
		[ SearchParameterInfo( "Activo" ) ] bool Activo, 
		[ SearchParameterInfo( "Formula" ) ] string Formula
			/*, 
		[ SearchParameterInfo( "Auxiliar1" ) ] string Auxiliar1, 
		[ SearchParameterInfo( "Auxiliar2" ) ] string Auxiliar2, 
		[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
		[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
		[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
		[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
		[ SearchParameterInfo( "RowId" ) ] Guid RowId*/
		)
		{
			tsy_TiposDeRetencionesDataset data = mz.erp.businessrules.tsy_TiposDeRetenciones.GetList(IdTipoDeRetencion,Descripcion, Sistema, Activo, Formula );
				//tsy_TiposDeRetenciones.GetList( IdTipoDeRetencion, Descripcion, Sistema, Activo, Formula, Auxiliar1, Auxiliar2, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
			return ( DataSet )data;
		}

		
		
		
		public void Dispose()
		{
		}
		
	}
}

