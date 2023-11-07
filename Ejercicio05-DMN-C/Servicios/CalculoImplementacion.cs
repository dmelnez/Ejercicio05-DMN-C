using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_DMN_C.Servicios
{
    internal class CalculoImplementacion : CalculoInterfaz
    {
        /// <summary>
        /// Metodo el cual comprueba si el año introducido por el usuario es Bisiesto o no
        /// <autor>07/11/2023 - DMN</autor>
        /// </summary>

        public bool calculoBisiesto(int anioIntro)
        {
            bool bisiesto = true;
           
            if ((anioIntro % 4 == 0 && anioIntro % 100 != 0) || anioIntro % 400 == 0)
            {
                Console.WriteLine("Es un Año Bisiesto");
            }
            else
            {
                Console.WriteLine("No es un Año Bisiesto");
                bisiesto = false;
            }

            return bisiesto;

        }
    }

}
