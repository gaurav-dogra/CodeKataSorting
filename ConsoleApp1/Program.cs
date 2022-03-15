using System;

public class Program
{
    static void Main(string[] args)
    {

        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Program program = new();
        program.Divide(array, 0, array.Length);
    }

    private void Divide(int[] array, int left, int right)
    {
        //List<int> nums = array[left..(right + 1)].ToList();
        //nums.ForEach(x => Console.Write($"{x} "));
        //Console.WriteLine("\n=================================");

        if (left < right)
        {
            int mid = (left + right) / 2; //3
            Divide(array, left, mid);
            Divide(array, mid+1, right);
            Merge(array, left, right, mid);
        }
        //else
        //{
        //    return;
        //}
    }

    private void Merge(int[] array, int left, int right, int mid)
    {
        int[] array1 = array[left..(mid+1)];
        int[] array2 = array[(mid+2)..(right-1)];
        int array1Tracker = 0;
        int array2Tracker = 0;

        List<int> array1List = array1.ToList();
        array1List.ForEach(x => Console.Write($"{x} "));
        Console.WriteLine("\n=================================");
        List<int> array2List = array2.ToList();
        array2List.ForEach(x => Console.Write($"{x} "));
        Console.WriteLine("\n=================================");

    }
}