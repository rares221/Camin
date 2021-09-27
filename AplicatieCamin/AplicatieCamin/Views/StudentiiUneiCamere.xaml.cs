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
    /// Interaction logic for StudentiiUneiCamere.xaml
    /// </summary>
    public partial class StudentiiUneiCamere : Window
    {
        public static Camera CameraCurenta;
        public StudentiiUneiCamere(Camera camera)
        {
            CameraCurenta = camera;
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AdaugaStudentLaCamera adaugaStudentLaCamera = new AdaugaStudentLaCamera();
            adaugaStudentLaCamera.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Camere camere = new Camere(Camere.CaminulCurent);
            camere.Show();
            this.Close();
        }
    }
}
