using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204055
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Makanan ayamcrispy      = new Makanan("Ayam Crispy", "makanan", 6000);
                Makanan ayamgeprek      = new Makanan("Ayam Geprek", "makanan", 8000);
                Makanan gepreknasi      = new Makanan("Ayam Geprek", "makanan", 11000);

                Minuman jusMangga       = new Minuman("Jus Mangga", "minuman", 6000);
                Minuman jusSirsak       = new Minuman("Jus Sirsak", "minuman", 6000);
                Minuman jusAlpukat      = new Minuman("Jus Alpukat", "minuman", 6000);
                Minuman jusStrawberry   = new Minuman("Jus Strawberry", "minuman", 6000);

                Console.WriteLine("==============================\n");
                Console.WriteLine("SELAMAT DATANG DI WARUNG AHOY\n");
                Console.WriteLine("==============================\n");
                Console.WriteLine("Halo-halo, silahkan pilih tipe menunya ya! :)\n");

                Console.WriteLine("1. Makanan");
                Console.WriteLine("2. Minuman\n");

                Console.Write("Tipe menu yang kamu pilih : ");

                int tipePilihan = Convert.ToInt16(Console.ReadLine());

                if (tipePilihan == 1)
                {
                    Console.WriteLine("\nKamu pilih makanan yaa!");
                    Console.WriteLine("Makanan disini terdiri dari: \n");
                    Console.WriteLine("1. {0} harga Rp.{1}", ayamcrispy.NamaMakanan, ayamcrispy.IniHarga);
                    Console.WriteLine("2. {0} harga Rp.{1}", ayamgeprek.NamaMakanan, ayamgeprek.IniHarga);
                    Console.WriteLine("3. {0} dengan nasi, harga Rp.{1}", gepreknasi.NamaMakanan, gepreknasi.IniHarga);
                }
                else if (tipePilihan == 2)
                {
                    Console.WriteLine("\nKamu pilih minuman yaa!");
                    Console.WriteLine("Minuman disini terdiri dari: \n");
                    Console.WriteLine("1. {0} harga Rp.{1}", jusAlpukat.NamaMinuman, jusAlpukat.IniHarga);
                    Console.WriteLine("2. {0} harga Rp.{1}", jusMangga.NamaMinuman, jusMangga.IniHarga);
                    Console.WriteLine("3. {0} harga Rp.{1}", jusSirsak.NamaMinuman, jusSirsak.IniHarga);
                    Console.WriteLine("4. {0} harga Rp.{1}", jusStrawberry.NamaMinuman, jusStrawberry.IniHarga);
                }
                else
                {
                    Console.WriteLine("\nMohon maaf kawan, tipe makanan tidak ada:(, Ulang kembali untuk memilih tipenya yaa. Terimakasi :)");
                }
                Console.Write("\nIngin mengulang kembali (y/t)? ");
            } while (Console.ReadLine() == "y");
        }
    }
}
