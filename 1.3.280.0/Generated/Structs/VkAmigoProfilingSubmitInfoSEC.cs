using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkAmigoProfilingSubmitInfoSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong firstDrawTimestamp;
        public ulong swapBufferTimestamp;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkAmigoProfilingSubmitInfoSEC Create()
        {
            VkAmigoProfilingSubmitInfoSEC ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
