using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderModuleCreateFlags flags;
        public ulong codeSize;
        public uint* pCode;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkShaderModuleCreateInfo Create()
        {
            VkShaderModuleCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
