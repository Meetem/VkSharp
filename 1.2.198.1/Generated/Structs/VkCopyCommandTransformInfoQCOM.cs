using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCopyCommandTransformInfoQCOM Create()
        {
            VkCopyCommandTransformInfoQCOM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
