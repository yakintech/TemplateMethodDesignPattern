using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class XMLRapor : SistemRaporlama
    {
        public override void RaporYaz()
        {
            System.Console.WriteLine("Rapor XML e dosyasına yazılıyor.");
        }
    }
}
