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
using System.Windows.Shapes;

namespace AplicatieCamin.Views
{
    /// <summary>
    /// Interaction logic for Camine.xaml
    /// </summary>
    public partial class Camine : Window
    {
        public Camine()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Camere.CaminulCurent = null;
            AdaugaCamin adaugaCamin = new AdaugaCamin();
            adaugaCamin.Show();
            this.Close();
        }

        private void RoomsBtn_Click(object sender, RoutedEventArgs e)
        {
            Camere camere = new Camere(Camere.CaminulCurent);
            camere.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaCamin modificaCamin = new ModificaCamin(Camere.CaminulCurent);
            modificaCamin.Show();
            this.Close();

        }
    }
}
