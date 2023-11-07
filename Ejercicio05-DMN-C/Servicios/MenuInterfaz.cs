using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_DMN_C.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabecera de los metodos que solicitan un mes y año al usuario
    /// <autor>07/11/2023 - DMN</autor>
    /// </summary>
    internal interface MenuInterfaz
    {
        public int pedirMes();
        public int pedirAño();
    }
}

