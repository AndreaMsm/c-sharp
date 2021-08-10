namespace UNAH_VS
{
  class Economia:Asignaturas
  {

    public bool Aceso { get; set; }
      public Economia(string codigo, string nombre, string nombreMaestro,string hora, int cupos)
      {
      Codigo=codigo; 
      Nombre=nombre;
      NombreMaestro=nombreMaestro;
      Hora=hora;
      Cupos=cupos;
      }

      public Economia()
      {
          Aceso=true;
      }
  }

}