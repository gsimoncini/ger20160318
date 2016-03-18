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
	public class tsh_Autorizaciones : IDisposable//, IGridDocument
	{
		public tsh_Autorizaciones()
		{
		}

		public tsh_Autorizaciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdAutorizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdAutorizacion", "IdAutorizacion" ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable" ) );
			if ( fl.Contains( "Motivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Motivo", "Motivo" ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado" ) );
			if ( fl.Contains( "IdResponsableDeAutorizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsableDeAutorizacion", "IdResponsableDeAutorizacion" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutSolicitudes()
		{
			string[] _fieldList = new string[] {"IdAutorizacion","Usuario","Motivo","Datos","FechaCreacion","DescripcionEstado"};
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdAutorizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdAutorizacion", "IdAutorizacion", 11, true ) );
			if ( fl.Contains( "Motivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Motivo", "Motivo", 200, false) );
			if ( fl.Contains( "Datos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Datos", "Datos", 100, true) );
			if ( fl.Contains( "Usuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Usuario", "Usuario", 120, false ) );
			//if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado" ) );
			//if ( fl.Contains( "IdResponsableDeAutorizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsableDeAutorizacion", "IdResponsableDeAutorizacion" ) );
			//if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha creación", 180, false ) );
			if ( fl.Contains( "DescripcionEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEstado", "Estado", 180, false ) );
			/*if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );*/
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		
		/*public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Autorizaciones.GetList().tsh_Autorizaciones;
		}
		
		public void Update( object dataTable )
		{			
			mz.erp.businessrules.tsh_Autorizaciones.Update( ( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable )dataTable );
		}*/
		
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

		/*[ SearchMember( "tsh_Autorizaciones" ) ]
		public static DataSet GetList(  )
		{
			tsh_AutorizacionesDataset data = mz.erp.businessrules.tsh_Autorizaciones.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}

