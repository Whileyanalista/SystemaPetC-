using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemaPet
{
    public partial class TelaLogn : Form
    {
               
        public TelaLogn()


        {
            InitializeComponent();
        }

        FormCadastroRemedio FormCadastroRemedio = new FormCadastroRemedio();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textBoxSenha_Enter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBoxSenha.CharacterCasing = CharacterCasing.Upper;
        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            //VALIDANDO ACESSO SENHA
            if (textBoxSenha.Text == "123")
            {
                this.Close();            
               
            }

        }
    }
}
