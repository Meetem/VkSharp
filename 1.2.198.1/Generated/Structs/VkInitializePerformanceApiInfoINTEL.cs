using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pUserData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkInitializePerformanceApiInfoINTEL Create()
        {
            VkInitializePerformanceApiInfoINTEL ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
