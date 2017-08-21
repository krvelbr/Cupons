using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Cupons.Controller.BancoDados;


namespace Cupons.Controller
{
    public class Funcoes
    {
        AcessoBancoSql acessoBanco = new BancoDados.AcessoBancoSql();

        public string InserirLojista(Lojista lojista)
        {
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Cnpj", lojista._Cnpj);
                acessoBanco.AdicionarParametros("@Ie", lojista._IE);
                acessoBanco.AdicionarParametros("@Razao", lojista._Razao);
                acessoBanco.AdicionarParametros("@Fantasia", lojista._Fantasia);
                acessoBanco.AdicionarParametros("@Ativo", lojista._Ativo);

                string idLojista = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspLojistaInserir").ToString();
                return idLojista;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

    }
}








/*


        public class Funcoes
            {


                public static DataGridView CarregaLojistas(string cnpj)
                {
                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = null;

                    string cmd;
                    cmd = @"select id, CNPJLojista, FantasiaLojista, RazaoLojista, IELojista, Ativo from [Cupons].dbo.tblLojista";

                    if (cnpj != null)
                    {
                        cmd = cmd + " where CNPJLojista = '" + cnpj + "' ";  // se recebeu um cnpj busca especificamente por ele
                    }

                    dgv.DataSource = AbreBanco(cmd, "CONSULTA");   // envia o comando de busca ao banco


                    return dgv;   // definir o retorno
                }


                public static void InsereLojistas(DataTable lojista)
                {
                    DataGridView dgv = new DataGridView();
                    dgv.DataSource = lojista;

                    string cmd;
                    cmd = @"INSERT INTO [Cupons].dbo.tblLojista(CNPJLojista, IELojista, RazaoLojista, FantasiaLojista, Ativo) " +
                        "VALUES (@CNPJ, @IE, @Razao, @Fantasia, @Ativo)";

                    AbreBanco(cmd, "INSERE", dgv);

                }









                private static DataGridView AbreBanco(string comando, string tipotarefabanco, DataGridView dgvtemp = null)
                {
                    DataGridView dgvbanco = new DataGridView();
                    string _conn =
                        "Data Source = localhost\\HIPER;" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                        "Initial Catalog = Cupons;" +
                        "User ID = sa;" +
                        "Password = hiper";

                    SqlConnection sqlConn = new SqlConnection(_conn);
                    SqlCommand sqlCmd = new SqlCommand(comando, sqlConn);

                    try
                    {
                        if (tipotarefabanco == "CONSULTA")
                        {
                            sqlConn.Open();
                            SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlCmd);
                            DataTable dtLojista = new DataTable();
                            sqlAdaptador.Fill(dtLojista);
                            dgvbanco.DataSource = dtLojista;
                            return dgvbanco;
                        }
                        if (tipotarefabanco == "INSERE")
                        {
                            sqlConn.Open();
                            SqlCommand cmdInsere = sqlConn.CreateCommand();
                            cmdInsere.CommandText = comando;

                            cmdInsere.Parameters.AddWithValue("@CNPJ", dgvtemp.Rows[0].Cells[0].Value.ToString());
                            cmdInsere.Parameters.AddWithValue("@IE", dgvtemp.Rows[0].Cells[1].Value.ToString());
                            cmdInsere.Parameters.AddWithValue("@razao", dgvtemp.Rows[0].Cells[2].Value.ToString());
                            cmdInsere.Parameters.AddWithValue("@Fantasia", dgvtemp.Rows[0].Cells[3].Value.ToString());

                            if (Convert.ToInt16(dgvtemp.Rows[0].Cells[4].Value.ToString()) == 1)
                            {
                                cmdInsere.Parameters.AddWithValue("@Ativo", 1);
                            }
                            else
                            {
                                cmdInsere.Parameters.AddWithValue("@Ativo", 0);
                            }

                        }
                        MessageBox.Show("Dados Inseridos com Sucesso.", "Aviso");

                        return null;
                    }
                    catch (SqlException sqlerror)
                    {
                        MessageBox.Show("Erro ao Acessar o banco de Dados.\n" + sqlerror.Message, "Erro");
                        return null;
                    }
                    finally
                    {
                        sqlConn.Close();
                    }

                }



            }
        }
    }
}
*/
