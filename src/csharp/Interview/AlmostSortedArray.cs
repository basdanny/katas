namespace Interview
{
    /*
     *  Sort an almost sorted array where only two elements are swapped 
     */
    public class AlmostSortedArray
    {
        public static void SortByOneSwap(int[] arr)
        {
            int n = arr.Length;

            for (int i = n-1; i > 0; i--)
            {
                if (arr[i] < arr[i-1])
                {
                    int j = i - 1;
                    while (j > 0 && arr[i] < arr[j])
                        j--;

                    //do the swap
                    int temp = arr[i];
                    arr[i] = arr[j+1];
                    arr[j+1] = temp;                    
                }
            }
        }
    }
}
