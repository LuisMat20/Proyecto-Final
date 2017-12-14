using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
   class Program
   {
      public void Temperatura()
      {
         float temperatura = 1.8F, Fahrenheit = 0, Celcius = 0, grados = 0;
         int tipo = 0;
         string opcion = "";

         while (opcion != "n")
         {
            Console.Clear();
            Console.Write("¿Que desea convertir?\n\n1) - Celcius a Fahrenheit \n2) - Fahrenheit a Celcius\n");
            tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
               case 1:
                  Console.Write("Ingrese los grados a convertir ");
                  grados = float.Parse(Console.ReadLine());
                  Fahrenheit = (grados * temperatura + 32);
                  Console.WriteLine("{0} Centigrados Fahrenheit", Fahrenheit);
                  break;
               case 2:
                  Console.Write("Ingrese los grados a convertir ");
                  grados = float.Parse(Console.ReadLine());
                  Celcius = ((grados - 32) / temperatura);
                  Console.WriteLine("{0} Centigrados Celcius", Celcius);
                  break;
               default:
                  Console.WriteLine("Solo se aceptan números del 1 al 2");
                  break;
            }
            Console.Write("\n¿Desea Continuar? (s/n) ");
            opcion = Console.ReadLine();
            if (opcion == "n")
            {
               Console.Clear();
               Menu();
            }
         }
      }

      public void Medidas()
      {
         float centimetro = 0.393701F, pulgadas = 2.54f, medida = 0, total = 0;
         int tipo = 0;
         string opcion = "";

         while (opcion != "n")
         {
            Console.Clear();
            Console.Write("¿Que desea convertir?\n\n1) - Centimetros a Pulgadas \n2) - Pulgadas a Centimetros\n");
            tipo = int.Parse(Console.ReadLine());


            switch (tipo)
            {
               case 1:
                  Console.Write("Ingrese los Centimetros a convertir ");
                  medida = float.Parse(Console.ReadLine());
                  total = (medida * centimetro);
                  Console.WriteLine("{0} Total en pulgdas ", total);
                  break;
               case 2:
                  Console.Write("Ingrese las Pulgadas a convertir ");
                  medida = float.Parse(Console.ReadLine());
                  total = (medida * pulgadas);
                  Console.WriteLine("{0} Total en centimetros ", total);
                  break;

               default:
                  Console.WriteLine("Solo se aceptan números");
                  break;
            }
            Console.Write("\n¿Desea Continuar? (s/n) ");
            opcion = Console.ReadLine();
            if (opcion == "n")
            {
               Console.Clear();
               Menu();
            }
         }
      }

      public void Salir()
      {
         string opt3;
         Console.Write("\n¿Seguro que desea salir? (s/n) ");
         opt3 = Console.ReadLine();
         if (opt3 == "s")
         {
            Console.WriteLine("\nEstudiante == Luis Manuel Mateo ---- Matricula 14-MISN-1-055");
            Console.WriteLine("Estudiante == Eddy Antonio Santos -- Matricula 14-EIST-1-089");
            Console.WriteLine("Estudiante == Gildany A. Ferrer ---- Matricula 13-EIST-1-050");

            Console.Write("\n************* Asta pronto ************\n\nPresione cualquier tecla para salir");
            Console.ReadKey();
         }
         else
         {
            Console.Clear();
            Menu();
         }
      }

      public void Menu()
      {
         Console.WriteLine("Estudiante == Luis Manuel Mateo ---- Matricula 14-MISN-1-055");
         Console.WriteLine("Estudiante == Eddy Antonio Santos -- Matricula 14-EIST-1-089");
         Console.WriteLine("Estudiante == Gildany A. Ferrer ---- Matricula 13-EIST-1-050\n");

         Console.WriteLine("Seleccione la opción deseada\n");

         Console.WriteLine(" 1) ==> Convertir temperatura");
         Console.WriteLine(" 2) ==> Convertir Medidas");
         Console.WriteLine(" 3) ==> Salir");
         Console.Write("==> ");

         string opt = Console.ReadLine();

         switch (opt)
         {
            case "1":
               Temperatura();
               break;
            case "2":
               Medidas();
               break;
            case "3":
               Salir();
               break;
            default:
               Console.Clear();
               Menu();
               break;
         }
      }

      static void Main(string[] args)
      {
         Program pro = new Program();
         pro.Menu();
      }
   }
}
