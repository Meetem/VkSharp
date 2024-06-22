using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkShaderModuleIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint identifierSize;
        public fixed byte identifier[32];
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkShaderModuleIdentifierEXT Create()
        {
            VkShaderModuleIdentifierEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
