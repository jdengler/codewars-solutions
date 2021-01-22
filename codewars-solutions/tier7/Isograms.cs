using System;

public class Kata
{
  public static bool IsIsogram(string str)
  {
    str = str.ToUpper();
    int[] alpha = new int[26];

    foreach(char c in str)
    {
      alpha[(int)c-65]++;
      if(alpha[(int)c-65] > 1)
        return false;
    }
    return true;
  }
}
