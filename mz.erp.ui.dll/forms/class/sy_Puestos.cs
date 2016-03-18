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

	public class sy_Puestos : IDisposable, IGridDocument
	{
		public sy_Puestos()
		{
		}
		/*
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdPuesto""><Caption>IdPuesto</Caption><DataMember>IdPuesto</DataMember><Key>IdPuesto</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""IdHardware""><Caption>IdHardware</Caption><DataMember>IdHardware</DataMember><Key>IdHardware</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Ubicacion""><Caption>Ubicacion</Caption><DataMember>Ubicacion</DataMember><Key>Ubicacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""UsuarioSO""><Caption>UsuarioSO</Caption><DataMember>UsuarioSO</DataMember><Key>UsuarioSO</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""Activo""><Caption>Activo</Caption><DataMember>Activo</DataMember><Key>Activo</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>10</Position></Column10>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		*/
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
			
			if ( fl.Contains( "IdPuesto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPuesto", "IdPuesto", 75, Types.EditType.NoEdit)); //20, true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",200 ) );
			if ( fl.Contains( "IdHardware" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHardware", "IdHardware",200 ) );
			if ( fl.Contains( "Ubicacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ubicacion", "Ubicacion",200 ) );
			if ( fl.Contains( "UsuarioSO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UsuarioSO", "UsuarioSO",200 ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",75, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true) );
			//			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",!fl.Contains( "IdEmpresa" ) ) );
			//if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Porcentaje de Recargo",200 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Puestos.GetList().sy_Puestos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Puestos.Update( ( sy_PuestosDataset.sy_PuestosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

