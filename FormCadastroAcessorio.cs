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
    public partial class FormCadastroAcessorio : Form
    {
        //INSTANCIA DA CLASSE DAO
        SQLite Instancia_SQLite = new SQLite();
        //CONECXAO COM BANCO
        SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Lista_Telefonica_Dados\\Lista_Telefonica.s3db");
        //VAREAVES QUE POSSIBILITA A FUNÇAO SELECT
        SQLiteCommand command;
        SQLiteDataAdapter adapter;
        DataTable table;


        public FormCadastroAcessorio()
        {
            InitializeComponent();
        }


        private void FormCadastroAcessorio_Load(object sender, EventArgs e)
        {
            //PARAMETROS PARA DESIGN DA TABELA
            dataGridViewAcessorio.DataSource = Instancia_SQLite.Carregar_Base_Dados_acessorio();

        }

        private void dataGridViewAcessorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SETANDO VALORES NA GRID_TABELA
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewAcessorio.Rows[e.RowIndex];

                textBox_IDacessorioAcessorio.Text = row.Cells["id"].Value.ToString();
                textBox_NomeAnimalAcessorio.Text = row.Cells["tipo_animal"].Value.ToString();
                textBox_ProdutoAcessorio.Text = row.Cells["nome_acessorio"].Value.ToString();
                textBox_UtilidadeAcessorio.Text = row.Cells["utilidade"].Value.ToString();
                textBox_PesoAcessorio.Text = row.Cells["peso"].Value.ToString();
                textBox_PrecoAcessorio.Text = row.Cells["preco"].Value.ToString();
                maskedTextBoxValidadeAcessorio.Text = row.Cells["validade"].Value.ToString();
                textBox_QuantidadeAcessorio.Text = row.Cells["quantidade"].Value.ToString();

            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            //ATRIBUINDO VALORES AS COLUNAS PARA CRECENTAR DADOS
            Instancia_SQLite.Abrir_Conexion();
            string[] Dados = new string[8];
            Dados[0] = textBox_IDacessorioAcessorio.Text;
            Dados[1] = textBox_NomeAnimalAcessorio.Text;
            Dados[2] = textBox_ProdutoAcessorio.Text;
            Dados[3] = textBox_UtilidadeAcessorio.Text;
            Dados[4] = textBox_PesoAcessorio.Text;
            Dados[5] = textBox_PrecoAcessorio.Text;
            Dados[6] = maskedTextBoxValidadeAcessorio.Text;
            Dados[7] = textBox_QuantidadeAcessorio.Text;

            Instancia_SQLite.Cadastro_Contato_acessorio(Dados);

            Instancia_SQLite.Desconectar();

            dataGridViewAcessorio.DataSource = Instancia_SQLite.Carregar_Base_Dados_acessorio();

            textBox_NomeAnimalAcessorio.Text = "";
            textBox_ProdutoAcessorio.Text = "";
            textBox_UtilidadeAcessorio.Text = "";
            textBox_PesoAcessorio.Text = "";
            textBox_PrecoAcessorio.Text = "";
            maskedTextBoxValidadeAcessorio.Text = "";
            textBox_QuantidadeAcessorio.Text = "";
        }

        private void button_excluirAcessorio_Click(object sender, EventArgs e)
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
                Dados[0] = textBox_IDacessorioAcessorio.Text;


                Instancia_SQLite.Delete_Contato_acessorio(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewAcessorio.DataSource = Instancia_SQLite.Carregar_Base_Dados_acessorio();

                textBox_NomeAnimalAcessorio.Text = "";
                textBox_ProdutoAcessorio.Text = "";
                textBox_UtilidadeAcessorio.Text = "";
                textBox_PesoAcessorio.Text = "";
                textBox_PrecoAcessorio.Text = "";
                textBox_QuantidadeAcessorio.Text = "";
                maskedTextBoxValidadeAcessorio.Text = "";
                textBox_IDacessorioAcessorio.Text = "";
            }
        }

        private void button_AlterarAcessorio_Click(object sender, EventArgs e)
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
                // EXECUTANDO AÇAO

                //ATRIBUINDO VALORES AS COLUNAS PARA ALTERAÇAO DADOS
                Instancia_SQLite.Abrir_Conexion();
                string[] Dados = new string[8];
                Dados[0] = textBox_IDacessorioAcessorio.Text;
                Dados[1] = textBox_NomeAnimalAcessorio.Text;
                Dados[2] = textBox_ProdutoAcessorio.Text;
                Dados[3] = textBox_UtilidadeAcessorio.Text;
                Dados[4] = textBox_PesoAcessorio.Text;
                Dados[5] = textBox_PrecoAcessorio.Text;
                Dados[6] = maskedTextBoxValidadeAcessorio.Text;
                Dados[7] = textBox_QuantidadeAcessorio.Text;

                Instancia_SQLite.Alterar_Campos_acessorio(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewAcessorio.DataSource = Instancia_SQLite.Carregar_Base_Dados_acessorio();

            }

        }

        private void textBox_NomeAnimalAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_NomeAnimalAcessorio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_ProdutoAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_ProdutoAcessorio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_UtilidadeAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_UtilidadeAcessorio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PrecoAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PrecoAcessorio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PesoAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PesoAcessorio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_QuantidadeAcessorio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_QuantidadeAcessorio.CharacterCasing = CharacterCasing.Upper;
        }
    }
       
}