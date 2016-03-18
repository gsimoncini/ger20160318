namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tpu_Proveedores : IDisposable, IGridDocument
	{
		public tpu_Proveedores()
		{
		}

		public tpu_Proveedores( string[] fieldList )
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
			
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre", 300) );
			if ( fl.Contains( "IdTitular" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTitular", "Titular", true ) );
			if ( fl.Contains( "IdCategoriaIva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCategoriaIva", "Categoria de Iva", true) );
			if ( fl.Contains( "idTipoDocumento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "idTipoDocumento", "Tipo de Documento", true ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha de Creacion", "Fecha de Creacion", true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "Ultima Modificacion",true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Empresa", true ) );
			if ( fl.Contains( "Domicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",150 ) );
			if ( fl.Contains( "HorarioComercial" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "HorarioComercial", "Horario Comercial", true ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", true ) );
			if ( fl.Contains( "Telefonos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Teléfonos",200 ) );
			if ( fl.Contains( "Email" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",200 ) );
			if ( fl.Contains( "InstantMessenger" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InstantMessenger", "InstantMessenger", true ) );
			if ( fl.Contains( "Web" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Web", "Web",true ) );
			if ( fl.Contains( "BonificacionGeneral" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "BonificacionGeneral", "Bonificación General",true ) );
			if ( fl.Contains( "IdLocalidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdLocalidad", "Localidad", true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal", true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_Proveedores.GetList().tpu_Proveedores;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_Proveedores.Update( ( tpu_ProveedoresDataset.tpu_ProveedoresDataTable )dataTable );
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

		[ SearchMember( "tpu_Proveedores" , OrderUIAvailable = true) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProveedor" ,IsAlternativePrimaryKey= true, OrderUI = 2) ] string IdProveedor, 
			[ SearchParameterInfo( "Nombre",IsDescription= true , OrderUI = 1) ] string Nombre
			/*[ SearchParameterInfo( "IdTitular" ) ] string IdTitular, 
			[ SearchParameterInfo( "IdLocalidad" ) ] string IdLocalidad*/
			)
		{
			tpu_ProveedoresDataset data = mz.erp.businessrules.tpu_Proveedores.GetList( IdProveedor, Nombre, null, null );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

