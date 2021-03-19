using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld17
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(new int[] { 2, 3 }); // Forma compacta de instanciar um vetor e colocar os dados nele.
            int s2 = Calculator.Sum(3, 5, 4, 1); // usando o 'params' na class, não é preciso mais instanciar o array, colocando somente os números entre os parênteses '()'.

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            Console.ReadLine();
        }
    }
}
