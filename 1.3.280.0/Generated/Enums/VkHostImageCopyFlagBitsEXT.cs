using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkHostImageCopyFlagBitsEXT : uint
    {
        VK_HOST_IMAGE_COPY_MEMCPY_EXT = (uint)(0x00000001U),
        VK_HOST_IMAGE_COPY_FLAG_BITS_MAX_ENUM_EXT = (uint)(0x7FFFFFFFU),
    }
}
