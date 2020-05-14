using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Cb_Genres
    {
        public int ID { get; set; }
        public string Genre_Name { get; set; }
        public override string ToString()
        {
            return Genre_Name;
        }
    }
}
