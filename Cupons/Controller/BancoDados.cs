using System;
using System.Data;
using System.Data.SqlClient;


namespace Cupons.Controller
{
    public class BancoDados
    {
        public class AcessoBancoSql
        {
//            AcessoBancoSql acessoBanco = new AcessoBancoSql();

            //criar conexao
            private SqlConnection CriarConexao()
            {
                string _conn =
                    "Data Source = localhost\\HIPER;" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                    "Initial Catalog = Cupons;" +
                    "User ID = sa;" +
                    "Password = hiper";
                return new SqlConnection(_conn);
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

        }
    }
}