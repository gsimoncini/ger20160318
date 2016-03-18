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

		public static DataTable GetList(Char IdTipoProducto, bool Activo) 
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(IdTipoProducto, Activo).tsh_JerarquiaAgrupProd;
		}

        //German 20120412 - Tarea 0000271
        public static DataTable GetListFiltrandoCampoAuxiliar6(Char IdTipoProducto, bool Activo)
        {
            return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetListFiltrandoCampoAuxiliar6(IdTipoProducto, Activo).tsh_JerarquiaAgrupProd;
        }

        //Fin German 20120412 - Tarea 0000271
		public static commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable GetList(string IdPadre, bool Activo) 
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(IdPadre, Activo).tsh_JerarquiaAgrupProd;
		}

		public static commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow GetByPk( string IdNomenclatura )
		{
			return mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(IdNomenclatura);
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
		
		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, string jerarquia)
		{
			int level = 1;
			HijosYNietos(NodoPadre, jerarquia, level);
		}

		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, string jerarquia, int level)
		{
			HijosYNietos(NodoPadre, false, true);
			if(level < (jerarquia.Length / 20))
			{
				level++;
				string sub = jerarquia.Substring(20*(level - 1), 20);
				Infragistics.Win.UltraWinTree.UltraTreeNode aux = NodoPadre.Nodes[sub];
				HijosYNietos(aux, jerarquia, level);
			}
		}

		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, bool AllowMultipleSelect)
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
			{data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(char.MinValue, false);}
			else
			{data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(NodoPadre.Key, false);}
						
			
            if(AllowMultipleSelect)
				NodoPadre.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
            
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				
				Infragistics.Win.UltraWinTree.UltraTreeNode node =  NodoPadre.Nodes.Add(claveH, descripcionH);
				
                if(AllowMultipleSelect)
					node.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
                

				
				System.Data.DataTable dataH = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(claveH, false);
				foreach (System.Data.DataRow rowN in dataH.Rows) 
				{
					descripcionN = rowN["Descripcion"].ToString();
					claveN = rowN["IdNomenclatura"].ToString();
					NodoHijo = NodoPadre.Nodes[claveH];
					node = NodoHijo.Nodes.Add(claveN, descripcionN);
                    if(AllowMultipleSelect)
						node.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
                     
				}
			}			
		}

		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{
			HijosYNietos(NodoPadre, false, false);			
		}

        //German 20120412 - Tarea 0000271
        public static void HijosYNietosFiltrandoCampoAuxiliar6(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, bool AllowMultipleSelect, bool Activo)
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
            { data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetListFiltrandoCampoAuxiliar6(char.MinValue, Activo); }
            else
            { data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(NodoPadre.Key, Activo); }


            foreach (System.Data.DataRow rowH in data.Rows)
            {
                descripcionH = rowH["Descripcion"].ToString();
                claveH = rowH["IdNomenclatura"].ToString();

                Infragistics.Win.UltraWinTree.UltraTreeNode node = NodoPadre.Nodes.Add(claveH, descripcionH);

                System.Data.DataTable dataH = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(claveH, Activo);
                foreach (System.Data.DataRow rowN in dataH.Rows)
                {
                    descripcionN = rowN["Descripcion"].ToString();
                    claveN = rowN["IdNomenclatura"].ToString();
                    NodoHijo = NodoPadre.Nodes[claveH];
                    NodoHijo.Nodes.Add(claveN, descripcionN);
                }
            }
        }
        //German 20120412 - Tarea 0000271

		[ mz.erp.commontypes.TreeByDemandAttribute ]					
		public static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, bool AllowMultipleSelect, bool Activo)
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
			{data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(char.MinValue, Activo);}
			else
			{data = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(NodoPadre.Key, Activo);}
			
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				
				Infragistics.Win.UltraWinTree.UltraTreeNode node =  NodoPadre.Nodes.Add(claveH, descripcionH);

				System.Data.DataTable dataH = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetList(claveH, Activo);
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

