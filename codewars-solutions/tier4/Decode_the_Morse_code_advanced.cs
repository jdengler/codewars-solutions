using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class MorseCodeDecoder
{

    public static string DecodeBits(string bits)
    {
        bits = bits.TrimStart('0');
        bits = bits.TrimEnd('0');

        //Get indices of each change of input (0 or 1)
        List<int> gapIndices = new List<int>();
        gapIndices.Add(0);
        char prev = bits[0];
        for(int i = 1; i < bits.Length; i++)
        {
          if(bits[i] != prev)
          {
            gapIndices.Add(i);
          }
          prev = bits[i];
        }

        //Split original string into each segment and add to list
        List<string> delin = new List<string>();
        int[] g = gapIndices.ToArray();
        for(int x = 0; x < g.Length-1; x++)
        {
          delin.Add(bits.Substring(g[x], (g[x+1]-g[x])));
        }
        delin.Add(bits.Substring(g[g.Length-1]));

        //Get timeUnit by getting GCD of all the lengths of delineated string
        List<int> lens = new List<int>();
        foreach(string str in delin)
        {
          lens.Add(str.Length);
        }
        int timeUnit = findGCD(lens.ToArray(), lens.Count);

        //Appends corresponding input ('.', '-', ' ', or "   ") to result string
        string result = "";
        foreach(string s in delin)
        {
          if(s.Length%7 == 0 && timeUnit*7 == s.Length)
          {
            result += "   ";
          }
          else if(s.Length%3 == 0 && timeUnit*3 == s.Length)
          {
            if(s.Contains('1'))
              result += '-';
            else
              result += ' ';
          }
          else
          {
            if(s.Contains('1'))
              result += '.';
          }
        }
        return result;
    }

    //GCD method
    static int gcd(int a, int b)
    {
        if (a == 0)
          return b;
        return gcd(b%a, a);
    }

    //GCD method
    static int findGCD(int[] arr, int n)
    {
        int result = arr[0];
        for (int i = 1; i < n; i++)
        {
          result = gcd(arr[i], result);
          if(result == 1)
            return 1;
        }
        return result;
    }

    //Decodes morse code string
    public static string DecodeMorse(string morseCode)
    {
        string[] words = Regex.Split(morseCode, "   ");
        string result = "";

        foreach(string w in words)
        {
          string[] chars = w.Split(' ');

          foreach(string c in chars)
            result += MorseCode.Get(c);

          result += " ";
        }
        return result.Trim();
    }
}
