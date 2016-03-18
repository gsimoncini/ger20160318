using System;
using System.Data;
using System.Collections;

using mz.erp.commontypes.data;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de VariableAuxiliar.
	/// </summary>
	public class VariableAuxiliar
	{
		
		public VariableAuxiliar(VariablesAuxiliares parent, string id, string descripcion, string valor, bool sistema, Type dataType)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Init(parent, id,descripcion,valor,sistema, true, dataType);
		}

		public VariableAuxiliar(VariablesAuxiliares parent, string id, string descripcion, string valor, bool sistema, bool editable, Type dataType)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			Init(parent, id,descripcion,valor,sistema, editable, dataType);
		}
		private VariablesAuxiliares _variablesAuxilares;
		private void Init( VariablesAuxiliares parent, string id, string descripcion, string valor, bool sistema, bool editable, Type dataType)
		{
			this._id = id;
			this._descripcion = descripcion;
			this._valor = valor;
			this._editable = editable;
			this._sistema = sistema;
			this._variablesAuxilares = parent;
			this._dataType = dataType;
		}


		public event EventHandler ValorChanged;
		private string _id;
		public string Id
		{
			get { return _id; }
		}
		private string _descripcion;
		public string Descripcion
		{
			get { return _descripcion; }
		}
		private string _valor;
		public string Valor
		{
			get 
			{ 
				if (_sistema)
				{
					return GetValorClase();
				}
				else
				{
					return _valor; 
				}
			}
			set 
			{ 
				if (_editable)
				{
					_valor = value; 
					if(ValorChanged != null)
						ValorChanged(this, new EventArgs());

				}
			}
		}
		private bool _editable;
		public bool Editable
		{
			get { return _editable; }
		}
		private bool _sistema;
		public bool Sistema
		{
			get { return _sistema; }
		}

		private Type _dataType = null;
		public Type DataType 
		{
			get
			{	
				return _dataType;
			}
		}

		private string GetValorClase()
		{
			//Harcode, corregir cuando sea posible
			switch (_descripcion)
			{
				case "Comprobantes.Bonificaciones.Metodo":
					return Convert.ToString(ComprobantesRules.Comprobantes_Bonificaciones_Metodo);
					break;
				case "Comprobantes.CondicionDeVenta":
					return _valor ;//Convert.ToString(this._variablesAuxilares.Comprobante.CondicionDeVenta.IdCondicionDeVenta);
					break;
				case "Comprobantes.CondicionDeVenta.Cuotas":
					return "";//Convert.ToString(this._variablesAuxilares.Comprobante.CondicionDeVenta.DetalleCondicionDeVenta.ToString());
					break;
				case "Comprobantes.AgrupaProductos":
					return Convert.ToString(ComprobantesRules.Comprobantes_Productos_AgrupaProductos);
			}
			return _valor;
		}
		public bool CompareByName(string Nombre)
		{
			return (_descripcion.ToUpper() == Nombre.ToUpper());
			
		}
		public bool CompareById( string Id)
		{
			return (_id.ToUpper() == Id.ToUpper());
		}

		
		public void Commit()
		{
			VariablesAuxiliares var = this._variablesAuxilares;
			Comprobante comprobante = var.Comprobante;
			tsa_ComprobantesExDataset data = comprobante.DatasetComprobante;
			tsa_ComprobantesExDataset.tsa_ComprobanteValoresVarAuxRow row = data.tsa_ComprobanteValoresVarAux.Newtsa_ComprobanteValoresVarAuxRow();
			
			row.IdComprobante = ((tsa_ComprobantesExDataset.tsa_ComprobantesRow)data.tsa_Comprobantes.Rows[0]).IdComprobante;
			row.IdVarAuxComprobante = this._id;
			row.Valor = this.Valor;

			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdReservado = 0;
			row.IdSucursal = Security.IdSucursal;
			data.tsa_ComprobanteValoresVarAux.Addtsa_ComprobanteValoresVarAuxRow( row );

			
		}
	}
	
	/// <summary>
	/// Descripción breve de VariablesAuxiliares.
	/// </summary>
	public class VariablesAuxiliares
	{
		public Comprobante Comprobante;
		public VariablesAuxiliares(string action, Comprobante parent)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			
			Comprobante = parent;
			_variablesDeUsuario = new ArrayList();
			_variablesDeSistema = new ArrayList();
			Init(action);
		}
		
		public VariablesAuxiliares(string IdComprobante, string IdTipoDeComprobante)
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			
			_variablesDeUsuario = new ArrayList();
			_variablesDeSistema = new ArrayList();
			Init(IdComprobante, IdTipoDeComprobante);
		}



		
		private void Init(string action)
		{			
			switch (action)
			{
				case "NEW":
					GetVariablesAuxiliares();
					break;
				case "EDIT":
					GetVariablesAuxiliares(this.Comprobante.IdComprobante, this.Comprobante.TipoComprobanteDestino );
					break;
				case "STEP":
					GetVariablesAuxiliaresOrigenDestino();
					break;
			}
		}


		private void Init(string IdComprobante, string IdTipoDeComprobante)
		{
				GetVariablesAuxiliares(IdComprobante, IdTipoDeComprobante );		
		}

		private System.Collections.ArrayList _variablesDeUsuario;
		private System.Collections.ArrayList _variablesDeSistema;
		
		/// <summary>
		/// Recupera las variables auxiliares para un comprobante existente
		/// </summary>
		/// <param name="idComprobante"></param>
		private void GetVariablesAuxiliares( string IdComprobante , string IdTipoDeComprobante)
		{
			System.Data.DataSet _dataVariablesAuxiliares = mz.erp.dataaccess.tsa_ComprobantesEx.GetVariablesAuxiliaresPorId(IdComprobante,IdTipoDeComprobante);
			System.Data.DataTable _variablesAuxiliares = _dataVariablesAuxiliares.Tables[0];
			FillEdit(_variablesAuxiliares);
		}

		/// <summary>
		/// Recupera las variables auxiliares para un nuevo comprobante
		/// </summary>
		private void GetVariablesAuxiliares()
		{
			//Levanto la definición definición de las variables auxiliares
			System.Data.DataTable _variablesAuxiliares = mz.erp.dataaccess.tsa_ComprobantesEx.GetVariablesAuxiliaresPorTipo( this.Comprobante.TipoComprobanteDestino ).Tables[0];
			FillNew(_variablesAuxiliares);
		}

		private void GetVariablesAuxiliaresOrigenDestino()
		{			
			//Levanto la definición definición de las variables auxiliares del origen		
			
			//System.Data.DataTable _variablesAuxiliaresOrigen = mz.erp.dataaccess.tsa_ComprobantesEx.GetVariablesAuxiliaresPorTipo( this.Comprobante.TipoComprobanteOrigen ).Tables[0];
			VariablesAuxiliares varsCompOrigen = new VariablesAuxiliares(this.Comprobante.IdComprobanteOrigen,this.Comprobante.TipoComprobanteOrigen);
	
		

			System.Data.DataTable _variablesAuxiliaresDestino = mz.erp.dataaccess.tsa_ComprobantesEx.GetVariablesAuxiliaresPorTipo( this.Comprobante.TipoComprobanteDestino ).Tables[0];
			FillNew(_variablesAuxiliaresDestino);
			foreach( VariableAuxiliar varSis in this.VariablesDeSistema )
			{				
				foreach(VariableAuxiliar varSisCompOrigen in varsCompOrigen.VariablesDeSistema)
				{
					if(varSisCompOrigen.Id.Equals(varSis.Id))
						varSis.Valor = varSisCompOrigen.Valor;
				}
			}				
			foreach( VariableAuxiliar varUser in this.VariablesDeUsuario )
			{				
				foreach(VariableAuxiliar varUserCompOrigen in varsCompOrigen.VariablesDeUsuario)
				{
					if(varUserCompOrigen.Id.Equals(varUser.Id))
						varUser.Valor = varUserCompOrigen.Valor;
				}
			}
		}

		private void FillEdit(DataTable _variablesAuxiliares)
		{			
			foreach (System.Data.DataRow row  in _variablesAuxiliares.Rows)
			{
				string id = Convert.ToString(row["IdVarAuxComprobante"]);
				string descripcion = Convert.ToString(row["Descripcion"]);
				Type tipo = Type.GetType(Convert.ToString(row["Tipo"]));
				string valor = Convert.ToString(row["Valor"]);
				if (valor == "")valor = Convert.ToString(row["ValorDefault"]);
				bool sistema = (bool)row["Sistema"];
				VariableAuxiliar var = new VariableAuxiliar( this, id, descripcion, valor, sistema, tipo);
				
				if (sistema)
				{
					this._variablesDeSistema.Add( var );
				}
				else
				{
					this._variablesDeUsuario.Add( var );
				}
			}
		}
		
		private void FillNew(DataTable _variablesAuxiliares)
		{			
			foreach (System.Data.DataRow row in _variablesAuxiliares.Rows)
			{
				string id = Convert.ToString(row["IdVarAuxComprobante"]);
				string descripcion = Convert.ToString(row["Descripcion"]);
				Type tipo = Type.GetType(Convert.ToString(row["Tipo"]));
				string valor = null;
				switch (descripcion)
				{
					case "Comprobantes.CondicionDeVenta":
					{
						if (this.Comprobante.CondicionDeVenta != null)
							valor = this.Comprobante.CondicionDeVenta.IdCondicionDeVenta;
						break;
					}
					case "Comprobantes.CondicionDeVenta.Cuotas":
					{
						if (this.Comprobante.CondicionDeVenta != null)
							valor = Convert.ToString(this.Comprobante.CondicionDeVenta.DetalleCondicionDeVenta.Count);
						break;
					}
					default :
					{
						valor = Convert.ToString(row["ValorDefault"]);
						break;
					}
				}
				bool sistema = (bool)row["Sistema"];
				VariableAuxiliar var = new VariableAuxiliar( this, id, descripcion, valor, sistema, tipo);
				if (sistema)
				{
					this._variablesDeSistema.Add( var );
				}
				else
				{
					this._variablesDeUsuario.Add( var );
				}
			}
		}
		public System.Collections.ArrayList VariablesDeUsuario
		{
			get 
			{ 
				return this._variablesDeUsuario; 
			}
		}
		public System.Collections.ArrayList VariablesDeSistema
		{
			get 
			{ 
				return this._variablesDeSistema; 
			}
		}

		public DataSet CommitEdit(string IdComprobante)
		{
			DataSet dataVariables = new DataSet();
			mz.erp.businessrules.tsa_ComprobanteValoresVarAux.GetList(dataVariables, IdComprobante, null, null);
			foreach(DataRow row in dataVariables.Tables[0].Rows)
			{
				string IdVarAux = Convert.ToString(row["IdVarAuxComprobante"]);
				foreach (VariableAuxiliar var in this._variablesDeSistema)
				{				
					string IdVariable = var.Id;
					if(IdVariable.Equals(IdVarAux))
					{
						row["Valor"] = var.Valor;
						break;
					}

				}
				foreach (VariableAuxiliar var in this._variablesDeUsuario)
				{
					string IdVariable = var.Id;
					if(IdVariable.Equals(IdVarAux))
					{
						row["Valor"] = var.Valor;
						break;
					}
				}
			}
			return dataVariables;
		}

		public void Commit(string IdVariablesAuxiliares)
		{
			ArrayList arrayIdVariablesAuxiliares = mz.erp.systemframework.Util.Parse(IdVariablesAuxiliares,",");
			foreach (VariableAuxiliar var in this._variablesDeSistema)
			{				
				if (arrayIdVariablesAuxiliares.Contains(var.Id)) 
				{
					var.Valor = FormatTagsDeSistema(var.Valor);	
				}	
				var.Commit();
			}
			foreach (VariableAuxiliar var in this._variablesDeUsuario)
			{
				var.Commit();
			}
		}

		private string FormatTagsDeSistema(string ValorOriginal) 
		{						
			ArrayList frases = mz.erp.systemframework.Util.Parse(ValorOriginal,"+");
			string valor = string.Empty;
			string fraseNu = string.Empty;
			foreach(string frase in frases) 
			{
				switch(frase.Trim()) 
				{
					case "cotizacion": 
						decimal cotizacion = tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto();
						fraseNu = Decimal.Round(cotizacion,2).ToString();
						break;
					default: 
						fraseNu = frase.Trim();;
						break;
				}
				valor = valor + " " + fraseNu;
				valor = valor.Trim();
			}
			
			
			return valor;
		}

		public VariableAuxiliar Search( string IdVariable )
		{
			foreach (VariableAuxiliar var in this._variablesDeSistema)
			{
				if (var.CompareById( IdVariable ))
				{
					return var;
				}
			}
			foreach (VariableAuxiliar var in this._variablesDeUsuario)
			{
				if (var.CompareById( IdVariable))
				{
					return var;
				}
			}
			return null;
		}
		

	}
}
