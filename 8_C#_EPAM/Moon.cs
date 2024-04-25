using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_C__EPAM
{
    internal class Moon : HeavenlyBody
    {
        public override void ReportAboutLife()
        {
            Console.WriteLine("Життя вiдсутнє");
        }
        public override void ReportAboutMovement()
        {
            Console.WriteLine("Луна обертається навколо Землi");
        }
    }
}
