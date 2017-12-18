using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        ITransport locomotive = null;
        public ITransport getLocomotive { get { return locomotive; } }

        private void Draw()
        {
            if (locomotive != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxLoc.Width, pictureBoxLoc.Height);
                Graphics gr = Graphics.FromImage(bmp);
                locomotive.setPosition(5, 5);
                locomotive.drawLocomotive(gr);
                pictureBoxLoc.Image = bmp;
            }
        }

        private event myDel eventAddTrain;

                public void AddEvent(myDel ev)
                {
                    if (eventAddTrain == null)
                    {
                        eventAddTrain = new myDel(ev);
                    }
                    else
                    {
                        eventAddTrain += ev;
                    }

                }

        public Form1()
        {
            InitializeComponent();
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            panel9.MouseDown += panelColor_MouseDown;
            
            button2.Click += (object sender, EventArgs e) => { Close(); };
        }

        

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

    
    private void label3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label3_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                locomotive.setMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventAddTrain != null)
            {
                eventAddTrain(locomotive);
            }
            Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    locomotive = new Locomotive(100, 4, 1000, Color.White);
                    break;
                case "Элктровоз":
                    locomotive = new CartLocomotive(100, 4, 1000, Color.White, true, true, true, Color.Black);
                    break;
            }
            Draw();
        }
        private void label4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label4_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                if (locomotive is CartLocomotive)
                {
                    (locomotive as CartLocomotive).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
