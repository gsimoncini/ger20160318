using System;
using System.Data;
using mz.erp.businessrules.comprobantes;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Validator.
	/// </summary>
	public class WorkflowValidator
	{
		public WorkflowValidator()
		{
		}

		public static void Clear()
		{
			ValidationsCache.Clear();
		}
		
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
	
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		
		public bool IsValidForStartProcess(long IdProcess, long IdTarea, object Sender)
		{
			bool IsValid = true;
			_errores.Clear();
			string  ProcessName = twf_Procesos.GetByPk(IdProcess).Descripcion;
			DataSet data = new DataSet();
			if(!ValidationsCache.Contains(IdProcess, IdTarea, Security.IdPerfil))
			{
				data = businessrules.twf_ProcesosTareasValidaciones.GetValidacionesForStartProcess(IdProcess, IdTarea); //Sobrecarga para workflow
				ValidationsCache.Add(IdProcess, IdTarea, Security.IdPerfil, data);
			}
			else data = ValidationsCache.Get(IdProcess, IdTarea, Security.IdPerfil);
			if (data != null)
			{
				foreach (DataRow row in data.Tables[0].Rows) 
				{
					string Condicion = Convert.ToString(row["Validacion"]);				
					string Titulo = Convert.ToString(row["Titulo"]);
					string Mensaje = Convert.ToString(row["Mensaje"]);
					if (!Evaluator.EvaluateToBool(Condicion, Sender, false)) //Pasa false si la compilación da como resultado un error
					{
						IsValid = false;
						_errores.Add( new ItemDatasetError( Titulo,ProcessName,Mensaje));
					}
				}
			}
			return IsValid;
		}
	}

	public sealed class ValidationsCache
	{
		private static Hashtable _validationsCache = new Hashtable();

		public static bool Contains(long IdProceso, long IdTarea, long IdPerfil)
		{
			KeyValidation key = new KeyValidation( IdProceso, IdTarea, IdPerfil);
			ArrayList aux = new ArrayList(_validationsCache.Keys);
			return aux.Contains(key);
		}



		public static void Add(long IdProceso, long IdTarea, long IdPerfil, DataSet data)
		{
			KeyValidation key = new KeyValidation( IdProceso, IdTarea, IdPerfil);
			ArrayList aux = new ArrayList(_validationsCache.Keys);
			if(!aux.Contains(key))
				_validationsCache.Add(key, data);
		}

		public static DataSet Get(long IdProceso, long IdTarea, long IdPerfil)
		{
			KeyValidation key = new KeyValidation( IdProceso, IdTarea, IdPerfil);
			ArrayList aux = new ArrayList(_validationsCache.Keys);
			if(aux.Contains(key))
				return (DataSet) _validationsCache[key];
			return null;
		}	

		public static void Clear()
		{
			_validationsCache.Clear();
		}

	}

	public class KeyValidation :IComparable, IComparer
	{
		private long _idProceso;
		private long _idTarea;
		private long _idPerfil;

		public KeyValidation(){}

		public long IdProceso
		{
			get{return _idProceso;}
		}

		public long IdTarea
		{
			get{return _idTarea;}
		}

		public long IdPerfil
		{
			get{return _idPerfil;}
		}

		public KeyValidation(long IdProceso, long IdTarea, long IdPerfil)
		{
			_idProceso = IdProceso;
			_idTarea = IdTarea;
			_idPerfil = IdPerfil;
		}

		public override int GetHashCode()
		{
			return Convert.ToInt32(_idProceso+_idTarea+_idPerfil);
		}


		public override bool Equals(object key)
		{
			
			KeyValidation obj = (KeyValidation) key;
			return _idProceso.Equals(obj.IdProceso) &&
				   _idTarea.Equals(obj.IdTarea) &&
				   (_idPerfil.Equals(obj.IdPerfil));
		}


		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			KeyValidation key = (KeyValidation) obj;
			if( _idProceso.Equals(key.IdProceso) &&
				   _idTarea.Equals(key.IdTarea) &&
				   (_idPerfil.Equals(key.IdPerfil)))
				return 0;
			return 1;
		}

		#endregion

		#region Miembros de IComparer

		public int Compare(object obj, object obj1)
		{
			KeyValidation x = (KeyValidation) obj;
			KeyValidation y = (KeyValidation) obj1;
			if( x.IdProceso.Equals(y.IdProceso) &&
				x.IdTarea.Equals(y.IdTarea) &&
				(x.IdPerfil.Equals(y.IdPerfil)))
				return 0;
			return 1;
		}

		#endregion
	}


}
