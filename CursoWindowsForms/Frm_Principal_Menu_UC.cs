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
        int ControleHellowldId = 0;
        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey abir = new Frm_DemonstracaoKey();
            abir.Show();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dando o numero de janelas abertas 
            ControleHellowldId += 1;
            // isntanciando o user control o formulario 
            fRM_hELLOwORD_uc u = new fRM_hELLOwORD_uc();

            //criei uma TABPAGE
            TabPage TB = new TabPage();

            //colocando as propriedades nome texto
            TB.Name = "Hello World" + ControleHellowldId;
            TB.Text = "Hello World" + ControleHellowldId;

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

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // controlando apagando somente se tiver tabs selecionadas
            if (!(Tbc_Aplicacoes.SelectedTab == null))// se tab page não for nula ela entra e apaga as que estao abertas 
            {
                // apagando as aplicalçoes que o mause estiver seelcionando 
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }

        }
    }
}
