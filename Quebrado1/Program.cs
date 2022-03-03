﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quebrado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fracción A = new Fracción(1,2);
            Fracción B = new Fracción("B",3, 4);
            Fracción C = A.Multiplicacion(B);
            Fracción D = A / B;
            C.NombreOperando = "A*B";
            D.NombreOperando = "A/B";
            Console.WriteLine($""); 
            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.WriteLine(D.ToString());
            Console.ReadLine();
        }
    }
}
