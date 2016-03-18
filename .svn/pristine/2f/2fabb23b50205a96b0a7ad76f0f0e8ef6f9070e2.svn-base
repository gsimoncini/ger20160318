using System;
using System.Collections;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
namespace mz.erp.businessrules

{
	/// <summary>
	/// Descripción breve de ClaseTarea.
	/// </summary>
	public class ClaseTarea
	{
		public ClaseTarea()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void Load()
		{
			System.Data.DataSet data =(System.Data.DataSet)twf_ClaseTarea.GetList();
			
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{	//Sacar espacios a la clase
				string IdTarea = Convert.ToString(row["IdTarea"]);
				string clase=Convert.ToString(row["Clase"]);
				clase.Trim();
			
				long idT= Convert.ToInt64(IdTarea);
				twf_TareasDataset.twf_TareasRow _rTarea=twf_Tareas.GetByPk(idT);
				string tarea=Convert.ToString(_rTarea["Descripcion"]);
				tarea.Trim();
				if (!_clases.ContainsKey(tarea))
					_clases.Add(tarea, Type.GetType(clase));
			}
		}
		private static System.Collections.SortedList _clases = new SortedList();
		public static void Reset()
		{
			_clases.Clear();
		}

		public  static SortedList Clases
		{
			get{ return _clases;}
		
		}

	}
}
