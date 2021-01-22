using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    List<string> newWords = new List<string>();

    foreach(string s in words)
    {
      if(AnagramCheck(word, s) == true)
        newWords.Add(s);
    }
    return newWords;
  }

  public static bool AnagramCheck(string one, string two)
  {
    if(one.Length != two.Length)
      return false;

    char[] oneArr = one.ToCharArray();
    Array.Sort(oneArr);
    char[] twoArr = two.ToCharArray();
    Array.Sort(twoArr);

    for(int i = 0; i < one.Length; i++)
    {
      if(oneArr[i] != twoArr[i])
        return false;
    }
    return true;
  }
}
