//https://www.codewars.com/kata/55908aad6620c066bc00002a

using System.Linq;
using System;
public static class Kata
{
  public static bool XO (string input)
  {
    int xCnt = 0;
    int oCnt = 0;

    foreach(char c in input)
    {
      if(c == 'x' || c == 'X')
        xCnt++;

      if(c == 'o' || c == 'O')
        oCnt++;
    }

    if(xCnt == oCnt)
      return true;
    else
      return false;
  }
}
