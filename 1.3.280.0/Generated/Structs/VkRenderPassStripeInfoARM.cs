using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassStripeInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D stripeArea;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassStripeInfoARM Create()
        {
            VkRenderPassStripeInfoARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
