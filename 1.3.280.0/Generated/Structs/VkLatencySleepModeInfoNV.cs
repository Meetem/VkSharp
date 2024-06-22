using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLatencySleepModeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 lowLatencyMode;
        public VkBool32 lowLatencyBoost;
        public uint minimumIntervalUs;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLatencySleepModeInfoNV Create()
        {
            VkLatencySleepModeInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
