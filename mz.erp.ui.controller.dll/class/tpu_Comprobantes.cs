using System;

namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tpu_Comprobantes : IDisposable
	{
		public tpu_Comprobantes()
		{
		}

		public tpu_Comprobantes( string[] fieldList )
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
			
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja" ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante" ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número" ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha" ) );
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor" ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable" ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total" ) );
			if ( fl.Contains( "TotalConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TotalConImpuestos", "TotalConImpuestos" ) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre" ) );
			if ( fl.Contains( "IdCotizacionCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionCierre", "IdCotizacionCierre" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_Comprobantes.GetList().tpu_Comprobantes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_Comprobantes.Update( ( tpu_ComprobantesDataset.tpu_ComprobantesDataTable )dataTable );
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

		/*[ SearchMember( "tpu_Comprobantes" ) ]
		public static DataSet GetList(  )
		{
			tpu_ComprobantesDataset data = mz.erp.businessrules.tpu_Comprobantes.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		

		public string GetLayoutItemComprobanteDeCompraView()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Selected" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Selected", "", 20, false, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante", true) );
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante", 100, Types.EditType.NoEdit) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante", 50,Types.EditType.NoEdit ) );
			if ( fl.Contains( "IdCuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuentaImputacion", "IdCuentaImputacion", true ) );
			if ( fl.Contains( "IdSubCuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSubCuentaImputacion", "IdSubCuentaImputacion", true ) );
			if ( fl.Contains( "CuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CuentaImputacion", "Cuenta", 100, Types.EditType.NoEdit ) );
			if ( fl.Contains( "SubCuentaImputacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubCuentaImputacion", "Subcuenta", 100 , Types.EditType.NoEdit) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número", 75 , Types.EditType.NoEdit) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "FechaVencimiento", 75 , Types.EditType.NoEdit) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha", 75 , Types.EditType.NoEdit) );
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor", true ) );
			if ( fl.Contains( "Proveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor", 100 , Types.EditType.NoEdit) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable", true ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total", 50 , Types.EditType.NoEdit) );
			if ( fl.Contains( "Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Saldo", "Saldo", 50 , Types.EditType.NoEdit) );
			if ( fl.Contains( "PagoEfectivo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PagoEfectivo", "Efectivo", 50 , Types.Aligment.Far, Types.FormatDisplay.Money, Types.EditType.NoEdit) );
			if ( fl.Contains( "PagoChequePropio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PagoChequePropio", "Cheque Propio", 100 , Types.Aligment.Far, Types.FormatDisplay.Money, Types.EditType.NoEdit) );
			if ( fl.Contains( "PagoChequeTercero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PagoChequeTercero", "Cheque Tercero", 100 , Types.Aligment.Far, Types.FormatDisplay.Money, Types.EditType.NoEdit) );
			if ( fl.Contains( "PagoTransferenciaBancaria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PagoTransferenciaBancaria", "Transf. Bancaria", 100 , Types.Aligment.Far, Types.FormatDisplay.Money, Types.EditType.NoEdit) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
	}
}
