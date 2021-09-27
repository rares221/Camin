using AplicatieCamin.Models.DataAccessLayer;
using AplicatieCamin.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.BusinessLogicLayer
{
    class StudentBLL
    {
        StudentDAL studentDAL = new StudentDAL();

        internal List<Student> TotiStudentii()
        {
            return studentDAL.TotiStudentii();
        }

        internal List<Student> TotiStudentiiUneiCamere(Camera camera)
        {
            return studentDAL.TotiStudentiiUneiCamere(camera);
        }

        internal List<Student> TotiStudentiiFaraCamera()
        {
            return studentDAL.TotiStudentiiFaraCamera();
        }

        internal void AdaugaStudent(Student student)
        {
            studentDAL.AdaugaStudent(student);
        }

        internal void ModificaStudent(Student student)
        {
            studentDAL.ModificareStudent(student);
        }

        internal void StergeStudent(Student student)
        {
            studentDAL.StergeStudent(student);
        }
    }
}
