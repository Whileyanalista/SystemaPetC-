using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemaPet
{
    public partial class FormCadastroAlimento : Form
    {
        //INSTANCIA DA CLASSE DAO
        SQLite Instancia_SQLite = new SQLite();
        //CONECXAO COM BANCO
        SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Lista_Telefonica_Dados\\Lista_Telefonica.s3db");
        //VAREAVES QUE POSSIBILITA A FUNÇAO SELECT
        SQLiteCommand command;
        SQLiteDataAdapter adapter;
        DataTable table;


        public FormCadastroAlimento()
        {
            InitializeComponent();
        }

        private void FormCadastroAlimento_Load(object sender, EventArgs e)
        {
            //PARAMETROS PARA DESIGN DA TABELA
            dataGridViewAlimento.DataSource = Instancia_SQLite.Carregar_Base_Dados_comida();

            //NAO PERMITE QUE COLUNAS SEJAM GERADAS ALTOMATICAMENTE PELA GDATADRIDEWIL
            dataGridViewAlimento.AutoGenerateColumns = false;
        }

        private void dataGridViewAlimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SETANDO VALORES NA GRID_TABELA
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewAlimento.Rows[e.RowIndex];

                textBoxIDAlimento.Text = row.Cells["id"].Value.ToString();
                textBox_NomeAlimento.Text = row.Cells["tipo_animal"].Value.ToString();
                textBox_ProdutoAlimento.Text = row.Cells["nome_comida"].Value.ToString();
                textBox_UtilidadeAlimento.Text = row.Cells["utilidade"].Value.ToString();
                textBox_PrecoAlimento.Text = row.Cells["peso"].Value.ToString();
                textBox_PesoAlimento.Text = row.Cells["preco"].Value.ToString();                
                maskedTextBoxValidadeAlimento.Text = row.Cells["validade"].Value.ToString();
                textBox_QuantidadeAlomento.Text = row.Cells["quantidade"].Value.ToString();

            }
        }

        private void button_salvarAlimento_Click(object sender, EventArgs e)
        {

            //ATRIBUINDO VALORES AS COLUNAS PARA CRECENTAR DADOS
            Instancia_SQLite.Abrir_Conexion();
            string[] Dados = new string[8];
            Dados[0] = textBoxIDAlimento.Text;
            Dados[1] = textBox_NomeAlimento.Text;
            Dados[2] = textBox_ProdutoAlimento.Text;
            Dados[3] = textBox_UtilidadeAlimento.Text;
            Dados[4] = textBox_PrecoAlimento.Text;
            Dados[5] = textBox_PesoAlimento.Text;
            Dados[6] = maskedTextBoxValidadeAlimento.Text;
            Dados[7] = textBox_QuantidadeAlomento.Text;

            Instancia_SQLite.Cadastro_Contato_comida(Dados);

            Instancia_SQLite.Desconectar();

            dataGridViewAlimento.DataSource = Instancia_SQLite.Carregar_Base_Dados_comida();

            textBox_NomeAlimento.Text = "";
            textBox_ProdutoAlimento.Text = "";
            textBox_UtilidadeAlimento.Text = "";
            textBox_PrecoAlimento.Text = "";
            textBox_PesoAlimento.Text = "";
            maskedTextBoxValidadeAlimento.Text = "";
            textBox_QuantidadeAlomento.Text = "";
        }



        private void button_excluirAlimento_Click(object sender, EventArgs e)
        {
            //ATRIBUINDO VALORES AS VARIAVES PARA MENSAGEM
            string message = "GOSTARIA DE APAGAR OS DADOS ?";
            string caption = "DADOS DELETADOS COM SUCESSO.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //USANDO AS VARIAVES COM OS VALORES 
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {

                //ATRIBUINDO VALORES AS COLUNAS PARA ALTERAÇAO
                Instancia_SQLite.Abrir_Conexion();
                string[] Dados = new string[1];
                Dados[0] = textBoxIDAlimento.Text;


                Instancia_SQLite.Delete_Contato_comida(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewAlimento.DataSource = Instancia_SQLite.Carregar_Base_Dados_comida();

                textBox_NomeAlimento.Text = "";
                textBox_ProdutoAlimento.Text = "";
                textBox_UtilidadeAlimento.Text = "";
                textBox_PrecoAlimento.Text = "";
                textBox_PesoAlimento.Text = "";
                maskedTextBoxValidadeAlimento.Text = "";
                textBox_QuantidadeAlomento.Text = "";

            }
        }

        private void button_AlterarAlimento_Click(object sender, EventArgs e)
        {
            //ATRIBUINDO VALORES AS VARIAVES PARA MENSAGEM
            string message = "GOSTARIA DE ALTERAR ESTE DADOS?";
            string caption = "DADOS ALTERADOS COM SUCESSO";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            //USANDO AS VARIAVES COM OS VALORES 
            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {

                //ATRIBUINDO VALORES AS COLUNAS PARA ALTERAÇAO DADOS
                Instancia_SQLite.Abrir_Conexion();
                string[] Dados = new string[8];
                Dados[0] = textBoxIDAlimento.Text;
                Dados[1] = textBox_NomeAlimento.Text;
                Dados[2] = textBox_ProdutoAlimento.Text;
                Dados[3] = textBox_UtilidadeAlimento.Text;
                Dados[4] = textBox_PrecoAlimento.Text;
                Dados[5] = textBox_PesoAlimento.Text;
                Dados[6] = maskedTextBoxValidadeAlimento.Text;
                Dados[7] = textBox_QuantidadeAlomento.Text;

                Instancia_SQLite.Alterar_Campos_comida(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewAlimento.DataSource = Instancia_SQLite.Carregar_Base_Dados_comida();
            }

        }

        private void textBox_NomeAlimento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_NomeAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_ProdutoAlimento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_ProdutoAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_UtilidadeAlimento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_UtilidadeAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PrecoAlimento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PrecoAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PesoAlimento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PesoAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_QuantidadeAlomento_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_QuantidadeAlomento.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
