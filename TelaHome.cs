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
    public partial class TelaHome : Form
    {
        string valido = "0";
        //INSTANCIA DA CLASSE DAO
        SQLite Instancia_SQLite = new SQLite();
        //CONECXAO COM BANCO
        SQLiteConnection connection = new SQLiteConnection("Data Source = C:\\BD_SystemaPT\\BD_SystemaPT.s3db");
        //VAREAVES QUE POSSIBILITA A FUNÇAO SELECT
        SQLiteCommand command;
        SQLiteDataAdapter adapter;
        DataTable table;

        public TelaHome()
        {
            InitializeComponent();
        }

        private void TelaHome_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            //PARAMETROS ATRIBUINDO VALORES DA TEXTBOX
            string valerToSearch = textBox_Pesquisa.Text.ToString();
            seachData(valerToSearch);
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_Pesquisa.CharacterCasing = CharacterCasing.Upper;
        }


        //METODO PARA FILTRO
        private void seachData(string valueToSearch)
        {
            DataTable databaseobject = new DataTable();

            if (textBox_Pesquisa.Text == "")
            {
                //PARAMETROS QUE POSSIBILITA O SELECT COM LIKE NO BANCO
                string query = "SELECT nome_remedio,peso,preco,validade,quantidade FROM remedio WHERE nome_remedio LIKE @nome_remedio";
                command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nome_remedio", textBox_Pesquisa.Text + "%");
                adapter = new SQLiteDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewTelaHome.DataSource = table;
            }
        }
        

        private void textBox_Pesquisa_Leave(object sender, EventArgs e)
        {
            //INFORMAÇOES PARA O USUARIO 
            if (textBox_Pesquisa.Text == "")
            {
                textBox_Pesquisa.Text = "PESQUISE UM PRODUTO";
                textBox_Pesquisa.ForeColor = Color.Black;
                this.Focus();
            }
        }


        private void textBox_Pesquisa_Click(object sender, EventArgs e)
        {
            //INFORMAÇOES PARA O USUARIO 
            if (textBox_Pesquisa.Text == "PESQUISE UM PRODUTO")
            {
                textBox_Pesquisa.Clear();
                textBox_Pesquisa.ForeColor = Color.Black;
            }
            //ESCREVER EM MAIUSCULO ALTOMATICAMENTE
            textBox_Pesquisa.CharacterCasing = CharacterCasing.Upper;

        }


       public void buttonRemed_Click(object sender, EventArgs e)
        {
            FormCadastroRemedio formCadastroRemedio = new FormCadastroRemedio();
            TelaLogn telaLogn = new TelaLogn();
            telaLogn.Show();

            if ((telaLogn.Visible == false))
            {
                formCadastroRemedio.Show();
            }
        }


        private void buttonBrinquedos_Click(object sender, EventArgs e)
        {
            FormCadastroAcessorio formCadastroAcessorio = new FormCadastroAcessorio();
            TelaLogn telaLogn = new TelaLogn();
            telaLogn.Show();

            if (telaLogn.Visible == false)
            {
                formCadastroAcessorio.Show();
            }
            
        }


        private void buttonAlimentos_Click(object sender, EventArgs e)
        {
            FormCadastroAlimento formCadastroAlimento = new FormCadastroAlimento();
            TelaLogn telaLogn = new TelaLogn();
            telaLogn.Show();

            if (telaLogn.Visible == false)
            {
                formCadastroAlimento.Show();
            }
           
        }


        private void dataGridViewTelaHome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SETANDO VALORES NA GRID_TABELA
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridViewTelaHome.Rows[e.RowIndex];

            }
        }


        private void textBox_Pesquisa_Enter(object sender, EventArgs e)
        {
            this.Focus();
        }
        
    }
    
}
