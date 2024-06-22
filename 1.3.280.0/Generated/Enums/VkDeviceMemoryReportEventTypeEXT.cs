using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkDeviceMemoryReportEventTypeEXT
    {
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = (int)(0),
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = (int)(1),
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = (int)(2),
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = (int)(3),
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = (int)(4),
        VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_MAX_ENUM_EXT = (int)(2147483647),
    }
}
