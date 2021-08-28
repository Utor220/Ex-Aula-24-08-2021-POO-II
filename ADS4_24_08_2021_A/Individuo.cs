using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS4_24_08_2021_A
{
    class Individuo
    {
        public string Apelido;
        private double Idade;
        public double Salário { get; set; }

        public Individuo()
        {
            Apelido = "Juca";
            Idade = 22;
            Salário = 1387.64;
        }

        public Individuo(string Apelido, double Idade, double Salário)
        {
            this.Apelido = Apelido;
            this.Idade = Idade;
            this.Salário = Salário;
        }

        public double GetIdade()
        {
            return Idade;
        }

        public void SetIdade(double Idade)
        {
            this.Idade = Idade;
        }
    }
}
