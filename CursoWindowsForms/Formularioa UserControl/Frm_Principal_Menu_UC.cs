using CursoWindowsForms.Formularioa_UserControl;
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
        // Instanciando os numeros de abas abertas 
        int ControleJanelasAbertasDemostracaoKey = 0;
        int ControleJanelasAbertasHelloWorld = 0;
        int ControleJanelasAbertasMascara = 0;
        int ControleJanenasAbertasValidaCPF = 0;
        int ControleJanenasAbertasValidaCPF2 = 0;
        int ControleJanenasAbertasValidaSenha = 0;

        private void demostraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dando o numeros de janelas abertas 
            ControleJanelasAbertasDemostracaoKey += 1;

            // Instanciando o user control no formulario 
            Frm_DemostracaoKey_UC abir = new Frm_DemostracaoKey_UC();

            // criando uma tabe page 
            TabPage tabePage = new TabPage();

            // nomeando as propriedades titulos e nome da tab 
            tabePage.Name = "Demostração Key " + ControleJanelasAbertasDemostracaoKey;
            tabePage.Text = "Demostração Key " + ControleJanelasAbertasDemostracaoKey;

            // Colocando a imagem na aba 
            tabePage.ImageIndex = 0;

            // Colocando o formulario dentro da TabPage
            tabePage.Controls.Add(abir);

            // adicionando as aplicações ao componente 
            Tbc_Aplicacoes.TabPages.Add(tabePage);
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dando o numero de janelas abertas 
            ControleJanelasAbertasHelloWorld += 1;

            // isntanciando o user control o formulario 
            fRM_hELLOwORD_uc u = new fRM_hELLOwORD_uc();

            //criei uma TABPAGE
            TabPage TB = new TabPage();

            //colocando as propriedades nome texto
            TB.Name = "Hello World " + ControleJanelasAbertasHelloWorld;
            TB.Text = "Hello World " + ControleJanelasAbertasHelloWorld;

            // adicionando imagens 
            TB.ImageIndex = 1;

            // colocando o formulado dentro da TABPage
            TB.Controls.Add(u);

            // adicionando as aplicações ao componente
            Tbc_Aplicacoes.TabPages.Add(TB);            

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mostrando o numero de janelas abertas 
            ControleJanelasAbertasMascara += 1;

            // Instanciando o user control no formulario 
            Frm_Mascara_UC abrir = new Frm_Mascara_UC();

            // criando a tabe page 
            TabPage tabePageMascara = new TabPage();

            // nomeando a tabe page e o titulo dela 
            tabePageMascara.Name = "Mascara " + ControleJanelasAbertasMascara;
            tabePageMascara.Text = "Mascara " + ControleJanelasAbertasMascara;

            // Colocando a imagem na aba 
            tabePageMascara.ImageIndex = 2;

            //o mais importante colocando o formulario dentro da tabe page ou janela principal 
            tabePageMascara.Controls.Add(abrir); 


            Tbc_Aplicacoes.TabPages.Add(tabePageMascara); 

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // adicionando o controle de abas
            ControleJanenasAbertasValidaCPF += 1;

            // instanciando o formulario principal 
            Frm_ValidaCPF_UC abrir = new Frm_ValidaCPF_UC(); 

            // Criando a TabePage pra por dentro do formulario principal 
            TabPage tabePageValidaCPF = new TabPage();

            // colocando o formulario dentro da tab page 
            tabePageValidaCPF.Controls.Add(abrir);

            // O mais importante colocando o formulario dentro da janela principal
            Tbc_Aplicacoes.TabPages.Add(tabePageValidaCPF);

            // nomeando a tabe page e o titulo dela 
            tabePageValidaCPF.Text = "Valida CPF" + ControleJanenasAbertasValidaCPF;
            tabePageValidaCPF.Name = "Valida CPF" + ControleJanenasAbertasValidaCPF;

            // Adicionando uma imagem ao lado do titulo
            tabePageValidaCPF.ImageIndex = 3; 
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // adicionando o controle da janela 
            ControleJanenasAbertasValidaCPF2 += 1;

            // instanciando o formulario 
            Frm_ValidaCPF2_UC abrir = new Frm_ValidaCPF2_UC();

            // criando a tabe page 
            TabPage tabePageValidaCPF2 = new TabPage();

            // colocando  o formulario dentro da tabppage
            tabePageValidaCPF2.Controls.Add(abrir); 

            // colocando a tabe page criada dentro do tab control principal 
            Tbc_Aplicacoes.TabPages.Add(tabePageValidaCPF2);

            // colocando o nome na aba 
            tabePageValidaCPF2.Name = "Valida CPF 2° " + ControleJanenasAbertasValidaCPF2; 
            tabePageValidaCPF2.Text = "Valida CPF 2° " + ControleJanenasAbertasValidaCPF2;

            // colocando a imagem no titulo 
            tabePageValidaCPF2.ImageIndex = 4; 

        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // iniciando a contançao de telas abertas 
            ControleJanenasAbertasValidaSenha += 1;

            // instanciando o formulario 
            Frm_ValidaSenha_UC abrir = new Frm_ValidaSenha_UC();

            // criando a tabPage 
            TabPage tabePageValidaSenha = new TabPage();

            //botando o formulario dentro da tabpage
            tabePageValidaSenha.Controls.Add(abrir);

            // colocando a tabpage com o formulario contido no tabcontrol
            Tbc_Aplicacoes.Controls.Add(tabePageValidaSenha); 

            // nomendo o titulo da tabpage 
            tabePageValidaSenha.Name = "Valida Senha " + ControleJanenasAbertasValidaSenha;
            tabePageValidaSenha.Text = "Valida Senha " + ControleJanenasAbertasValidaSenha;

            // colocando a logo do lado do titulo 
            tabePageValidaSenha.ImageIndex = 5; 
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
