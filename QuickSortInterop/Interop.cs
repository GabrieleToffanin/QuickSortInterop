using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortInterop
{
    public static unsafe partial class Interop
    {
        /// <summary>
        /// Marhsaling Span<int>
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="arrLen"></param>


        [LibraryImport("QuickSort", EntryPoint = "quickSort")]
        [UnmanagedCallConv (CallConvs = new[] {typeof(CallConvCdecl)})]
        public static partial void QuickSort(Span<int> buffer,int start, int arrLen);
    }
}
