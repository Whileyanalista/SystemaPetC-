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
    public partial class FormCadastroRemedio : Form
    {
        //INSTANCIA DA CLASSE DAO
        SQLite Instancia_SQLite = new SQLite();
        //CONECXAO COM BANCO
        SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\Lista_Telefonica_Dados\\Lista_Telefonica.s3db");
        //VAREAVES QUE POSSIBILITA A FUNÇAO SELECT
        SQLiteCommand command;
        SQLiteDataAdapter adapter;
        DataTable table;

        public FormCadastroRemedio()
        {
            InitializeComponent();
        }      

        private void FormCadastroRemedio_Load(object sender, EventArgs e)
        {
            //PARAMETROS PARA DESIGN DA TABELA
            dataGridViewRemedio.DataSource = Instancia_SQLite.Carregar_Base_Dados_remedio();
            //NAO PERMITE QUE COLUNAS SEJAM GERADAS ALTOMATICAMENTE PELA GDATADRIDEWIL
            dataGridViewRemedio.AutoGenerateColumns = false;
        }

        private void dataGridViewRemedio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SETANDO VALORES NA GRID_TABELA
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewRemedio.Rows[e.RowIndex];

                textBoxIDRemedio.Text = row.Cells["id"].Value.ToString();
                textBox_NomeRemedio.Text = row.Cells["tipo_animal"].Value.ToString();
                textBox_ProdutoRemedio.Text = row.Cells["nome_remedio"].Value.ToString();
                textBox_UtilidadeRemedio.Text = row.Cells["utilidade"].Value.ToString();
                textBox_PrecoRemedio.Text = row.Cells["peso"].Value.ToString();
                textBox_PesoRemedio.Text = row.Cells["preco"].Value.ToString();                
                maskedTextBoxValidadeRemedio.Text = row.Cells["validade"].Value.ToString();
                textBox_QuantidadeRemedio.Text = row.Cells["quantidade"].Value.ToString();

            }
        }

        private void button_SalvarRemedio_Click(object sender, EventArgs e)
        {
            //ATRIBUINDO VALORES AS COLUNAS PARA CRECENTAR DADOS
            Instancia_SQLite.Abrir_Conexion();
            string[] Dados = new string[8];
            Dados[0] = textBoxIDRemedio.Text;
            Dados[1] = textBox_NomeRemedio.Text;
            Dados[2] = textBox_ProdutoRemedio.Text;
            Dados[3] = textBox_UtilidadeRemedio.Text;
            Dados[4] = textBox_PrecoRemedio.Text;
            Dados[5] = textBox_PesoRemedio.Text;
            Dados[6] = maskedTextBoxValidadeRemedio.Text;
            Dados[7] = textBox_QuantidadeRemedio.Text;

            Instancia_SQLite.Cadastro_Contato_remedio(Dados);

            Instancia_SQLite.Desconectar();

            dataGridViewRemedio.DataSource = Instancia_SQLite.Carregar_Base_Dados_remedio();

            textBoxIDRemedio.Text = "";
            textBox_NomeRemedio.Text = "";
            textBox_ProdutoRemedio.Text = "";
            textBox_UtilidadeRemedio.Text = "";
            textBox_PrecoRemedio.Text = "";
            textBox_PesoRemedio.Text = "";
            maskedTextBoxValidadeRemedio.Text = "";
            textBox_QuantidadeRemedio.Text = "";
        }

        private void button_ExcluirRemedio_Click(object sender, EventArgs e)
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
                Dados[0] = textBoxIDRemedio.Text;


                Instancia_SQLite.Delete_Contato_remedio(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewRemedio.DataSource = Instancia_SQLite.Carregar_Base_Dados_remedio();

                textBox_NomeRemedio.Text = "";
                textBox_ProdutoRemedio.Text = "";
                textBox_UtilidadeRemedio.Text = "";
                textBox_PrecoRemedio.Text = "";
                textBox_PesoRemedio.Text = "";
                maskedTextBoxValidadeRemedio.Text = "";
                textBox_QuantidadeRemedio.Text = "";
            }

        }

        private void button_AlterarRemedio_Click(object sender, EventArgs e)
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
                Dados[0] = textBoxIDRemedio.Text;
                Dados[1] = textBox_NomeRemedio.Text;
                Dados[2] = textBox_ProdutoRemedio.Text;
                Dados[3] = textBox_UtilidadeRemedio.Text;
                Dados[4] = textBox_PrecoRemedio.Text;
                Dados[5] = textBox_PesoRemedio.Text;
                Dados[6] = maskedTextBoxValidadeRemedio.Text;
                Dados[7] = textBox_QuantidadeRemedio.Text;

                Instancia_SQLite.Alterar_Campos_remedio(Dados);

                Instancia_SQLite.Desconectar();

                dataGridViewRemedio.DataSource = Instancia_SQLite.Carregar_Base_Dados_remedio();
            }

        }

        private void textBox_NomeRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_NomeRemedio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_ProdutoRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_ProdutoRemedio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_UtilidadeRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_UtilidadeRemedio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PrecoRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PrecoRemedio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_PesoRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_PesoRemedio.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox_QuantidadeRemedio_TextChanged(object sender, EventArgs e)
        {
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_QuantidadeRemedio.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
