using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.controls;
	using mz.erp.ui.controllers;


namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de sy_JerarquiaAgrupVariables.
	/// </summary>
	public class sy_JerarquiaAgrupVariables: IDisposable , IGridDocument
	{
		public sy_JerarquiaAgrupVariables()
		{
		}

		public sy_JerarquiaAgrupVariables( string[] fieldList )
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


		
			if ( fl.Contains( "Id" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Nivel" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nivel", "Nivel" ) );
			if ( fl.Contains( "IdPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPadre", "IdPadre" ) );
			if ( fl.Contains( "Jerarquia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Jerarquia", "Jerarquia" ) );
			/*if ( fl.Contains( "IdVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariable", "IdVariable" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		
		public static DataTable GetList(string IdPadre) 
		{
			return mz.erp.businessrules.sy_JerarquiaAgrupVariables.GetList(IdPadre).sy_JerarquiaAgrupVariables;
		}
	

		public static DataTable GetList(Char Str) 
		{
			return mz.erp.businessrules.sy_JerarquiaAgrupVariables.GetList(Str).sy_JerarquiaAgrupVariables;
		}

		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_JerarquiaAgrupVariables.GetList().sy_JerarquiaAgrupVariables;
		}

		private static void BorraHijos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{														
			/// <summary>
			/// Limpia el árbol a partir del NodoPadre
			/// </summary>

			int hijos = NodoPadre.GetNodeCount(false);			
			for (int i=0; i < hijos; i++) {NodoPadre.Nodes[0].Remove();}
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_JerarquiaAgrupVariables.Update( ( sy_JerarquiaAgrupVariablesDataset.sy_JerarquiaAgrupVariablesDataTable )dataTable );
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
			{data = mz.erp.ui.forms.classes.sy_JerarquiaAgrupVariables.GetList(char.MinValue);}
			else
			{data = mz.erp.ui.forms.classes.sy_JerarquiaAgrupVariables.GetList(NodoPadre.Key);}
			
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				NodoPadre.Nodes.Add(claveH, descripcionH);
				
				System.Data.DataTable dataH = mz.erp.ui.forms.classes.sy_JerarquiaAgrupVariables.GetList(claveH);
				foreach (System.Data.DataRow rowN in dataH.Rows) 
				{
					descripcionN = rowN["Descripcion"].ToString();
					claveN = rowN["Id"].ToString();
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
