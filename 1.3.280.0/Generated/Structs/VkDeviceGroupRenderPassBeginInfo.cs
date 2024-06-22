using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public VkRect2D* pDeviceRenderAreas;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceGroupRenderPassBeginInfo Create()
        {
            VkDeviceGroupRenderPassBeginInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
