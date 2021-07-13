using System;
using System.Collections.Generic;

namespace Ejercicio8_forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add ("JUAN");
            nombres.Add ("Maria");
            nombres.Add ("Pedro");
            foreach (var nombre in nombres)
            {
                Console.WriteLine (nombre);
            }


            List<int> numeros = new List<int>();
            numeros.Add (10);
            numeros.Add (50);
            numeros.Add (2); 

            foreach (var numero in numeros)
            {
                Console.WriteLine (numero);
                
            }

            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno (123,"Pedro");
            Alumno b = new Alumno(231,"Juan");
            Alumno c = new Alumno(321,"Maria");

            alumnos.Add (a);
            alumnos.Add (b);
            alumnos.Add (c);

            foreach (var alumno in alumnos)
            {
                Console.WriteLine (alumno.Id+" -> "+alumno.Nombre);
            }
            
        }
    }
}
