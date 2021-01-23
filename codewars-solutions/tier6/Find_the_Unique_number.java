//https://www.codewars.com/kata/585d7d5adb20cf33cb000235

import java.util.Arrays;
public class Kata {
    public static double findUniq(double arr[]) {
      Arrays.sort(arr);
      if(arr[0] != arr[1])
        return arr[0];
      else
        return arr[arr.length-1];
    }
}
