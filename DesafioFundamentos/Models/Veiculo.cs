using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public Veiculo()
        {
            
        }

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public string Placa { get; set; }
    }
}