namespace Ejercicio05_DMN_C.Servicios;

/// <summary>
/// Clase Principal por la cual el programa se Inicia
/// <autor>07/11/2023 - DMN</autor>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo por el cual solicita al usuario un Mes y Año, por el cual calcula si es bisiesto y el numero de dias en funcion al mes.
    /// <autor>07/11/2023 - DMN</autor>
    /// </summary>

    public static void Main(String[] args)
    {



        MenuInterfaz mi = new MenuImplementacion();
        CalculoInterfaz mi1 = new CalculoImplementacion();
        CasoInterfaz mi2 = new CasoImplementacion();


        bool cerrarMenu = false;
        

        while (!cerrarMenu)
        {
            int mesIntro = mi.pedirMes();          
            int anioIntro = mi.pedirAño();
            bool bisiesto = mi1.calculoBisiesto(anioIntro);


            if (bisiesto)
            {
                if (mesIntro == 1 || mesIntro == 3 || mesIntro == 5 || mesIntro == 7 || mesIntro == 8 || mesIntro == 10 || mesIntro == 12)
                {
                    Console.WriteLine("31 Dias");
                }
                else if (mesIntro == 4 || mesIntro == 6 || mesIntro == 9 || mesIntro == 11)
                {
                    Console.WriteLine("30 Dias");
                }
                else if (mesIntro == 2)
                {
                    Console.WriteLine("29 Dias");
                }
            }

            else
            {


                if (mesIntro == 1 || mesIntro == 3 || mesIntro == 5 || mesIntro == 7 || mesIntro == 8 || mesIntro == 10 || mesIntro == 12)
                {
                    Console.WriteLine("31 Dias");
                }
                else if (mesIntro == 4 || mesIntro == 6 || mesIntro == 9 || mesIntro == 11)
                {
                    Console.WriteLine("30 Dias");
                }
                else if (mesIntro == 2)
                {
                    Console.WriteLine("28 Dias");
                }


            }

            string valorContinua = mi2.Caso();

            if (valorContinua != "s")
            {

                cerrarMenu = true;

            }

        }

    }

}