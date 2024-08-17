using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {

        public string NumeroDaPlaca { get; set; }


        public Veiculo(string numeroDaPlaca)
        {
            NumeroDaPlaca = numeroDaPlaca;
        }

    }
}