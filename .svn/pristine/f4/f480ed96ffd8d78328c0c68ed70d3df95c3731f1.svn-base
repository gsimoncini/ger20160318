using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TaskStaticInfo.
	/// </summary>
	public class TaskStaticInfo
	{
		public TaskStaticInfo()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			System.Console.WriteLine("");
			
		}
		private static System.Collections.SortedList _classtypes = new SortedList();
		private static void DeclareTypes()
		{
			_classtypes=ClaseTarea.Clases;
		}

		
		public static Type GetTaskType(string keyTask)
		{
			if (_classtypes.Count == 0)
			{
				DeclareTypes();
			}
			if (_classtypes.Contains(keyTask))
				return (Type)_classtypes[keyTask];
			else
				return null;
		}
		

		public static Type GetTaskType(long IdTask)
		{
			string keyTask = mz.erp.businessrules.twf_Tareas.GetByPk(IdTask).Descripcion;
			return GetTaskType(keyTask);
		}

		public enum SortOrder
		{
			Default,
			OrderBR,
			OrderDA,
			OrderUI
		};
	}
}
