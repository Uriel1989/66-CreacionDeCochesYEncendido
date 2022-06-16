using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDeExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Carga de 5 autos, con propiedades: Marca, Modelo, Color
             * Metodo "Encender"
             * 1) Cargar los autos (Usar un For)
             * 2) Encernderlos (Usar otro For independiente)
             */

            List<Automovil> ListaAutos = new List<Automovil>();

            Console.CursorLeft = 30;
            
            Console.WriteLine("Ingrese la cantidad de autos:");

            int CantidadDeCoches = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < CantidadDeCoches; i++)
            {
                int b = i + 1;
                Automovil Auto = new Automovil();

                Console.WriteLine("Ingrese marca del auto " + b + ":");

                string Marca = Console.ReadLine();

                Auto.Marca = Marca.ToUpper();


                Console.WriteLine("Ingrese modelo del auto " + b + ":");

                string Modelo = Console.ReadLine();

                Auto.Modelo = Modelo.ToUpper();

                Console.WriteLine("Ingrese color del auto " + b + ":");

                string Color = Console.ReadLine();

                Auto.Color = Color.ToUpper();

                Console.Clear();


                ListaAutos.Add(Auto);

                switch (Auto.Marca.ToUpper())
                {
                    case "FIAT":

                        Console.WriteLine(Auto.Encender());
                        break;
                }
            }


            Console.ReadKey();

            /*Pedir al usuario que ingrese Fiat y que solo enciendan los que correspondan a dicha marca
             * Toupper//Tolower se encarga de mandar todo el texto a mayuscula o minuscula
             */
        }
    }
}
