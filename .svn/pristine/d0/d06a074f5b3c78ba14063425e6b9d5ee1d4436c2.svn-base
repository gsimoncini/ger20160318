using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Data;
using mz.erp.dbhelper;
using mz.erp.commontypes;
using mz.erp.commontypes.data;



namespace mz.erp.businessrules
{
	#region clases auxiliares

	/*
	public class FamiliaTDCompTesoreria
	{
		private string _key = string.Empty;
		private string _description = string.Empty;

		public string Key
		{
			get{return _key;}
			set{_key = value;}
        }

		public string Description
		{
			get {return _description;}
			set{_description = value;}
		}
	}
	*/
		public class MAPStaticInfoItem
		{
			#region constructor
			public MAPStaticInfoItem()
			{
			}
			#endregion

			#region variables
			string key = string.Empty;
			string valor = string.Empty; 
			#endregion
			
			#region acceso a variables
			public  string Key
			{
				set{ key = value;}
				get{ return key;}
			}
			public  string Valor
			{
				set{ valor = value;}
				get{ return valor;}
			}
			#endregion

		}
		

		public class MAPStaticInfoHeader
		{
			#region constructores
			public MAPStaticInfoHeader()
			{
			}
			public MAPStaticInfoHeader( SortedList hash)
			{
				
				foreach( string key in hash.Keys)
				{
					MAPStaticInfoItem item = new MAPStaticInfoItem();
					item.Key = key;
					item.Valor = Convert.ToString(hash[key]);
					arregloItems.Add(item);
				}
			}
			#endregion

			#region variables y acceso a variables 
			
			ArrayList arregloItems = new ArrayList();
			
			public MAPStaticInfoItem[] ArregloItems
			{
				get
				{
					return (MAPStaticInfoItem[])arregloItems.ToArray(typeof(MAPStaticInfoItem));
				}
				set
				{
					arregloItems.AddRange(value);
				}
			}
			#endregion
		}

	
	#endregion
	


		public class MAPStaticInfo
		{
			#region variables

			
			
			static string pathFDP = mz.erp.systemframework.Util.ResourcePath() + @"\Resources\XML\MAPStaticInfoFDP.xml";
			static string pathBDFDP = mz.erp.systemframework.Util.ResourcePath() + @"\Resources\XML\MAPStaticInfoBDFDP.xml";			
			static string pathFamilia = mz.erp.systemframework.Util.ResourcePath() + @"\Resources\XML\MAPStaticInfoFamilia.xml";			
			
			private static MAPStaticInfoHeader mapH = new MAPStaticInfoHeader();

			private static System.Collections.SortedList _nameFamilia = new SortedList();
			private static System.Collections.SortedList _nameFDP = new SortedList();
			private static System.Collections.SortedList _nameFDPFamilia = new SortedList();
			private static System.Collections.SortedList _nameBDFDP = new SortedList();
			private static System.Collections.SortedList _nameCV = new SortedList();

			private static System.Data.DataSet _dataFDP = null;
			private static System.Data.DataSet _dataFamiliaFDPEntidades = null;

			private static DataTable _tableFamiliasTDCompTesoreria = new DataTable();

			

			private static bool _loaded = false;
			
			#endregion
		
			#region constructores
			public MAPStaticInfo()
			{
				
			}
			#endregion

			#region metodos privados

			public static DataTable GetTableFamiliasTDCompTesoreria()
			{
				if(!_loaded)
				{
					DeclareTypes();
				}
				return _tableFamiliasTDCompTesoreria;
				
			}
		
