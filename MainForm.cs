/*
 * Created by SharpDevelop.
 * User: CA
 * Date: 01/05/2014
 * Time: 12:48 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuintaPractica
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string contestar="";
		 	contestar=this.button1.Text;
		 	
		 	
			if(this.Germany.Checked & this.Russia.Checked)
			{
				contestar= "Correcta 1/4";
				
			}
				
			if (  this.Germany.Checked & this.Russia.Checked 
			    & this.radioButton2.Checked)
			{
				contestar=  "Correcta 2/4";
				
			}
		 
		 	if(  this.Germany.Checked & this.Russia.Checked 
			   & this.radioButton2.Checked
			   & this.numericUpDown1.Text== "31")
		 	{
		 		contestar ="Correcta 3/4";
		 	
		 	}
			
			/*if(  this.Germany.Checked & this.Russia.Checked 
			/*if( this.Germany.Checked & this.Russia.Checked 
			   	 & this.radioButton2.Checked
			   	 & this.numericUpDown1.Text== "31"
			     &  this.monthCalendar1.SelectionStart.Date.ToShortDateString="16/09/1810")
			{
		 		contestar = "Correcta 4/4";
		 	}*/
			
			//me ocasiona error la opcción "ToShortDateString 
			//(razón: No se puede asignar porque es "grupo de métodos")
			
			
			
			
			
 System.Windows.Forms.MessageBox.Show(contestar);
			
		 				
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
