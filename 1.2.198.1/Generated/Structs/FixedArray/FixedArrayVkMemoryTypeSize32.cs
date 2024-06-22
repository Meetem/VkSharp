using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkMemoryTypeSize32
    {
        public const int ElementCount = 32;
        public const int ElementSize = 8;
        public const int TotalSizeInBytes = 256;
        public fixed byte _data[256];
        
        public ref VkMemoryType this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkMemoryTypeSize32* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkMemoryTypeSize32>(ref this);
                return ref VkUnsafe.PtrToRef<VkMemoryType>((VkMemoryType*)_thisPtr->_data + idx);
            }
        }
    }
}
