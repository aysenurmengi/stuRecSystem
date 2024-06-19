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
    public partial class FrmStudentPage : Form
    {
        public FrmStudentPage()
        {
            InitializeComponent();
        }

        public string number;

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-RTIPF2B\SQLEXPRESS;Initial Catalog=DBNotKayit;Integrated Security=True");
     
        private void FrmStudentPage_Load(object sender, EventArgs e)
        {
            LblStuNum.Text = number;

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From STULESSON where STU_NUM=@p1", connection);
            command .Parameters.AddWithValue("@p1", number);
            SqlDataReader dr = command.ExecuteReader();  
            while (dr.Read())
            {
                LblNameS.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblExam1.Text = dr[4].ToString();
                LblExam2.Text = dr[5].ToString();
                LblExam3.Text = dr[6].ToString();
                LblAvg.Text = dr[7].ToString();
                LblSit.Text = dr[8].ToString();
                if (LblSit.Text == "True")
                {
                    LblSit.Text = "Passed";
                } else if (LblSit.Text == "False")
                {
                    LblSit.Text = "Failed";
                }
            }
            connection.Close();
        }
    }
}
