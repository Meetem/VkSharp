using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkFunctionPointer vkGetDeviceProcAddr(byte* pName)
        {
            var f = new PFN_vkGetDeviceProcAddr(VkLoader.GetFunction(9));
            return f.Call(this, pName);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDevice(in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDevice(VkLoader.GetFunction(11));
            f.Call(this, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceQueue(uint queueFamilyIndex, uint queueIndex, ref VkQueue pQueue)
        {
            var f = new PFN_vkGetDeviceQueue(VkLoader.GetFunction(15));
            f.Call(this, queueFamilyIndex, queueIndex, ref pQueue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkDeviceWaitIdle()
        {
            var f = new PFN_vkDeviceWaitIdle(VkLoader.GetFunction(18));
            return f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAllocateMemory(in VkMemoryAllocateInfo pAllocateInfo, in VkAllocationCallbacks pAllocator, ref VkDeviceMemory pMemory)
        {
            var f = new PFN_vkAllocateMemory(VkLoader.GetFunction(19));
            return f.Call(this, in pAllocateInfo, in pAllocator, ref pMemory);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkFreeMemory(VkDeviceMemory memory, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkFreeMemory(VkLoader.GetFunction(20));
            f.Call(this, memory, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkMapMemory(VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlags flags, ref void* ppData)
        {
            var f = new PFN_vkMapMemory(VkLoader.GetFunction(21));
            return f.Call(this, memory, offset, size, flags, ref ppData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkUnmapMemory(VkDeviceMemory memory)
        {
            var f = new PFN_vkUnmapMemory(VkLoader.GetFunction(22));
            f.Call(this, memory);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkFlushMappedMemoryRanges(uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            var f = new PFN_vkFlushMappedMemoryRanges(VkLoader.GetFunction(23));
            return f.Call(this, memoryRangeCount, pMemoryRanges);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkInvalidateMappedMemoryRanges(uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges)
        {
            var f = new PFN_vkInvalidateMappedMemoryRanges(VkLoader.GetFunction(24));
            return f.Call(this, memoryRangeCount, pMemoryRanges);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceMemoryCommitment(VkDeviceMemory memory, ref ulong pCommittedMemoryInBytes)
        {
            var f = new PFN_vkGetDeviceMemoryCommitment(VkLoader.GetFunction(25));
            f.Call(this, memory, ref pCommittedMemoryInBytes);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindBufferMemory(VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset)
        {
            var f = new PFN_vkBindBufferMemory(VkLoader.GetFunction(26));
            return f.Call(this, buffer, memory, memoryOffset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindImageMemory(VkImage image, VkDeviceMemory memory, ulong memoryOffset)
        {
            var f = new PFN_vkBindImageMemory(VkLoader.GetFunction(27));
            return f.Call(this, image, memory, memoryOffset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetBufferMemoryRequirements(VkBuffer buffer, ref VkMemoryRequirements pMemoryRequirements)
        {
            var f = new PFN_vkGetBufferMemoryRequirements(VkLoader.GetFunction(28));
            f.Call(this, buffer, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageMemoryRequirements(VkImage image, ref VkMemoryRequirements pMemoryRequirements)
        {
            var f = new PFN_vkGetImageMemoryRequirements(VkLoader.GetFunction(29));
            f.Call(this, image, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageSparseMemoryRequirements(VkImage image, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            var f = new PFN_vkGetImageSparseMemoryRequirements(VkLoader.GetFunction(30));
            f.Call(this, image, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateFence(in VkFenceCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            var f = new PFN_vkCreateFence(VkLoader.GetFunction(33));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pFence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyFence(VkFence fence, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyFence(VkLoader.GetFunction(34));
            f.Call(this, fence, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkResetFences(uint fenceCount, VkFence* pFences)
        {
            var f = new PFN_vkResetFences(VkLoader.GetFunction(35));
            return f.Call(this, fenceCount, pFences);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetFenceStatus(VkFence fence)
        {
            var f = new PFN_vkGetFenceStatus(VkLoader.GetFunction(36));
            return f.Call(this, fence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkWaitForFences(uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout)
        {
            var f = new PFN_vkWaitForFences(VkLoader.GetFunction(37));
            return f.Call(this, fenceCount, pFences, waitAll, timeout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSemaphore(in VkSemaphoreCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSemaphore pSemaphore)
        {
            var f = new PFN_vkCreateSemaphore(VkLoader.GetFunction(38));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSemaphore);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySemaphore(VkSemaphore semaphore, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySemaphore(VkLoader.GetFunction(39));
            f.Call(this, semaphore, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateEvent(in VkEventCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkEvent pEvent)
        {
            var f = new PFN_vkCreateEvent(VkLoader.GetFunction(40));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pEvent);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyEvent(VkEvent _event, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyEvent(VkLoader.GetFunction(41));
            f.Call(this, _event, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetEventStatus(VkEvent _event)
        {
            var f = new PFN_vkGetEventStatus(VkLoader.GetFunction(42));
            return f.Call(this, _event);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSetEvent(VkEvent _event)
        {
            var f = new PFN_vkSetEvent(VkLoader.GetFunction(43));
            return f.Call(this, _event);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkResetEvent(VkEvent _event)
        {
            var f = new PFN_vkResetEvent(VkLoader.GetFunction(44));
            return f.Call(this, _event);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateQueryPool(in VkQueryPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkQueryPool pQueryPool)
        {
            var f = new PFN_vkCreateQueryPool(VkLoader.GetFunction(45));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pQueryPool);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyQueryPool(VkQueryPool queryPool, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyQueryPool(VkLoader.GetFunction(46));
            f.Call(this, queryPool, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetQueryPoolResults(VkQueryPool queryPool, uint firstQuery, uint queryCount, ulong dataSize, void* pData, ulong stride, VkQueryResultFlags flags)
        {
            var f = new PFN_vkGetQueryPoolResults(VkLoader.GetFunction(47));
            return f.Call(this, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateBuffer(in VkBufferCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkBuffer pBuffer)
        {
            var f = new PFN_vkCreateBuffer(VkLoader.GetFunction(48));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pBuffer);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyBuffer(VkBuffer buffer, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyBuffer(VkLoader.GetFunction(49));
            f.Call(this, buffer, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateBufferView(in VkBufferViewCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkBufferView pView)
        {
            var f = new PFN_vkCreateBufferView(VkLoader.GetFunction(50));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pView);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyBufferView(VkBufferView bufferView, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyBufferView(VkLoader.GetFunction(51));
            f.Call(this, bufferView, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateImage(in VkImageCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkImage pImage)
        {
            var f = new PFN_vkCreateImage(VkLoader.GetFunction(52));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pImage);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyImage(VkImage image, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyImage(VkLoader.GetFunction(53));
            f.Call(this, image, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageSubresourceLayout(VkImage image, in VkImageSubresource pSubresource, ref VkSubresourceLayout pLayout)
        {
            var f = new PFN_vkGetImageSubresourceLayout(VkLoader.GetFunction(54));
            f.Call(this, image, in pSubresource, ref pLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateImageView(in VkImageViewCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkImageView pView)
        {
            var f = new PFN_vkCreateImageView(VkLoader.GetFunction(55));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pView);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyImageView(VkImageView imageView, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyImageView(VkLoader.GetFunction(56));
            f.Call(this, imageView, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateShaderModule(in VkShaderModuleCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkShaderModule pShaderModule)
        {
            var f = new PFN_vkCreateShaderModule(VkLoader.GetFunction(57));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pShaderModule);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyShaderModule(VkShaderModule shaderModule, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyShaderModule(VkLoader.GetFunction(58));
            f.Call(this, shaderModule, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreatePipelineCache(in VkPipelineCacheCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineCache pPipelineCache)
        {
            var f = new PFN_vkCreatePipelineCache(VkLoader.GetFunction(59));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pPipelineCache);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyPipelineCache(VkPipelineCache pipelineCache, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyPipelineCache(VkLoader.GetFunction(60));
            f.Call(this, pipelineCache, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPipelineCacheData(VkPipelineCache pipelineCache, ref ulong pDataSize, void* pData)
        {
            var f = new PFN_vkGetPipelineCacheData(VkLoader.GetFunction(61));
            return f.Call(this, pipelineCache, ref pDataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkMergePipelineCaches(VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches)
        {
            var f = new PFN_vkMergePipelineCaches(VkLoader.GetFunction(62));
            return f.Call(this, dstCache, srcCacheCount, pSrcCaches);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateGraphicsPipelines(VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            var f = new PFN_vkCreateGraphicsPipelines(VkLoader.GetFunction(63));
            return f.Call(this, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateComputePipelines(VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            var f = new PFN_vkCreateComputePipelines(VkLoader.GetFunction(64));
            return f.Call(this, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyPipeline(VkPipeline pipeline, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyPipeline(VkLoader.GetFunction(65));
            f.Call(this, pipeline, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreatePipelineLayout(in VkPipelineLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineLayout pPipelineLayout)
        {
            var f = new PFN_vkCreatePipelineLayout(VkLoader.GetFunction(66));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pPipelineLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyPipelineLayout(VkPipelineLayout pipelineLayout, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyPipelineLayout(VkLoader.GetFunction(67));
            f.Call(this, pipelineLayout, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSampler(in VkSamplerCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSampler pSampler)
        {
            var f = new PFN_vkCreateSampler(VkLoader.GetFunction(68));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSampler);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySampler(VkSampler sampler, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySampler(VkLoader.GetFunction(69));
            f.Call(this, sampler, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDescriptorSetLayout(in VkDescriptorSetLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorSetLayout pSetLayout)
        {
            var f = new PFN_vkCreateDescriptorSetLayout(VkLoader.GetFunction(70));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSetLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDescriptorSetLayout(VkDescriptorSetLayout descriptorSetLayout, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDescriptorSetLayout(VkLoader.GetFunction(71));
            f.Call(this, descriptorSetLayout, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDescriptorPool(in VkDescriptorPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorPool pDescriptorPool)
        {
            var f = new PFN_vkCreateDescriptorPool(VkLoader.GetFunction(72));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pDescriptorPool);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDescriptorPool(VkDescriptorPool descriptorPool, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDescriptorPool(VkLoader.GetFunction(73));
            f.Call(this, descriptorPool, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkResetDescriptorPool(VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags)
        {
            var f = new PFN_vkResetDescriptorPool(VkLoader.GetFunction(74));
            return f.Call(this, descriptorPool, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAllocateDescriptorSets(in VkDescriptorSetAllocateInfo pAllocateInfo, ref VkDescriptorSet pDescriptorSets)
        {
            var f = new PFN_vkAllocateDescriptorSets(VkLoader.GetFunction(75));
            return f.Call(this, in pAllocateInfo, ref pDescriptorSets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkFreeDescriptorSets(VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets)
        {
            var f = new PFN_vkFreeDescriptorSets(VkLoader.GetFunction(76));
            return f.Call(this, descriptorPool, descriptorSetCount, pDescriptorSets);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkUpdateDescriptorSets(uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies)
        {
            var f = new PFN_vkUpdateDescriptorSets(VkLoader.GetFunction(77));
            f.Call(this, descriptorWriteCount, pDescriptorWrites, descriptorCopyCount, pDescriptorCopies);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateFramebuffer(in VkFramebufferCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkFramebuffer pFramebuffer)
        {
            var f = new PFN_vkCreateFramebuffer(VkLoader.GetFunction(78));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pFramebuffer);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyFramebuffer(VkFramebuffer framebuffer, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyFramebuffer(VkLoader.GetFunction(79));
            f.Call(this, framebuffer, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateRenderPass(in VkRenderPassCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass)
        {
            var f = new PFN_vkCreateRenderPass(VkLoader.GetFunction(80));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pRenderPass);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyRenderPass(VkRenderPass renderPass, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyRenderPass(VkLoader.GetFunction(81));
            f.Call(this, renderPass, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetRenderAreaGranularity(VkRenderPass renderPass, ref VkExtent2D pGranularity)
        {
            var f = new PFN_vkGetRenderAreaGranularity(VkLoader.GetFunction(82));
            f.Call(this, renderPass, ref pGranularity);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateCommandPool(in VkCommandPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCommandPool pCommandPool)
        {
            var f = new PFN_vkCreateCommandPool(VkLoader.GetFunction(83));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pCommandPool);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyCommandPool(VkCommandPool commandPool, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyCommandPool(VkLoader.GetFunction(84));
            f.Call(this, commandPool, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkResetCommandPool(VkCommandPool commandPool, VkCommandPoolResetFlags flags)
        {
            var f = new PFN_vkResetCommandPool(VkLoader.GetFunction(85));
            return f.Call(this, commandPool, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAllocateCommandBuffers(in VkCommandBufferAllocateInfo pAllocateInfo, ref VkCommandBuffer pCommandBuffers)
        {
            var f = new PFN_vkAllocateCommandBuffers(VkLoader.GetFunction(86));
            return f.Call(this, in pAllocateInfo, ref pCommandBuffers);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkFreeCommandBuffers(VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers)
        {
            var f = new PFN_vkFreeCommandBuffers(VkLoader.GetFunction(87));
            f.Call(this, commandPool, commandBufferCount, pCommandBuffers);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindBufferMemory2(uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            var f = new PFN_vkBindBufferMemory2(VkLoader.GetFunction(135));
            return f.Call(this, bindInfoCount, pBindInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindImageMemory2(uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            var f = new PFN_vkBindImageMemory2(VkLoader.GetFunction(136));
            return f.Call(this, bindInfoCount, pBindInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceGroupPeerMemoryFeatures(uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures)
        {
            var f = new PFN_vkGetDeviceGroupPeerMemoryFeatures(VkLoader.GetFunction(137));
            f.Call(this, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageMemoryRequirements2(in VkImageMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetImageMemoryRequirements2(VkLoader.GetFunction(141));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetBufferMemoryRequirements2(in VkBufferMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetBufferMemoryRequirements2(VkLoader.GetFunction(142));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageSparseMemoryRequirements2(in VkImageSparseMemoryRequirementsInfo2 pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            var f = new PFN_vkGetImageSparseMemoryRequirements2(VkLoader.GetFunction(143));
            f.Call(this, in pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkTrimCommandPool(VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            var f = new PFN_vkTrimCommandPool(VkLoader.GetFunction(151));
            f.Call(this, commandPool, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceQueue2(in VkDeviceQueueInfo2 pQueueInfo, ref VkQueue pQueue)
        {
            var f = new PFN_vkGetDeviceQueue2(VkLoader.GetFunction(152));
            f.Call(this, in pQueueInfo, ref pQueue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSamplerYcbcrConversion(in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion)
        {
            var f = new PFN_vkCreateSamplerYcbcrConversion(VkLoader.GetFunction(153));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pYcbcrConversion);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySamplerYcbcrConversion(VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySamplerYcbcrConversion(VkLoader.GetFunction(154));
            f.Call(this, ycbcrConversion, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDescriptorUpdateTemplate(in VkDescriptorUpdateTemplateCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorUpdateTemplate pDescriptorUpdateTemplate)
        {
            var f = new PFN_vkCreateDescriptorUpdateTemplate(VkLoader.GetFunction(155));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pDescriptorUpdateTemplate);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDescriptorUpdateTemplate(VkDescriptorUpdateTemplate descriptorUpdateTemplate, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDescriptorUpdateTemplate(VkLoader.GetFunction(156));
            f.Call(this, descriptorUpdateTemplate, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkUpdateDescriptorSetWithTemplate(VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            var f = new PFN_vkUpdateDescriptorSetWithTemplate(VkLoader.GetFunction(157));
            f.Call(this, descriptorSet, descriptorUpdateTemplate, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDescriptorSetLayoutSupport(in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport)
        {
            var f = new PFN_vkGetDescriptorSetLayoutSupport(VkLoader.GetFunction(161));
            f.Call(this, in pCreateInfo, ref pSupport);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateRenderPass2(in VkRenderPassCreateInfo2 pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass)
        {
            var f = new PFN_vkCreateRenderPass2(VkLoader.GetFunction(164));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pRenderPass);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkResetQueryPool(VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            var f = new PFN_vkResetQueryPool(VkLoader.GetFunction(168));
            f.Call(this, queryPool, firstQuery, queryCount);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSemaphoreCounterValue(VkSemaphore semaphore, ref ulong pValue)
        {
            var f = new PFN_vkGetSemaphoreCounterValue(VkLoader.GetFunction(169));
            return f.Call(this, semaphore, ref pValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkWaitSemaphores(in VkSemaphoreWaitInfo pWaitInfo, ulong timeout)
        {
            var f = new PFN_vkWaitSemaphores(VkLoader.GetFunction(170));
            return f.Call(this, in pWaitInfo, timeout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSignalSemaphore(in VkSemaphoreSignalInfo pSignalInfo)
        {
            var f = new PFN_vkSignalSemaphore(VkLoader.GetFunction(171));
            return f.Call(this, in pSignalInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetBufferDeviceAddress(in VkBufferDeviceAddressInfo pInfo)
        {
            var f = new PFN_vkGetBufferDeviceAddress(VkLoader.GetFunction(172));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetBufferOpaqueCaptureAddress(in VkBufferDeviceAddressInfo pInfo)
        {
            var f = new PFN_vkGetBufferOpaqueCaptureAddress(VkLoader.GetFunction(173));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetDeviceMemoryOpaqueCaptureAddress(in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo)
        {
            var f = new PFN_vkGetDeviceMemoryOpaqueCaptureAddress(VkLoader.GetFunction(174));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSwapchainKHR(in VkSwapchainCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSwapchainKHR pSwapchain)
        {
            var f = new PFN_vkCreateSwapchainKHR(VkLoader.GetFunction(180));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSwapchain);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySwapchainKHR(VkSwapchainKHR swapchain, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySwapchainKHR(VkLoader.GetFunction(181));
            f.Call(this, swapchain, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSwapchainImagesKHR(VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, VkImage* pSwapchainImages)
        {
            var f = new PFN_vkGetSwapchainImagesKHR(VkLoader.GetFunction(182));
            return f.Call(this, swapchain, ref pSwapchainImageCount, pSwapchainImages);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAcquireNextImageKHR(VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, ref uint pImageIndex)
        {
            var f = new PFN_vkAcquireNextImageKHR(VkLoader.GetFunction(183));
            return f.Call(this, swapchain, timeout, semaphore, fence, ref pImageIndex);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDeviceGroupPresentCapabilitiesKHR(ref VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities)
        {
            var f = new PFN_vkGetDeviceGroupPresentCapabilitiesKHR(VkLoader.GetFunction(185));
            return f.Call(this, ref pDeviceGroupPresentCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDeviceGroupSurfacePresentModesKHR(VkSurfaceKHR surface, ref VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            var f = new PFN_vkGetDeviceGroupSurfacePresentModesKHR(VkLoader.GetFunction(186));
            return f.Call(this, surface, ref pModes);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAcquireNextImage2KHR(in VkAcquireNextImageInfoKHR pAcquireInfo, ref uint pImageIndex)
        {
            var f = new PFN_vkAcquireNextImage2KHR(VkLoader.GetFunction(188));
            return f.Call(this, in pAcquireInfo, ref pImageIndex);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSharedSwapchainsKHR(uint swapchainCount, in VkSwapchainCreateInfoKHR pCreateInfos, in VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains)
        {
            var f = new PFN_vkCreateSharedSwapchainsKHR(VkLoader.GetFunction(196));
            return f.Call(this, swapchainCount, in pCreateInfos, in pAllocator, pSwapchains);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceGroupPeerMemoryFeaturesKHR(uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures)
        {
            var f = new PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR(VkLoader.GetFunction(206));
            f.Call(this, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkTrimCommandPoolKHR(VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
        {
            var f = new PFN_vkTrimCommandPoolKHR(VkLoader.GetFunction(209));
            f.Call(this, commandPool, flags);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetMemoryFdKHR(in VkMemoryGetFdInfoKHR pGetFdInfo, ref int pFd)
        {
            var f = new PFN_vkGetMemoryFdKHR(VkLoader.GetFunction(212));
            return f.Call(this, in pGetFdInfo, ref pFd);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetMemoryFdPropertiesKHR(VkExternalMemoryHandleTypeFlags handleType, int fd, ref VkMemoryFdPropertiesKHR pMemoryFdProperties)
        {
            var f = new PFN_vkGetMemoryFdPropertiesKHR(VkLoader.GetFunction(213));
            return f.Call(this, handleType, fd, ref pMemoryFdProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkImportSemaphoreFdKHR(in VkImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo)
        {
            var f = new PFN_vkImportSemaphoreFdKHR(VkLoader.GetFunction(215));
            return f.Call(this, in pImportSemaphoreFdInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSemaphoreFdKHR(in VkSemaphoreGetFdInfoKHR pGetFdInfo, ref int pFd)
        {
            var f = new PFN_vkGetSemaphoreFdKHR(VkLoader.GetFunction(216));
            return f.Call(this, in pGetFdInfo, ref pFd);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDescriptorUpdateTemplateKHR(in VkDescriptorUpdateTemplateCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorUpdateTemplate pDescriptorUpdateTemplate)
        {
            var f = new PFN_vkCreateDescriptorUpdateTemplateKHR(VkLoader.GetFunction(219));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pDescriptorUpdateTemplate);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDescriptorUpdateTemplateKHR(VkDescriptorUpdateTemplate descriptorUpdateTemplate, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDescriptorUpdateTemplateKHR(VkLoader.GetFunction(220));
            f.Call(this, descriptorUpdateTemplate, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkUpdateDescriptorSetWithTemplateKHR(VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData)
        {
            var f = new PFN_vkUpdateDescriptorSetWithTemplateKHR(VkLoader.GetFunction(221));
            f.Call(this, descriptorSet, descriptorUpdateTemplate, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateRenderPass2KHR(in VkRenderPassCreateInfo2 pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass)
        {
            var f = new PFN_vkCreateRenderPass2KHR(VkLoader.GetFunction(222));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pRenderPass);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSwapchainStatusKHR(VkSwapchainKHR swapchain)
        {
            var f = new PFN_vkGetSwapchainStatusKHR(VkLoader.GetFunction(226));
            return f.Call(this, swapchain);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkImportFenceFdKHR(in VkImportFenceFdInfoKHR pImportFenceFdInfo)
        {
            var f = new PFN_vkImportFenceFdKHR(VkLoader.GetFunction(228));
            return f.Call(this, in pImportFenceFdInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetFenceFdKHR(in VkFenceGetFdInfoKHR pGetFdInfo, ref int pFd)
        {
            var f = new PFN_vkGetFenceFdKHR(VkLoader.GetFunction(229));
            return f.Call(this, in pGetFdInfo, ref pFd);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAcquireProfilingLockKHR(in VkAcquireProfilingLockInfoKHR pInfo)
        {
            var f = new PFN_vkAcquireProfilingLockKHR(VkLoader.GetFunction(232));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkReleaseProfilingLockKHR()
        {
            var f = new PFN_vkReleaseProfilingLockKHR(VkLoader.GetFunction(233));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageMemoryRequirements2KHR(in VkImageMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetImageMemoryRequirements2KHR(VkLoader.GetFunction(240));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetBufferMemoryRequirements2KHR(in VkBufferMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetBufferMemoryRequirements2KHR(VkLoader.GetFunction(241));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetImageSparseMemoryRequirements2KHR(in VkImageSparseMemoryRequirementsInfo2 pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            var f = new PFN_vkGetImageSparseMemoryRequirements2KHR(VkLoader.GetFunction(242));
            f.Call(this, in pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateSamplerYcbcrConversionKHR(in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion)
        {
            var f = new PFN_vkCreateSamplerYcbcrConversionKHR(VkLoader.GetFunction(243));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pYcbcrConversion);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySamplerYcbcrConversionKHR(VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySamplerYcbcrConversionKHR(VkLoader.GetFunction(244));
            f.Call(this, ycbcrConversion, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindBufferMemory2KHR(uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            var f = new PFN_vkBindBufferMemory2KHR(VkLoader.GetFunction(245));
            return f.Call(this, bindInfoCount, pBindInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindImageMemory2KHR(uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
        {
            var f = new PFN_vkBindImageMemory2KHR(VkLoader.GetFunction(246));
            return f.Call(this, bindInfoCount, pBindInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDescriptorSetLayoutSupportKHR(in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport)
        {
            var f = new PFN_vkGetDescriptorSetLayoutSupportKHR(VkLoader.GetFunction(247));
            f.Call(this, in pCreateInfo, ref pSupport);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSemaphoreCounterValueKHR(VkSemaphore semaphore, ref ulong pValue)
        {
            var f = new PFN_vkGetSemaphoreCounterValueKHR(VkLoader.GetFunction(250));
            return f.Call(this, semaphore, ref pValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkWaitSemaphoresKHR(in VkSemaphoreWaitInfo pWaitInfo, ulong timeout)
        {
            var f = new PFN_vkWaitSemaphoresKHR(VkLoader.GetFunction(251));
            return f.Call(this, in pWaitInfo, timeout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSignalSemaphoreKHR(in VkSemaphoreSignalInfo pSignalInfo)
        {
            var f = new PFN_vkSignalSemaphoreKHR(VkLoader.GetFunction(252));
            return f.Call(this, in pSignalInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkWaitForPresentKHR(VkSwapchainKHR swapchain, ulong presentId, ulong timeout)
        {
            var f = new PFN_vkWaitForPresentKHR(VkLoader.GetFunction(255));
            return f.Call(this, swapchain, presentId, timeout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetBufferDeviceAddressKHR(in VkBufferDeviceAddressInfo pInfo)
        {
            var f = new PFN_vkGetBufferDeviceAddressKHR(VkLoader.GetFunction(256));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetBufferOpaqueCaptureAddressKHR(in VkBufferDeviceAddressInfo pInfo)
        {
            var f = new PFN_vkGetBufferOpaqueCaptureAddressKHR(VkLoader.GetFunction(257));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetDeviceMemoryOpaqueCaptureAddressKHR(in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo)
        {
            var f = new PFN_vkGetDeviceMemoryOpaqueCaptureAddressKHR(VkLoader.GetFunction(258));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDeferredOperationKHR(in VkAllocationCallbacks pAllocator, ref VkDeferredOperationKHR pDeferredOperation)
        {
            var f = new PFN_vkCreateDeferredOperationKHR(VkLoader.GetFunction(259));
            return f.Call(this, in pAllocator, ref pDeferredOperation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDeferredOperationKHR(VkDeferredOperationKHR operation, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDeferredOperationKHR(VkLoader.GetFunction(260));
            f.Call(this, operation, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint vkGetDeferredOperationMaxConcurrencyKHR(VkDeferredOperationKHR operation)
        {
            var f = new PFN_vkGetDeferredOperationMaxConcurrencyKHR(VkLoader.GetFunction(261));
            return f.Call(this, operation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDeferredOperationResultKHR(VkDeferredOperationKHR operation)
        {
            var f = new PFN_vkGetDeferredOperationResultKHR(VkLoader.GetFunction(262));
            return f.Call(this, operation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkDeferredOperationJoinKHR(VkDeferredOperationKHR operation)
        {
            var f = new PFN_vkDeferredOperationJoinKHR(VkLoader.GetFunction(263));
            return f.Call(this, operation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPipelineExecutablePropertiesKHR(in VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            var f = new PFN_vkGetPipelineExecutablePropertiesKHR(VkLoader.GetFunction(264));
            return f.Call(this, in pPipelineInfo, ref pExecutableCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPipelineExecutableStatisticsKHR(in VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics)
        {
            var f = new PFN_vkGetPipelineExecutableStatisticsKHR(VkLoader.GetFunction(265));
            return f.Call(this, in pExecutableInfo, ref pStatisticCount, pStatistics);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPipelineExecutableInternalRepresentationsKHR(in VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            var f = new PFN_vkGetPipelineExecutableInternalRepresentationsKHR(VkLoader.GetFunction(266));
            return f.Call(this, in pExecutableInfo, ref pInternalRepresentationCount, pInternalRepresentations);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceBufferMemoryRequirementsKHR(in VkDeviceBufferMemoryRequirementsKHR pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetDeviceBufferMemoryRequirementsKHR(VkLoader.GetFunction(281));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceImageMemoryRequirementsKHR(in VkDeviceImageMemoryRequirementsKHR pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetDeviceImageMemoryRequirementsKHR(VkLoader.GetFunction(282));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceImageSparseMemoryRequirementsKHR(in VkDeviceImageMemoryRequirementsKHR pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            var f = new PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(VkLoader.GetFunction(283));
            f.Call(this, in pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkDebugMarkerSetObjectTagEXT(in VkDebugMarkerObjectTagInfoEXT pTagInfo)
        {
            var f = new PFN_vkDebugMarkerSetObjectTagEXT(VkLoader.GetFunction(287));
            return f.Call(this, in pTagInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkDebugMarkerSetObjectNameEXT(in VkDebugMarkerObjectNameInfoEXT pNameInfo)
        {
            var f = new PFN_vkDebugMarkerSetObjectNameEXT(VkLoader.GetFunction(288));
            return f.Call(this, in pNameInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateCuModuleNVX(in VkCuModuleCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuModuleNVX pModule)
        {
            var f = new PFN_vkCreateCuModuleNVX(VkLoader.GetFunction(298));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pModule);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateCuFunctionNVX(in VkCuFunctionCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuFunctionNVX pFunction)
        {
            var f = new PFN_vkCreateCuFunctionNVX(VkLoader.GetFunction(299));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pFunction);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyCuModuleNVX(VkCuModuleNVX module, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyCuModuleNVX(VkLoader.GetFunction(300));
            f.Call(this, module, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyCuFunctionNVX(VkCuFunctionNVX function, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyCuFunctionNVX(VkLoader.GetFunction(301));
            f.Call(this, function, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint vkGetImageViewHandleNVX(in VkImageViewHandleInfoNVX pInfo)
        {
            var f = new PFN_vkGetImageViewHandleNVX(VkLoader.GetFunction(303));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetImageViewAddressNVX(VkImageView imageView, ref VkImageViewAddressPropertiesNVX pProperties)
        {
            var f = new PFN_vkGetImageViewAddressNVX(VkLoader.GetFunction(304));
            return f.Call(this, imageView, ref pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetShaderInfoAMD(VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref ulong pInfoSize, void* pInfo)
        {
            var f = new PFN_vkGetShaderInfoAMD(VkLoader.GetFunction(307));
            return f.Call(this, pipeline, shaderStage, infoType, ref pInfoSize, pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkDisplayPowerControlEXT(VkDisplayKHR display, in VkDisplayPowerInfoEXT pDisplayPowerInfo)
        {
            var f = new PFN_vkDisplayPowerControlEXT(VkLoader.GetFunction(314));
            return f.Call(this, display, in pDisplayPowerInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkRegisterDeviceEventEXT(in VkDeviceEventInfoEXT pDeviceEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            var f = new PFN_vkRegisterDeviceEventEXT(VkLoader.GetFunction(315));
            return f.Call(this, in pDeviceEventInfo, in pAllocator, ref pFence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkRegisterDisplayEventEXT(VkDisplayKHR display, in VkDisplayEventInfoEXT pDisplayEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            var f = new PFN_vkRegisterDisplayEventEXT(VkLoader.GetFunction(316));
            return f.Call(this, display, in pDisplayEventInfo, in pAllocator, ref pFence);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetSwapchainCounterEXT(VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ref ulong pCounterValue)
        {
            var f = new PFN_vkGetSwapchainCounterEXT(VkLoader.GetFunction(317));
            return f.Call(this, swapchain, counter, ref pCounterValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetRefreshCycleDurationGOOGLE(VkSwapchainKHR swapchain, ref VkRefreshCycleDurationGOOGLE pDisplayTimingProperties)
        {
            var f = new PFN_vkGetRefreshCycleDurationGOOGLE(VkLoader.GetFunction(318));
            return f.Call(this, swapchain, ref pDisplayTimingProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPastPresentationTimingGOOGLE(VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings)
        {
            var f = new PFN_vkGetPastPresentationTimingGOOGLE(VkLoader.GetFunction(319));
            return f.Call(this, swapchain, ref pPresentationTimingCount, pPresentationTimings);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkSetHdrMetadataEXT(uint swapchainCount, VkSwapchainKHR* pSwapchains, in VkHdrMetadataEXT pMetadata)
        {
            var f = new PFN_vkSetHdrMetadataEXT(VkLoader.GetFunction(321));
            f.Call(this, swapchainCount, pSwapchains, in pMetadata);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSetDebugUtilsObjectNameEXT(in VkDebugUtilsObjectNameInfoEXT pNameInfo)
        {
            var f = new PFN_vkSetDebugUtilsObjectNameEXT(VkLoader.GetFunction(322));
            return f.Call(this, in pNameInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSetDebugUtilsObjectTagEXT(in VkDebugUtilsObjectTagInfoEXT pTagInfo)
        {
            var f = new PFN_vkSetDebugUtilsObjectTagEXT(VkLoader.GetFunction(323));
            return f.Call(this, in pTagInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetImageDrmFormatModifierPropertiesEXT(VkImage image, ref VkImageDrmFormatModifierPropertiesEXT pProperties)
        {
            var f = new PFN_vkGetImageDrmFormatModifierPropertiesEXT(VkLoader.GetFunction(335));
            return f.Call(this, image, ref pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateValidationCacheEXT(in VkValidationCacheCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkValidationCacheEXT pValidationCache)
        {
            var f = new PFN_vkCreateValidationCacheEXT(VkLoader.GetFunction(336));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pValidationCache);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyValidationCacheEXT(VkValidationCacheEXT validationCache, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyValidationCacheEXT(VkLoader.GetFunction(337));
            f.Call(this, validationCache, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkMergeValidationCachesEXT(VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches)
        {
            var f = new PFN_vkMergeValidationCachesEXT(VkLoader.GetFunction(338));
            return f.Call(this, dstCache, srcCacheCount, pSrcCaches);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetValidationCacheDataEXT(VkValidationCacheEXT validationCache, ref ulong pDataSize, void* pData)
        {
            var f = new PFN_vkGetValidationCacheDataEXT(VkLoader.GetFunction(339));
            return f.Call(this, validationCache, ref pDataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateAccelerationStructureNV(in VkAccelerationStructureCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureNV pAccelerationStructure)
        {
            var f = new PFN_vkCreateAccelerationStructureNV(VkLoader.GetFunction(343));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pAccelerationStructure);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyAccelerationStructureNV(VkAccelerationStructureNV accelerationStructure, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyAccelerationStructureNV(VkLoader.GetFunction(344));
            f.Call(this, accelerationStructure, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetAccelerationStructureMemoryRequirementsNV(in VkAccelerationStructureMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetAccelerationStructureMemoryRequirementsNV(VkLoader.GetFunction(345));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBindAccelerationStructureMemoryNV(uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos)
        {
            var f = new PFN_vkBindAccelerationStructureMemoryNV(VkLoader.GetFunction(346));
            return f.Call(this, bindInfoCount, pBindInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateRayTracingPipelinesNV(VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            var f = new PFN_vkCreateRayTracingPipelinesNV(VkLoader.GetFunction(350));
            return f.Call(this, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetRayTracingShaderGroupHandlesKHR(VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData)
        {
            var f = new PFN_vkGetRayTracingShaderGroupHandlesKHR(VkLoader.GetFunction(351));
            return f.Call(this, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetRayTracingShaderGroupHandlesNV(VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData)
        {
            var f = new PFN_vkGetRayTracingShaderGroupHandlesNV(VkLoader.GetFunction(352));
            return f.Call(this, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetAccelerationStructureHandleNV(VkAccelerationStructureNV accelerationStructure, ulong dataSize, void* pData)
        {
            var f = new PFN_vkGetAccelerationStructureHandleNV(VkLoader.GetFunction(353));
            return f.Call(this, accelerationStructure, dataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCompileDeferredNV(VkPipeline pipeline, uint shader)
        {
            var f = new PFN_vkCompileDeferredNV(VkLoader.GetFunction(355));
            return f.Call(this, pipeline, shader);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetMemoryHostPointerPropertiesEXT(VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, ref VkMemoryHostPointerPropertiesEXT pMemoryHostPointerProperties)
        {
            var f = new PFN_vkGetMemoryHostPointerPropertiesEXT(VkLoader.GetFunction(356));
            return f.Call(this, handleType, pHostPointer, ref pMemoryHostPointerProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetCalibratedTimestampsEXT(uint timestampCount, in VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, ref ulong pMaxDeviation)
        {
            var f = new PFN_vkGetCalibratedTimestampsEXT(VkLoader.GetFunction(359));
            return f.Call(this, timestampCount, in pTimestampInfos, pTimestamps, ref pMaxDeviation);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkInitializePerformanceApiINTEL(in VkInitializePerformanceApiInfoINTEL pInitializeInfo)
        {
            var f = new PFN_vkInitializePerformanceApiINTEL(VkLoader.GetFunction(366));
            return f.Call(this, in pInitializeInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkUninitializePerformanceApiINTEL()
        {
            var f = new PFN_vkUninitializePerformanceApiINTEL(VkLoader.GetFunction(367));
            f.Call(this);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAcquirePerformanceConfigurationINTEL(in VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
        {
            var f = new PFN_vkAcquirePerformanceConfigurationINTEL(VkLoader.GetFunction(371));
            return f.Call(this, in pAcquireInfo, ref pConfiguration);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkReleasePerformanceConfigurationINTEL(VkPerformanceConfigurationINTEL configuration)
        {
            var f = new PFN_vkReleasePerformanceConfigurationINTEL(VkLoader.GetFunction(372));
            return f.Call(this, configuration);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPerformanceParameterINTEL(VkPerformanceParameterTypeINTEL parameter, ref VkPerformanceValueINTEL pValue)
        {
            var f = new PFN_vkGetPerformanceParameterINTEL(VkLoader.GetFunction(374));
            return f.Call(this, parameter, ref pValue);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkSetLocalDimmingAMD(VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
        {
            var f = new PFN_vkSetLocalDimmingAMD(VkLoader.GetFunction(375));
            f.Call(this, swapChain, localDimmingEnable);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetBufferDeviceAddressEXT(in VkBufferDeviceAddressInfo pInfo)
        {
            var f = new PFN_vkGetBufferDeviceAddressEXT(VkLoader.GetFunction(376));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkResetQueryPoolEXT(VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            var f = new PFN_vkResetQueryPoolEXT(VkLoader.GetFunction(382));
            f.Call(this, queryPool, firstQuery, queryCount);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetGeneratedCommandsMemoryRequirementsNV(in VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            var f = new PFN_vkGetGeneratedCommandsMemoryRequirementsNV(VkLoader.GetFunction(395));
            f.Call(this, in pInfo, ref pMemoryRequirements);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateIndirectCommandsLayoutNV(in VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            var f = new PFN_vkCreateIndirectCommandsLayoutNV(VkLoader.GetFunction(399));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pIndirectCommandsLayout);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyIndirectCommandsLayoutNV(VkIndirectCommandsLayoutNV indirectCommandsLayout, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyIndirectCommandsLayoutNV(VkLoader.GetFunction(400));
            f.Call(this, indirectCommandsLayout, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreatePrivateDataSlotEXT(in VkPrivateDataSlotCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPrivateDataSlotEXT pPrivateDataSlot)
        {
            var f = new PFN_vkCreatePrivateDataSlotEXT(VkLoader.GetFunction(403));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pPrivateDataSlot);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyPrivateDataSlotEXT(VkPrivateDataSlotEXT privateDataSlot, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyPrivateDataSlotEXT(VkLoader.GetFunction(404));
            f.Call(this, privateDataSlot, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkSetPrivateDataEXT(VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data)
        {
            var f = new PFN_vkSetPrivateDataEXT(VkLoader.GetFunction(405));
            return f.Call(this, objectType, objectHandle, privateDataSlot, data);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPrivateDataEXT(VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ref ulong pData)
        {
            var f = new PFN_vkGetPrivateDataEXT(VkLoader.GetFunction(406));
            f.Call(this, objectType, objectHandle, privateDataSlot, ref pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkRenderPass renderpass, ref VkExtent2D pMaxWorkgroupSize)
        {
            var f = new PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkLoader.GetFunction(411));
            return f.Call(this, renderpass, ref pMaxWorkgroupSize);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetMemoryRemoteAddressNV(in VkMemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, ref VkRemoteAddressNV pAddress)
        {
            var f = new PFN_vkGetMemoryRemoteAddressNV(VkLoader.GetFunction(414));
            return f.Call(this, in pMemoryGetRemoteAddressInfo, ref pAddress);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkSetDeviceMemoryPriorityEXT(VkDeviceMemory memory, float priority)
        {
            var f = new PFN_vkSetDeviceMemoryPriorityEXT(VkLoader.GetFunction(423));
            f.Call(this, memory, priority);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateAccelerationStructureKHR(in VkAccelerationStructureCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureKHR pAccelerationStructure)
        {
            var f = new PFN_vkCreateAccelerationStructureKHR(VkLoader.GetFunction(424));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pAccelerationStructure);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyAccelerationStructureKHR(VkAccelerationStructureKHR accelerationStructure, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyAccelerationStructureKHR(VkLoader.GetFunction(425));
            f.Call(this, accelerationStructure, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkBuildAccelerationStructuresKHR(VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos)
        {
            var f = new PFN_vkBuildAccelerationStructuresKHR(VkLoader.GetFunction(428));
            return f.Call(this, deferredOperation, infoCount, pInfos, ppBuildRangeInfos);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCopyAccelerationStructureKHR(VkDeferredOperationKHR deferredOperation, in VkCopyAccelerationStructureInfoKHR pInfo)
        {
            var f = new PFN_vkCopyAccelerationStructureKHR(VkLoader.GetFunction(429));
            return f.Call(this, deferredOperation, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCopyAccelerationStructureToMemoryKHR(VkDeferredOperationKHR deferredOperation, in VkCopyAccelerationStructureToMemoryInfoKHR pInfo)
        {
            var f = new PFN_vkCopyAccelerationStructureToMemoryKHR(VkLoader.GetFunction(430));
            return f.Call(this, deferredOperation, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCopyMemoryToAccelerationStructureKHR(VkDeferredOperationKHR deferredOperation, in VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
        {
            var f = new PFN_vkCopyMemoryToAccelerationStructureKHR(VkLoader.GetFunction(431));
            return f.Call(this, deferredOperation, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkWriteAccelerationStructuresPropertiesKHR(uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, ulong dataSize, void* pData, ulong stride)
        {
            var f = new PFN_vkWriteAccelerationStructuresPropertiesKHR(VkLoader.GetFunction(432));
            return f.Call(this, accelerationStructureCount, pAccelerationStructures, queryType, dataSize, pData, stride);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetAccelerationStructureDeviceAddressKHR(in VkAccelerationStructureDeviceAddressInfoKHR pInfo)
        {
            var f = new PFN_vkGetAccelerationStructureDeviceAddressKHR(VkLoader.GetFunction(436));
            return f.Call(this, in pInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetDeviceAccelerationStructureCompatibilityKHR(in VkAccelerationStructureVersionInfoKHR pVersionInfo, ref VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            var f = new PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(VkLoader.GetFunction(438));
            f.Call(this, in pVersionInfo, ref pCompatibility);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetAccelerationStructureBuildSizesKHR(VkAccelerationStructureBuildTypeKHR buildType, in VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, in uint pMaxPrimitiveCounts, ref VkAccelerationStructureBuildSizesInfoKHR pSizeInfo)
        {
            var f = new PFN_vkGetAccelerationStructureBuildSizesKHR(VkLoader.GetFunction(439));
            f.Call(this, buildType, in pBuildInfo, in pMaxPrimitiveCounts, ref pSizeInfo);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateRayTracingPipelinesKHR(VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines)
        {
            var f = new PFN_vkCreateRayTracingPipelinesKHR(VkLoader.GetFunction(441));
            return f.Call(this, deferredOperation, pipelineCache, createInfoCount, pCreateInfos, in pAllocator, ref pPipelines);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData)
        {
            var f = new PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR(VkLoader.GetFunction(442));
            return f.Call(this, pipeline, firstGroup, groupCount, dataSize, pData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong vkGetRayTracingShaderGroupStackSizeKHR(VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader)
        {
            var f = new PFN_vkGetRayTracingShaderGroupStackSizeKHR(VkLoader.GetFunction(444));
            return f.Call(this, pipeline, group, groupShader);
        }
    }
}
