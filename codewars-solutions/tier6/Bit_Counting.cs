using System;
using System.Collections.Generic;

public class Kata
{
  public static int CountBits(int n)
  {

    int cnt = 0;
    int p = 30;

    //Until n is 0
    while(n > 0)
    {
      //find largest bit that fits within n
      while((int)(Math.Pow(2, p)) > n)
      {
        p--;
      }
      //update cnt of bits within n and reduce n by bit size
      cnt++;
      n -= (int)(Math.Pow(2, p));
    }
    return cnt;
  }
}
