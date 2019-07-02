using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komposisi
{
    public class Mobil
    {
        public string Merk { get; set; }
        private Mesin mesin;
        public Mobil()
        {
            mesin = new Mesin();
            mesin.Type = "INLINE";
        }
        public Mesin GetlnfoMesin()
        {
            return mesin;
        }

        public class Mesin 
        { public string Type { get; set; }
        }
    }
}
