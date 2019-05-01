using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krywan1 = new Karyawan();
            krywan1.NIK = "123456789";
            krywan1.Nama= "lhya";
            krywan1.GajiBulanan = 40000000;
            
            Karyawan krywan2 = new Karyawan();
            krywan2.NIK = "123876542";
            krywan2.Nama = "lasmita";
            krywan2.GajiBulanan = 50000000;
           
            Console.WriteLine("No. \t\tNIK\t\tNama\t\tGajiBulanan");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1.\t\t{0}\t {1}\t\t{2}", krywan1.NIK, krywan1.Nama, krywan1.GajiBulanan);
            Console.WriteLine("2.\t\t{0}\t {1}\t{2}", krywan2.NIK, krywan2.Nama, krywan2.GajiBulanan);
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("\n\n");
            Console.WriteLine("kenaikan gaji 10%");
            krywan1.GajiBulanan += krywan1.GajiBulanan * 0.1;
            krywan2.GajiBulanan += krywan2.GajiBulanan * 0.1;

            Console.WriteLine("\n");
            Console.WriteLine("No. \t\tNIK\t\tNama\t\tGajiBulanan");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1.\t\t{0}\t {1}\t\t{2}", krywan1.NIK, krywan1.Nama, krywan1.GajiBulanan);
            Console.WriteLine("2.\t\t{0}\t {1}\t{2}", krywan2.NIK, krywan2.Nama, krywan2.GajiBulanan);
            Console.WriteLine("-------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
