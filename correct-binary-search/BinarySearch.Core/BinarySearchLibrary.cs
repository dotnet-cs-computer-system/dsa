namespace BinarySearch.Core;

public class BinarySearchLibrary
{
    public static int Search(int[] array, int n)
    {
        // low, high, loop
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            
            if (n == array[mid])
            {
                return mid;
            }
            else if (n < array[mid])
            {   
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }
}