using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool IsPrime(int n)
  {
    //no primes below 2
    if(n <= 1)
      return false;

    //factors come in pairs and square root of number is the max of lower half of pairs
    int factors = 0;
    int max = (int) Math.Sqrt(n);

    for(int f = 1; f <= max; f++)
      if(n%f == 0)  // if n is divisible by f, add 2 factors
        factors += 2;

    //primes only have 2 factors
    if(factors > 2)
      return false;
    else
      return true;
  }
}
