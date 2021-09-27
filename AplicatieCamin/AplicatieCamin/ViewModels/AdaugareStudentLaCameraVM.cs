using AplicatieCamin.Models.BusinessLogicLayer;
using AplicatieCamin.Models.EntityLayer;
using AplicatieCamin.ViewModels.Commands;
using AplicatieCamin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AplicatieCamin.ViewModels
{
    class AdaugareStudentLaCameraVM : BasePropertyChanged
    {
        StudentBLL studentBLL;
        public AdaugareStudentLaCameraVM()
        {
            studentBLL = new StudentBLL();
            Studenti = new ObservableCollection<Student>(studentBLL.TotiStudentiiFaraCamera());
        }

        ObservableCollection<Student> studenti;

        public ObservableCollection<Student> Studenti
        {
            get
            {
                return studenti;
            }
            set
            {
                studenti = value;
                NotifyPropertyChanged("Studenti");
            }
        }

        private Student studentSelectat;
        public Student StudentSelectat
        {
            get
            {
                return studentSelectat;
            }
            set
            {
                studentSelectat = value;

                if (studentSelectat != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("StudentSelectat");
            }
        }

        bool sterge;
        public bool Sterge
        {
            get
            {
                return sterge;
            }
            set
            {
                sterge = value;
                NotifyPropertyChanged("Sterge");
            }
        }
        public void AdaugaStudentLaCamera(object o)
        {

            StudentSelectat.Camin = Camere.CaminulCurent.Numar;
            StudentSelectat.Camera = StudentiiUneiCamere.CameraCurenta.Numar;
            studentBLL.ModificaStudent(StudentSelectat);

            Studenti = new ObservableCollection<Student>(studentBLL.TotiStudentiiUneiCamere(StudentiiUneiCamere.CameraCurenta));

            MessageBox.Show("Studentul a fost adaugat in aceasta camera!");
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaStudentLaCamera);
                }
                return adauga;
            }
        }
    }
}
