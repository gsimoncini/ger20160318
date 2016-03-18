using System;
using System.Collections;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de JerarquiaConfigurarVariable.
	/// </summary>
	public class JerarquiaConfigurarVariable: ITask, IPersistentTask
	{
		
		#region Constructores

		public JerarquiaConfigurarVariable()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public JerarquiaConfigurarVariable(string processName, string taskName)
		{
			this._processName=processName;
			this._taskName=taskName;
			Init();
		}
		#endregion

		#region Variables Privadas
		private string _textoBotonAnterior = "Anterior";
		private string _textoBotonSiguiente = "Siguiente";
		
		private IList _elementos;
		private DataTable _dataTableVariables = new DataTable();
		private string _jerarquia = string.Empty;
		private string _idNomenclatura = string.Empty;		
		private ArrayList _fieldsLayout = new ArrayList();
		private string _uiClass = string.Empty;
		private string _uiClassAgrupamientos = string.Empty;
		private string _nivelMaximoPermitido = string.Empty;
		private bool _validarNodoNivel0 = false;
		private string[] _nomenclaturas = new string[8];			
		private string[] _jerarquias = new string[8];
		private bool[] _jerarquiasEditables = new bool[8]; // false por default.

        /* Silvina 20111104 - Tarea 0000222 */

        private bool _usaCategorias = true;
        private string _categoria = string.Empty;

        /* Fin Silvina 20111104 - Tarea 0000222 */

		#endregion

		#region Variables Privadas ITask

		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		protected ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		protected ProcessManager _processParent;

		#endregion

		#region Propiedades
		public string Jerarquia
		{
			get{return _jerarquia;}
			set{_jerarquia = value;}
		}
		public  IList Elementos
		{
			get{return _elementos;}
		}

		public string IdNomenclatura
		{
			get{return _idNomenclatura;}
			set{_idNomenclatura = value;}
		}

		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);		
				}
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}									
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}
		
		public string Jerarquia1
		{
			get{return _jerarquias[0];}
			set{_jerarquias[0]=value;}
		}
		public string Jerarquia2
		{
			get{return _jerarquias[1];}
			set{_jerarquias[1]=value;}
		}
		public string Jerarquia3
		{
			get{return _jerarquias[2];}
			set{_jerarquias[2]=value;}
		}
		public string Jerarquia4
		{
			get{return _jerarquias[3];}
			set{_jerarquias[3]=value;}
		}
		public string Jerarquia5
		{
			get{return _jerarquias[4];}
			set{_jerarquias[4]=value;}
		}
		public string Jerarquia6
		{
			get{return _jerarquias[5];}
			set{_jerarquias[5]=value;}
		}
		public string Jerarquia7
		{
			get{return _jerarquias[6];}
			set{_jerarquias[6]=value;}
		}
		public string Jerarquia8
		{
			get{return _jerarquias[7];}
			set{_jerarquias[7]=value;}
		}

		public string SetNomenclaturaJerarquia1
		{
			set{_nomenclaturas[0]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[0]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia2
		{
			set{_nomenclaturas[1]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[1]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia3
		{
			set{_nomenclaturas[2]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[2]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia4
		{
			set{_nomenclaturas[3]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[3]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia5
		{
			set{_nomenclaturas[4]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[4]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia6
		{
			set{_nomenclaturas[5]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[5]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia7
		{
			set{_nomenclaturas[6]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[6]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}
		public string SetNomenclaturaJerarquia8
		{
			set{_nomenclaturas[7]=value;}
            /* Silvina 20111104 - Tarea 0000222 */
            get { return _nomenclaturas[7]; }
            /* Silvina 20111104 - Tarea 0000222 */
		}

        /* Silvina 20111104 - Tarea 0000222 */

        public bool UsaCategorias
        {
            get { return _usaCategorias; }
        }

        public string Categoria
        {
            get { return _categoria; }
        }

        public void SetCategoria(int indice)
        {
            _categoria = _nomenclaturas[indice - 1]; 
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

		public bool ExisteKey(string key)
		{
			if (!key.Equals(string.Empty))
			{
				// Testear que no haya, en otra Jerarquia, el mismo grupo/jerarquia seleccionada.
				for(int x = 0; x < this._nomenclaturas.Length; x++) 
				{
					if (_nomenclaturas[x].Equals(key))
						return true;					
				}					
			}
			return false;
		}

		public bool JerarquiaEditable(string nro, string key)
		{
			long index = Convert.ToInt32(nro)-1;
			if ( _jerarquiasEditables[index] && !ExisteKey(key) )
				return true;
			return false;
		}

		/*public bool JerarquiaEditableNUEVA(string nro, string key)
		{
			long index = Convert.ToInt32(nro)-1;
			switch (this._processName)
			{
				case "ProcesoJerarquiaConfigurarVariableCuentas":
					if (!_nomenclaturas[index].Equals(string.Empty))
					{
						string idJerarquia = mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetByPk(_nomenclaturas[index]).Jerarquia;
						if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
						{
							DataTable table = mz.erp.dataaccess.tsa_AgrupCuentas.GetListExistePadre(idJerarquia).Tables[0];
							if (table.Rows.Count==0)
								// Jerarquia editable --> no asociada a ningun producto.
								return !ExisteKey(key); // puede ser true o false!
							else
								// Jerarquia NO editable --> asociada a algun producto.
								return false;
						}
					}
					// Jerarquia editable --> no definida.
					return !ExisteKey(key); // puede ser true o false!
					break;
				case "ProcesoJerarquiaConfigurarVariableProductos":
					if (!_nomenclaturas[index].Equals(string.Empty))
					{
						string idJerarquia = mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetByPk(_nomenclaturas[index]).Jerarquia;
						if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
						{
							DataTable table = mz.erp.dataaccess.tsh_AgrupProductos.GetListExistePadre(idJerarquia).Tables[0];
							if (table.Rows.Count==0)
								// Jerarquia editable --> no asociada a ningun producto.
								return !ExisteKey(key); // puede ser true o false!
							else
								// Jerarquia NO editable --> asociada a algun producto.
								return false;
						}
					}
					// Jerarquia editable --> no definida.
					return !ExisteKey(key); // puede ser true o false!
					break;
				case "ProcesoJerarquiaConfigurarVariableProveedores":
					if (!_nomenclaturas[index].Equals(string.Empty))
					{
						string idJerarquia = mz.erp.dataaccess.tpu_JerarquiaAgrupProveedores.GetByPk(_nomenclaturas[index]).Jerarquia;
						if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
						{
							DataTable table = mz.erp.dataaccess.tpu_AgrupProveedores.GetListExistePadre(idJerarquia).Tables[0];
							if (table.Rows.Count==0)
								// Jerarquia editable --> no asociada a ningun producto.
								return !ExisteKey(key); // puede ser true o false!
							else
								// Jerarquia NO editable --> asociada a algun producto.
								return false;
						}
					}
					// Jerarquia editable --> no definida.
					return !ExisteKey(key); // puede ser true o false!
					break;
				default:
					return false;
					break;
			}
		}
*/
		#endregion

		#region Eventos
		//public event EventHandler TotalImputadoChanged;
		#endregion

		#region Metodos Privados
		public string GetUIClass()
		{
			switch(this._processName)
			{
				case "ProcesoJerarquiaConfigurarVariableProductos": 
					return "mz.erp.ui.controllers.tsh_Productos";
					break;
				
				case "ProcesoJerarquiaConfigurarVariableCuentas": 
					return "mz.erp.ui.controllers.tsa_Cuentas";
					break;
				
				case "ProcesoJerarquiaConfigurarVariableProveedores": 
					return "mz.erp.ui.controllers.tpu_Proveedores";
					break;
					
				default: 
					return string.Empty;
					break;
			}

		}
		public ArrayList GetFields()
		{
			return new ArrayList();
		}
		
		public Node getChildsNode(string key)
		{
			System.Data.DataTable table = new DataTable();
			string descriptionH = String.Empty;
			string keyH = String.Empty;
			string descriptionN = String.Empty;
			string keyN = String.Empty;
			Node header;
			if (key.ToUpper().Equals("RAIZ")) 
			{
				switch(this._processName)
				{
					case "ProcesoJerarquiaConfigurarVariableProductos": 
						table = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetListGeneric(char.MinValue, true);
						break;
				
					case "ProcesoJerarquiaConfigurarVariableCuentas": 
						table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetNomenclaturas();
						break;
				
					case "ProcesoJerarquiaConfigurarVariableProveedores": 
						table = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetNomenclaturas();
						break;
					
					default:
						break;
				}
				header = new Node(key, "Agrupamientos");
			}
			else
			{
				//table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetList(key);
				switch(this._processName)
				{
					case "ProcesoJerarquiaConfigurarVariableProductos": 
						table = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(key);
						break;
				
					case "ProcesoJerarquiaConfigurarVariableCuentas": 
						table = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetList(key);
						break;
				
					case "ProcesoJerarquiaConfigurarVariableProveedores": 
						table = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetList(key);
						break;
					
					default:
						break;
				}
				header = new Node(key, key);
			}

			foreach (System.Data.DataRow rowH in table.Rows) 
			{
				descriptionH = rowH["Descripcion"].ToString();
				keyH = rowH["IdNomenclatura"].ToString();
				Node child = new Node(keyH, descriptionH);
				header.AddChild(child);
			}
	
			return header;
		}
		
		public string GetUIClassAgrupamientos()
		{
			switch (this._processName)
			{
				case "ProcesoJerarquiaConfigurarVariableProductos":
					return "mz.erp.ui.controllers.tsh_AgrupProductos";
					break;
				case "ProcesoJerarquiaConfigurarVariableCuentas":
					return "mz.erp.ui.controllers.tsa_AgrupCuentas";
					break;
				case "ProcesoJerarquiaConfigurarVariableProveedores":
					return "mz.erp.ui.controllers.tpu_AgrupProveedores";
					break;
				default:
					return string.Empty;
					break;
			}
		}
		
		public void GetJerarquia(string key)
		{
			if(key != null && ! key.Equals(string.Empty))
			{
				tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow row  = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(key);
				if(row != null)
				{
					Jerarquia = row.Jerarquia;
					IdNomenclatura = row.IdNomenclatura;
				}
			}
		}
		
		public void ProcesarElementos(ArrayList rows)
		{
			if(this.Elementos == null)
				this.SetElementos(new CuentasViewCollection());
			foreach(System.Data.DataRow row in rows)
			{
				CuentaView cuenta = new CuentaView();
				cuenta.Codigo = Convert.ToString(row["Codigo"]);
				cuenta.IdCuenta = Convert.ToString(row["IdCuenta"]);
				cuenta.Nombre = Convert.ToString(row["Nombre"]);
				cuenta.Domicilio = Convert.ToString(row["Domicilio"]);
				cuenta.Telefono = Convert.ToString(row["Telefono"]);
				if(!((CuentasViewCollection)this.Elementos).Contains(cuenta))
					this.Elementos.Add(cuenta);
			}
		}

		private bool IsValidJerarquia(CuentaView cuenta)
		{

			//if(Jerarquia == null || Jerarquia.Equals(string.Empty)) return false;
			DataSet data = dataaccess.tsa_AgrupCuentas.GetList(cuenta.IdCuenta, Security.IdEmpresa);
			string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20)", "'" + Jerarquia + "'");			
			DataView dv = new DataView( data.Tables[0], filtro, "", System.Data.DataViewRowState.Unchanged );
			return dv.Count == 0;
		}

		private void RelacionarJerarquiaElementos()
		{

		}
		
//		public void DeleteAgrupamientos(string Hierarchy)
//		{
//			if(this.Elementos != null)
//			{
//				foreach(CuentaView cv in this.Elementos)
//				{
//					string IdCuenta = cv.IdCuenta;
//					tsa_AgrupCuentasDataset.tsa_AgrupCuentasRow row = businessrules.tsa_AgrupCuentas.NewRow();
//					row = businessrules.tsa_AgrupCuentas.GetByPk(IdCuenta, Hierarchy);
//					if (row != null)
//					{
//						row.Delete();
//						businessrules.tsa_AgrupCuentas.Update (row);
//
//						//Si hay otra agrupcuentas no hay q eliminarla solo actualizarla, si no hay otra directamente borro la de cuentas jerarquia
//						DataSet dataset = businessrules.tsa_AgrupCuentas.GetList(IdCuenta);
//						if (dataset.Tables[0].Rows.Count==0)
//						{
//							tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow rowCJ = businessrules.tsa_CuentasJerarquias.GetByPk(IdCuenta);
//							rowCJ.Delete();
//							businessrules.tsa_CuentasJerarquias.Update (rowCJ);
//						}
//							//Else hay q actualizar la q jerarquia q corresponde = ""
//						else 
//						{
//								if (!Jerarquia.Equals(string.Empty))
//						   {
//							   CuentasJerarquiaAuxiliar c = new CuentasJerarquiaAuxiliar();
//							   string nomenclatura = c.nomenclaturaReal(Jerarquia);
//							   ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquia,20);
//							   tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow rowCJ = AddTsa_CuentasJerarquias(IdCuenta);
//							   rowCJ[nomenclatura+"a"] = string.Empty;
//							   rowCJ[nomenclatura+"b"] = string.Empty;
//							   rowCJ[nomenclatura+"c"] = string.Empty;
//							   rowCJ[nomenclatura+"d"] = string.Empty;
//							   businessrules.tsa_CuentasJerarquias.Update(rowCJ);
//						   }
//						}
//
//					}	
//				}
//			}
//		}


		#endregion

		#region Metodos Publicos
		public void CargarJerarquias()
		{
			switch (this._processName)
			{
				case "ProcesoJerarquiaConfigurarVariableCuentas":
					this.CargarJerarquiasCuentas();
					break;
				case "ProcesoJerarquiaConfigurarVariableProductos":
					this.CargarJerarquiasProductos();
					break;
				case "ProcesoJerarquiaConfigurarVariableProveedores":
					this.CargarJerarquiasProveedores();
					break;
				default:
					break;
			}		
		}

		public void CargarJerarquiasCuentas()
		{
			// Levanto todas las variables "Cuentas.BusquedaJerarquica.Jerarquia%" (%=1..8)
			this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Cuentas.BusquedaJerarquica.Jerarquia").Tables[0];
			// Seteo _nomenclaturas[0] con cada valor de las variables.
			foreach(DataRow row in this._dataTableVariables.Rows)
			{
				string var = Convert.ToString(row["IdVariable"]);
				switch(var)
				{
					case "Cuentas.BusquedaJerarquica.Jerarquia1":
						_nomenclaturas[0]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia2":
						_nomenclaturas[1]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia3":
						_nomenclaturas[2]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia4":
						_nomenclaturas[3]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia5":
						_nomenclaturas[4]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia6":
						_nomenclaturas[5]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia7":
						_nomenclaturas[6]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Cuentas.BusquedaJerarquica.Jerarquia8":
						_nomenclaturas[7]=Convert.ToString(row["ValorDefault"]);
						break;
					default:
						break;
				}
			}
			// Recupero la descripcion de las jerarquias.
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
					_jerarquias[x] = mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetByPk(_nomenclaturas[x]).Descripcion;
			}
			// Define que jerarquias seran editables.
			this.CargarJerarquiasCuentasEditables();
            /* Silvina 20111104 - Tarea 0000222 */
            _categoria = sy_Variables.GetByPk("Cuentas.Categorias.JerarquiaAsociada").ValorDefault; 
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		public void CargarJerarquiasProductos()
		{
			// Levanto todas las variables "Productos.BusquedaJerarquica.Jerarquia%" (%=1..8)
			this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Productos.BusquedaJerarquica.Jerarquia").Tables[0];
			// Seteo _nomenclaturas[0] con cada valor de las variables.
			foreach(DataRow row in this._dataTableVariables.Rows)
			{
				string var = Convert.ToString(row["IdVariable"]);
				switch(var)
				{
					case "Productos.BusquedaJerarquica.Jerarquia1":
						_nomenclaturas[0]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia2":
						_nomenclaturas[1]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia3":
						_nomenclaturas[2]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia4":
						_nomenclaturas[3]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia5":
						_nomenclaturas[4]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia6":
						_nomenclaturas[5]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia7":
						_nomenclaturas[6]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Productos.BusquedaJerarquica.Jerarquia8":
						_nomenclaturas[7]=Convert.ToString(row["ValorDefault"]);
						break;
					default:
						break;
				}
			}
			// Recupero la descripcion de las jerarquias.
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
					_jerarquias[x] = mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetByPk(_nomenclaturas[x]).Descripcion;
			}
			// Define que jerarquias seran editables.
			this.CargarJerarquiasProductosEditables();
            /* Silvina 20111104 - Tarea 0000222 */
            _categoria = sy_Variables.GetByPk("Productos.Categorias.JerarquiaAsociada").ValorDefault; 
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		public void CargarJerarquiasProveedores()
		{
			// Levanto todas las variables "Proveedores.BusquedaJerarquica.Jerarquia%" (%=1..8)
			this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Proveedores.BusquedaJerarquica.Jerarquia").Tables[0];
			// Seteo _nomenclaturas[0] con cada valor de las variables.
			foreach(DataRow row in this._dataTableVariables.Rows)
			{
				string var = Convert.ToString(row["IdVariable"]);
				switch(var)
				{
					case "Proveedores.BusquedaJerarquica.Jerarquia1":
						_nomenclaturas[0]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia2":
						_nomenclaturas[1]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia3":
						_nomenclaturas[2]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia4":
						_nomenclaturas[3]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia5":
						_nomenclaturas[4]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia6":
						_nomenclaturas[5]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia7":
						_nomenclaturas[6]=Convert.ToString(row["ValorDefault"]);
						break;
					case "Proveedores.BusquedaJerarquica.Jerarquia8":
						_nomenclaturas[7]=Convert.ToString(row["ValorDefault"]);
						break;
					default:
						break;
				}
			}
			// Recupero la descripcion de las jerarquias.
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
					_jerarquias[x] = mz.erp.dataaccess.tpu_JerarquiaAgrupProveedores.GetByPk(_nomenclaturas[x]).Descripcion;
			}
			// Define que jerarquias seran editables.
			this.CargarJerarquiasProveedoresEditables();
            /* Silvina 20111104 - Tarea 0000222 */
            _usaCategorias = false;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		public void CargarJerarquiasProductosEditables()
		{
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
				{
					string idJerarquia = mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetByPk(_nomenclaturas[x]).Jerarquia;
					if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
					{
						DataTable table = mz.erp.dataaccess.tsh_AgrupProductos.GetListExistePadre(idJerarquia).Tables[0];
						if (table.Rows.Count==0)
							// Jerarquia editable --> no asociada a ningun producto.
							this._jerarquiasEditables[x]=true;
						else
							// Jerarquia NO editable --> asociada a algun producto.
                            this._jerarquiasEditables[x]=false;
					}
				}
				else
					// Jerarquia editable --> no definida.
					this._jerarquiasEditables[x]=true;
			}
            			
		}

		public void CargarJerarquiasCuentasEditables()
		{
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
				{
					string idJerarquia = mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetByPk(_nomenclaturas[x]).Jerarquia;
					if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
					{
						DataTable table = mz.erp.dataaccess.tsa_AgrupCuentas.GetListExistePadre(idJerarquia).Tables[0];
						if (table.Rows.Count==0)
							// Jerarquia editable --> no asociada a ningun producto.
							this._jerarquiasEditables[x]=true;
						else
							// Jerarquia NO editable --> asociada a algun producto.
							this._jerarquiasEditables[x]=false;
					}
				}
				else
					// Jerarquia editable --> no definida.
					this._jerarquiasEditables[x]=true;
			}
		}

		public void CargarJerarquiasProveedoresEditables()
		{
			for(int x = 0; x < this._nomenclaturas.Length; x++) 
			{
				if (!_nomenclaturas[x].Equals(string.Empty))
				{
					string idJerarquia = mz.erp.dataaccess.tpu_JerarquiaAgrupProveedores.GetByPk(_nomenclaturas[x]).Jerarquia;
					if (idJerarquia!=null && !idJerarquia.Equals(string.Empty))
					{
						DataTable table = mz.erp.dataaccess.tpu_AgrupProveedores.GetListExistePadre(idJerarquia).Tables[0];
						if (table.Rows.Count==0)
							// Jerarquia editable --> no asociada a ningun producto.
							this._jerarquiasEditables[x]=true;
						else
							// Jerarquia NO editable --> asociada a algun producto.
							this._jerarquiasEditables[x]=false;
					}
				}
				else
					// Jerarquia editable --> no definida.
					this._jerarquiasEditables[x]=true;
			}
		}

		public bool ValidarNodoNivel0(string _idNomenclatura)
		{			
			if (_validarNodoNivel0)
			{
				DataRow _row = null;
				switch (this._processName)
				{
					case "ProcesoJerarquiaConfigurarVariableCuentas":
						_row = mz.erp.dataaccess.tsa_JerarquiaAgrupCuentas.GetByPk(_idNomenclatura);
						break;
					case "ProcesoJerarquiaConfigurarVariableProductos":
						_row = mz.erp.dataaccess.tsh_JerarquiaAgrupProd.GetByPk(_idNomenclatura);
						break;
					case "ProcesoJerarquiaConfigurarVariableProveedores":
						_row = mz.erp.dataaccess.tpu_JerarquiaAgrupProveedores.GetByPk(_idNomenclatura);
						break;
					default:
						break;
				}
				string nivel = string.Empty;;
				if (_row!=null)
					nivel = Convert.ToString(_row["Nivel"]);
				return ( Convert.ToInt32(nivel)<=Convert.ToInt32(this._nivelMaximoPermitido) );
			}
			return true;			
		}


		#endregion
        
		#region Miembros de ITask

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public  void ListenerTaskDependentChanged(object sender)
		{
			
		}

		public  void ListenerAfterExecuteDependentTask(object sender)
		{
			
		}

		private void Step()
		{
			
		}

		public  void ListenerBeforeExecuteDependentTask(object sender)
		{
			
		}

		public  void Init()
		{
			_fieldsLayout = this.GetFields();
			_uiClass = this.GetUIClass();
			_uiClassAgrupamientos = this.GetUIClassAgrupamientos();

			_nivelMaximoPermitido = Variables.GetValueString(this._processName, this._taskName, "NivelMaximoPermitido");
			_validarNodoNivel0 = Variables.GetValueBool(this._processName, this._taskName, "Validar.NodoNivel0");

			// Levanta las Jerarquias Visibles.
			this.CargarJerarquias();
            /* Silvina 20111104 - Tarea 0000222 */
            _usaCategorias = _usaCategorias && Variables.GetValueBool("Cuentas.UsaCategorias",false);
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public  bool IsValid()
		{
			_errores.Clear();
            /* Silvina 20111104 - Tarea 0000222 */
			//bool isvalid = true;
            if (_usaCategorias && string.IsNullOrEmpty(_categoria))
            {
                _errores.Add(new ItemDatasetError("Jerarquias", "Categoria", "Debe seleccionar la jerarquía que determina la Categoría."));
            }

            if (_errores.Count > 0)
                return false;
            else
                return true;
			//return isvalid;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		public  bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}

		public ItemsDatasetErrors GetErrors()
		{
			return _errores;			
		}

		public  string GetWarnings()
		{
			return null;			
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _processParent;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processParent = processManager;
			_processName = _processParent.Process.ProcessName;
		}

		public string GetTaskName()
		{
			return _taskName;
		}

		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());			
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public  void Previous()
		{
			
		}

		public  void ListenerAfterPreviousDependentTask(object sender)
		{
			
		}

		public  void ListenerBeforePreviousDependentTask(object sender)
		{
			
		}


		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;

		public event System.EventHandler OnTaskAfterFlush;

		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			return data;;
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			
		}

		public bool GetHasSaved()
		{
			return false;
		}

		public  void UpdateElementos(ArrayList rows)
		{
			ProcesarElementos(rows);
			Refresh();			
		}

		public void Add(string key)
		{
			GetJerarquia(key);
			/*
			if(IsValid())
			{
				RelacionarJerarquiaElementos();
			}
			*/
			if(IsValid())
			{
				Commit();
				Flush(null);
			}
			
		}
	
		public void Commit()
		{
			switch(this._processName)
			{
				case "ProcesoJerarquiaConfigurarVariableProductos":
					this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Productos.BusquedaJerarquica.Jerarquia").Tables[0];
					foreach(DataRow row in this._dataTableVariables.Rows)
					{
						string var = Convert.ToString(row["IdVariable"]);
						switch(var)
						{
							case "Productos.BusquedaJerarquica.Jerarquia1":
                                row["ValorDefault"]=_nomenclaturas[0];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia2":
								row["ValorDefault"]=_nomenclaturas[1];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia3":
								row["ValorDefault"]=_nomenclaturas[2];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia4":
								row["ValorDefault"]=_nomenclaturas[3];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia5":
								row["ValorDefault"]=_nomenclaturas[4];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia6":
								row["ValorDefault"]=_nomenclaturas[5];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia7":
								row["ValorDefault"]=_nomenclaturas[6];
								break;
							case "Productos.BusquedaJerarquica.Jerarquia8":
								row["ValorDefault"]=_nomenclaturas[7];
								break;
							default:
								break;
						}
					}
                    /* Silvina 20111104 - Tarea 0000222 */
                    sy_VariablesDataset.sy_VariablesRow rowCat = sy_Variables.GetByPk("Productos.Categorias.JerarquiaAsociada");
                    rowCat.ValorDefault = _categoria;
                    _dataTableVariables.ImportRow(rowCat);
                    /* Fin Silvina 20111104 - Tarea 0000222 */
					break;
				case "ProcesoJerarquiaConfigurarVariableCuentas":
					this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Cuentas.BusquedaJerarquica.Jerarquia").Tables[0];
					foreach(DataRow row in this._dataTableVariables.Rows)
					{
						string var = Convert.ToString(row["IdVariable"]);
						switch(var)
						{
							case "Cuentas.BusquedaJerarquica.Jerarquia1":
								row["ValorDefault"]=_nomenclaturas[0];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia2":
								row["ValorDefault"]=_nomenclaturas[1];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia3":
								row["ValorDefault"]=_nomenclaturas[2];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia4":
								row["ValorDefault"]=_nomenclaturas[3];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia5":
								row["ValorDefault"]=_nomenclaturas[4];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia6":
								row["ValorDefault"]=_nomenclaturas[5];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia7":
								row["ValorDefault"]=_nomenclaturas[6];
								break;
							case "Cuentas.BusquedaJerarquica.Jerarquia8":
								row["ValorDefault"]=_nomenclaturas[7];
								break;
							default:
								break;
						}
					}
                    /* Silvina 20111104 - Tarea 0000222 */
                    sy_VariablesDataset.sy_VariablesRow rowC = sy_Variables.GetByPk("Cuentas.Categorias.JerarquiaAsociada");
                    rowC.ValorDefault = _categoria;
                    _dataTableVariables.ImportRow(rowC);
                    /* Fin Silvina 20111104 - Tarea 0000222 */
					break;
				case "ProcesoJerarquiaConfigurarVariableProveedores":
					this._dataTableVariables = mz.erp.dataaccess.sy_Variables.GetListByInicio("Proveedores.BusquedaJerarquica.Jerarquia").Tables[0];
					foreach(DataRow row in this._dataTableVariables.Rows)
					{
						string var = Convert.ToString(row["IdVariable"]);
						switch(var)
						{
							case "Proveedores.BusquedaJerarquica.Jerarquia1":
								row["ValorDefault"]=_nomenclaturas[0];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia2":
								row["ValorDefault"]=_nomenclaturas[1];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia3":
								row["ValorDefault"]=_nomenclaturas[2];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia4":
								row["ValorDefault"]=_nomenclaturas[3];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia5":
								row["ValorDefault"]=_nomenclaturas[4];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia6":
								row["ValorDefault"]=_nomenclaturas[5];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia7":
								row["ValorDefault"]=_nomenclaturas[6];
								break;
							case "Proveedores.BusquedaJerarquica.Jerarquia8":
								row["ValorDefault"]=_nomenclaturas[7];
								break;
							default:
								break;
						}
					}
					break;
				default:
					break;
			}

		}
		
//		private tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow AddTsa_CuentasJerarquias(string idCuenta)
//		{
//			tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row = businessrules.tsa_CuentasJerarquias.GetByPk(idCuenta);
//			if (row==null)
//				row= businessrules.tsa_CuentasJerarquias.NewRow();
//			row["IdCuenta"]=idCuenta;
//			return row;
//							
//		}

		public void Flush(string IdTransaction)
		{
			mz.erp.dataaccess.sy_Variables.Update(_dataTableVariables);			
		}
		
		public void InitializeData()
		{
		
		}
		
		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		
//		public abstract TaskCollectionData GetData()
//		{
//			TaskCollectionData data = new TaskCollectionData();
//			data.TaskName = this._taskName;
//			data.Add(_data);
//			return data;
//		}
		
		public void Refresh()
		{
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		protected void SetElementos(IList elems)
		{
			_elementos = elems;
		}

		#endregion
	}
}
