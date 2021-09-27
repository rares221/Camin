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
    public class CamineVM : BasePropertyChanged
    {
        CaminBLL caminBLL;
        ObservableCollection<Camin> camine;
        public CamineVM()
        {
            caminBLL = new CaminBLL();
            Camine = new ObservableCollection<Camin>(caminBLL.ToateCaminele());
        }

        public ObservableCollection<Camin> Camine
        {
            get
            {
                return camine;
            }
            set
            {
                camine = value;
                NotifyPropertyChanged("Camine");
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


        private Camin caminSelectat;
        public Camin CaminSelectat
        {
            get
            {
                return caminSelectat;
            }
            set
            {
                caminSelectat = value;
                Camere.CaminulCurent = value;
                if(caminSelectat!=null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("CaminSelectat");
            }
        }

        public void StergeCamin(object o)
        {
            caminBLL.StergeCamin(CaminSelectat);

            Camine = new ObservableCollection<Camin>(caminBLL.ToateCaminele());
            //Camere.ContextMenuClosingEvent

            MessageBox.Show("Camin sters!");
        }


        private ICommand stergereCamin;
        public ICommand StergereCamin
        {
            get
            {
                if (stergereCamin == null)
                {
                    stergereCamin = new RelayCommand(StergeCamin);
                }
                return stergereCamin;
            }
        }

        
    }
}
