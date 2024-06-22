using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceBufferMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateInfo* pCreateInfo;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceBufferMemoryRequirements Create()
        {
            VkDeviceBufferMemoryRequirements ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
