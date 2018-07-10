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
using Excel = Microsoft.Office.Interop.Excel;

namespace BankS
{
    public partial class Form3 : Form
    {
        public int[,] matrix = new int[6,7];
        public Form3()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter.Fill(this.database1DataSet1.table1);
            

        }

        

        private void OnApplicationExit(object sender, EventArgs e)
        {
           
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
           
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {





                OleDbConnection connection0 = new OleDbConnection();



                connection0.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";

                connection0.Open();



                string query0 = "UPDATE table1 SET Stavka = " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query1 = "UPDATE table1 SET MinSumTisR = " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query2 = "UPDATE table1 SET ViplataProc = " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query3 = "UPDATE table1 SET Capital = " + dataGridView1.Rows[i].Cells[4].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query4 = "UPDATE table1 SET Popoln = " + dataGridView1.Rows[i].Cells[5].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query5 = "UPDATE table1 SET ChastichSn = " + dataGridView1.Rows[i].Cells[6].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);
                string query6 = "UPDATE table1 SET MinVel = " + dataGridView1.Rows[i].Cells[7].Value.ToString() + " WHERE Код = " + Convert.ToString(i + 1);





                OleDbCommand command0 = new OleDbCommand(query0, connection0);
                OleDbCommand command1 = new OleDbCommand(query1, connection0);
                OleDbCommand command2 = new OleDbCommand(query2, connection0);
                OleDbCommand command3 = new OleDbCommand(query3, connection0);
                OleDbCommand command4 = new OleDbCommand(query4, connection0);
                OleDbCommand command5 = new OleDbCommand(query5, connection0);
                OleDbCommand command6 = new OleDbCommand(query6, connection0);

                command0.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
                connection0.Close();

            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введите целое положительное число!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
