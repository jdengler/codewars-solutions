public class Kata
{
  public static int TripleDouble(long num1, long num2)
  {
    int prev1 = -1;
    int prev2 = -1;
    while(num1 > 0)
    {
      int x = (int)(num1%10);
      num1/=10;
      if(x == prev1 && x == prev2)
      {
        int prev = (int)(num2%10);
        num2 /= 10;
        while(num2 > 0)
        {
          int y = (int)(num2%10);
          num2/=10;
          if(x == y && prev == y)
          {
            return 1;
          }
          prev = y;
        }
      }
      prev2 = prev1;
      prev1 = x;
    }
    return 0;
  }
}
