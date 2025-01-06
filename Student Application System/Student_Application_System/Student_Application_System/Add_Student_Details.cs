using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Application_System
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Student_Management_Studio.db;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Add_Student_Details_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
        }

        private void btn_Add_List_Click(object sender, EventArgs e)
        {
            frm_New_List obj = new frm_New_List();
            obj.Show();
            this.Hide();
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void tb_Mobile_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();

            if(tb_Roll_No.Text != "" &&  tb_Name.Text !="" && tb_Mobile_No.Text !="" && cmb_Courses.Text !="")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details values(@RNo,@NM,@MobNo,@D_O_B,@course)";


                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("D_O_B", SqlDbType.Date).Value = dtp_D_O_B.Text;
                Cmd.Parameters.Add("course", SqlDbType.VarChar).Value = cmb_Courses.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Successfuly.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Con.Close();
        }
    }
}
