//https://www.codewars.com/kata/57a37f3cbb99449513000cd8

using System;

namespace Solution
{
  public static class Program
  {
    public static int getNumberFromString(string s)
    {
      string res = "";
      foreach(char c in s)
      {
        if(Char.IsNumber(c))
          res += c;
      }
      return Int32.Parse(res);
    }
  }
}
