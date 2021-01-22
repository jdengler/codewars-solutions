using System;

public class Persist
{
  public static int Persistence(long n)
  {
    if(n.ToString().Length == 1)
      return 0;

    long ne = 1;
    while(n > 1)
    {
      ne *= n%10;
      n /= 10;
    }

    return (1 + Persistence(ne));
  }
}
