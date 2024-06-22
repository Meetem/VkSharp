using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [Flags]
    public enum VkStencilFaceFlags : uint
    {
        VK_STENCIL_FACE_FRONT_BIT = (uint)(0x00000001U),
        VK_STENCIL_FACE_BACK_BIT = (uint)(0x00000002U),
        VK_STENCIL_FACE_FRONT_AND_BACK = (uint)(0x00000003U),
        VK_STENCIL_FRONT_AND_BACK = (uint)(0x00000003U),
        VK_STENCIL_FACE_FLAG_BITS_MAX_ENUM = (uint)(0x7FFFFFFFU),
    }
}
