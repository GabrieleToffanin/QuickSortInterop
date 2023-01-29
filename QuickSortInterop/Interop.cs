using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortInterop
{
    public static unsafe partial class Interop
    {
        [LibraryImport("QuickSort")]
        public static partial void quickSort(int* buffer, int start, int arrLen);
    }
}
