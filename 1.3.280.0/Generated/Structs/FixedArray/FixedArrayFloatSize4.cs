using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayFloatSize4
    {
        public const int ElementCount = 4;
        public const int ElementSize = 4;
        public const int TotalSizeInBytes = 16;
        public fixed byte _data[16];
        
        public ref float this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayFloatSize4* _thisPtr = VkUnsafe.RefToPtr<FixedArrayFloatSize4>(ref this);
                return ref VkUnsafe.PtrToRef<float>((float*)_thisPtr->_data + idx);
            }
        }
    }
}
