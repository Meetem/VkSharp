using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkDebugReportObjectTypeEXT
    {
        VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = (int)(0),
        VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = (int)(1),
        VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = (int)(2),
        VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = (int)(3),
        VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = (int)(4),
        VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = (int)(5),
        VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = (int)(6),
        VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = (int)(7),
        VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = (int)(8),
        VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = (int)(9),
        VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = (int)(10),
        VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = (int)(11),
        VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = (int)(12),
        VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = (int)(13),
        VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = (int)(14),
        VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = (int)(15),
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = (int)(16),
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = (int)(17),
        VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = (int)(18),
        VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = (int)(19),
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = (int)(20),
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = (int)(21),
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = (int)(22),
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = (int)(23),
        VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = (int)(24),
        VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = (int)(25),
        VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = (int)(26),
        VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = (int)(27),
        VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = (int)(28),
        VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = (int)(29),
        VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = (int)(30),
        VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = (int)(33),
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = (int)(1000156000),
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = (int)(1000085000),
        VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT = (int)(1000029000),
        VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT = (int)(1000029001),
        VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = (int)(1000150000),
        VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = (int)(1000165000),
        VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT = (int)(1000366000),
        VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT = (int)(28),
        VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT = (int)(33),
        VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT = (int)(1000085000),
        VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT = (int)(1000156000),
        VK_DEBUG_REPORT_OBJECT_TYPE_MAX_ENUM_EXT = (int)(2147483647),
    }
}