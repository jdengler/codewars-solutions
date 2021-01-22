public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    for(int x = 0; x < arr.Length; x++)
    {
      int leftSum = 0;
      int rightSum = 0;

      for(int l = 0; l < x; l++)
      {
        leftSum += arr[l];
      }

      if(x + 1 <= arr.Length-1)
      {
        for(int r = x + 1; r < arr.Length; r++)
        {
          rightSum += arr[r];
        }
      }

      if(leftSum == rightSum)
        return x;

    }

    return -1;
  }
}
