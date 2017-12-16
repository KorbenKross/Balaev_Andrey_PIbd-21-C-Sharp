using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
	public partial class Form1 : Form
	{
		Color color;
		Color dopColor;
		int maxSpeed;
		int maxCountPass;
		int weight;
        int maxCapacityGenerator;


        private ITtransport inter;
		public Form1()
		{
			InitializeComponent();

			color = Color.White;
			dopColor = Color.Yellow;
			maxSpeed = 200;
			maxCountPass = 50;
			weight = 1000;

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				color = cd.Color;
				button1.BackColor = color;
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				dopColor = cd.Color;
				button3.BackColor = dopColor;
			}

		}

		private bool checkFields()
		{
			if (!int.TryParse(txtBoxMaxSpeed.Text, out maxSpeed))
			{
				return false;
			}
			if (!int.TryParse(txtBoxMaxCntPas.Text, out maxCountPass))
			{
				return false;
			}
			if (!int.TryParse(txtBoxWeight.Text, out weight))
			{
				return false;
			}
			return true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (checkFields())
			{
				inter = new Train(maxSpeed, maxCountPass, maxCapacityGenerator, weight, color);
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				inter.drawCar(gr);
				pictureBox1.Image = bmp;
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			inter = new PasTrain(150, 4, 100,1000, Color.Black, true, true, true, Color.Yellow);
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics gr = Graphics.FromImage(bmp);
			inter.drawCar(gr);
			pictureBox1.Image = bmp;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (inter != null)
			{
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				inter.moveCar(gr);
				pictureBox1.Image = bmp;

			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (checkFields())
			{
				inter = new PasTrain(maxSpeed, maxCountPass,maxCapacityGenerator ,weight, color, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, dopColor);
				Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
				Graphics gr = Graphics.FromImage(bmp);
				inter.drawCar(gr);
				pictureBox1.Image = bmp;
			}

		}
	}
}