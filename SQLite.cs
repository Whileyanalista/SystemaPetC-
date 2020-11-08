using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemaPet
{
    class SQLite
    {

        SQLiteConnection Conexion;

        //ESTABELECENDO UMA CONEXÃO COM O BANCO
        public void Abrir_Conexion()
        {
            Conexion = new SQLiteConnection("Data Source = C:\\BD_SystemaPT\\BD_SystemaPT.s3db");
            Conexion.Open();
        }


        //DESCONECTA A BASE DE DADOS
        public void Desconectar()
        {
            Conexion.Close();
        }

        //CRIANDO TABELA COM BANCO SQLite   
        public void Crear_Base_Dados()
        {
            this.Abrir_Conexion();

            try
            {
                //CRAR TABELA 
                String comando = "CREATE TABLE remedio " +
                    "(" +
                        "id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL," +
                        "tipo_animal VARCHAR(20)  NULL," +
                        "nome_remedio VARCHAR(100)  NULL, " +
                        "utilidade VARCHAR(100)  NULL," +
                        "peso VARCHAR(10)  NULL," +
                        "preco VARCHAR(10)  NULL,   " +
                        "validade VARCHAR(20)  NULL,   " +
                        "quantidade VARCHAR(10)  NULL" +          
                    " );" +
                    "CREATE TABLE senha " +
                    "(" +
                        "id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL," +                        
                        "senha VARCHAR(20)  NULL " +                        
                    " );" +
                    "CREATE TABLE acessorio " +
                    "(" +
                        "id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL," +
                        "tipo_animal VARCHAR(20)  NULL," +
                        "nome_acessorio VARCHAR(100)  NULL, " +
                        "utilidade VARCHAR(100)  NULL," +
                        "peso VARCHAR(10)  NULL," +
                        "preco VARCHAR(10)  NULL,   " +
                        "validade VARCHAR(20)  NULL,   " +
                        "quantidade VARCHAR(10)  NULL " +
                    " );" +
                    "CREATE TABLE comida " +
                    "(" +
                        "id INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL," +
                        "tipo_animal VARCHAR(20)  NULL," +
                        "nome_comida VARCHAR(100)  NULL, " +
                        "utilidade VARCHAR(100)  NULL," +
                        "peso VARCHAR(10)  NULL," +
                        "preco VARCHAR(10)  NULL,   " +
                        "validade VARCHAR(20)  NULL,   " +
                        "quantidade VARCHAR(10)  NULL " +
                    " );";
                               
                SQLiteCommand SQLiteCommand = new SQLiteCommand(comando, Conexion);

                int error = SQLiteCommand.ExecuteNonQuery();

                if (error > 0)
                {

                }
            }
            catch (Exception)
            {

            }

            this.Desconectar();
        }

        //ATUALIZANDO TABELA COM DADOS DO BANCO
        public DataTable Carregar_Base_Dados_remedio()
        {
            this.Abrir_Conexion();

            DataTable DataTable = new DataTable();

            try
            {
                string comando = "select * from remedio";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);

                SQLiteAdapter.Fill(DataTable);
            }
            catch (Exception) { }

            return DataTable;
        }

        //ATUALIZANDO TABELA COM DADOS DO BANCO
        public DataTable Carregar_Base_Dados_acessorio()
        {
            this.Abrir_Conexion();

            DataTable DataTable = new DataTable();

            try
            {
                string comando = "select * from acessorio";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);

                SQLiteAdapter.Fill(DataTable);
            }
            catch (Exception) { }

            return DataTable;
        }

        //ATUALIZANDO TABELA COM DADOS DO BANCO
        public DataTable Carregar_Base_Dados_comida()
        {
            this.Abrir_Conexion();

            DataTable DataTableComida = new DataTable();

            try
            {
                string comando = "select * from comida";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);

                SQLiteAdapter.Fill(DataTableComida);
            }
            catch (Exception) { }

            return DataTableComida;

        }


        //CADASTRANDO   
        public void Cadastro_Contato_remedio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "insert into remedio " +
                    "(" +
                        "tipo_animal, nome_remedio, utilidade, peso, preco,validade, quantidade" +
                    ") " +
                    "values (?,?,?,?,?,?,?)";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("tipo_animal", Dados[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("nome_remedio", Dados[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("utilidade", Dados[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("peso", Dados[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("preco", Dados[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("validade", Dados[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("quantidade", Dados[7]));                

                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS CADASTRADOS COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }



        //CADASTRANDO 
        public void Cadastro_Contato_acessorio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "insert into acessorio " +
                    "(" +
                        "tipo_animal, nome_acessorio, utilidade, peso, preco,validade, quantidade" +
                    ") " +
                    "values (?,?,?,?,?,?,?)";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("tipo_animal", Dados[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("nome_acessorio", Dados[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("utilidade", Dados[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("peso", Dados[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("preco", Dados[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("validade", Dados[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("quantidade", Dados[7]));

                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS CADASTRADOS COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }



        //CADASTRANDO   
        public void Cadastro_Contato_comida(String[] DadosComida)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "insert into comida " +
                    "(" +
                        "tipo_animal, nome_comida, utilidade, peso, preco, validade, quantidade" +
                    ") " +
                    "values (?,?,?,?,?,?,?)";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("tipo_animal", DadosComida[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("nome_comida", DadosComida[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("utilidade", DadosComida[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("peso", DadosComida[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("preco", DadosComida[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("validade", DadosComida[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("quantidade", DadosComida[7]));

                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS CADASTRADOS COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }



        //DELETAR UM CAMPO DA TABELA
        public void Delete_Contato_remedio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "delete from remedio where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));


                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show(" DADOS REMOVIDO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }


        //DELETAR UM CAMPO DA TABELA
        public void Delete_Contato_acessorio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "delete from acessorio where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));


                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show(" DADOS REMOVIDO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }


        //DELETAR UM CAMPO DA TABELA
        public void Delete_Contato_comida(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "delete from comida where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);


                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));


                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show(" DADOS REMOVIDO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }


        //ALTERAR UM CAMPO DA TABELA
        public void Alterar_Campos_remedio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "update remedio set tipo_animal = @tipo_animal, nome_remedio = @nome_remedio, utilidade = @utilidade, peso = @peso, " +
                                 "preco = @preco, validade = @validade, quantidade = @quantidade where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);

                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@tipo_animal", Dados[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@nome_remedio", Dados[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@utilidade", Dados[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@peso", Dados[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@preco", Dados[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@validade", Dados[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@quantidade", Dados[7]));
                


                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS ALTERADO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }



        //ALTERAR UM CAMPO DA TABELA
        public void Alterar_Campos_acessorio(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "update acessorio set tipo_animal = @tipo_animal, nome_acessorio = @nome_acessorio, utilidade = @utilidade, peso = @peso, " +
                                 "preco = @preco, validade = @validade, quantidade = @quantidade where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);

                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@tipo_animal", Dados[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@nome_acessorio", Dados[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@utilidade", Dados[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@peso", Dados[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@preco", Dados[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@validade", Dados[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@quantidade", Dados[7]));



                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS ALTERADO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }


        //ALTERAR UM CAMPO DA TABELA
        public void Alterar_Campos_comida(String[] Dados)
        {
            this.Abrir_Conexion();

            try
            {
                string comando = "update comida set tipo_animal = @tipo_animal, nome_comida = @nome_comida, utilidade = @utilidade, peso = @peso, " +
                                 "preco = @preco, validade = @validade, quantidade = @quantidade where id = @id";

                SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);

                SQLiteComando.Parameters.Add(new SQLiteParameter("@id", Dados[0]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@tipo_animal", Dados[1]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@nome_comida", Dados[2]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@utilidade", Dados[3]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@peso", Dados[4]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@preco", Dados[5]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@validade", Dados[6]));
                SQLiteComando.Parameters.Add(new SQLiteParameter("@quantidade", Dados[7]));



                int error = SQLiteComando.ExecuteNonQuery();


                if (error > 0)
                {
                    System.Windows.Forms.MessageBox.Show("DADOS ALTERADO COM SUCESSO !!!");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("ERRO NA BASE DE DADOS");
            }

            this.Desconectar();
        }




        //LETRAS EM CAIXA ALTA
        public string ToUpper(String text)
        {
            char[] textCharArr = text.ToCharArray();

            for (int i = 0; i < textCharArr.Length; i++)
            {
                char current = textCharArr[i];
                if (current >= 'a' && current <= 'z')
                {
                    int distance = current - 'a';
                    textCharArr[i] = (char)('A' + distance);
                }

            }

            return new string(textCharArr);
        }
    }
}
