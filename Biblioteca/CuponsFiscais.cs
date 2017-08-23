using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CuponsFiscais
    {
        public Int32 _id { get; set; }
        public Int32 _idLojista { get; set; }
        public Int32 _idCliente { get; set; }
        public Int32 _COO { get; set; }
        public DateTime _DataCupomCOO { get; set; }
        public decimal _ValorCompraCOO { get; set; }
        public string _CadastradoPor { get; set; }
        public DateTime _DataCadastro { get; set; }
        public string _NSURede { get; set; }

    }

    public class CuponsFiscaisColecao : List<CuponsFiscais>
    {

    }
}