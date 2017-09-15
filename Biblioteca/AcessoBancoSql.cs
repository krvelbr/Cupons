using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Biblioteca
{

    public class AcessoBancoSql
    {

        //criar conexao
        private SqlConnection CriarConexao()
        {
            string conexao = null;
            //string _conn =
            //    "Data Source = localhost\\SQL2014;" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
            //    "Initial Catalog = Cupons;" +
            //    "User ID = sa;" +
            //    "Password = solution";
            try
            {
                if (File.Exists("configCupons.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    FileStream read = new FileStream("configCupons.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Config info = (Config)xs.Deserialize(read);
                    conexao = String.Format(
                "Data Source = {0},{1}\\{3};" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                "Initial Catalog = {2};" +
                "User ID = {4};" +
                "Password = {5}", info.serverName, info.serverPort, info.dataBase, info.serverInstance, info.userName, info.passWord);
                    read.Close();
                }
                
                SqlConnection _conn = new SqlConnection(conexao);
                //_conn.ConnectionTimeout.Equals(50);
                _conn.Open();
                if (_conn.State == ConnectionState.Closed)
                {
                    conexao = null;
                }

                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            catch (Exception ex)
            {
                conexao = null;
                /*
                Config info = new Config();
                info.serverName = "LocalHost";
                info.serverPort = "5010";
                info.dataBase = "Cupons";
                info.serverInstance = "sqlexpress";
                info.userName = "sa";
                info.passWord = "solution";
                SaveXML.SaveData(info, "configCupons.xml");

                conexao = String.Format(
                "Data Source = {0},{1}\\{3};" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                "Initial Catalog = {2};" +
                "User ID = {4};" +
                "Password = {5}", info.serverName, info.serverPort, info.dataBase, info.serverInstance, info.userName, info.passWord);
                */
            }       
            return new SqlConnection(conexao);
        }



        //parametros que vao para o banco
        // recebe uma colecao de parametros
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()   // sempre usar para limpar os parametros antes de adicionar.
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }


        //metodos para persistencia dos dados abaixo, incluir, alterar
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public object ExecutarManipulacao(CommandType comandoTipo, string nomedaProcedureouTexto)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar o comando que vai levar a informacao ao banco
                SqlCommand sqlComando = sqlConnection.CreateCommand();  //criou um comando vazio pra por as coisas dentro depois
                                                                        //vamos configurar a conexao do comando.
                sqlComando.CommandType = comandoTipo;                 //CommandType.StoredProcedure; recebe o parametro que eu enviei na funcao
                sqlComando.CommandText = nomedaProcedureouTexto;     // recebe o nome da procedure ou o texto que enviei na funcao
                sqlComando.CommandTimeout = 500;                    // tempo para expirar... sao 500 segundos... se for algo tipo um relatorio muito grande... pode aumentar se nao conseguir trazer o que queria

                //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)   // vai percorrer a colecao e para cada parametro vai fazer algo abaixo
                {
                    sqlComando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //executa o comando, manda ir ao banco
                return sqlComando.ExecuteScalar();   // executa a query e retorna a primeira coluna e primeira linha (vai trazer o retorno da procedure com o ID do registro)
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);  //esse throw nao deixa explodir aqui... explode la onde foi chamado pela funcao
            }
        }

        //consultar registros
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public DataTable ExecutarConsulta(CommandType comandoTipo, string nomedaProcedureouTexto)
        {

            try
            {
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar o comando que vai levar a informacao ao banco
                SqlCommand sqlComando = sqlConnection.CreateCommand(); //criou um comando vazio pra por as coisas dentro depois
                                                                       //vamos configurar a conexao do comando.
                sqlComando.CommandType = comandoTipo;   //CommandType.StoredProcedure; recebe o parametro que eu enviei na funcao
                sqlComando.CommandText = nomedaProcedureouTexto;  // recebe o nome da procedure ou o texto que enviei na funcao
                sqlComando.CommandTimeout = 500;  // tempo para expirar... sao 500 segundos... se for algo tipo um relatorio muito grande... pode aumentar se nao conseguir trazer o que queria

                //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)   // vai percorrer a colecao e para cada parametro vai fazer algo abaixo
                {
                    sqlComando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //criar um adaptador do tipo DATATABLE preenche o datatable e retorna com o conteudo
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComando);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);  //esse throw nao deixa explodir aqui... explode la onde foi chamado pela funcao
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public DataTable ConsultaRamos(CommandType comandoTipo, string nomedaProcedureouTexto)
        {

            try
            {
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //criar o comando que vai levar a informacao ao banco
                SqlCommand sqlComando = sqlConnection.CreateCommand(); //criou um comando vazio pra por as coisas dentro depois
                                                                       //vamos configurar a conexao do comando.
                sqlComando.CommandType = comandoTipo;   //CommandType.StoredProcedure; recebe o parametro que eu enviei na funcao
                sqlComando.CommandText = nomedaProcedureouTexto;  // recebe o nome da procedure ou o texto que enviei na funcao
                sqlComando.CommandTimeout = 500;  // tempo para expirar... sao 500 segundos... se for algo tipo um relatorio muito grande... pode aumentar se nao conseguir trazer o que queria

                //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)   // vai percorrer a colecao e para cada parametro vai fazer algo abaixo
                {
                    sqlComando.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //criar um adaptador do tipo DATATABLE preenche o datatable e retorna com o conteudo
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlComando);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);  //esse throw nao deixa explodir aqui... explode la onde foi chamado pela funcao
            }
        }


        public String ExecutaProcedure(CommandType comandoTipo, string nomedaProcedureouTexto)
        {

            try
            {
                using (SqlConnection sqlConnection = CriarConexao())
                {
                    string infoMessageText = "";

                    //abrir conexao
                    sqlConnection.Open();
                    //criar o comando que vai levar a informacao ao banco
                    SqlCommand sqlComando = sqlConnection.CreateCommand(); //criou um comando vazio pra por as coisas dentro depois
                                                                           //vamos configurar a conexao do comando.
                    sqlComando.CommandType = comandoTipo;   //CommandType.StoredProcedure; recebe o parametro que eu enviei na funcao
                    sqlComando.CommandText = nomedaProcedureouTexto;  // recebe o nome da procedure ou o texto que enviei na funcao
                    sqlComando.CommandTimeout = 500;  // tempo para expirar... sao 500 segundos... se for algo tipo um relatorio muito grande... pode aumentar se nao conseguir trazer o que queria

                    SqlParameter text = new SqlParameter("@ReturnMessage", SqlDbType.NVarChar, 1000);
                    text.Direction = ParameterDirection.ReturnValue;
                    sqlComando.Parameters.Add(text);

                    sqlConnection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
                    {
                        infoMessageText += e.Message.ToString();
                    };
                    using (DataTable dt = new DataTable())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlComando))
                        {
                            da.Fill(dt);
                        }
                    }

                    return infoMessageText.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);  //esse throw nao deixa explodir aqui... explode la onde foi chamado pela funcao
            }

        }

        public class SaveXML
        {
            public static void SaveData(object obj, string filename)
            {
                XmlSerializer sr = new XmlSerializer(obj.GetType());
                TextWriter writer = new StreamWriter(filename);
                sr.Serialize(writer, obj);
                writer.Close();
            }
        }

        public class Config
        {
            public string serverName { get; set; }
            public string serverPort { get; set; }
            public string serverInstance { get; set; }
            public string dataBase { get; set; }
            public string userName { get; set; }
            public string passWord { get; set; }

        }
    }
}






