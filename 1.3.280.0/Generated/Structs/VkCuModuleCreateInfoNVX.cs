using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCuModuleCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong dataSize;
        public void* pData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCuModuleCreateInfoNVX Create()
        {
            VkCuModuleCreateInfoNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
