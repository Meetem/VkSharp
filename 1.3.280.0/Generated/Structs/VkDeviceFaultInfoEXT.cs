using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceFaultInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte description[256];
        public VkDeviceFaultAddressInfoEXT* pAddressInfos;
        public VkDeviceFaultVendorInfoEXT* pVendorInfos;
        public void* pVendorBinaryData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceFaultInfoEXT Create()
        {
            VkDeviceFaultInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
