using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheckBoxyCombobox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            //Se mete un objeto de tipo poblaciones los {} es para indicar que elementos ban como si fuera un array pero no exactamente uno
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogota" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "DF" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });
            //Capitales de donde se originan tus elementos, de lista capitales
            Capitales.ItemsSource = ListaCapitales;
        }
        //lOS OTROS EVENTOS AYUDA A ACTIVAR Y DESACTIVAR
        private void TodosC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;
        }

        private void TodosC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false; ;
            Lima.IsChecked = false;
            DF.IsChecked = false; ;
            Santiago.IsChecked = false;
        }

        private void IndividualCheked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true 
                && Bogota.IsChecked == true 
                && Lima.IsChecked == true 
                && DF.IsChecked == true 
                && Santiago.IsChecked == true)
            {
                TodosC.IsChecked = true;
            }
            else
            {
                TodosC.IsChecked = null;
            }
        }

        private void IndividualUncheked(object sender, RoutedEventArgs e)
        {
            if ( Madrid.IsChecked == false
               && Bogota.IsChecked == false
               && Lima.IsChecked == false
               && DF.IsChecked == false
               && Santiago.IsChecked == false)
            {
                TodosC.IsChecked = false;
            }
            else
            {
                TodosC.IsChecked = null;
            }
        }
    }
    public class Capitales
    {//el binding accede a la propiedad 
        //mi teoria es que los lee porque la clase le esta indicando que los datos vienen del string NombreCapital entonces como esto estan creando objetos  que acceden al NombreCapital usa sus datos
        //ya que la propiedad le indica esto, ya que indica que viene de ListaCapitales.
        public string NombreCapital { get; set; }
    }
}
