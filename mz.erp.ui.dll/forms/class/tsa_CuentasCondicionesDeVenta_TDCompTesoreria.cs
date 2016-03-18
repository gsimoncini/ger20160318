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


	public class tsa_CuentasCondicionesDeVenta_TDCompTesoreria : IDisposable, IGridDocument
	{
		public tsa_CuentasCondicionesDeVenta_TDCompTesoreria()
		{
		}

		public tsa_CuentasCondicionesDeVenta_TDCompTesoreria( string[] fieldList )
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
			
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta" ) );
			if ( fl.Contains( "IdCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "IdCondicionDeVenta" ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "MetodoDeAsignacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MetodoDeAsignacion", "MetodoDeAsignacion" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public static string GetLayoutAbmCuentasCondicionesDeVenta()
		{
			string[] _fieldList = new string[] {"Descripcion","Valor"};
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			//if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta" , true));
			//if ( fl.Contains( "IdCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "IdCondicionDeVenta", false) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",250, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		/*		public string GetLayout()
				{
					ArrayList fl = new ArrayList();
					if ( _fieldList != null )
					{
						fl.AddRange( _fieldList );
					}

					int i = 0;
					StringBuilder sb = new StringBuilder();
					sb.Append( LayoutBuilder.GetHeader() );
			
					//if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta" , true));
					//if ( fl.Contains( "IdCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "IdCondicionDeVenta", false) );
					if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",250, Types.ColumnTypes.Text, Types.EditType.NoEdit) );
					if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",50,Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			
					sb.Append( LayoutBuilder.GetFooter() );

					return sb.ToString();
				}*/

		public DataTable GetList()
		{
			//return mz.erp.businessrules.tsa_cuenta
			return mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetList().tsa_CuentasCondicionesDeVenta_TDCompTesoreria;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Update( ( tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataTable )dataTable );
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

		/*[ SearchMember( "tsa_CuentasCondicionesDeVenta" ) ]
		public static DataSet GetList(  )
		{
			tsa_CuentasCondicionesDeVentaDataset data = mz.erp.businessrules.tsa_CuentasCondicionesDeVenta.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}

