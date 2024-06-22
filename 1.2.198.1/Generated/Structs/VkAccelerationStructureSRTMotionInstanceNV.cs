using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureSRTMotionInstanceNV
    {
        public VkSRTDataNV transformT0;
        public VkSRTDataNV transformT1;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureSRTMotionInstanceNV Create()
        {
            return default;
        }
        
    }
}
