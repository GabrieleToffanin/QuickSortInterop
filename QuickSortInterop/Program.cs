
using System.Runtime.InteropServices;
using QuickSortInterop;

int[] numerini = { 68, 45, 1, 4, 33, 44, 2,5345,62,34,62457,27,234,57,34567,35678,358,3568,3568 };

unsafe
{
    fixed(int* ptr = &numerini[0])
    {
        Interop.quickSort(ptr, 0, numerini.Length - 1);

        for (int i = 0; i < numerini.Length - 1; i++)
        {
            Console.WriteLine(*(ptr + i));
        }
    }
}
