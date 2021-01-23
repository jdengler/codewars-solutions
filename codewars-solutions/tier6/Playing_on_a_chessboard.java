//https://www.codewars.com/kata/55ab4f980f2d576c070000f4

public class Suite2 {

  public static String game(long n) {
    if(n%2 == 1)
      return "[" + (n*n) + ", " + 2 + "]";
    return "[" + (n*n)/2 + "]";
  }
}
