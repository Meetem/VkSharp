using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkOffset3DSize2
    {
        public const int ElementCount = 2;
        public const int ElementSize = 12;
        public const int TotalSizeInBytes = 24;
        public fixed byte _data[24];
        
        public ref VkOffset3D this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkOffset3DSize2* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkOffset3DSize2>(ref this);
                return ref VkUnsafe.PtrToRef<VkOffset3D>((VkOffset3D*)_thisPtr->_data + idx);
            }
        }
    }
}
