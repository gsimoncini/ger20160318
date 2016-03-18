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
	

	public class tsa_Cuentas : IDisposable, IGridDocument
	{
		public tsa_Cuentas()
		{
		}

		public tsa_Cuentas( string[] fieldList )
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
		public string GetLayout()
		{
			String EtiqCampoAux1 = Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta");
			String EtiqCampoAux2 = Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta");
			String EtiqCampoAux3 = Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta");
			
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta",!fl.Contains( "IdCuenta" ) ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",90 ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",300 ) );
			if ( fl.Contains( "Domicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Domicilio", "Domicilio",100 ) );
			if ( fl.Contains( "HorarioComercial" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "HorarioComercial", "HorarioComercial",!fl.Contains( "HorarioComercial" ) ) );
			if ( fl.Contains( "idTipoDocumento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "idTipoDocumento", "idTipoDocumento",!fl.Contains( "idTipoDocumento" ) ) );
			if ( fl.Contains( "Documento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Documento", "Documento", !fl.Contains( "Documento" ) ) );
			if ( fl.Contains( "IdCategoriaIva" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCategoriaIva", "IdCategoriaIva",!fl.Contains( "IdCategoriaIva") ) );
			if ( fl.Contains( "Telefono" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefono", "Telefono",150 ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", EtiqCampoAux1,true) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", EtiqCampoAux2,!fl.Contains( "CampoAuxiliar2") ) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", EtiqCampoAux3,!fl.Contains( "CampoAuxiliar3") ) );
			if ( fl.Contains( "IdTitular" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTitular", "IdTitular",!fl.Contains( "IdTitular") ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones",!fl.Contains( "Observaciones") ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",!fl.Contains( "Activo") ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",!fl.Contains( "FechaCreacion") ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",!fl.Contains( "IdConexionCreacion") ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",!fl.Contains( "UltimaModificacion") ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",!fl.Contains( "IdConexionUltimaModificacion") ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",!fl.Contains( "IdReservado") ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",!fl.Contains( "RowId") ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",!fl.Contains( "IdSucursal") ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",!fl.Contains( "IdEmpresa") ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
	
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_Cuentas.GetList().tsa_Cuentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Cuentas.Update( ( tsa_CuentasDataset.tsa_CuentasDataTable )dataTable );
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

		[ SearchMember( "tsa_Cuentas", Caption ="Cuentas" ) ]
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
		}



		
		
		public void Dispose()
		{
		}
		
	}
}

