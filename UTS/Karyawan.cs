using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Karyawan
    {
        public Karyawan()
        {
        }
        public string Nama { get; set; }
        public string NIK { get; set; }
        public double GajiBulanan { get; set; }
       
        public Karyawan(string Na, string N, int GaBu)
        {if(GajiBulanan < 0)
            {
                Console.WriteLine("Gaji diatas 0!");
            }
        else
            {
                Nama = Na;
                GajiBulanan = GaBu;
                NIK = N;
            } 
        }
     }
}

