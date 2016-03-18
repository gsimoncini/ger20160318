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

	public class tlg_Depositos : IDisposable, IGridDocument
	{
		public tlg_Depositos()
		{
		}

		public tlg_Depositos( string[] fieldList )
		{
			_fieldList = fieldList;
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
			
			if ( fl.Contains( "IdDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDeposito", "IdDeposito",150) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",250 ) );
			if ( fl.Contains( "Ubicacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ubicacion", "Ubicacion",150 ) );
			if ( fl.Contains( "Comentario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentario", "Comentario",250 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		[ValueListGridMember]
		public DataTable GetList()
		{
			return mz.erp.businessrules.tlg_Depositos.GetList().tlg_Depositos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_Depositos.Update( ( tlg_DepositosDataset.tlg_DepositosDataTable )dataTable );
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

		[ SearchMember( "tlg_Depositos" ) ]
		public static DataSet GetList(
			[ SearchParameterInfo( "IdDeposito",IsAlternativePrimaryKey = true ) ] string IdDeposito, 
			[ SearchParameterInfo( "Descripcion", IsDescription = true ) ] string Descripcion, 
			[ SearchParameterInfo( "Ubicacion" ) ] string Ubicacion,
			[ SearchParameterInfo( "Activo" ) ] bool Activo
			/*
			[ SearchParameterInfo( "Comentario" ) ] string Comentario, 
			[ SearchParameterInfo( "Activo" ) ] long Activo,
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa*/
			)
		{
			tlg_DepositosDataset data = mz.erp.businessrules.tlg_Depositos.GetList( IdDeposito, Descripcion, Ubicacion,Activo);
			//tlg_DepositosDataset data = mz.erp.businessrules.tlg_Depositos.GetList( IdDeposito, Descripcion, Ubicacion, Comentario, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
			return ( DataSet )data;
		}
		
		public void DeletingRowValidate( DataRow row )
		{
		}
		
		public void Dispose()
		{
		}
		
	}
}

