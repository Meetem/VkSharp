using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkQueueGlobalPriorityKHRSize16
    {
        public const int ElementCount = 16;
        public const int ElementSize = 4;
        public const int TotalSizeInBytes = 64;
        public fixed byte _data[64];
        
        public ref VkQueueGlobalPriorityKHR this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkQueueGlobalPriorityKHRSize16* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkQueueGlobalPriorityKHRSize16>(ref this);
                return ref VkUnsafe.PtrToRef<VkQueueGlobalPriorityKHR>((VkQueueGlobalPriorityKHR*)_thisPtr->_data + idx);
            }
        }
    }
}
