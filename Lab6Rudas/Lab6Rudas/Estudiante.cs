using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab6Rudas
{
    public class Estudiante:List<ListViewGroup>
    {
        public string Seccion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        private Estudiante( string nombres, String apellidos)
        {
            Nombres = nombres;
            Apellidos= apellidos;
        }
        public static IList<Estudiante> All { private set; get; }

        static Estudiante()
        {
            List<Estudiante> Groups = new List<Estudiante> {

            new Estudiante ("Seccion A", "A"){

                new ListViewGroup("Sharon", "Rudas", new switchCellPage(),""),
                new ListViewGroup("Deysi", "Lloja", new switchCellPage(), "grapefruit.jpg"),
                new ListViewGroup("Ana", "Cristina", new switchCellPage(), "grapefruit.jpg"),
                new ListViewGroup("Luis", "ISlachin", new switchCellPage(), "grapefruit.jpg")
            },
            new Estudiante ("Seccion B", "B"){
                new ListViewGroup("Brooke", "Lumia", new switchCellPage(),""),
                new ListViewGroup("Bobby", "Xperia", new switchCellPage(), "grapefruit.jpg"),
                new ListViewGroup("Bella", "Desire", new switchCellPage(), "grapefruit.jpg"),
                new ListViewGroup("Ben", "Chocolate", new switchCellPage(), "grapefruit.jpg")
            }
        };
            All = Groups;
        }
    }
}
