//https://www.codewars.com/kata/550498447451fbbd7600041c

import java.util.*;

public class AreSame {

  public static boolean comp(int[] a, int[] b) {
    if(a == null || b == null || a.length != b.length)
      return false;

    for(int z = 0; z < b.length; z++)
    {
      if(b[z] < 0)
        b[z] *= -1;
      if(a[z] < 0)
        a[z] *= -1;
    }

    Arrays.sort(a);
    Arrays.sort(b);
    for(int x = 0; x < a.length; x++)
    {
      if((a[x] * a[x]) != b[x])
        return false;
    }

    return true;
  }
}
