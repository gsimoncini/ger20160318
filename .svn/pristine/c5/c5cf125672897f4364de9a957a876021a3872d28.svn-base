using System;
using System.Collections;
using mz.erp.io;
using mz.erp.businessrules;
using mz.erp.systemframework;

namespace mz.erp.ui.controllers.reportes
{		
	/// <summary>
	/// Descripción breve de OrdenDePreparado.
	/// </summary>
	/// 
	/*public class OrdenDePreparadoItem
	{
		string _codigo;

		public string Codigo 
		{
			set {_codigo = value;}
			get {return _codigo;}
		}
		public OrdenDePreparadoItem()
		{
		}
	}*/

	public class OrdenDePreparado		
	{
		DateTime _fecha;
		string _hora;
		string _cliente;
		string _clienteCodigo;
		string _direccion;
		string _localidad;
		string _telefono;
		string _lugarDeEntrega;
		DateTime _fechaDeEntrega;
		string _vendedor;
		string _observaciones;
		string _comprobante;				
		string _tipoImpresora = "";

		decimal _saldo;
		ArrayList _items;

		public DateTime Fecha 
		{
			set {_fecha = value;}
			get {return _fecha;}
		}
		public string Hora
		{
			set {_hora = value;}
			get {return _hora;}
		}
		public string Cliente
		{
			set {_cliente = value;}
			get 
			{				
				string cadena = _cliente + systemframework.Util.Replicate(' ',100);
				return cadena.Substring(0,30);
			}
		}
		public string ClienteCodigo
		{
			set {_clienteCodigo = value;}
			get {return _clienteCodigo;}
		}
		public string Direccion
		{
			set {_direccion = value;}
			get {return _direccion;}
		}
		public string Localidad
		{
			set {_localidad = value;}
			get {return _localidad;}
		}
		public string Telefono
		{
			set {_telefono = value;}
			get {return _telefono;}
		}
		public string LugarDeEntrega
		{
			set {_lugarDeEntrega = value;}
			get {return _lugarDeEntrega;}
		}
		public DateTime FechaDeEntrega
		{
			set {_fechaDeEntrega = value;}
			get {return _fechaDeEntrega;}
		}
		public string Vendedor
		{
			set {_vendedor = value;}
			get {return _vendedor;}
		}
		public string Observaciones
		{
			set {_observaciones = value;}
			get {return _observaciones;}
		}
		public string Comprobante
		{
			set {_comprobante = value;}
			get {return _comprobante;}
		}
		public decimal Saldo
		{
			set {_saldo = value;}
			get {return _saldo;}
		}
		/*public ArrayList Items 
		{
			set {_items = value;}
			get {return _items;}
		}*/

		public OrdenDePreparado()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			//Init();			
		}

		public void Print() 
		{
			//string nombreReporte = "OrdenDePreparado.rpx";
			//Report.PrintReport(nombreReporte);
		}

		/*public void Print() 
		{  
			
			ArrayList impresion = new ArrayList();
			impresion = this.Cargar();  //Dibuja todo el diseño de la orden de preparado en un ArrayList

			PrinterController pd = new PrinterController(_tipoImpresora);			
			pd.Copias = 1;
			pd.RenglonesPorHoja = 33;

			for (int i= 0; i < impresion.Count; i++) 
			//Acá recorro todo el arraylist y elimino caracteres extraños para las impresoras
			{				
				impresion[i] = systemframework.Util.ArregloCadena(impresion[i].ToString());				
			}
			pd.Print(impresion); 
		}*/

		/*private void Init() 
		{		
			_tipoImpresora = Variables.GetValueStringWithoutCache("IO.Impresion.OrdenDePreparado.TipoImpresora");		

			this.Direccion = "Av.44 Nro. 1145 entre Cno. Gral. Belgrano y Papini";
			this.Hora = "15:52";
			this.Telefono = "(02229) 452-2342";
			this.LugarDeEntrega = "casa de rejas negras";
			this.Fecha = Convert.ToDateTime("20/09/2005");
			this.FechaDeEntrega  = Convert.ToDateTime("10/10/2005");
			this.Localidad = "J.M. Gutiérrez";
			this.Cliente = "Oscar R. López";
			this.ClienteCodigo = "00001234";
			this.Vendedor = "Pedro Gómez";
			this.Observaciones = "Estas son observaciones para la orden de preparado";
			this.Comprobante = "A-1234-12349234";
			this.Saldo = Convert.ToDecimal("1.23");

			//OrdenDePreparadoItem item = new OrdenDePreparadoItem();
		}*/

		/*private ArrayList Cargar()
		{	
			ArrayList lineas = new ArrayList();			
			lineas.Add("Fecha: " + this.Fecha.ToShortDateString() + "Hora: " + this.Hora.ToString());			
			lineas.Add("Pedido del cliente: " + this.Cliente + " " + this.ClienteCodigo);
			lineas.Add("Direccion: " + this.Direccion);
			lineas.Add("Localidad: " + this.Localidad);
			lineas.Add("Telefono: " + this.Telefono + " Saldo: " + this.Saldo);
			lineas.Add("Fecha y lugar de entrega: " + this.FechaDeEntrega.ToShortDateString() + " " + this.LugarDeEntrega);			
			lineas.Add("Obs: " + this.Observaciones);
			lineas.Add("Comprobante: " + this.Comprobante + " Vendedor: " + this.Vendedor);
			lineas.Add(systemframework.Util.Replicate('-',80));
			lineas.Add("Codigo  Articulo" + systemframework.Util.Replicate(' ',33) + "Unidad   Cant Stock  Ubic M2xC");
			lineas.Add(systemframework.Util.Replicate('-',80));
			CargarItems(ref lineas);
			lineas.Add(systemframework.Util.Replicate('-',80));
			return lineas;
		}*/

		public void CargarItems(ref ArrayList lineas) 
		{
			lineas.Add("item 1 item 1 item 1 item 1 item 1 item 1 item 1 item 1 item 1");
			lineas.Add("item 2 item 2 item 2 item 2 item 2 item 2 item 2 item 2 item 2");
			lineas.Add("item 3 item 3 item 3 item 3 item 3 item 3 item 3 item 3 item 3");
			lineas.Add("item 4 item 4 item 4 item 4 item 4 item 4 item 4 item 4 item 4");
			lineas.Add("item 5 item 5 item 5 item 5 item 5 item 5 item 5 item 5 item 5");
			lineas.Add(systemframework.Util.Replicate('-',80));
			lineas.Add("item 1 item 1 item 1 item 1 item 1 item 1 item 1 item 1 item 1");


		}

	}
}
