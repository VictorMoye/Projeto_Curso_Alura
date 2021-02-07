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
    public partial class Frm_Principal_Menu_UC : Form
    {
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey abir = new Frm_DemonstracaoKey();
            abir.Show();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // isntanciando o user control o formulario 
            fRM_hELLOwORD_uc u = new fRM_hELLOwORD_uc();

            //criei uma TABPAGE
            TabPage TB = new TabPage();

            //colocando as propriedades nome texto
            TB.Name = "Hello World";
            TB.Text = "Hello World";
            // adicionando imagens 
            TB.ImageIndex = 1;
            // colocando o formulado dentro da TABPage
            TB.Controls.Add(u);

            // adicionando as aplicações ao componente
            Tbc_Aplicacoes.TabPages.Add(TB); 

            

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara abir = new Frm_Mascara();
            abir.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF abir = new Frm_ValidaCPF();
            abir.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 abir = new Frm_ValidaCPF2();
            abir.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha abir = new Frm_ValidaSenha();
            abir.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
