using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaparcial
{
    internal class Temporal : Vendedor
    {
        public Temporal(string nombre, int codigo) : base(codigo, nombre)
        {

        }
        public override double Sueldo()
        {
            double monto = Ventas;
            if (Ventas <= 1000000)
            {
                monto *= 0.15;
            }
            else monto *= 0.20;
            return monto;
        }
    }
}
