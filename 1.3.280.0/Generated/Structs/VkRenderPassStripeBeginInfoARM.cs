using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassStripeBeginInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeInfoCount;
        public VkRenderPassStripeInfoARM* pStripeInfos;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassStripeBeginInfoARM Create()
        {
            VkRenderPassStripeBeginInfoARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
