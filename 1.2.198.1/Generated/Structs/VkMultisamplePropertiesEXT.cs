using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxSampleLocationGridSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMultisamplePropertiesEXT Create()
        {
            VkMultisamplePropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
