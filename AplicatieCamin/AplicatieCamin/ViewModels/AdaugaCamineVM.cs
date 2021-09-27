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
    class AdaugaCamineVM : BasePropertyChanged
    {
        CaminBLL caminBLL;
        public AdaugaCamineVM()
        {
            if(Camere.CaminulCurent!=null)
            {
                NumarCamin = Camere.CaminulCurent.Numar.ToString();
                Taxa = Camere.CaminulCurent.Taxa.ToString();
            }
            caminBLL = new CaminBLL();
        }
 
        private string numarCamin;
        private string taxa;
        public string NumarCamin 
        {
            get 
            {
                return numarCamin;
            }
            set 
            {
                numarCamin = value;
                NotifyPropertyChanged("NumarCamin");
            }
        }

        public string Taxa
        {
            get
            {
                return taxa;
            }
            set
            {
                taxa = value;
                NotifyPropertyChanged("Taxa");
            }
        }

        public void Adaugare(object o)
        {
            bool ok = true;
            int numar=0;
            float taxaLunara=0;
            try
            {
                numar = Int32.Parse(NumarCamin);
                taxaLunara = float.Parse(Taxa);
            }
            catch (Exception)
            {
                MessageBox.Show("Datele introduse sunt incorecte!");
                ok = false;
            }
            
            if(ok)
            {
                bool exista = false;
                List<Camin> camine = caminBLL.ToateCaminele();
                foreach (Camin c in camine)
                {
                    if(c.Numar == numar)
                    {
                        MessageBox.Show("Exista deja un camin cu acest numar!");
                        exista = true;
                    }
                }

                if(!exista)
                {
                    Camin camin = new Camin()
                    {
                        Numar = numar,
                        Taxa = taxaLunara
                    };

                    caminBLL.AdaugareCamin(camin);

                    NumarCamin = String.Empty;
                    Taxa = String.Empty;

                    MessageBox.Show("Camin adaugat cu succes!");
                }
            }
        }

        private ICommand adaugaCamin;
        public ICommand AdaugaCamin
        {
            get
            {
                if (adaugaCamin == null)
                {
                    adaugaCamin = new RelayCommand(Adaugare);
                }
                return adaugaCamin;
            }
        }

        public void Modificare(object o)
        {
            bool ok = true;
            int numar = 0;
            float taxaLunara = 0;
            try
            {
                numar = Int32.Parse(NumarCamin);
                taxaLunara = float.Parse(Taxa);
            }
            catch (Exception)
            {
                MessageBox.Show("Datele introduse sunt incorecte!");
                ok = false;
            }

            if (ok)
            {
                bool exista = false;
                List<Camin> camine = caminBLL.ToateCaminele();
                foreach (Camin c in camine)
                {
                    if (c.Numar == numar && numar != Camere.CaminulCurent.Numar)
                    {
                        MessageBox.Show("Exista deja un camin cu acest numar!");
                        exista = true;
                    }
                }

                if (!exista)
                {
                    Camin camin = new Camin()
                    {
                        ID = Camere.CaminulCurent.ID,
                        Numar = numar,
                        Taxa = taxaLunara
                    };

                    caminBLL.ModificareCamin(camin);

                    MessageBox.Show("Datele caminului au fost modificate!");
                }
            }
        }

        private ICommand modificaCamin;
        public ICommand ModificaCamin
        {
            get
            {
                if (modificaCamin == null)
                {
                    modificaCamin = new RelayCommand(Modificare);
                }
                return modificaCamin;
            }
        }
    }
}
