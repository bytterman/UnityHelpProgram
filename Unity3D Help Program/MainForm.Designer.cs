/*
 * Created by SharpDevelop.
 * User: Mike Rovers
 * Date: 14-11-2012
 * Time: 17:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Unity3D_Help_Program
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DocumentationButton = new System.Windows.Forms.Button();
			this.UnifyButton = new System.Windows.Forms.Button();
			this.ForumButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.groupBox1.Controls.Add(this.DocumentationButton);
			this.groupBox1.Controls.Add(this.UnifyButton);
			this.groupBox1.Controls.Add(this.ForumButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(968, 63);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Toolbar";
			// 
			// DocumentationButton
			// 
			this.DocumentationButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.DocumentationButton.Location = new System.Drawing.Point(325, 19);
			this.DocumentationButton.Name = "DocumentationButton";
			this.DocumentationButton.Size = new System.Drawing.Size(153, 37);
			this.DocumentationButton.TabIndex = 2;
			this.DocumentationButton.Text = "Documentation";
			this.DocumentationButton.UseVisualStyleBackColor = false;
			this.DocumentationButton.Click += new System.EventHandler(this.DocumentationButtonClick);
			// 
			// UnifyButton
			// 
			this.UnifyButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.UnifyButton.Location = new System.Drawing.Point(166, 19);
			this.UnifyButton.Name = "UnifyButton";
			this.UnifyButton.Size = new System.Drawing.Size(153, 37);
			this.UnifyButton.TabIndex = 1;
			this.UnifyButton.Text = "Unify ";
			this.UnifyButton.UseVisualStyleBackColor = false;
			this.UnifyButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// ForumButton
			// 
			this.ForumButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ForumButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ForumButton.Location = new System.Drawing.Point(7, 19);
			this.ForumButton.Name = "ForumButton";
			this.ForumButton.Size = new System.Drawing.Size(153, 37);
			this.ForumButton.TabIndex = 0;
			this.ForumButton.Text = "Forum";
			this.ForumButton.UseVisualStyleBackColor = false;
			this.ForumButton.Click += new System.EventHandler(this.ForumButtonClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 85);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(968, 630);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.webBrowser1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(960, 604);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 3);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(954, 598);
			this.webBrowser1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(960, 604);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(992, 737);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Unity3D Help Program";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button DocumentationButton;
		private System.Windows.Forms.Button UnifyButton;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button ForumButton;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
