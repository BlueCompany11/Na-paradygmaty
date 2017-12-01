using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_paradygmaty
{
    public class Pistolet : IAtak
    {
        public void Atakuj()
        {
            Console.WriteLine("Atakuje cie pistoletem");
        }
    }
}
