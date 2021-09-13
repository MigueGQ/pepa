using Melano.Entidades;
using Melano.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melano
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsMelano clsmelano = new ClsMelano();
            NClsMelano nclsmelano = new NClsMelano();

            Console.WriteLine("Hey dundo, escriba el monto sinó me lo monto");
            clsmelano.Monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Elija el día, dundo");
            Console.WriteLine("1) Lunes, 2) Martes, 3) Miercoles, 4) Jueves, 5) Viernes, 6) Sabado, 7)Suqlo");
            clsmelano.Dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nclsmelano.Calc(clsmelano.Dia, clsmelano.Monto));
            Console.ReadLine();
        }
    }
}
