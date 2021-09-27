using AplicatieCamin.Models.BusinessLogicLayer;
using AplicatieCamin.Models.EntityLayer;
using AplicatieCamin.Views;
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

namespace AplicatieCamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            AdminBLL adminBLL = new AdminBLL();
            List<Admin> admini = adminBLL.ToatiAdministratorii();
            foreach (var admin in admini)
            {
                if(admin.NumeUtilizator == this.UsernameTxt.Text && admin.Parola == this.PasswordTxt.Password)
                {
                    ok = true;
                }
            }
            if(ok)
            {
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola incorecte!");
            }
            
        }

        private void TaxeBtn_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            StudentBLL studentBLL = new StudentBLL();
            List<Student> studenti = studentBLL.TotiStudentii();

            foreach (var student in studenti)
            {
                if(student.CNP == this.CNPTxt.Text)
                {
                    ok = true;
                    TaxeStudent.StudentCurent = student;
                    TaxeStudent taxeStudent = new TaxeStudent(student);
                    taxeStudent.Show();
                    this.Close();
                }
            }

            if(!ok)
            {
                MessageBox.Show("Nu a fost gasit niciun student cu acest CNP!");
            }
        }
    }
}
