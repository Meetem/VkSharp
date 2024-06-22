using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayVkFragmentShadingRateCombinerOpKHRSize2
    {
        public const int ElementCount = 2;
        public const int ElementSize = 4;
        public const int TotalSizeInBytes = 8;
        public fixed byte _data[8];
        
        public ref VkFragmentShadingRateCombinerOpKHR this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayVkFragmentShadingRateCombinerOpKHRSize2* _thisPtr = VkUnsafe.RefToPtr<FixedArrayVkFragmentShadingRateCombinerOpKHRSize2>(ref this);
                return ref VkUnsafe.PtrToRef<VkFragmentShadingRateCombinerOpKHR>((VkFragmentShadingRateCombinerOpKHR*)_thisPtr->_data + idx);
            }
        }
    }
}
