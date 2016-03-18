using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de ITiposObservaciones.
	/// </summary>
	public interface ITiposObservaciones: ITask, IPersistentTask, IContext
	{
		#region Eventos
		event System.EventHandler TiposObservacionesNuevasHasChanged;
		#endregion

		#region Metodos
		void AddMovimiento(string DescripcionTipo, string KeyTipo, string KeyTipoPadre, string DescripcionTipoPadre, bool Activo, string Modo);
		string TextoBotonAnterior();
		string TextoBotonSiguiente();
		string LeyendaFormulario();
		bool PreguntarAlCancelar();
		System.Collections.ArrayList TiposObservacionesNuevas();
		System.Collections.ArrayList TiposObservacionesNuevasConfigVariables();
		Node getChildsNode(string key);
		/*void ListenerAfterExecuteDependentTask( object sender );
		void ListenerBeforeExecuteDependentTask( object sender );
		void Init();
		bool IsValid();
		bool IsValidForStartProcess();
		bool AllowShow();
		ItemsDatasetErrors GetErrors();
		string GetWarnings();
		ProcessManager GetProcessManagerParent();
		void SetProcessManagerParent(ProcessManager processManager);
		string GetTaskName();
		void SetTaskName(string taskName);
		void Execute();
		bool AllowPrevious();
		void Previous();
		void FormHasClosed();
		void ListenerAfterPreviousDependentTask( object sender );
		void ListenerBeforePreviousDependentTask( object sender );
			*/
			
		#endregion

	}
}
