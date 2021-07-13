 public class Alumno{
     /*Propiedades*/

     public int id { get; set; }
     public string PrimerNombre{ get; set; }
     public string SegundoNombre { get; set; }
    public bool Activo { get; set; }

     public Alumno(int Id, string primerNombre, string segundoNombre)//constructor
     {
         id=Id;
         PrimerNombre = primerNombre;
         SegundoNombre = segundoNombre;
         Activo=true;
     }

     public string nombrecompleto(){ //Funcion
         if (Activo == true)
         {
           return PrimerNombre + " " + SegundoNombre;  
         }
         
         return "Alumno Inactivo";
     }
     public void alumnoinactivo(){ //funcion
         Activo = false;
     }
     public void activaralumno(){ //funcion
         Activo = true;
     }
 }