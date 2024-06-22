using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAccelerationStructureInstanceKHR Create()
        {
            return default;
        }
        
    }
}
