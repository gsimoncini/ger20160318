using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using System.Data.SqlClient;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Regla.
	/// </summary>
	/// 
	public class Regla
	{
		
		#region Variables privadas

		private string _idRegla = string.Empty;
		private string _decripcion = string.Empty;
		private string _comentario = string.Empty;
		private Hashtable _configuraciones = new Hashtable();
		private static Regla instance = null;

		#endregion

		#region Constructores

		private Regla()
		{
		}

		private Regla(sy_ReglasDataset.sy_ReglasRow row)
		{
			_idRegla = row.IdRegla;
			_decripcion = row.Descripcion;
			_comentario = row.Comentario;
		}
		#endregion
	
		#region Propiedades

		public string IdRegla
		{
			get{return _idRegla;}
			set{_idRegla = value;}
		}

		public string Decripcion
		{
			get{return _decripcion;}
			set{_decripcion = value;}
		}

		public string Comentario
		{
			get{return _comentario;}
			set{_comentario = value;}
		}
		
		public Hashtable Configuraciones
		{
			get{return _configuraciones;}
			set{_configuraciones = value;}
		}
		#endregion

		#region Metodos Privados

		#endregion

		#region Metodos Publicos
		public static Regla GetInstance()
		{
			if(instance == null)
				instance = new Regla();
			return instance;
		}

		public Regla GetRegla(string IdRegla)
		{
			sy_ReglasDataset.sy_ReglasRow rowR = sy_Reglas.GetByPk(IdRegla);
			Regla regla = new Regla(rowR);
			sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasDataTable tableConf = sy_ConfiguracionesReglas.GetList(IdRegla).sy_ConfiguracionesReglas;
			Hashtable configuraciones = new Hashtable();
			foreach(sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow rowC in tableConf.Rows)
			{
				ConfiguracionRegla conf = new ConfiguracionRegla(rowC);
				configuraciones.Add(conf.IdConfiguracion,conf);
			}
			regla.Configuraciones = configuraciones;
			return regla;
		}

		public void Commit(sy_ConfiguracionesReglasDataset DataConfiguracionesReglas, sy_VariablesDataset Data, sy_VariablesUsuariosDataset DataUsuarios, sy_VariablesPerfilesDataset DataPerfiles, sy_VariablesPuestosDataset DataPuestos)
		{
			foreach(ConfiguracionRegla conf in this.Configuraciones.Values)
			{
				conf.Commit(DataConfiguracionesReglas, Data, DataUsuarios, DataPerfiles, DataPuestos);
			}

		}
		#endregion
	}

	
	public class ConfiguracionRegla
	{
		
		#region Variables privadas

		private string _idConfiguracion = string.Empty;
		private string _valorDefault = string.Empty;
		private string _valor = string.Empty;
		private string _nombre = string.Empty;
		private string _descripcion = string.Empty;
		private ArrayList _variables = new ArrayList();

		#endregion

		#region Constructores

		public ConfiguracionRegla(sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow row)
		{
			_idConfiguracion = row.IdConfiguracion;
			_valorDefault = row.ValorDefault;
			_valor = row.Valor;
			_nombre = row.nombre;
			_descripcion = row.Descripcion;
			_variables = new ArrayList();
			sy_VariablesReglasDataset.sy_VariablesReglasDataTable tableVar = sy_VariablesReglas.GetList(_idConfiguracion).sy_VariablesReglas; 
			foreach(sy_VariablesReglasDataset.sy_VariablesReglasRow rowV in tableVar.Rows)
			{
				VariableRegla var = new VariableRegla(rowV);
				_variables.Add(var);
			}
			
		}

		#endregion
	
		#region Propiedades

		public string IdConfiguracion
		{
			get{return _idConfiguracion;}
			set{_idConfiguracion = value;}
		}

		public string ValorDefault
		{
			get{return _valorDefault;}
			set{_valorDefault = value;}
		}

		public string Valor
		{
			get{return _valor;}
			set{_valor = value;}
		}
		
		public string Nombre
		{
			get{return _nombre;}
			set{_nombre = value;}
		}
		
		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public ArrayList Variables
		{
			get{return _variables;}
			set{_variables = value;}
		}
		#endregion

		#region Metodos Privados

		#endregion

		#region Metodos Publicos

		public void Commit(sy_ConfiguracionesReglasDataset DataConfiguracionesReglas, sy_VariablesDataset Data, sy_VariablesUsuariosDataset DataUsuarios, sy_VariablesPerfilesDataset DataPerfiles, sy_VariablesPuestosDataset DataPuestos)
		{
			//Guardo el valor de la configuracion
            sy_ConfiguracionesReglasDataset.sy_ConfiguracionesReglasRow rowC = sy_ConfiguracionesReglas.GetByPk(this.IdConfiguracion);
			if(rowC != null)
			{
				rowC.Valor = this.Valor;
				DataConfiguracionesReglas.sy_ConfiguracionesReglas.ImportRow(rowC);
			}

			//Guardo las variables 
			foreach(VariableRegla var in this.Variables)
			{
				var.Commit(Data, DataUsuarios, DataPerfiles, DataPuestos, this.Valor, this.Descripcion);
			}

		}

		public override System.String ToString()
		{
			return _nombre;
		}
		
		public override System.Boolean Equals ( System.Object obj )
		{
			return this.IdConfiguracion.Equals(((ConfiguracionRegla)obj).IdConfiguracion);
		}
		#endregion
	}

	public class VariableRegla
	{
		
		#region Variables privadas

		private string _idVariable = string.Empty;

		#endregion

		#region Constructores

		public VariableRegla(sy_VariablesReglasDataset.sy_VariablesReglasRow row)
		{
			_idVariable = row.IdVariable;
		}
		#endregion
	
		#region Propiedades

		public string IdVariable
		{
			get{return _idVariable;}
			set{_idVariable = value;}
		}

		#endregion

		#region Metodos Privados

		#endregion

		#region Metodos Publicos
		public void Commit(sy_VariablesDataset Data, sy_VariablesUsuariosDataset DataUsuarios, sy_VariablesPerfilesDataset DataPerfiles, sy_VariablesPuestosDataset DataPuestos, string Valor, string Descripcion)
		{
            sy_VariablesDataset.sy_VariablesRow row = sy_Variables.GetByPk(this.IdVariable);
			if(row == null)
			{
				row = Data.sy_Variables.Newsy_VariablesRow();
				row.IdVariable = IdVariable;
				row.IdTipoVariable = "System.Boolean";
				row.Descripcion = Descripcion;
				row.ValorDefault = Valor;
				row.FechaCreacion = DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				Data.sy_Variables.Addsy_VariablesRow(row);
			}
			else
			{
				row.ValorDefault = Valor;
				Data.sy_Variables.ImportRow(row);
			}

			sy_VariablesUsuariosDataset.sy_VariablesUsuariosDataTable tableVU = sy_VariablesUsuarios.GetList(this.IdVariable).sy_VariablesUsuarios;
			foreach(sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU in tableVU.Rows)
			{
				rowU.Valor = Valor;
				DataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
			}

			sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable tableVP = sy_VariablesPerfiles.GetList(this.IdVariable).sy_VariablesPerfiles;
			foreach(sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP in tableVP.Rows)
			{
				rowP.Valor = Valor;
				DataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
			}
		
			sy_VariablesPuestosDataset.sy_VariablesPuestosDataTable tableVPU = sy_VariablesPuestos.GetList(this.IdVariable).sy_VariablesPuestos;
			foreach(sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowPU in tableVPU.Rows)
			{
				rowPU.Valor = Valor;
				DataPuestos.sy_VariablesPuestos.ImportRow(rowPU);
			}
		}
		#endregion
	}
}