			//Ver capaz hay q cargar para la familia Cheques Diferidos _DP_
			private static void DeclareTypes()
			{
				//mapH = Read( path );
				/*
				foreach (MAPStaticInfoItem item in mapH.ArregloItems)
				{
					lista.Add(item.Key, item.Valor);
				}
				*/
				if( !_loaded)
				{
					_tableFamiliasTDCompTesoreria = new DataTable();
					_tableFamiliasTDCompTesoreria.Columns.Add("Key");
					_tableFamiliasTDCompTesoreria.Columns.Add("Description");
					DataRow row0 = _tableFamiliasTDCompTesoreria.NewRow();
					row0["Key"] = "_TD_";
					row0["Description"] = "Tarjetas de Débito";
					_tableFamiliasTDCompTesoreria.Rows.Add(row0);
					DataRow row1 = _tableFamiliasTDCompTesoreria.NewRow();
					row1["Key"] = "_TC_";
					row1["Description"] = "Tarjetas de Crédito";
					_tableFamiliasTDCompTesoreria.Rows.Add(row1);
					DataRow row2 = _tableFamiliasTDCompTesoreria.NewRow();
					row2["Key"] = "_DT_,_D_";
					row2["Description"] = "Cheques Diferidos";
					_tableFamiliasTDCompTesoreria.Rows.Add(row2);
					DataRow row3 = _tableFamiliasTDCompTesoreria.NewRow();
					row3["Key"] = "_T_,_C_";
					row3["Description"] = "Cheques";
					_tableFamiliasTDCompTesoreria.Rows.Add(row3);
					DataRow row4 = _tableFamiliasTDCompTesoreria.NewRow();
					row4["Key"] = "_RET_";
					row4["Description"] = "Retenciones";
					_tableFamiliasTDCompTesoreria.Rows.Add(row4);
					DataRow row5 = _tableFamiliasTDCompTesoreria.NewRow();
					row5["Key"] = string.Empty;
					row5["Description"] = string.Empty;
					_tableFamiliasTDCompTesoreria.Rows.Add(row5);
					_dataFDP = mz.erp.businessrules.tui_ConfiguracionFormasDePago.GetList();
					_dataFamiliaFDPEntidades = mz.erp.businessrules.tui_ConfiguracionFamiliaFDPEntidades.GetList();
					_nameBDFDP.Clear();
					_nameFamilia.Clear();
					_nameFDP.Clear();
					_nameFDPFamilia.Clear();
					foreach(DataRow row in _dataFDP.Tables[0].Rows)
					{
						string IdTDCompTesoreria = Convert.ToString(row["IdTDCompTesoreria"]);
						string ClaveCorta = Convert.ToString(row["ClaveCorta"]);
						string ClaveLarga = Convert.ToString(row["ClaveLarga"]);
						string Familia = Convert.ToString(row["Familia"]);
						_nameFDP.Add(IdTDCompTesoreria, ClaveLarga);
						_nameBDFDP.Add(IdTDCompTesoreria, ClaveCorta);
						_nameFDPFamilia.Add(IdTDCompTesoreria, Familia);
					}
					foreach(DataRow row in _dataFamiliaFDPEntidades.Tables[0].Rows)
					{
						string IdEntidad = Convert.ToString(row["IdEntidad"]);
						string Familia = Convert.ToString(row["Familia"]);
						_nameFamilia.Add(IdEntidad,Familia);
					}
					_loaded = true;
				}

		}
		
			private static void DeclareTypesCV()
			{				
				_nameCV.Add( "Cuenta Corriente",	"3" );			
			}

