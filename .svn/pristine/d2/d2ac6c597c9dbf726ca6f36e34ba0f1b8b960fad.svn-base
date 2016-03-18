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
	/// <summary>
	/// Descripción breve de tpu_JerarquiaAgrupProveedores.
	/// </summary>
	public class tpu_JerarquiaAgrupProveedores : IDisposable, IGridDocument
	{
		public tpu_JerarquiaAgrupProveedores()
		{
		}

		public tpu_JerarquiaAgrupProveedores(string[] fieldList)
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
			
			if ( fl.Contains( "IdNomenclatura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdNomenclatura", "IdNomenclatura" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Nivel" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nivel", "Nivel" ) );
			if ( fl.Contains( "IdPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPadre", "IdPadre" ) );
			if ( fl.Contains( "Jerarquia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquia" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "OldIdNomenclatura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OldIdNomenclatura", "OldIdNomenclatura" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		public static commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow GetByPk( string IdNomenclatura )
		{
			return mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(IdNomenclatura);
		}

		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList().tpu_JerarquiaAgrupProveedores;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.Update( ( tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable )dataTable );
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

		[ SearchMember( "tpu_JerarquiaAgrupProveedores" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdNomenclatura" ) ] string IdNomenclatura, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "Nivel" ) ] long Nivel, 
			[ SearchParameterInfo( "IdPadre" ) ] string IdPadre, 
			[ SearchParameterInfo( "Jerarquia" ) ] string Jerarquia, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "OldIdNomenclatura" ) ] string OldIdNomenclatura,
			[ SearchParameterInfo( "Activo" ) ] bool Activo
			)
		{
			tpu_JerarquiaAgrupProveedoresDataset data = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList( IdNomenclatura, Descripcion, Nivel, IdPadre, Jerarquia, IdEmpresa, IdSucursal, OldIdNomenclatura, Activo );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}

		#region Jerarquias

		public static DataTable GetList(bool Activo)
		{
			return mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList(Activo).Tables[0];
		}

		public static commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable GetList(string IdPadre, bool Activo) 
		{
			return mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList(IdPadre, Activo).tpu_JerarquiaAgrupProveedores;
		}
        //Cristian Tarea 000069 20110907
        public static commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable GetListActivas(string IdPadre, bool Activo)
        {
            return mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetListActivas(IdPadre).tpu_JerarquiaAgrupProveedores;
        }
        //Fin Cristian
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
			{data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(false);}
			else
			{data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(NodoPadre.Key, false);}
			if(AllowMultipleSelect)
				NodoPadre.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				
				Infragistics.Win.UltraWinTree.UltraTreeNode node =  NodoPadre.Nodes.Add(claveH, descripcionH);
				if(AllowMultipleSelect)
					node.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;

				
				System.Data.DataTable dataH = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(claveH, false);
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
        //Cristian Tarea 000069 20110907
        public static void HijosYNietosActivos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
        {
            HijosYNietosActivos(NodoPadre, false, true);
        }
        //Fin Cristian

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

            System.Data.DataTable data = null;

			if (NodoPadre.Key == "RAIZ") 
			{data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(Activo);}
			else
                //Cristian Tarea 000069 20110907
                if(!Activo){
			     {data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(NodoPadre.Key, Activo);}
                }
                else {data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetListActivas(NodoPadre.Key, Activo); }
                //Fin Cristian Tarea 000069
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				
				Infragistics.Win.UltraWinTree.UltraTreeNode node =  NodoPadre.Nodes.Add(claveH, descripcionH);
				
				
				System.Data.DataTable dataH = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(claveH, Activo);
				foreach (System.Data.DataRow rowN in dataH.Rows) 
				{
					descripcionN = rowN["Descripcion"].ToString();
					claveN = rowN["IdNomenclatura"].ToString();
					NodoHijo = NodoPadre.Nodes[claveH];
					NodoHijo.Nodes.Add(claveN, descripcionN);
				}
			}			
		}
        public static void HijosYNietosActivos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre, bool AllowMultipleSelect, bool Activo)
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
            { data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(Activo); }
            else

            { data = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(NodoPadre.Key, Activo); }


            foreach (System.Data.DataRow rowH in data.Rows)
            {
                descripcionH = rowH["Descripcion"].ToString();
                claveH = rowH["IdNomenclatura"].ToString();

                Infragistics.Win.UltraWinTree.UltraTreeNode node = NodoPadre.Nodes.Add(claveH, descripcionH);


                System.Data.DataTable dataH = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(claveH, Activo);
                foreach (System.Data.DataRow rowN in dataH.Rows)
                {
                    descripcionN = rowN["Descripcion"].ToString();
                    claveN = rowN["IdNomenclatura"].ToString();
                    NodoHijo = NodoPadre.Nodes[claveH];
                    NodoHijo.Nodes.Add(claveN, descripcionN);
                }
            }
        }

		private static void BorraHijos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{														
			/// <summary>
			/// Limpia el árbol a partir del NodoPadre
			/// </summary>

			int hijos = NodoPadre.GetNodeCount(false);			
			for (int i=0; i < hijos; i++) {NodoPadre.Nodes[0].Remove();}
		}
		

		#endregion



	}
}
