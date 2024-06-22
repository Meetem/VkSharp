using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassStripeSubmitInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassStripeSubmitInfoARM Create()
        {
            VkRenderPassStripeSubmitInfoARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
