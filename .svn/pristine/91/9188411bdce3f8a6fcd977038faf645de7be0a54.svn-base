using System;
using System.Data;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.systemframework;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using System.Data.SqlClient;

using mz.erp.dbhelper;


namespace mz.erp.businessrules.Comprobantes_de_Compra
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompra.
	/// </summary>
	public class ComprobanteDeCompra
	{
		public ComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


		#region Variables Privadas
		private string _state;
		public tpu_ComprobantesExDataset DatasetComprobante;
		//protected CondicionDeCompra _condicionDeCompra;
		
		//public VariablesAuxiliares VariablesComprobante;
		
		protected string _tipoComprobanteDestino;
		protected string _tipoComprobanteOrigen;

		protected string _claseComprobante;
		protected string _idComprobanteOrigen;
		//protected string _idComprobanteDestino;
		protected string _idComprobante;
	
		protected int _signo = 1;
		protected System.DateTime _fechaComprobante;

		protected string _numero;
		protected string _idInstanciaCaja;
		protected decimal _total;
		protected string _idMonedaCierre;
		protected string _IdResponsable;
		protected string _idProveedor;
		protected string _momento;
		protected long _idSucursal = Security.IdSucursal;
		protected long _idEmpresa = Security.IdEmpresa;

		protected long _idSucursalDestinoDatos = Security.IdSucursal;

		protected ItemsComprobantesCompra _itemsComprobantesCompras;

		#endregion

		#region Variables Publicas

		/*	public CondicionDeVenta CondicionDeVenta
			{
				get{return _condicionDeVenta;}
				set
				{	
					_condicionDeVenta = value;
				}
			}*/


		/*	public virtual decimal Saldo
			{
				get{return _saldo;}
				set{_saldo  = value;}


			}*/

		public ItemsComprobantesCompra Items
		{
			get{return _itemsComprobantesCompras;}
			set{_itemsComprobantesCompras = value;}
		}

		public string IdComprobante
		{
			get {return _idComprobante;}
			set {_idComprobante = value;}
		}

		public string IdComprobanteOrigen
		{
			get {return _idComprobanteOrigen;}
			set {_idComprobanteOrigen = value;}
		}

		public string IdComprobanteDestino
		{
			get {return _idComprobante;}	
			set {_idComprobante = value;}
		}

		public virtual string IdProveedor
		{
			get {return _idProveedor;}
			set {_idProveedor = value;}

		}
		public string IdInstanciaCaja
		{
			get {return _idInstanciaCaja;}
			set {_idInstanciaCaja = value;}


		}

		public virtual decimal Total
		{
			get {return _total;}
			set 
			{
				_total = value;
				//if (TotalChanged != null)
				//	TotalChanged(this,new EventArgs());	
			}
		}

		public string IdMonedaCierre
		{
			get {return _idMonedaCierre;}
			set {_idMonedaCierre = value;}
		}

		public string IdResponsable
		{
			get{return _IdResponsable;}
			set {_IdResponsable = value;}
		}


		public string Numero
		{
			get{return _numero;}
			set{_numero = value;}
		}

		public virtual string TipoComprobanteOrigen
		{
			set 
			{ 
				_tipoComprobanteOrigen = value; 
				//	this.SetDirty(false);
			}
			get 
			{ 
				return _tipoComprobanteOrigen ; 
			}
		}

		public virtual string TipoComprobanteDestino
		{
			set 
			{ 
				_tipoComprobanteDestino = value; 
				//this.SetDirty(true);
			}
			get 
			{ 
				return _tipoComprobanteDestino ; 
			}
		}

		/// <summary>
		/// Devuelve/Obtiene la fecha del comprobante
		/// </summary>
		public System.DateTime FechaComprobante
		{
			set 
			{
				_fechaComprobante = value;
			}   
			get 
			{
				return _fechaComprobante;
			}
		}

		public int Signo
		{
			get
			{
				return _signo;
			}
			set
			{
				_signo = value;
			}
		}

		public string Momento
		{
			get{return _momento;}
			set{_momento = value;}
		}

		public long IdSucursal
		{
			get {return Security.IdSucursal; }
			set {_idSucursal = value; }
		}
		public long IdEmpresa
		{
			get {return Security.IdEmpresa; }
			set {_idEmpresa = value ; }
		}

		public long IdSucursalDestinoDatos
		{
			get {return _idSucursalDestinoDatos; }
			set {_idSucursalDestinoDatos = value; }
		}
		#endregion

		#region Contructores

		public ComprobanteDeCompra(string action, ItemComprobante item,  string momento,string idTipoComprobanteDestino)
		{
			Init(action , item, null, idTipoComprobanteDestino,null);

		}

		public ComprobanteDeCompra( string action, ItemComprobante item,  string momento,string idTipoComprobanteDestino, RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			Init(action , item, momento, idTipoComprobanteDestino,relaciones);
		}



		#endregion

		#region inicializadores
		private void Init(string Action,  ItemComprobante item, string momento, string idTipoDeComprobanteDestino,RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			this.Momento = momento;
			switch (Action.ToUpper())
			{
				case "NEW":
				{
					this._state = "NEW";
					FillLoadData(item, null,null);
					break;
				}
				case "STEP":
				{
					this._state = "STEP";
					FillLoadData(null, idTipoDeComprobanteDestino,relaciones);
					break;
				}

			}

		}

		


		private  void FillLoadData(ItemComprobante item,  string TipoDeComprobanteDestino,RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			//Tomar el XML con lo guardado
			switch (this._state)
			{
				case "NEW":
				{
					
					DatasetComprobante = new tpu_ComprobantesExDataset();
					try
					{

						DatasetComprobante.ReadXml(mz.erp.systemframework.Util.ResourcePath() + "/temp/pedido" + Security.IdUsuario +".xml");
						FillStaticData("EDIT", item, null, null);
					}
					catch(Exception e)
					{
						DatasetComprobante = mz.erp.businessrules.tpu_ComprobantesEx.NewDataSet();
						FillStaticData("NEW",item, null, null);

					}
					
				

					break;
				}

				case "STEP":
				{
					this.DatasetComprobante = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
					
					this.IdResponsable = relaciones.IdResponsable;
									
					
					this.IdProveedor = relaciones.IdProveedor;

					this.TipoComprobanteDestino = TipoDeComprobanteDestino;

					this.FechaComprobante = System.DateTime.Now;
					this.IdComprobante = Util.NewStringId();
					
					this.Numero = string.Empty;
					this.Items = new ItemsComprobantesCompra("STEP", this, relaciones);
					this.Total= 0;
					break;					
					break;
				}

					
			}
			SetEditablesProperty();
			
		}

		private void FillStaticData(string Action, ItemComprobante item,string idTipoDeComprobanteDestino,RelacionesComprobanteDeCompraOrigenDestino relaciones)
		{
			
			switch(Action.ToUpper())
			{
				case "NEW":
				{
					
					this.IdComprobante = mz.erp.systemframework.Util.NewStringId();
					this.IdResponsable =  Security.IdPersona;
					this.IdProveedor = Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault");
					this.FechaComprobante = DateTime.Now;
					this._itemsComprobantesCompras = new ItemsComprobantesCompra("New", this);
					//this.IdComprobanteDestino = "CPE";
					this._tipoComprobanteDestino = "CPE";
					//this.TipoComprobanteDestino = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this.IdComprobanteDestino).Descripcion;

					if(item != null)
					{
						ItemComprobanteCompra  itemCompra = new ItemComprobanteCompra(item, this._itemsComprobantesCompras);
						this._itemsComprobantesCompras.Add(itemCompra);
					}


					


					break;
				}
				case "EDIT":
				{
					tpu_ComprobantesExDataset.tpu_ComprobantesDataTable tableComp = this.DatasetComprobante.tpu_Comprobantes;
					tpu_ComprobantesExDataset.tpu_ComprobantesRow rowComp =(tpu_ComprobantesExDataset.tpu_ComprobantesRow) tableComp.Rows[0];
					
					this.IdComprobante = rowComp.IdComprobante;
					this.IdComprobanteDestino = rowComp.IdComprobante;
					this.IdResponsable = rowComp.IdResponsable;
					this.FechaComprobante = rowComp.Fecha;
					
					this.TipoComprobanteDestino = rowComp.IdTipoDeComprobante;
					this.IdProveedor = rowComp.IdProveedor;
					this.Total = rowComp.Total;
					this._itemsComprobantesCompras = new ItemsComprobantesCompra("New", this);
					ItemComprobanteCompra  itemCompra;
					tpu_ComprobantesExDataset.tpu_ComprobantesDetDataTable tableDet = this.DatasetComprobante.tpu_ComprobantesDet;
					foreach(tpu_ComprobantesExDataset.tpu_ComprobantesDetRow rowDet in tableDet.Rows)
					{	
						itemCompra = new ItemComprobanteCompra(rowDet, this._itemsComprobantesCompras);
						this._itemsComprobantesCompras.Add(itemCompra);


					}
					if(item != null)
					{
						if(!this._itemsComprobantesCompras.Contains(item))
						{
							itemCompra = new ItemComprobanteCompra(item, this._itemsComprobantesCompras);
							this._itemsComprobantesCompras.Add(itemCompra);
						}
					}


					

					break;
				}



			}
		}

		public bool IsValid()
		{
			bool isValid = true;
			if ((this.IdProveedor == null) || (this.IdProveedor == string.Empty))
			{
				isValid = false;
				this.DatasetComprobante.tpu_Comprobantes.Rows[0].SetColumnError("IdProveedor","El Proveedor  no puede ser nulo");
			}
			if ((this.IdResponsable == null) || (this.IdResponsable == string.Empty))
			{
				isValid = false;
				this.DatasetComprobante.tpu_Comprobantes.Rows[0].SetColumnError("IdResponsable","El responsable de emisión/modificación no puede ser nulo");
			}

			return isValid;
		}
		#endregion

		#region Constructor
		public ComprobanteDeCompra(string action, string idComprobante, string Momento, string idCuenta, System.DateTime Fecha, string idResponsable, string idCondicionDeVenta, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{
			switch ( action.ToUpper() )
			{
				case "NEW":
					this._state = "NEW";
					//FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, mz.erp.businessrules.sy_Usuarios.GetByPk(Security.IdUsuario).IdPersona, idCuenta, idCondicionDeVenta, relaciones);
					//FillStaticData( );
					break;
				case "EDIT":
					this._state = "EDIT";
					//this.AllowEdit = false;
					//FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, idResponsable, idCuenta, idCondicionDeVenta, relaciones);
					
					break;
				case "STEP":
					this._state = "STEP";
					//FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, idResponsable, idCuenta, idCondicionDeVenta, relaciones);
					//FillStaticData( );
					this.IdComprobante = Util.NewStringId();										
					break;
			}
			//	SetEditablesProperty();

		}

		private void FillLoadData( string IdComprobante, string state, string TipoComprobanteDestino, string IdResponsable, string idCuenta, string idCondicionDeVenta, RelacionesComprobanteOrigenDestino relaciones)
		{
		
			switch (state)
			{
				case "STEP":
				{
					this.DatasetComprobante = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
					
					this.IdResponsable = relaciones.IdResponsable;
					//this.VariablesComprobante = new VariablesAuxiliares( "NEW", this );
					
					//this.Cuenta = new Cuenta( "EDIT", this, relaciones.IdCuenta );
					//this.IdCuenta = relaciones.IdCuenta;

					this.TipoComprobanteDestino = TipoComprobanteDestino;

					this.FechaComprobante = System.DateTime.Now;
					this.IdComprobante = Util.NewStringId();
					
					this.Numero = string.Empty;
					//this.TemporalNumeration = true;
					
					

					//this.Items = new ItemsComprobantes("STEP", this, relaciones);
					//this.Items.IsDirty=false;
					
					//this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, idCondicionDeVenta );
					//long condicionPorDefecto = ComprobantesRules.Momentos_FormaDePago_Default(this.Momento); 
					//if ( ! (condicionPorDefecto == long.MinValue))
					//	this.CondicionDeVenta.IdCondicionDeVenta = Convert.ToString(condicionPorDefecto);
					
					this.Total= 0;
					break;					
				}
				case "EDIT":
				{
					this.DatasetComprobante = mz.erp.businessrules.tpu_ComprobantesEx.GetList(IdComprobante );
					tpu_ComprobantesExDataset.tpu_ComprobantesRow rowComprobante = (tpu_ComprobantesExDataset.tpu_ComprobantesRow)this.DatasetComprobante.tpu_Comprobantes.Rows[0];
					this.IdResponsable = rowComprobante.IdResponsable;
					

					this.TipoComprobanteDestino = rowComprobante.IdTipoDeComprobante; 
					this.FechaComprobante = rowComprobante.Fecha;
					this.IdComprobante = rowComprobante.IdComprobante;
					this.Numero = rowComprobante.Numero;
					//this.TemporalNumeration = false;
					

					//this.VariablesComprobante = new VariablesAuxiliares( "EDIT", this );
					//this.Cuenta = new Cuenta( "EDIT", this, rowComprobante.IdCuenta );
					//this.IdCuenta = rowComprobante.IdCuenta;

					
					
					
					//this.Items = new ItemsComprobantes("EDIT", this );
					//this.Items.IsDirty=false;
					
					//this.CondicionDeVenta = new CondicionDeVenta("EDIT", this );
					this.Total= rowComprobante.Total;
					break;					
				}

				case "NEW":
				{
					this.DatasetComprobante = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
					//Modificar para tomar el responsable por defecto
					
					this.IdResponsable = IdResponsable;
					
				
					//this.Cuenta = new Cuenta( "NEW", this, idCuenta);
					//this.IdCuenta = idCuenta;

					//this.TipoComprobanteDestino = Cuenta.ComprobanteDeVentaSugerido();

					this.FechaComprobante = System.DateTime.Now;
					this.IdComprobante = Util.NewStringId();

					this.Numero = string.Empty;
					//this.TemporalNumeration = true;
					
					
					//this.VariablesComprobante = new VariablesAuxiliares( "NEW", this );
					
					//this.Items = new ItemsComprobantes( "NEW", this );
					//this.Items.IsDirty=false;
					
					/*this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, idCondicionDeVenta );
					long condicionPorDefecto = ComprobantesRules.Momentos_FormaDePago_Default(this.Momento); 
					if ( ! (condicionPorDefecto == long.MinValue))
						this.CondicionDeVenta.IdCondicionDeVenta = Convert.ToString(condicionPorDefecto);*/
					this.Total= 0;
		
					break;
				}
			}
			
			//InitEvents();
		}


		#endregion

		#region Persistencia
		private string _fileName;
		[XmlIgnore]
		public string FileName
		{
			get{ return _fileName; }
			set{ _fileName = value; }
		}


		public static ComprobanteDeCompra Read(string fileName)
		{
			return Read( new FileStream( fileName, FileMode.Open, FileAccess.Read, FileShare.Read ) );
		}

		public static ComprobanteDeCompra Read( Stream stream )
		{
			stream.Position = 0;

			XmlSerializer serializer = new XmlSerializer( typeof( ComprobanteDeCompra ) );
			XmlReader reader = new XmlTextReader( stream );
          
			ComprobanteDeCompra j = ( ComprobanteDeCompra )serializer.Deserialize( reader );
			reader.Close();

			//j.FileName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

			return j;
		}
		public static ComprobanteDeCompra  Read( byte[] bytes )
		{
			MemoryStream ms = new MemoryStream();
			ms.Write( bytes, 0, bytes.Length );

			return Read( ms );
		}

		public void Save(string fileName)
		{
			XmlSerializer serializer = new XmlSerializer( typeof( ComprobanteDeCompra ) );

			Stream fs = new FileStream( fileName, FileMode.Create, FileAccess.Write, FileShare.None );
			XmlWriter writer = new XmlTextWriter( fs, new UTF8Encoding() );
			try
			{
				serializer.Serialize( writer, this );
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

		#region Commit

		public void Commit()
		{
			DatasetComprobante = new mz.erp.commontypes.data.tpu_ComprobantesExDataset();
			tpu_ComprobantesExDataset.tpu_ComprobantesRow row = DatasetComprobante.tpu_Comprobantes.Newtpu_ComprobantesRow();

			row.Fecha = System.DateTime.Now;
			row.FechaCreacion = System.DateTime.Now;
			row.IdComprobante = this.IdComprobante;
			row.IdProveedor = this.IdProveedor;
			row.IdResponsable = this.IdResponsable;
		

			row.IdTipoDeComprobante = this.TipoComprobanteDestino;
			row.Numero = "";//Util.NewStringId();
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.Total = this.Total;

			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
		
			row.IdEmpresa = this.IdEmpresa;
			row.IdSucursal = this.IdSucursalDestinoDatos;

			row.IdInstanciaCaja = string.Empty;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdReservado = 0;
		
			this.Numero = row.Numero;
			
			DatasetComprobante.tpu_Comprobantes.Addtpu_ComprobantesRow( row );
		
			this.Items.Commit();
			//this.CondicionDeVenta.Commit();
			//this.VariablesComprobante.Commit();

			
		}

		public  void  Flush()
		{
			
			if(this.Momento.Equals("Prepedir"))
				
				
				this.DatasetComprobante.WriteXml(mz.erp.systemframework.Util.ResourcePath() + "/temp/pedido"+Security.IdUsuario+".xml");
			else
			{
				long IdSucursalDestino = long.MinValue;
				if (this.IdSucursal != this.IdSucursalDestinoDatos)
				{
					IdSucursalDestino = this.IdSucursalDestinoDatos;
				}
				mz.erp.businessrules.tpu_ComprobantesEx.Update( this.DatasetComprobante,  this.ActualizaNumeracion, this.Momento, IdSucursalDestino);
				if(this.Momento.Equals("Pedir"))
				{
					string FileName = mz.erp.businessrules.tpu_ComprobantesEx.NextFileName();
					this.DatasetComprobante.WriteXml(mz.erp.systemframework.Util.ResourcePath()+ "/Pedidos/" + FileName + ".xml"  );
					this.DeleteFile();

				}
			}
		
		}	
		

		#endregion

		#region Variables de estado
		private void SetEditablesProperty()
		{
			string cMomento = this.Momento;
			AllowEditTipoDeComprobante =false;// ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.TComp");
			AllowEditProveedor =false;// ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.Proveedor");
			AllowEditFecha =true;// ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.Fecha");
			AllowEditFormasDePago =false; //ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.FPago");
			AllowEditCondicionDeVenta = false;//ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.CondVenta");
			AllowEditItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.Items");
			AllowEditResponsableEmision =false;// ComprobantesRules.Momentos_Parametros_Bool( this.Momento, "Emision.Editar.REmision");
		}

		private bool _allowEditTipoDeComprobante = true;
		public bool AllowEditTipoDeComprobante
		{
			set { _allowEditTipoDeComprobante = value; }
			get { return _allowEditTipoDeComprobante; }
		}
		private bool _allowEditProveedor = true;
		public bool AllowEditProveedor
		{
			set { _allowEditProveedor = value; }
			get { return _allowEditProveedor; }
		}
		private bool _allowEditFecha = true;
		public bool AllowEditFecha
		{
			set { _allowEditFecha = value; }
			get { return _allowEditFecha; }
		}
		private bool _allowEditResponsableEmision = true;
		public bool AllowEditResponsableEmision
		{
			set { _allowEditResponsableEmision = value; }
			get { return _allowEditResponsableEmision; }
		}
		private bool _allowEditCondicionDeVenta = true;
		public bool AllowEditCondicionDeVenta
		{
			set { _allowEditCondicionDeVenta = value; }
			get { return _allowEditCondicionDeVenta; }
		}
		private bool _allowEditItems = true;
		public bool AllowEditItems
		{
			set { _allowEditItems = value; }
			get { return _allowEditItems; }
		}
		private bool _allowEditFormasDePago = true;
		public bool AllowEditFormasDePago
		{
			set { _allowEditFormasDePago = value; }
			get { return _allowEditFormasDePago; }
		}

		private bool _actualizaNumeracion = true;

		public bool ActualizaNumeracion 

		{

			set { _actualizaNumeracion = value;}

			get { return _actualizaNumeracion; }

		}
		#endregion

		#region DeleteFile

		private void DeleteFile()
		{
			string sourceFileName =  mz.erp.systemframework.Util.ResourcePath()+ "/Temp/pedido" + Security.IdUsuario+ ".xml";
			if ( File.Exists( sourceFileName ) )
			{
				
					File.Delete( sourceFileName );
				
			}
		}
		#endregion
	


	}
}
