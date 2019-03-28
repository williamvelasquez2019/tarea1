using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
   public class Division
    {
      private  double d1, d2, dr;

        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double Dr { get => dr; set => dr = value; }
        public Division()
        {
            this.d1 = 0;
            this.d2 = 0;
        }

        public double Calcular()
        {
            dr = d1 / d2;
            return dr;
        }
    }
}
