using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkValidationFlagsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkValidationFlagsEXT Create()
        {
            VkValidationFlagsEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
