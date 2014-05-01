/*
 * Created by SharpDevelop.
 * User: CA
 * Date: 29/04/2014
 * Time: 11:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuintaPractica
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.uk = new System.Windows.Forms.CheckBox();
			this.Japan = new System.Windows.Forms.CheckBox();
			this.Germany = new System.Windows.Forms.CheckBox();
			this.Russia = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(25, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(179, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre del alumno";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(179, 47);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(198, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(25, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(352, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "1.- Seleccione los países aliados en la 2° guerra mundial";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// uk
			// 
			this.uk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.uk.Location = new System.Drawing.Point(58, 135);
			this.uk.Name = "uk";
			this.uk.Size = new System.Drawing.Size(104, 24);
			this.uk.TabIndex = 5;
			this.uk.Text = "Reino Unido";
			this.uk.UseVisualStyleBackColor = true;
			this.uk.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// Japan
			// 
			this.Japan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Japan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Japan.Location = new System.Drawing.Point(223, 135);
			this.Japan.Name = "Japan";
			this.Japan.Size = new System.Drawing.Size(104, 24);
			this.Japan.TabIndex = 6;
			this.Japan.Text = "Japón";
			this.Japan.UseVisualStyleBackColor = true;
			// 
			// Germany
			// 
			this.Germany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Germany.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Germany.Location = new System.Drawing.Point(58, 165);
			this.Germany.Name = "Germany";
			this.Germany.Size = new System.Drawing.Size(104, 24);
			this.Germany.TabIndex = 7;
			this.Germany.Text = "Alemania";
			this.Germany.UseVisualStyleBackColor = true;
			// 
			// Russia
			// 
			this.Russia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Russia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Russia.Location = new System.Drawing.Point(223, 165);
			this.Russia.Name = "Russia";
			this.Russia.Size = new System.Drawing.Size(104, 24);
			this.Russia.TabIndex = 8;
			this.Russia.Text = "Rusia";
			this.Russia.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(25, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(352, 41);
			this.label4.TabIndex = 9;
			this.label4.Text = "2.- Seleccione el gobernante de Italia durante la 2° guerra mundial";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton1.Location = new System.Drawing.Point(25, 245);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(90, 24);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Adolf Hitler";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton2.Location = new System.Drawing.Point(152, 245);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(83, 37);
			this.radioButton2.TabIndex = 11;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Benito Mussolini";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.radioButton3.Location = new System.Drawing.Point(251, 245);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(126, 24);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Silvio Berlusconi ";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(25, 298);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(352, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "3.- Número de estados de la republica Mexicana";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(138, 325);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									36,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(25, 370);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(352, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "4.- Fecha de independencia de México";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(88, 402);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(160, 589);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "Contestar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(409, 623);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Russia);
			this.Controls.Add(this.Germany);
			this.Controls.Add(this.Japan);
			this.Controls.Add(this.uk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CincoPrac";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox Russia;
		private System.Windows.Forms.CheckBox Germany;
		private System.Windows.Forms.CheckBox Japan;
		private System.Windows.Forms.CheckBox uk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
