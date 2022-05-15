using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_notu
{
    public class Ogrenci
    {
        private int vize_1;
        public int vize
        {
            get
            {
                return vize_1;
            }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    vize_1 = value;
                }
                else
                {
                    Console.WriteLine("Girmiş Olduğunuz Vize Notunuz 0-100 aralığında değildir.");
                }
            }
        }
    }
}
