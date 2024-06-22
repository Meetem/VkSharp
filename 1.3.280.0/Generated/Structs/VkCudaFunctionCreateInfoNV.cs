using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCudaFunctionCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaModuleNV module;
        public byte* pName;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CUDA_FUNCTION_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCudaFunctionCreateInfoNV Create()
        {
            VkCudaFunctionCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
