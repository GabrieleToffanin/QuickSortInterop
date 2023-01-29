using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortInterop
{
    [CustomMarshaller(typeof(Span<>), MarshalMode.Default, typeof(SpanMarshaller<>))]
    internal static unsafe class SpanMarshaller<T>
    {
        public static int* ConvertToUnmanaged(Span<int> span)
        {
            fixed (void* p_buffer = &SpanMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(span))
            {
                return (int*)p_buffer;
            }
        }
    }
}
