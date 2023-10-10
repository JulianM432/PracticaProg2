using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaparcial
{
    public class Empresa
    {
        List<Vendedor> vendedores = new List<Vendedor>();
        public void AgregarVenta(double monto, int codigo)
        {
            Vendedor unVendedor = BuscarVendedor(codigo);
            if (unVendedor != null)
            {
                unVendedor.AgregarVenta(monto);
            }
        }
        public void AgregarVendedor(Vendedor v)
        {
            vendedores.Add(v);
        }
        public double VerSueldo(int codigo)
        {
            double sueldo = 0;
            Vendedor unVendedor = BuscarVendedor(codigo);
            if(unVendedor != null)
            {
                sueldo = unVendedor.Sueldo();
            }
            return sueldo;
            /*Vendedor unVendedor = null;
            int i= 0;
            do
            {
                if (vendedores[i].Codigo == codigo)
                {
                    unVendedor = vendedores[i];
                }
                i++;
            } while ((i < vendedores.Count) && (unVendedor == null));
            return unVendedor.Sueldo();*/
        }
        public Vendedor BuscarVendedor(int c)
        {
            Vendedor aBuscar = new Mostrador("",c);
            vendedores.Sort();
            int i = vendedores.BinarySearch(aBuscar);
            if(i >=0)
            {
                aBuscar = vendedores[i];
            }
            else
            {
                aBuscar = null;
            }
            return aBuscar;
        }
        /*public double[,] Sueldos()
        {

        }*/
    }
}
