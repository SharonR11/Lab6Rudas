using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab6Rudas
{
    public class Estudiante
    {
        public string Seccion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public Estudiante(string seccion, string nombres, string apellidos)
        {
            Seccion = seccion;
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public string Persona => $"{Nombres} {Apellidos}";


    }


}



