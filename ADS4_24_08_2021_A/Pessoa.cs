using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_24_08_2021_A
{
    class Pessoa
    {
        public string Nome;
        private double CPF;
        public int RA { get; set; }

        public Pessoa()
        {
            Nome = "NADA";
            CPF = 4;
            RA = 3;
        }

        public Pessoa(string Nome)
        {
            this.Nome = Nome;
            CPF = 1;
            RA = 2;
        }
        public double GetCPF()
        {
            return CPF;
        }
        public void SetCPF(double CPF)
        {
            this.CPF = CPF;
        }
    }
}
