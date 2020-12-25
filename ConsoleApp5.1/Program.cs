using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._1
{
    static class Program //Средний уровень
    {
        static void Main(string[] args)
        {
            string S = new String(new char[] { 'Р', 'о', 'с', 'с', 'и', 'я' });
            string s = string.Join(" ", S.ToCharArray());
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
