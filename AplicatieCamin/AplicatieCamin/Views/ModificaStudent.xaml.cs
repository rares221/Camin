using AplicatieCamin.Models.EntityLayer;
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
    /// Interaction logic for ModificaStudent.xaml
    /// </summary>
    public partial class ModificaStudent : Window
    {
        public static Student StudentCurent;
        public ModificaStudent(Student student)
        {
            StudentCurent = student;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Studenti studenti = new Studenti();
            studenti.Show();
            this.Close();
        }
    }
}
