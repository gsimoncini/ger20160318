using System;

public class EventArgsChange: EventArgs
{
	/// <summary>
	/// Clase temporariamente deshabilitada
	/// </summary>
	public EventArgsChange()
	{
	}
	
	private string _propertyName;
	public string PropertyName
	{
		get { return _propertyName; }
		set { _propertyName = value; }
	}
	private object _oldValue;
	public object OldValue
	{
		get { return _oldValue; }
		set { _oldValue = value ;}
	}
	private object _newValue;
	public object NewValue
	{
		get { return _newValue; }
		set { _newValue = value; }
	}
	private bool _cancel = false;
	public bool Cancel
	{
		get { return _cancel; }
		set { _cancel = value; }
	}
}

