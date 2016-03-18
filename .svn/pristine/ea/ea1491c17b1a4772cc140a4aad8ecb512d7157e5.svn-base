using System;
using System.Data;
//using mz.erp.;
using System.Collections;
namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de GridManagerViewSortByAgregateColumnController.
	/// </summary>
	public class GridManagerViewSortByAgregateColumnController
	{
		public GridManagerViewSortByAgregateColumnController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region variables privadas
		private Janus.Windows.GridEX.GridEX _grilla;
		private DataTable _dataSource = new DataTable();
		public DataTable DataSource
		{
			get{return _dataSource;}
			set{ _dataSource=value;}
		}

		private object _dataSourceAnterior;
		public object DataSourceAnterior
		{
			get{return _dataSourceAnterior;}
			set{ _dataSourceAnterior=value;}
		}
		private ArrayList _columnasVisibles = new ArrayList();
		public ArrayList ColumnasVisibles
		{
			get{return _columnasVisibles;}
			set{ _columnasVisibles=value;}
		}
		private ArrayList _columnasGrupo = new ArrayList();
		public ArrayList ColumnasGrupo
		{
			get{return _columnasGrupo;}
			set{ _columnasGrupo=value;}
		}
		private ArrayList _columnasTotales = new ArrayList();
		public ArrayList ColumnasTotales
		{
			get{return _columnasTotales;}
			set{ _columnasTotales=value;}
		}
		//La nueva grilla tiene q tener primero las columnas de grupo y despues las de totales, guardo aca la posicion vieja de todas las columnas
		private Hashtable _posicionColumnas=new Hashtable();
		public Hashtable PosicionColumnas
		{
			get{return _posicionColumnas;}
			set{ _posicionColumnas=value;}
		}
		#endregion
		#region metodos publicos

	
		public void nuevoLayout(Janus.Windows.GridEX.GridEX grilla,GridVariablesLoader _loader){
			_grilla=grilla;
			this.cargarInfoGrillaAnterior(_grilla,_loader);
			
			//Aca tengo todas las columnas de la 'nueva grilla', recorro la grilla para quedarme con el tipo y ponerlas visibles
			ArrayList nuevasColum= new ArrayList();
			nuevasColum.AddRange(ColumnasGrupo);
			foreach (string col in ColumnasTotales)
			{
				if(!nuevasColum.Contains(col))
					nuevasColum.Add(col);
			}
					
			DataTable dataTable = new DataTable();
			int i=1;
			foreach (string s in nuevasColum){
				grilla.RootTable.Columns[s].Visible=true;
				grilla.RootTable.Columns[s].Position=i;
				i++;
				//DataColumn columna=new DataColumn(Convert.ToString(s));
				DataColumn columna=new DataColumn(s);
                /* Silvina 20100914 */
				//columna.DataType =_grilla.RootTable.Columns[s].GetType();
                columna.DataType = _grilla.RootTable.Columns[s].Type;
                /* Fin Silvina */
				dataTable.Columns.Add(columna);
			
			}
			//Carga el nuevo datasource con los datos q necesita
			dataTable=this.cargarTabla(dataTable,_grilla);
			//Una vez q tengo todos los datos cargados para la grilla nueva, vuelo los grupos
			_grilla.RootTable.Groups.Clear();
			this._dataSource=dataTable;
		
		}

		//Se queda con las columnas visibles de la tabla para despues poner visibles solo esas
		public void columnasVisibles(Janus.Windows.GridEX.GridEX grilla){
			ArrayList visibles=new ArrayList();
			foreach  ( Janus.Windows.GridEX.GridEXColumn columna in grilla.RootTable.Columns){
					if (columna.Visible)
						visibles.Add(Convert.ToString(columna.DataMember));
			
			}
			this.ColumnasVisibles=visibles;
		}

		public void layoutAnterior(Janus.Windows.GridEX.GridEX grilla){
			//Le cargo la posicion q tenia antes y pongo invisibles a todas
			foreach  ( Janus.Windows.GridEX.GridEXColumn columna in grilla.RootTable.Columns)
			{	columna.Position=Convert.ToInt32(this._posicionColumnas[Convert.ToString(columna.DataMember)]);
				columna.Visible=false;
			}
			//Solo visible las q eran visibles
			foreach (string s in this.ColumnasVisibles)
			{
				grilla.RootTable.Columns[s].Visible=true;
			}
			//Vuelvo a agrupar como taba
			foreach (string s1 in this.ColumnasGrupo)
			{
				grilla.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(grilla.RootTable.Columns[s1]));
			}
		}
		#endregion
		#region metodos privados
		private void cargarInfoGrillaAnterior(Janus.Windows.GridEX.GridEX grilla,GridVariablesLoader _loader)
		{
			_grilla=grilla;
			string columnasAgrup=String.Empty;
			string columnasTotal=String.Empty;
			ArrayList agrupadas=new ArrayList();
			Janus.Windows.GridEX.GridEXGroupCollection grupos= _grilla.RootTable.Groups;
			foreach (Janus.Windows.GridEX.GridEXGroup g in grupos)
			{
				agrupadas.Add(g.Column.DataMember.ToString());				
				
			}
			this.ColumnasGrupo=agrupadas;
			//TODO: esto habria q ver si se puede sacar de la grilla las columnas por las q totaliza, por ahora son fijas, pero podrian ser dinamicas.
			columnasTotal=_loader.TotalGroups;
			this.ColumnasTotales=mz.erp.systemframework.Util.Parse(columnasTotal);
			//Solo estas columnas tienen q quedar visibles en el layout			
			Hashtable _posiciones=new Hashtable();
			foreach  ( Janus.Windows.GridEX.GridEXColumn columna in _grilla.RootTable.Columns)
			{
				columna.Visible=false;
				_posiciones.Add(Convert.ToString(columna.DataMember), columna.Position);
			}
			this._posicionColumnas=_posiciones;
		}

		private DataTable cargarTabla(DataTable dataTable,Janus.Windows.GridEX.GridEX _grilla)
		{
			/*Janus.Windows.GridEX.GridEXRow[] todasRows=_grilla.GetRows();
			foreach (Janus.Windows.GridEX.GridEXRow row in todasRows)
			{
				//Esto seria los valores encabezados del grupo entonces sacar los valores para las colum agrup
				Janus.Windows.GridEX.GridEXRow prueba=row;
				if(prueba.RowType == Janus.Windows.GridEX.RowType.GroupHeader)
				{
					
					DataRow fila=dataTable.NewRow();
					foreach (string s in ColumnasGrupo)
					{
						fila[s]=prueba.GroupCaption;
						prueba=row.GetChildRows()[0];
					}
					//No hay mas groupsHeader ahora tengo q totalizar el grupo :S, pipi
					foreach (string s1 in ColumnasTotales)
						{
						if(prueba.RowType== Janus.Windows.GridEX.RowType.GroupHeader)
							fila[s1]=prueba.GetSubTotal(_grilla.RootTable.Columns[s1],Janus.Windows.GridEX.AggregateFunction.Sum);
						else
							fila[s1]=prueba.Parent.GetSubTotal(_grilla.RootTable.Columns[s1],Janus.Windows.GridEX.AggregateFunction.Sum);
						}
					dataTable.Rows.Add(fila);
					}
				
			
			}
			return dataTable;*/
			Janus.Windows.GridEX.GridEXRow[] todasRows=_grilla.GetRows();
			foreach (Janus.Windows.GridEX.GridEXRow row in todasRows)
			{
				//Esto seria los valores encabezados del grupo entonces sacar los valores para las colum agrup
				Janus.Windows.GridEX.GridEXRow prueba=row;
				DataRow fila=dataTable.NewRow();
				recorrerGrillaCargandoInfo(prueba,dataTable,_grilla,"");
			}
			return dataTable;
		}

        private void recorrerGrillaCargandoInfo(Janus.Windows.GridEX.GridEXRow prueba, DataTable tabla, Janus.Windows.GridEX.GridEX _grilla, string caption)
        {
            /* Silvina 20101118 - Tarea 931 */
            //caption = caption + prueba.GroupCaption + ',';
            caption = caption + prueba.GroupCaption.Replace(',', '.') +',';
            /* Fin Silvina */
            ArrayList colGrupos = mz.erp.systemframework.Util.Parse(caption);
			if (!hijasGrupo(prueba))
			{			
				DataRow fila=tabla.NewRow();
				foreach (string s1 in ColumnasTotales){
					if (!this.ColumnasGrupo.Contains(s1))
						fila[s1]=prueba.GetSubTotal(_grilla.RootTable.Columns[s1],Janus.Windows.GridEX.AggregateFunction.Sum);
				}
				
				int i=0;
				foreach (string s in colGrupos)
                {
					if (!s.Equals(string.Empty)){
						fila[i]=s;
					i++;
					}
				}
				tabla.Rows.Add(fila);
			}
			else
			{
				foreach(Janus.Windows.GridEX.GridEXRow row in prueba.GetChildRows())
				{
                    recorrerGrillaCargandoInfo(row, tabla, _grilla, caption);
				}
			}
		}

		private bool hijasGrupo(Janus.Windows.GridEX.GridEXRow row){
			Janus.Windows.GridEX.GridEXRow[] hijas=row.GetChildRows();
			return (hijas[0].RowType==Janus.Windows.GridEX.RowType.GroupHeader);
		
		
		}

		
			#endregion		
	}
}
