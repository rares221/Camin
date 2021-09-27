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
    class StudentiVM : BasePropertyChanged
    {
        StudentBLL studentBLL;
        ObservableCollection<Student> studenti;
        public StudentiVM()
        {
            studentBLL = new StudentBLL();
            Students = new ObservableCollection<Student>(studentBLL.TotiStudentii());
        }

        public ObservableCollection<Student> Students
        {
            get
            {
                return studenti;
            }
            set
            {
                studenti = value;
                NotifyPropertyChanged("Students");
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
                ModificaStudent.StudentCurent = value;
                if (studentSelectat != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("StudentSelectat");
            }
        }

        public void StergeStudent(object o)
        {
            studentBLL.StergeStudent(StudentSelectat);


            Students = new ObservableCollection<Student>(studentBLL.TotiStudentii());

            MessageBox.Show("Student sters!");
        }


        private ICommand stergereStudent;
        public ICommand StergereStudent
        {
            get
            {
                if (stergereStudent == null)
                {
                    stergereStudent = new RelayCommand(StergeStudent);
                }
                return stergereStudent;
            }
        }
    }
}
