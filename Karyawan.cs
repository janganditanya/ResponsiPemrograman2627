using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2627 
{
    public class Karyawan 
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public double GajiBulanan { get; set; }
        public string No { get; set; }

        public void GetData() 
        {
            Console.WriteLine("{0} {1} {2}\t{3}", No, NIK, Nama, GajiBulanan);
        }

        public void GetDataNaik() 
        {
            double temp;
            temp = GajiBulanan * 0.1;
            GajiBulanan += Convert.ToInt32(temp);
            Console.WriteLine("{0} {1} {2}\t{3}", No, NIK, Nama, GajiBulanan);
        }

        public Karyawan(string no, string nik, string nama, double gajibulanan) 
        {
            No = no;
            NIK = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;

            if (GajiBulanan < 0) 
            {
                GajiBulanan = 0;
            }
        }
    }
}
