using System;

namespace HW5_1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var array = generate(10, -10);
      log(array);
      sort(array);
      log(array);
      sort(array, true);
      log(array);
      
      
      //
      Console.ReadKey();
    }

    private static int[] generate(int length = 10, int min = 0, int max = 10)
    {
      var rand = new Random();
      int[] array = new int[length];
      for (int i = 0; i < length; i++) array[i] = rand.Next(min, max);
      return array;
    }
    private static void log(int[] arr)
    {
      foreach (var a in arr) Console.Write(a + ", ");
      Console.WriteLine();
    }
    private static void sort(int[] arr, bool isFromEnd = false)
    {
      for (int j = 1; j < arr.Length; j++)
      {
        for (int i = 0; i < arr.Length - 1; i++)
        {
          if (!isFromEnd  && (arr[i] > arr[i + 1]))
          {
            int accum = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = accum;
          }
          if (isFromEnd && (arr[i] < arr[i + 1]))
          {
            int accum = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = accum;
          }
        }
      }
    }

   
  }
}