			#region viejo
			//si mandan la descripcion
			/*_nameFDP.Add( "Tarjeta de Crédito",	"TarjetaDeCredito" );
				_nameFDP.Add( "Tarjeta de Débito", "TarjetaDeDebito" );			
				_nameFDP.Add( "Efectivo", "Efectivo" );			
				_nameFDP.Add( "Cheque de Terceros",  "ChequeDeTerceros") ;
				_nameFDP.Add( "Cheque del Cliente",  "ChequeDelCliente" );
				_nameFDP.Add( "Cheque Diferido de Terceros", "ChequeDiferidoDeTerceros" );
				_nameFDP.Add( "Cheque Diferido del Cliente", "ChequeDiferidoDelCliente" );
				_nameFDP.Add( "Tarjeta de Crédito - CUOTAS", "TarjetaDeCreditoCuotas" );
				_nameFDP.Add( "Retenciones", "Retenciones" );
				_nameFDP.Add( "Tarjeta de Crédito - 1 CUOTA", "TarjetaDeCredito1CUOTA" );
				_nameFDP.Add( "Tarjeta de Crédito - 2 CUOTAS", "TarjetaDeCredito2CUOTAS" );
				_nameFDP.Add( "Tarjeta de Crédito - 3 CUOTAS", "TarjetaDeCredito3CUOTAS" );
				_nameFDP.Add( "Tarjeta de Crédito - 6 CUOTAS", "TarjetaDeCredito6CUOTAS" );
				_nameFDP.Add( "Tarjeta de Crédito - 12 CUOTAS", "TarjetaDeCredito12CUOTAS" );

				//si mandan el id
				_nameFDP.Add( "2","TarjetaDeCredito" );
				_nameFDP.Add( "3","TarjetaDeDebito" );
				_nameFDP.Add( "4","Efectivo" );
				_nameFDP.Add( "5","ChequeDeTerceros") ;
				_nameFDP.Add( "6","ChequeDelCliente" );
				_nameFDP.Add( "7","ChequeDiferidoDeTerceros" );
				_nameFDP.Add( "8","ChequeDiferidoDelCliente" );	
				_nameFDP.Add( "9","TarjetaDeCreditoCuotas" );
				_nameFDP.Add( "10","Retenciones");
				_nameFDP.Add( "11","TarjetaDeCredito1CUOTA");
				_nameFDP.Add( "12","TarjetaDeCredito2CUOTAS");
				_nameFDP.Add( "13","TarjetaDeCredito3CUOTAS");
				_nameFDP.Add( "14","TarjetaDeCredito6CUOTAS");
				_nameFDP.Add( "15","TarjetaDeCredito12CUOTAS");
				
			
				_nameBDFDP.Add( "Tarjeta de Crédito",	"_TC_" );
				_nameBDFDP.Add( "Tarjeta de Débito", "_TD_" );			
				_nameBDFDP.Add( "Efectivo", "_E_" );			
				_nameBDFDP.Add( "Cheque de Terceros",  "_T_") ;
				_nameBDFDP.Add( "Cheque del Cliente",  "_C_" );
				_nameBDFDP.Add( "Cheque Diferido de Terceros", "_DT_" );
				_nameBDFDP.Add( "Cheque Diferido del Cliente", "_D_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - CUOTAS", "_TCCUO_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - 1 CUOTA", "_TCCUO_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - 2 CUOTAS", "_TCCUO_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - 3 CUOTAS", "_TCCUO_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - 6 CUOTAS", "_TCCUO_" );
				_nameBDFDP.Add( "Tarjeta de Crédito - 12 CUOTAS", "_TCCUO_" );
				//si mandan el id
				_nameBDFDP.Add( "2","_TC_" );
				_nameBDFDP.Add( "3","_TD_" );
				_nameBDFDP.Add( "4","_E_" );
				_nameBDFDP.Add( "5","_T_") ;
				_nameBDFDP.Add( "6","_C_" );
				_nameBDFDP.Add( "7","_DT_" );
				_nameBDFDP.Add( "8","_D_" );	
				_nameBDFDP.Add( "9","_TCCUO_" );
				_nameBDFDP.Add( "10","_RET_");
				_nameBDFDP.Add( "11","_TCCUO_" );
				_nameBDFDP.Add( "12","_TCCUO_" );
				_nameBDFDP.Add( "13","_TCCUO_" );
				_nameBDFDP.Add( "14","_TCCUO_" );
				_nameBDFDP.Add( "15","_TCCUO_" );
				
				_nameFamilia.Add("1"	,"Tarjeta");
				_nameFamilia.Add("14"	,"Tarjeta");
				_nameFamilia.Add("15"	,"Tarjeta");
				_nameFamilia.Add("16"	,"Tarjeta");
				_nameFamilia.Add("18"	,"Tarjeta");
				_nameFamilia.Add("19"	,"Tarjeta");
				_nameFamilia.Add("20"	,"Tarjeta");
				_nameFamilia.Add("21"	,"Tarjeta");
				_nameFamilia.Add("22"	,"Tarjeta");
				_nameFamilia.Add("23"	,"Tarjeta");
				_nameFamilia.Add("24"	,"Tarjeta");
				_nameFamilia.Add("25"	,"Tarjeta");
				_nameFamilia.Add("26"	,"Cheque");
				_nameFamilia.Add("27"	,"Cheque");
				_nameFamilia.Add("28"	,"Cheque");
				_nameFamilia.Add("29"	,"Cheque");
				_nameFamilia.Add("30"	,"Cheque");
				_nameFamilia.Add("31"	,"Cheque");
				_nameFamilia.Add("32"	,"Cheque");
				_nameFamilia.Add("33"	,"Cheque");
				_nameFamilia.Add("34"	,"Cheque");
				_nameFamilia.Add("35"	,"Cheque");
				_nameFamilia.Add("36"	,"Cheque");
				_nameFamilia.Add("37"	,"Cheque");
				_nameFamilia.Add("38"	,"Cheque");
				_nameFamilia.Add("39"	,"Cheque");
				_nameFamilia.Add("40"	,"Cheque");
				_nameFamilia.Add("41"	,"Cheque");
				_nameFamilia.Add("42"	,"Cheque");
				_nameFamilia.Add("43"	,"Cheque");
				_nameFamilia.Add("44"	,"Cheque");
				_nameFamilia.Add("45"	,"Cheque");
				_nameFamilia.Add("46"	,"Cheque");
				_nameFamilia.Add("47"	,"Cheque");
				_nameFamilia.Add("48"	,"Cheque");
				_nameFamilia.Add("49"	,"Cheque");
				_nameFamilia.Add("50"	,"Cheque");
				_nameFamilia.Add("51"	,"Cheque");
				_nameFamilia.Add("52"	,"Cheque");
				_nameFamilia.Add("53"	,"Cheque");
				_nameFamilia.Add("54"	,"Cheque");
				_nameFamilia.Add("55"	,"Cheque");
				_nameFamilia.Add("56"	,"Cheque");
				_nameFamilia.Add("57"	,"Cheque");
				_nameFamilia.Add("58"	,"Cheque");
				_nameFamilia.Add("59"	,"Cheque");
				_nameFamilia.Add("60"	,"Cheque");
				_nameFamilia.Add("61"	,"Cheque");
				_nameFamilia.Add("62"	,"Cheque");
				_nameFamilia.Add("63"	,"Cheque");
				_nameFamilia.Add("64"	,"Cheque");
				_nameFamilia.Add("65"	,"Cheque");
				_nameFamilia.Add("66"	,"Cheque");
				_nameFamilia.Add("67"	,"Cheque");
				_nameFamilia.Add("68"	,"Cheque");

			}
				

			#endregion
			*/
		
			

			
		
			
		
