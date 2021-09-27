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
    /// Interaction logic for AdaugaStudentLaCamera.xaml
    /// </summary>
    public partial class AdaugaStudentLaCamera : Window
    {
        public AdaugaStudentLaCamera()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            StudentiiUneiCamere studentiiUneiCamere = new StudentiiUneiCamere(StudentiiUneiCamere.CameraCurenta);
            studentiiUneiCamere.Show();
            this.Close();
        }
    }
}
