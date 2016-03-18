using System;
using mz.erp.commontypes.data;
using System.Collections;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Clase auxiliar estatica de calculo de impuestos.
	/// En el cálculo de impuestos intervienen las entidades cuenta, productos y comprobantes
	/// Cada impuesto interviene en los items del comprobante. Este se comportará de manera
	/// directa o indirecta pero el impuesto siempre debe pertenecer a un item.
	/// Si tuvieramos el caso de que alguien trabaje sin detalle en el comprobante de venta
	/// se deberia crear al menos un item para manejar los impuestos.
	/// </summary>
	public class FuncionesImpuestos
	{
		public FuncionesImpuestos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		/// <summary>
		/// Para una condición de aplicación. Por ejemplo obtener total impuestos aplicados al producto
		/// devuelve el total para los impuestos que cumplan esa condición.
		/// </summary>
		/// <param name="colleccionImpuestos">
		/// Colección de Impuestos
		/// </param>
		/// <param name="AplicadoA">
		/// Valor constante puede ser los que se definieron en el documento Aplicación de Impuestos variables a Comprobantes de Venta
		/// </param>
		/// <returns></returns>
		/// 

		public static decimal CalcularInversa (Impuestos colleccionImpuestos , decimal precio, string AplicadoA)
		{
				return CalcularInversa(ObtenerColeccionImpuestos(colleccionImpuestos, AplicadoA),precio);
		}

		
		public static decimal CalcularInversa (Impuestos colleccionImpuestos , decimal precio)
		{
			decimal valor = Convert.ToDecimal(0.00);
			foreach (Impuesto impuesto in colleccionImpuestos )
			{
				/*
				if(impuesto.Key.ToUpper().Equals("IVA"))
					valor = valor + precio / (1 + Convert.ToDecimal((Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva"))) /100);
				else 
					if(impuesto.Key.ToUpper().Equals("IVADIF"))
				
					valor = valor +  precio /(1 +  Convert.ToDecimal(Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva")/2) /100);
				*/
				if(impuesto.Alicuota != Convert.ToDecimal(0))
				{					
						/*if(impuesto.Key.ToUpper().Equals("IB") || impuesto.Key.ToUpper().Equals("IB RI"))
						{
							decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valor = valor + impuesto.Alicuota;//+ precio / (1 + impuesto.Alicuota / 100);
						}
						else valor = valor + impuesto.Alicuota;//+ precio / (1 + impuesto.Alicuota / 100);*/

					switch (impuesto.Key.ToUpper())
					{
						case "IB": 
						case "IB RI": 
							decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valor = valor + impuesto.Alicuota;								
							break;						
						case "IIVP":
						case "IICOMUN":
						case "IISUPER":
						case "IIPD":
						case "IIGO":
						case "IIKERO":
						case "IIGNC":
                        //German 20110524 - Tarea 0000140
                        case "TASAVP":
                        case "TASACOMUN":
                        case "TASASUPER":
                        case "TASAPD":
                        case "TASAGO":
                        case "TASAKERO":
                        case "TASAGNC":
                        //Fin German 20110524 - Tarea 0000140
                            //German 20110527 - Tarea 0000142
                            //valor = valor + imp.Alicuota;
                            precio = precio - impuesto.Alicuota;// Debido a que es un monto se resta
                            //Fin German 20110527 - Tarea 0000142
							 break;
						default:
                             //German 20110605 - Tarea 0000149
					        if(impuesto.DescripcionLarga.ToUpper().Equals("II"))
                                precio = precio - impuesto.Alicuota;// Debido a que es un monto se resta
                            else
                            //Fin German 20110605 - Tarea 0000149
							    valor = valor + impuesto.Alicuota;							
							break;
					}	
				}
				/*
				if(impuesto.Alicuota != Convert.ToDecimal(0))
					valor = valor + precio / (1 + impuesto.Alicuota / 100);
				*/
			}
			if(valor == 0) return precio;
			return precio / (Convert.ToDecimal(1.00) + valor / Convert.ToDecimal(100.00));
		}
		
		public static decimal CalcularInversa (Hashtable colleccionImpuestos , decimal precio)
		{
			decimal valor = 0;
			/*
			foreach (string Key in colleccionImpuestos.Keys )
			{
				
				if(Key.ToUpper().Equals("IVA"))
					valor = valor + precio / (1 + Convert.ToDecimal((Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva"))) /100);
				else 
					if(Key.ToUpper().Equals("IVADIF"))
					valor = valor +  precio /(1 +  Convert.ToDecimal(Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva"))/2 /100);
				
			}
			*/
			foreach(Impuesto imp in colleccionImpuestos.Values)
			{
				if(imp.Alicuota != Convert.ToDecimal(0))
				{					
						/*if(imp.Key.ToUpper().Equals("IB") || imp.Key.ToUpper().Equals("IB RI"))
						{
							decimal TotalNeto = imp.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valor = valor + imp.Alicuota ;//+ precio /(1 +  imp.Alicuota  /100);
						}
						else
							valor = valor + imp.Alicuota;// + precio /(1 +  imp.Alicuota  /100);*/
					switch (imp.Key.ToUpper())
					{
						case "IB": 
						case "IB RI": 
							decimal TotalNeto = imp.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valor = valor + imp.Alicuota;
							break;						
						case "IIVP":
						case "IICOMUN":
						case "IISUPER":
						case "IIPD":
						case "IIGO":
						case "IIKERO":
						case "IIGNC":
                        //German 20110524 - Tarea 0000140
                        case "TASAVP":
                        case "TASACOMUN":
                        case "TASASUPER":
                        case "TASAPD":
                        case "TASAGO":
                        case "TASAKERO":
                        case "TASAGNC":
                        //Fin German 20110524 - Tarea 0000140
                            //German 20110527 - Tarea 0000142
							//valor = valor + imp.Alicuota;
                            precio = precio - imp.Alicuota;// Debido a que es un monto se resta
                            //Fin German 20110527 - Tarea 0000142
							break;
						default:
                            //German 20110605 - Tarea 0000149
                            if (imp.DescripcionLarga.ToUpper().Equals("II"))
                                precio = precio - imp.Alicuota;// Debido a que es un monto se resta
                            else
                            //Fin German 20110605 - Tarea 0000149
							    valor = valor + imp.Alicuota;
							break;
					}		

				}

			}

							
		    if(valor == 0) return precio;
			return precio / (1 + valor / 100);
		}




		public static decimal ObtenerValorAplicado( Impuestos colleccionImpuestos, string AplicadoA )
		{
			decimal subtotal = 0;
			foreach (Impuesto imp in colleccionImpuestos )
			{
				if (imp.AplicadoA == AplicadoA)
				{
					subtotal+= imp.Valor;
				}
			}
			return subtotal;
		}

		/// <summary>
		/// Obtiene el total de la coleccion de impuestos.
		/// Deprecated. Se mantiene por compatibilidad
		/// </summary>
		/// <param name="colleccionImpuestos"></param>
		/// <returns></returns>
		public static decimal ObtenerValor( Impuestos colleccionImpuestos )
		{
			return colleccionImpuestos.Total;
		}

		/// <summary>
		/// Obtiene el total de la coleccion de impuestos condicionada a un filtro de aplicacion negada
		/// </summary>
		/// <param name="collectionImpuestos"></param>
		/// <param name="AplicadoA">
		/// Valor constante puede ser los que se definieron en el documento Aplicación de Impuestos variables a Comprobantes de Venta
		/// </param>
		/// <returns>
		/// La colección de impuestos filtrada
		/// </returns>
		public static Impuestos ObtenerColeccionImpuestosNoAplicados( Impuestos collectionImpuestos, string AplicadoA)
		{
			Impuestos impfiltrados = new Impuestos();
			foreach (Impuesto imp in collectionImpuestos )
			{
				if (imp.AplicadoA !=AplicadoA)
				{
					impfiltrados.Add( imp );
				}
			}
			return impfiltrados;
		}
		/// <summary>
		/// Obtiene el total de la coleccion de impuestos condicionada a un filtro de aplicacion negada
		/// </summary>
		/// <param name="collectionImpuestos"></param>
		/// <param name="AplicadoA">
		/// Valor constante puede ser los que se definieron en el documento Aplicación de Impuestos variables a Comprobantes de Venta
		/// </param>
		/// <returns>
		/// La coleccion de impuestos filtrada
		/// </returns>
		public static Impuestos ObtenerColeccionImpuestos( Impuestos collectionImpuestos, string AplicadoA)
		{
			Impuestos impfiltrados = new Impuestos();
			foreach (Impuesto imp in collectionImpuestos )
			{
				if (imp.AplicadoA == AplicadoA)
				{
					impfiltrados.Add( imp );
				}
			}
			return impfiltrados;
		}
		/***
		 * Esta funcion sirve para calcular el impuesto sobre un importe dado
		 * FALTA: MEJORAR para que ande bajo el calculo dinamico de impuestos
		 * **/

		public static decimal Calcular( Impuesto sender , decimal precio)
		{
			// Aca entro YO!!!

			//ComprobanteDeVenta miComprobante  = (ComprobanteDeVenta)comprobanteOrigne;
			/* Codigo de Ejemplo
			 * */
			bool activo = Variables.GetValueBool( "Debug.ActivaCalculoImpuestos");
			//activo = true;
			if (activo)
			{
				string s = ((Impuesto)sender).Formula;
				decimal d=0;

				try
				{
					/*Deberia pasarsele el precio*/
					d = Evaluator.EvaluateToDecimal( s, sender );
				}
				catch (Exception e)
				{
					d = 0;
				}
			
				return d;
			}
			else
			{
				Impuesto impuesto = ((Impuesto)sender);
				decimal valorimpuesto = 0;
				if(impuesto.Alicuota != Convert.ToDecimal(0))
				{
					/*if(impuesto.Key.ToUpper().Equals("IB") || impuesto.Key.ToUpper().Equals("IB RI"))
					{
						decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
						if(TotalNeto >= 50)
							valorimpuesto = precio * impuesto.Alicuota / 100;
					}
					else
						valorimpuesto = precio * impuesto.Alicuota / 100;*/
					switch (impuesto.Key.ToUpper())
					{
						case "IB": 
						case "IB RI": 
							decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valorimpuesto = precio * impuesto.Alicuota / 100;
							break;						
						case "IIVP":
						case "IICOMUN":
						case "IISUPER":
						case "IIPD":
						case "IIGO":
						case "IIKERO":
						case "IIGNC":
                        //German 20110524 - Tarea 0000140
                        case "TASAVP":
                        case "TASACOMUN":
                        case "TASASUPER":
                        case "TASAPD":
                        case "TASAGO":
                        case "TASAKERO":
                        case "TASAGNC":
                        //Fin German 20110524 - Tarea 0000140
							//valorimpuesto = precio * impuesto.Alicuota / 100;
							valorimpuesto = impuesto.Alicuota;
							break;
						default:
                            //German 20110605 - Tarea 0000149
                            if (impuesto.DescripcionLarga.ToUpper().Equals("II"))
                                valorimpuesto = impuesto.Alicuota;
                            else
                                //Fin German 20110605 - Tarea 0000149
                                valorimpuesto = precio * impuesto.Alicuota / 100;
							break;
					}		

				}


				/*
				if(impuesto.Key.ToUpper().Equals("IVA"))
				{
					valorimpuesto = Convert.ToDecimal(precio * (Convert.ToDecimal((Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva"))) /100));
				}
				else 
				{
					if(impuesto.Key.ToUpper().Equals("IVADIF"))
					{
						decimal alicuota = Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva");
						alicuota = Convert.ToDecimal(alicuota / 2);
						valorimpuesto = Convert.ToDecimal(precio * alicuota /100 );
					}
				}
				*/
				return valorimpuesto;
			}
				
				
			return 0;
		}

		/// <summary>
		/// Calcula un impuesto. Lo invoca cada impuesto al querer obtener su valor
		/// La formula de calculo es dinámica y es obtenida del RDBM y definida por el implementador
		/// </summary>
		/// <param name="sender">
		/// Sender de tipo Impuesto
		/// </param>
		/// <param name="FormulaDeCalculo"></param>
		/// <returns>
		/// 
		/// </returns>
		/// 


		public static decimal Calcular( Impuesto sender )
		{
			// Aca entro YO!!!

			//ComprobanteDeVenta miComprobante  = (ComprobanteDeVenta)comprobanteOrigne;
			/* Codigo de Ejemplo
			 * */
			bool activo = Variables.GetValueBool( "Debug.ActivaCalculoImpuestos");
			//activo = true;
			if (activo)
			{
				string s = ((Impuesto)sender).Formula;
				decimal d=0;

				try
				{
					d = Evaluator.EvaluateToDecimal( s, sender );
				}
				catch (Exception e)
				{
					d = 0;
				}
			
				return d;
			}
			else
			{
				Impuesto impuesto = ((Impuesto)sender);
				decimal precio = impuesto.Impuestos.ItemComprobante.Precio;
				decimal valorimpuesto = 0;
				if(impuesto.Alicuota != Convert.ToDecimal(0))
				{
					/*if(impuesto.Key.ToUpper().Equals("IB") || impuesto.Key.ToUpper().Equals("IB RI"))
					{
						decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
						if(TotalNeto >= 50)
							valorimpuesto = precio * impuesto.Alicuota / 100;
					}
					else
						valorimpuesto = precio * impuesto.Alicuota / 100;*/
					switch (impuesto.Key.ToUpper())
					{
						case "IB": 
						case "IB RI": 
							decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
							if(TotalNeto >= 50)
								valorimpuesto = precio * impuesto.Alicuota / 100;
							break;						
						case "IIVP":
						case "IICOMUN":
						case "IISUPER":
						case "IIPD":
						case "IIGO":
						case "IIKERO":
						case "IIGNC":
                        //German 20110524 - Tarea 0000140
                        case "TASAVP":
                        case "TASACOMUN":
                        case "TASASUPER":
                        case "TASAPD":
                        case "TASAGO":
                        case "TASAKERO":
                        case "TASAGNC":
                        //Fin German 20110524 - Tarea 0000140
							//valorimpuesto = precio * impuesto.Alicuota / 100;
							valorimpuesto = impuesto.Alicuota;
							break;
						default:	
					        						
                            //German 20110605 - Tarea 0000149
                            if (impuesto.DescripcionLarga.ToUpper().Equals("II"))
                                valorimpuesto = impuesto.Alicuota;
                            else
                                //Fin German 20110605 - Tarea 0000149
                                valorimpuesto = precio * impuesto.Alicuota / 100;
							break;
					}			
				}
				/*
				if(impuesto.Key.ToUpper().Equals("IVA"))
				{
					valorimpuesto = Convert.ToDecimal(precio * (Convert.ToDecimal((Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva"))) /100));
				}
				else 
				{
					if(impuesto.Key.ToUpper().Equals("IVADIF"))
					{
						decimal alicuota = Variables.GetValueLong("Contabilidad.Impuestos.AlicuotaIva");
						alicuota = Convert.ToDecimal(alicuota / 2);
						valorimpuesto = Convert.ToDecimal(precio * alicuota /100 );
					}
				}
				*/
				return valorimpuesto;
			}
				
				
			return 0;
		}
		/*public void pavada() 
		{

			//Calculo de II tomando alicuota como monto fijo
			if (sender.GetType() == typeof(Impuestos)  )
			{  
				Impuesto imp = ( Impuesto )sender;  
				ItemComprobante item = imp.Impuestos.ItemComprobante;  
				ItemsComprobantes items = item.ItemsComprobantes;  
				ComprobanteDeVenta comprobante = items.ComprobanteDeVenta;  				
				return imp.Alicuota;
			}  
			else  
			{  
				return 0;  
			}
		}*/


		public static System.Collections.Hashtable ObtenerFormulas( ArrayList Impuestos)                             
		{                                                                                                                                                         
			System.Collections.Hashtable formulas = new System.Collections.Hashtable();                                                                            
			foreach (string IdImp in Impuestos )                                                                                      
			{                                 
				tsy_ImpuestosDataset.tsy_ImpuestosRow row = mz.erp.businessrules.tsy_Impuestos.GetByPk(IdImp);                                                                                                    
				Impuesto imp  = new Impuesto(row.IdImpuesto, row.Impuesto, row.Descripcion, row.DescripcionCorta, row.DescripcionLarga, row.IdTipoDeConcepto, row.FormulaDeCalculo, row.Alicuota1);
				formulas.Add(row.Impuesto,imp);                                                                                                  
			}                                                                                                                                                      
			return formulas;                                                                                                                                       
		} 

		                                                                                                                                                        
		public static System.Collections.Hashtable ObtenerFormulas( string unaCuenta, string unTipoDeComprobante, string unProducto )                             
		{                                                                                                                                                         
			System.Collections.Hashtable formulas = new System.Collections.Hashtable();                                                                            
		                                                                                                                                                       
			tsy_ImpuestosExDataset.tsy_ImpuestosExDataTable table = mz.erp.businessrules.tsy_ImpuestosEx.GetList( unProducto, unaCuenta, unTipoDeComprobante );    
			foreach (tsy_ImpuestosExDataset.tsy_ImpuestosExRow row in table )                                                                                      
			{                                                                                                                                                      
				Impuesto imp  = new Impuesto(row.IdImpuesto, row.Impuesto, row.Descripcion, row.DescripcionCorta, row.DescripcionLarga, row.AplicadoA, row.FormulaDeCalculo, row.Alicuota);
				formulas.Add(row.Impuesto,imp);                                                                                                  
			}                                                                                                                                                      
			return formulas;                                                                                                                                       
		} 
		                                                                                                                                                        
                                                                                                                                                  
		public static decimal Calcular( System.Collections.Hashtable formulas, object sender )                                                                  
		{                                                                                                                                                         
			bool activo = Variables.GetValueBool( "Debug.ActivaCalculoImpuestos");                                                                                 
			if (activo)                                                                                                                                            
			{                                                                                                                                                      
				decimal d=0;                                                                                                                                        
				foreach (Impuesto imp in formulas.Values)                                                                                                                
				{
					try                                                                                                                                              
					{                                                                                                                                                
						d = d+Evaluator.EvaluateToDecimal( imp.Formula, imp  );                                                                                         
					}                                                                                                                                                
					catch (Exception e)                                                                                                                              
					{                                                                                                                                                
						d = d+0;                                                                                                                                      
					}                                                                                                                                                

				}                                                                                                                                                             
				return d;                                                                                                                                           
			}
			else
			{

                //German 20110527 - Tarea 0000142
                /*
				decimal d=0;  
                
				decimal precio = Convert.ToDecimal(sender);
				try
				{
					foreach(Impuesto imp in formulas.Values)
					{
						if(imp.Alicuota != Convert.ToDecimal(0))
						{
							
								if(imp.Key.ToUpper().Equals("IB") || imp.Key.ToUpper().Equals("IB RI"))
								{
									decimal TotalNeto = imp.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
									if(TotalNeto >= 50)
										d = d + precio * imp.Alicuota / 100;
								}
								else 
									d = d + precio * imp.Alicuota / 100;
						}
					}
				}
				catch(Exception e){ d = d;}                                           
				return d; 
                 */
                decimal valorimpuesto = 0;
                foreach (Impuesto impuesto in formulas.Values)
                {
                    decimal precio = Convert.ToDecimal(sender); ;
                    
                    if (impuesto.Alicuota != Convert.ToDecimal(0))
                    {
                        
                        switch (impuesto.Key.ToUpper())
                        {
                            case "IB":
                            case "IB RI":
                                /*
                                decimal TotalNeto = impuesto.Impuestos.ItemComprobante.ItemsComprobantes.ComprobanteDeVenta.TotalNetoAPercibirIB;
                                if (TotalNeto >= 50)
                                    valorimpuesto = precio * impuesto.Alicuota / 100;
                                 */
                                valorimpuesto = valorimpuesto + 0;
                                break;
                            case "IIVP":
                            case "IICOMUN":
                            case "IISUPER":
                            case "IIPD":
                            case "IIGO":
                            case "IIKERO":
                            case "IIGNC":
                            //German 20110524 - Tarea 0000140
                            case "TASAVP":
                            case "TASACOMUN":
                            case "TASASUPER":
                            case "TASAPD":
                            case "TASAGO":
                            case "TASAKERO":
                            case "TASAGNC":
                                //Fin German 20110524 - Tarea 0000140
                                //valorimpuesto = precio * impuesto.Alicuota / 100;
                                valorimpuesto = valorimpuesto +  impuesto.Alicuota;
                                break;
                            default:
                                					
                            //German 20110605 - Tarea 0000149
                            if (impuesto.DescripcionLarga.ToUpper().Equals("II"))
                                valorimpuesto = valorimpuesto + impuesto.Alicuota;
                            else
                                //Fin German 20110605 - Tarea 0000149
                                valorimpuesto = valorimpuesto +  (precio * impuesto.Alicuota / 100);
                                break;
                        }
                    }
                  
                }
				return valorimpuesto;
                //Fin German 20110527 - Tarea 0000142
				                                                                                                                                          
			}                                                                                                                                   
			return 0;                                                                                                                                          
		}  
		                                                                                                                                                      
		  
	}
}
