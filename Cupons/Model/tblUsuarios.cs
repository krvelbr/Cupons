//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cupons.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUsuarios
    {
        public long id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Celular { get; set; }
        public string Whatsapp { get; set; }
        public bool Ativo { get; set; }
        public string CadastradoPor { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public string AlteradoPor { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
    }
}