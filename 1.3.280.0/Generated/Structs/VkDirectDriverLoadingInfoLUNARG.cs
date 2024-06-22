using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectDriverLoadingFlagsLUNARG flags;
        public PFN_vkGetInstanceProcAddrLUNARG pfnGetInstanceProcAddr;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDirectDriverLoadingInfoLUNARG Create()
        {
            VkDirectDriverLoadingInfoLUNARG ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
