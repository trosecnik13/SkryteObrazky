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
	public partial class Hra : Form
	{
		public Hra()
		{
			InitializeComponent();
		}

		int size = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Hra_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		PictureBox[] pics = new PictureBox[Form1.size*Form1.size];
		PictureBox[] lines = new PictureBox[Form1.size * Form1.size];
		PictureBox[] lines2 = new PictureBox[Form1.size * Form1.size];
		Label[] label = new Label[Form1.size * Form1.size];

		private void Hra_Load(object sender, EventArgs e)
		{
			size = 1000 / Form1.size;

			this.Size = new Size((Form1.size) * size, (Form1.size) * size);
			button1.Location = new Point((Form1.size * size) -100, (Form1.size * size) -100);

			this.MaximizeBox = false;
			this.MinimizeBox = false;
		

			int x = 0;
			int y = 0;

			int souradnice_x = 65;
			int souradnice_y = 1;

			int konec_cisel = souradnice_x + Form1.size;

			for (int i = 0; i < Form1.size*Form1.size; i++)
			{   
				pics[i] = new PictureBox();
				pics[i].Location = new Point(x, y);
				pics[i].Name = x + ":" + y + ":" + i;
				pics[i].Size = new Size(size, size);
				pics[i].Image = Image.FromFile("../../black.png");
				pics[i].Visible = true;
				pics[i].Click += new EventHandler(PictureBoxClick);

				lines[i] = new PictureBox();
				lines[i].Location = new Point(x, y);
				lines[i].Size = new Size(1200, 2);
				lines[i].Image = Image.FromFile("../../horizontal.png");
				lines[i].Visible = true;

				lines2[i] = new PictureBox();
				lines2[i].Location = new Point(x, y);
				lines2[i].Size = new Size(2, 1200);
				lines2[i].Image = Image.FromFile("../../vertical.png");
				lines2[i].Visible = true;

				label[i] = new Label();
				label[i].Location = new Point(x + 2, y + 2);
				label[i].Size = new Size(16, 16);
				label[i].Text = (char)souradnice_x + ":" + souradnice_y;
				label[i].Visible = true;
				label[i].AutoSize = true;
				label[i].Font = new Font("Calibri", 14);
				label[i].ForeColor = Color.Yellow;

				this.Controls.Add(label[i]);
				this.Controls.Add(lines[i]);
				this.Controls.Add(lines2[i]);
				this.Controls.Add(pics[i]);

				x += size;
				int konec_x = Form1.size * size;
				if (x == konec_x) { x = 0; y += size; }

				souradnice_x++;
				if (souradnice_x == konec_cisel) { souradnice_x = 65; souradnice_y++; }
			}
		}

		private void PictureBoxClick(object sender, EventArgs e)
		{
			int x = int.Parse((((PictureBox)sender).Name).Split(':')[0]);
			int y = int.Parse((((PictureBox)sender).Name).Split(':')[1]);
			int i = int.Parse((((PictureBox)sender).Name).Split(':')[2]);

			Bitmap source = new Bitmap(Form1.path);

			Bitmap bmpCrop = ResizeBitmap(source, Form1.size* size, Form1.size* size);


			Rectangle section = new Rectangle(new Point(x, y), new Size(size, size));

			Bitmap CroppedImage = CropImage(bmpCrop, section);

			pics[i].Image = CroppedImage;
			label[i].Visible = false;
		}

		public Bitmap CropImage(Bitmap source, Rectangle section)
		{
			var bitmap = new Bitmap(section.Width, section.Height);
			using (var g = Graphics.FromImage(bitmap))
			{
				g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
				return bitmap;
			}
		}

		public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
		{
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(bmp, 0, 0, width, height);
			}
			return bitmap;
		}
	}
}