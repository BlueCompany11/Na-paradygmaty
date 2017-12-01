using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_paradygmaty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAtak> bronieDoAtaku = new List<IAtak>();
            bronieDoAtaku.Add(new Kusza());
            bronieDoAtaku.Add(new Noz());
            bronieDoAtaku.Add(new Pistolet());
            foreach (var item in bronieDoAtaku)
            {
                item.Atakuj();
            }
            Console.ReadKey();
        }
    }
}
