using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Variable.
	/// </summary>
	public class Variable
	{

		#region Variables privadas
		private string _idVariable = string.Empty;
		private string _idVariableOriginal = string.Empty;
		private string _descripcion = string.Empty;
		private string _valor = string.Empty;
		private string _idTipoVariable = string.Empty;
		private string _categoria = string.Empty;
		private string _comentario = string.Empty;
		private long _idPerfil;
		private string _perfil = string.Empty;
		private long _idPuesto;
		private string _puesto = string.Empty;
		private long _idEmpresa;
		private long _idSucursal;
		private string _idUsuario = string.Empty;
		private string _usuario = string.Empty;
		private string _estado = string.Empty;
		private string _tipoVariable;
		#endregion

		#region Constructores
		public Variable()
		{
		}

		public Variable(string IdVariableOriginal, string IdVariable, string Descripcion, string Tipo, string Valor, string IdUsuario, long IdPerfil, long IdPuesto, string Usuario, string Perfil, string Puesto, string Estado, string TipoVariable)
		{
			_idVariable = IdVariable;
			_idVariableOriginal = IdVariableOriginal;
			_descripcion = Descripcion;
			_idTipoVariable = Tipo;
			_valor = Valor;
			_idUsuario = IdUsuario;
			_idPerfil = IdPerfil;
			_idPuesto = IdPuesto;
			_usuario = Usuario;
			_perfil = Perfil;
			_puesto = Puesto;
			_estado = Estado;
			_tipoVariable = TipoVariable;
		}

		public Variable(DataRow row)
		{
			_idVariable = (string)row["IdVariable"];
			_idVariableOriginal = (string)row["IdVariable"];
			_descripcion = (string)row["Descripcion"];
			_idTipoVariable = (string)row["Tipo"];
			_valor = (string)row["ValorDefault"];
			_usuario = (string)row["Usuario"];
			_perfil = (string)row["Perfil"];
			_puesto = (string)row["Puesto"];
			string tipoVar = "GENERICA";
			if(!_usuario.Equals(string.Empty))
			{
				_idUsuario = (string)row["IdUsuario"];
				tipoVar = "USUARIO";
			}
			if(!_perfil.Equals(string.Empty))
			{
				_idPerfil = Convert.ToInt64(row["IdPerfil"]);
				tipoVar = "PERFIL";
			}
			if(!_puesto.Equals(string.Empty))
			{
				_idPuesto = Convert.ToInt64(row["IdPuesto"]);
				tipoVar = "PUESTO";
			}
			_estado = "MODIF";
			_tipoVariable = tipoVar;

		}

		public Variable(DataRowView row)
		{
			_idVariable = (string)row["IdVariable"];
			_idVariableOriginal = (string)row["IdVariable"];
			_descripcion = (string)row["Descripcion"];
			_idTipoVariable = (string)row["Tipo"];
			_valor = (string)row["ValorDefault"];
			_usuario = (string)row["Usuario"];
			_perfil = (string)row["Perfil"];
			_puesto = (string)row["Puesto"];
			string tipoVar = "GENERICA";
			if(!_usuario.Equals(string.Empty))
			{
				_idUsuario = (string)row["IdUsuario"];
				tipoVar = "USUARIO";
			}
			if(!_perfil.Equals(string.Empty))
			{
				_idPerfil = Convert.ToInt64(row["IdPerfil"]);
				tipoVar = "PERFIL";
			}
			if(!_puesto.Equals(string.Empty))
			{
				_idPuesto = Convert.ToInt64(row["IdPuesto"]);
				tipoVar = "PUESTO";
			}
			_estado = "MODIF";
			_tipoVariable = tipoVar;

		}
		#endregion

		#region Propiedades

		public string IdVariableOriginal 
		{
			get{return _idVariableOriginal;}
			set{_idVariableOriginal = value;}
		}

		public string IdVariable 
		{
			get{return _idVariable;}
			set{_idVariable = value;}
		}

		public string Descripcion 
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}

		public string Valor
		{
			get{return _valor;}
			set{_valor = value;}
		}

		public string IdTipoVariable 
		{
			get{return _idTipoVariable;}
			set{_idTipoVariable = value;}
		}
		
		public string Categoria 
		{
			get{return _categoria;}
			set{_categoria = value;}
		}
		
		public string Comentario 
		{
			get{return _comentario;}
			set{_comentario = value;}
		}
		
		public long IdPerfil 
		{
			get{return _idPerfil;}
			set{_idPerfil = value;}
		}
		
		public string Perfil 
		{
			get{return _perfil;}
			set{_perfil = value;}
		}
		
		public long IdPuesto 
		{
			get{return _idPuesto;}
			set{_idPuesto = value;}
		}
		
		public string Puesto 
		{
			get{return _puesto;}
			set{_puesto = value;}
		}
		
		public long IdEmpresa 
		{
			get{return _idEmpresa;}
			set{_idEmpresa = value;}
		}
		
		public long IdSucursal 
		{
			get{return _idSucursal;}
			set{_idSucursal = value;}
		}
		
		public string IdUsuario 
		{
			get{return _idUsuario;}
			set{_idUsuario = value;}
		}
		
		public string Usuario 
		{
			get{return _usuario;}
			set{_usuario = value;}
		}

		public string Estado
		{
			get{return _estado;}
			set{_estado = value;}
		}

		public string TipoVariable
		{
			get{return _tipoVariable;}
		}
		#endregion
	
		#region Métodos Públicos
		public void Commit(sy_VariablesDataset DataGenericas, sy_VariablesUsuariosDataset DataUsuarios, sy_VariablesPerfilesDataset DataPerfiles, sy_VariablesPuestosDataset DataPuestos)
		{
			switch(TipoVariable)
			{
				case "GENERICA":
				{
					sy_VariablesDataset.sy_VariablesRow rowG;
					if(Estado.Equals("NEW"))
					{
						rowG = DataGenericas.sy_Variables.Newsy_VariablesRow();
						rowG.IdVariable = IdVariable;
						rowG.Descripcion = Descripcion;
						rowG.ValorDefault = Valor;
						rowG.IdTipoVariable = IdTipoVariable;
						rowG.Categoria = Categoria;
						rowG.Comentario = Comentario;
						rowG.FechaCreacion = DateTime.Now;
						rowG.IdConexionCreacion = Security.IdConexion;
						DataGenericas.sy_Variables.Addsy_VariablesRow(rowG);
					}
					else if(Estado.Equals("MODIF"))
					{
						rowG = mz.erp.businessrules.sy_Variables.GetByPk(IdVariableOriginal);
						rowG.IdVariable = IdVariable;
						rowG.Descripcion = Descripcion;
						rowG.ValorDefault = Valor;
						rowG.IdTipoVariable = IdTipoVariable;
						rowG.Categoria = Categoria;
						rowG.Comentario = Comentario;
						DataGenericas.sy_Variables.ImportRow(rowG);
					}
					else //Es borrado
					{
						rowG = mz.erp.businessrules.sy_Variables.GetByPk(IdVariableOriginal);
						rowG.Delete();
						DataGenericas.sy_Variables.ImportRow(rowG);
					}
					break;
				}
				case "USUARIO":
				{
					sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow rowU;
					if(Estado.Equals("NEW"))
					{
						rowU = DataUsuarios.sy_VariablesUsuarios.Newsy_VariablesUsuariosRow();
						rowU.IdVariable = IdVariable;
						rowU.IdUsuario = IdUsuario;
						rowU.Valor = Valor;
						rowU.FechaCreacion = DateTime.Now;
						rowU.IdConexionCreacion = Security.IdConexion;
						DataUsuarios.sy_VariablesUsuarios.Addsy_VariablesUsuariosRow(rowU);
					}
					else if(Estado.Equals("MODIF"))
					{
						rowU = mz.erp.businessrules.sy_VariablesUsuarios.GetByPk(IdVariableOriginal, IdUsuario);
						rowU.IdVariable = IdVariable;
						rowU.Valor = Valor;
						DataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
					}
					else //Es borrado
					{
						rowU = mz.erp.businessrules.sy_VariablesUsuarios.GetByPk(IdVariableOriginal, IdUsuario);
						rowU.Delete();
						DataUsuarios.sy_VariablesUsuarios.ImportRow(rowU);
					}
					break;
				}
				case "PERFIL":
				{
					sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowP;
					if(Estado.Equals("NEW"))
					{
						rowP = DataPerfiles.sy_VariablesPerfiles.Newsy_VariablesPerfilesRow();
						rowP.IdVariable = IdVariable;
						rowP.IdPerfil = IdPerfil;
						rowP.Valor = Valor;
						rowP.FechaCreacion = DateTime.Now;
						rowP.IdConexionCreacion = Security.IdConexion;
						DataPerfiles.sy_VariablesPerfiles.Addsy_VariablesPerfilesRow(rowP);
					}
					else if(Estado.Equals("MODIF"))
					{
						rowP = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(IdVariableOriginal, IdPerfil);
						rowP.IdVariable = IdVariable;
						rowP.Valor = Valor;
						DataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
					}
					else //Es borrado
					{
						rowP = mz.erp.businessrules.sy_VariablesPerfiles.GetByPk(IdVariableOriginal, IdPerfil);
						rowP.Delete();
						DataPerfiles.sy_VariablesPerfiles.ImportRow(rowP);
					}

					break;
				}
				case "PUESTO":
				{
					sy_VariablesPuestosDataset.sy_VariablesPuestosRow rowP;
					if(Estado.Equals("NEW"))
					{
						rowP = DataPuestos.sy_VariablesPuestos.Newsy_VariablesPuestosRow();
						rowP.IdVariable = IdVariable;
						rowP.IdPuesto = IdPuesto;
						rowP.IdEmpresa = Security.IdEmpresa;
						rowP.IdSucursal = Security.IdSucursal;
						rowP.Valor = Valor;
						rowP.FechaCreacion = DateTime.Now;
						rowP.IdConexionCreacion = Security.IdConexion;
						DataPuestos.sy_VariablesPuestos.Addsy_VariablesPuestosRow(rowP);
					}
					else if(Estado.Equals("MODIF"))
					{
						rowP = mz.erp.businessrules.sy_VariablesPuestos.GetByPk(IdVariableOriginal, Security.IdEmpresa, Security.IdSucursal, IdPuesto);
						rowP.IdVariable = IdVariable;
						rowP.Valor = Valor;
						DataPuestos.sy_VariablesPuestos.ImportRow(rowP);
					}
					else //Es borrado
					{
						rowP = mz.erp.businessrules.sy_VariablesPuestos.GetByPk(IdVariableOriginal, Security.IdEmpresa, Security.IdSucursal, IdPuesto);
						rowP.Delete();
						DataPuestos.sy_VariablesPuestos.ImportRow(rowP);
					}
					break;
				}
			}

		}
		#endregion

		#region Métodos Privados
		private void Init() 
		{
		}

		#endregion

		#region Eventos
			
		#endregion

	}
}
