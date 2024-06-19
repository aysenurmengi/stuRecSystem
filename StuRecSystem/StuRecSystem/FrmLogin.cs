using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuRecSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudentPage frm = new FrmStudentPage();
            frm.number = maskedTextBox1.Text;
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text == "1111")
            {
                FrmTeachersPage frm1 = new FrmTeachersPage();
                frm1.num = maskedTextBox2.Text;
                frm1.Show();
            }
        }

       
    }
}
