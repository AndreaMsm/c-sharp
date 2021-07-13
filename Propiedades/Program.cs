using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Nombre = "Pedro";
            a.edad = 19;
            a.sexo="Masculino";
            a.NumeroTelefono = 8989090;
            
            Alumno b = new Alumno( "Juan roberto", "Masculino");
            b.Id = 321;
            b.edad = 50;
            b.NumeroTelefono = 675434353;
            Console.WriteLine ("");
            
            Alumno c = new Alumno(355);
            c.Nombre = "Martin";
            c.edad = 40;
            c.sexo = "Masculino";
            c.NumeroTelefono = 6990353;

            Console.WriteLine("Codigo = " + a.Id);
            Console.WriteLine("Nombre = " + a.Nombre);
            Console.WriteLine("Edad = " + a.edad);
            Console.WriteLine("Sexo= " + a.sexo);
            Console.WriteLine("Numero de Telefono = " + a.NumeroTelefono);
            Console.WriteLine("");
            
            Console.WriteLine("");
            Console.WriteLine("Codigo = " + b.Id);
            Console.WriteLine("Nombre = " + b.Nombre);
            Console.WriteLine("Edad = " + b.edad);
            Console.WriteLine("Sexo= " + b.sexo);
            Console.WriteLine("Numero de Telefono = " + b.NumeroTelefono);
        
            Console.WriteLine("");
            Console.WriteLine("Codigo = " + c.Id);
            Console.WriteLine("Nombre = " + c.Nombre);
            Console.WriteLine("Edad = " + c.edad);
            Console.WriteLine("Sexo= " + c.sexo);
            Console.WriteLine("Numero de Telefono = " + c.NumeroTelefono);
        }
    }
}
