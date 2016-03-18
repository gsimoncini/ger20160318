using System;

using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.businessrules;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tsa_CondicionesDeVentaDet.
	/// </summary>
	public class tsa_CondicionesDeVentaDet
	{
		public tsa_CondicionesDeVentaDet()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		public static tsa_CondicionesDeVentaDetDataset GetList( string IdCondicionDeVenta)
		{
			return mz.erp.dataaccess.tsa_CondicionesDeVentaDet.GetListByIdCondicionDeVenta( IdCondicionDeVenta);
		}

		public static tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow GetByPK( string IdCondicionDeVenta, short Cuota )
		{
			return mz.erp.dataaccess.tsa_CondicionesDeVentaDet.GetByPk(IdCondicionDeVenta, Cuota);
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CondicionesDeVentasRow.
		/// </summary>
		public static tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow SetRowDefaultValues(tsa_CondicionesDeVentaDetDataset.tsa_CondicionesDeVentaDetRow row )
		{//MIRAR LOS VALORES DE INICIALIZACION
			row.IdCondicionDeVentaDet = Util.NewStringId(); 
			row.Cuota = 1;
			row.DiasVencimiento = 0;
			row.Porcentual = 100;		
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = 1;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
		
			return row;
		}


		/// <summary>
		/// ojooo, esto se usa para determinar en un texto los dias de vencimiento de cada una de las cuotas 
		/// de forma que la interfaz para el usuario sea mas sencilla y no se tenga q implementar 
		/// una grilla que es dificil de controlar
		/// </summary>
		/// <returns></returns>
		public string TextCuotas( string idCondicionDeVenta)
		{
			mz.erp.commontypes.data.tsa_CondicionesDeVentaDetDataset _data = GetList( idCondicionDeVenta);
				
			string dias = string.Empty;
			for(int i = 0 ; i< _data.tsa_CondicionesDeVentaDet.Rows.Count ; i++)
			{
				dias = dias + ',' + Convert.ToString(_data.tsa_CondicionesDeVentaDet.Rows[i]["DiasVencimiento"]);
			}
			if (dias != string.Empty && dias != null)
				return dias.Substring(1); //saco la primer coma
			else 
				return string.Empty;
		}
		
	}
}
