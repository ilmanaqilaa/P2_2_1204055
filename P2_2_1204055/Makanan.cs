using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204055
{

    public class Makanan: Tipe
    {
        protected string namaMakanan;
         
        public Makanan(string namamakanan, string tipe, int harga) :base(tipe,harga)
        {
            this.namaMakanan = namamakanan;
        }

        public string NamaMakanan
        {
            get
            {
                return namaMakanan;
            }

            set
            {
                namaMakanan = value;
            }
        }
    }
}
