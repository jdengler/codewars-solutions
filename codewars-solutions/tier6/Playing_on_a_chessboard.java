public class Suite2 {

  public static String game(long n) {
    if(n%2 == 1)
      return "[" + (n*n) + ", " + 2 + "]";
    return "[" + (n*n)/2 + "]";
  }
}
