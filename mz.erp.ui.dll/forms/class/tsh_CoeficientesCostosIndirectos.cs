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
	/// <summary>
	/// Descripción breve de tsh_CoeficientesCostosIndirectos.
	/// </summary>
	public class tsh_CoeficientesCostosIndirectos : IDisposable, IGridDocument
	{
		public tsh_CoeficientesCostosIndirectos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public tsh_CoeficientesCostosIndirectos( string[] fieldList )
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
			
			if ( fl.Contains( "IdCoeficienteCostoIndirecto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCoeficienteCostoIndirecto", "IdCoeficienteCostoIndirecto" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "Tipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo", "Tipo" ) );
			if ( fl.Contains( "DescripcionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMoneda", "DescripcionMoneda" ) );
			if ( fl.Contains( "DescripcionFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionFuenteDeCambio", "DescripcionFuenteDeCambio" ) );
			if ( fl.Contains( "Orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Orden", "Orden" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" ) );
			
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutEx(string[] aMostrar)
		{
			string[] _fieldList = aMostrar;
			
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCoeficienteCostoIndirecto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCoeficienteCostoIndirecto", "IdCoeficienteCostoIndirecto", 50 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 170 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor", 60 ) );
            if (fl.Contains("Tipo") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Tipo", "Tipo Moneda", 85, Types.ColumnTypes.CheckBox)); //Matias 20100720 - Tarea 78 (cambio de titulo y tam).
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda" ) );
			if ( fl.Contains( "IdFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFuenteDeCambio", "IdFuenteDeCambio" ) );
			if ( fl.Contains( "DescripcionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMoneda", "Moneda", 100 ) );
			if ( fl.Contains( "DescripcionFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionFuenteDeCambio", "Fuente De Cambio", 120 ) );
			if ( fl.Contains( "Orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Orden", "Orden", 50 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50, Types.ColumnTypes.CheckBox ) );
			
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		/*public static string GetLayoutAbmCuentasCondicionesDeVenta()
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

		}*/

		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_CoeficientesCostosIndirectos.GetList().tsh_CoeficientesCostosIndirectos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_CoeficientesCostosIndirectos.Update( ( tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosDataTable )dataTable );
			//mz.erp.businessrules.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.Update( ( tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataset.tsa_CuentasCondicionesDeVenta_TDCompTesoreriaDataTable )dataTable );
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
