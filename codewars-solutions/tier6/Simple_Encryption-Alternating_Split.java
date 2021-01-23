//https://www.codewars.com/kata/57814d79a56c88e3e0000786

public class Kata {

  public static String encrypt(final String text, final int n) {
    if(n <= 0 || text.length() == 0)
      return (text == null) ? null : text;

    char[] st = text.toCharArray();
    String[] result = {"",""};

    for(int x = 0; x < st.length; x++) {
      int indx = (x+1)%2 == 0 ? 0 : 1;
      result[indx] += st[x];
    }
    return encrypt(result[0] + result[1], n-1);
  }

  public static String decrypt(final String text, final int n) {
    if(n <= 0 || text.length() == 0)
      return (text == null) ? null : text;

    char[] back = text.substring(text.length()/2).toCharArray();
    char[] front = text.substring(0, (text.length()/2)).toCharArray();

    char[] result = new char[text.length()];

    for(int x = 0; x < text.length(); x++)
      result[x] = (x%2 == 0) ? back[x/2] : front[x/2];

    return decrypt(new String(result), n-1);
  }

}
