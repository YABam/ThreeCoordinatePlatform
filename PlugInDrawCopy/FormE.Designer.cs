﻿namespace DrawCopy
{
	partial class FormE
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbMul = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(86, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "插  补";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "坐标系数：";
			// 
			// tbMul
			// 
			this.tbMul.Location = new System.Drawing.Point(230, 6);
			this.tbMul.Name = "tbMul";
			this.tbMul.Size = new System.Drawing.Size(100, 21);
			this.tbMul.TabIndex = 3;
			this.tbMul.Text = "1";
			// 
			// FormE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 476);
			this.Controls.Add(this.tbMul);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Name = "FormE";
			this.Text = "FormE";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormE_FormClosed);
			this.Load += new System.EventHandler(this.FormE_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormE_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormE_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormE_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormE_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMul;
	}
}