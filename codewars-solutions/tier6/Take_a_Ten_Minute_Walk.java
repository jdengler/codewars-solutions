//https://www.codewars.com/kata/54da539698b8a2ad76000228

public class TenMinWalk {
  public static boolean isValid(char[] walk) {
    int x = 0, y = 0;
    for(char c : walk){
      switch(c){
        case('n'): y++; break;
        case('s'): y--; break;
        case('e'): x++; break;
        case('w'): x--; break;
      }
    }
    if((walk.length != 10) || (x != 0) || (y != 0))
      return false;
    else
      return true;
  }
}
