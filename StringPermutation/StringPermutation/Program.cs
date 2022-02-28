using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string word = Console.ReadLine();

            Permutation obj = new Permutation();

            Console.WriteLine(obj.CheckPermutation(word));
            Console.ReadKey();
        }
    }
}
