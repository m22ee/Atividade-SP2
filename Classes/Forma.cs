using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Senai7.Classes
{
    public abstract class Forma
    {
        public double base { get; set;}
        public double altura { get; set; }
	    public double area { get; set; }
	    public virtual void CalcularArea()
        {
            area = base * altura;
        } 
    }
}