using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rasterizationOrderColorAttachmentAccess;
        public VkBool32 rasterizationOrderDepthAttachmentAccess;
        public VkBool32 rasterizationOrderStencilAttachmentAccess;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT Create()
        {
            VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
