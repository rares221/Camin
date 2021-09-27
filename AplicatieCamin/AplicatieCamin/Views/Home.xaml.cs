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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CamineBtn_Click(object sender, RoutedEventArgs e)
        {
            Camine camine = new Camine();
            camine.Show();
            this.Close();
        }

        private void StudentsBtn_Click(object sender, RoutedEventArgs e)
        {
            Studenti studenti = new Studenti();
            studenti.Show();
            this.Close();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
