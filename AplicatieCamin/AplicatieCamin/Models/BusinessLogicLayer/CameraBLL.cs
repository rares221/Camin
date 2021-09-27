using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class CameraBLL
    {
        CameraDAL cameraDAL = new CameraDAL();

        internal List<Camera> ToateCamereleUnuiCamin(Camin camin)
        {
            return cameraDAL.ToateCamereleUnuiCamin(camin);
        }

        internal void AdaugareCamera(Camera camera)
        {
            cameraDAL.AdaugareCamera(camera);
        }

        internal void ModificareCamera(Camera camera)
        {
            cameraDAL.ModificareCamera(camera);
        }

        internal void StergeCamera(Camera camera)
        {
            cameraDAL.StergeCamera(camera);
        }
    }
}
