namespace UNAH_VS
{
  class Informatica:Asignaturas
  {
    public bool Aceso { get; set; }
      public Informatica(string codigo, string nombre, string nombreMaestro,string hora, int cupos)
      {
      Codigo=codigo; 
      Nombre=nombre;
      NombreMaestro=nombreMaestro;
      Hora=hora;
      Cupos=cupos;
      }
      public Informatica()
      {
          
      }
        public void aceso()
        {
          Aceso =true;
        }
        
      

  }

}