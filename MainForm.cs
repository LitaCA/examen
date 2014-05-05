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
		 	contestar=this.contesta.Text;
			
		 	int res=0;
		 	
			if (this.Germany.Checked & this.Russia.Checked)
			{
				
				res=res+1;
			}
				
			if (this.radioButton2.Checked)
			{
				
				res=res+1;
			}
		 
		 	if (this.numericUpDown1.Text=="31")
		 	{
		 		
		 		res=res+1;
		 	}
			
		 	if (this.monthCalendar1.SelectionStart.Date.ToShortDateString()=="16/09/1810")
		 	{
		 		
		 		res=res+1;
		 	}
			
		 	System.Windows.Forms.MessageBox.Show("Las respuestas correctas son: " +res+ "/4" );		 
		 	
		}
		
		
		
		void GermanyCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
	}
}
