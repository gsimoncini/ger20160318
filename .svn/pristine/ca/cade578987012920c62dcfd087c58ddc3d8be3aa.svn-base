using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Workflow.
	/// </summary>
	public class Workflow
	{
		public Workflow()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static string GetMomentosPrecedentes (string Momento) 
		{
			
			return "";
		}

		/// <summary>
		/// Este metodo debe devolver un ArrayList de instancias de tipo TaskDynamicInfo
		/// </summary>
		/// <param name="aProcess"></param>
		/// <returns></returns>
		public static DataSet GetDependentTasks(long IdTask)
		{
			return mz.erp.dataaccess.Workflow.GetDependentTasks(IdTask);
		}

		public static bool IsNextTask(long IdCurrentTask , long IdNextTask)
		{
			return mz.erp.dataaccess.Workflow.IsNextTask(IdCurrentTask, IdNextTask);
		}

		public ArrayList GetNextTask( long IdCurrentTask, long IdCurrentProcess)
		{
			ArrayList array = new ArrayList();
			DataSet data = mz.erp.dataaccess.Workflow.GetNextTasks( IdCurrentTask, IdCurrentProcess);
			if (data.Tables.Count> 0)
			{
				foreach (DataRow row in data.Tables[0].Rows )
				{
					array.Add( Convert.ToString(row["Descripcion"]) );
				}
			}
			return array;	
		
		}

		public static DataSet GetNextTasks(long IdCurrentTask)
		{
			return mz.erp.dataaccess.Workflow.GetNextTasks(IdCurrentTask);
		}

		public static DataSet GetPreviousTasks(long IdCurrentTask)
		{
			return mz.erp.dataaccess.Workflow.GetPreviousTasks(IdCurrentTask);
		}

		public static DataSet GetDependentFlows(long IdCurrentTask, long IdNextTask)
		{
			return  mz.erp.dataaccess.Workflow.GetDependentFlows(IdCurrentTask, IdNextTask);
		}
		
		public static DataSet GetComprobantesAsociados( long IdCurrentTask)
		{
			return mz.erp.dataaccess.Workflow.GetComprobantesAsociados(IdCurrentTask);
		}
		public static SortedList GetComprobantesAsociadosList( long IdCurrentTask)
		{
			DataSet data = GetComprobantesAsociados( IdCurrentTask );
			SortedList array = new SortedList();
			if (data.Tables.Count > 0)
			{
				foreach( System.Data.DataRow row in data.Tables[0].Rows )
				{
					string idTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
					System.Data.DataRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(idTipoDeComprobante);
					string descripcion = string.Empty;
					if(rowTC != null)
						descripcion = Convert.ToString( rowTC["Descripcion"]);


					array.Add( idTipoDeComprobante, descripcion);

				}
			}
			
			return array;
		}

		public static DataSet GetProcessPrimaryTask(long IdProcess)
		{
			return mz.erp.dataaccess.Workflow.GetProcessPrimaryTask(IdProcess);
		}

		public static DataSet GetProcessSecondaryTasks(long IdProcess)
		{
			return mz.erp.dataaccess.Workflow.GetProcessSecondaryTasks(IdProcess);
		}
			
		public static long GetIdProcessByName( string _nameProcess )
		{
			if(_nameProcess == null)
				return long.MinValue;
			else
                return mz.erp.businessrules.twf_Procesos.GetIdProcessByName( _nameProcess );
		}

		public static long GetIdTakByName(string _nameTask)
		{
			if(_nameTask == null)
				return long.MinValue;
			else
                return mz.erp.businessrules.twf_Tareas.GetIdTaskByName(_nameTask);
		}

		public static DataSet GetPreviousTasksOfProcess(long IdCurrentTask, long IdCurrentProcess)
		{
			return mz.erp.dataaccess.Workflow.GetPreviousTasksOfProcess(IdCurrentTask, IdCurrentProcess);
		}

		public static DataSet GetCaminoComprobantesOrdinalBottonUp(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesOrdinalBottonUp(CurrentIdComprobante, CurrentOrdinal, ToIdTipoDeComprobantes);
		}

		public static DataSet GetCaminoComprobantesBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesBottonUp(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		public static DataSet GetCaminoComprobantesTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesTopDown(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		public static DataSet GetComprobantesBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetComprobantesBottonUp(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		public static DataSet GetComprobantesTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetComprobantesTopDown(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		public static string GetHTMLComprobantesDeComprasPendientes(string IdComprobante)
		{
			return mz.erp.dataaccess.Workflow.GetHTMLComprobantesDeComprasPendientes(IdComprobante);
		}

		public static string GetHTMLComprobantes(string IdComprobante, string IdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetHTMLComprobantes(IdComprobante ,IdTipoDeComprobantes);
		}
        //German 20120301 - Tarea 0000247

        public static string GetHTMLDetalleAcopio(string IdComprobante, long Ordinal)
        {
            return mz.erp.dataaccess.Workflow.GetHTMLDetalleAcopio(IdComprobante, Ordinal);
        }
        //Fin German 20120301 - Tarea 0000247
		public static string GetHTMLRetenciones(long IdRetencion)
		{
			return mz.erp.dataaccess.Workflow.GetHTMLRetenciones(IdRetencion);
		}
		public static string GetCaminoJerarquiaAgrupProd(string IdNomenclatura)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoJerarquiaAgrupProd(IdNomenclatura);
		}

		public static string GetCaminoJerarquiaAgrupCuentas(string IdNomenclatura)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoJerarquiaAgrupCuentas(IdNomenclatura);
		}

		public static string GetCaminoJerarquiaAgrupProveedores(string IdNomenclatura)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoJerarquiaAgrupProveedores(IdNomenclatura);
		}
	
		public static string GetHTMLComprobantesResumido(string IdComprobante, string IdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetHTMLComprobantesResumido(IdComprobante ,IdTipoDeComprobantes);
		}

		public static DataSet GetCaminoComprobantesCompraOrdinalBottonUp(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesCompraOrdinalBottonUp(CurrentIdComprobante, CurrentOrdinal, ToIdTipoDeComprobantes);
		}

		public static DataSet GetCaminoComprobantesCompraBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesCompraBottonUp(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		public static DataSet GetCaminoComprobantesCompraTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesCompraTopDown(CurrentIdComprobante, ToIdTipoDeComprobantes);
		}

		
		public static DataSet GetCaminoComprobantesOrdinalTopDown(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			return mz.erp.dataaccess.Workflow.GetCaminoComprobantesOrdinalTopDown(CurrentIdComprobante, CurrentOrdinal, ToIdTipoDeComprobantes);
		}


        //German 20110309 - Tarea 0000038
        public static bool EsProcesoDeConfirmacionDePrecios(string ProcessName)
        {
            return ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")
                || ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")
                || ProcessName.Equals("ProcesoIngresarComprasCompleto");
        }

        public static bool NOEsProcesoDeConfirmacionDePrecios(string ProcessName)
        {
            return !ProcessName.Equals("ProcesoConfirmarIngresoMercaderia")
                && !ProcessName.Equals("ProcesoConfirmarIngresoMercaderiaAnterior")
                && !ProcessName.Equals("ProcesoIngresarComprasCompleto");
        }
        //Fin German 20110309 - Tarea 0000038




	}
}
