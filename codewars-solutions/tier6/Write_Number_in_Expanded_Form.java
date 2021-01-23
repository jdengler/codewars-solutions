//https://www.codewars.com/kata/5842df8ccbd22792a4000245

import java.util.*;
//import java.util.Collections;

public class Kata
{
    public static String expandedForm(int num)
    {
      List<Integer> nums = new ArrayList<Integer>();
      int power = 10;
      while(num > 0)
      {
        if(num%power != 0)
        {
          nums.add(num%power);
          num -= (num%power);
          power = 10;
        }
        else
        {
          power*=10;
        }
      }
      Collections.reverse(nums);
      String expanded = "";

      for(int x : nums)
        expanded += (x + " + ");

      expanded = expanded.substring(0, expanded.length()-3);
      return expanded;
    }
}
