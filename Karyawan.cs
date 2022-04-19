using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4396
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }

        
        public void gajiawal()
        {
            Console.WriteLine("{0} {1}      {2}", Nik, Nama, GajiBulanan);
        }

        public void gajiakhir()
        {
            Console.WriteLine("{0} {1}      {2}", Nik, Nama, GajiBulanan + GajiBulanan * 10 / 100);
        }
    }
}
