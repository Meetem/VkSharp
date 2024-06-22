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
        public VkResult vkQueuePresentKHR(in VkPresentInfoKHR pPresentInfo)
        {
            var f = new PFN_vkQueuePresentKHR(VkLoader.GetFunction(184));
            return f.Call(this, in pPresentInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSubmit2KHR(uint submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence)
        {
            var f = new PFN_vkQueueSubmit2KHR(VkLoader.GetFunction(272));
            return f.Call(this, submitCount, pSubmits, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetQueueCheckpointData2NV(ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData)
        {
            var f = new PFN_vkGetQueueCheckpointData2NV(VkLoader.GetFunction(274));
            f.Call(this, ref pCheckpointDataCount, pCheckpointData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueBeginDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkQueueBeginDebugUtilsLabelEXT(VkLoader.GetFunction(324));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueEndDebugUtilsLabelEXT()
        {
            var f = new PFN_vkQueueEndDebugUtilsLabelEXT(VkLoader.GetFunction(325));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkQueueInsertDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkQueueInsertDebugUtilsLabelEXT(VkLoader.GetFunction(326));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetQueueCheckpointDataNV(ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData)
        {
            var f = new PFN_vkGetQueueCheckpointDataNV(VkLoader.GetFunction(365));
            f.Call(this, ref pCheckpointDataCount, pCheckpointData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkQueueSetPerformanceConfigurationINTEL(VkPerformanceConfigurationINTEL configuration)
        {
            var f = new PFN_vkQueueSetPerformanceConfigurationINTEL(VkLoader.GetFunction(373));
            return f.Call(this, configuration);
        }
    }
}
