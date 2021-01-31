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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }
        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }
        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", ""); // repalce é pra substituir no caso subistituir . por vazio e - por vazio 
            vConteudo = vConteudo.Trim(); // tira os vazios se entendi direito
            if (vConteudo == "")
            {
                MessageBox.Show("Voce deve digitar o valor do CPF", "Mensagem de Validação", MessageBoxButtons.OK);

            }
            else
            {
                //controlando a quantidade de numeros contida na barra validar 
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 12 Números", "Mensagem de Validação", MessageBoxButtons.OK);
                }                
                else
                {
                    //pergunta se o usuario quer validar O CPF dele ou não 
                    if (MessageBox.Show("Voce deseja realmente valida o CPF ?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;//dialog confirma se vc clicou no botom Ys mas poderia ser tbm NÃO
                    {
                        bool validaCPF = false;
                        validaCPF = Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            // caixa de mensagem 
                            MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);//peimeiro argumento é a validação a segunda é a mensagem que vai vir no caption, e o terceiro é o icon 

                        }
                        else
                        {
                            MessageBox.Show("CPF INVALIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

    }
}