			#endregion
			#endregion
			
			#region metodos publicos
			
			/*
			public static void AddFDP(string id, string descripcion, string mapeo)
			{
				_nameFDP.Add(id, mapeo);
				_nameFDP.Add(descripcion, mapeo);
				Save(_nameFDP, pathFDP);
			}
			public static void AddBDFDP(string id, string descripcion, string Tipo)
			{
				switch ( Tipo )
				{
					case "Cheque":
					{
						Tipo = "_DT_";
						break;
					}
					case "Tarjeta":
					{
						
						Tipo = "_TC_";
						break;
					}
					case "Retención":
					{
						
						Tipo = "_RET_";
						break;
					}
					default :
					{
						Tipo = "_";
						break;
					}	
				}
				_nameBDFDP.Add(id, Tipo);
				_nameBDFDP.Add(descripcion, Tipo);
				Save(_nameBDFDP, pathBDFDP);
			}

			public static void AddFamilia (string idEntidad, string familia)
			{
				_nameFamilia.Add(idEntidad,familia);
				Save(_nameFamilia, pathFamilia);
			}
		
			*/
			
			public static tui_ConfiguracionFormasDePagoDataset Save(string IdTDCompTedsoreria, string Descripcion, string Familia, string ClaveCorta, string IdTDCompTedsoreriaOriginal)
			{
				tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row = null;
				if(IdTDCompTedsoreria != null)
					row = mz.erp.businessrules.tui_ConfiguracionFormasDePago.GetByPk(IdTDCompTedsoreria);
				/*string ClaveCorta = string.Empty;*/
				string ClaveLarga =  systemframework.Util.RemoveSpaces(Descripcion);
			/*	switch ( Familia )
				{
					case "Cheque":
					{
						ClaveCorta = "_DT_";
						break;
					}
					case "Tarjeta":
					{
						
						ClaveCorta = "_TC_";
						break;
					}
					case "Retención":
					{
						
						ClaveCorta = "_RET_";
						break;
					}
					default :
					{
						ClaveCorta = "_";
						break;
					}	
				}*/

				tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow rowO = mz.erp.businessrules.tui_ConfiguracionFormasDePago.GetByPk(IdTDCompTedsoreriaOriginal);
				
				tui_ConfiguracionFormasDePagoDataset data = new tui_ConfiguracionFormasDePagoDataset();
				if(row != null)
				{
					/*
					row["ClaveCorta"] = ClaveCorta;
					row["ClaveLarga"] = ClaveLarga;
					row["Familia"] = Familia;
					data.Tables[0].ImportRow(row);
					*/
				}
				else
				{
					row = data.tui_ConfiguracionFormasDePago.Newtui_ConfiguracionFormasDePagoRow();
					row.IdTDCompTesoreria = mz.erp.systemframework.Util.NewStringId(); 
					row.ClaveCorta = ClaveCorta;
					row.ClaveLarga = ClaveLarga;
					row.Familia = Familia;
					row.Activo = true;
					row.FechaCreacion = DateTime.Now;
					row.IdConexionCreacion = Security.IdConexion;
					//row.UltimaModificacion = null;
					row.IdConexionUltimaModificacion = Security.IdConexion;
					row.IdReservado = 1;
					row.RowId = Guid.Empty;
					row.IdEmpresa = Security.IdEmpresa;
					row.IdSucursal = Security.IdSucursal;
					row.IdControlDeCajasFamiliasComprobanteTesoreria = rowO.IdControlDeCajasFamiliasComprobanteTesoreria;
					data.tui_ConfiguracionFormasDePago.Addtui_ConfiguracionFormasDePagoRow(row);
				}
				return data;
			}
			//Solo cuando se da de alta porq nunca se le cambia el tipo de comprobante,al q pertenece, solo la descripcion, etc
			public static tfi_AgrupTDCompTesoreriaDataset Save(string IdTDCompTedsoreria, string jerarquia)
			{
				tfi_AgrupTDCompTesoreriaDataset.tfi_AgrupTDCompTesoreriaRow row = null;
				tfi_AgrupTDCompTesoreriaDataset data = new tfi_AgrupTDCompTesoreriaDataset();
				row = data.tfi_AgrupTDCompTesoreria.Newtfi_AgrupTDCompTesoreriaRow();
				row.IdTDCompTesoreria = mz.erp.systemframework.Util.NewStringId(); 
				row.Jerarquia=jerarquia;
				row.FechaCreacion = DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				//row.UltimaModificacion = null;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 1;
				row.RowId = Guid.Empty;
				row.IdEmpresa = Security.IdEmpresa;
				//row.IdSucursal = Security.IdSucursal;
				data.tfi_AgrupTDCompTesoreria.Addtfi_AgrupTDCompTesoreriaRow(row);
		
				return data;
			}

