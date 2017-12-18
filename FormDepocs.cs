
using NLog;
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
    public partial class FormDepocs : Form
    {
        Depo depo;
        Form1 form;
        private Logger log = LogManager.GetCurrentClassLogger();
        public FormDepocs()
        {
            InitializeComponent();           
            depo = new Depo(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
   
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depo.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
                pictureBoxParking.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var locomotive = new Locomotive(100, 4, 1000, dialog.Color);
                int place = depo.PutLocoInDepo(locomotive);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var locomotive = new CartLocomotive(100, 4, 1000, dialog.Color, true, true, true, dialogDop.Color);
                        int place = depo.PutLocoInDepo(locomotive);
                        Draw();
                        MessageBox.Show("Ваше место: " + place);
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
                {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                    string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                    if (maskedTextBox1.Text != "")
                    {
                        try
                        {
                            ITransport locomotive = depo.GetLocoInDepo(Convert.ToInt32(maskedTextBox1.Text));

                            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            locomotive.setPosition(20, 50);
                            locomotive.drawLocomotive(gr);
                            pictureBoxTakeCar.Image = bmp;
                            Draw();
                        }
                        catch (ParkingIndexOutOfRangeException ex)
                        {
                            MessageBox.Show(ex.Message, "Неверный номер",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Общая ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
            }            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

            depo.LevelDown();
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
            log.Info("Переход на уровень ниже Текущий уровень: " + depo.getCurrentLevel);
            Draw();

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

            depo.LevelUp();
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
            log.Info("Переход на уровень выше Текущий уровень: " + depo.getCurrentLevel);
            Draw();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            log.Info("Вызов  ");
            form = new Form1();
            form.AddEvent(AddLoco);
            log.Info("Вызов локомотива ");
            form.Show();

        }

        private void AddLoco(ITransport locomotive)
        {
            if (locomotive != null)
            {
                try
                {
                    int place = depo.PutLocoInDepo(locomotive);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {                
                    MessageBox.Show(ex.Message, "Общая ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depo.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depo.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }

        }
    }
}

