using System;
using System.Data;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using System.Text;
using System.Collections;
using mz.erp.commontypes.data;
namespace  mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de AbmBonificacionesController.
	/// </summary>
	public class AbmBonificacionesController:ITaskController
	{
		public AbmBonificacionesController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public AbmBonificacionesController(AbmBonificaciones brClass)
		{
			_brClass = brClass;	
			Init();
		}
		#region Variables Privadas
			
		private AbmBonificaciones _brClass;
		private ProcessControllerManager _processManager;
		
		#endregion
		#region propiedades
		public event EventHandler BonificacionesDetalleChanged;
		public event EventHandler TipoBonificacionChanged;
		public event EventHandler CodigoChanged;
		public event EventHandler DescripcionChanged;
		public event EventHandler CodigoEdicionChanged;
		public event EventHandler TipoBonificacionEdicionChanged;
		public event EventHandler ObjectHasChanged;
		public event EventHandler MaximoChanged;
		public event EventHandler MinimoChanged;
		public event EventHandler ValorChanged;
		
			
			

		public ArrayList BonificacionesDetalle
		{
			get{return _brClass.BonificacionesDetalle;}
			set{_brClass.BonificacionesDetalle=value;}
			
		}
		public System.Data.DataTable Codigos
		{
			get{return _brClass.Codigos;}
			
			
		}
		public string TipoBonificacion
		{
			get{return _brClass.TipoBonificacion;}
			set{_brClass.TipoBonificacion=Convert.ToString(value);}
		}

		public string TipoBonificacionEdicion
		{
			get{return _brClass.TipoBonificacionEdicion;}
			set{_brClass.TipoBonificacionEdicion=Convert.ToString(value);}
		}

		
		public string Codigo
		{
			get{return _brClass.Codigo;}
			
			
			set{_brClass.Codigo=Convert.ToString(value);}
		}
		public string CodigoEdicion
		{
			get{return _brClass.CodigoEdicion;}
			set{_brClass.CodigoEdicion=Convert.ToString(value);}
		}

		public BonificacionItem SelectedItem
		{
			get{return _brClass.SelectedItem;}
			set{_brClass.SelectedItem = value;}
		}

		
		public string Descripcion
		{
			get{return _brClass.Descripcion;}
			set{_brClass.Descripcion=Convert.ToString(value);}
		}
		public decimal Maximo
		{
			get{return _brClass.Maximo;}
			set{_brClass.Maximo=Convert.ToDecimal(value);}
		}
		public decimal Minimo
		{
			get{return _brClass.Minimo;}
			set{_brClass.Minimo=Convert.ToDecimal(value);}
		}
		public decimal Valor
		{
			get{return _brClass.Valor;}
			set{_brClass.Valor= value;}
		}
		public string TextoBotonSiguiente
		{
			get 
			{
				return _brClass.TextoBotonSiguiente;
			}
		}
		public string Leyenda
		{
			get 
			{
				return _brClass.Leyenda;
			}
		}
		

		#endregion


		
		#region Miembros de ITaskController

		public bool IsFlushedState()
		{
			return this._processManager.ProcessFlushed;
		}

		public bool IsNextState()
		{
			return this._processManager.IsNextState();	
		}

		public bool IsBackState()
		{	
			return this._processManager.IsBackState();
		}

		public bool IsFirstTask()
		{
			return this._processManager.IsFirstTask(_brClass.GetTaskName());
		}

		public string GetTaskName()
		{
			return _brClass.GetTaskName();
		}

		
		
		public void SetProcessManager(ProcessControllerManager processManager)
		{
			_processManager = processManager;
		}
		public ProcessControllerManager GetProcessManager()
		{
			return _processManager;
		}

		public bool AllowPrevious()
		{
			return _brClass.AllowPrevious();
		}

		public void Previous()
		{
			_brClass.Previous();
		}
		
		public ItemsDatasetErrors GetErrors()
		{
			return _brClass.GetErrors();
		}
		public string GetWarnings()
		{
			return _brClass.GetWarnings();
		}
		public void Continue()
		{

		}

		public void Execute()
		{
			_brClass.Execute();
		}

		public bool AllowShow()
		{
			return _brClass.AllowShow();
		}

		#endregion

		#region metodos publicos
		public string GetLayout()
		{

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
						
			sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "IdBonificacion" ,true) );	
			sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal",true ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Minimo", "Mínimo", false ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Maximo", "Máximo", false ) );
			sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor", false ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		public void Init()
		{
			_brClass.BonificacionesDetalleHasChanged+=new EventHandler(_brClass_BonificacionesDetalleHasChanged);
			_brClass.DescripcionHasChanged+=new EventHandler(_brClass_DescripcionHasChanged);
			_brClass.CodigoHasChanged+=new EventHandler(_brClass_CodigoHasChanged);
			_brClass.TipoBonificacionHasChanged+=new EventHandler(_brClass_TipoBonificacionHasChanged);
			_brClass.CodigoEdicionHasChanged+=new EventHandler(_brClass_CodigoEdicionHasChanged);
			_brClass.TipoBonificacionEdicionHasChanged+=new EventHandler(_brClass_TipoBonificacionEdicionHasChanged);
			_brClass.ObjectHasChanged+=new EventHandler(_brClass_ObjectHasChanged);
			_brClass.MaximoHasChanged+=new EventHandler(_brClass_MaximoHasChanged);
			_brClass.MinimoHasChanged+=new EventHandler(_brClass_MinimoHasChanged);
			_brClass.ValorHasChanged+=new EventHandler(_brClass_ValorHasChanged);
			
			
		
		}

		public void NuevoDetalle()
		{
			_brClass.NuevoDetalle();
		}
		public void AgregarDetalleActual()
		{
			_brClass.AgregarDetalleActual();
		}
		
		public bool ItemValido(){
			return _brClass.ItemValido();
		}
		
		public void EliminarBonificacionDetalle(BonificacionItem bonif)
		{
			_brClass.EliminarBonificacionDetalle( bonif);
		}
		
		public string ContenedoresVisibles()
		{
		
			return _brClass.ContenedoresVisibles();
		}

		public void SeleccionarBonificacion()
		{
			_brClass.SeleccionarBonificacion();
		}
		public void ResetearBonificacion()
		{
			_brClass.ResetearBonificacion();
		}
		#endregion

		#region metodos privados
		private void _brClass_BonificacionesDetalleHasChanged(object sender, EventArgs e)
		{
			if (BonificacionesDetalleChanged!=null)
				BonificacionesDetalleChanged(this, new EventArgs());
		}

		private void _brClass_DescripcionHasChanged(object sender, EventArgs e)
		{
			if(DescripcionChanged!=null)
				DescripcionChanged(this, new EventArgs());
		}

		private void _brClass_CodigoHasChanged(object sender, EventArgs e)
		{
			if(CodigoChanged!=null)
				CodigoChanged(this, new EventArgs());
		}

		private void _brClass_TipoBonificacionHasChanged(object sender, EventArgs e)
		{
			if (TipoBonificacionChanged!=null)
				TipoBonificacionChanged(this, new EventArgs());
		}
		#endregion

		private void _brClass_CodigoEdicionHasChanged(object sender, EventArgs e)
		{
			if (CodigoEdicionChanged!=null)
				CodigoEdicionChanged(this, new EventArgs());
		}

		private void _brClass_TipoBonificacionEdicionHasChanged(object sender, EventArgs e)
		{
			if (TipoBonificacionEdicionChanged!=null)
				TipoBonificacionEdicionChanged(this, new EventArgs());
		}

		private void _brClass_ObjectHasChanged(object sender, EventArgs e)
		{
			if(ObjectHasChanged!=null)
				ObjectHasChanged(this, new EventArgs());
		}

		private void _brClass_MaximoHasChanged(object sender, EventArgs e)
		{
			if(MaximoChanged!=null)
				MaximoChanged(this, new EventArgs());
		}

		private void _brClass_MinimoHasChanged(object sender, EventArgs e)
		{
			if(MinimoChanged!=null)
				MinimoChanged(this, new EventArgs());
		}

		private void _brClass_ValorHasChanged(object sender, EventArgs e){
			if(ValorChanged!=null)
				ValorChanged(this, new EventArgs());

		}
	}
}
