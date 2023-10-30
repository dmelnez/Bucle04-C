using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bucle04.Servicios
{
    internal class CalculoImplentacion : CalculoInterfaz
    {
        public int calculoCase (int numeroUsu)
        {
            bool cerramenu = false;
            int opcionUsu;
            int i = numeroUsu;

            do
            {

                for (int b = 1; b <= i; ++b)
                {
                    
                    Console.WriteLine(i);
                }


                Console.WriteLine("------------------------------");
                Console.WriteLine("- [0] Salir de la Aplicacion -");
                Console.WriteLine("- [1] Continuar              -");
                Console.WriteLine("------------------------------");
                opcionUsu = Convert.ToInt32(Console.ReadLine());
                return opcionUsu;



            }

                while (!cerramenu);
                {
                    switch (opcionUsu)
                    {
                        case 0: 
                            Console.WriteLine("[INFO] - Cerrar Menu");
                            cerramenu = true;
                            break;
                         case 1:
                            Console.WriteLine("[INFO] - Continuar");
                           
                            break;
                    default:    
                            break;
                    }
                }


            return opcionUsu;
        }
    }
}
