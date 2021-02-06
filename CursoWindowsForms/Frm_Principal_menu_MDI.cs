using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_menu_MDI : Form
    {
        public Frm_Principal_menu_MDI()
        {
            InitializeComponent();
        }
        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey abir = new Frm_DemonstracaoKey();
            abir.MdiParent = this;
            abir.Show();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld abir = new Frm_HelloWorld();
            abir.MdiParent = this;
            abir.Show();
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara abir = new Frm_Mascara();
            abir.MdiParent = this; 
            abir.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF abir = new Frm_ValidaCPF();
            abir.MdiParent = this; 
            abir.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 abir = new Frm_ValidaCPF2();
            abir.MdiParent = this;
            abir.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha abir = new Frm_ValidaSenha();
            abir.MdiParent = this.MdiParent; 
            abir.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
