using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de IContext.
	/// </summary>
	public interface IContext
	{
		#region Métodos
		ArrayList getDatosNuevos();
		ArrayList getContext();
		bool isValorLista();
		string getValorVariableParaUsuario(string idVariable, string descripcionDatoNuevo, string idUsuario);
		string getValorVariableParaPerfil(string idVariable, string descripcionDatoNuevo, long idPerfil);
		string getValorVariableParaPuesto(string idVariable, string descripcionDatoNuevo, long idEmpresa, long idSucursal, long idPuesto);
		string getValorVariableParaEmpresa(string idVariable, string descripcionDatoNuevo, long idEmpresa);
		string getValorVariableParaSucursal(string idVariable, string descripcionDatoNuevo, long idEmpresa, long idSucursal);
		bool huboCambios();
		bool isConfiguracionValida(string idVariable, string descripcionDatoNuevo);
		#endregion

	}
}
