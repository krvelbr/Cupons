//SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
using System;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows;
using Biblioteca;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Funcoes
{
    public class Banco
    {

        public string InserirLojista(Lojista lojista)
        {
            
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Cnpj", lojista._Cnpj);
                acessoBanco.AdicionarParametros("@Ie", lojista._IE);
                acessoBanco.AdicionarParametros("@Razao", lojista._Razao);
                acessoBanco.AdicionarParametros("@Fantasia", lojista._Fantasia);
                acessoBanco.AdicionarParametros("@idRamoAtividade", lojista._idRamoAtividade);
                acessoBanco.AdicionarParametros("@Ativo", lojista._Ativo);

                string idLojista = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspLojistaInserir").ToString();
                return idLojista;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string InserirCliente(Cliente cliente)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@CPF", cliente._CPF);
                acessoBanco.AdicionarParametros("@RG", cliente._RG);
                acessoBanco.AdicionarParametros("@Nome", cliente._Nome);
                acessoBanco.AdicionarParametros("@Nascimento", cliente._Nascimento);
                acessoBanco.AdicionarParametros("@Sexo", cliente._Sexo);
                acessoBanco.AdicionarParametros("@Ativo", cliente._Ativo);
                acessoBanco.AdicionarParametros("@Endereco", cliente._Endereco);
                acessoBanco.AdicionarParametros("@EnderecoNumero", cliente._EndNumero);
                acessoBanco.AdicionarParametros("@EnderecoComplemento", cliente._EndComplemento);
                acessoBanco.AdicionarParametros("@Bairro", cliente._Bairro);
                acessoBanco.AdicionarParametros("@Cidade", cliente._Cidade);
                acessoBanco.AdicionarParametros("@Estado", cliente._UF);
                acessoBanco.AdicionarParametros("@CEP", cliente._CEP);
                acessoBanco.AdicionarParametros("@FoneFixo", cliente._FoneFixo);
                acessoBanco.AdicionarParametros("@FoneCelular1", cliente._Celular1);
                acessoBanco.AdicionarParametros("@FoneCelular2", cliente._Celular2);
                acessoBanco.AdicionarParametros("@FoneCelular3", cliente._Celular3);
                acessoBanco.AdicionarParametros("@Whatsapp", cliente._Whatsapp);
                acessoBanco.AdicionarParametros("@Email", cliente._Email);
                acessoBanco.AdicionarParametros("@Facebook", cliente._Facebook);
                acessoBanco.AdicionarParametros("@Twitter", cliente._Twitter);
                acessoBanco.AdicionarParametros("@Observacao", cliente._Observacao);
                //acessoBanco.AdicionarParametros("@Foto", cliente._Foto);
                acessoBanco.AdicionarParametros("@CadastradoPor", cliente._CadastradoPor);


                string idCliente = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return idCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public DataTable ConsultaLojista(string cnpjLojista)
        {
            DataTable dtRetorno = new DataTable();
            string cnpj = "";
            cnpj = cnpjLojista;
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cnpj", cnpj);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspLojistaConsultarCNPJ");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaCliente(string cpfCliente)
        {
            DataTable dtRetorno = new DataTable();
            string cpf = "";
            cpf = cpfCliente;
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cpf", cpf);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarCPF");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Backup()
        {
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@ReturnMessage", SqlDbType.NVarChar);
                string Retorno = acesso.ExecutaProcedure(CommandType.StoredProcedure, "BackupBanco").ToString();

                return Retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable LoginUser(string nomeusuario)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@usuario", nomeusuario);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioLogin");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaTodosUsuarios()
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                //acesso.AdicionarParametros("@usuario", nomeusuario);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuariosConsultarTodos");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaUsuarioUnico(string nomeusuario)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@usuario", nomeusuario);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultarUnico");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string InserirUsuario(Usuario usuario)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Usuario", usuario._Usuario);
                acessoBanco.AdicionarParametros("@Senha", usuario._Senha);
                acessoBanco.AdicionarParametros("@Ativo", usuario._Ativo);
                acessoBanco.AdicionarParametros("@Nome", usuario._Nome);
                acessoBanco.AdicionarParametros("@Endereco", usuario._Endereco);
                acessoBanco.AdicionarParametros("@EnderecoNumero", usuario._EndNumero);
                acessoBanco.AdicionarParametros("@EnderecoComplemento", usuario._EndComplemento);
                acessoBanco.AdicionarParametros("@Bairro", usuario._Bairro);
                acessoBanco.AdicionarParametros("@Cidade", usuario._Cidade);
                acessoBanco.AdicionarParametros("@Estado", usuario._UF);
                acessoBanco.AdicionarParametros("@CEP", usuario._CEP);
                acessoBanco.AdicionarParametros("@Celular", usuario._Celular);
                acessoBanco.AdicionarParametros("@Whatsapp", usuario._Whatsapp);
                acessoBanco.AdicionarParametros("@CadastradoPor", usuario._CadastradoPor);


                string idUsuario = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioInserir").ToString();
                return idUsuario;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string UpdateUsuario(Usuario usuario)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Usuario", usuario._Usuario);
                acessoBanco.AdicionarParametros("@Senha", usuario._Senha);
                acessoBanco.AdicionarParametros("@Nome", usuario._Nome);
                acessoBanco.AdicionarParametros("@Endereco", usuario._Endereco);
                acessoBanco.AdicionarParametros("@EnderecoNumero", usuario._EndNumero);
                acessoBanco.AdicionarParametros("@EnderecoComplemento", usuario._EndComplemento);
                acessoBanco.AdicionarParametros("@Bairro", usuario._Bairro);
                acessoBanco.AdicionarParametros("@Cidade", usuario._Cidade);
                acessoBanco.AdicionarParametros("@Estado", usuario._UF);
                acessoBanco.AdicionarParametros("@CEP", usuario._CEP);
                acessoBanco.AdicionarParametros("@Celular", usuario._Celular);
                acessoBanco.AdicionarParametros("@Whatsapp", usuario._Whatsapp);
                acessoBanco.AdicionarParametros("@AlteradoPor", usuario._AlteradoPor);
                acessoBanco.AdicionarParametros("@Ativo", usuario._Ativo);

                // criar stored procedure no sql para update cliente
                string idCliente = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioUpdate").ToString();
                return idCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public DataTable ConsultaConfig(CommandType tipo, String comando)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                //acesso.LimparParametros();
                //acesso.AdicionarParametros("@usuario", nomeusuario);
                dtRetorno = acesso.ExecutarConsulta(tipo, comando);  //recebe um comando em texto para executar

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string UpdateLojista(Lojista lojista)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Cnpj", lojista._Cnpj);
                acessoBanco.AdicionarParametros("@Ie", lojista._IE);
                acessoBanco.AdicionarParametros("@Razao", lojista._Razao);
                acessoBanco.AdicionarParametros("@Fantasia", lojista._Fantasia);
                acessoBanco.AdicionarParametros("@idRamoAtividade", lojista._idRamoAtividade);
                acessoBanco.AdicionarParametros("@Ativo", lojista._Ativo);

                string idLojista = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspLojistaUpdate").ToString();
                return idLojista;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public static string GeraSenha(string _login, string _senha)
        {
            StringBuilder senha = new StringBuilder();

            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(_login + "//" + _senha);
            byte[] hash = md5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                senha.Append(hash[i].ToString("X2"));  //o x2 formata para sair em formato Hexa de 2 caracteres
            }
            return senha.ToString();
        }

        public string UpdateCliente(Cliente cliente)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@CPF", cliente._CPF);
                acessoBanco.AdicionarParametros("@RG", cliente._RG);
                acessoBanco.AdicionarParametros("@Nome", cliente._Nome);
                acessoBanco.AdicionarParametros("@Nascimento", cliente._Nascimento);
                acessoBanco.AdicionarParametros("@Sexo", cliente._Sexo);
                acessoBanco.AdicionarParametros("@Ativo", cliente._Ativo);
                acessoBanco.AdicionarParametros("@Endereco", cliente._Endereco);
                acessoBanco.AdicionarParametros("@EnderecoNumero", cliente._EndNumero);
                acessoBanco.AdicionarParametros("@EnderecoComplemento", cliente._EndComplemento);
                acessoBanco.AdicionarParametros("@Bairro", cliente._Bairro);
                acessoBanco.AdicionarParametros("@Cidade", cliente._Cidade);
                acessoBanco.AdicionarParametros("@Estado", cliente._UF);
                acessoBanco.AdicionarParametros("@CEP", cliente._CEP);
                acessoBanco.AdicionarParametros("@FoneFixo", cliente._FoneFixo);
                acessoBanco.AdicionarParametros("@FoneCelular1", cliente._Celular1);
                acessoBanco.AdicionarParametros("@FoneCelular2", cliente._Celular2);
                acessoBanco.AdicionarParametros("@FoneCelular3", cliente._Celular3);
                acessoBanco.AdicionarParametros("@Whatsapp", cliente._Whatsapp);
                acessoBanco.AdicionarParametros("@Email", cliente._Email);
                acessoBanco.AdicionarParametros("@Facebook", cliente._Facebook);
                acessoBanco.AdicionarParametros("@Twitter", cliente._Twitter);
                acessoBanco.AdicionarParametros("@Observacao", cliente._Observacao);
                //acessoBanco.AdicionarParametros("@Foto", cliente._Foto);
                acessoBanco.AdicionarParametros("@AlteradoPor", cliente._AlteradoPor);


                string idCliente = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteUpdateCPF").ToString();
                return idCliente;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string ConvertCommandParamatersToLiteralValues(SqlCommand cmd)
        {
            System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();
            info.NumberDecimalSeparator = ",";
            info.NumberGroupSeparator = ".";


            string query = cmd.CommandText;
            foreach (SqlParameter prm in cmd.Parameters)
            {
                switch (prm.SqlDbType)
                {
                    case SqlDbType.Bit:
                        int boolToInt = (bool)prm.Value ? 1 : 0;
                        query = query.Replace(prm.ParameterName, string.Format("{0}", (bool)prm.Value ? 1 : 0));
                        break;
                    case SqlDbType.Int:
                        query = query.Replace(prm.ParameterName, string.Format("{0}", prm.Value));
                        break;
                    case SqlDbType.VarChar:
                        query = query.Replace(prm.ParameterName, string.Format("'{0}'", prm.Value));
                        break;
                    default:
                        query = query.Replace(prm.ParameterName, string.Format("'{0}'", prm.Value));
                        break;
                }
            }
            return query;
        }

        public string InserirCupom(CuponsFiscais CupomF)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@idLojista", CupomF._idLojista);
                acessoBanco.AdicionarParametros("@idCliente", CupomF._idCliente);
                acessoBanco.AdicionarParametros("@COO", CupomF._COO);
                acessoBanco.AdicionarParametros("@DataCupomCOO", CupomF._DataCupomCOO);
                acessoBanco.AdicionarParametros("@ValorCompraCOO", CupomF._ValorCompraCOO);
                acessoBanco.AdicionarParametros("@CadastradorPor", CupomF._CadastradoPor);
                acessoBanco.AdicionarParametros("@NSURede", CupomF._NSURede);

                string idcupom = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspCupomFiscalInserir").ToString();
                return idcupom;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public DataTable ConsultaCuponsFiscaisCliente(Int32 idCliente)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@idCliente", idCliente);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspCupomFiscalConsultarCliente");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string InserirTicketImpresso(Tickets tickets)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@idCliente", tickets._idCliente);
                acessoBanco.AdicionarParametros("@Impresso", tickets._Impresso);
                acessoBanco.AdicionarParametros("@GeradoPor", tickets._GeradoPor);

                string idticket = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspCupomImpressoInserir").ToString();
                return idticket;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string ReimprimeTicket(Tickets tickets)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@noCupom", tickets._noTicket);
                acessoBanco.AdicionarParametros("@idCliente", tickets._idCliente);
                acessoBanco.AdicionarParametros("@Acao", tickets._Acao);
                acessoBanco.AdicionarParametros("@AcaoPor", tickets._ReimpressoPor);

                string idticket = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspLogAcao").ToString();
                return idticket;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string ExcluirCupom(Tickets tickets)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@noCupom", tickets._noTicket);
                acessoBanco.AdicionarParametros("@idCliente", tickets._idCliente);
                acessoBanco.AdicionarParametros("@Acao", tickets._Acao);
                acessoBanco.AdicionarParametros("@AcaoPor", tickets._ReimpressoPor);


                string idticket = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspLogAcao").ToString();
                return idticket;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }





        /*
        public DataTable ConsultaCuponsFiscaisImpressosQtde(Int32 idCliente)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@idCliente", idCliente);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspCupomImpressoConsultar");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

            ------------- pode excluir... repetida da de baixo.
        */
        public DataTable ConsultaTickets(Int32 idCliente)
        {
            DataTable dtRetorno = new DataTable();

            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@idCliente", idCliente);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspCupomImpressoConsultar");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable VendasLojista(string cnpjLojista)
        {
            DataTable dtRetorno = new DataTable();
            string cnpj = "";
            cnpj = cnpjLojista;
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cnpj", cnpj);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVendas");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable ConsultaCuponsCPF(string cpf)
        {
            DataTable dtRetorno = new DataTable();
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cpf", cpf);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCuponsCPF");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExtratoCuponsCPF(string cpf)
        {
            DataTable dtRetorno = new DataTable();
            try
            {
                AcessoBancoSql acesso = new AcessoBancoSql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@Cpf", cpf);
                dtRetorno = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspExtratoCupons");

                return dtRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public string InserirRamo(string ramo, string cadastrado)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Atividade", ramo);
                acessoBanco.AdicionarParametros("@CadastradoPor", cadastrado);

                string idRamo = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspRamosInserir").ToString();
                return idRamo;
            }
            catch (Exception ex)
            {
                return ex.Message;    // se der algum erro, vai aparecer a string de erro aqui, e vai ser devolvido ao inves do id do lojista.
            }
        }

        public string AlterarRamo(Int32 codigo, string ramo, string alterado)
        {
            AcessoBancoSql acessoBanco = new AcessoBancoSql();
            try
            {
                acessoBanco.LimparParametros();
                acessoBanco.AdicionarParametros("@Codigo", codigo);
                acessoBanco.AdicionarParametros("@Atividade", ramo);
                acessoBanco.AdicionarParametros("@AlteradoPor", alterado);

                string idRamo = acessoBanco.ExecutarManipulacao(CommandType.StoredProcedure, "uspRamosAlterar").ToString();
                return idRamo;
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
