using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class ExcelRapor : SistemRaporlama
    {
        public override void RaporYaz()
        {
            System.Console.WriteLine("Rapor Excel e dosyasına yazılıyor.");
        }
    }
}
