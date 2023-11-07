using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_DMN_C.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabecera del metodo que calcula si el año es bisiesto
    /// <autor>07/11/2023 - DMN</autor>
    /// </summary>
    internal interface CalculoInterfaz
    {
        public bool calculoBisiesto(int anioIntro);

    }
}
