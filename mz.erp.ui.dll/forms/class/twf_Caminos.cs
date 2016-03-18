namespace mz.erp.ui
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;

	public class twf_Caminos : IDisposable, IGridDocument
	{
		public twf_Caminos()
		{
		}

		public twf_Caminos( string[] fieldList )
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
			
			if ( fl.Contains( "IdCamino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCamino", "IdCamino" ) );
			if ( fl.Contains( "IdTareaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTareaOrigen", "IdTareaOrigen" ) );
			if ( fl.Contains( "IdTareaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTareaDestino", "IdTareaDestino" ) );
			if ( fl.Contains( "IdProceso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProceso", "IdProceso" ) );
			if ( fl.Contains( "Power" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Power", "Power" ) );
			if ( fl.Contains( "Frecuencia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Frecuencia", "Frecuencia" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.twf_Caminos.GetList().twf_Caminos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.twf_Caminos.Update( ( twf_CaminosDataset.twf_CaminosDataTable )dataTable );
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

		[ SearchMember( "twf_Caminos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCamino" ) ] long IdCamino, 
			[ SearchParameterInfo( "IdTareaOrigen" ) ] long IdTareaOrigen, 
			[ SearchParameterInfo( "IdTareaDestino" ) ] long IdTareaDestino, 
			[ SearchParameterInfo( "Power" ) ] short Power, 
			[ SearchParameterInfo( "Frecuencia" ) ] short Frecuencia, 
			[ SearchParameterInfo( "IdConexion" ) ] long IdConexion, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "Observaciones" ) ] string Observaciones
			)
		{
			twf_CaminosDataset data = mz.erp.businessrules.twf_Caminos.GetList( IdCamino, IdTareaOrigen, IdTareaDestino, Power, Frecuencia, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


