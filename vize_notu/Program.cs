using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_notu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen Vize Notunuzu Giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.vize = a;
            Console.WriteLine("Vize Notunuz:"+ogrenci.vize);
            Console.ReadLine();
            
        }
    }
}
