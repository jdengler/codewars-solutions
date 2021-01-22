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
