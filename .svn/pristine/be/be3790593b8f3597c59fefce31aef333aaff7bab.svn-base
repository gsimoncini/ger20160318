namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tsa_CondicionesDeVentas : IDisposable, IGridDocument
	{
		public tsa_CondicionesDeVentas()
		{
		}

		public tsa_CondicionesDeVentas( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		public string GetCustomLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCondicionDeVenta" ) ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "IdCondicionDeVenta",!fl.Contains( "IdCondicionDeVenta" ) ) );
			if ( fl.Contains( "Descripcion" )  ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200 ) );
			if ( fl.Contains( "PorcentajeRecargo" )  ) sb.Append( LayoutBuilder.GetRow( i++, "PorcentajeRecargo", "%",50,Types.Aligment.Near,Types.FormatDisplay.Default ) );
			if ( fl.Contains( "Recargo" )  ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Recargo",50,Types.Aligment.Near,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "Importe" )  ) sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe",50,Types.Aligment.Near,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "Activo" ) ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",!fl.Contains( "Activo" ) ) );

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		[ atMethodLayoutData ]
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
			
			if ( fl.Contains( "IdCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCondicionDeVenta", "IdCondicionDeVenta",!fl.Contains( "IdCondicionDeVenta" ) ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",!fl.Contains( "Activo" ) ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_CondicionesDeVentas.GetList().tsa_CondicionesDeVentas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_CondicionesDeVentas.Update( ( tsa_CondicionesDeVentasDataset.tsa_CondicionesDeVentasDataTable )dataTable );
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

		[ SearchMember( "tsa_CondicionesDeVentas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCondicionDeVenta", IsAlternativePrimaryKey=true ) ] string IdCondicionDeVenta, 
			[ SearchParameterInfo( "Descripcion", IsDescription= true ) ] string Descripcion 
			)
		{
			tsa_CondicionesDeVentasDataset data = mz.erp.businessrules.tsa_CondicionesDeVentas.GetList( IdCondicionDeVenta, Descripcion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

