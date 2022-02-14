namespace SkryteObrazky
{
	partial class Hra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hra));
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(497, 567);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Zpět";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Hra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 611);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Hra";
			this.Text = "Hra";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hra_FormClosed);
			this.Load += new System.EventHandler(this.Hra_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
	}
}