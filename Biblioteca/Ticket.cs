using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tickets
    {
        public Int32 _noTicket { get; set; }
        public Int32 _idCliente { get; set; }
        public DateTime _DataHoraImpressao { get; set; }
        public string _GeradoPor { get; set; }
        public bool _Impresso { get; set; }
    }

    public class TicketsColecao : List<Tickets>
    {

    }
}