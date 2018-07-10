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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Подобрать вклад");
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int k = 7, r = 6;

            int[] exMn = new int[k];
            double[,] sf = new double[k, k];
            int[,] exVl = new int[r, k];
            int[] Res1 = new int[r];
            double[,] tR;
            double[] tR1;
            double[] vft = new double[k];
            double[] result = new double[r];
            double[,] Vf = new double[k, k];
            List<double[,]> sfa = new List<double[,]>();
            List<double[,]> vfat = new List<double[,]>();
            List<double[]> vfati = new List<double[]>();
            string[] strRes = new string[r];

         
            
                try
                {
                    if ((Convert.ToInt32(rtb7.Text.ToString()) > 0) && (Convert.ToInt32(rtb1.Text.ToString()) > 0) && (Convert.ToInt32(rtb2.Text.ToString()) > 0) && (Convert.ToInt32(rtb3.Text.ToString()) > 0) && (Convert.ToInt32(rtb4.Text.ToString()) > 0) && (Convert.ToInt32(rtb5.Text.ToString()) > 0) && (Convert.ToInt32(rtb6.Text.ToString()) > 0))
                    {
                        exMn[0] = Convert.ToInt32(rtb1.Text.ToString());
                        exMn[1] = Convert.ToInt32(rtb2.Text.ToString());
                        exMn[2] = Convert.ToInt32(rtb3.Text.ToString());
                        exMn[3] = Convert.ToInt32(rtb4.Text.ToString());
                        exMn[4] = Convert.ToInt32(rtb5.Text.ToString());
                        exMn[5] = Convert.ToInt32(rtb6.Text.ToString());
                        exMn[6] = Convert.ToInt32(rtb7.Text.ToString());
                       
                   
                
            
            
                
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    sf[i, j] = exMn[i] / Convert.ToDouble(exMn[j]);
                }
            }

            for (int i = 0; i < r; i++)
            {
                OleDbConnection connection0 = new OleDbConnection();
                connection0.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
                connection0.Open();

                string query0 = "SELECT Stavka FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query1 = "SELECT MinSumTisR FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query2 = "SELECT ViplataProc FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query3 = "SELECT Capital FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query4 = "SELECT Popoln FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query5 = "SELECT ChastichSn FROM table1 WHERE Код = " + Convert.ToString(i + 1);
                string query6 = "SELECT MinVel FROM table1 WHERE Код = " + Convert.ToString(i + 1);

                OleDbCommand command0 = new OleDbCommand(query0, connection0);
                OleDbCommand command1 = new OleDbCommand(query1, connection0);
                OleDbCommand command2 = new OleDbCommand(query2, connection0);
                OleDbCommand command3 = new OleDbCommand(query3, connection0);
                OleDbCommand command4 = new OleDbCommand(query4, connection0);
                OleDbCommand command5 = new OleDbCommand(query5, connection0);
                OleDbCommand command6 = new OleDbCommand(query6, connection0);



                // выполняем запрос и выводим результат в textBox1
                exVl[i, 0] = Convert.ToInt32(command0.ExecuteScalar().ToString());
                exVl[i, 1] = Convert.ToInt32(command1.ExecuteScalar().ToString());
                exVl[i, 2] = Convert.ToInt32(command2.ExecuteScalar().ToString());
                exVl[i, 3] = Convert.ToInt32(command3.ExecuteScalar().ToString());
                exVl[i, 4] = Convert.ToInt32(command4.ExecuteScalar().ToString());
                exVl[i, 5] = Convert.ToInt32(command5.ExecuteScalar().ToString());
                exVl[i, 6] = Convert.ToInt32(command6.ExecuteScalar().ToString());

                connection0.Close();
            }

            for (int t = 0; t < k; t++)
            {
                tR = new double[r, r];
                for (int i = 0; i < r; i++)
                    for (int j = 0; j < r; j++)
                    {

                        tR[i, j] = exVl[i, t] * (1 / Convert.ToDouble(exVl[j, t]));
                    }
                sfa.Add(tR);
            }

            for (int t = 0; t < k; t++)
            {
                tR = new double[r, r];
                for (int i = 0; i < r; i++)
                    for (int j = 0; j < r; j++)
                    {
                        double sum = 0;
                        for (int l = 0; l < r; l++)
                            sum += sfa[t][l, j];
                        tR[i, j] = sfa[t][i, j] / sum;
                    }
                vfat.Add(tR);
            }

            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                {
                    double sum = 0;
                    for (int l = 0; l < k; l++)
                        sum += sf[l, j];
                    Vf[i, j] = sf[i, j] / sum;
                }

            for (int t = 0; t < k; t++)
            {
                double sum = 0;
                for (int j = 0; j < k; j++)
                    sum += Vf[t, j];
                vft[t] = sum / k;
            }



            for (int t = 0; t < k; t++)
            {
                tR1 = new double[r];
                for (int i = 0; i < r; i++)
                {
                    double sum = 0;
                    for (int l = 0; l < r; l++)
                        sum += vfat[t][i, l];
                    tR1[i] = sum / r;
                }
                vfati.Add(tR1);
            }

            for (int i = 0; i < r; i++)
            {
                double sum = 0;
                for (int t = 0; t < k; t++)
                    sum += vft[t] * vfati[t][i];
                result[i] = sum;
            }
            for (int i = 0; i < r; i++)
            {
                Res1[i] = i + 1;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r - 1; j++)
                {
                    if (result[j] <= result[j + 1])
                    {
                        int z1 = Res1[j];
                        double z = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = z;
                        Res1[j] = Res1[j + 1];
                        Res1[j + 1] = z1;
                    }
                }
            }

            for (int i = 0; i < r; i++)
            {
                OleDbConnection connection0 = new OleDbConnection();
                connection0.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
                connection0.Open();
                string query0 = "SELECT Naime FROM table1 WHERE Код = " + Convert.ToString(Res1[i]);
                OleDbCommand command0 = new OleDbCommand(query0, connection0);
                strRes[i] = command0.ExecuteScalar().ToString();


                connection0.Close();
            }
            this.Close();
            FormResult f = new FormResult(strRes, exMn, k, r);
            f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Введите целое положительное число!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            catch
            {
                MessageBox.Show("Введите целое положительное число!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = BankS.Properties.Resources.deposit_white;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = BankS.Properties.Resources.deposit;
        }
    }
}
