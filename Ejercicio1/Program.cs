using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desarrollar un programa que permita almacenar las edades de un grupo 
//    de 10 personas en un vector de enteros y luego determine la cantidad 
//    de personas que son menores de edad, mayores de edad, cuántos adultos 
//    mayores, la edad más baja, la edad más alta y el promedio de edades ingresadas. 
//    Para el ejercicio anterior suponga que un adulto mayor debe tener una edad igual 
//    o superior a 60. Debe validar para cada ingreso que los valores estén en un rango 
//    entre 1 y 120 años. En caso de error deberá notificar y solicitar un nuevo valor.

/*
 * Tareas
 * Vector = 1
 * Menor = 1
 * Mayor = 1
 * Adultos = 1
 * Edad mas baja
 * Edad mas alta
 * Promedio de las edades = 1
 * Ingreso en rango de edad = 1
 * Validar mayor de edad = 1
 */
namespace Ejercicio1
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Ej();
            Console.ReadKey();
        }
        public static void Ej()
        {
            // VARIABLES
            int Menor = 0;
            int Mayor = 0;
            int Adulto = 0;
            int EdadBaja;
            int suma = 0;
            double Promedio = 0;
            // VECTOR
            int[] Edad = new int[10];

            //INGRESO DE EDADES
            Console.WriteLine("Ingrese la edad de las 10 personas del grupo\n");
            for (int i = 0; i < Edad.Length; i++)
            {
                Console.Write($"Persona {i + 1}: ");
                Edad[i] = int.Parse(Console.ReadLine());

                if (Edad[i] >= 1 && Edad[i] <= 120)
                {
                    Edad[i] = Edad[i];
                }
                else
                {
                    Console.WriteLine($"La edad ingresada para la persona {i + 1} no cumple con el rango de edad, ingresa una nueva\n");
                     Console.Write($"Persona {i + 1}: "); ;
                    Edad[i] = int.Parse(Console.ReadLine());
                }

            }
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // LISTADO DE EDADES
            Console.WriteLine();
            Console.WriteLine("Las edades de los Personas son:\n");
            foreach (var item in Edad)
            {
                Console.Write(item + " ");
            }
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // MENORES DE EDAD
            Console.WriteLine();
            for (int i = 0; i < Edad.Length; i++)
            {
                if (Edad[i] < 18)
                {
                    Menor++;
                }
            }
            Console.Write($"Cantidad de personas MENORES de edad son: {Menor}\n");
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // MAYORES DE EDAD
            Console.WriteLine();
            for (int i = 0; i < Edad.Length; i++)
            {
                if (Edad[i] >= 18 && Edad[i] < 60)
                {
                    Mayor++;
                }
            }
            Console.Write($"Cantidad de personas MAYORES de edad son: {Mayor}\n");
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // ADULTO DE EDAD
            Console.WriteLine();
            for (int i = 0; i < Edad.Length; i++)
            {
                if (Edad[i] >= 60 && Edad[i] <= 120)
                {
                    Adulto++;
                }
            }
            Console.Write($"Cantidad de personas ADULTAS de edad son: {Adulto}\n");
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // EDAD MAS BAJA
            //Console.WriteLine();
            //for (int i = 0; i < Edad.Length; i++)
            //{
            //    if (Edad[i] <  Edad[i - 1] )
            //    {
            //       EdadBaja = Edad[i];
            //    }
            //}
            //Console.Write($"La edad mas baja es: {EdadBaja}\n");
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            //×××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××××
            // PROMEDIO DE LAS EDADES
            foreach (var ed in Edad)
            {
                suma += ed;
                Promedio = suma / (10);
            }
            Console.WriteLine($"El promedio de las edades es: {Promedio}");
        }
    }
}