			public static void Reset()
			{
				_loaded = false;
			}

			public static string GetFamilia(string IdTDCompTesoreria)
			{
				if(!_loaded)
				{
					DeclareTypes();
				}
				if(_nameFDPFamilia.ContainsKey(IdTDCompTesoreria))
					return Convert.ToString(_nameFDPFamilia[IdTDCompTesoreria]);
				return string.Empty;
			}
			public static string GetIdEntidades(string familia)
			{
				//retorno un string con una lista de todos los iddeentidades de una familia determinada
				string aux = string.Empty;
				if(!_loaded)
				{
					//DeclareTypes(pathFamilia, _nameFamilia);
					DeclareTypes();
				}
				if (_nameFamilia.ContainsValue(familia))
				{
					for (int i = 0 ; i < _nameFamilia.Count; i++)
					{
						if(Convert.ToString(_nameFamilia.GetValueList()[i]).Equals(familia))
							aux = aux +","+Convert.ToString(_nameFamilia.GetKeyList()[i]);
					}
				}
				if (familia.Equals(string.Empty))
				{
					for (int i = 0 ; i < _nameFamilia.Count; i++)
					{
						aux = aux +","+Convert.ToString(_nameFamilia.GetKeyList()[i]);
					}
				}
				if(aux != null && aux != string.Empty)
					return aux.Substring(1); //saco la primer coma
				else
					return string.Empty;
			}

			
			public static string GetFDP(string key)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathFDP , _nameFDP);
					DeclareTypes();
				}
				if (_nameFDP.Contains(key))
					return (string)_nameFDP[key];
				else
					return "";
			}
		
			public static string GetBDFDP(string key)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				if (_nameBDFDP.Contains(key))
					return (string)_nameBDFDP[key];
				else
					return "";
			}

			public static string GetIdCV(string key)
			{
				if (_nameCV.Count == 0)
				{
					DeclareTypesCV();
				}
				if (_nameCV.Contains(key))
					return (string)_nameCV[key];
				else
					return "";
			}
				
		
			public static bool PertenceARetenciones(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (
					_nameBDFDP[id].Equals("_RET_")
					));
			}

			public static bool PertenceFamiliaARetenciones(string familia)
			{
				string[] keys = familia.Split(new char[]{','});
				bool ok = false;
				foreach(string key in keys)
				{
					ok = ok || key.Equals("_RET_");
				}
				return ok;
			}
		
			public static bool PerteneceFamiliaACheque(string familia)
			{
				string[] keys = familia.Split(new char[]{','});
				bool ok = false;
				foreach(string key in keys)
				{
					ok = ok || key.Equals("_D_")|| key.Equals("_T_") || key.Equals("_DT_") || key.Equals("_C_");
				}
				return ok;
			}

			public static bool PerteneceFamiliaATarjeta(string familia)
			{
				string[] keys = familia.Split(new char[]{','});
				bool ok = false;
				foreach(string key in keys)
				{
					ok = ok || key.Equals("_TCCUO_")|| key.Equals("_TC_") || key.Equals("_TD_");
				}
				return ok;
			}

			public static bool PerteneceATerceros(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (
					_nameBDFDP[id].Equals("_T_")
					|| _nameBDFDP[id].Equals("_DT_")));
			}

			public static bool PerteneceAPropio(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (_nameBDFDP[id].Equals("_DP_")));
				
			}
			
			public static bool PerteneceATarjeta(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (
					_nameBDFDP[id].Equals("_TC_")
					|| _nameBDFDP[id].Equals("_TD_")
					|| _nameBDFDP[id].Equals("_TCCUO_")));
			}

			public static bool PerteneceACheque(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (
					_nameBDFDP[id].Equals("_T_")
					|| _nameBDFDP[id].Equals("_DT_")
					|| _nameBDFDP[id].Equals("_C_")
					|| _nameBDFDP[id].Equals("_D_")|| _nameBDFDP[id].Equals("_DP_")));
			}
					
		
			public static bool ChequeDiferido (string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (
					_nameBDFDP[id].Equals("_D_")
					|| _nameBDFDP[id].Equals("_DT_")
					));
			}

			public static bool PerteneceAEfectivo(string id)
			{
				if (!_loaded)
				{
					//DeclareTypes(pathBDFDP, _nameBDFDP);
					DeclareTypes();
				}
				return ((_nameBDFDP.Contains(id)) && (_nameBDFDP[id].Equals("_E_")));
				
			}
		
			#endregion
			
			#region read y save XML
			public static MAPStaticInfoHeader Read(string fileName)
			{
				
				return Read( new FileStream( fileName, FileMode.Open, FileAccess.Read, FileShare.Read ) );
			}

			public static MAPStaticInfoHeader Read( Stream stream )
			{
				stream.Position = 0;

				XmlSerializer serializer = new XmlSerializer( typeof( MAPStaticInfoHeader ) );
				XmlReader reader = new XmlTextReader( stream );
          
				MAPStaticInfoHeader j = ( MAPStaticInfoHeader )serializer.Deserialize( reader );
				reader.Close();

				return j;
			}
			public static MAPStaticInfoHeader Read( byte[] bytes )
			{
				MemoryStream ms = new MemoryStream();
				ms.Write( bytes, 0, bytes.Length );

				return Read( ms );
			}

		
			public static void Save(SortedList list, string path)
			{
				mapH = new MAPStaticInfoHeader(list);
				MAPStaticInfo.Save( path ); 
				list = new SortedList();
			}
			private static void Save(string fileName)
			{
				XmlSerializer serializer = new XmlSerializer( typeof( MAPStaticInfoHeader ) );

				Stream fs = new FileStream( fileName, FileMode.Create, FileAccess.Write, FileShare.None );
				XmlWriter writer = new XmlTextWriter( fs, new UTF8Encoding() );
				try
				{
					serializer.Serialize( writer, MAPStaticInfo.mapH );
				}
				catch( Exception ex )
				{
					throw ex;
				}
				finally
				{
					writer.Close();
					fs.Close();
				}
			}
			#endregion

			#region bd
			
			#endregion

			/*
			 * Ver como mejorar la forma de decidir si dado un IdControlDeCajasFamiliasComprobanteTesoreria es una tarjeta o cheque o demas
			 * por ahora lo hago estatico dado a la falta de tiempo..
			 */
			#region Sabrina ControlDeCajasFamiliasTarjeta
			private static bool _loadedControlDeCajasFamiliasTarjeta = false;
			private static ArrayList _controlDeCajasFamiliasTarjeta = new ArrayList();
			private static ArrayList _controlDeCajasFamiliasEfectivo = new ArrayList();

			private static void LoadControlDeCajasFamiliasTarjeta()
			{
				_controlDeCajasFamiliasTarjeta.Add("TC");
				_controlDeCajasFamiliasEfectivo.Add("E");
				_loadedControlDeCajasFamiliasTarjeta = true;
			}
			public static bool PerteneceAControlDeCajasFamiliasTarjeta(string IdControlDeCajasFamiliasComprobanteTesoreria)
			{
				if (!_loadedControlDeCajasFamiliasTarjeta)
				{
					LoadControlDeCajasFamiliasTarjeta();
				}
				return _controlDeCajasFamiliasTarjeta.Contains(IdControlDeCajasFamiliasComprobanteTesoreria);
			}

			public static bool PerteneceAControlDeCajasFamiliasEfectivo(string IdControlDeCajasFamiliasComprobanteTesoreria)
			{
				if (!_loadedControlDeCajasFamiliasTarjeta)
				{
					LoadControlDeCajasFamiliasTarjeta();
				}
				return _controlDeCajasFamiliasEfectivo.Contains(IdControlDeCajasFamiliasComprobanteTesoreria);
			}
			#endregion
		}


	}
