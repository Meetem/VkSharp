using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkSparseImageFormatFlags : uint
    {
        VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = (uint)(0x00000001U),
        VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = (uint)(0x00000002U),
        VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = (uint)(0x00000004U),
        VK_SPARSE_IMAGE_FORMAT_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
