namespace CodeKataSortingApp;

public class MergeSort : ISortingStrategy
{
    public static int[] MSort(int[] array, int left, int right)
    {
        
        if (left<right)
        {    
            int mid = (left + right) / 2;
            MSort(array, left, mid);
            MSort(array, mid + 1, right);   
        }
       return Merge(array, left, mid, right);    
    }

    public int[] Sort(int[] array)
    {
        throw new NotImplementedException();
    }

    public static int[] Merge(int[] array, int left, int mid, int right)
    {
        int l = 0;
        int r = mid+1;
        for(int i = left; i<right; i++)
        {
            if(l == array[left..mid].Length-1)
            {
                array[i] = array[r]; 
                r++;
            }
            else if (r == array[r..right].Length-1)
            {
                array[i] = array[l];
            }
            else if(array[l] <= array[r])
            {
                array[i] = array[l];
                l++;
            }
            else
            {
                array[i] = array[r];
                r++;
            }
        }
        return array;
    }
}
