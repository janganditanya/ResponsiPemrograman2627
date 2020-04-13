using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2627 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1.", "190302124", "Riki", 3000000);
            Karyawan karyawan2 = new Karyawan("2.", "190302123", "Maru", 2000000);

            Console.WriteLine("No. NIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------");

            karyawan1.GetData();
            karyawan2.GetData();

            Console.WriteLine("\nAseeeek Naik Gaji 10%!!!\n");
            Console.WriteLine("No. NIK/Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------");

            karyawan1.GetDataNaik();
            karyawan2.GetDataNaik();

            Console.ReadKey();
        }
    }
}
