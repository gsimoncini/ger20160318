using System;
using System.Data.SqlClient;
using mz.erp.dataaccess;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Reflection;
using System.Collections;
using mz.erp.dataaccess;
using System.Data.SqlClient;
namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Bonificacion.
	/// </summary>
	public class Bonificacion
	{
		public Bonificacion()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public event EventHandler BonificacionesDetalleHasChanged;
		public event EventHandler TipoBonificacionHasChanged;
	
		#region variables privadas
		private string _idBonificacion=string.Empty;
		private string _descripcion=string.Empty;
		private string _codigo=string.Empty;
		private string _tipoBonificacion=string.Empty;
		private BonificacionItem _selectedItem=new BonificacionItem();
		private ArrayList _bonificacionesDetalle=new ArrayList();
		private bool _itemsValidos=true;
		private BonificacionItem _itemActual=new BonificacionItem();
		private mz.erp.commontypes.data.tsa_BonificacionesDataset _data = new mz.erp.commontypes.data.tsa_BonificacionesDataset();
		private mz.erp.commontypes.data.tsa_BonificacionesDetDataset _dataDetalle = new mz.erp.commontypes.data.tsa_BonificacionesDetDataset();
		
		#endregion
		#region property
		public bool ItemsValidos
		{
			get{return _itemsValidos;}
			set{_itemsValidos=value;}
		}

		public string IdBonificacion
		{
			get
			{
				return _idBonificacion;
			}
			set
			{ if (_idBonificacion!=value){
				  _idBonificacion= value;
				
			  
			  }
			}
		}

		public string Codigo
		{
			get
			{
				return _codigo;
			}
			set
			{
			if (_codigo!=value)
			  {
				  _codigo= value;
				
			  }
			}
		}
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (_descripcion!=value){
					_descripcion= value;
					
				
				}
			}
		}
		public string TipoBonificacion
		{
			get
			{
				return _tipoBonificacion;
			}
			set
			{
				if (_tipoBonificacion!=value)
				{
					_tipoBonificacion= value;
					if (TipoBonificacionHasChanged!=null)
						TipoBonificacionHasChanged(this, new EventArgs());
				}
			}
		}
		public ArrayList BonificacionesDetalle
		{
			get
			{
				return _bonificacionesDetalle;
			}
			set
			{
				_bonificacionesDetalle= value;
			/*	if (BonificacionesDetalleHasChanged!=null)
					BonificacionesDetalleHasChanged(this, new EventArgs());*/
			}
		}

		public decimal Maximo
		{
			get{return _selectedItem.Maximo;}
			set{_selectedItem.Maximo=Convert.ToDecimal(value);}
		}
		public decimal Minimo
		{
			get{return _selectedItem.Minimo;}
			set{_selectedItem.Minimo=Convert.ToDecimal(value);}
		}
        //German 20120208 - Tarea 0000276
		public decimal Valor
		{
			get{return _selectedItem.Valor;}
			set{_selectedItem.Valor=value;}
		}
        //German 20120208 - Tarea 0000276
		public BonificacionItem SelectedItem
		{
			get{return _selectedItem;}
			set
			{
				if(value != null)
				{
					BonificacionItem item = (BonificacionItem) value;
					if(_selectedItem != item)
					{
						_selectedItem = item;
						/*if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());*/
					}
				}
								
			}
		}

		
		#endregion
		#region comportamiento
		#endregion
		#region metodos publicos
		public void AgregarBonificacionDetalle(BonificacionItem bonif)
		{
			this._bonificacionesDetalle.Add(bonif);
			
		}

		public void EliminarBonificacionDetalle(BonificacionItem bonif)
		{
			this._bonificacionesDetalle.Remove(bonif);
			//return _bonificacionesDetalle.
			
		}
		public BonificacionItem NuevoDetalle()
		{
			BonificacionItem bonif= new BonificacionItem();
    		_itemActual=bonif;
			//this.AgregarBonificacionDetalle(bonif);
			return bonif;
		
			
		}
		public void AgregarDetalleActual()
		{

            //German 20120208 - Tarea 0000276
            _itemActual.Maximo = this.Maximo;
            _itemActual.Minimo = this.Minimo;
            _itemActual.Valor = this.Valor;
            //Fin German 20120208 - Tarea 0000276
			this.AgregarBonificacionDetalle(_itemActual);	
			_itemActual= new BonificacionItem();
		}
		//Recorre sus items y determina si el nuevo item es valido o no

		public bool ItemValido(decimal maximo, decimal minimo )
		{
			 bool ok= true;
			foreach (BonificacionItem item in this.BonificacionesDetalle){
					ok=ok && item.Validar(maximo, minimo);
			
			}
			this._itemsValidos=ok;
			return ok;
		}
		public bool ItemValido(BonificacionItem detalle )
		{
			bool ok= true;
			foreach (BonificacionItem item in this.BonificacionesDetalle)
			{   //si no es el mismo item, comparalos 
				if (!item.Equals(detalle))
					ok=ok && item.Validar(detalle.Maximo,detalle.Minimo);
			
			}
			return ok;
		}

		public void Commit(){
			//Si el id de bonificacion es "" es un alta
			if (this._idBonificacion.Equals(string.Empty))
			{
				#region alta
				tsa_BonificacionesDataset.tsa_BonificacionesRow _row = _data.tsa_Bonificaciones.Newtsa_BonificacionesRow();
				_row = tsa_Bonificaciones.SetRowDefaultValues( _row);
				_row["descripcion"] = this._descripcion;
				_row["codigo"]=this._codigo;
				_row["IdTipoBonificacion"]=this._tipoBonificacion;
				_data.Tables[0].Rows.Add(_row);	
				int i=1;
				foreach(BonificacionItem b in this.BonificacionesDetalle)
				{
					tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow _rowDetalle= _dataDetalle.tsa_BonificacionesDet.Newtsa_BonificacionesDetRow();
					_rowDetalle=tsa_BonificacionesDet.SetRowDefaultValues(_rowDetalle);
					_rowDetalle["ordinal"]=i;
					if (b.Maximo.Equals(Decimal.MaxValue)||b.Maximo==0)
						_rowDetalle["maximo"]=System.DBNull.Value;
					else
						_rowDetalle["maximo"]=b.Maximo;
					_rowDetalle["minimo"]=b.Minimo;
					_rowDetalle["valor"]=Convert.ToDecimal(b.Valor);
					_dataDetalle.Tables[0].Rows.Add(_rowDetalle);
					i++;			
			
				}
				#endregion
			}
				//Es una actualización
			else
			{
				#region actualizacion
				tsa_BonificacionesDataset.tsa_BonificacionesRow _row = tsa_Bonificaciones.GetByPk(this._idBonificacion);
				_row["descripcion"] = this._descripcion;
				_row["codigo"]=this._codigo;
				_row["IdTipoBonificacion"]=this._tipoBonificacion;
				_data.Tables[0].ImportRow(_row);
			
				_dataDetalle=tsa_BonificacionesDet.GetList(this.IdBonificacion,Decimal.MinValue);
				if (_dataDetalle.Tables[0].Rows.Count!=0)
					{	foreach (tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row in _dataDetalle.Tables[0].Rows)
						{
						row.Delete();
						}
					}
				int i=1;
				foreach(BonificacionItem b in this.BonificacionesDetalle)
				{
					tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow _rowDetalle= _dataDetalle.tsa_BonificacionesDet.Newtsa_BonificacionesDetRow();
					_rowDetalle=tsa_BonificacionesDet.SetRowDefaultValues(_rowDetalle);
					_rowDetalle["idBonificacion"]=this._idBonificacion;
					_rowDetalle["ordinal"]=i;
					if (b.Maximo.Equals(Decimal.MaxValue)||b.Maximo==0)
						_rowDetalle["maximo"]=System.DBNull.Value;
					else
						_rowDetalle["maximo"]=b.Maximo;
					_rowDetalle["minimo"]=b.Minimo;
					_rowDetalle["valor"]=Convert.ToDecimal(b.Valor);
					_dataDetalle.Tables[0].Rows.Add(_rowDetalle);
					i++;			
			
				}
				#endregion
				
			}
			
		
		}

		public void Flush(string IdTransaction)
		{	
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			#region alta
			if (this.IdBonificacion.Equals(string.Empty))
			{
				dataaccess.tsa_Bonificaciones.Update( (tsa_BonificacionesDataset.tsa_BonificacionesDataTable) _data.Tables[0],trx);
				//Mando a actualizar los detalles, con el id de la bonificacion agregada :D
                //German 20120208 - Tarea 0000276
				//tsa_BonificacionesDataset resul =tsa_Bonificaciones.GetList(null, null, null, this.Codigo);

                string idBonificacion = Convert.ToString(_data.Tables[0].Rows[0]["IdBonificacion"]);
                //Fin German 20120208 - Tarea 0000276

				foreach(tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row in _dataDetalle.Tables[0].Rows)
				{
					row["IdBonificacion"]=idBonificacion;		
				}
				if (_dataDetalle.Tables[0].Rows.Count>0)
					dataaccess.tsa_BonificacionesDet.Update( (tsa_BonificacionesDetDataset.tsa_BonificacionesDetDataTable) _dataDetalle.Tables[0],trx);
			}
				#endregion
				#region modificacion
				else
				{
				
					dataaccess.tsa_Bonificaciones.Update( (tsa_BonificacionesDataset.tsa_BonificacionesDataTable) _data.Tables[0],trx);
					if (_dataDetalle.Tables[0].Rows.Count>0)
						dataaccess.tsa_BonificacionesDet.Update( (tsa_BonificacionesDetDataset.tsa_BonificacionesDetDataTable) _dataDetalle.Tables[0],trx);
				}
			#endregion

			
		}

		public ArrayList BuscarDetalles(){
			ArrayList detalle=new ArrayList();
			tsa_BonificacionesDetDataset dato=tsa_BonificacionesDet.GetList(this.IdBonificacion,Decimal.MinValue);
			if (dato.Tables[0].Rows.Count!=0)
			foreach (tsa_BonificacionesDetDataset.tsa_BonificacionesDetRow row in dato.Tables[0].Rows){
				BonificacionItem item = new BonificacionItem();
				item.IdBonificacion=Convert.ToString(row["IdBonificacion"]);
				item.Ordinal=Convert.ToInt32(row["Ordinal"]);
				item.Valor=Convert.ToInt32(row["Valor"]);
				item.Minimo=Convert.ToDecimal(row["Minimo"]);
				if (row["Maximo"]!=System.DBNull.Value)
					item.Maximo=Convert.ToDecimal(row["Maximo"]);
				else item.Maximo=Decimal.MaxValue;
				detalle.Add(item);				
				}
			return detalle;
			
		}
        //German 20120208 - Tarea 0000276
		public decimal BonificacionAAplicar(decimal cantidad){
			int valor=0;
			foreach(BonificacionItem item in this.BonificacionesDetalle){
			      if (item.Minimo<=cantidad && cantidad<=item.Maximo)
					  return item.Valor;

			}
			return valor;
		
		}
        //German 20120208 - Tarea 0000276
		public void CargarDetalle(){
				this.BonificacionesDetalle=BuscarDetalles();
		
		}

        //German 20120208 - Tarea 0000276
        public void setPrecioFinalProducto(decimal precioFinal)
        {

            foreach (BonificacionItem item in this.BonificacionesDetalle)
            {
                item.setPrecioFinal(precioFinal);
            }

        }

        //German 20120208 - Tarea 0000276
		#endregion
	

	}
	#region clases auxiliares
	public class BonificacionItem
	{
		public BonificacionItem()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		
		
		}
		#region variables privadas
		private string _idBonificacion=string.Empty;
		private int _ordinal=0;
		private decimal _maximo=0;
		private decimal _minimo=0;
        //German 20120208 - Tarea 0000276
		//private int _valor=0;
        private decimal _valor = 0;
        //German 20120208 - Tarea 0000276
        //German 20120208 - Tarea 0000276
        private decimal _precioFinal = 0;
        private decimal _montoBonificacion = 0;
        private decimal _precioFinalBonificacionesAplicadas = 0;
        //German 20120208 - Tarea 0000276
		#endregion
		#region propiedades

        //German 20120208 - Tarea 0000276
        public decimal PrecioFinal
        {
            get
            {
                return _precioFinal;
            }
            
        }

        public decimal PrecioFinalBonificacionesAplicadas
        {
            get
            {
                return _precioFinalBonificacionesAplicadas;
            }

        }
        public decimal MontoBonificacion
        {
            get
            {
                return _montoBonificacion;
            }

        }
        //German 20120208 - Tarea 0000276
		public string IdBonificacion
		{
			get
			{
				return _idBonificacion;
			}
			set
			{
				_idBonificacion= value;
			}
		}
		
		public decimal Maximo
		{
			get
			{
				return _maximo;
			}
			set
			{
				_maximo=Convert.ToDecimal(value);
			}
		}
		public decimal Minimo
		{
			get
			{
				return _minimo;
			}
			set
			{
				_minimo= Convert.ToDecimal(value);
			}
		}
        //German 20120208 - Tarea 0000276
		public decimal Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				_valor= value;
			}
		}
        //German 20120208 - Tarea 0000276
		public int Ordinal
		{
			get
			{
				return _ordinal;
			}
			set
			{
				_ordinal= value;
			}
		}

		#endregion
		#region metodos publicos

        //German 20120208 - Tarea 0000276
        public void setPrecioFinal(decimal precioFinal)
        {
            _precioFinal = precioFinal;
            _precioFinalBonificacionesAplicadas = _precioFinal + (_precioFinal * _valor / 100);
            _montoBonificacion = _precioFinal * _valor / 100;
        }

        //German 20120208 - Tarea 0000276
		public bool Validar(decimal maximo,decimal minimo)
		{	bool ok= true;
			
			if (this.Maximo!=0 && maximo!=0)
				if ((this.Minimo<=minimo && minimo<=this.Maximo)||(this.Minimo<=maximo && maximo<=this.Maximo)|| (minimo<=this.Minimo && this.Maximo<=maximo))
				 ok=false;
			//no tiene maximo establecido, entonces es entre el minimo en adelante
			if (this.Maximo==0 && maximo!=0)
					if ((this.Minimo<=minimo)||(this.Minimo<=maximo))
						ok=false;
			//Si ambos se establecen como sin limite en algun lugar se superponen
			 if (this.Maximo==0 && maximo==0)
							ok=false;
	
			if (this.Maximo!=0 && maximo==0)
				if (minimo<=this.Maximo)
						ok=false;
			return ok;

		}
		#endregion
	}
	#endregion
}
