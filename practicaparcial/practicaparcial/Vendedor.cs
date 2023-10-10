using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaparcial
{
    public abstract class Vendedor : IComparable
    {
        public int Codigo { get; private set; }
        public string Nombre { get; private set; }
        public double Ventas { get; protected set; }
        public Vendedor(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            Ventas = 0.00;
        }
        public abstract double Sueldo();
        public void AgregarVenta(double monto)
        {
            Ventas += monto;
        }
        public int CompareTo(object obj)
        {
            return this.Codigo.CompareTo(((Vendedor)obj).Codigo);
        }
    }
}
