using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text;


            Classe_Validacao validacao = new Classe_Validacao();

            bool verifica = true;

            verifica = validacao.validaCPF(cpf);

            if (verifica == true)
            {
                MessageBox.Show("CPF válido!", "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("CPF inválido!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
