using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCuFunctionCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuModuleNVX module;
        public byte* pName;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCuFunctionCreateInfoNVX Create()
        {
            VkCuFunctionCreateInfoNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
