using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2640
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(19112640, "M.Fitratul Iman", 1000000);
            Karyawan karyawan2 = new Karyawan(19112650, "Paijo", 2000000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("------------------------------------");
            karyawan1.BK();
            karyawan2.BK();

            Console.WriteLine("\n Asyiiiiinihh naik gaji nih");
            Console.WriteLine(" ");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("------------------------------------");
            karyawan1.KenaikanGaji();
            karyawan2.KenaikanGaji();

            Console.ReadKey();
        }
    }
    class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gaji < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = gaji;
            }
        }

        public void BK()
        {
            Console.WriteLine("{0} \t {1} \t {2}", NIK, Nama, GajiBulanan);
        }

        public void KenaikanGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", NIK, Nama, GajiBulanan);
        }
    }
}