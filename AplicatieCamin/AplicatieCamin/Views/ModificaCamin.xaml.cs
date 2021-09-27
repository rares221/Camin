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
    /// Interaction logic for ModificaCamin.xaml
    /// </summary>
    public partial class ModificaCamin : Window
    {
        public ModificaCamin(Camin camin)
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Camine camine = new Camine();
            camine.Show();
            this.Close();
        }

        private static readonly Regex conditieNumarCamin = new Regex("[^0-9]+");
        private static readonly Regex conditieTaxaCamin = new Regex("[^0-9.]+");
        private static bool TextPentruNumar(string text)
        {
            return !conditieNumarCamin.IsMatch(text);
        }

        private static bool TextPentruTaxa(string text)
        {
            return !conditieTaxaCamin.IsMatch(text);
        }

        private void NumarCamin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextPentruNumar(e.Text);
        }

        private void TaxaCamin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !TextPentruTaxa(e.Text);
        }
    }
}
