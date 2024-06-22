using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkQueueGlobalPriorityEXTSize16
    {
        public const int ElementCount = 16;
        public const int ElementSize = 4;
        public const int TotalSizeInBytes = 64;
        public fixed byte _data[64];
        
        public ref VkQueueGlobalPriorityEXT this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkQueueGlobalPriorityEXTSize16* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkQueueGlobalPriorityEXTSize16>(ref this);
                return ref VkUnsafe.PtrToRef<VkQueueGlobalPriorityEXT>((VkQueueGlobalPriorityEXT*)_thisPtr->_data + idx);
            }
        }
    }
}
