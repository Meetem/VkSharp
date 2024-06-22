using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkFenceImportFlags : uint
    {
        VK_FENCE_IMPORT_TEMPORARY_BIT = (uint)(0x00000001U),
        VK_FENCE_IMPORT_TEMPORARY_BIT_KHR = (uint)(0x00000001U),
        VK_FENCE_IMPORT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
