using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Cliente
    {
        public Int32    _Id { get; set; }
        public string   _CPF { get; set; }
        public string   _RG { get; set; }
        public string   _Sexo { get; set; }
        public bool     _Ativo { get; set; }
        public string   _Nome { get; set; }
        public DateTime _Nascimento { get; set; }
        public string   _Endereco { get; set; }
        public string   _EndNumero { get; set; }
        public string   _EndComplemento { get; set; }
        public string   _Bairro { get; set; }
        public string   _Cidade { get; set; }
        public string   _UF { get; set; }
        public string   _CEP { get; set; }
        public string   _FoneFixo { get; set; }
        public string   _Celular1 { get; set; }
        public string   _Celular2 { get; set; }
        public string   _Celular3 { get; set; }
        public string   _Whatsapp { get; set; }
        public string   _Email { get; set; }
        public string   _Facebook { get; set; }
        public string   _Twitter { get; set; }
        public string   _Observacao { get; set; }
        public byte[]   _Foto { get; set; }
        public string   _CadastradoPor { get; set; }
        public string   _AlteradoPor { get; set; }


    }

    public class ClienteColecao : List<Cliente>
    {

    }
}
