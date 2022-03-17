using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200010
{
    class HaloGeneric
    {
        public static void SapaUser()
        {
            Console.Write("Masukan Nama : ");
            string nama = Console.ReadLine();
            Console.WriteLine("Halo user "+nama);
        }
    }
    class DataGeneric
    {
        static void dataGeneric<T>(T data)
        {
            Console.Write(data);
        }
        public static void printData()
        {
            Console.Write("Data yang tersimpan adalah: ");
            dataGeneric<int>(1302200010);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser();
            DataGeneric.printData();
            Console.ReadKey();
        }
    }
}
