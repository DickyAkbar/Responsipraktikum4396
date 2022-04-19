using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4396    
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan();
            Karyawan kar2 = new Karyawan();

            kar1.Nik = 190302123;
            kar1.Nama = "Paijo";
            kar1.GajiBulanan = 3000000;

            kar2.Nik = 190302124;
            kar2.Nama = "Jono";
            kar2.GajiBulanan = 2000000;

            if (kar1.GajiBulanan<0)
            {
                kar1.GajiBulanan = 0;
            }
            if (kar2.GajiBulanan < 0)
            {
                kar2.GajiBulanan = 0;
            }

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            kar1.gajiawal();
            kar2.gajiawal();

            Console.WriteLine("\nAlhamdulillah dapat kenaikan gaji 10%\n\n");

            Console.WriteLine("Nik Nama                    Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
            kar1.gajiakhir();
            kar2.gajiakhir();

            
            Console.WriteLine(Environment.NewLine+"Tekan Enter untuk Keluar");
            Console.ReadKey();
        }
    }
}