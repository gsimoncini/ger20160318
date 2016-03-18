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

	public class tsa_BonificacionesDet : IDisposable, IGridDocument
	{
		public tsa_BonificacionesDet()
		{
		}

		public tsa_BonificacionesDet( string[] fieldList )
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
			
			if ( fl.Contains( "IdBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "IdBonificacion" ,true) );
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal",true ) );
			if ( fl.Contains( "Minimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Minimo", "Minimo" ) );
			if ( fl.Contains( "Maximo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Maximo", "Maximo" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ,true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdCoexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado", true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_BonificacionesDet.GetList().tsa_BonificacionesDet;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_BonificacionesDet.Update( ( tsa_BonificacionesDetDataset.tsa_BonificacionesDetDataTable )dataTable );
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

		[ SearchMember( "tsa_BonificacionesDet" ) ]
		public static DataSet GetList( string IdBonificacion, decimal Valor )
		{
			tsa_BonificacionesDetDataset data = mz.erp.businessrules.tsa_BonificacionesDet.GetList(IdBonificacion , Valor  );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}


        //German 20120208 - Tarea 0000276
        public string GetLayoutBuscadorProductos()
        {
            ArrayList fl = new ArrayList();
            if (_fieldList != null)
            {
                fl.AddRange(_fieldList);
            }

            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(LayoutBuilder.GetHeader());

            if (fl.Contains("IdBonificacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdBonificacion", "IdBonificacion", true));
            if (fl.Contains("Ordinal") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Ordinal", "Ordinal", true));
            if (fl.Contains("Minimo") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Minimo", "Cant. Min", 75, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("Maximo") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Maximo", "Cant. Max", 75, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("Valor") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "Valor", "% Bonif.", 75, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("PrecioFinal") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioFinal", "Precio", 125, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("MontoBonificacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "MontoBonificacion", "Bonificación", 125, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("PrecioFinalBonificacionesAplicadas") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "PrecioFinalBonificacionesAplicadas", "Precio Con Bonif.", 150, Types.Aligment.Far, Types.FormatDisplay.Money));
            if (fl.Contains("FechaCreacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "FechaCreacion", "FechaCreacion", true));
            if (fl.Contains("IdConexionCreacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdConexionCreacion", "IdConexionCreacion", true));
            if (fl.Contains("UltimaModificacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "UltimaModificacion", "UltimaModificacion", true));
            if (fl.Contains("IdConexionUltimaModificacion") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdConexionUltimaModificacion", "IdCoexionUltimaModificacion", true));
            if (fl.Contains("IdReservado") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "IdReservado", "IdReservado", true));
            if (fl.Contains("RowId") || _fieldList == null) sb.Append(LayoutBuilder.GetRow(i++, "RowId", "RowId", true));

            sb.Append(LayoutBuilder.GetFooter());

            return sb.ToString();

        }


        //German 20120208 - Tarea 0000276
	}
}

