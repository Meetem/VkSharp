using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV type;
        public VkAccelerationStructureMotionInstanceFlagsNV flags;
        public VkAccelerationStructureMotionInstanceDataNV data;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureMotionInstanceNV Create()
        {
            return default;
        }
        
    }
}
