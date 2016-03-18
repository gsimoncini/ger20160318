using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using mz.erp.commontypes.CommonInterfaces;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// 
	/// </summary>
	public class ToolTipCheckedListBox : System.Windows.Forms.CheckedListBox
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct SIZE
		{
			public int cx;
			public int cy;
		}
		[DllImport("gdi32.dll")]
		public static extern int GetTextExtentPoint32(IntPtr hdc, 
			String str, int len, ref SIZE size);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern int ReleaseDC(IntPtr hWnd,IntPtr hdc);


		public ToolTipCheckedListBox()
		{			
			tp.InitialDelay = 500;
			tp.ReshowDelay = 500;
			tp.AutoPopDelay = 3000;			
			tp.Active = true;			
		}	

		
		protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
		{				
			int index = IndexFromPoint(e.X,e.Y);
			if(index != ListBox.NoMatches )
			{				
				if( LastIndex != index )
				{
					object obj = Items[index];
					Type[] types = obj.GetType().GetInterfaces();
					ArrayList aux = new ArrayList(types);
					string s = string.Empty;
					if(aux.Contains(typeof(IToolTip)))
						s = ((IToolTip) obj).ToStringToolTip();
					else
						s = Items[index].ToString();	

					IntPtr hdc = GetDC(this.Handle);
					SIZE size;
					size.cx = 0;
					size.cy = 0;
					GetTextExtentPoint32(hdc,s,s.Length,ref size);
					ReleaseDC(this.Handle,hdc);

					//if(this.Width < size.cx)					
						tp.SetToolTip(this,s);

					LastIndex = index;				
				}							
			}
		}
		
		private ToolTip tp = new ToolTip();
		private int LastIndex = -1;
		
	}
}
