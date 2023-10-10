using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaparcial
{
    public class Mostrador : Vendedor
    {
        private double basico;
        public Mostrador(string nombre, int codigo, double basico = 1000) : base(codigo, nombre)
        {
            this.basico = basico;
        }
        public override double Sueldo()
        {
            basico += (Ventas * 0.05);
            return basico;
        }

    }
}
