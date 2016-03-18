namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	



	public class tsh_JerarquiaAgrupProd : IDisposable, IGridDocument
	{
		public tsh_JerarquiaAgrupProd()
		{
		}
		
		public tsh_JerarquiaAgrupProd( string[] fieldList )
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
			
			if ( fl.Contains( "IdNomenclatura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdNomenclatura", "IdNomenclatura", true) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Nivel" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nivel", "Nivel" ) );
			if ( fl.Contains( "IdPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPadre", "IdPadre" ) );
			if ( fl.Contains( "Jerarquia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquia" ) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "IdTipoProducto" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		/*public static tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetByPk( string IdNomenclatura )
		{
			return GetByPk( ( string )IdNomenclatura );
		}*/

		public static DataTable GetList(Char IdTipoProducto) 
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(IdTipoProducto, true).tsh_JerarquiaAgrupProd;
		}

		public static DataTable GetList(string IdPadre) 
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(IdPadre, false).tsh_JerarquiaAgrupProd;
		}

		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList().tsh_JerarquiaAgrupProd;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_JerarquiaAgrupProd.Update( ( tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable )dataTable );
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

/*		[ SearchMember( "tsh_JerarquiaAgrupProd" ) ]
		public static DataSet GetList(  )
		{
			tsh_JerarquiaAgrupProdDataset data = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(  );
			return ( DataSet )data;
		}*/


		private static void BorraHijos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{														
			/// <summary>
			/// Limpia el árbol a partir del NodoPadre
			/// </summary>

			int hijos = NodoPadre.GetNodeCount(false);			
			for (int i=0; i < hijos; i++) {NodoPadre.Nodes[0].Remove();}
		}
		
		
		[ mz.erp.commontypes.TreeByDemandAttribute ]					
		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{			
			/// <summary>
			/// Genera un datatable de acuerdo a todos los hijos que posee el NodoPadre. De cada unos de ellos genera otro datatable para ver sus hijos. Con esta información regenera todo la rama a partir del NodoPadre			
			/// </summary>
			
			
			if (NodoPadre.HasNodes)
			{
				BorraHijos(NodoPadre);
			}			
				
			Infragistics.Win.UltraWinTree.UltraTreeNode NodoHijo;
			string descripcionH = String.Empty;
			string claveH = String.Empty;
			string descripcionN = String.Empty;
			string claveN = String.Empty;

			System.Data.DataTable data;

			if (NodoPadre.Key == "RAIZ") 
			{data = mz.erp.ui.controllers.tsh_JerarquiaAgrupProd.GetList(char.MinValue);}
			else
			{data = mz.erp.ui.controllers.tsh_JerarquiaAgrupProd.GetList(NodoPadre.Key);}
			
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				NodoPadre.Nodes.Add(claveH, descripcionH);
				
				System.Data.DataTable dataH = mz.erp.ui.controllers.tsh_JerarquiaAgrupProd.GetList(claveH);
				foreach (System.Data.DataRow rowN in dataH.Rows) 
				{
					descripcionN = rowN["Descripcion"].ToString();
					claveN = rowN["IdNomenclatura"].ToString();
					NodoHijo = NodoPadre.Nodes[claveH];
					NodoHijo.Nodes.Add(claveN, descripcionN);
				}
			}			
		}
		
		public void Dispose()
		{
		}
		
	}
}

