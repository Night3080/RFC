/*
 * Created by SharpDevelop.
 * User: CC2-PC04
 * Date: 22/10/2024
 * Time: 03:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RFC
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
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			txtapellido1.Text="";
			txtapellido2.Text="";
			txtdireccion.Text="";
			txtnombre.Text="";
			txttelefono.Text="";
			lbRFC.Text="..........";
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			string RFC;
			string a = txtapellido1.Text;
			string c = txtapellido2.Text;
			string b = txtnombre.Text;
			string d = dTPFecha.Value.ToString("dd/MM/yyyy");
			RFC = a.Substring(0, 2)+c.Substring(0,1)+ b.Substring(0,1)+d.Substring(0, 2)+d.Substring(3, 2)+d.Substring(8, 2);
			lbRFC.Text=RFC;
		}
	}
}
