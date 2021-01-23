//https://www.codewars.com/kata/54b724efac3d5402db00065e

using System.Text.RegularExpressions;

class MorseCodeDecoder
{
  public static string Decode(string morseCode)
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
