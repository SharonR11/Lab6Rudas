using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6Rudas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    

    public partial class ListViewGroup : ContentPage
    {


        public class Grupo<TKey, TItem> : List<TItem>
        {
            public TKey Key { get; private set; }

            public Grupo(TKey key, IEnumerable<TItem> items)
            {
                Key = key;
                AddRange(items);
            }
        }

        ObservableCollection<Grupo<string, Estudiante>> estudiantesGrupos = new ObservableCollection<Grupo<string, Estudiante>>();

        public ObservableCollection<Grupo<string, Estudiante>> EstudiantesGrupos { get { return estudiantesGrupos; } }



        public ListViewGroup()
        {
            InitializeComponent();

            var estudiantes = new List<Estudiante>
            {
                new Estudiante("Seccion A", "Sharon", "Rudas"),
                new Estudiante("Seccion A", "Deysi", "Lloja"),
                new Estudiante("Seccion A", "Ana", "Cristina"),
                new Estudiante("Seccion A", "Luis", "Islachin"),
                new Estudiante("Seccion B", "Brooke", "Lumia"),
                new Estudiante("Seccion B", "Bobby", "Xperia"),
                new Estudiante("Seccion B", "Bella", "Desire"),
                new Estudiante("Seccion B", "Ben", "Chocolate")
            };

            var grupos = estudiantes
                .GroupBy(e => e.Seccion)
                .Select(grupo => new Grupo<string, Estudiante>(grupo.Key, grupo));

            estudiantesGrupos = new ObservableCollection<Grupo<string, Estudiante>>(grupos);

            GroupedView.ItemsSource = estudiantesGrupos;

            GroupedView.ItemsSource = grupos;


        }

    }
}