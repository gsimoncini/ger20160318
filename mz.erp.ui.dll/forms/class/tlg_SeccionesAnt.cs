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

	public class tlg_Secciones : IDisposable, IGridDocument
	{
		public tlg_Secciones()
		{
		}

		public tlg_Secciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDeposito", "IdDeposito",150, true ) );
			if ( fl.Contains( "IdSeccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSeccion", "IdSeccion",150, false ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",250, false ) );
			if ( fl.Contains( "Ubicacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ubicacion", "Ubicacion",150 ) );
			/*if ( fl.Contains( "Comentario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentario", "Comentario",200 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ,true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tlg_Secciones.GetList().tlg_Secciones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_Secciones.Update( ( tlg_SeccionesDataset.tlg_SeccionesDataTable )dataTable );
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

		[ SearchMember( "tlg_Secciones" ) ]
		public static DataSet GetList( 
			[ SearchParameterInfo( "IdSeccion" ,IsAlternativePrimaryKey= true ) ] string IdSeccion, 
			/*[ SearchParameterInfo( "IdDeposito" ) ] string IdDeposito, */
			[ SearchParameterInfo( "Descripcion" , IsDescription= true ) ] string Descripcion, 
			[ SearchParameterInfo( "Ubicacion" ) ] string Ubicacion ,
			[ SearchParameterInfo( "Activo" ) ] bool Activo 
			/*[ SearchParameterInfo( "Comentario" ) ] string Comentario
			[ SearchParameterInfo( "Activo" ) ] long Activo, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId,
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa*/
			)
		{
			//tlg_SeccionesDataset data = mz.erp.businessrules.tlg_Secciones.GetList( IdSeccion, IdDeposito, Descripcion, Ubicacion, Comentario, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
			tlg_SeccionesDataset data = mz.erp.businessrules.tlg_Secciones.GetList( IdSeccion, Descripcion, Ubicacion,Activo);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

