public class Line {
  public static String Tickets(int[] peopleInLine) {
      int[] bal = new int[2];
      for(int x : peopleInLine) {
        switch(x) {
          case(25): bal[0]+=25; break;

          case(50): if(bal[0] >= 25) { bal[0]-=25; bal[1] += 50; break;}
                    else return "NO";


          case(100): if(bal[1] < 50) {
                      if(bal[0] < 75) { return "NO"; }
                      else { bal[0]-=75; break;}
                    }
                    else {
                      if(bal[0] < 25) { return "NO"; }
                      else { bal[0]-=25; bal[1]-=50; break; }
                    }
        }
      }
      return "YES";
  }
}
