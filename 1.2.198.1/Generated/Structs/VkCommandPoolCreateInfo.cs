using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCommandPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPoolCreateFlags flags;
        public uint queueFamilyIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCommandPoolCreateInfo Create()
        {
            VkCommandPoolCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
