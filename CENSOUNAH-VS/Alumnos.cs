using System;

namespace UNAH_VS
{
    class Alumnos
    {
        public string NCuenta { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }

        public bool Administracion { get; set; }
        public bool Economia { get; set; }
        public bool Informatica { get; set; }

        public Alumnos(string cuenta, string nombre, string carrera,bool administracion,bool economia,bool informatica)
        {
            NCuenta=cuenta;
            Nombre=nombre;
            Carrera=carrera;
            Administracion=administracion;
            Economia=economia;
            Informatica=informatica;
        }
    }

}