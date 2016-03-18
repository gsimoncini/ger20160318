using System;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de Exceptions.
	/// </summary>
	public class ConceptoRepetidoException: Exception
	{
		public ConceptoRepetidoException():base("El concepto ya existe")
		{
			//this.Message = "El concepto ya existe";
			
		}
	}
	public class NetoAcumuladoInvalidoException: Exception
	{
		public NetoAcumuladoInvalidoException()
		{
			//this.Message = "El Neto acumulado en los conceptos supera el Neto del comprobante";
		}
	}
}
