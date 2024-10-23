/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 22/10/2024
 * Time: 03:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtapellido1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtapellido2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dTPFecha = new System.Windows.Forms.DateTimePicker();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(130, 79);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 20);
			this.txtnombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido 1:";
			// 
			// txtapellido1
			// 
			this.txtapellido1.Location = new System.Drawing.Point(130, 121);
			this.txtapellido1.Name = "txtapellido1";
			this.txtapellido1.Size = new System.Drawing.Size(100, 20);
			this.txtapellido1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido 2:";
			// 
			// txtapellido2
			// 
			this.txtapellido2.Location = new System.Drawing.Point(130, 154);
			this.txtapellido2.Name = "txtapellido2";
			this.txtapellido2.Size = new System.Drawing.Size(100, 20);
			this.txtapellido2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Telefono:";
			// 
			// txttelefono
			// 
			this.txttelefono.Location = new System.Drawing.Point(130, 193);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(100, 20);
			this.txttelefono.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Direccion:";
			// 
			// txtdireccion
			// 
			this.txtdireccion.Location = new System.Drawing.Point(130, 225);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(100, 20);
			this.txtdireccion.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 267);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Semestre:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6"});
			this.comboBox1.Location = new System.Drawing.Point(130, 264);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 303);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fecha de nacimiento:";
			// 
			// dTPFecha
			// 
			this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTPFecha.Location = new System.Drawing.Point(130, 297);
			this.dTPFecha.Name = "dTPFecha";
			this.dTPFecha.Size = new System.Drawing.Size(100, 20);
			this.dTPFecha.TabIndex = 13;
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(13, 391);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnlimpiar.TabIndex = 16;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(155, 391);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(75, 23);
			this.btncalcular.TabIndex = 17;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(34, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(184, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Inserte los datos solicitados por favor";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 452);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.dTPFecha);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtdireccion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txttelefono);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtapellido2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtapellido1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "RFC";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.DateTimePicker dTPFecha;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtapellido2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtapellido1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
	}
}
