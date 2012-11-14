/*
 * Created by SharpDevelop.
 * User: Mike Rovers
 * Date: 14-11-2012
 * Time: 17:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Unity3D_Help_Program
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			webBrowser1.Navigate ("www.unity3d.com");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate ("http://wiki.unity3d.com/index.php?title=Main_Page");
		}
		
		void ForumButtonClick(object sender, EventArgs e)
		{
			webBrowser1.Navigate ("http://forum.unity3d.com/");
		}
		
		void DocumentationButtonClick(object sender, EventArgs e)
		{
			webBrowser1.Navigate ("http://unity3d.com/company/support/documentation/");
		}
	}
}
