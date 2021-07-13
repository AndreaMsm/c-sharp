public class Producto
{
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int Existencia { get; set; }

    public int ProductoEnMalEstado { get; set; } //existencia de producto malo



    public Producto(string codigo, string descripcion, int existencia, int ProductoEnMalEstado)
    {
        Codigo=codigo;
        Descripcion = descripcion;
        Existencia =existencia;
        ProductoEnMalEstado = ProductoEnMalEstado;
    }
}