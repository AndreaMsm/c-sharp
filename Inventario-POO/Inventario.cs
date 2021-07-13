using System;
using System.Collections.Generic;

public class Inventario {

    public List<Producto> ListaProducto { get; set; }
    public Inventario()
    {
     ListaProducto = new List<Producto>();
     Producto a=new Producto ("001","Iphone X", 0 , 5);
     Producto b=new Producto ("002","Dell", 10 , 3);
     Producto c=new Producto ("003","Monitor Samsung", 50 , 15);
     Producto d=new Producto ("004","Mouse", 100 , 25);
     Producto e=new Producto ("005","Headset", 80 , 3);

     ListaProducto.Add(a);
     ListaProducto.Add(b);
     ListaProducto.Add(c);
     ListaProducto.Add(d);
     ListaProducto.Add(e);
    }
    
public void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Producto");
            Console.WriteLine("-------------------");
            Console.WriteLine("CODIGO | DESCRIPCION | EXISTENCIA |PRODUCTO EN MAL ESTADO");

     foreach (var producto in ListaProducto)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion +" | "+producto.Existencia.ToString() +" | "+ producto.ProductoEnMalEstado.ToString());
        }
}
private void movimiento_inventario(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
       foreach (var producto in ListaProducto)
       {
            if (producto.Codigo==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        producto.ProductoEnMalEstado=producto.ProductoEnMalEstado+cantidad;
                    }
                    else
                    {
                         producto.ProductoEnMalEstado=producto.ProductoEnMalEstado- cantidad;
                    }
                }
       }
}
       
private void movimiento_cambio(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        foreach (var producto in ListaProducto)
        {
            if (producto.Codigo==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        producto.ProductoEnMalEstado=producto.ProductoEnMalEstado+ cantidad;
                    }
                    else
                    {
                         producto.ProductoEnMalEstado=producto.ProductoEnMalEstado- cantidad;
                    }
                }
        }
}
        
public void ingreso_inventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("PRODUCTO AGREGADO");
        movimiento_inventario(codigo,Int32.Parse(cantidad),"+");
}   
public void salida_inventario(){//Resta  de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que saldra de inventario: ");
        cantidad=Console.ReadLine();
        movimiento_inventario(codigo,Int32.Parse(cantidad),"-");
}
public void productoMalo(){// ajuste positivo Producto que se daña en la empresa o biene malo por defectos de fabrica
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto en mal estado: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("HAS AGREGADO PRODUCTOS EN MAL ESTADO A TU INVENTARIO : "+cantidad);
        movimiento_cambio(codigo,Int32.Parse(cantidad),"+");
}

public void productoCambio(){//Ajuste negativo
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de producto daniado para cambio");
        Console.WriteLine("**************************************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que se cambiara: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("HAS LOGRADO CAMBIAR PRODUCTOS DANIADO");
        movimiento_cambio(codigo,Int32.Parse(cantidad),"-");
    }


}