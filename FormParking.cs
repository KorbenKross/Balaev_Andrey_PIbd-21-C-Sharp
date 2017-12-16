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
    public partial class FormParking : Form
    {
        public FormParking()
        {
            InitializeComponent();
            depo = new Depo();
            Draw();
        }

        Depo depo;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depo.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void buttonSetTrain_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var train = new Train(100, 4, 240, 1000, dialog.Color);
                int place = depo.PutCarInParking(train);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }

        private void buttonSetPasTrain_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var train = new PasTrain(100, 4, 240, 1000, dialog.Color, true, true, true, dialogDop.Color);
                    int place = depo.PutCarInParking(train);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonTakeCar_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var train = depo.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.setPosition(5, 5);
                train.drawCar(gr);
                pictureBox2.Image = bmp;
                Draw();
            }
        }
    }
}
