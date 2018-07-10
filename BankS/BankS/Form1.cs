using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "Добавить клиента");
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(pictureBox4, "Таблица вкладов");
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(pictureBox5, "Выйти");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //FormV f = new FormV();
          //  f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.vtb.ru");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/sweaty_nipples");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = BankS.Properties.Resources.add_user_blue;
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = BankS.Properties.Resources.dollar_analysis_bars_chart_blue;
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = BankS.Properties.Resources.logout_blue;
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = BankS.Properties.Resources.logout_white;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = BankS.Properties.Resources.dollar_analysis_bars_chart_white;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = BankS.Properties.Resources.add_user_white;
           

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = BankS.Properties.Resources.add_user;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = BankS.Properties.Resources.dollar_analysis_bars_chart;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = BankS.Properties.Resources.logout;
        }
    }
}
