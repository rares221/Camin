using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieCamin.Models.EntityLayer
{
    class Plata
    {
        public int ID { get; set; }

        public float Suma { get; set; }

        public string Luna { get; set; }

        public bool Platita { get; set; }

        public int IDStudent { get; set; }
    }
}
