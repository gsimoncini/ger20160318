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
	

	public class tsy_TiposMovimientos : IDisposable
	{
		public tsy_TiposMovimientos()
		{
		}

		public tsy_TiposMovimientos( string[] fieldList )
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
		
			if ( fl.Contains( "KeyTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeyTipo", "KeyTipo", true) );
			if ( fl.Contains( "DescripcionTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionTipo", "Tipo de movimiento",250 ) );
			if ( fl.Contains( "KeySubTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "KeySubTipo", "KeySubTipo", true) );
			if ( fl.Contains( "DescripcionSubTipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionSubTipo", "Subtipo de movimiento",250 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
	
		/*public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_Cuentas.GetList().tsa_Cuentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Cuentas.Update( ( tsa_CuentasDataset.tsa_CuentasDataTable )dataTable );
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

		/*[ SearchMember( "tsa_Cuentas", Caption ="Cuentas" ) ]
		public static DataSet GetList([ SearchParameterInfo( "Nombre", IsDescription = true ) ] string Nombre, 
			[ SearchParameterInfo( "Codigo", IsAlternativePrimaryKey = true) ] string Codigo, 
			[ SearchParameterInfo( "Domicilio" ) ] string Domicilio, 
			[ SearchParameterInfo( "Tipo de Documento" ) ] string idTipoDocumento, 
			[ SearchParameterInfo( "Numero de Documento" ) ] string Documento, 
			[ SearchParameterInfo( "Titular " ) ] string IdTitular,
			[ SearchParameterInfo( "Activo " ) ]  bool Activo

			)
		{
			
			tsa_CuentasDataset data;
			if(Variables.GetValueBool("Cuentas.Busquedas.BusquedaParcial"))
				data = mz.erp.businessrules.tsa_Cuentas.GetList( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, Activo);
			else

				data = mz.erp.businessrules.tsa_Cuentas.GetListEx( Codigo, Nombre, Domicilio, idTipoDocumento, Documento, IdTitular, Activo);

			return ( DataSet )data;
		}*/



		
		
		public void Dispose()
		{
		}
		
	}
}

