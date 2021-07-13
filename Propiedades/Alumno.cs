

public class Alumno
{
 public int Id { get; set; }

 public string Nombre { get; set; }

 public int edad { get; set; }

 public string sexo { get; set; }

 public int NumeroTelefono { get; set; }


 public Alumno (){
    Id=123;
 }

 public Alumno (int id){

     Id=id;
 }

 public Alumno (string nombre , string Sexo){
     Nombre = nombre;
     sexo =Sexo;
 }
}
