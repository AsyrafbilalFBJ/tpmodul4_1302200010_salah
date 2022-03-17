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
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser();
        }
    }
}
