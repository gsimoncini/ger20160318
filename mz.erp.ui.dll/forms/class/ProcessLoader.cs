using System;
using System.Collections;


namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ProcessLoader.
	/// </summary>
	public class ProcessLoader
	{
		public ProcessLoader()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void CallProcess( string _processName )
		{
			Hashtable parametros = null;
			CallProcess(_processName, parametros);
		}
		public static void CallProcess( string _processName, Hashtable parametros)
		{
			DateTime fecha = DateTime.Now;
			Console.WriteLine("Arranca el Proceso "  + fecha);
			ProcessUIManager _process = new ProcessUIManager();
			_process.CreateNewProcess(_processName, parametros);
			TimeSpan diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Clases Manager creadas " + diff.TotalSeconds + " " + DateTime.Now);
			_process.Init();
			diff = DateTime.Now.Subtract(fecha);
			Console.WriteLine("Clases Inicializadas " + diff.TotalSeconds + " " + DateTime.Now);
		}
	}
}
