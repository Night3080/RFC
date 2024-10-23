/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 23/10/2024
 * Time: 04:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC
{
	partial class Form1
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
			this.lbnombre = new System.Windows.Forms.Label();
			this.lbRFC = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbnombre
			// 
			this.lbnombre.Location = new System.Drawing.Point(12, 66);
			this.lbnombre.Name = "lbnombre";
			this.lbnombre.Size = new System.Drawing.Size(292, 23);
			this.lbnombre.TabIndex = 0;
			this.lbnombre.Text = "................";
			// 
			// lbRFC
			// 
			this.lbRFC.Location = new System.Drawing.Point(473, 66);
			this.lbRFC.Name = "lbRFC";
			this.lbRFC.Size = new System.Drawing.Size(239, 23);
			this.lbRFC.TabIndex = 1;
			this.lbRFC.Text = "...................";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 142);
			this.Controls.Add(this.lbRFC);
			this.Controls.Add(this.lbnombre);
			this.Name = "Form1";
			this.Text = "Calculo rfc";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbRFC;
		private System.Windows.Forms.Label lbnombre;
	}
}
