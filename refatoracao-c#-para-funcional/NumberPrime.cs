using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpToFunctional
{
  class NumberPrime
  {
    static void Main(string[] args)
    {
      //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
      //int oddNumbers = numbers.Count(n => n % 2 == 1);

      bool IsPrime(int number)
      {
        return Enumerable.Range(1, number).Count(x => number % x == 0) == 2;
      }

      Console.WriteLine(IsPrime(1));
      Console.ReadKey();

      //bool NOT = (x) => !x;
      //const isNot = NOT
      //const even = (num) => (num % 2)
      //const halfOf = (num) => Math.ceil(num / 2)
      //const disibleBy = (num) => (i) => isNot(num % i)
      //const squareRootOf = (num) => Math.sqrt(num)
      //const isInteger = (num) => Number.isInteger(num)

      //const hasDivisor = (num) => {
      //  const isDisibleBy = disibleBy(num)
      //  for (let i = halfOf(num); i >= 2; i--)
      //  {
      //    if (isDisibleBy(i))
      //    {
      //      return true
      //    }
      //  }
      //  return false
      //}

      //const hasIntegerSquareRoot = (num) =>
      //  (isInteger(squareRootOf(num)))

      //const isEvenAndNot2 = (num) =>
      //  (isNot(even(num)) && (num !== 2))

      //const isPrime = (num) =>
      //  (NOT(isEvenAndNot2(num)) &&
      //   NOT(hasIntegerSquareRoot(num)) &&
      //   NOT(hasDivisor(num)))


      //Console.WriteLine('filter', [2, 3, 4, 5].filter(isPrime))

      // Console.WriteLine('isPrime 2', isPrime(2))
      // Console.WriteLine('isPrime 3', isPrime(3))
      // Console.WriteLine('isPrime 4', isPrime(4))

      // Console.WriteLine('isPrime 100002', isPrime(100002))
      // Console.WriteLine('isPrime 100003', isPrime(100003))
      // Console.WriteLine('isPrime 100007', isPrime(100007))
    }
  }
}
