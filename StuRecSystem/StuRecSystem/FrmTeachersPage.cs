using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StuRecSystem
{
    public partial class FrmTeachersPage : Form
    {
        public FrmTeachersPage()
        {
            InitializeComponent();
        }

        public string num; 

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RTIPF2B\SQLEXPRESS;Initial Catalog=DBNotKayit;Integrated Security=True");

        private void FrmTeachersPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotKayitDataSet.STULESSON' table. You can move, or remove it, as needed.
            this.sTULESSONTableAdapter.Fill(this.dBNotKayitDataSet.STULESSON);

            connection.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(Situation) From STULESSON where Situation='True' ", connection);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lblPass.Text = dr[0].ToString();
            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("Select Count(Situation) From STULESSON where Situation='False' ", connection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblFail.Text = dr2[0].ToString();
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into STULESSON (STU_NUM, STU_Name, STU_Sname) values(@P1,@P2,@P3)", connection);
            cmd.Parameters.AddWithValue("@P1", mskNum.Text);
            cmd.Parameters.AddWithValue("@P2", txtName.Text);
            cmd.Parameters.AddWithValue("@P3", txtSurname.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Sisteme eklendi.");
            this.sTULESSONTableAdapter.Fill(this.dBNotKayitDataSet.STULESSON);
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            mskNum.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            txtExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, e1, e2, e3;
            string situation;
            e1 = Convert.ToDouble(txtExam1.Text);
            e2 = Convert.ToDouble(txtExam2.Text);
            e3 = Convert.ToDouble(txtExam3.Text);

            average = (e1 + e2 + e3) / 3;
            lblAvg.Text = average.ToString();

            if(average>=50)
            {
                situation = "True";
            }
            else
            {
                situation="False";
            }

            connection.Open();
            SqlCommand cmd = new SqlCommand("update STULESSON set STU_Exam1 = @P1, STU_Exam2 = @P2, STU_Exam3 = @P3, AVERAGE = @P4, Situation = @P5 WHERE STU_NUM = @P6", connection);
            cmd.Parameters.AddWithValue("@P1", txtExam1.Text);
            cmd.Parameters.AddWithValue("@P2", txtExam2.Text);
            cmd.Parameters.AddWithValue("@P3", txtExam3.Text);
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(lblAvg.Text));
            cmd.Parameters.AddWithValue("@P5", situation);
            cmd.Parameters.AddWithValue("@P6", mskNum.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi.");
            this.sTULESSONTableAdapter.Fill(this.dBNotKayitDataSet.STULESSON);
        }
    }
        
}
    

