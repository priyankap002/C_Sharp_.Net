
namespace Student_Application_System
{
    partial class frm_New_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Add_List = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Add_List = new System.Windows.Forms.Button();
            this._Student_Management_Studio_dbDataSet = new Student_Application_System._Student_Management_Studio_dbDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new Student_Application_System._Student_Management_Studio_dbDataSetTableAdapters.Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Student_Management_Studio_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Add_List
            // 
            this.dgv_Add_List.AllowUserToAddRows = false;
            this.dgv_Add_List.AllowUserToDeleteRows = false;
            this.dgv_Add_List.AutoGenerateColumns = false;
            this.dgv_Add_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Add_List.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_Add_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Add_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.dgv_Add_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Add_List.Location = new System.Drawing.Point(3, 12);
            this.dgv_Add_List.Name = "dgv_Add_List";
            this.dgv_Add_List.ReadOnly = true;
            this.dgv_Add_List.RowHeadersWidth = 62;
            this.dgv_Add_List.RowTemplate.Height = 28;
            this.dgv_Add_List.Size = new System.Drawing.Size(993, 447);
            this.dgv_Add_List.TabIndex = 0;
            // 
            // btn_Add_List
            // 
            this.btn_Add_List.BackColor = System.Drawing.Color.Aqua;
            this.btn_Add_List.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_List.Location = new System.Drawing.Point(292, 491);
            this.btn_Add_List.Name = "btn_Add_List";
            this.btn_Add_List.Size = new System.Drawing.Size(359, 77);
            this.btn_Add_List.TabIndex = 14;
            this.btn_Add_List.Text = "Add New List";
            this.btn_Add_List.UseVisualStyleBackColor = false;
            this.btn_Add_List.Click += new System.EventHandler(this.btn_Add_List_Click);
            // 
            // _Student_Management_Studio_dbDataSet
            // 
            this._Student_Management_Studio_dbDataSet.DataSetName = "_Student_Management_Studio_dbDataSet";
            this._Student_Management_Studio_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this._Student_Management_Studio_dbDataSet;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_New_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(999, 614);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add_List);
            this.Controls.Add(this.dgv_Add_List);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "frm_New_List";
            this.Text = "New List";
            this.Load += new System.EventHandler(this.frm_New_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Student_Management_Studio_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Add_List;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Add_List;
        private _Student_Management_Studio_dbDataSet _Student_Management_Studio_dbDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private _Student_Management_Studio_dbDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
    }
}