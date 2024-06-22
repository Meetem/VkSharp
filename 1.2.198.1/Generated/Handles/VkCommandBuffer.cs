using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkCommandBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBeginCommandBuffer(in VkCommandBufferBeginInfo pBeginInfo)
        {
            var f = new PFN_vkBeginCommandBuffer(VkLoader.GetFunction(88));
            return f.Call(this, in pBeginInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEndCommandBuffer()
        {
            var f = new PFN_vkEndCommandBuffer(VkLoader.GetFunction(89));
            return f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkResetCommandBuffer(VkCommandBufferResetFlags flags)
        {
            var f = new PFN_vkResetCommandBuffer(VkLoader.GetFunction(90));
            return f.Call(this, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindPipeline(VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
        {
            var f = new PFN_vkCmdBindPipeline(VkLoader.GetFunction(91));
            f.Call(this, pipelineBindPoint, pipeline);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetViewport(uint firstViewport, uint viewportCount, VkViewport* pViewports)
        {
            var f = new PFN_vkCmdSetViewport(VkLoader.GetFunction(92));
            f.Call(this, firstViewport, viewportCount, pViewports);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetScissor(uint firstScissor, uint scissorCount, VkRect2D* pScissors)
        {
            var f = new PFN_vkCmdSetScissor(VkLoader.GetFunction(93));
            f.Call(this, firstScissor, scissorCount, pScissors);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetLineWidth(float lineWidth)
        {
            var f = new PFN_vkCmdSetLineWidth(VkLoader.GetFunction(94));
            f.Call(this, lineWidth);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            var f = new PFN_vkCmdSetDepthBias(VkLoader.GetFunction(95));
            f.Call(this, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetBlendConstants(FixedArrayFloatSize4 blendConstants)
        {
            var f = new PFN_vkCmdSetBlendConstants(VkLoader.GetFunction(96));
            f.Call(this, blendConstants);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            var f = new PFN_vkCmdSetDepthBounds(VkLoader.GetFunction(97));
            f.Call(this, minDepthBounds, maxDepthBounds);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetStencilCompareMask(VkStencilFaceFlags faceMask, uint compareMask)
        {
            var f = new PFN_vkCmdSetStencilCompareMask(VkLoader.GetFunction(98));
            f.Call(this, faceMask, compareMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetStencilWriteMask(VkStencilFaceFlags faceMask, uint writeMask)
        {
            var f = new PFN_vkCmdSetStencilWriteMask(VkLoader.GetFunction(99));
            f.Call(this, faceMask, writeMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetStencilReference(VkStencilFaceFlags faceMask, uint reference)
        {
            var f = new PFN_vkCmdSetStencilReference(VkLoader.GetFunction(100));
            f.Call(this, faceMask, reference);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindDescriptorSets(VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets)
        {
            var f = new PFN_vkCmdBindDescriptorSets(VkLoader.GetFunction(101));
            f.Call(this, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, dynamicOffsetCount, pDynamicOffsets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindIndexBuffer(VkBuffer buffer, ulong offset, VkIndexType indexType)
        {
            var f = new PFN_vkCmdBindIndexBuffer(VkLoader.GetFunction(102));
            f.Call(this, buffer, offset, indexType);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindVertexBuffers(uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets)
        {
            var f = new PFN_vkCmdBindVertexBuffers(VkLoader.GetFunction(103));
            f.Call(this, firstBinding, bindingCount, pBuffers, in pOffsets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDraw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            var f = new PFN_vkCmdDraw(VkLoader.GetFunction(104));
            f.Call(this, vertexCount, instanceCount, firstVertex, firstInstance);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            var f = new PFN_vkCmdDrawIndexed(VkLoader.GetFunction(105));
            f.Call(this, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndirect(VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndirect(VkLoader.GetFunction(106));
            f.Call(this, buffer, offset, drawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndexedIndirect(VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndexedIndirect(VkLoader.GetFunction(107));
            f.Call(this, buffer, offset, drawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDispatch(uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            var f = new PFN_vkCmdDispatch(VkLoader.GetFunction(108));
            f.Call(this, groupCountX, groupCountY, groupCountZ);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDispatchIndirect(VkBuffer buffer, ulong offset)
        {
            var f = new PFN_vkCmdDispatchIndirect(VkLoader.GetFunction(109));
            f.Call(this, buffer, offset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyBuffer(VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions)
        {
            var f = new PFN_vkCmdCopyBuffer(VkLoader.GetFunction(110));
            f.Call(this, srcBuffer, dstBuffer, regionCount, pRegions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyImage(VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions)
        {
            var f = new PFN_vkCmdCopyImage(VkLoader.GetFunction(111));
            f.Call(this, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBlitImage(VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter)
        {
            var f = new PFN_vkCmdBlitImage(VkLoader.GetFunction(112));
            f.Call(this, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions, filter);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyBufferToImage(VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions)
        {
            var f = new PFN_vkCmdCopyBufferToImage(VkLoader.GetFunction(113));
            f.Call(this, srcBuffer, dstImage, dstImageLayout, regionCount, pRegions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyImageToBuffer(VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions)
        {
            var f = new PFN_vkCmdCopyImageToBuffer(VkLoader.GetFunction(114));
            f.Call(this, srcImage, srcImageLayout, dstBuffer, regionCount, pRegions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdUpdateBuffer(VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData)
        {
            var f = new PFN_vkCmdUpdateBuffer(VkLoader.GetFunction(115));
            f.Call(this, dstBuffer, dstOffset, dataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdFillBuffer(VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data)
        {
            var f = new PFN_vkCmdFillBuffer(VkLoader.GetFunction(116));
            f.Call(this, dstBuffer, dstOffset, size, data);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdClearColorImage(VkImage image, VkImageLayout imageLayout, in VkClearColorValue pColor, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            var f = new PFN_vkCmdClearColorImage(VkLoader.GetFunction(117));
            f.Call(this, image, imageLayout, in pColor, rangeCount, pRanges);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdClearDepthStencilImage(VkImage image, VkImageLayout imageLayout, in VkClearDepthStencilValue pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges)
        {
            var f = new PFN_vkCmdClearDepthStencilImage(VkLoader.GetFunction(118));
            f.Call(this, image, imageLayout, in pDepthStencil, rangeCount, pRanges);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdClearAttachments(uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects)
        {
            var f = new PFN_vkCmdClearAttachments(VkLoader.GetFunction(119));
            f.Call(this, attachmentCount, pAttachments, rectCount, pRects);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdResolveImage(VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions)
        {
            var f = new PFN_vkCmdResolveImage(VkLoader.GetFunction(120));
            f.Call(this, srcImage, srcImageLayout, dstImage, dstImageLayout, regionCount, pRegions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetEvent(VkEvent _event, VkPipelineStageFlags stageMask)
        {
            var f = new PFN_vkCmdSetEvent(VkLoader.GetFunction(121));
            f.Call(this, _event, stageMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdResetEvent(VkEvent _event, VkPipelineStageFlags stageMask)
        {
            var f = new PFN_vkCmdResetEvent(VkLoader.GetFunction(122));
            f.Call(this, _event, stageMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWaitEvents(uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            var f = new PFN_vkCmdWaitEvents(VkLoader.GetFunction(123));
            f.Call(this, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPipelineBarrier(VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers)
        {
            var f = new PFN_vkCmdPipelineBarrier(VkLoader.GetFunction(124));
            f.Call(this, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginQuery(VkQueryPool queryPool, uint query, VkQueryControlFlags flags)
        {
            var f = new PFN_vkCmdBeginQuery(VkLoader.GetFunction(125));
            f.Call(this, queryPool, query, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndQuery(VkQueryPool queryPool, uint query)
        {
            var f = new PFN_vkCmdEndQuery(VkLoader.GetFunction(126));
            f.Call(this, queryPool, query);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdResetQueryPool(VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            var f = new PFN_vkCmdResetQueryPool(VkLoader.GetFunction(127));
            f.Call(this, queryPool, firstQuery, queryCount);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteTimestamp(VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query)
        {
            var f = new PFN_vkCmdWriteTimestamp(VkLoader.GetFunction(128));
            f.Call(this, pipelineStage, queryPool, query);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyQueryPoolResults(VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags)
        {
            var f = new PFN_vkCmdCopyQueryPoolResults(VkLoader.GetFunction(129));
            f.Call(this, queryPool, firstQuery, queryCount, dstBuffer, dstOffset, stride, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPushConstants(VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues)
        {
            var f = new PFN_vkCmdPushConstants(VkLoader.GetFunction(130));
            f.Call(this, layout, stageFlags, offset, size, pValues);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginRenderPass(in VkRenderPassBeginInfo pRenderPassBegin, VkSubpassContents contents)
        {
            var f = new PFN_vkCmdBeginRenderPass(VkLoader.GetFunction(131));
            f.Call(this, in pRenderPassBegin, contents);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdNextSubpass(VkSubpassContents contents)
        {
            var f = new PFN_vkCmdNextSubpass(VkLoader.GetFunction(132));
            f.Call(this, contents);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndRenderPass()
        {
            var f = new PFN_vkCmdEndRenderPass(VkLoader.GetFunction(133));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdExecuteCommands(uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            var f = new PFN_vkCmdExecuteCommands(VkLoader.GetFunction(134));
            f.Call(this, commandBufferCount, pCommandBuffers);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDeviceMask(uint deviceMask)
        {
            var f = new PFN_vkCmdSetDeviceMask(VkLoader.GetFunction(138));
            f.Call(this, deviceMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDispatchBase(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            var f = new PFN_vkCmdDispatchBase(VkLoader.GetFunction(139));
            f.Call(this, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndirectCount(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndirectCount(VkLoader.GetFunction(162));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndexedIndirectCount(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndexedIndirectCount(VkLoader.GetFunction(163));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginRenderPass2(in VkRenderPassBeginInfo pRenderPassBegin, in VkSubpassBeginInfo pSubpassBeginInfo)
        {
            var f = new PFN_vkCmdBeginRenderPass2(VkLoader.GetFunction(165));
            f.Call(this, in pRenderPassBegin, in pSubpassBeginInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdNextSubpass2(in VkSubpassBeginInfo pSubpassBeginInfo, in VkSubpassEndInfo pSubpassEndInfo)
        {
            var f = new PFN_vkCmdNextSubpass2(VkLoader.GetFunction(166));
            f.Call(this, in pSubpassBeginInfo, in pSubpassEndInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndRenderPass2(in VkSubpassEndInfo pSubpassEndInfo)
        {
            var f = new PFN_vkCmdEndRenderPass2(VkLoader.GetFunction(167));
            f.Call(this, in pSubpassEndInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginRenderingKHR(in VkRenderingInfoKHR pRenderingInfo)
        {
            var f = new PFN_vkCmdBeginRenderingKHR(VkLoader.GetFunction(197));
            f.Call(this, in pRenderingInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndRenderingKHR()
        {
            var f = new PFN_vkCmdEndRenderingKHR(VkLoader.GetFunction(198));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDeviceMaskKHR(uint deviceMask)
        {
            var f = new PFN_vkCmdSetDeviceMaskKHR(VkLoader.GetFunction(207));
            f.Call(this, deviceMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDispatchBaseKHR(uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            var f = new PFN_vkCmdDispatchBaseKHR(VkLoader.GetFunction(208));
            f.Call(this, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPushDescriptorSetKHR(VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites)
        {
            var f = new PFN_vkCmdPushDescriptorSetKHR(VkLoader.GetFunction(217));
            f.Call(this, pipelineBindPoint, layout, set, descriptorWriteCount, pDescriptorWrites);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPushDescriptorSetWithTemplateKHR(VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData)
        {
            var f = new PFN_vkCmdPushDescriptorSetWithTemplateKHR(VkLoader.GetFunction(218));
            f.Call(this, descriptorUpdateTemplate, layout, set, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginRenderPass2KHR(in VkRenderPassBeginInfo pRenderPassBegin, in VkSubpassBeginInfo pSubpassBeginInfo)
        {
            var f = new PFN_vkCmdBeginRenderPass2KHR(VkLoader.GetFunction(223));
            f.Call(this, in pRenderPassBegin, in pSubpassBeginInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdNextSubpass2KHR(in VkSubpassBeginInfo pSubpassBeginInfo, in VkSubpassEndInfo pSubpassEndInfo)
        {
            var f = new PFN_vkCmdNextSubpass2KHR(VkLoader.GetFunction(224));
            f.Call(this, in pSubpassBeginInfo, in pSubpassEndInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndRenderPass2KHR(in VkSubpassEndInfo pSubpassEndInfo)
        {
            var f = new PFN_vkCmdEndRenderPass2KHR(VkLoader.GetFunction(225));
            f.Call(this, in pSubpassEndInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndirectCountKHR(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndirectCountKHR(VkLoader.GetFunction(248));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndexedIndirectCountKHR(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndexedIndirectCountKHR(VkLoader.GetFunction(249));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetFragmentShadingRateKHR(in VkExtent2D pFragmentSize, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps)
        {
            var f = new PFN_vkCmdSetFragmentShadingRateKHR(VkLoader.GetFunction(254));
            f.Call(this, in pFragmentSize, combinerOps);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetEvent2KHR(VkEvent _event, in VkDependencyInfoKHR pDependencyInfo)
        {
            var f = new PFN_vkCmdSetEvent2KHR(VkLoader.GetFunction(267));
            f.Call(this, _event, in pDependencyInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdResetEvent2KHR(VkEvent _event, VkPipelineStageFlags2KHR stageMask)
        {
            var f = new PFN_vkCmdResetEvent2KHR(VkLoader.GetFunction(268));
            f.Call(this, _event, stageMask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWaitEvents2KHR(uint eventCount, VkEvent* pEvents, in VkDependencyInfoKHR pDependencyInfos)
        {
            var f = new PFN_vkCmdWaitEvents2KHR(VkLoader.GetFunction(269));
            f.Call(this, eventCount, pEvents, in pDependencyInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPipelineBarrier2KHR(in VkDependencyInfoKHR pDependencyInfo)
        {
            var f = new PFN_vkCmdPipelineBarrier2KHR(VkLoader.GetFunction(270));
            f.Call(this, in pDependencyInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteTimestamp2KHR(VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint query)
        {
            var f = new PFN_vkCmdWriteTimestamp2KHR(VkLoader.GetFunction(271));
            f.Call(this, stage, queryPool, query);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteBufferMarker2AMD(VkPipelineStageFlags2KHR stage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            var f = new PFN_vkCmdWriteBufferMarker2AMD(VkLoader.GetFunction(273));
            f.Call(this, stage, dstBuffer, dstOffset, marker);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyBuffer2KHR(in VkCopyBufferInfo2KHR pCopyBufferInfo)
        {
            var f = new PFN_vkCmdCopyBuffer2KHR(VkLoader.GetFunction(275));
            f.Call(this, in pCopyBufferInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyImage2KHR(in VkCopyImageInfo2KHR pCopyImageInfo)
        {
            var f = new PFN_vkCmdCopyImage2KHR(VkLoader.GetFunction(276));
            f.Call(this, in pCopyImageInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyBufferToImage2KHR(in VkCopyBufferToImageInfo2KHR pCopyBufferToImageInfo)
        {
            var f = new PFN_vkCmdCopyBufferToImage2KHR(VkLoader.GetFunction(277));
            f.Call(this, in pCopyBufferToImageInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyImageToBuffer2KHR(in VkCopyImageToBufferInfo2KHR pCopyImageToBufferInfo)
        {
            var f = new PFN_vkCmdCopyImageToBuffer2KHR(VkLoader.GetFunction(278));
            f.Call(this, in pCopyImageToBufferInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBlitImage2KHR(in VkBlitImageInfo2KHR pBlitImageInfo)
        {
            var f = new PFN_vkCmdBlitImage2KHR(VkLoader.GetFunction(279));
            f.Call(this, in pBlitImageInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdResolveImage2KHR(in VkResolveImageInfo2KHR pResolveImageInfo)
        {
            var f = new PFN_vkCmdResolveImage2KHR(VkLoader.GetFunction(280));
            f.Call(this, in pResolveImageInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDebugMarkerBeginEXT(in VkDebugMarkerMarkerInfoEXT pMarkerInfo)
        {
            var f = new PFN_vkCmdDebugMarkerBeginEXT(VkLoader.GetFunction(289));
            f.Call(this, in pMarkerInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDebugMarkerEndEXT()
        {
            var f = new PFN_vkCmdDebugMarkerEndEXT(VkLoader.GetFunction(290));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDebugMarkerInsertEXT(in VkDebugMarkerMarkerInfoEXT pMarkerInfo)
        {
            var f = new PFN_vkCmdDebugMarkerInsertEXT(VkLoader.GetFunction(291));
            f.Call(this, in pMarkerInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindTransformFeedbackBuffersEXT(uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets, in ulong pSizes)
        {
            var f = new PFN_vkCmdBindTransformFeedbackBuffersEXT(VkLoader.GetFunction(292));
            f.Call(this, firstBinding, bindingCount, pBuffers, in pOffsets, in pSizes);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginTransformFeedbackEXT(uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, in ulong pCounterBufferOffsets)
        {
            var f = new PFN_vkCmdBeginTransformFeedbackEXT(VkLoader.GetFunction(293));
            f.Call(this, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndTransformFeedbackEXT(uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, in ulong pCounterBufferOffsets)
        {
            var f = new PFN_vkCmdEndTransformFeedbackEXT(VkLoader.GetFunction(294));
            f.Call(this, firstCounterBuffer, counterBufferCount, pCounterBuffers, in pCounterBufferOffsets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginQueryIndexedEXT(VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index)
        {
            var f = new PFN_vkCmdBeginQueryIndexedEXT(VkLoader.GetFunction(295));
            f.Call(this, queryPool, query, flags, index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndQueryIndexedEXT(VkQueryPool queryPool, uint query, uint index)
        {
            var f = new PFN_vkCmdEndQueryIndexedEXT(VkLoader.GetFunction(296));
            f.Call(this, queryPool, query, index);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndirectByteCountEXT(uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride)
        {
            var f = new PFN_vkCmdDrawIndirectByteCountEXT(VkLoader.GetFunction(297));
            f.Call(this, instanceCount, firstInstance, counterBuffer, counterBufferOffset, counterOffset, vertexStride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCuLaunchKernelNVX(in VkCuLaunchInfoNVX pLaunchInfo)
        {
            var f = new PFN_vkCmdCuLaunchKernelNVX(VkLoader.GetFunction(302));
            f.Call(this, in pLaunchInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndirectCountAMD(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndirectCountAMD(VkLoader.GetFunction(305));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawIndexedIndirectCountAMD(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawIndexedIndirectCountAMD(VkLoader.GetFunction(306));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginConditionalRenderingEXT(in VkConditionalRenderingBeginInfoEXT pConditionalRenderingBegin)
        {
            var f = new PFN_vkCmdBeginConditionalRenderingEXT(VkLoader.GetFunction(309));
            f.Call(this, in pConditionalRenderingBegin);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndConditionalRenderingEXT()
        {
            var f = new PFN_vkCmdEndConditionalRenderingEXT(VkLoader.GetFunction(310));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetViewportWScalingNV(uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings)
        {
            var f = new PFN_vkCmdSetViewportWScalingNV(VkLoader.GetFunction(311));
            f.Call(this, firstViewport, viewportCount, pViewportWScalings);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDiscardRectangleEXT(uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
        {
            var f = new PFN_vkCmdSetDiscardRectangleEXT(VkLoader.GetFunction(320));
            f.Call(this, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBeginDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkCmdBeginDebugUtilsLabelEXT(VkLoader.GetFunction(327));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdEndDebugUtilsLabelEXT()
        {
            var f = new PFN_vkCmdEndDebugUtilsLabelEXT(VkLoader.GetFunction(328));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdInsertDebugUtilsLabelEXT(in VkDebugUtilsLabelEXT pLabelInfo)
        {
            var f = new PFN_vkCmdInsertDebugUtilsLabelEXT(VkLoader.GetFunction(329));
            f.Call(this, in pLabelInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetSampleLocationsEXT(in VkSampleLocationsInfoEXT pSampleLocationsInfo)
        {
            var f = new PFN_vkCmdSetSampleLocationsEXT(VkLoader.GetFunction(333));
            f.Call(this, in pSampleLocationsInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindShadingRateImageNV(VkImageView imageView, VkImageLayout imageLayout)
        {
            var f = new PFN_vkCmdBindShadingRateImageNV(VkLoader.GetFunction(340));
            f.Call(this, imageView, imageLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetViewportShadingRatePaletteNV(uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
        {
            var f = new PFN_vkCmdSetViewportShadingRatePaletteNV(VkLoader.GetFunction(341));
            f.Call(this, firstViewport, viewportCount, pShadingRatePalettes);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetCoarseSampleOrderNV(VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            var f = new PFN_vkCmdSetCoarseSampleOrderNV(VkLoader.GetFunction(342));
            f.Call(this, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBuildAccelerationStructureNV(in VkAccelerationStructureInfoNV pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            var f = new PFN_vkCmdBuildAccelerationStructureNV(VkLoader.GetFunction(347));
            f.Call(this, in pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyAccelerationStructureNV(VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode)
        {
            var f = new PFN_vkCmdCopyAccelerationStructureNV(VkLoader.GetFunction(348));
            f.Call(this, dst, src, mode);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdTraceRaysNV(VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth)
        {
            var f = new PFN_vkCmdTraceRaysNV(VkLoader.GetFunction(349));
            f.Call(this, raygenShaderBindingTableBuffer, raygenShaderBindingOffset, missShaderBindingTableBuffer, missShaderBindingOffset, missShaderBindingStride, hitShaderBindingTableBuffer, hitShaderBindingOffset, hitShaderBindingStride, callableShaderBindingTableBuffer, callableShaderBindingOffset, callableShaderBindingStride, width, height, depth);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteAccelerationStructuresPropertiesNV(uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            var f = new PFN_vkCmdWriteAccelerationStructuresPropertiesNV(VkLoader.GetFunction(354));
            f.Call(this, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteBufferMarkerAMD(VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker)
        {
            var f = new PFN_vkCmdWriteBufferMarkerAMD(VkLoader.GetFunction(357));
            f.Call(this, pipelineStage, dstBuffer, dstOffset, marker);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawMeshTasksNV(uint taskCount, uint firstTask)
        {
            var f = new PFN_vkCmdDrawMeshTasksNV(VkLoader.GetFunction(360));
            f.Call(this, taskCount, firstTask);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawMeshTasksIndirectNV(VkBuffer buffer, ulong offset, uint drawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawMeshTasksIndirectNV(VkLoader.GetFunction(361));
            f.Call(this, buffer, offset, drawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawMeshTasksIndirectCountNV(VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            var f = new PFN_vkCmdDrawMeshTasksIndirectCountNV(VkLoader.GetFunction(362));
            f.Call(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetExclusiveScissorNV(uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors)
        {
            var f = new PFN_vkCmdSetExclusiveScissorNV(VkLoader.GetFunction(363));
            f.Call(this, firstExclusiveScissor, exclusiveScissorCount, pExclusiveScissors);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetCheckpointNV(void* pCheckpointMarker)
        {
            var f = new PFN_vkCmdSetCheckpointNV(VkLoader.GetFunction(364));
            f.Call(this, pCheckpointMarker);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCmdSetPerformanceMarkerINTEL(in VkPerformanceMarkerInfoINTEL pMarkerInfo)
        {
            var f = new PFN_vkCmdSetPerformanceMarkerINTEL(VkLoader.GetFunction(368));
            return f.Call(this, in pMarkerInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCmdSetPerformanceStreamMarkerINTEL(in VkPerformanceStreamMarkerInfoINTEL pMarkerInfo)
        {
            var f = new PFN_vkCmdSetPerformanceStreamMarkerINTEL(VkLoader.GetFunction(369));
            return f.Call(this, in pMarkerInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCmdSetPerformanceOverrideINTEL(in VkPerformanceOverrideInfoINTEL pOverrideInfo)
        {
            var f = new PFN_vkCmdSetPerformanceOverrideINTEL(VkLoader.GetFunction(370));
            return f.Call(this, in pOverrideInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetLineStippleEXT(uint lineStippleFactor, ushort lineStipplePattern)
        {
            var f = new PFN_vkCmdSetLineStippleEXT(VkLoader.GetFunction(381));
            f.Call(this, lineStippleFactor, lineStipplePattern);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetCullModeEXT(VkCullModeFlags cullMode)
        {
            var f = new PFN_vkCmdSetCullModeEXT(VkLoader.GetFunction(383));
            f.Call(this, cullMode);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetFrontFaceEXT(VkFrontFace frontFace)
        {
            var f = new PFN_vkCmdSetFrontFaceEXT(VkLoader.GetFunction(384));
            f.Call(this, frontFace);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetPrimitiveTopologyEXT(VkPrimitiveTopology primitiveTopology)
        {
            var f = new PFN_vkCmdSetPrimitiveTopologyEXT(VkLoader.GetFunction(385));
            f.Call(this, primitiveTopology);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetViewportWithCountEXT(uint viewportCount, VkViewport* pViewports)
        {
            var f = new PFN_vkCmdSetViewportWithCountEXT(VkLoader.GetFunction(386));
            f.Call(this, viewportCount, pViewports);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetScissorWithCountEXT(uint scissorCount, VkRect2D* pScissors)
        {
            var f = new PFN_vkCmdSetScissorWithCountEXT(VkLoader.GetFunction(387));
            f.Call(this, scissorCount, pScissors);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindVertexBuffers2EXT(uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets, in ulong pSizes, in ulong pStrides)
        {
            var f = new PFN_vkCmdBindVertexBuffers2EXT(VkLoader.GetFunction(388));
            f.Call(this, firstBinding, bindingCount, pBuffers, in pOffsets, in pSizes, in pStrides);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthTestEnableEXT(VkBool32 depthTestEnable)
        {
            var f = new PFN_vkCmdSetDepthTestEnableEXT(VkLoader.GetFunction(389));
            f.Call(this, depthTestEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthWriteEnableEXT(VkBool32 depthWriteEnable)
        {
            var f = new PFN_vkCmdSetDepthWriteEnableEXT(VkLoader.GetFunction(390));
            f.Call(this, depthWriteEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthCompareOpEXT(VkCompareOp depthCompareOp)
        {
            var f = new PFN_vkCmdSetDepthCompareOpEXT(VkLoader.GetFunction(391));
            f.Call(this, depthCompareOp);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthBoundsTestEnableEXT(VkBool32 depthBoundsTestEnable)
        {
            var f = new PFN_vkCmdSetDepthBoundsTestEnableEXT(VkLoader.GetFunction(392));
            f.Call(this, depthBoundsTestEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetStencilTestEnableEXT(VkBool32 stencilTestEnable)
        {
            var f = new PFN_vkCmdSetStencilTestEnableEXT(VkLoader.GetFunction(393));
            f.Call(this, stencilTestEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetStencilOpEXT(VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp)
        {
            var f = new PFN_vkCmdSetStencilOpEXT(VkLoader.GetFunction(394));
            f.Call(this, faceMask, failOp, passOp, depthFailOp, compareOp);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdPreprocessGeneratedCommandsNV(in VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
        {
            var f = new PFN_vkCmdPreprocessGeneratedCommandsNV(VkLoader.GetFunction(396));
            f.Call(this, in pGeneratedCommandsInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdExecuteGeneratedCommandsNV(VkBool32 isPreprocessed, in VkGeneratedCommandsInfoNV pGeneratedCommandsInfo)
        {
            var f = new PFN_vkCmdExecuteGeneratedCommandsNV(VkLoader.GetFunction(397));
            f.Call(this, isPreprocessed, in pGeneratedCommandsInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindPipelineShaderGroupNV(VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex)
        {
            var f = new PFN_vkCmdBindPipelineShaderGroupNV(VkLoader.GetFunction(398));
            f.Call(this, pipelineBindPoint, pipeline, groupIndex);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetFragmentShadingRateEnumNV(VkFragmentShadingRateNV shadingRate, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps)
        {
            var f = new PFN_vkCmdSetFragmentShadingRateEnumNV(VkLoader.GetFunction(407));
            f.Call(this, shadingRate, combinerOps);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetVertexInputEXT(uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            var f = new PFN_vkCmdSetVertexInputEXT(VkLoader.GetFunction(410));
            f.Call(this, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSubpassShadingHUAWEI()
        {
            var f = new PFN_vkCmdSubpassShadingHUAWEI(VkLoader.GetFunction(412));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBindInvocationMaskHUAWEI(VkImageView imageView, VkImageLayout imageLayout)
        {
            var f = new PFN_vkCmdBindInvocationMaskHUAWEI(VkLoader.GetFunction(413));
            f.Call(this, imageView, imageLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetPatchControlPointsEXT(uint patchControlPoints)
        {
            var f = new PFN_vkCmdSetPatchControlPointsEXT(VkLoader.GetFunction(415));
            f.Call(this, patchControlPoints);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetRasterizerDiscardEnableEXT(VkBool32 rasterizerDiscardEnable)
        {
            var f = new PFN_vkCmdSetRasterizerDiscardEnableEXT(VkLoader.GetFunction(416));
            f.Call(this, rasterizerDiscardEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetDepthBiasEnableEXT(VkBool32 depthBiasEnable)
        {
            var f = new PFN_vkCmdSetDepthBiasEnableEXT(VkLoader.GetFunction(417));
            f.Call(this, depthBiasEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetLogicOpEXT(VkLogicOp logicOp)
        {
            var f = new PFN_vkCmdSetLogicOpEXT(VkLoader.GetFunction(418));
            f.Call(this, logicOp);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetPrimitiveRestartEnableEXT(VkBool32 primitiveRestartEnable)
        {
            var f = new PFN_vkCmdSetPrimitiveRestartEnableEXT(VkLoader.GetFunction(419));
            f.Call(this, primitiveRestartEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetColorWriteEnableEXT(uint attachmentCount, VkBool32* pColorWriteEnables)
        {
            var f = new PFN_vkCmdSetColorWriteEnableEXT(VkLoader.GetFunction(420));
            f.Call(this, attachmentCount, pColorWriteEnables);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawMultiEXT(uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride)
        {
            var f = new PFN_vkCmdDrawMultiEXT(VkLoader.GetFunction(421));
            f.Call(this, drawCount, pVertexInfo, instanceCount, firstInstance, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdDrawMultiIndexedEXT(uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, in int pVertexOffset)
        {
            var f = new PFN_vkCmdDrawMultiIndexedEXT(VkLoader.GetFunction(422));
            f.Call(this, drawCount, pIndexInfo, instanceCount, firstInstance, stride, in pVertexOffset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBuildAccelerationStructuresKHR(uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            var f = new PFN_vkCmdBuildAccelerationStructuresKHR(VkLoader.GetFunction(426));
            f.Call(this, infoCount, pInfos, ppBuildRangeInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdBuildAccelerationStructuresIndirectKHR(uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, in ulong pIndirectDeviceAddresses, in uint pIndirectStrides, in uint* ppMaxPrimitiveCounts)
        {
            var f = new PFN_vkCmdBuildAccelerationStructuresIndirectKHR(VkLoader.GetFunction(427));
            f.Call(this, infoCount, pInfos, in pIndirectDeviceAddresses, in pIndirectStrides, in ppMaxPrimitiveCounts);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyAccelerationStructureKHR(in VkCopyAccelerationStructureInfoKHR pInfo)
        {
            var f = new PFN_vkCmdCopyAccelerationStructureKHR(VkLoader.GetFunction(433));
            f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyAccelerationStructureToMemoryKHR(in VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
        {
            var f = new PFN_vkCmdCopyAccelerationStructureToMemoryKHR(VkLoader.GetFunction(434));
            f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdCopyMemoryToAccelerationStructureKHR(in VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
        {
            var f = new PFN_vkCmdCopyMemoryToAccelerationStructureKHR(VkLoader.GetFunction(435));
            f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdWriteAccelerationStructuresPropertiesKHR(uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            var f = new PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(VkLoader.GetFunction(437));
            f.Call(this, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdTraceRaysKHR(in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth)
        {
            var f = new PFN_vkCmdTraceRaysKHR(VkLoader.GetFunction(440));
            f.Call(this, in pRaygenShaderBindingTable, in pMissShaderBindingTable, in pHitShaderBindingTable, in pCallableShaderBindingTable, width, height, depth);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdTraceRaysIndirectKHR(in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress)
        {
            var f = new PFN_vkCmdTraceRaysIndirectKHR(VkLoader.GetFunction(443));
            f.Call(this, in pRaygenShaderBindingTable, in pMissShaderBindingTable, in pHitShaderBindingTable, in pCallableShaderBindingTable, indirectDeviceAddress);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkCmdSetRayTracingPipelineStackSizeKHR(uint pipelineStackSize)
        {
            var f = new PFN_vkCmdSetRayTracingPipelineStackSizeKHR(VkLoader.GetFunction(445));
            f.Call(this, pipelineStackSize);
        }
    }
}
