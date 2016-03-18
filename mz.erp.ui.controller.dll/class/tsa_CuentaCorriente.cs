using System;
using System.Data;
using System.Text;
using System.Collections;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de tsa_CuentaCorriente.
	/// </summary>
	public class tsa_CuentaCorriente
	{
		public tsa_CuentaCorriente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public string GetLayoutDetalleCuentaCorriente()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			

			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			
			if ( fl.Contains( "FechaEmision" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaEmision", "Fecha de Emisión", true) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha de Vencimiento",125 ) );
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",100) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100) );
			if ( fl.Contains( "Cuota" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuota", "Cuota" ,45) );
			if ( fl.Contains( "Debe" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Debe", "Debe",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "Haber" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Haber", "Haber", 80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
            //Cristian Tarea 855
            if (fl.Contains("Importe") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Importe", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
            //Fin Tarea 855
            if ( fl.Contains( "SaldoSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoSinSigno", "Saldo",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "SaldoAcumuladoSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSinSigno", "Saldo Acumulado",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "SaldoAcumuladoSoloPendientesSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSoloPendientesSinSigno", "Saldo Acumulado",80 ,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			
			
			if ( fl.Contains( "Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Saldo", "Saldo",true ) );
			if ( fl.Contains( "SaldoAcumulado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumulado", "Saldo Acumulado",true) );
			if ( fl.Contains( "SaldoAcumuladoSoloPendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSoloPendientes", "Saldo Acumulado",true) );
			if ( fl.Contains( "Signo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Signo", "Signo",true ) );
			if ( fl.Contains( "SignoCtaCte" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SignoCtaCte", "SignoCtaCte",true ) );
			if ( fl.Contains( "Pago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Pago", "Pago",true ) );
			if ( fl.Contains( "FechaPago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaPago", "Fecha de Pago", true) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string GetLayoutDetalleCuentaCorriente(string[] _fieldList)
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			

			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			
			if ( fl.Contains( "FechaEmision" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaEmision", "Fecha de Emisión",140) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha de Vencimiento",140 ) );
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",100) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100) );
			if ( fl.Contains( "Cuota" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuota", "Cuota" ,40, Types.Aligment.Center) );
			if ( fl.Contains( "Debe" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Debe", "Debe",75 ) );
			if ( fl.Contains( "Haber" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Haber", "Haber", 75 ) );
            
            //Cristian Tarea 855
            if (fl.Contains("ImporteSinSigno") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "ImporteSinSigno", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("Importe") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Importe", "Importe", 80, Types.Aligment.Far, Types.FormatDisplay.Money));
            //Fin tarea 855

            if ( fl.Contains( "SaldoSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoSinSigno", "Saldo",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "SaldoAcumuladoSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSinSigno", "Saldo Acumulado",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "SaldoAcumuladoSoloPendientesSinSigno" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSoloPendientesSinSigno", "Saldo Acumulado",80 ,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			
			
			if ( fl.Contains( "Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Saldo", "Saldo",80,Types.Aligment.Far, Types.FormatDisplay.Money  ) );
			if ( fl.Contains( "SaldoAcumulado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumulado", "Saldo Acumulado",true) );
			if ( fl.Contains( "SaldoAcumuladoSoloPendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SaldoAcumuladoSoloPendientes", "Saldo Acumulado",true) );
			if ( fl.Contains( "Signo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Signo", "Signo",true ) );
			if ( fl.Contains( "SignoCtaCte" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SignoCtaCte", "SignoCtaCte",true ) );
			if ( fl.Contains( "Pago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Pago", "Pago",80,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "FechaPago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaPago", "Fecha de Pago", 150) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

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
	}
}
