using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de tfi_Recargos.
	/// </summary>
	public class tfi_Recargos
	{
		public tfi_Recargos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
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

		public string  GetLayout()
		{


			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			
			if ( fl.Contains( "Concepto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Concepto", "Concepto",250 ) );
			if ( fl.Contains( "ImporteAbonado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImporteAbonado", "Importe",75,Types.Aligment.Far,Types.FormatDisplay.Money) );
			if ( fl.Contains( "ImporteRecargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImporteRecargo", "Imp. Recgo",75,Types.Aligment.Far ,Types.FormatDisplay.Money) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Imp. Final" ,75,Types.Aligment.Far ,Types.FormatDisplay.Money));
			if ( fl.Contains( "PorcentajeRecargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PorcentajeRecargo", "% Rec",50, Types.Aligment.Far, Types.FormatDisplay.Percent) );
			if ( fl.Contains( "RecargosIncluidos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RecargosIncluidos", "Inc Rec",50, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
			
			/*
			if ( fl.Contains( "Concepto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Concepto", "Concepto",true ) );
			if ( fl.Contains( "ImporteAbonado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImporteAbonado", "Importe",75,Types.Aligment.Far,Types.FormatDisplay.Money) );
			if ( fl.Contains( "PorcentajeRecargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PorcentajeRecargo", "% Recargo",true) );
			if ( fl.Contains( "ImporteRecargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImporteRecargo", "Imp. Recgo",true) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Imp. Final" ,true));
			
			if ( fl.Contains( "RecargosIncluidos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RecargosIncluidos", "Incluye Recgos",100, Types.ColumnTypes.CheckBox) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

	}
}
