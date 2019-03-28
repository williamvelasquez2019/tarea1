using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Multiplicacion
    {
        private double m1, m2, mm;

        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double Mm { get => mm; set => mm = value; }

        public Multiplicacion()
        {
            this.m1 = 0;
            this.m2 = 0;
        }

        public double Calcular()
        {
            mm = m1 * m2;
            return mm;
        }
    }
}
