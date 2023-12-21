using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Prenotazione
    {
        Cliente cliente {  get; set; }
        Stanza stanza { get; set; } 
        DateTime checkin {  get; set; }
        DateTime checkout { get; set; }
        int numeroprenotazione {  get; set; }
        float caparra {  get; set; }
        float prezzoNotte { get; set; }

        List<Servizio> servizi {  get; set; }

    }
}
