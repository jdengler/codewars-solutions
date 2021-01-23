//https://www.codewars.com/kata/52223df9e8f98c7aa7000062

using System;

public class Kata
{
  public static string Rot13(string input)
  {
    string output = "";
    foreach(char c in input)
    {
      int redux = Char.IsLower(c) ? 97 : 65;
      char x = ((int)(c - redux)) >= 13 ? (char)(c-13) : (char)(c+13);
      output += Char.IsLetter(c) ? x : c;
    }

    return output;
  }
}
