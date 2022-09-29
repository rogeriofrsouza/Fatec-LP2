using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado  // especialização => herança
    {
        public double SalarioMensal { get; set; }  // propriedade

        // sobrescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
