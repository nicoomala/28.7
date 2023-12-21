using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    enum Tipo
    {
        singola,
        doppia
    }
    internal class Stanza
    {
        int Numero {  get; set; }
        string Descrizione { get; set; }

        Tipo Tipo { get; set; }

    }
}
