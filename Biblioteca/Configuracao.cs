using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Configuracao
    {
        public int    _ValorCupom   { get; set; }
        public string _Licenca      { get; set; }

        public string _IP           { get; set; }
        public string _Instancia    { get; set; }
        public string _Banco        { get; set; }
        public string _Usuario      { get; set; }
        public string _Senha        { get; set; }
        public List<Tuple<int, string>> _Ramos { get; set; }

    }

}