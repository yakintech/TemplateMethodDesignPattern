using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemRaporlama raporlama = null;

            raporlama = new XMLRapor();
            raporlama.RaporHazirla();


            raporlama = new ExcelRapor();
            raporlama.RaporHazirla();

            Console.ReadKey();
        }
    }
}
