import java.lang.Math;

public class DigPow {

  public static long digPow(int n, int p) {
    char[] chars = String.valueOf(n).toCharArray();
    long sum = 0;
    for(char x : chars)
      sum += Math.pow(Character.getNumericValue(x), p++);

    return (sum%n == 0) ? sum/n : -1;
  }

}
