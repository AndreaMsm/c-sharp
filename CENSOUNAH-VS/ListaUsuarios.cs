using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAH_VS
{
    class ListaUsuarios
    {
        public List<Alumnos> ListaAlumnos{ get; set; }

        public ListaUsuarios()
        {
            ListaAlumnos = new List<Alumnos>();
            Alumnos();
        }

private void Alumnos(){

            Alumnos a = new Alumnos ("20192002292","Andrea Monserrat Mejia Sanchez"    ,"Informatica Administrativa",true,true,true);
            Alumnos b = new Alumnos ("20202000864","Gilma Paola Deras Reyes"           ,"Informatica Administrativa",true,true,true);
            Alumnos c = new Alumnos ("20192002178","Helen Nicoole Suarez Hernandez"    ,"Informatica Administrativa",true,true,true);
            Alumnos d = new Alumnos ("20212021040","Denilson Aldair Rubi Garcia"       ,"Informatica Administrativa",true,true,true);
            Alumnos e = new Alumnos ("20192201236","Jhessua Manuel Gonzalez"           ,"Informatica Administrativa",true,true,true);
            Alumnos f = new Alumnos ("20202003125","Jader Eduardo Araque Acuña"        ,"Administracion de Empresa", true,true,false);
            Alumnos g = new Alumnos ("20192000545","Maximo Marco Hernandez"            ,"Administracion de Empresa", true,true,false);
            Alumnos h = new Alumnos ("20202000355","Ramona Victoria Parra"             ,"Administracion de Empresa", true,true,false);
            Alumnos i = new Alumnos ("20132000565","Margarita de Jesus Zambrano"       ,"Administracion de Empresa", true,true,false);
            Alumnos j = new Alumnos ("20012000255","Lucila Maria Perez"                ,"Economia",                  true,true,false);
            Alumnos k = new Alumnos ("20182000055","Juan Bautista Zurita"              ,"Economia",                  true,true,false);
            Alumnos l = new Alumnos ("20192000975","Luis Javier Collado"               ,"Economia",                  true,true,false);
            Alumnos m = new Alumnos ("20202000565","Vanesa Rivero"                     ,"Economia",                  true,true,false);
            Alumnos n = new Alumnos ("20212000576","Maria Estrella Peña"               ,"Economia",                  true,true,false);
            Alumnos o = new Alumnos ("20192000542","Leonardo Cantero"                  ,"Economia",                  true,true,false);

            
            ListaAlumnos.Add(a);
            ListaAlumnos.Add(b);
            ListaAlumnos.Add(c);
            ListaAlumnos.Add(d);
            ListaAlumnos.Add(e);
            ListaAlumnos.Add(f);
            ListaAlumnos.Add(g);
            ListaAlumnos.Add(h);
            ListaAlumnos.Add(i);
            ListaAlumnos.Add(j);
            ListaAlumnos.Add(l);
            ListaAlumnos.Add(m);
            ListaAlumnos.Add(n);
            ListaAlumnos.Add(o);
            
        }
        public void listaUsuarios()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                         LISTA DE USUARIOS");
            Console.WriteLine("========================================================================================================================");

            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("Numero de Cuenta |  Nombre y Apellido      |  Carrera    |   Aceso Administracion | Aceso a Economia| Aceso aInformatica");
            Console.WriteLine("========================================================================================================================");
            var usuariosOrdenados= ListaAlumnos.OrderBy(usr => usr.Carrera);
            foreach (var usuarios in usuariosOrdenados)
            {
                Console.WriteLine(usuarios.NCuenta+" | "+usuarios.Nombre+"     ->   "+usuarios.Carrera+"   ->  "+usuarios.Administracion +"    ->  "+usuarios.Economia +"   ->  "+usuarios.Informatica);
            }
            Console.ReadLine();
        }
    }   
}