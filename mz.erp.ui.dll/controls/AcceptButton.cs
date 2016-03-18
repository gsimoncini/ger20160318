using System;
using System.ComponentModel;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Set the AcceptButton when a control gets the focus. 
	/// 
	/// It extends contols with two extra properties:
	/// - UseDefaultAcceptButton
	/// - AcceptButton
	/// </summary>
	/// <remarks>
	/// Copyright © 2002 Reflection IT
	/// 
	/// This software is provided 'as-is', without any express or implied warranty.
	/// In no event will the authors be held liable for any damages arising from the
	/// use of this software.
	/// 
	/// Permission is granted to anyone to use this software for any purpose,
	/// including commercial applications, subject to the following restrictions:
	/// 
	/// 1. The origin of this software must not be misrepresented; you must not claim
	/// that you wrote the original software. 
	/// 
	/// 2. No substantial portion of the source code of this library may be redistributed
	/// without the express written permission of the copyright holders, where
	/// "substantial" is defined as enough code to be recognizably from this library. 
	/// </remarks>
	[ProvideProperty("UseDefaultAcceptButton", typeof(Control))]
	[ProvideProperty("AcceptButton", typeof(Control))]
	[ToolboxBitmap(typeof(Button), "Toolbox.bmp")]
	public class AcceptButton : System.ComponentModel.Component, System.ComponentModel.IExtenderProvider 
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private IButtonControl _previousButton;
		private Hashtable _useDefaultAcceptButtonList = new Hashtable();
		private Hashtable _acceptButtonList = new Hashtable();

		/// <summary>
		/// Required for Windows.Forms Class Composition Designer support
		/// </summary>
		public AcceptButton(System.ComponentModel.IContainer container)
		{
			container.Add(this);
			InitializeComponent();
		}

		/// <summary>
		/// Required for Windows.Forms Class Composition Designer support
		/// </summary>
		public AcceptButton()
		{
			InitializeComponent();
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		/// <summary>
		/// Specifies whether this object can provide its extender properties to the specified object.
		/// </summary>
		/// <param name="target">The Object to receive the extender properties.</param>
		/// <returns>true if this object can provide extender properties to the specified object; otherwise, false</returns>
		bool IExtenderProvider.CanExtend(object target) 
		{
			return (target is Control & !(target is IButtonControl) & !(target is Form));
		}

		/// <summary>
		/// Get whether the given control uses the Form's (default) AcceptButton.
		/// </summary>
		/// <param name="control">The Control to associate the AccecButton UseDefaultAcceptButton with. </param>
		/// <param name="value">true if the control uses the default, otherwise, false</param>
		[Category("Misc")]
		[Description("Indicates whether the default (Form) accept button is used or not.")]
		[DefaultValue(true)]
		public bool GetUseDefaultAcceptButton(Control control)
		{
			if (_useDefaultAcceptButtonList.ContainsKey(control))
				return (bool)(_useDefaultAcceptButtonList[control]);

			return true;
		}
		

		/// <summary>
		/// Set whether the given control uses the Form's (default) AcceptButton.
		/// </summary>
		/// <param name="control">The Control to associate the AccecButton UseDefaultAcceptButton with. </param>
		/// <param name="value">true if the control uses the default, otherwise, false</param>
		public void SetUseDefaultAcceptButton(Control control, bool value)
		{
			if (value != GetUseDefaultAcceptButton(control)) {
				_useDefaultAcceptButtonList[control] = value;

				if (value) {
					SetAcceptButton(control, null);
				}

				if (!DesignMode) {
					if (!value) {
						control.Enter += new EventHandler(OnControlEnter);
						control.Leave += new EventHandler(OnControlLeave);
					}
					else {
						control.Enter -= new EventHandler(OnControlEnter);
						control.Leave -= new EventHandler(OnControlLeave);
					}
				}
			}
		}

		/// <summary>
		/// Get the AcceptButton for the given control.
		/// </summary>
		/// <param name="control">The Control to associate the AccecButton AcceptButton with. </param>
		/// <returns>A Button control or null</returns>
		[Category("Misc")]
		[Description("The accept button for this control. If this is set, the button is 'clicked whenever the user presses the 'ENTER' key.")]
		[DefaultValue(null)]
		public IButtonControl GetAcceptButton(Control control) {
			if (_acceptButtonList.ContainsKey(control))
				return (IButtonControl)(_acceptButtonList[control]);

			return null;
		}

		/// <summary>
		/// Set the AcceptButton for the given control.
		/// </summary>
		/// <param name="control">The Control to associate the AccecButton AcceptButton with. </param>
		/// <param name="value">A Button control or null</param>
		public void SetAcceptButton(Control control, IButtonControl value) {
			_acceptButtonList[control] = value;

			if (value != null) {
				SetUseDefaultAcceptButton(control, false);
			}
		}

		/// <summary>
		/// Remember the Form's (default) AcceptButton and 
		/// set it to the Control's AcceptButton.
		/// </summary>
		/// <param name="sender">Control</param>
		/// <param name="e">Empty EventArgs</param>
		private void OnControlEnter(object sender, EventArgs e) 
		{
			Control control = (Control)sender;
			if (!GetUseDefaultAcceptButton(control)) {
				Form form = control.FindForm();
				_previousButton = form.AcceptButton;
				form.AcceptButton = GetAcceptButton(control);
			}
		}

		/// <summary>
		/// Restore the previous AcceptButton
		/// </summary>
		/// <param name="sender">Control</param>
		/// <param name="e">Empty EventArgs</param>
		private void OnControlLeave(object sender, EventArgs e) {
			Control control = (Control)sender;
			if (!GetUseDefaultAcceptButton(control)) {
				Form form = control.FindForm();
				form.AcceptButton = _previousButton;
			}
		}

	}
}
