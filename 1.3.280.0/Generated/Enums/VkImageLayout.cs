using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkImageLayout
    {
        VK_IMAGE_LAYOUT_UNDEFINED = (int)(0),
        VK_IMAGE_LAYOUT_GENERAL = (int)(1),
        VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = (int)(2),
        VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = (int)(3),
        VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = (int)(4),
        VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = (int)(5),
        VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = (int)(6),
        VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = (int)(7),
        VK_IMAGE_LAYOUT_PREINITIALIZED = (int)(8),
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = (int)(1000117000),
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = (int)(1000117001),
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = (int)(1000241000),
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = (int)(1000241001),
        VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = (int)(1000241002),
        VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = (int)(1000241003),
        VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = (int)(1000314000),
        VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = (int)(1000314001),
        VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = (int)(1000001002),
        VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = (int)(1000024000),
        VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = (int)(1000024001),
        VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = (int)(1000024002),
        VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = (int)(1000111000),
        VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = (int)(1000218000),
        VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = (int)(1000164003),
        VK_IMAGE_LAYOUT_RENDERING_LOCAL_READ_KHR = (int)(1000232000),
        VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = (int)(1000299000),
        VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = (int)(1000299001),
        VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = (int)(1000299002),
        VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = (int)(1000339000),
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = (int)(1000117000),
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = (int)(1000117001),
        VK_IMAGE_LAYOUT_SHADING_RATE_OPTIMAL_NV = (int)(1000164003),
        VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL_KHR = (int)(1000241000),
        VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL_KHR = (int)(1000241001),
        VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL_KHR = (int)(1000241002),
        VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL_KHR = (int)(1000241003),
        VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL_KHR = (int)(1000314000),
        VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL_KHR = (int)(1000314001),
        VK_IMAGE_LAYOUT_MAX_ENUM = (int)(2147483647),
    }
}
