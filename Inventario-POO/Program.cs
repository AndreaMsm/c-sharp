using System;


namespace _01_Inventario
{
    class Program
    {
    
    static void Main(string[] args)
        {

            string opcion="";
            Inventario inventario =new Inventario();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");//nombre del programa
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("1-> Productos");
                Console.WriteLine("2-> Ingreso de inventario");
                Console.WriteLine("3-> Salida de inventario");
                Console.WriteLine("4-> Producto con defectos de fabrica");
                Console.WriteLine("5-> Cambiar productos con defectos");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Seleccione una opcion: ");//ingrese un numero de tipo entero
                opcion=Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                    {   Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        inventario.listarProductos();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue ;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        inventario.ingreso_inventario();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta ;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        inventario.salida_inventario();
                        Console.ReadLine();
                        break;
                    }
                    case "4":
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        inventario.productoMalo();
                        Console.ReadLine();
                        break;
                    }
                    case "5":
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        inventario.productoCambio();
                        Console.ReadLine();
                        break;
                    }
                    
                    default:
                    break;
                }
                if (opcion=="0")
                {
                    break;
                }
                
            }
            
        }
    }
}
