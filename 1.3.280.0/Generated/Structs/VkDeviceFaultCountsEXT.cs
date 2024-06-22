using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceFaultCountsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint addressInfoCount;
        public uint vendorInfoCount;
        public ulong vendorBinarySize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceFaultCountsEXT Create()
        {
            VkDeviceFaultCountsEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
