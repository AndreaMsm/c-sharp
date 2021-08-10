using System;
using System.Collections.Generic;
using System.Linq;

namespace UNAH_VS

{
    class ListaClases
    {
        int matriculadosAdministracion=0;
        int matriculadosEconomia=0;
        int matriculadosInformatica=0;


        public List<Alumnos> ListaAlumnos{ get; set; }
        public List<Administracion> ListaAdministracion { get; set; }
        public List<Economia> ListaEconomia { get; set; }
        public List<Informatica> ListaInformatica { get; set; }
    
    public ListaClases()
        {
        ListaAlumnos = new List<Alumnos>();
        Alumnos();    
        ListaAdministracion = new List<Administracion>();
        administracion();
        ListaEconomia = new List<Economia>();
        economia();
        ListaInformatica = new List<Informatica>();
        informatica();
        }

        private void Alumnos(){

            Alumnos a = new Alumnos ("20192002292","Andrea Monserrat Mejia Sanchez"    ,"Informatica Administrativa",true,true,true);
            Alumnos b = new Alumnos ("20202000864","Gilma Paola Deras Reyes"           ,"Informatica Administrativa",true,true,true);
            Alumnos c = new Alumnos ("20192002178","Helen Nicoole Suarez Hernandez"    ,"Informatica Administrativa",true,true,true);
            Alumnos d = new Alumnos ("20212021040","Denilson Aldair Rubi Garcia"       ,"Informatica Administrativa",true,true,true);
            Alumnos e = new Alumnos ("20192201236","Jhessua Manuel Gonzalez Blanco"    ,"Informatica Administrativa",true,true,true);
            Alumnos f = new Alumnos ("20202003125","Jader Eduardo Araque Acuña"        ,"Administracion de Empresa", true,true,false);
            Alumnos g = new Alumnos ("20192000545","Victoria Iveth Mejia Sanchez"      ,"Administracion de Empresa", true,true,false);
            Alumnos h = new Alumnos ("20202000355","Deyner Diaz Boca Negra"            ,"Administracion de Empresa", true,true,false);
            Alumnos i = new Alumnos ("20132000565","Viviana Gisela Castillo Carranza"  ,"Administracion de Empresa", true,true,false);
            Alumnos j = new Alumnos ("20012000255","Jennifer Paola Castillo Carranza"  ,"Economia",                  true,true,false);
            Alumnos k = new Alumnos ("20182000055","Maycol Gerardo Portillo Maldonado" ,"Economia",                  true,true,false);
            Alumnos l = new Alumnos ("20192000975","Denilson Alejandro Gimenez "       ,"Economia",                  true,true,false);
            Alumnos m = new Alumnos ("20202000565","Luis Bermudez Carmonon"            ,"Economia",                  true,true,false);
            Alumnos n = new Alumnos ("20212000576","Dennis Jared Rios Morales"         ,"Economia",                  true,true,false);
            Alumnos o = new Alumnos ("20192000542","Angelina Duran Soto"               ,"Economia",                  true,true,false);
            
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
            Console.WriteLine("                                         ░L░I░S░T░A░ ░D░E░ ░U░S░U░A░R░I░O░");
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
 private void administracion()
        {
            Administracion a =new Administracion ("DAE-300", "Administracion I",            "Gabriel Peña","08:00 - 09:00",30);
            Administracion b =new Administracion ("DAE-400", "Administracion II",           "Juan Jose","18:00 - 19:00",30);
            Administracion c =new Administracion ("DAE-610", "Analisis Cuantitativo I",     "Pedro Perez","11:00 - 12:00",30);
            Administracion d =new Administracion ("DAE-505", "Contabilidad Administrativa I","Julio Amalla","07:00 - 08:00",30);
            Administracion e =new Administracion ("DAE-605", "Contabilidad Administrativa II.","Roberto Perdomo","11:00 - 12:00",30);
            Administracion f =new Administracion ("DAE-710", "Analisis Cuantitativo II.",      "Josefina Martinez","12:00 - 13:00",30);
        
            ListaAdministracion.Add(a);
            ListaAdministracion.Add(b);
            ListaAdministracion.Add(c);
            ListaAdministracion.Add(d);
            ListaAdministracion.Add(e);
            ListaAdministracion.Add(f);
            
        }
    public void ListadeAdministracion()
        {
            Console.Clear();
            Console.WriteLine("================================================================================================================================"); 
            Console.WriteLine("                           [A] [D] [M] [I] [N] [I] [S] [T] [R] [A] [C] [I] [O] [N]");
            Console.WriteLine("================================================================================================================================");
            Console.WriteLine("=================================================================================================================================");
            Console.WriteLine("");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("Codigo  | Asignatura | Maestro | Hora inicio - Hora Final | Cupos disponibles");
            Console.WriteLine("=============================================================================");

            foreach (var administracion in ListaAdministracion)
            {
                Console.WriteLine(administracion.Codigo +" -> "+administracion.Nombre+" -> "+administracion.NombreMaestro+" -> "+administracion.Hora+" -> "+administracion.Cupos );
            }
            Console.ReadLine();
        }

 private void economia()
        {
            Economia a =new Economia ("CE-020", "Principios de Economia","Lidia Ferrera","10:00 - 11:00",30);
            Economia b =new Economia ("CE-240", "Microenomia","Ramon Bustillo","13:00 - 14:00",30);
            Economia c =new Economia ("CE-075", "Macroeconomia","Alonso Paredes","16:00 - 17:00",30);
            Economia d =new Economia ("CE-020", "Principios de Economia","Ramon Bustillo","18:00 - 19:00",30);
            Economia e =new Economia ("CE-040", "Microeconomía I","Ramon Bustillo","14:00 - 15:00",30);
            ListaEconomia.Add(a);
            ListaEconomia.Add(a);
            ListaEconomia.Add(b);
            ListaEconomia.Add(c);
            ListaEconomia.Add(d);
            ListaEconomia.Add(e);
        }
    public void ListadeEconomia()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================="); 
            Console.WriteLine("                        [E] [C] [O] [N] [O] [M] [I] [A]");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("Codigo  | Asignatura | Maestro | Hora inicio - Hora Final | Cupos disponibles");
            Console.WriteLine("=============================================================================");

            foreach (var economia in ListaEconomia)
            {
                Console.WriteLine(economia.Codigo +" -> "+economia.Nombre+" -> "+economia.NombreMaestro+" -> "+economia.Hora+" -> "+economia.Cupos );
            }
            Console.ReadLine();
        }

