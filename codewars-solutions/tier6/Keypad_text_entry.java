//https://www.codewars.com/kata/54a2e93b22d236498400134b

public class Keypad {
  public static int presses(String phrase) {
    int[][] taps = {/*one*/   {32, 42, 35, 49, 65, 68, 71, 74, 77, 80, 84, 87},
                    /*two*/   {48, 66, 69, 72, 75, 78, 81, 85, 88},
                    /*three*/ {67, 70, 73, 76, 79, 82, 86, 89},
                    /*four*/  {50, 51, 52, 53, 54, 56, 83, 90},
                    /*five*/  {55, 57, 59}};

    int press = 0;
    char[] phr = phrase.toCharArray();

    for(char c : phr) {
      c = Character.toUpperCase(c);
      for(int x = 0; x < 5; x++)
        for(int y = 0; y < taps[x].length; y++)
          press += (int) c == taps[x][y] ? (x+1) : 0;
    }
    return press;
  }
}
