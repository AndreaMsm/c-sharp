namespace UNAH_VS
{
  class Administracion:Asignaturas
  {

      public Administracion(string codigo, string nombre, string nombreMaestro,string hora, int cupos)
      {
      Codigo=codigo; 
      Nombre=nombre;
      NombreMaestro=nombreMaestro;
      Hora=hora;
      Cupos=cupos;
      }
  }

}