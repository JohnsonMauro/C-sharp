using System;
using System.Linq;

namespace cSharpToFunctional
{
  class NumberPrime
  {
    static void Main(string[] args)
    {
      bool IsPrime(int number)
      {
        return Enumerable.Range(1, number).Count(x => number % x == 0) == 2;
      }

      Console.WriteLine(IsPrime(1));
      Console.ReadKey();
    }
  }
}
