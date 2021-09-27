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
    /// Interaction logic for Camere.xaml
    /// </summary>
    public partial class Camere : Window
    {
        public static Camin CaminulCurent;
        public Camere(Camin camin)
        {
            CaminulCurent = camin;
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Camine camine = new Camine();
            camine.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentiiUneiCamere.CameraCurenta = null;
            AdaugareCamera adaugareCamera = new AdaugareCamera();
            adaugareCamera.Show();
            this.Close();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            ModificaCamera modificaCamera = new ModificaCamera(StudentiiUneiCamere.CameraCurenta);
            modificaCamera.Show();
            this.Close();
        }

        private void StudentiBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentiiUneiCamere studentiiUneiCamere = new StudentiiUneiCamere(StudentiiUneiCamere.CameraCurenta);
            studentiiUneiCamere.Show();
            this.Close();
        }
    }
}
