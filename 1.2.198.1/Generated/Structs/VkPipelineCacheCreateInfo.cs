using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPipelineCacheCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCacheCreateFlags flags;
        public ulong initialDataSize;
        public void* pInitialData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPipelineCacheCreateInfo Create()
        {
            VkPipelineCacheCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
