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

	public class sy_Validaciones : IDisposable
	{
		public sy_Validaciones()
		{
		}

		public sy_Validaciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdValidacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValidacion", "IdValidacion" ) );
			if ( fl.Contains( "IdProceso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProceso", "IdProceso" ) );
			if ( fl.Contains( "IdTarea" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTarea", "IdTarea" ) );
			if ( fl.Contains( "Formulario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Formulario", "Formulario" ) );
			if ( fl.Contains( "Validacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Validacion", "Validacion" ) );
			if ( fl.Contains( "Titulo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Titulo", "Titulo" ) );
			if ( fl.Contains( "Mensaje" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mensaje", "Mensaje" ) );
			if ( fl.Contains( "TipoMensaje" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoMensaje", "TipoMensaje" ) );
			if ( fl.Contains( "Perfiles" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Perfiles", "Perfiles" ) );
			if ( fl.Contains( "Botones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Botones", "Botones" ) );
			if ( fl.Contains( "FechaInicio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaInicio", "FechaInicio" ) );
			if ( fl.Contains( "FechaFin" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaFin", "FechaFin" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", "CampoAuxiliar1" ) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", "CampoAuxiliar2" ) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", "CampoAuxiliar3" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Validaciones.GetList().sy_Validaciones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Validaciones.Update( ( sy_ValidacionesDataset.sy_ValidacionesDataTable )dataTable );
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

		/*[ SearchMember( "sy_Validaciones" ) ]
		public static DataSet GetList(  )
		{
			sy_ValidacionesDataset data = mz.erp.businessrules.sy_Validaciones.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}

