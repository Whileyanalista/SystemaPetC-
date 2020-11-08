using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemaPet
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CODIGO PARA CRIAR UMA PASTA NO WIN CHAMADO "BD_SystemaPT" PARA A BASE DE DADOS DO SISTEMA 
            if (Directory.Exists("c:\\BD_SystemaPT") == false)
            {
                //CRIAR PASTA DO DIREITORIO C:
                Directory.CreateDirectory("C:\\BD_SystemaPT");
            }

            if (File.Exists("C:\\BD_SystemaPT\\BD_SystemaPT.s3db") == false)
            {
                //CRIAR BANCO DE DADOS NO DIREITORIO C:
                new SQLite().Crear_Base_Dados();
                System.Windows.Forms.MessageBox.Show(" BASE DE DADOS CRIADA  !!!\n Local:C: PASTA (BD_SystemaPT) \n PARA SUA SEGURANÇA  " +
                    "FAVOR SALVAR ESTE ARQUIVO EM UM LOCAL SEGURO \n NO FINAL DE CADA DIA.");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(" OBS: FAVOR ARMAZENAR BASE DE DADOS EM LOCAL SEGURO!!!\n Local:C: PASTA (BD_SystemaPT) ");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTelaSplash());
        }
    }
}
