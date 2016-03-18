namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.businessrules;
	/// <summary>
	/// Descripción breve de tpu_PorveedoresObservaciones.
	/// </summary>
	public class tpu_PorveedoresObservaciones: IDisposable
	{
		public tpu_PorveedoresObservaciones()
		{
		}

		public tpu_PorveedoresObservaciones( string[] fieldList )
		{
			_fieldList = fieldList;
		}

		[ atOrderBy ]
		public static string DefaultOrderBy
		{
			get
			{
				return "Nombre asc";
			}
		}

		[ atMethodLayoutData ]
		public string GetLayoutEx()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			if ( fl.Contains( "IdProveedorObservacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedorObservacion", "IdProveedorObservacion", true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Proveedor",150 ) );
			if ( fl.Contains( "Titulo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Titulo", "Título",280 ) );
			if ( fl.Contains( "Observacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observacion", "Observación", true) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",130 ) );
			if ( fl.Contains( "Usuario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",100 ) );			
			if ( fl.Contains( "Tipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo", "Tipo",!fl.Contains( "Tipo" )));
			if ( fl.Contains( "SubTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTipo", "SubTipo", !fl.Contains( "SubTipo" ) ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado", "Estado",!fl.Contains( "Estado" ) ) );
			if ( fl.Contains( "FechaAviso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaAviso", "Fecha Aviso",130 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha Venc.",130 ) );			
			
			
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

		[ SearchMember( "tpu_Proveedores", Caption ="Proveedores" ) ]
		public static DataSet GetList([ SearchParameterInfo( "Nombre", IsDescription = true ) ] string Nombre, 
			[ SearchParameterInfo( "Codigo", IsAlternativePrimaryKey = true) ] string Codigo, 
			[ SearchParameterInfo( "Domicilio" ) ] string Domicilio, 
			[ SearchParameterInfo( "Tipo de Documento" ) ] string idTipoDocumento, 
			[ SearchParameterInfo( "Numero de Documento" ) ] string Documento, 
			[ SearchParameterInfo( "Titular " ) ] string IdTitular,
			[ SearchParameterInfo( "Activo " ) ]  bool Activo

			)
		{
			tpu_ProveedoresDataset data = null;
			//TODO Sabri
			/*tpu_ProveedoresDataset data;
			
			/*if(Variables.GetValueBool("Proveedores.Busquedas.BusquedaParcial"))
				data = mz.erp.businessrules.tpu_Proveedores.GetList( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, Activo);
			else

				data = mz.erp.businessrules.tpu_Proveedores.GetListEx( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, Activo);
*/
			return ( DataSet )data;
		}



		
		
		public void Dispose()
		{
		}
		

	}
}
