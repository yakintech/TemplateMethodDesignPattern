using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    abstract class SistemRaporlama
    {

        public void IstatistikTopla()
        {
            System.Console.WriteLine("İstatistikler ırlanıyor");
        }

        public void KisileriTopla()
        {
            System.Console.WriteLine("Kisiler toplanıyor");
        }

        public abstract void RaporYaz();

        public void RaporHazirla()
        {
            IstatistikTopla();
            KisileriTopla();
            RaporYaz();
        }
    }
}
