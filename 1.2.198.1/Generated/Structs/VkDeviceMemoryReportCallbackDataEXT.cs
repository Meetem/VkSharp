using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemoryReportFlagsEXT flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong memoryObjectId;
        public ulong size;
        public VkObjectType objectType;
        public ulong objectHandle;
        public uint heapIndex;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceMemoryReportCallbackDataEXT Create()
        {
            VkDeviceMemoryReportCallbackDataEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
