using System;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ComboItem.
	/// </summary>
	/// 
	public class ComboItem
	{   
		private int _imageIndex;    
		private string _etiqueta;    
		public string Etiqueta    
		{       
			get { return _etiqueta; }        
			set { _etiqueta = value; }   
		}    
		public int ImageIndex   
		{       
			get { return _imageIndex; }      
			set { _imageIndex = value; }   
		}    
		public ComboItem(string etiqueta, int imageIndex)   
		{       
			this.Etiqueta = etiqueta;       
			this.ImageIndex = imageIndex;   
		}  
		public override string ToString()   
		{     
			return Etiqueta;   
		}
	}

}