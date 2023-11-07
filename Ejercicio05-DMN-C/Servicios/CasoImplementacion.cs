using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_DMN_C.Servicios
{
    internal class CasoImplementacion : CasoInterfaz
    {
        /// <summary>
        /// Menu el cual indica al usuario si desea continuar, debe introducir una s
        /// <autor>07/11/2023 - DMN</autor>
        /// </summary>
        public string Caso()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("- ¿Desea Continuar? -");
            Console.WriteLine("- S = SI            -");
            Console.WriteLine("---------------------");
            string continua = Console.ReadLine();
            return continua;

        }

    }
}

