using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe struct FixedArrayStdVideoAV1FrameRestorationTypeSize3
    {
        public const int ElementCount = 3;
        public const int ElementSize = 4;
        public const int TotalSizeInBytes = 12;
        public fixed byte _data[12];
        
        public ref StdVideoAV1FrameRestorationType this[int idx]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                FixedArrayStdVideoAV1FrameRestorationTypeSize3* _thisPtr = VkUnsafe.RefToPtr<FixedArrayStdVideoAV1FrameRestorationTypeSize3>(ref this);
                return ref VkUnsafe.PtrToRef<StdVideoAV1FrameRestorationType>((StdVideoAV1FrameRestorationType*)_thisPtr->_data + idx);
            }
        }
    }
}
