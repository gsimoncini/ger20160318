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

	public class tui_ConfiguracionGrillasUsuarios : IDisposable, IGridDocument
	{
		public tui_ConfiguracionGrillasUsuarios()
		{
		}

		public tui_ConfiguracionGrillasUsuarios( string[] fieldList )
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
			
			if ( fl.Contains( "IdUsuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUsuario", "IdUsuario" ) );
			if ( fl.Contains( "IdProceso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProceso", "IdProceso" ) );
			if ( fl.Contains( "IdTarea" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTarea", "IdTarea" ) );
			if ( fl.Contains( "Grilla" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Grilla", "Grilla" ) );
			if ( fl.Contains( "Campo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Campo", "Campo" ) );
			if ( fl.Contains( "Propiedad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Propiedad", "Propiedad" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			if ( fl.Contains( "Comentario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentario", "Comentario" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList().tui_ConfiguracionGrillasUsuarios;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.Update( ( tui_ConfiguracionGrillasUsuariosDataset.tui_ConfiguracionGrillasUsuariosDataTable )dataTable );
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

		[ SearchMember( "tui_ConfiguracionGrillasUsuarios" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdUsuario" ) ] string IdUsuario, 
			[ SearchParameterInfo( "IdProceso" ) ] long IdProceso, 
			[ SearchParameterInfo( "IdTarea" ) ] long IdTarea, 
			[ SearchParameterInfo( "Grilla" ) ] string Grilla, 
			[ SearchParameterInfo( "Campo" ) ] string Campo, 
			[ SearchParameterInfo( "Propiedad" ) ] string Propiedad
			)
		{
			tui_ConfiguracionGrillasUsuariosDataset data = mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList( IdUsuario, IdProceso, IdTarea, Grilla, Campo, Propiedad, null );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

