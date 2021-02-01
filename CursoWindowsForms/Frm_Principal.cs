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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Desmostracao_Key_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey abir = new Frm_DemonstracaoKey();
            abir.Show(); 
        }

        private void Btn_Hello_Word_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld abir = new Frm_HelloWorld();
            abir.Show();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara abir = new Frm_Mascara();
            abir.Show();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF abir = new Frm_ValidaCPF();
            abir.Show();
        }

        private void Btn_ValdiaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 abir = new Frm_ValidaCPF2();
            abir.Show();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha abir = new Frm_ValidaSenha();
            abir.Show();
        }
    }
}
