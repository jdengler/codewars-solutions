import java.util.ArrayList;

class Metro {

  public static int countPassengers(ArrayList<int[]> stops) {
    int count = 0;
    for(int[] x : stops)
    {
      count += x[0];
      count -= x[1];
    }
    return count;
  }
}
