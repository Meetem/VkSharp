using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingEnable;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSwapchainDisplayNativeHdrCreateInfoAMD Create()
        {
            VkSwapchainDisplayNativeHdrCreateInfoAMD ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
