using AplicatieCamin.Models.BusinessLogicLayer;
using AplicatieCamin.Models.EntityLayer;
using AplicatieCamin.ViewModels.Commands;
using AplicatieCamin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AplicatieCamin.ViewModels
{
    class AdaugareStudentVM : BasePropertyChanged
    {
        FacultateBLL facultateBLL;
        TipTaxaBLL tipTaxaBLL;
        StudentBLL studentBLL;
        
        public AdaugareStudentVM()
        {
            facultateBLL = new FacultateBLL();
            tipTaxaBLL = new TipTaxaBLL();
            studentBLL = new StudentBLL();
            if(ModificaStudent.StudentCurent !=null)
            {
                ID = ModificaStudent.StudentCurent.ID;
                Nume = ModificaStudent.StudentCurent.Nume;
                Prenume = ModificaStudent.StudentCurent.Prenume;
                CNP = ModificaStudent.StudentCurent.CNP;
            }

            Facultati = facultateBLL.ToateFacultatile();
            TipuriDeTaxa = tipTaxaBLL.ToateTipurileDeTaxa();
        }

        public void AdaugaStudent(object o)
        {
            Student student = new Student()
            {
                Nume = Nume,
                Prenume = Prenume,
                CNP = CNP,
                Facultate = Facultate.Nume,
                TipTaxa = TipTaxa.Nume
            };

            studentBLL.AdaugaStudent(student);

            MessageBox.Show("Studentul a fost adaugat cu succes!");
            Nume = String.Empty;
            Prenume = String.Empty;
            CNP = String.Empty;
            Facultate = null;
            TipTaxa = null;
        }

        private ICommand adauga;
        public ICommand Adauga
        {
            get
            {
                if (adauga == null)
                {
                    adauga = new RelayCommand(AdaugaStudent);
                }
                return adauga;
            }
        }


        public void ModificareStudent(object o)
        {
            Student student = new Student()
            {
                ID = ID,
                Nume = Nume,
                Prenume = Prenume,
                CNP = CNP,
                Facultate = Facultate.Nume,
                TipTaxa = TipTaxa.Nume
            };

            studentBLL.ModificaStudent(student);

            MessageBox.Show("Datele studentului au fost modificate!");
        }

        private ICommand modifica;
        public ICommand Modifica
        {
            get
            {
                if (modifica == null)
                {
                    modifica = new RelayCommand(ModificareStudent);
                }
                return modifica;
            }
        }

        List<Facultate> facultati;
        
        public List<Facultate> Facultati
        {
            get
            {
                return facultati;
            }
            set
            {
                facultati = value;
                NotifyPropertyChanged("Facultati");
            }
        }

        List<TipTaxa> tipuriDeTaxa;

        public List<TipTaxa> TipuriDeTaxa
        {
            get
            {
                return tipuriDeTaxa;
            }
            set
            {
                tipuriDeTaxa = value;
                NotifyPropertyChanged("TipuriDeTaxa");
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("ID");
            }
        }

        string nume;
        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                NotifyPropertyChanged("Nume");
            }
        }

        string prenume;
        public string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                prenume = value;
                NotifyPropertyChanged("Prenume");
            }
        }

        string cnp;
        public string CNP
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
                NotifyPropertyChanged("CNP");
            }
        }

        Facultate facultate;
        public Facultate Facultate
        {
            get
            {
                return facultate;
            }
            set
            {
                facultate = value;
                NotifyPropertyChanged("Facultate");
            }
        }

        TipTaxa tipTaxa;
        public TipTaxa TipTaxa
        {
            get
            {
                return tipTaxa;
            }
            set
            {
                tipTaxa = value;
                NotifyPropertyChanged("TipTaxa");
            }
        }
    }
}
