using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_DMN_C.Servicios
{
    /// <summary>
    /// Metodo que solicita al usuario un mes y año
    /// <autor>07/11/2023 - DMN</autor>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        //Metodo que solicita al usuario un mes del Año
        public int pedirMes()
        {
            Console.WriteLine("Indique un Mes del Año: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        //Metodo que solicita al usuario un Año
        public int pedirAño()
        {
            Console.WriteLine("Indique un Año: ");
            int año = Convert.ToInt32(Console.ReadLine());
            return año;
        }
    }
}
