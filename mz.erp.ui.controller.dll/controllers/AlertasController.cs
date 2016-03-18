/* Silvina 20110712 - Tarea 0000121 */

using System;
using mz.erp.businessrules;
using System.Text;
using System.Collections;
using System.Data;

namespace mz.erp.ui.controllers
{
    public class AlertasController
    {
        public AlertasController()
        {
            _brClass = new Alertas();
        }

        private Alertas _brClass;

        public DataTable Result
        {
            get { return _brClass.Result; }
        }

        public bool VisualizaAlertas
        {
            get { return _brClass.VisualizaAlertas; }
        }

        public bool HayAlertas
        {
            get { return _brClass.HayAlertas; }
        }

        public bool MuestraSaldoCtaCteDV
        {
            get { return _brClass.MuestraSaldoCtaCteDV; }
        }

        public int TiempoDeActualizacion
        {
            get { return _brClass.TiempoDeActualizacion; }
        }

        public bool ValidaPorFecha
        {
            get { return _brClass.ValidaPorFecha; }
        }

        public bool ValidaPorMonto
        {
            get { return _brClass.ValidaPorMonto; }
        }

        public string Grilla
        {
            get { return _brClass.Grilla; }
        }

        public void ActualizarDatos()
        {
            _brClass.ActualizarDatos();
        }

    }
}

/* Fin Silvina 20110712 - Tarea 0000121 */