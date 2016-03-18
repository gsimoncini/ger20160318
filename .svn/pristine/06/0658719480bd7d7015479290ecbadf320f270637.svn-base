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

	public class tfi_Cajas : IDisposable, IGridDocument
	{
		public tfi_Cajas()
		{
		}

		public tfi_Cajas( string[] fieldList )
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
			
			if ( fl.Contains( "IdCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCaja", "Nº de Caja",100 ) );
			/*if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );*/
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",250 ) );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );*/
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string GetLayoutApertura()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCaja", "Caja Nº",100 ) );
			/*if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );*/
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción de caja",250 ) );
			if ( fl.Contains( "IdInstancaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "instancia",true) );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );*/
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",200) );			
			if ( fl.Contains( "Apertura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Apertura", "Apertura",150 ) );
			if ( fl.Contains( "Cierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cierre", "Cierre",150, true ) );			
			if ( fl.Contains( "Con Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Con Saldo", "Posee Valores?",100) );			
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		[ValueListGridMember]
		
		public DataTable GetList()
		{
			DataTable table =  mz.erp.businessrules.tfi_Cajas.GetList().tfi_Cajas;
			string PerfilesSuperiores = mz.erp.businessrules.Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
			string IdCajaTemporalDefault = mz.erp.businessrules.Variables.GetValueString("Cajas.CajaTemporalDefault");
			string CajasPerfilesSuperiores = mz.erp.businessrules.Variables.GetValueString("Cajas.CajasPerfilesSuperiores");
			ArrayList CajasPerfilesSuperioresList = mz.erp.systemframework.Util.Parse(CajasPerfilesSuperiores);
			ArrayList PerfilesSuperioresList = mz.erp.systemframework.Util.Parse(PerfilesSuperiores);
			ArrayList aux = new ArrayList();
			if(!PerfilesSuperioresList.Contains(mz.erp.businessrules.Security.IdPerfil.ToString()))
			{
				foreach(DataRow row in table.Rows)
				{
					if(Convert.ToString(row["IdCaja"]).Equals(IdCajaTemporalDefault)
						|| CajasPerfilesSuperioresList.Contains(Convert.ToString(row["IdCaja"])))
					{
						aux.Add(row);
						
					}
				}
				foreach(DataRow rowAux in aux)
				{
					table.Rows.Remove(rowAux);
				}
			}
			return table;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_Cajas.Update( ( tfi_CajasDataset.tfi_CajasDataTable )dataTable );
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

		[ SearchMember( "tfi_Cajas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCaja" ) ] string IdCaja, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion
			)
		{
			tfi_CajasDataset data = mz.erp.businessrules.tfi_Cajas.GetList( IdCaja, Descripcion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}

