using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace komposisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo Relasi Komposisi";
            Mobil mobil = new Mobil();
            mobil.Merk = "BMW";
            Console.WriteLine("Merek mobil: {0}, Tipe mesin: {1}",
            mobil.Merk, mobil.GetlnfoMesin().Type);
            Console.ReadKey();
        }
    }
}
