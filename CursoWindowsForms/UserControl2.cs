using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class UserControl2 : CursoWindowsForms.UserControl1
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = DataSetSchemaImporterExtension(
                @"C:\Users\victo\Documents\HDBI - victor moye .xlsm", true).Tables[0];
        }
    }
}
