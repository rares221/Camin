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
    /// Interaction logic for Studenti.xaml
    /// </summary>
    public partial class Studenti : Window
    {
        public Studenti()
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
            ModificaStudent.StudentCurent = null;
            AdaugareStudent adaugareStudent = new AdaugareStudent();
            adaugareStudent.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaStudent modificaStudent = new ModificaStudent(ModificaStudent.StudentCurent);
            modificaStudent.Show();
            this.Close();
        }
    }
}
