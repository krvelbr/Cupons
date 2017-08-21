using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Lojista
    {
        public Int32 _Id { get; set; }
        public string _Cnpj { get; set; }
        public string _IE { get; set; }
        public string _Razao { get; set; }
        public string _Fantasia { get; set; }
        public Int32 _idRamoAtividade { get; set; }
        public bool _Ativo { get; set; }
    }

    public class LojistaColecao : List<Lojista>
    {

    }
}



/*
    DataGridView dgv = new DataGridView();
    static string comando;
    static string _conn =
                    "Data Source = localhost\\HIPER;" + // aqui deve ser colocado o campo com o local do servidor que deve vir da configuracao de parametros
                    "Initial Catalog = Cupons;" +
                    "User ID = sa;" +
                    "Password = hiper";

    static SqlConnection sqlConn = new SqlConnection(_conn);
    static SqlCommand sqlCmd = new SqlCommand(comando, sqlConn);



    public bool Salvar()
    {
    DataGridView dgv = new DataGridView();
    //dgv.DataSource = lojista;

    string cmd;
    cmd = @"INSERT INTO [Cupons].dbo.tblLojista(CNPJLojista, IELojista, RazaoLojista, FantasiaLojista, Ativo) " +
        "VALUES (@CNPJ, @IE, @Razao, @Fantasia, @Ativo)";

    //AbreBanco(cmd, "INSERE", dgv);


    return true;
    }

    public DataTable Consultar()
    {
        DataTable dt = new DataTable();
        //implementar
        return dt;
    }

}
}
*/
