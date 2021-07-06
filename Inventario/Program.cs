using System;

namespace inventario
{
    class Program
    {


    static string [,] productos = new string [5,4]
        {
            {"001","Iphone X","10","5"},
            {"002","Lapto DELL","5","1"},
            {"003","Monitor samsung","25","12"},
            {"004","Mause","100","15"},
            {"005","Headset","25","10"},
        
        } ;
    static void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Producto");
            Console.WriteLine("-------------------");
            Console.WriteLine("CODIGO | DESCRIPCION | EXISTENCIA |PRODUCTO DANIADO ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine (productos [i, 0] + " |" + productos [i, 1] + " |"+productos[i, 2] + " | "+productos[i, 3]);
            }
        }
    static void movimiento_inventario(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        for (int i = 0; i < 5; i++)
            {
                if (productos [i, 0]==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        productos[i, 2]=(Int32.Parse(productos[i, 2])+ cantidad).ToString();
                    }
                    else
                    {
                         productos[i, 2]=(Int32.Parse(productos[i, 2])- cantidad).ToString();
                    }
                    
                    
                }
                
            }
            
        }
    
    static void movimiento_cambio(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        for (int i = 0; i < 5; i++)
            {
                if (productos [i, 0]==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        productos[i, 3]=(Int32.Parse(productos[i, 3])+ cantidad).ToString();
                    }
                    else
                    {
                         productos[i, 3]=(Int32.Parse(productos[i, 3])- cantidad).ToString();
                    }
                    
                    
                }
                
            }
            
        }

    static void ingreso_inventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        movimiento_inventario(codigo,Int32.Parse(cantidad),"+");
}   
     static void salida_inventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        movimiento_inventario(codigo,Int32.Parse(cantidad),"-");
}
     static void productoMalo(){// ajuste positivo Producto que se daña en la empresa o biene malo por defectos de fabrica
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto en mal estado: ");
        cantidad=Console.ReadLine();
        movimiento_cambio(codigo,Int32.Parse(cantidad),"+");
}

    static void productoCambio(){//Ajuste negativo
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de producto daniado para cambio");
        Console.WriteLine("**************************************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que se cambiara: ");
        cantidad=Console.ReadLine();
        movimiento_cambio(codigo,Int32.Parse(cantidad),"-");
    }
    static void Main(string[] args)
        {
            string opcion="";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("1-> Productos");
                Console.WriteLine("2-> Ingreso de inventario");
                Console.WriteLine("3-> Salida de inventario");
                Console.WriteLine("4-> Producto con defectos de fabrica");
                Console.WriteLine("5-> Cambiar productos con defectos");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion=Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                    {
                        Console.Clear();
                        listarProductos();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        ingreso_inventario();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        salida_inventario();
                        break;
                    }
                    case "4":
                    {
                        Console.Clear();
                        productoMalo();
                        break;
                    }
                    case "5":
                    {
                        Console.Clear();
                        productoCambio();
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