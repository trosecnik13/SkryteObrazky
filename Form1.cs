using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkryteObrazky
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static string path = null;
		public static int size = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				path = openFileDialog.FileName;
				size = Convert.ToInt32(numericUpDown1.Value);
			}

			if (path != null)
			{
				Hra hra = new Hra();
				hra.Show();
			}
			else
			{
				MessageBox.Show("Vybraný soubor je neplatný!");
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
