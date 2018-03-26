namespace GeoMetrics
{
	partial class MainForm
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
			this.fractionalInchTextBox_AX = new GeoMetrics.FractionalInchTextBox();
			this.fractionalInchTextBox_AY = new GeoMetrics.FractionalInchTextBox();
			this.fractionalInchTextBox_AZ = new GeoMetrics.FractionalInchTextBox();
			this.textBox_ALength = new System.Windows.Forms.TextBox();
			this.textBox_BLength = new System.Windows.Forms.TextBox();
			this.fractionalInchTextBox_BZ = new GeoMetrics.FractionalInchTextBox();
			this.fractionalInchTextBox_BY = new GeoMetrics.FractionalInchTextBox();
			this.fractionalInchTextBox_BX = new GeoMetrics.FractionalInchTextBox();
			this.textBox_Angle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControl_Main = new System.Windows.Forms.TabControl();
			this.tabPage_3DLengthsAndAngle = new System.Windows.Forms.TabPage();
			this.tabPage_Scaling = new System.Windows.Forms.TabPage();
			this.tabPage_GoldenRatio = new System.Windows.Forms.TabPage();
			this.fractionalInchTextBox1 = new GeoMetrics.FractionalInchTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabControl_Main.SuspendLayout();
			this.tabPage_3DLengthsAndAngle.SuspendLayout();
			this.tabPage_GoldenRatio.SuspendLayout();
			this.SuspendLayout();
			// 
			// fractionalInchTextBox_AX
			// 
			this.fractionalInchTextBox_AX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_AX.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_AX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fractionalInchTextBox_AX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_AX.Location = new System.Drawing.Point(34, 27);
			this.fractionalInchTextBox_AX.Name = "fractionalInchTextBox_AX";
			this.fractionalInchTextBox_AX.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_AX.TabIndex = 0;
			this.fractionalInchTextBox_AX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_AX.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// fractionalInchTextBox_AY
			// 
			this.fractionalInchTextBox_AY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_AY.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_AY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_AY.Location = new System.Drawing.Point(140, 27);
			this.fractionalInchTextBox_AY.Name = "fractionalInchTextBox_AY";
			this.fractionalInchTextBox_AY.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_AY.TabIndex = 1;
			this.fractionalInchTextBox_AY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_AY.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// fractionalInchTextBox_AZ
			// 
			this.fractionalInchTextBox_AZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_AZ.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_AZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_AZ.Location = new System.Drawing.Point(246, 27);
			this.fractionalInchTextBox_AZ.Name = "fractionalInchTextBox_AZ";
			this.fractionalInchTextBox_AZ.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_AZ.TabIndex = 2;
			this.fractionalInchTextBox_AZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_AZ.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// textBox_ALength
			// 
			this.textBox_ALength.Location = new System.Drawing.Point(352, 27);
			this.textBox_ALength.Name = "textBox_ALength";
			this.textBox_ALength.ReadOnly = true;
			this.textBox_ALength.Size = new System.Drawing.Size(100, 20);
			this.textBox_ALength.TabIndex = 3;
			this.textBox_ALength.TabStop = false;
			// 
			// textBox_BLength
			// 
			this.textBox_BLength.Location = new System.Drawing.Point(352, 53);
			this.textBox_BLength.Name = "textBox_BLength";
			this.textBox_BLength.ReadOnly = true;
			this.textBox_BLength.Size = new System.Drawing.Size(100, 20);
			this.textBox_BLength.TabIndex = 7;
			this.textBox_BLength.TabStop = false;
			// 
			// fractionalInchTextBox_BZ
			// 
			this.fractionalInchTextBox_BZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_BZ.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_BZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_BZ.Location = new System.Drawing.Point(246, 53);
			this.fractionalInchTextBox_BZ.Name = "fractionalInchTextBox_BZ";
			this.fractionalInchTextBox_BZ.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_BZ.TabIndex = 6;
			this.fractionalInchTextBox_BZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_BZ.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// fractionalInchTextBox_BY
			// 
			this.fractionalInchTextBox_BY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_BY.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_BY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_BY.Location = new System.Drawing.Point(140, 53);
			this.fractionalInchTextBox_BY.Name = "fractionalInchTextBox_BY";
			this.fractionalInchTextBox_BY.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_BY.TabIndex = 5;
			this.fractionalInchTextBox_BY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_BY.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// fractionalInchTextBox_BX
			// 
			this.fractionalInchTextBox_BX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox_BX.Denominator = FlintLib.Geometrics.CustomaryDenominators.ThirtySecond;
			this.fractionalInchTextBox_BX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox_BX.Location = new System.Drawing.Point(34, 53);
			this.fractionalInchTextBox_BX.Name = "fractionalInchTextBox_BX";
			this.fractionalInchTextBox_BX.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox_BX.TabIndex = 4;
			this.fractionalInchTextBox_BX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fractionalInchTextBox_BX.Leave += new System.EventHandler(this.FractionalInchTextBox_Leave);
			// 
			// textBox_Angle
			// 
			this.textBox_Angle.Location = new System.Drawing.Point(92, 89);
			this.textBox_Angle.Name = "textBox_Angle";
			this.textBox_Angle.ReadOnly = true;
			this.textBox_Angle.Size = new System.Drawing.Size(100, 20);
			this.textBox_Angle.TabIndex = 8;
			this.textBox_Angle.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "X";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(183, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Y";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(289, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Z";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(382, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Length";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(52, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Angle";
			// 
			// tabControl_Main
			// 
			this.tabControl_Main.Controls.Add(this.tabPage_3DLengthsAndAngle);
			this.tabControl_Main.Controls.Add(this.tabPage_Scaling);
			this.tabControl_Main.Controls.Add(this.tabPage_GoldenRatio);
			this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Main.Name = "tabControl_Main";
			this.tabControl_Main.SelectedIndex = 0;
			this.tabControl_Main.Size = new System.Drawing.Size(629, 262);
			this.tabControl_Main.TabIndex = 16;
			// 
			// tabPage_3DLengthsAndAngle
			// 
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label3);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label7);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_AX);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.textBox_Angle);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label6);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_AY);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label5);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_AZ);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label4);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.textBox_ALength);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_BX);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label2);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_BY);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.label1);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.fractionalInchTextBox_BZ);
			this.tabPage_3DLengthsAndAngle.Controls.Add(this.textBox_BLength);
			this.tabPage_3DLengthsAndAngle.Location = new System.Drawing.Point(4, 22);
			this.tabPage_3DLengthsAndAngle.Name = "tabPage_3DLengthsAndAngle";
			this.tabPage_3DLengthsAndAngle.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_3DLengthsAndAngle.Size = new System.Drawing.Size(621, 236);
			this.tabPage_3DLengthsAndAngle.TabIndex = 0;
			this.tabPage_3DLengthsAndAngle.Text = "3D Lengths & Angle";
			this.tabPage_3DLengthsAndAngle.UseVisualStyleBackColor = true;
			// 
			// tabPage_Scaling
			// 
			this.tabPage_Scaling.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Scaling.Name = "tabPage_Scaling";
			this.tabPage_Scaling.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Scaling.Size = new System.Drawing.Size(621, 236);
			this.tabPage_Scaling.TabIndex = 1;
			this.tabPage_Scaling.Text = "Scaling";
			this.tabPage_Scaling.UseVisualStyleBackColor = true;
			// 
			// tabPage_GoldenRatio
			// 
			this.tabPage_GoldenRatio.Controls.Add(this.textBox2);
			this.tabPage_GoldenRatio.Controls.Add(this.textBox1);
			this.tabPage_GoldenRatio.Controls.Add(this.fractionalInchTextBox1);
			this.tabPage_GoldenRatio.Location = new System.Drawing.Point(4, 22);
			this.tabPage_GoldenRatio.Name = "tabPage_GoldenRatio";
			this.tabPage_GoldenRatio.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_GoldenRatio.Size = new System.Drawing.Size(621, 236);
			this.tabPage_GoldenRatio.TabIndex = 2;
			this.tabPage_GoldenRatio.Text = "Golden Ratio";
			this.tabPage_GoldenRatio.UseVisualStyleBackColor = true;
			// 
			// fractionalInchTextBox1
			// 
			this.fractionalInchTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
			this.fractionalInchTextBox1.Denominator = FlintLib.Geometrics.CustomaryDenominators.HundredTwentyEighth;
			this.fractionalInchTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fractionalInchTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
			this.fractionalInchTextBox1.Location = new System.Drawing.Point(21, 43);
			this.fractionalInchTextBox1.Name = "fractionalInchTextBox1";
			this.fractionalInchTextBox1.Size = new System.Drawing.Size(100, 20);
			this.fractionalInchTextBox1.TabIndex = 0;
			this.fractionalInchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(127, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(233, 43);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 262);
			this.Controls.Add(this.tabControl_Main);
			this.Name = "MainForm";
			this.Text = "GeoMetrics";
			this.tabControl_Main.ResumeLayout(false);
			this.tabPage_3DLengthsAndAngle.ResumeLayout(false);
			this.tabPage_3DLengthsAndAngle.PerformLayout();
			this.tabPage_GoldenRatio.ResumeLayout(false);
			this.tabPage_GoldenRatio.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private FractionalInchTextBox fractionalInchTextBox_AX;
		private FractionalInchTextBox fractionalInchTextBox_AY;
		private FractionalInchTextBox fractionalInchTextBox_AZ;
		private System.Windows.Forms.TextBox textBox_ALength;
		private System.Windows.Forms.TextBox textBox_BLength;
		private FractionalInchTextBox fractionalInchTextBox_BZ;
		private FractionalInchTextBox fractionalInchTextBox_BY;
		private FractionalInchTextBox fractionalInchTextBox_BX;
		private System.Windows.Forms.TextBox textBox_Angle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabControl tabControl_Main;
		private System.Windows.Forms.TabPage tabPage_3DLengthsAndAngle;
		private System.Windows.Forms.TabPage tabPage_Scaling;
		private System.Windows.Forms.TabPage tabPage_GoldenRatio;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private FractionalInchTextBox fractionalInchTextBox1;
	}
}