using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDepthStencilResolveProperties Create()
        {
            VkPhysicalDeviceDepthStencilResolveProperties ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
