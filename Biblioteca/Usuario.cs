using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Usuario
    {
        public Int32 _Id { get; set; }
        public string _Usuario { get; set; }
        public string _Senha { get; set; }
        public bool _Ativo { get; set; }
        public string _Nome { get; set; }
        public string _Endereco { get; set; }
        public string _EndNumero { get; set; }
        public string _EndComplemento { get; set; }
        public string _Bairro { get; set; }
        public string _Cidade { get; set; }
        public string _UF { get; set; }
        public string _CEP { get; set; }
        public string _Celular { get; set; }
        public string _Whatsapp { get; set; }
        public string _CadastradoPor { get; set; }
        public string _AlteradoPor { get; set; }

    }

    public class UsuarioColecao : List<Usuario>
    {

    }
}
