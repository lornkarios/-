using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BankS
{
    public partial class FormResult : Form
    {
        public string[] result;
        public int[] zapros;
        public int k, r;
        public FormResult()
        {
            InitializeComponent();
        }
        public FormResult(string[] Result, int[] Zapros, int K, int R)
        {
            InitializeComponent();
            result = Result;
            zapros = Zapros;
            k = K;
            r = R;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = BankS.Properties.Resources.tick_inside_circle_white;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = BankS.Properties.Resources.tick_inside_circle;
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(result);
            label1.Text = "Вклад - " +"\"" +result[0]+"\"";
        }

       
    }
}
