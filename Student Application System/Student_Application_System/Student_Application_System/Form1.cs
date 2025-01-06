using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Application_System
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
       
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "a123") ||(tb_Username.Text=="a" && tb_Password.Text=="a"))
            {

                MessageBox.Show(" Correct Information", "Login Successfuly", MessageBoxButtons.OK, MessageBoxIcon.None);

                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Credentials", "Login Failded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }
    }
}
