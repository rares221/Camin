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
    class AdaugareCameraVM : BasePropertyChanged
    {
        CameraBLL cameraBLL;
        public AdaugareCameraVM()
        {
            if(StudentiiUneiCamere.CameraCurenta!=null)
            {
                NumarCamera = StudentiiUneiCamere.CameraCurenta.Numar.ToString();
            }
            cameraBLL = new CameraBLL();
        }

        private string numarCamera;
        public string NumarCamera
        {
            get
            {
                return numarCamera;
            }
            set
            {
                numarCamera = value;
                NotifyPropertyChanged("NumarCamera");
            }
        }

        public void Adaugare(object o)
        {
            bool ok = true;
            int numar = 0;
            try
            {
                numar = Int32.Parse(NumarCamera);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Datele introduse sunt incorecte!");
                ok = false;
            }

            if (ok)
            {
                bool exista = false;
                List<Camera> camere = cameraBLL.ToateCamereleUnuiCamin(Camere.CaminulCurent);
                foreach (Camera c in camere)
                {
                    if (c.Numar == numar)
                    {
                        MessageBox.Show("Exista deja o camera cu acest numar!");
                        exista = true;
                    }
                }

                if (!exista)
                {
                    Camera camera = new Camera()
                    {
                        Numar = numar,
                        IDCamin = Camere.CaminulCurent.ID
                    };

                    cameraBLL.AdaugareCamera(camera);

                    NumarCamera = String.Empty;

                    MessageBox.Show("Camera adaugata cu succes!");
                }
            }
        }

        private ICommand adaugaCamera;
        public ICommand AdaugaCamera
        {
            get
            {
                if (adaugaCamera == null)
                {
                    adaugaCamera = new RelayCommand(Adaugare);
                }
                return adaugaCamera;
            }
        }

        public void Modificare(object o)
        {
            bool ok = true;
            int numar = 0;
            try
            {
                numar = Int32.Parse(NumarCamera);

            }
            catch (Exception)
            {
                MessageBox.Show("Datele introduse sunt incorecte!");
                ok = false;
            }

            if (ok)
            {
                bool exista = false;
                List<Camera> camere = cameraBLL.ToateCamereleUnuiCamin(Camere.CaminulCurent);
                foreach (Camera c in camere)
                {
                    if (c.Numar == numar && numar != StudentiiUneiCamere.CameraCurenta.Numar)
                    {
                        MessageBox.Show("Exista deja o camera cu acest numar in camin!");
                        exista = true;
                    }
                }

                if (!exista)
                {
                    Camera camera = new Camera()
                    {
                        ID = StudentiiUneiCamere.CameraCurenta.ID,
                        Numar = numar,
                        IDCamin = Camere.CaminulCurent.ID
                    };

                    cameraBLL.ModificareCamera(camera);

                    MessageBox.Show("Datele camerei au fost modificate!");
                }
            }
        }

        private ICommand modificareCamera;
        public ICommand ModificareCamera
        {
            get
            {
                if (modificareCamera == null)
                {
                    modificareCamera = new RelayCommand(Modificare);
                }
                return modificareCamera;
            }
        }
    }
}
