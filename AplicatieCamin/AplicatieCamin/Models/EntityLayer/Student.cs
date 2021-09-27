using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.EntityLayer
{
    public class Student
    {
        public int ID { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string CNP { get; set; }

        public string Facultate { get; set; }

        public string TipTaxa { get; set; }

        public int? Camin { get; set; }

        public int? Camera { get; set; }
    }
}
