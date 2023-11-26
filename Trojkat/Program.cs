using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Trojkat 
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.Write("Wpisz wartosc przyprostokatnej A: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Wpisz wartosc przyprostokatnej B: ");
        b = double.Parse(Console.ReadLine());
        c = (a * a + b * b);
        Console.WriteLine("Przeciwprostokatna C : {0}", c);
        c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Pierwiastek : {0}", c);
        Console.ReadLine();

    }
}