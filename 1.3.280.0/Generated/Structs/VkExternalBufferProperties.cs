using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkExternalBufferProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkExternalBufferProperties Create()
        {
            VkExternalBufferProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
