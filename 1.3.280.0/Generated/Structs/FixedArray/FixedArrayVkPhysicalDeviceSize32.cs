using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkPhysicalDeviceSize32
    {
        public const int ElementCount = 32;
        public const int ElementSize = 8;
        public const int TotalSizeInBytes = 256;
        public fixed byte _data[256];
        
        public ref VkPhysicalDevice this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkPhysicalDeviceSize32* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkPhysicalDeviceSize32>(ref this);
                return ref VkUnsafe.PtrToRef<VkPhysicalDevice>((VkPhysicalDevice*)_thisPtr->_data + idx);
            }
        }
    }
}
