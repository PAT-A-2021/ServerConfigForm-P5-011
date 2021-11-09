namespace ServerConfigForm_P5_011
{
	partial class Form1
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
			this.buttonOn = new System.Windows.Forms.Button();
			this.buttonOff = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelKet = new System.Windows.Forms.Label();
			this.labelOnOrOff = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonOn
			// 
			this.buttonOn.Location = new System.Drawing.Point(79, 181);
			this.buttonOn.Name = "buttonOn";
			this.buttonOn.Size = new System.Drawing.Size(75, 23);
			this.buttonOn.TabIndex = 0;
			this.buttonOn.Text = "ON";
			this.buttonOn.UseVisualStyleBackColor = true;
			this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
			// 
			// buttonOff
			// 
			this.buttonOff.Location = new System.Drawing.Point(239, 181);
			this.buttonOff.Name = "buttonOff";
			this.buttonOff.Size = new System.Drawing.Size(75, 23);
			this.buttonOff.TabIndex = 1;
			this.buttonOff.Text = "OFF";
			this.buttonOff.UseVisualStyleBackColor = true;
			this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "SERVER";
			// 
			// labelKet
			// 
			this.labelKet.AutoSize = true;
			this.labelKet.Location = new System.Drawing.Point(119, 96);
			this.labelKet.Name = "labelKet";
			this.labelKet.Size = new System.Drawing.Size(35, 13);
			this.labelKet.TabIndex = 3;
			this.labelKet.Text = "label2";
			// 
			// labelOnOrOff
			// 
			this.labelOnOrOff.AutoSize = true;
			this.labelOnOrOff.Location = new System.Drawing.Point(119, 128);
			this.labelOnOrOff.Name = "labelOnOrOff";
			this.labelOnOrOff.Size = new System.Drawing.Size(35, 13);
			this.labelOnOrOff.TabIndex = 4;
			this.labelOnOrOff.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 294);
			this.Controls.Add(this.labelOnOrOff);
			this.Controls.Add(this.labelKet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOff);
			this.Controls.Add(this.buttonOn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOn;
		private System.Windows.Forms.Button buttonOff;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelKet;
		private System.Windows.Forms.Label labelOnOrOff;
	}
}

