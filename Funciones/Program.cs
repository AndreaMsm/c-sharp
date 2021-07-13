using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno a=new Alumno(123,"Juan","Perez");
            Alumno b=new Alumno(321,"Maria","Martinez");
            
            a.alumnoinactivo();
            Console.WriteLine(a.nombrecompleto());
            Console.WriteLine(b.nombrecompleto());

            Console.WriteLine("");
            a.activaralumno();
            Console.WriteLine(a.nombrecompleto());
            Console.WriteLine(b.nombrecompleto());

        }
    }
}
