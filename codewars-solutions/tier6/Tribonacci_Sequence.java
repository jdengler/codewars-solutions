//https://www.codewars.com/kata/556deca17c58da83c00002db

import java.util.*;

public class Xbonacci {

  public double[] tribonacci(double[] s, int n) {
      double[] seq = new double[n];
      for(int x = 0; x < n; x++)
      {
        if(x == 0 || x == 1 || x == 2)
          seq[x] = s[x];
        else
          seq[x] = seq[x-1] + seq[x-2] + seq[x-3];
      }
      return seq;
  }
}
