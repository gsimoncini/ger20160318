/* Silvina 20110712 - Tarea 0000121 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace mz.erp.businessrules
{
    public class Alertas
    {

        public Alertas()
        {
            Init();
        }

        private void Init()
        {
            _visualizaAlertas = Variables.GetValueBool("Alertas.CuentaCorriente.VisualizaAlertas");
            _valorLimite = Variables.GetValueDecimal("Alertas.CuentaCorriente.ValorLimite");
            _muestraSaldoCtaCteDV = Variables.GetValueBool("Alertas.CuentaCorriente.MuestraSaldoDV");
            _tiempoDeActualizacion = Convert.ToInt32(Variables.GetValueDecimal("Alertas.CuentaCorriente.TiempoDeActualizacion"));
            _validaPorMonto = Variables.GetValueBool("Alertas.CuentaCorriente.ValidaPorMonto");
            _validaPorFecha = Variables.GetValueBool("Alertas.CuentaCorriente.ValidaPorFecha");
            _cantDias = Convert.ToInt32(Variables.GetValueDecimal("Alertas.CuentaCorriente.FechaLimiteDePago"));
            _grilla = Variables.GetValueString("Alertas.CuentaCorriente.Grilla", "gridResultado"); 
        }

        private DataTable _result = new DataTable();
        private bool _visualizaAlertas = false;
        private decimal _valorLimite = 0;
        private bool _muestraSaldoCtaCteDV = false;
        private int _tiempoDeActualizacion = 0;
        private bool _validaPorMonto = false;
        private bool _validaPorFecha = false;
        private int _cantDias = 0;
        private string _grilla = string.Empty;

        public DataTable Result
        {
            get {return _result; }
        }

        public bool VisualizaAlertas
        {
            get { return _visualizaAlertas; }
        }

        public bool HayAlertas
        {
            get { return (_result.Rows.Count > 0); }
        }

        public bool MuestraSaldoCtaCteDV
        {
            get { return _muestraSaldoCtaCteDV; }
        }

        public int TiempoDeActualizacion
        {
            get { return _tiempoDeActualizacion; }
        }

        public bool ValidaPorFecha
        {
            get { return _validaPorFecha; }
        }

        public bool ValidaPorMonto
        {
            get { return _validaPorMonto; }
        }

        public string Grilla
        {
            get { return _grilla; }
        }

        public void ActualizarDatos()
        {
            _result = tsa_Cuentas.GetAlertas(_valorLimite, _validaPorMonto, _validaPorFecha, _cantDias);
        }

    }
}

/* Fin Silvina 20110712 - Tarea 0000121 */