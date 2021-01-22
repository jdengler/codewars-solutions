public class PangramChecker {
  public boolean check(String sentence){
    sentence = sentence.toLowerCase();
    char[] split = sentence.toCharArray();
    char[] alpha = new char[26];

    for(char c : split)
    {
      if(c >= 'a' && c <= 'z')
        alpha[c-'a']++;
    }
    for(int x : alpha)
    {
      if(x == 0)
        return false;
    }
    return true;
  }
}
