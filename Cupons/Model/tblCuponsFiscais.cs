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
    
    public partial class tblCuponsFiscais
    {
        public long idCupom { get; set; }
        public long idLojista { get; set; }
        public long idCliente { get; set; }
        public long COO { get; set; }
        public System.DateTime DataCupomCOO { get; set; }
        public Nullable<decimal> ValorCompraCOO { get; set; }
        public string CadastradoPor { get; set; }
        public System.DateTime DataCadastro { get; set; }
    }
}