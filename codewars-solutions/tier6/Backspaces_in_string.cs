public class Kata
{
  public static string CleanString(string s)
  {
    string result = "";
    for(int x = 0; x < s.Length; x++)
    {
      if(s[x] == '#' && result.Length > 0)
      {
        result = result.Remove(result.Length-1, 1);
      }

      if(s[x] != '#')
        result += s[x];
    }
    return result;
  }
}
