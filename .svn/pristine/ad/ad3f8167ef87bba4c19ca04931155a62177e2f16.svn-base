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

	public class tfi_ValoresDatosAuxiliares : IDisposable, IGridDocument
	{
		public tfi_ValoresDatosAuxiliares()
		{
		}

		public tfi_ValoresDatosAuxiliares( string[] fieldList )
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

			if ( fl.Contains( "IdValor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor" ) );
			if ( fl.Contains( "CODIGO_AUT_TC_TD_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CODIGO_AUT_TC_TD_TCCUO", "CODIGO_AUT_TC_TD_TCCUO_" ) );
			if ( fl.Contains( "CUPON_TC_TD_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CUPON_TC_TD_TCCUO", "CUPON_TC_TD_TCCUO_" ) );
			if ( fl.Contains( "FECHA_ACREDIT_TC_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FECHA_ACREDIT_TC_TCCUO", "FECHA_ACREDIT_TC_TCCUO_" ) );
			if ( fl.Contains( "FECHA_AUT_TC_TD_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FECHA_AUT_TC_TD_TCCUO", "FECHA_AUT_TC_TD_TCCUO_" ) );
			if ( fl.Contains( "LOTE_TC_TD_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "LOTE_TC_TD_TCCUO", "LOTE_TC_TD_TCCUO_" ) );
			if ( fl.Contains( "CANTIDAD_CUOTAS_TCCUO_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CANTIDAD_CUOTAS_TCCUO", "CANTIDAD_CUOTAS_TCCUO_" ) );
			if ( fl.Contains( "CTA_BANCARIA_CHE_T_C_DT_D_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CTA_BANCARIA_CHE_T_C_DT_D", "CTA_BANCARIA_CHE_T_C_DT_D_" ) );
			if ( fl.Contains( "LIBRADOR_CHE_T_DT_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "LIBRADOR_CHE_T_DT", "LIBRADOR_CHE_T_DT_" ) );
			if ( fl.Contains( "SUCURSAL_CHE_T_C_DT_D_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SUCURSAL_CHE_T_C_DT_D", "SUCURSAL_CHE_T_C_DT_D_" ) );
			if ( fl.Contains( "FECHA_PAGO_CHE_T_DT_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FECHA_PAGO_CHE_T_DT", "FECHA_PAGO_CHE_T_DT_" ) );
			if ( fl.Contains( "FECHA_RECEP_CHE_T_C_DT_D_" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FECHA_RECEP_CHE_T_C_DT_D", "FECHA_RECEP_CHE_T_C_DT_D_" ) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_ValoresDatosAuxiliares.GetList().tfi_ValoresDatosAuxiliares;
		}

		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_ValoresDatosAuxiliares.Update( ( tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresDataTable )dataTable );
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
/*
		[ SearchMember( "tfi_ValoresDatosAuxiliares" ) ]
		public static DataSet GetList( )
		{
			tfi_ValoresDatosAuxiliaresDataset data = mz.erp.businessrules.tfi_ValoresDatosAuxiliares.GetList( );
			return ( DataSet )data;
		}
*/
		public void Dispose()
		{
		}

	}
}