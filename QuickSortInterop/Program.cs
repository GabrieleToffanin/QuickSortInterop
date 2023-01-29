
using System.Runtime.InteropServices;
using QuickSortInterop;

List<int> numerini = new List<int>(){ 68, 45, 1, 4, 33, 44, 2,5345,62,34,62457,27,234,57,34567,35678,358,3568,3568 };

Interop.QuickSort(CollectionsMarshal.AsSpan(numerini),0, numerini.Count - 1);

var numb = numerini.ToArray();

for (int i = 0; i < numerini.Count - 1; i++)
{
    Console.WriteLine(
        numb[i]);
}
