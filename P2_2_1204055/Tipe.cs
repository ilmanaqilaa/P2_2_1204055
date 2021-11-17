using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204055
{
    public class Tipe
    {
        public string iniJenis;
        public int iniHarga;

        public Tipe()
        {

        }

        public Tipe(string jenis, int harga)
        {
            this.iniJenis = jenis;
            this.iniHarga = harga;
        }

        public string IniJenis
        {
            get
            {
                return iniJenis;
            }

            set
            {
                iniJenis = value;
            }
        }

        public int IniHarga
        {
            get
            {
                return iniHarga;
            }
            set
            {
                iniHarga = value;
            }
        }
    }
}
