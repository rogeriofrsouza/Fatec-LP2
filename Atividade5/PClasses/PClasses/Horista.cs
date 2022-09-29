using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado  // não pode herdar mais de uma classe, não existe herança múltipla
    {
        // pro e 2x tab a estrutura da propriedade
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        // override indica sobrescrever
        public override int TempoTrabalho()
        {
            // o método retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
