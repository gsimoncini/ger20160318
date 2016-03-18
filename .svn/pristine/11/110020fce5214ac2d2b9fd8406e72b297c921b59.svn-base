using System;
using System.Collections;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ControllerTarea.
	/// </summary>
	public class ControllerTarea
	{
		public ControllerTarea()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void Load()
		{
			System.Data.DataSet data =(System.Data.DataSet)mz.erp.businessrules.twf_ControllerTarea.GetList();
			
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{	//Sacar espacios a la clase
				string IdTarea = Convert.ToString(row["IdTarea"]);
				string _controller=Convert.ToString(row["Controller"]);
				_controller.Trim();
			
				long idT= Convert.ToInt64(IdTarea);
				twf_TareasDataset.twf_TareasRow _rTarea=mz.erp.businessrules.twf_Tareas.GetByPk(idT);
				string tarea=Convert.ToString(_rTarea["Descripcion"]);
				tarea.Trim();
				if(!_controls.ContainsKey(tarea))
					_controls.Add(tarea, _controller);
			}
		}
		private static System.Collections.SortedList _controls = new SortedList();
		public static void Reset()
		{
			_controls.Clear();
		}

		public  static SortedList Controls
		{
			get{ return _controls;}
		
		}

	}
}
