using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ModificaCamera.xaml
    /// </summary>
    public partial class ModificaCamera : Window
    {
        public ModificaCamera(Camera camera)
        {
            InitializeComponent();
        }

        private void NumarCamera_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextPentruNumar(e.Text);
        }

        private static readonly Regex conditieNumarCamera = new Regex("[^0-9]+");
        private static bool TextPentruNumar(string text)
        {
            return !conditieNumarCamera.IsMatch(text);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Camere camere = new Camere(Camere.CaminulCurent);
            camere.Show();
            this.Close();
        }
    }
}
