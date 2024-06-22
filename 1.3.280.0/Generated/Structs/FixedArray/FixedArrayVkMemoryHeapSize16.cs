using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkMemoryHeapSize16
    {
        public const int ElementCount = 16;
        public const int ElementSize = 16;
        public const int TotalSizeInBytes = 256;
        public fixed byte _data[256];
        
        public ref VkMemoryHeap this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkMemoryHeapSize16* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkMemoryHeapSize16>(ref this);
                return ref VkUnsafe.PtrToRef<VkMemoryHeap>((VkMemoryHeap*)_thisPtr->_data + idx);
            }
        }
    }
}
