using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Semana_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = " ";
            textSobrenome.Text = " ";
            result.Text = "Seu nome aparecerá aqui: ";

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void btConcatenar_Click(object sender, EventArgs e)
        {
            result.Text = "Seu nome é: " + textNome.Text + " " + textSobrenome.Text;

        }

        private void sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void textSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
