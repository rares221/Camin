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
    class CamereVM : BasePropertyChanged
    {
        CameraBLL cameraBLL;
        ObservableCollection<Camera> camere;
        public CamereVM()
        {
            cameraBLL = new CameraBLL();
            NumarCamin = Camere.CaminulCurent.Numar.ToString();
            Rooms = new ObservableCollection<Camera>(cameraBLL.ToateCamereleUnuiCamin(Camere.CaminulCurent));
        }

        public ObservableCollection<Camera> Rooms
        {
            get
            {
                return camere;
            }
            set
            {
                camere = value;
                NotifyPropertyChanged("Rooms");
            }
        }

        public string NumarCamin { get; set; }


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


        private Camera cameraSelectata;
        public Camera CameraSelectata
        {
            get
            {
                return cameraSelectata;
            }
            set
            {
                cameraSelectata = value;
                StudentiiUneiCamere.CameraCurenta = value;
                if (cameraSelectata != null)
                {
                    Sterge = true;
                }
                NotifyPropertyChanged("CameraSelectata");
            }
        }

        public void StergeCamera(object o)
        {
            cameraBLL.StergeCamera(CameraSelectata);
    
            Rooms = new ObservableCollection<Camera>(cameraBLL.ToateCamereleUnuiCamin(Camere.CaminulCurent));
            
            MessageBox.Show("Camera stersa!");
        }


        private ICommand stergereCamera;
        public ICommand StergereCamera
        {
            get
            {
                if (stergereCamera == null)
                {
                    stergereCamera = new RelayCommand(StergeCamera);
                }
                return stergereCamera;
            }
        }
    }
}