        private void informatica()
        {
            Informatica a =new Informatica ("A-012", "Introducion a la informatica","Carmen Salgado","07:00 - 08:00",3);
            Informatica b =new Informatica ("A-023", "Taller de Hardware I","Hector Garcia","09:00 - 10:00",30);
            Informatica c =new Informatica ("A-033", "Metodologia de la Programacion","Hector Garcia","07:00 - 08:00",30);
            Informatica d =new Informatica ("A-044", "Lenguaje de Programación I.","Igor Mejia","11:00 - 12:00",30);
            Informatica e =new Informatica ("A-044", "Lenguaje de Programación I.","Nazarena Idiaquez","18:00 - 19:00",30);
            Informatica f =new Informatica ("A-054", "Taller de Hardware II","Juan Mejia","14:00 - 15:00",30);
            Informatica g =new Informatica ("IA-065", "Lenguaje de Programación II.","Bilys Fernandez","19:00 - 20:00",30);

            ListaInformatica.Add(a);
            ListaInformatica.Add(b);
            ListaInformatica.Add(c);
            ListaInformatica.Add(d);
            ListaInformatica.Add(e);
            ListaInformatica.Add(f);
            ListaInformatica.Add(g);
        }
    public void ListadeInformatica()
        {
            Console.Clear();
            Console.WriteLine(); 
            Console.WriteLine("============================================================================================="); 
            Console.WriteLine("                       [I] [N] [F] [O] [R] [M] [A] [T] [I] [C] [A]                            ");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Codigo  | Asignatura | Maestro | Hora inicio - Hora Final | Cupos disponibles");
            Console.WriteLine("=============================================================================");

            foreach (var informatica in ListaInformatica)
            {
                Console.WriteLine(informatica.Codigo +" -> "+informatica.Nombre+" -> "+informatica.NombreMaestro+" -> "+informatica.Hora+" -> "+informatica.Cupos );
            }
            Console.ReadLine();
        }
public void ofertaAcademica()
{
Console.Clear();
Console.WriteLine("=====================================================================");
Console.WriteLine("         La oferta Academica para el periodo es");
Console.WriteLine("=====================================================================");
Console.WriteLine("");
ListadeAdministracion();
Console.WriteLine("");
Console.WriteLine("");
ListadeEconomia();
Console.WriteLine("");
Console.WriteLine("");
ListadeInformatica();
}

public void agregar()
{
    string cuenta="";
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("            ADICION DE CLASES");
    Console.WriteLine("*******************************************");
    Console.WriteLine("Ingrese su numero de cuenta: ");
    cuenta=Console.ReadLine();
    Alumnos alumno = ListaAlumnos.Find(v=>v.NCuenta==cuenta);
        if (alumno==null)
        {
            Console.WriteLine("Alumno no encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Alumno: "+ alumno.Nombre);
            Console.ReadLine();
        }
    matriculaUNAHVS(cuenta);

}


public void matriculaUNAHVS(string cuenta)
{
    Informatica a = new Informatica();
    string departamento="";
    string codigo="";
    string matricular="";
if (cuenta == "20192002292" ||cuenta == "20202000864" ||cuenta == "20192002178" ||cuenta == "20212021040" ||cuenta == "20192201236")
{
        Console.Clear();
        Console.WriteLine("================================================");
        Console.WriteLine("         BIENVENIDO ADICIONA TU CLASE");
        Console.WriteLine("================================================");
        Console.WriteLine("");
        Console.WriteLine("Ingresa el nombre del departamento: ");
        Console.WriteLine("====================================");
        departamento=Console.ReadLine();
if (departamento.ToLower() == "administracion")
    {
    Console.WriteLine("Ingrese el condigo de su clase:");
    codigo=Console.ReadLine();
    foreach (var administracion in ListaAdministracion)
        {
            if(administracion.Codigo==codigo)
            {
                    Console.WriteLine("Asignatura: "+administracion.Nombre+" Horario: "+administracion.Hora);
                    Console.WriteLine("Cupos Disponibles: "+administracion.Cupos);
                    if (administracion.Cupos == 0)
                    {
                     Console.WriteLine("NO HAY CUPOS");
                     Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Decea matricular su clase (s/n): ");
                        matricular= Console.ReadLine();
                        if (matricular.ToLower() == "s")
                        administracion.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosAdministracion++;
                        Console.ReadLine();
                    }
                    
            }
           
       }
       
    }
    else if (departamento.ToLower() == "economia")
    {
        Console.WriteLine("Ingrese el condigo de su clase:");
        codigo=Console.ReadLine();
        foreach (var economia in ListaEconomia)
       {
            if(economia.Codigo==codigo)
            {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+economia.Nombre+" Horario: "+economia.Hora);
                    Console.WriteLine("Cupos Disponibles: "+economia.Cupos);
                    Console.WriteLine("Decea matricular su clase (s/n): ");
                    if (economia.Cupos == 0)
                    {
                     Console.WriteLine("NO HAY CUPOS");
                     Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Decea matricular su clase (s/n): ");
                        matricular= Console.ReadLine();
                        if (matricular.ToLower() == "s")
                        economia.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosEconomia++;
                        Console.ReadLine();
                    }
                        
            }
       }
        
    }
    else if (departamento.ToLower() == "informatica")
    {
        Console.WriteLine("Ingrese el condigo de su clase:");
        codigo=Console.ReadLine();
        foreach (var informatica in ListaInformatica)
       {
            if(informatica.Codigo==codigo)
                {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+informatica.Nombre+" Horario: "+informatica.Hora);
                    Console.WriteLine("Cupos Disponibles: "+informatica.Cupos);
                    
                    if (informatica.Cupos == 0)
                    {
                     Console.WriteLine("NO HAY CUPOS");
                     Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Decea matricular su clase (s/n): ");
                        matricular= Console.ReadLine();
                        if (matricular.ToLower() == "s")
                        informatica.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosInformatica++ ;
                        Console.ReadLine();
                    }
                }
        }


    }
    else
    {
        Console.WriteLine("DEPARTAMENTO NO ECONTRADO");
        Console.WriteLine("=========================");
        Console.ReadLine();
    }
Console.ReadLine();
}
else if (cuenta == "20202003125" ||cuenta == "20192000545" ||cuenta == "20202000355" ||cuenta == "20132000565" ||cuenta == "20012000255"||cuenta == "20182000055"||cuenta == "20192000975"||cuenta == "20202000565"||cuenta == "20192000542"||cuenta == "20212000576")
    {
        Console.Clear();
        Console.WriteLine("================================================");
        Console.WriteLine("         BIENVENIDO ADICIONA TU CLASE");
        Console.WriteLine("================================================");
        Console.WriteLine("");
        Console.WriteLine("Ingresa el nombre del departamento: ");
        Console.WriteLine("====================================");
        departamento=Console.ReadLine();
if (departamento.ToLower() == "administracion")
    {
    Console.WriteLine("Ingrese el condigo de su clase:");
    codigo=Console.ReadLine();
    foreach (var administracion in ListaAdministracion)
        {
            if(administracion.Codigo==codigo)
            {
            
                    Console.WriteLine("ADICIONANDO TU CLASE");
                    Console.WriteLine("====================");
                    Console.WriteLine("Asignatura: "+administracion.Nombre+" Horario: "+administracion.Hora);
                    Console.WriteLine("Cupos Disponibles: "+administracion.Cupos);
                    if (administracion.Cupos == 0)
                    {
                     Console.WriteLine("NO HAY CUPOS");
                     Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Decea matricular su clase (s/n): ");
                        matricular= Console.ReadLine();
                        if (matricular.ToLower() == "s")
                        administracion.Cupos--;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        matriculadosAdministracion++;
                        Console.ReadLine();
                    }
            }
           
       }
       
    }
    else if (departamento.ToLower() == "economia")
    {
        
        Console.WriteLine("Ingrese el condigo de su clase:");
        codigo=Console.ReadLine();
        foreach (var economia in ListaEconomia)
       {
            if(economia.Codigo==codigo)
            {
                    Console.Clear();
                    Console.WriteLine("Asignatura: "+economia.Nombre+" Horario: "+economia.Hora);
                    Console.WriteLine("Cupos Disponibles: "+economia.Cupos);
                    if (economia.Cupos == 0)
                    {
                     Console.WriteLine("NO HAY CUPOS");
                     Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Decea matricular su clase (s/n): ");
                        matricular= Console.ReadLine();
                        if (matricular.ToLower() == "s")
                        economia.Cupos--;
                        matriculadosEconomia++;
                        Console.WriteLine("Se ha matriculado exitosamente");
                        Console.ReadLine();
                    }
            Console.ReadLine();        
            }
       }
        
    }
else if(departamento.ToLower() == "informatica")
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("SIN ACESSO AL DEPARTAMENTO DE INFORMATICA");
        Console.WriteLine("=========================================");
        Console.ReadLine();
    }
    }
else
    {
        Console.WriteLine("\aUSUARIO NO ENCONTRADO");
        Console.ReadLine();
    }

}
public void TotalMatriculado()
{
    Console.Clear();
    Console.WriteLine("=====================================================");
    Console.WriteLine("                   MATRICULA TOTAL");
    Console.WriteLine("=====================================================");
    Console.WriteLine("");
    Console.WriteLine("Matriculados en el departamento de administracion: "+matriculadosAdministracion);
    Console.WriteLine("Matriculados en el departamento de economia: "+ matriculadosEconomia);
    Console.WriteLine("Matriculados en el departamento de informatica: "+matriculadosInformatica);
    Console.WriteLine("");
    Console.WriteLine("El total de alumno matriculados para el periodo son: "+(matriculadosAdministracion+matriculadosEconomia+matriculadosInformatica));
    Console.ReadLine();
}
    }
}        