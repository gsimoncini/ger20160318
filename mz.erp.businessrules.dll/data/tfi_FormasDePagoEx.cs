using System;
using System.Collections;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tfi_FormasDePagoEx.
	/// </summary>
	public class tfi_FormasDePagoEx
	{
		public tfi_FormasDePagoEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region This block of functions has been deprecated momentarily
		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="data"></param>
		/// <param name="IdMonedaOrigen"></param>
		/// <param name="IdMonedaDestino"></param>
		/// <returns></returns>
		public static System.Data.DataRow GetValorCotizacion(tfi_FormasDePagoExDataset data, string IdMonedaOrigen, string IdMonedaDestino)
		{
			
			System.Data.DataRow row = null ; //mz.erp.dataaccess.tfi_FormasDePagoEx.GetValorCotizacion(data, IdMonedaOrigen, IdMonedaDestino);
			
			return row;
		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static  System.Data.DataRowCollection GetFormasDePagosGenerales(tfi_FormasDePagoExDataset data)
		{
			
			return mz.erp.dataaccess.tfi_FormasDePagoEx.GetFormasDePagosGenerales(data);
			
		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static System.Data.DataRowCollection GetComprobantesTesoreria(tfi_FormasDePagoExDataset data)
		{
			return  mz.erp.dataaccess.tfi_FormasDePagoEx.GetComprobantesTesoreria(data);
			
		}
		public static System.Data.DataRowCollection GetComprobantesTesoreria(tfi_FormasDePagoExDataset data, string IdCondicionDeVenta)
		{
			return  mz.erp.dataaccess.tfi_FormasDePagoEx.GetComprobantesTesoreria(data, IdCondicionDeVenta);
			
		}

		public static System.Data.DataRowCollection GetComprobantesTesoreria(tfi_FormasDePagoExDataset data, string IdCondicionDeVenta, string IdCuenta, string IdTipoDeComprobante)
		{
			return  mz.erp.dataaccess.tfi_FormasDePagoEx.GetComprobantesTesoreria(data, IdCondicionDeVenta, IdCuenta, IdTipoDeComprobante);
			
		}
		
		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static System.Data.DataRowCollection GetFormasDePagosEspecificas(tfi_FormasDePagoExDataset data)
		{
			return  mz.erp.dataaccess.tfi_FormasDePagoEx.GetFormasDePagosEspecificas(data);
			
		}

		public static FormasDePagos GetFormasDePago()//string IdMonedaReferencia
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data);
			System.Data.DataRowCollection formasDePagosGen=GetFormasDePagosGenerales(data);
			System.Data.DataRowCollection formasDePagosEsp=GetFormasDePagosEspecificas(data);
			FormasDePagos res= new FormasDePagos();
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
				string IdMoneda="";
				string IdComp="";
				string descComp=(string) rowCompTesoreria["Descripcion"];
				string IdFormaDePago="";
				bool Agrupado = (bool)rowCompTesoreria["Agrupado"];
				int Orden = 0;
				if(!rowCompTesoreria.IsNull("Orden"))
					Orden = Convert.ToInt32(rowCompTesoreria["Orden"]);
				if ( Agrupado)
				{
					string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
					IdComp= aux.Substring(0,aux.IndexOf("#"));
					IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
				}
				else IdComp= (string) rowCompTesoreria ["IdTDCompTesoreria"];
				ArrayList master = new ArrayList();
				if (Agrupado) master.AddRange(ProcesarFormasDePagoEspBilletes(formasDePagosEsp, IdComp, descComp,IdMoneda));
				else master.AddRange(ProcesarFormasDePagoEsp(formasDePagosEsp, IdComp, descComp ));
				if (Agrupado) master.AddRange(ProcesarFormasDePagoGenBilletes(formasDePagosGen, IdComp, descComp,IdMoneda));
				else master.AddRange(ProcesarFormasDePagoGen(formasDePagosGen, IdComp, descComp ));
				if (master.Count == 0 ) master.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
				foreach(FormaDePago fdp in master)
				{
					fdp.Agrupado = Agrupado;
					fdp.Orden = Orden;
					fdp.Cuotas=Convert.ToUInt16(rowCompTesoreria["Cuotas"]);
				}
				result.AddRange(master);
			}
			return result;
		}

		public static FormasDePagos GetFormasDePago( ArrayList ListaTDComTesoreria)//string IdMonedaReferencia
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data);
			System.Data.DataRowCollection formasDePagosGen=GetFormasDePagosGenerales(data);
			System.Data.DataRowCollection formasDePagosEsp=GetFormasDePagosEspecificas(data);
			FormasDePagos res= new FormasDePagos();
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
					string IdMoneda="";
					string IdComp="";
					string descComp=(string) rowCompTesoreria["Descripcion"];
					string IdFormaDePago="";
					int Orden = int.MaxValue;
					bool Agrupado = (bool)rowCompTesoreria["Agrupado"];
					
					if ( Agrupado)
					{
						string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
						IdComp= aux.Substring(0,aux.IndexOf("#"));
						IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
					}
					else IdComp= (string) rowCompTesoreria ["IdTDCompTesoreria"];
					if(!rowCompTesoreria.IsNull("Orden"))
						Orden = Convert.ToInt32(rowCompTesoreria["Orden"]);
					if(ListaTDComTesoreria.Contains(IdComp))
					{
					
				
						ArrayList master = new ArrayList();
						if (Agrupado) master.AddRange(ProcesarFormasDePagoEspBilletes(formasDePagosEsp, IdComp, descComp,IdMoneda));
						else master.AddRange(ProcesarFormasDePagoEsp(formasDePagosEsp, IdComp, descComp ));
						if (Agrupado) master.AddRange(ProcesarFormasDePagoGenBilletes(formasDePagosGen, IdComp, descComp,IdMoneda));
						else master.AddRange(ProcesarFormasDePagoGen(formasDePagosGen, IdComp, descComp ));
						if (master.Count == 0 ) master.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
						foreach(FormaDePago fdp in master)
						{
							fdp.Agrupado = Agrupado;
							fdp.Orden = Orden;
							fdp.Cuotas=Convert.ToUInt16(rowCompTesoreria["Cuotas"]);
						}
						result.AddRange(master);
					}
			}
			return result;
		}


		public static FormasDePagos GetFormasDePago(decimal valororigen, string ListaTDComTesoreria)
		{
			ArrayList aux = mz.erp.systemframework.Util.Parse(ListaTDComTesoreria, ",");
			FormasDePagos _fdp = GetFormasDePago(aux);
			
			foreach (FormaDePago _fp in _fdp )
			{
				
				_fp.ImporteConRecargo = (valororigen * _fp.Recargo/100)+valororigen;
				if(_fp.Cuotas != 0)
					_fp.ValorDeLaCuota = _fp.ImporteConRecargo / _fp.Cuotas ;
				else _fp.ValorDeLaCuota = _fp.ImporteConRecargo;
				
			}
			
			return _fdp;
		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <returns></returns>
		/// 


		public static FormasDePagos GetComprobantesTesoreria(string IdCondicionDeVenta, string IdCuenta, string IdTipoDeComprobante)
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data, IdCondicionDeVenta, IdCuenta,IdTipoDeComprobante);
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
				string IdMoneda="";
				string IdComp="";
				string descComp=(string) rowCompTesoreria["Descripcion"];
				string IdFormaDePago="";
				if ((bool)rowCompTesoreria["Agrupado"] )
				{
					string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
					IdComp= aux.Substring(0,aux.IndexOf("#"));
					IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
				}
				else
					IdComp=(string)rowCompTesoreria["IdTDCompTesoreria"];
				ArrayList master = new ArrayList();
				result.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
			}
			return result;
		}


		public static FormasDePagos GetComprobantesTesoreria(string IdCondicionDeVenta)
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data, IdCondicionDeVenta);
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
				string IdMoneda="";
				string IdComp="";
				string descComp=(string) rowCompTesoreria["Descripcion"];
				string IdFormaDePago="";
				if ((bool)rowCompTesoreria["Agrupado"] )
				{
					string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
					IdComp= aux.Substring(0,aux.IndexOf("#"));
					IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
				}
				else
					IdComp=(string)rowCompTesoreria["IdTDCompTesoreria"];
				ArrayList master = new ArrayList();
				result.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
			}
			return result;
		}

		public static FormasDePagos GetFormasDePago(string IdCondicionDeVenta)//string IdMonedaReferencia
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data, IdCondicionDeVenta);
			System.Data.DataRowCollection formasDePagosGen=GetFormasDePagosGenerales(data);
			System.Data.DataRowCollection formasDePagosEsp=GetFormasDePagosEspecificas(data);
			FormasDePagos res= new FormasDePagos();
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
				string IdMoneda="";
				string IdComp="";
				string descComp=(string) rowCompTesoreria["Descripcion"];
				string IdFormaDePago="";
				bool Agrupado = (bool)rowCompTesoreria["Agrupado"];
				if (Agrupado )
				{
					string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
					IdComp= aux.Substring(0,aux.IndexOf("#"));
					IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
				}
				else IdComp= (string) rowCompTesoreria ["IdTDCompTesoreria"];
				ArrayList master = new ArrayList();
				if (Agrupado) master.AddRange(ProcesarFormasDePagoEspBilletes(formasDePagosEsp, IdComp, descComp,IdMoneda));
				else master.AddRange(ProcesarFormasDePagoEsp(formasDePagosEsp, IdComp, descComp ));
					if (Agrupado) master.AddRange(ProcesarFormasDePagoGenBilletes(formasDePagosGen, IdComp, descComp,IdMoneda));
					else master.AddRange(ProcesarFormasDePagoGen(formasDePagosGen, IdComp, descComp ));
					if (master.Count == 0 ) master.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
				foreach(FormaDePago fdp in master)
				{
					fdp.Agrupado = Agrupado;
				}

				result.AddRange(master);
			}
		return result;
		}


		public static FormasDePagos GetFormasDePago(string IdCondicionDeVenta, string IdCuenta, string IdTipoDeComprobante)//string IdMonedaReferencia
		{
			FormasDePagos result = new FormasDePagos();
			tfi_FormasDePagoExDataset data= new tfi_FormasDePagoExDataset();
			System.Data.DataRowCollection comprobantes=GetComprobantesTesoreria(data, IdCondicionDeVenta, IdCuenta, IdTipoDeComprobante);
			System.Data.DataRowCollection formasDePagosGen=GetFormasDePagosGenerales(data);
			System.Data.DataRowCollection formasDePagosEsp=GetFormasDePagosEspecificas(data);
			FormasDePagos res= new FormasDePagos();
			foreach(System.Data.DataRow rowCompTesoreria in comprobantes)
			{
				string IdMoneda="";
				string IdComp="";
				string descComp=(string) rowCompTesoreria["Descripcion"];
				string IdFormaDePago="";
				bool Agrupado = (bool)rowCompTesoreria["Agrupado"];
				if (Agrupado )
				{
					string aux= (string)rowCompTesoreria["IdTDCompTesoreria"];
					IdComp= aux.Substring(0,aux.IndexOf("#"));
					IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
				}
				else IdComp= (string) rowCompTesoreria ["IdTDCompTesoreria"];
				ArrayList master = new ArrayList();
				if (Agrupado) master.AddRange(ProcesarFormasDePagoEspBilletes(formasDePagosEsp, IdComp, descComp,IdMoneda));
				else master.AddRange(ProcesarFormasDePagoEsp(formasDePagosEsp, IdComp, descComp ));
				if (Agrupado) master.AddRange(ProcesarFormasDePagoGenBilletes(formasDePagosGen, IdComp, descComp,IdMoneda));
				else master.AddRange(ProcesarFormasDePagoGen(formasDePagosGen, IdComp, descComp ));
				if (master.Count == 0 ) master.Add(Factory.GetFormaDePagoMaster(IdComp,descComp,IdMoneda,IdFormaDePago));
				foreach(FormaDePago fdp in master)
				{
					fdp.Agrupado = Agrupado;
				}

				result.AddRange(master);
			}
			return result;
		}
	
		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="formasDePagosEsp"></param>
		/// <param name="IdComp"></param>
		/// <param name="descComp"></param>
		/// <returns></returns>
		private static ArrayList ProcesarFormasDePagoEsp(System.Data.DataRowCollection col, string IdComp, string descComp )
		{	
			ArrayList result = new ArrayList();
			foreach(System.Data.DataRow row in col)
			{									
				if (IdComp.Equals(Convert.ToString( row["IdTDCompTesoreria"])))
				{
					result.Add(Factory.GetFormaDePago(row,descComp));
				}
				

			}
			return result;
		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="master"></param>
		/// <param name="col"></param>
		/// <param name="IdComp"></param>
		/// <param name="descComp"></param>
		/// <returns></returns>
		private static ArrayList ProcesarFormasDePagoGen(System.Data.DataRowCollection col, string IdComp, string descComp )
		{	

			ArrayList result = new ArrayList();
			foreach(System.Data.DataRow row in col)
			{									
				if (IdComp.Equals(Convert.ToString( row["IdTDCompTesoreria"])))
				{
					result.Add(Factory.GetFormaDePagoGen(row,descComp));
				}
				

			}
			return result;
	
		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="master"></param>
		/// <param name="col"></param>
		/// <param name="IdComp"></param>
		/// <param name="descComp"></param>
		/// <param name="IdMoneda"></param>
		/// <returns></returns>
		private static ArrayList ProcesarFormasDePagoGenBilletes(System.Data.DataRowCollection col, string IdComp, string descComp ,string IdMoneda)
		{	
			/*
			for(int i=0; i< col.Count; i++)
			{
					
				tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosGeneralesRow rowGen;
				rowGen=(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosGeneralesRow )col [i];
				if ((IdComp.Equals(rowGen.IdTDCompTesoreria)) && (IdMoneda.Equals(rowGen.IdMoneda)))
				{
					//es el primero de ese comprobante
					if (master == null) master = Factory.GetFormaDePago(rowGen,descComp,true);
					else 
					{
						//es el segunndo
						if(master.Detalle == null)
						{
							master = Factory.GetFormaDePagoMaster(master,rowGen.Descripcion);
							master.Detalle.Add(Factory.GetFormaDePago(rowGen,descComp));
			                                							
						}
						//hay mas de dos seguro
						else master.Detalle.Add(Factory.GetFormaDePago(rowGen,descComp));
									
					}	
					//Remueve la fila seleccionada, para dsiminuir los tiempos de busqueda
					col.Remove(rowGen);
					i--;
				}
				

			}
		return master;
		*/
			ArrayList result = new ArrayList();
			foreach(System.Data.DataRow row in col)
			{									
				if (IdComp.Equals(Convert.ToString( row["IdTDCompTesoreria"])) && (IdMoneda.Equals(Convert.ToString(row["IdMoneda"]))))
				{
					result.Add(Factory.GetFormaDePagoGen(row,descComp));
				}
				

			}
			return result;

		}

		/// <summary>
		/// This function has been deprecated momentarily
		/// </summary>
		/// <param name="formasDePagosEsp"></param>
		/// <param name="IdComp"></param>
		/// <param name="descComp"></param>
		/// <param name="IdMoneda"></param>
		/// <returns></returns>
		private static ArrayList ProcesarFormasDePagoEspBilletes(System.Data.DataRowCollection col, string IdComp, string descComp ,string IdMoneda)
		{	
			/*
			FormaDePago master= null;
			for(int i=0; i< formasDePagosEsp.Count; i++)
			{
					
				tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosRow rowFormaPagoEsp;
				rowFormaPagoEsp=(tfi_FormasDePagoExDataset.Pr_tfi_GetFormasDePagosRow )formasDePagosEsp[i];
				if ((IdComp.Equals(rowFormaPagoEsp.IdTDCompTesoreria)) && IdMoneda.Equals(rowFormaPagoEsp.IdMoneda))
				{
					//es el primero de ese comprobante
					if (master == null) master = Factory.GetFormaDePago(rowFormaPagoEsp,descComp,true);
					else 
					{
						//es el segunndo
						if(master.Detalle == null)
						{
							master = Factory.GetFormaDePagoMaster(master,rowFormaPagoEsp.Moneda);
							master.Detalle.Add(Factory.GetFormaDePago(rowFormaPagoEsp,descComp));
			                                							
						}
							//hay mas de dos seguro
						else master.Detalle.Add(Factory.GetFormaDePago(rowFormaPagoEsp,descComp));
									
					}		
					formasDePagosEsp.Remove(rowFormaPagoEsp);
					i--;
				}
				

			}
			return master;
			*/
			ArrayList result = new ArrayList();
			foreach(System.Data.DataRow row in col)
			{									
				if (IdComp.Equals(Convert.ToString( row["IdTDCompTesoreria"])) && (IdMoneda.Equals(Convert.ToString(row["IdMoneda"]))))
				{
					result.Add(Factory.GetFormaDePago(row,descComp));
				}
				

			}
			return result;
		}

		#endregion

		
	}
}