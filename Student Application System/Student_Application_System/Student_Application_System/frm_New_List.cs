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
    public partial class frm_New_List : Form
    {
        public frm_New_List()
        {
            InitializeComponent();
        }

        private void btn_Add_List_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_New_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_Management_Studio_dbDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Student_Management_Studio_dbDataSet.Student_Details);

        }
    }
}
