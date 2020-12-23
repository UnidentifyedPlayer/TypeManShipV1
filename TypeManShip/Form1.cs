using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace TypeManShip
{
    public partial class Form1 : Form
    {
        MainController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new MainController(dataSet1);
        }

        private void pass_set_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pass_set_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void pass_enter_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    pass_enter_textbox.Text = "";
                    controller.ClearCurEntry();
                    break;
                default: controller.Key_Down(e.KeyCode, pass_enter_textbox.Text);
                    break;
            }
            e.Handled = true;
        }

        private void pass_enter_textbox_TextChanged(object sender, EventArgs e)
        {
            controller.Text_changed();
        }

        private void pass_enter_textbox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Back)
            {
                controller.Key_Up(e.KeyCode);
            }
        }

        private void pass_set_button_Click(object sender, EventArgs e)
        {
            controller.SetPassword(pass_set_textbox.Text);
            pass_set_button.Enabled = false;
            pass_set_textbox.Enabled = false;
            pass_entry_button.Enabled = true;
            pass_enter_textbox.Enabled = true;
        }

        private void pass_entry_button_Click(object sender, EventArgs e)
        {
            if (controller.Enter_button(pass_enter_textbox.Text))
            {
                PhraseInputStat stat = controller.CurrentPhraseStat;
                logbox.Text += String.Format("typing time - {0} ms, speed -  {1:f3} keys/sec",
                    stat.PressTime, stat.TypeSpeed);
                
                exp_speed.Text = String.Format("exp speed: {0:f3} keys /sec.", controller.Expected_speed);
                dispersion_l.Text = String.Format("dispersion: {0:f3} keys/sec.",controller.Dispersion);
                label1.Text = string.Format("Наложения 1-го рода: {0}", controller.CurrentPhraseStat.type1_impos);
                label2.Text = string.Format("Наложения 2-го рода: {0}", controller.CurrentPhraseStat.type2_impos);
                label3.Text = string.Format("Наложения 3-го рода: {0}", controller.CurrentPhraseStat.type3_impos);
            }
            pass_enter_textbox.Text = "";
            controller.ClearCurEntry();
            pass_enter_textbox.Focus();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            controller.Reset();
            pass_enter_textbox.Text = "";
            pass_set_textbox.Text = "";
            pass_set_button.Enabled = true;
            pass_set_textbox.Enabled = true;
            pass_entry_button.Enabled = false;
            pass_enter_textbox.Enabled = false;
        }

        List<int> array1 = new List<int> { 5, 6, 8, 4, 5, 3, 6, 7 };
        private void Form1_Load(object sender, EventArgs e)
        {
            pass_entry_button.Enabled = false;
            pass_enter_textbox.Enabled = false;
        }
        
       

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void logbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pass_set_textbox_TextChanged(object sender, EventArgs e)
        {
            Password_Q q = controller.RatePassword(pass_set_textbox.Text);
            string q_s = "";
            switch(q)
            {
                case Password_Q.Bad: q_s = "Плохой"; break;
                case Password_Q.Normal: q_s = "Нормальный"; break;
                case Password_Q.Good: q_s = "Хороший"; break;
                case Password_Q.Great: q_s = "Отличный"; break;
                case Password_Q.Safe: q_s = "Надёжный"; break;
            }
            label4.Text = "Сложность: " + q_s;
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            ShowStats stats_form = new ShowStats(controller);
            stats_form.Show();
        }

        private void day_stats_win_button_Click(object sender, EventArgs e)
        {
            DayFluctuation day_form = new DayFluctuation(controller);
            day_form.Show();
        }
    }
}
