using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle04.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int solNum()
        {
            Console.WriteLine("Introduzca un Valor de Tipo INT");
            int valorInt = Convert.ToInt32(Console.ReadLine());
            return valorInt;
        }
    }
}
