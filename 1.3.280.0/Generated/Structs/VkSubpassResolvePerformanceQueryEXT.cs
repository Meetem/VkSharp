using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSubpassResolvePerformanceQueryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 optimal;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSubpassResolvePerformanceQueryEXT Create()
        {
            VkSubpassResolvePerformanceQueryEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
