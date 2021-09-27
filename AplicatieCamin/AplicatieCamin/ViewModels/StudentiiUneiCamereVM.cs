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
    class StudentiiUneiCamereVM : BasePropertyChanged
    {
        StudentBLL studentBLL;
        public StudentiiUneiCamereVM()
        {
            studentBLL = new StudentBLL();
            NumarCamera = StudentiiUneiCamere.CameraCurenta.Numar.ToString();
            Studenti = new ObservableCollection<Student>(studentBLL.TotiStudentiiUneiCamere(StudentiiUneiCamere.CameraCurenta));
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

        public string NumarCamera { get; set; }


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

        public void MutaStudent(object o)
        {
            StudentSelectat.Camin = null;
            StudentSelectat.Camera = null;
            studentBLL.ModificaStudent(StudentSelectat);
            
            Studenti = new ObservableCollection<Student>(studentBLL.TotiStudentiiUneiCamere(StudentiiUneiCamere.CameraCurenta));
            
            MessageBox.Show("Studentul a fost scos din aceasta camera!");
        }


        private ICommand muta;
        public ICommand Muta
        {
            get
            {
                if (muta == null)
                {
                    muta = new RelayCommand(MutaStudent);
                }
                return muta;
            }
        }

        
    }
}
