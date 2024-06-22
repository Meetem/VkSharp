using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkQueue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSubmit(uint submitCount, VkSubmitInfo* pSubmits, VkFence fence)
        {
            var f = new PFN_vkQueueSubmit(VkLoader.GetFunction(16));
            return f.Call(this, submitCount, pSubmits, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueWaitIdle()
        {
            var f = new PFN_vkQueueWaitIdle(VkLoader.GetFunction(17));
            return f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueBindSparse(uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence)
        {
            var f = new PFN_vkQueueBindSparse(VkLoader.GetFunction(32));
            return f.Call(this, bindInfoCount, pBindInfo, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSubmit2(uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            var f = new PFN_vkQueueSubmit2(VkLoader.GetFunction(185));
            return f.Call(this, submitCount, pSubmits, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueuePresentKHR(in VkPresentInfoKHR pPresentInfo)
        {
            var f = new PFN_vkQueuePresentKHR(VkLoader.GetFunction(221));
            return f.Call(this, in pPresentInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSubmit2KHR(uint submitCount, VkSubmitInfo2* pSubmits, VkFence fence)
        {
            var f = new PFN_vkQueueSubmit2KHR(VkLoader.GetFunction(329));
            return f.Call(this, submitCount, pSubmits, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetQueueCheckpointData2NV(ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            var f = new PFN_vkGetQueueCheckpointData2NV(VkLoader.GetFunction(331));
            f.Call(this, ref pCheckpointDataCount, pCheckpointData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueBeginDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkQueueBeginDebugUtilsLabelEXT(VkLoader.GetFunction(398));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueEndDebugUtilsLabelEXT()
        {
            var f = new PFN_vkQueueEndDebugUtilsLabelEXT(VkLoader.GetFunction(399));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueInsertDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkQueueInsertDebugUtilsLabelEXT(VkLoader.GetFunction(400));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetQueueCheckpointDataNV(ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            var f = new PFN_vkGetQueueCheckpointDataNV(VkLoader.GetFunction(440));
            f.Call(this, ref pCheckpointDataCount, pCheckpointData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSetPerformanceConfigurationINTEL(VkPerformanceConfigurationINTEL configuration)
        {
            var f = new PFN_vkQueueSetPerformanceConfigurationINTEL(VkLoader.GetFunction(448));
            return f.Call(this, configuration);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueNotifyOutOfBandNV(in VkOutOfBandQueueTypeInfoNV pQueueTypeInfo)
        {
            var f = new PFN_vkQueueNotifyOutOfBandNV(VkLoader.GetFunction(596));
            f.Call(this, in pQueueTypeInfo);
        }
    }
}
