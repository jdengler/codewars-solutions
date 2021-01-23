//https://www.codewars.com/kata/525c7c5ab6aecef16e0001a5

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Parser
{
    public static int ParseInt(string s)
    {
      List<int> nums = GetNums(s.Split(new Char [] {' ', '-'}));

      //if thousand found at index x, need to split list into two arrays from {0 -> x} and {x+1 -> list.Count} and add their sums together
      int kIndex = nums.IndexOf(1000);
      if(kIndex != -1)
      {
        kIndex++;
        int[] half2 = new int[nums.Count-kIndex];
        nums.CopyTo(kIndex, half2, 0, half2.Length);
        nums.RemoveRange(kIndex, half2.Length);

        int[] half1 = nums.ToArray();

        return Sums(half1) + Sums(half2);
      }
      else
      {
        return Sums(nums.ToArray());
      }
    }

    //returns sequentially int-parsed list from input
    public static List<int> GetNums(string[] splt)
    {
        string[,] bases = new string[3, 2] {{"hundred", "100"}, {"thousand", "1000"}, {"million", "1000000"} };
        string[,] ones = new string[13,2] { {"zero", "0"}, {"one", "1"}, {"two", "2"}, {"three", "3"},
                                          {"four", "4"}, {"five", "5"}, {"six", "6"}, {"seven", "7"},
                                          {"eight", "8"}, {"nine", "9"}, {"ten", "10"}, {"eleven", "11"}, {"twelve", "12"}};
        List<int> nums = new List<int>();

        foreach(string s in splt)
        {
          string trim = s.Substring(0,2);
          //number loop
          for(int a = 0; a < 13; a++)
          {
            //if a match, res is parsed
            int res = (ones[a,0] == s) ? int.Parse(ones[a,1]) : -1;

            //trim is first two chars and used to determine if string is 20,30,40,...90 (starts with trim, ends in "ty") or 13-19 (starts with trim, ends in "teen")
            res = (ones[a,0].Contains(trim)) ? (s.Contains("ty") ? int.Parse(ones[a,1])*10 : (s.Contains("teen") ? int.Parse(ones[a,1])+10 : res)) : res;

            //if string was found, add int to list and break to go to next string in splt
            if(res != -1)
            {
              nums.Add(res);
              break;
            }
          }
          //base100 loop
          for(int x = 0; x < 3; x++)
          {
            if(s == bases[x,0])
              nums.Add(int.Parse(bases[x,1]));
          }
        }
        return nums;
    }

    //if n is base100 multiply r by base, else it is a number so add it to sum
    public static int Sums(int[] nums)
    {
      int r = 0;
      foreach(int n in nums)
        r = n%100 == 0 ? r*n : r+n;

      return r;
    }
}
