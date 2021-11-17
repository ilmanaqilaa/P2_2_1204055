using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204055
{
    public class Minuman : Tipe
    {
        protected string namaMinuman;

        public Minuman(string namaminuman,string tipe, int harga) :base(tipe,harga)
        {
            this.namaMinuman = namaminuman;
        }

        public string NamaMinuman
        {
            get
            {
                return namaMinuman;
            }

            set
            {
                namaMinuman = value;
            }
        }
    }
}
