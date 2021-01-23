//https://www.codewars.com/kata/558fc85d8fd1938afb000014

using System;
using System.Collections;

public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
  {
    //Code here...
    ArrayList al = new ArrayList();

    for(int i = 0; i < numbers.Length; i++)
    {
      al.Add(numbers[i]);
    }

    int min = -1;
    int min2 = -1;
    int index = 0;

    for(int count = 0; count < 2; count++)
    {
      index = 0;

      if(count == 0)
        min = (int) al[0];

      if(count == 1)
        min2 = (int) al[0];

      for(int x = 0; x < al.Count; x++)
      {
        switch(count)
        {
          case(0):
            if((int) al[x] < min)
            {
              min = (int) al[x];
              index = x;
            }
            break;

          case(1):
            if((int) al[x] < min2)
            {
              min2 = (int) al[x];
              index = x;
            }
            break;
        }
      }

      al.RemoveAt(index);
    }

    return min + min2;
  }
}
