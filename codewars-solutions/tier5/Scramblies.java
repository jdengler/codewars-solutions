import java.util.Arrays;
public class Scramblies {

    public static boolean scramble(String str1, String str2) {
        if(str2.length() > str1.length())
          return false;
        char[] one = str1.toCharArray();
        char[] two = str2.toCharArray();
        Arrays.sort(one);
        Arrays.sort(two);

        for(int x = 0; x < str2.length(); x++)
        {
          char search = two[x];
          int foundIndex = -1;
          for(int y = x; y < str1.length(); y++)
          {
            if(one[y] == search)
              foundIndex = y;
          }
          if(foundIndex == -1)
            return false;
        }
        return true;
    }
}
