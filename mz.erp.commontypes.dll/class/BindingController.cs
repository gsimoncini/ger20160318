using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;

namespace mz.erp.commontypes
{
	/// <summary>
	///Esta clase tiene como ebjetivo imitar el comportamiento del DataBinding de .Net, pero a su vez
	///corrigiendo algunos de los bugs que contiene la implementacion en .Net. La idea es que se mantenga
	///en todo momento consistente la interfaz grafica con el modelo bindeado, sin tener en cuenta el estado
	///del control bindeado, esto es, si tiene el foco o si no, si ya se ha salido del control o no, etc...
	///Ademas esta clase permite q varias instancias del modelo se bindeen entre si, sin q el source sea necesariamente
	///un Control de interfaz grafica
	/// </summary>
	public class BindingController
	{
		
		#region Constructor
		public BindingController(object source , string sourceProp, object target, string targetProp)
		{
			this._source = source;
			this._sourceProperty = sourceProp;
			this._target = target;
			this._targetProperty = targetProp;
			Type sourceType=this._source.GetType();
			Type targetType=this._target.GetType();
			this._sourcePropertyInfo=sourceType.GetProperty(this._sourceProperty);
			this._targetPropertyInfo=targetType.GetProperty(this._targetProperty);
		}

		#endregion

		#region variables Privadas

			protected object _source;
			protected object _target;
			protected string _sourceProperty;
			protected string _targetProperty;
			protected PropertyInfo _sourcePropertyInfo;
			protected PropertyInfo _targetPropertyInfo;
			private static ArrayList _instances = new ArrayList();

		#endregion

		#region Propiedades

		public object Source
		{
			get
			{
				return _source;
			}
		}

		public object Target
		{
			get
			{
				return _target;
			}
		}

		public string SourceProperty
		{
			get
			{
				return _sourceProperty;
			}
		}

		public string TargetProperty
		{
			get
			{
				return _targetProperty;
			}
		}

		public PropertyInfo SourcePropertyInfo
		{
			get
			{
				return _sourcePropertyInfo;
			}
		}
		
		public PropertyInfo TargetPropertyInfo
		{
			get
			{
				return _targetPropertyInfo;
			}
		}

		#endregion

		#region Metodo estatico Bind


		
		public static void Bind(object source, string sourceProp, object target, string targetProp)
		{
			string sourceEvent=sourceProp+"Changed";
			string targetEvent=targetProp+"Changed";
			Type sourceType=source.GetType();
			Type targetType=target.GetType();
			EventInfo ei1=sourceType.GetEvent(sourceEvent);
			EventInfo ei2=targetType.GetEvent(targetEvent);
			BindingController bh=new BindingController(source, sourceProp, target, targetProp);
			_instances.Add(bh);
			ei1.AddEventHandler(source, new EventHandler(bh.SourceChanged));
			ei2.AddEventHandler(target, new EventHandler(bh.TargetChanged));
			bh.TargetChanged(bh, EventArgs.Empty);
		}
		#endregion

		#region Listener de Eventos
		private void SourceChanged(object sender, EventArgs e)
		{
			object val=this._sourcePropertyInfo.GetValue(this._source, null);
			this._targetPropertyInfo.SetValue(this._target, val, null);
		}

		private void TargetChanged(object sender, EventArgs e)
		{
			object val=this._targetPropertyInfo.GetValue(this._target, null);
			this._sourcePropertyInfo.SetValue(this._source, val, null);
		}

		private void OnLeave(object sender, EventArgs e)
		{
			object val=this._sourcePropertyInfo.GetValue(this._source, null);
			this._targetPropertyInfo.SetValue(this._target, val, null);
		}

		public static void Clear(object source, string sourceProp, object target, string targetProp)
		{
			string sourceEvent=sourceProp+"Changed";
			string targetEvent=targetProp+"Changed";
			Type sourceType=source.GetType();
			Type targetType=target.GetType();
			EventInfo ei1=sourceType.GetEvent(sourceEvent);
			EventInfo ei2=targetType.GetEvent(targetEvent);
			BindingController bh = Find(source, sourceProp, target, targetProp);
			_instances.Remove(bh);
			ei1.RemoveEventHandler(source, new EventHandler(bh.SourceChanged));
			ei2.RemoveEventHandler(target, new EventHandler(bh.TargetChanged));
		}

		private static BindingController Find(object source, string sourceProp, object target, string targetProp)
		{
			foreach(BindingController bind in _instances)
			{
				if(bind.Source.Equals(source) && bind.SourceProperty.Equals(sourceProp)
					&& bind.Target.Equals(target) && bind.TargetProperty.Equals(targetProp))
					return bind;
			}
			return new BindingController(source, sourceProp, target, targetProp);
		}
	
		#endregion

	}
}
