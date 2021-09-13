using Melano.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melano.Negocio
{
    class NClsMelano
    {
        public String Calc(int dia, double monto)
        {
            if (dia == 2 || dia == 4)
            {
                Console.WriteLine("Hoy aplica un descuento de 15% así que no sea dundo");
                double total = monto - (monto * 0.15);
                return "Su total a pagar es de: " + total;
            }

            else
                return "No tiene descuento hoy pasmado, deberá pagar: " + monto;
        }
    }
}
