﻿using System;
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
            bool validaCPF = false;
            validaCPF = Valida(Msk_CPF.Text);
            if (validaCPF == true)
            {
                // caixa de mensagem 
                MessageBox.Show("CPF VÁLIDO","Mensagem de validação",MessageBoxButtons.OK,MessageBoxIcon.Information);//peimeiro argumento é a validação a segunda é a mensagem que vai vir no caption, e o terceiro é o icon 
               
            }
            else
            {
                MessageBox.Show("CPF INVALIDO", "Mensagem de Validação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }
    }
}
