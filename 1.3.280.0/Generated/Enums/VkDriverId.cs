using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkDriverId
    {
        VK_DRIVER_ID_AMD_PROPRIETARY = (int)(1),
        VK_DRIVER_ID_AMD_OPEN_SOURCE = (int)(2),
        VK_DRIVER_ID_MESA_RADV = (int)(3),
        VK_DRIVER_ID_NVIDIA_PROPRIETARY = (int)(4),
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = (int)(5),
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = (int)(6),
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY = (int)(7),
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY = (int)(8),
        VK_DRIVER_ID_ARM_PROPRIETARY = (int)(9),
        VK_DRIVER_ID_GOOGLE_SWIFTSHADER = (int)(10),
        VK_DRIVER_ID_GGP_PROPRIETARY = (int)(11),
        VK_DRIVER_ID_BROADCOM_PROPRIETARY = (int)(12),
        VK_DRIVER_ID_MESA_LLVMPIPE = (int)(13),
        VK_DRIVER_ID_MOLTENVK = (int)(14),
        VK_DRIVER_ID_COREAVI_PROPRIETARY = (int)(15),
        VK_DRIVER_ID_JUICE_PROPRIETARY = (int)(16),
        VK_DRIVER_ID_VERISILICON_PROPRIETARY = (int)(17),
        VK_DRIVER_ID_MESA_TURNIP = (int)(18),
        VK_DRIVER_ID_MESA_V3DV = (int)(19),
        VK_DRIVER_ID_MESA_PANVK = (int)(20),
        VK_DRIVER_ID_SAMSUNG_PROPRIETARY = (int)(21),
        VK_DRIVER_ID_MESA_VENUS = (int)(22),
        VK_DRIVER_ID_MESA_DOZEN = (int)(23),
        VK_DRIVER_ID_MESA_NVK = (int)(24),
        VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA = (int)(25),
        VK_DRIVER_ID_MESA_AGXV = (int)(26),
        VK_DRIVER_ID_AMD_PROPRIETARY_KHR = (int)(1),
        VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = (int)(2),
        VK_DRIVER_ID_MESA_RADV_KHR = (int)(3),
        VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = (int)(4),
        VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = (int)(5),
        VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = (int)(6),
        VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = (int)(7),
        VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = (int)(8),
        VK_DRIVER_ID_ARM_PROPRIETARY_KHR = (int)(9),
        VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = (int)(10),
        VK_DRIVER_ID_GGP_PROPRIETARY_KHR = (int)(11),
        VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = (int)(12),
        VK_DRIVER_ID_MAX_ENUM = (int)(2147483647),
    }
}
