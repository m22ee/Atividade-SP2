using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Senai7.Classes
{
    public class Triangulo : Forma  
    {
        public override void CalcularArea()
        {
            area = base * altura/2;
        }
    }
}