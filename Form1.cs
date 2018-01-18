using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class WindowsFormsApplication2 : Form
    {
        private Potato[] potatos;
        private Bow[] bow;
        private Carrot[] carrot;
        private Zucchini[] zucchini;
        private Tomato[] tomato;

        private Salt salt;
        private Spice spice;
        private tomato_paste tomato_paste;

        private WaterTap waterTap = new WaterTap();

        private Knife knife = new Knife();
        private Blender blender = new Blender();

        private Pan pan = new Pan();
        private Oven oven = new Oven();



        public WindowsFormsApplication2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potatos = new Potato[Convert.ToInt32(numericUpDown1.Value)];
                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i] = new Potato();
                }
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i].Dirty = 0;
                    
                }
                numericUpDown1.Enabled = false;
                //radioButton2.Checked = true;
                button1.Enabled = false;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                carrot = new Carrot[Convert.ToInt32(numericUpDown2.Value)];
                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
                for (int i = 0; i < carrot.Length; ++i)
                {
                    carrot[i] = new Carrot();
                }
                for (int i = 0; i < carrot.Length; ++i)
                {
                    carrot[i].Dirty = 0;
                }
                numericUpDown2.Enabled = false;
                //radioButtonClose.Checked = true;
                button18.Enabled = false;
                MessageBox.Show("Морковку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Морковки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tomato = new Tomato[Convert.ToInt32(numericUpDown4.Value)];
                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
                for (int i = 0; i < tomato.Length; ++i)
                {
                    tomato[i] = new Tomato();
                }
                for (int i = 0; i < tomato.Length; ++i)
                {
                    tomato[i].Dirty = 0;
                }
                numericUpDown4.Enabled = false;
                //radioButtonClose.Checked = true;
                button17.Enabled = false;
                MessageBox.Show("Помидорку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помидорки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                zucchini = new Zucchini[Convert.ToInt32(numericUpDown3.Value)];
                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
                for (int i = 0; i < zucchini.Length; ++i)
                {
                    zucchini[i] = new Zucchini();
                }
                for (int i = 0; i < zucchini.Length; ++i)
                {
                    zucchini[i].Dirty = 0;
                }
                numericUpDown3.Enabled = false;
                //radioButtonClose.Checked = true;
                button19.Enabled = false;
                MessageBox.Show("Кабачок помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Кабачка то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bow = new Bow[Convert.ToInt32(numericUpDown5.Value)];
                pan.Init(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown5.Value));
                for (int i = 0; i < bow.Length; ++i)
                {
                    bow[i] = new Bow();
                }
                for (int i = 0; i < bow.Length; ++i)
                {
                    bow[i].Dirty = 0;
                }
                numericUpDown5.Enabled = false;
                //radioButtonClose.Checked = true;
                button7.Enabled = false;
                MessageBox.Show("Лук помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Лука то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioBtnBlenderOn_CheckedChanged(object sender, EventArgs e)
        {
            blender.State = true;
        }

        private void radioBtnBlenderOff_CheckedChanged(object sender, EventArgs e)
        {
            blender.State = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!blender.State)
            {
                MessageBox.Show("Блендер выключен, включите, чтоб измельчить ингредиенты!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pan.Init(Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown4.Value), Convert.ToInt32(numericUpDown3.Value));

            if (carrot == null)
            {
                MessageBox.Show("Недостаточно ингредиентов! Добавьте продукты в блендер.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((potatos.Length == 0) || (bow.Length == 0) || (zucchini.Length == 0) || (tomato.Length == 0) || (carrot.Length == 0))
            {
                MessageBox.Show("Недостаточно ингредиентов! Добавьте продукты в блендер.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potatos.Length; ++i)
            {
                blender.Cut_potato(potatos[i]);
            }

            for (int i = 0; i < carrot.Length; ++i)
            {
                blender.Cut_carrot(carrot[i]);
            }

            for (int i = 0; i < bow.Length; ++i)
            {
                blender.Cut_bow(bow[i]);
            }

            for (int i = 0; i < zucchini.Length; ++i)
            {
                blender.Cut_zucchini(zucchini[i]);
            }

            for (int i = 0; i < tomato.Length; ++i)
            {
                blender.Cut_tomato(tomato[i]);
            }

            MessageBox.Show("Ингредиенты измельчены!)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (potatos == null)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (potatos.Length == 0)
            //{
            //    MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Помыть бы ее сначала, а потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                knife.Clean_potato(potatos[i]);
            }
            //buttonAddPotatos.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Картошку помыли, можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Моркови то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Моркови то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                if (carrot[i].Dirty > 0)
                {
                    MessageBox.Show("Морковь грязная!!! Помыть бы ее сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                knife.Clean_carrot(carrot[i]);
            }
            //buttonAddPotatos.Enabled = true;
            button16.Enabled = false;
            MessageBox.Show("Морковь помыли, можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!waterTap.State)
            {
                MessageBox.Show("Кран закрыт, как заливать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < 3; ++i)
            {
                pan.AddWater(waterTap.GetWater());
            }
            //btnAddSalt.Enabled = true;
            button4.Enabled = false;
            //radioButtonClose.Checked = true;
            MessageBox.Show("Воду залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAddSalt_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDown6.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAddSalt.Enabled = false;
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            spice = new Spice();
            spice.Count = Convert.ToInt32(numericUpDown7.Value);
            if (spice.Count > 0)
            {
                pan.AddSpice(spice);
                MessageBox.Show("Специи добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Специй же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tomato_paste = new tomato_paste();
            tomato_paste.Count = Convert.ToInt32(numericUpDown8.Value);
            if (tomato_paste.Count > 0)
            {
                pan.AddPaste(tomato_paste);
                MessageBox.Show("Томатную пасту добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button9.Enabled = false;
            }
            else
            {
                MessageBox.Show("Томатной пасты же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potatos[i].Have_skin)
                {
                    MessageBox.Show("У нас обычная картошка, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                pan.AddPotato(potatos[i]);
            }
                btnAddSalt.Enabled = true;
            button5.Enabled = false;
            MessageBox.Show("Картошку положили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bow == null)
            {
                MessageBox.Show("Лука то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bow.Length == 0)
            {
                MessageBox.Show("Лука то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < bow.Length; ++i)
            {
                if (bow[i].Dirty > 0)
                {
                    MessageBox.Show("Лук грязный!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (bow[i].Have_cut)
                {
                    MessageBox.Show("Лук нужно измельчить!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < bow.Length; ++i)
            {
                pan.AddBow(bow[i]);
            }
            button6.Enabled = false;
            MessageBox.Show("Лук положили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tomato == null)
            {
                MessageBox.Show("Помидор то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tomato.Length == 0)
            {
                MessageBox.Show("Помидор то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < tomato.Length; ++i)
            {
                if (tomato[i].Dirty > 0)
                {
                    MessageBox.Show("Помидора грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tomato[i].Have_cut)
                {
                    MessageBox.Show("Сначала измельчите ингридиент!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < tomato.Length; ++i)
            {
                pan.AddTomato(tomato[i]);
            }
            button12.Enabled = false;
            MessageBox.Show("Помидору положили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (zucchini == null)
            {
                MessageBox.Show("Кабачков то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (zucchini.Length == 0)
            {
                MessageBox.Show("Кабачков то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < zucchini.Length; ++i)
            {
                if (zucchini[i].Dirty > 0)
                {
                    MessageBox.Show("Кабачок грязный!!! Какой его варить, а ну мыть его быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (zucchini[i].Have_cut)
                {
                    MessageBox.Show("Нужно сначала измельчить кабачок!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < zucchini.Length; ++i)
            {
                pan.AddZucchini(zucchini[i]);
            }
            button11.Enabled = false;
            MessageBox.Show("Кабачок положили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Моркови то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Моркови то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                if (carrot[i].Dirty > 0)
                {
                    MessageBox.Show("Морковь грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (carrot[i].Have_skin)
                {
                    MessageBox.Show("У нас обычная морковь, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                pan.AddCarrot(carrot[i]);
            }
            button10.Enabled = false;
            MessageBox.Show("Морковь положили, можно и на плиту", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        


        private void button13_Click(object sender, EventArgs e)
        {
            oven.Pan = pan;
            button13.Enabled = false;
            MessageBox.Show("Жаровня на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            oven.State = checkBox1.Checked;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (!oven.State)
            {
                MessageBox.Show("Томить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!pan.ReadyToGo)
            {
                MessageBox.Show("У нас не все готово для томления!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            oven.Cook();
            if (oven.Pan.IsReady())
            {
                //buttonGetPan.Enabled = true;
                checkBox1.Checked = false;
                MessageBox.Show("Готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так...", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //buttonDrain.Enabled = true;
            MessageBox.Show("Убрали с плиты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pan.Drain();
            button20.Enabled = false;
            MessageBox.Show("Воду слили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            potatos = pan.GetPotatos();
            carrot = pan.GetCarrot();
            bow = pan.GetBows();
            zucchini = pan.GetZuccgini();
            tomato = pan.GetTomato();
            MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

