namespace SkryteObrazky
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(81, 60);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 71);
			this.button1.TabIndex = 2;
			this.button1.Text = "Vybrat obrázek";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(168, 12);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(18, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pocet řad a sloupců:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(300, 150);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "SkryteObrazky";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
	}
}

