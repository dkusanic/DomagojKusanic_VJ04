using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        /// <summary>
        /// Konstruktor klase.
        /// </summary>
        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }
    }
}
