using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public static unsafe partial class VkDelegates
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyInstanceDelegate(VkInstance instance, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumeratePhysicalDevicesDelegate(VkInstance instance, ref uint pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFeaturesDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceFeatures pFeatures);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, ref VkFormatProperties pFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, ref VkImageFormatProperties pImageFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDevicePropertiesDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceProperties pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(VkPhysicalDevice physicalDevice, ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceMemoryProperties pMemoryProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkFunctionPointer vkGetInstanceProcAddrDelegate(VkInstance instance, byte* pName);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkFunctionPointer vkGetDeviceProcAddrDelegate(VkDevice device, byte* pName);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDeviceDelegate(VkPhysicalDevice physicalDevice, in VkDeviceCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDevice pDevice);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDeviceDelegate(VkDevice device, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(byte* pLayerName, ref uint pPropertyCount, VkExtensionProperties* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(VkPhysicalDevice physicalDevice, byte* pLayerName, ref uint pPropertyCount, VkExtensionProperties* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkLayerProperties* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceQueueDelegate(VkDevice device, uint queueFamilyIndex, uint queueIndex, ref VkQueue pQueue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueueSubmitDelegate(VkQueue queue, uint submitCount, VkSubmitInfo* pSubmits, VkFence fence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueueWaitIdleDelegate(VkQueue queue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkDeviceWaitIdleDelegate(VkDevice device);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAllocateMemoryDelegate(VkDevice device, in VkMemoryAllocateInfo pAllocateInfo, in VkAllocationCallbacks pAllocator, ref VkDeviceMemory pMemory);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkFreeMemoryDelegate(VkDevice device, VkDeviceMemory memory, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkMapMemoryDelegate(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlags flags, ref void* ppData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkUnmapMemoryDelegate(VkDevice device, VkDeviceMemory memory);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkFlushMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkInvalidateMappedMemoryRangesDelegate(VkDevice device, uint memoryRangeCount, VkMappedMemoryRange* pMemoryRanges);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceMemoryCommitmentDelegate(VkDevice device, VkDeviceMemory memory, ref ulong pCommittedMemoryInBytes);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindBufferMemoryDelegate(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, ulong memoryOffset);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindImageMemoryDelegate(VkDevice device, VkImage image, VkDeviceMemory memory, ulong memoryOffset);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetBufferMemoryRequirementsDelegate(VkDevice device, VkBuffer buffer, ref VkMemoryRequirements pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageMemoryRequirementsDelegate(VkDevice device, VkImage image, ref VkMemoryRequirements pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageSparseMemoryRequirementsDelegate(VkDevice device, VkImage image, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint pPropertyCount, VkSparseImageFormatProperties* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueueBindSparseDelegate(VkQueue queue, uint bindInfoCount, VkBindSparseInfo* pBindInfo, VkFence fence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateFenceDelegate(VkDevice device, in VkFenceCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyFenceDelegate(VkDevice device, VkFence fence, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkResetFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetFenceStatusDelegate(VkDevice device, VkFence fence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkWaitForFencesDelegate(VkDevice device, uint fenceCount, VkFence* pFences, VkBool32 waitAll, ulong timeout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSemaphoreDelegate(VkDevice device, in VkSemaphoreCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSemaphore pSemaphore);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySemaphoreDelegate(VkDevice device, VkSemaphore semaphore, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateEventDelegate(VkDevice device, in VkEventCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkEvent pEvent);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyEventDelegate(VkDevice device, VkEvent _event, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetEventStatusDelegate(VkDevice device, VkEvent _event);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSetEventDelegate(VkDevice device, VkEvent _event);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkResetEventDelegate(VkDevice device, VkEvent _event);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateQueryPoolDelegate(VkDevice device, in VkQueryPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkQueryPool pQueryPool);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetQueryPoolResultsDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, ulong dataSize, void* pData, ulong stride, VkQueryResultFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateBufferDelegate(VkDevice device, in VkBufferCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkBuffer pBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyBufferDelegate(VkDevice device, VkBuffer buffer, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateBufferViewDelegate(VkDevice device, in VkBufferViewCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkBufferView pView);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyBufferViewDelegate(VkDevice device, VkBufferView bufferView, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateImageDelegate(VkDevice device, in VkImageCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkImage pImage);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyImageDelegate(VkDevice device, VkImage image, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageSubresourceLayoutDelegate(VkDevice device, VkImage image, in VkImageSubresource pSubresource, ref VkSubresourceLayout pLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateImageViewDelegate(VkDevice device, in VkImageViewCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkImageView pView);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyImageViewDelegate(VkDevice device, VkImageView imageView, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateShaderModuleDelegate(VkDevice device, in VkShaderModuleCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkShaderModule pShaderModule);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyShaderModuleDelegate(VkDevice device, VkShaderModule shaderModule, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreatePipelineCacheDelegate(VkDevice device, in VkPipelineCacheCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineCache pPipelineCache);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyPipelineCacheDelegate(VkDevice device, VkPipelineCache pipelineCache, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPipelineCacheDataDelegate(VkDevice device, VkPipelineCache pipelineCache, ref ulong pDataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkMergePipelineCachesDelegate(VkDevice device, VkPipelineCache dstCache, uint srcCacheCount, VkPipelineCache* pSrcCaches);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateGraphicsPipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkGraphicsPipelineCreateInfo* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateComputePipelinesDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkComputePipelineCreateInfo* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyPipelineDelegate(VkDevice device, VkPipeline pipeline, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreatePipelineLayoutDelegate(VkDevice device, in VkPipelineLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPipelineLayout pPipelineLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyPipelineLayoutDelegate(VkDevice device, VkPipelineLayout pipelineLayout, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSamplerDelegate(VkDevice device, in VkSamplerCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSampler pSampler);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySamplerDelegate(VkDevice device, VkSampler sampler, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDescriptorSetLayoutDelegate(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorSetLayout pSetLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDescriptorSetLayoutDelegate(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDescriptorPoolDelegate(VkDevice device, in VkDescriptorPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorPool pDescriptorPool);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkResetDescriptorPoolDelegate(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAllocateDescriptorSetsDelegate(VkDevice device, in VkDescriptorSetAllocateInfo pAllocateInfo, ref VkDescriptorSet pDescriptorSets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkFreeDescriptorSetsDelegate(VkDevice device, VkDescriptorPool descriptorPool, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkUpdateDescriptorSetsDelegate(VkDevice device, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites, uint descriptorCopyCount, VkCopyDescriptorSet* pDescriptorCopies);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateFramebufferDelegate(VkDevice device, in VkFramebufferCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkFramebuffer pFramebuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyFramebufferDelegate(VkDevice device, VkFramebuffer framebuffer, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateRenderPassDelegate(VkDevice device, in VkRenderPassCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyRenderPassDelegate(VkDevice device, VkRenderPass renderPass, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetRenderAreaGranularityDelegate(VkDevice device, VkRenderPass renderPass, ref VkExtent2D pGranularity);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateCommandPoolDelegate(VkDevice device, in VkCommandPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCommandPool pCommandPool);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkResetCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAllocateCommandBuffersDelegate(VkDevice device, in VkCommandBufferAllocateInfo pAllocateInfo, ref VkCommandBuffer pCommandBuffers);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkFreeCommandBuffersDelegate(VkDevice device, VkCommandPool commandPool, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBeginCommandBufferDelegate(VkCommandBuffer commandBuffer, in VkCommandBufferBeginInfo pBeginInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEndCommandBufferDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkResetCommandBufferDelegate(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindPipelineDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetViewportDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewport* pViewports);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetScissorDelegate(VkCommandBuffer commandBuffer, uint firstScissor, uint scissorCount, VkRect2D* pScissors);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetLineWidthDelegate(VkCommandBuffer commandBuffer, float lineWidth);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthBiasDelegate(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetBlendConstantsDelegate(VkCommandBuffer commandBuffer, FixedArrayFloatSize4 blendConstants);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthBoundsDelegate(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetStencilCompareMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint compareMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetStencilWriteMaskDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint writeMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetStencilReferenceDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint reference);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindDescriptorSetsDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint descriptorSetCount, VkDescriptorSet* pDescriptorSets, uint dynamicOffsetCount, uint* pDynamicOffsets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindIndexBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkIndexType indexType);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindVertexBuffersDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawDelegate(VkCommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndexedDelegate(VkCommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndexedIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDispatchDelegate(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDispatchIndirectDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint regionCount, VkBufferCopy* pRegions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageCopy* pRegions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBlitImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageBlit* pRegions, VkFilter filter);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyBufferToImageDelegate(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkBufferImageCopy* pRegions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyImageToBufferDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint regionCount, VkBufferImageCopy* pRegions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdUpdateBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong dataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdFillBufferDelegate(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, ulong dstOffset, ulong size, uint data);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdClearColorImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, in VkClearColorValue pColor, uint rangeCount, VkImageSubresourceRange* pRanges);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdClearDepthStencilImageDelegate(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, in VkClearDepthStencilValue pDepthStencil, uint rangeCount, VkImageSubresourceRange* pRanges);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdClearAttachmentsDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkClearAttachment* pAttachments, uint rectCount, VkClearRect* pRects);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdResolveImageDelegate(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint regionCount, VkImageResolve* pRegions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetEventDelegate(VkCommandBuffer commandBuffer, VkEvent _event, VkPipelineStageFlags stageMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdResetEventDelegate(VkCommandBuffer commandBuffer, VkEvent _event, VkPipelineStageFlags stageMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWaitEventsDelegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPipelineBarrierDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint memoryBarrierCount, VkMemoryBarrier* pMemoryBarriers, uint bufferMemoryBarrierCount, VkBufferMemoryBarrier* pBufferMemoryBarriers, uint imageMemoryBarrierCount, VkImageMemoryBarrier* pImageMemoryBarriers);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndQueryDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdResetQueryPoolDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteTimestampDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkQueryPool queryPool, uint query);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyQueryPoolResultsDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint firstQuery, uint queryCount, VkBuffer dstBuffer, ulong dstOffset, ulong stride, VkQueryResultFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPushConstantsDelegate(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint offset, uint size, void* pValues);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginRenderPassDelegate(VkCommandBuffer commandBuffer, in VkRenderPassBeginInfo pRenderPassBegin, VkSubpassContents contents);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdNextSubpassDelegate(VkCommandBuffer commandBuffer, VkSubpassContents contents);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndRenderPassDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdExecuteCommandsDelegate(VkCommandBuffer commandBuffer, uint commandBufferCount, VkCommandBuffer* pCommandBuffers);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindBufferMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindImageMemory2Delegate(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceGroupPeerMemoryFeaturesDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDeviceMaskDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDispatchBaseDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumeratePhysicalDeviceGroupsDelegate(VkInstance instance, ref uint pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageMemoryRequirements2Delegate(VkDevice device, in VkImageMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetBufferMemoryRequirements2Delegate(VkDevice device, in VkBufferMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageSparseMemoryRequirements2Delegate(VkDevice device, in VkImageSparseMemoryRequirementsInfo2 pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFeatures2Delegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceFeatures2 pFeatures);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceProperties2Delegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceProperties2 pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFormatProperties2Delegate(VkPhysicalDevice physicalDevice, VkFormat format, ref VkFormatProperties2 pFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, ref VkImageFormatProperties2 pImageFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceQueueFamilyProperties2Delegate(VkPhysicalDevice physicalDevice, ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceMemoryProperties2Delegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceSparseImageFormatProperties2Delegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, ref uint pPropertyCount, VkSparseImageFormatProperties2* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkTrimCommandPoolDelegate(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceQueue2Delegate(VkDevice device, in VkDeviceQueueInfo2 pQueueInfo, ref VkQueue pQueue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSamplerYcbcrConversionDelegate(VkDevice device, in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySamplerYcbcrConversionDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDescriptorUpdateTemplateDelegate(VkDevice device, in VkDescriptorUpdateTemplateCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorUpdateTemplate pDescriptorUpdateTemplate);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDescriptorUpdateTemplateDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkUpdateDescriptorSetWithTemplateDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalBufferPropertiesDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, ref VkExternalBufferProperties pExternalBufferProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalFencePropertiesDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, ref VkExternalFenceProperties pExternalFenceProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDescriptorSetLayoutSupportDelegate(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndexedIndirectCountDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateRenderPass2Delegate(VkDevice device, in VkRenderPassCreateInfo2 pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginRenderPass2Delegate(VkCommandBuffer commandBuffer, in VkRenderPassBeginInfo pRenderPassBegin, in VkSubpassBeginInfo pSubpassBeginInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdNextSubpass2Delegate(VkCommandBuffer commandBuffer, in VkSubpassBeginInfo pSubpassBeginInfo, in VkSubpassEndInfo pSubpassEndInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndRenderPass2Delegate(VkCommandBuffer commandBuffer, in VkSubpassEndInfo pSubpassEndInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkResetQueryPoolDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSemaphoreCounterValueDelegate(VkDevice device, VkSemaphore semaphore, ref ulong pValue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkWaitSemaphoresDelegate(VkDevice device, in VkSemaphoreWaitInfo pWaitInfo, ulong timeout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSignalSemaphoreDelegate(VkDevice device, in VkSemaphoreSignalInfo pSignalInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetBufferDeviceAddressDelegate(VkDevice device, in VkBufferDeviceAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetBufferOpaqueCaptureAddressDelegate(VkDevice device, in VkBufferDeviceAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressDelegate(VkDevice device, in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySurfaceKHRDelegate(VkInstance instance, VkSurfaceKHR surface, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, VkSurfaceKHR surface, ref VkBool32 pSupported);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref VkSurfaceCapabilitiesKHR pSurfaceCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSwapchainKHRDelegate(VkDevice device, in VkSwapchainCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSwapchainKHR pSwapchain);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySwapchainKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSwapchainImagesKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ref uint pSwapchainImageCount, VkImage* pSwapchainImages);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquireNextImageKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong timeout, VkSemaphore semaphore, VkFence fence, ref uint pImageIndex);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueuePresentKHRDelegate(VkQueue queue, in VkPresentInfoKHR pPresentInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDeviceGroupPresentCapabilitiesKHRDelegate(VkDevice device, ref VkDeviceGroupPresentCapabilitiesKHR pDeviceGroupPresentCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDeviceGroupSurfacePresentModesKHRDelegate(VkDevice device, VkSurfaceKHR surface, ref VkDeviceGroupPresentModeFlagsKHR pModes);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDevicePresentRectanglesKHRDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref uint pRectCount, VkRect2D* pRects);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquireNextImage2KHRDelegate(VkDevice device, in VkAcquireNextImageInfoKHR pAcquireInfo, ref uint pImageIndex);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceDisplayPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPropertiesKHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDisplayPlaneSupportedDisplaysKHRDelegate(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, VkDisplayKHR* pDisplays);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDisplayModePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModePropertiesKHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDisplayModeKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, in VkDisplayModeCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDisplayModeKHR pMode);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDisplayPlaneCapabilitiesKHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayModeKHR mode, uint planeIndex, ref VkDisplayPlaneCapabilitiesKHR pCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDisplayPlaneSurfaceKHRDelegate(VkInstance instance, in VkDisplaySurfaceCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSharedSwapchainsKHRDelegate(VkDevice device, uint swapchainCount, in VkSwapchainCreateInfoKHR pCreateInfos, in VkAllocationCallbacks pAllocator, VkSwapchainKHR* pSwapchains);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginRenderingKHRDelegate(VkCommandBuffer commandBuffer, in VkRenderingInfoKHR pRenderingInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndRenderingKHRDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFeatures2KHRDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceFeatures2 pFeatures);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceProperties2KHRDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceProperties2 pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceFormatProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkFormat format, ref VkFormatProperties2 pFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceImageFormatProperties2KHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, ref VkImageFormatProperties2 pImageFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceQueueFamilyProperties2KHRDelegate(VkPhysicalDevice physicalDevice, ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceMemoryProperties2KHRDelegate(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceSparseImageFormatProperties2KHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, ref uint pPropertyCount, VkSparseImageFormatProperties2* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceGroupPeerMemoryFeaturesKHRDelegate(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDeviceMaskKHRDelegate(VkCommandBuffer commandBuffer, uint deviceMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDispatchBaseKHRDelegate(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkTrimCommandPoolKHRDelegate(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumeratePhysicalDeviceGroupsKHRDelegate(VkInstance instance, ref uint pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalBufferPropertiesKHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, ref VkExternalBufferProperties pExternalBufferProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetMemoryFdKHRDelegate(VkDevice device, in VkMemoryGetFdInfoKHR pGetFdInfo, ref int pFd);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetMemoryFdPropertiesKHRDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, ref VkMemoryFdPropertiesKHR pMemoryFdProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalSemaphorePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkImportSemaphoreFdKHRDelegate(VkDevice device, in VkImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSemaphoreFdKHRDelegate(VkDevice device, in VkSemaphoreGetFdInfoKHR pGetFdInfo, ref int pFd);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPushDescriptorSetKHRDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set, uint descriptorWriteCount, VkWriteDescriptorSet* pDescriptorWrites);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPushDescriptorSetWithTemplateKHRDelegate(VkCommandBuffer commandBuffer, VkDescriptorUpdateTemplate descriptorUpdateTemplate, VkPipelineLayout layout, uint set, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDescriptorUpdateTemplateKHRDelegate(VkDevice device, in VkDescriptorUpdateTemplateCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorUpdateTemplate pDescriptorUpdateTemplate);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDescriptorUpdateTemplateKHRDelegate(VkDevice device, VkDescriptorUpdateTemplate descriptorUpdateTemplate, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkUpdateDescriptorSetWithTemplateKHRDelegate(VkDevice device, VkDescriptorSet descriptorSet, VkDescriptorUpdateTemplate descriptorUpdateTemplate, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateRenderPass2KHRDelegate(VkDevice device, in VkRenderPassCreateInfo2 pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkRenderPass pRenderPass);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginRenderPass2KHRDelegate(VkCommandBuffer commandBuffer, in VkRenderPassBeginInfo pRenderPassBegin, in VkSubpassBeginInfo pSubpassBeginInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdNextSubpass2KHRDelegate(VkCommandBuffer commandBuffer, in VkSubpassBeginInfo pSubpassBeginInfo, in VkSubpassEndInfo pSubpassEndInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndRenderPass2KHRDelegate(VkCommandBuffer commandBuffer, in VkSubpassEndInfo pSubpassEndInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSwapchainStatusKHRDelegate(VkDevice device, VkSwapchainKHR swapchain);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceExternalFencePropertiesKHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, ref VkExternalFenceProperties pExternalFenceProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkImportFenceFdKHRDelegate(VkDevice device, in VkImportFenceFdInfoKHR pImportFenceFdInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetFenceFdKHRDelegate(VkDevice device, in VkFenceGetFdInfoKHR pGetFdInfo, ref int pFd);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHRDelegate(VkPhysicalDevice physicalDevice, uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHRDelegate(VkPhysicalDevice physicalDevice, in VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, ref uint pNumPasses);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquireProfilingLockKHRDelegate(VkDevice device, in VkAcquireProfilingLockInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkReleaseProfilingLockKHRDelegate(VkDevice device);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref VkSurfaceCapabilities2KHR pSurfaceCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceFormats2KHRDelegate(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceDisplayProperties2KHRDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayProperties2KHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHRDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDisplayModeProperties2KHRDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModeProperties2KHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDisplayPlaneCapabilities2KHRDelegate(VkPhysicalDevice physicalDevice, in VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, ref VkDisplayPlaneCapabilities2KHR pCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageMemoryRequirements2KHRDelegate(VkDevice device, in VkImageMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetBufferMemoryRequirements2KHRDelegate(VkDevice device, in VkBufferMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetImageSparseMemoryRequirements2KHRDelegate(VkDevice device, in VkImageSparseMemoryRequirementsInfo2 pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateSamplerYcbcrConversionKHRDelegate(VkDevice device, in VkSamplerYcbcrConversionCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSamplerYcbcrConversion pYcbcrConversion);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroySamplerYcbcrConversionKHRDelegate(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindBufferMemory2KHRDelegate(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindImageMemory2KHRDelegate(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDescriptorSetLayoutSupportKHRDelegate(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndirectCountKHRDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndexedIndirectCountKHRDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSemaphoreCounterValueKHRDelegate(VkDevice device, VkSemaphore semaphore, ref ulong pValue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkWaitSemaphoresKHRDelegate(VkDevice device, in VkSemaphoreWaitInfo pWaitInfo, ulong timeout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSignalSemaphoreKHRDelegate(VkDevice device, in VkSemaphoreSignalInfo pSignalInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceFragmentShadingRatesKHRDelegate(VkPhysicalDevice physicalDevice, ref uint pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetFragmentShadingRateKHRDelegate(VkCommandBuffer commandBuffer, in VkExtent2D pFragmentSize, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkWaitForPresentKHRDelegate(VkDevice device, VkSwapchainKHR swapchain, ulong presentId, ulong timeout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetBufferDeviceAddressKHRDelegate(VkDevice device, in VkBufferDeviceAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetBufferOpaqueCaptureAddressKHRDelegate(VkDevice device, in VkBufferDeviceAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetDeviceMemoryOpaqueCaptureAddressKHRDelegate(VkDevice device, in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDeferredOperationKHRDelegate(VkDevice device, in VkAllocationCallbacks pAllocator, ref VkDeferredOperationKHR pDeferredOperation);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDeferredOperationKHRDelegate(VkDevice device, VkDeferredOperationKHR operation, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint vkGetDeferredOperationMaxConcurrencyKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDeferredOperationResultKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkDeferredOperationJoinKHRDelegate(VkDevice device, VkDeferredOperationKHR operation);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPipelineExecutablePropertiesKHRDelegate(VkDevice device, in VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPipelineExecutableStatisticsKHRDelegate(VkDevice device, in VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pStatisticCount, VkPipelineExecutableStatisticKHR* pStatistics);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPipelineExecutableInternalRepresentationsKHRDelegate(VkDevice device, in VkPipelineExecutableInfoKHR pExecutableInfo, ref uint pInternalRepresentationCount, VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetEvent2KHRDelegate(VkCommandBuffer commandBuffer, VkEvent _event, in VkDependencyInfoKHR pDependencyInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdResetEvent2KHRDelegate(VkCommandBuffer commandBuffer, VkEvent _event, VkPipelineStageFlags2KHR stageMask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWaitEvents2KHRDelegate(VkCommandBuffer commandBuffer, uint eventCount, VkEvent* pEvents, in VkDependencyInfoKHR pDependencyInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPipelineBarrier2KHRDelegate(VkCommandBuffer commandBuffer, in VkDependencyInfoKHR pDependencyInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteTimestamp2KHRDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkQueryPool queryPool, uint query);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueueSubmit2KHRDelegate(VkQueue queue, uint submitCount, VkSubmitInfo2KHR* pSubmits, VkFence fence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteBufferMarker2AMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags2KHR stage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetQueueCheckpointData2NVDelegate(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointData2NV* pCheckpointData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyBuffer2KHRDelegate(VkCommandBuffer commandBuffer, in VkCopyBufferInfo2KHR pCopyBufferInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyImage2KHRDelegate(VkCommandBuffer commandBuffer, in VkCopyImageInfo2KHR pCopyImageInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyBufferToImage2KHRDelegate(VkCommandBuffer commandBuffer, in VkCopyBufferToImageInfo2KHR pCopyBufferToImageInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyImageToBuffer2KHRDelegate(VkCommandBuffer commandBuffer, in VkCopyImageToBufferInfo2KHR pCopyImageToBufferInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBlitImage2KHRDelegate(VkCommandBuffer commandBuffer, in VkBlitImageInfo2KHR pBlitImageInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdResolveImage2KHRDelegate(VkCommandBuffer commandBuffer, in VkResolveImageInfo2KHR pResolveImageInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceBufferMemoryRequirementsKHRDelegate(VkDevice device, in VkDeviceBufferMemoryRequirementsKHR pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceImageMemoryRequirementsKHRDelegate(VkDevice device, in VkDeviceImageMemoryRequirementsKHR pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceImageSparseMemoryRequirementsKHRDelegate(VkDevice device, in VkDeviceImageMemoryRequirementsKHR pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDebugReportCallbackEXTDelegate(VkInstance instance, in VkDebugReportCallbackCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDebugReportCallbackEXT pCallback);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDebugReportCallbackEXTDelegate(VkInstance instance, VkDebugReportCallbackEXT callback, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDebugReportMessageEXTDelegate(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong _object, ulong location, int messageCode, byte* pLayerPrefix, byte* pMessage);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkDebugMarkerSetObjectTagEXTDelegate(VkDevice device, in VkDebugMarkerObjectTagInfoEXT pTagInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkDebugMarkerSetObjectNameEXTDelegate(VkDevice device, in VkDebugMarkerObjectNameInfoEXT pNameInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDebugMarkerBeginEXTDelegate(VkCommandBuffer commandBuffer, in VkDebugMarkerMarkerInfoEXT pMarkerInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDebugMarkerEndEXTDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDebugMarkerInsertEXTDelegate(VkCommandBuffer commandBuffer, in VkDebugMarkerMarkerInfoEXT pMarkerInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindTransformFeedbackBuffersEXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets, in ulong pSizes);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, in ulong pCounterBufferOffsets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndTransformFeedbackEXTDelegate(VkCommandBuffer commandBuffer, uint firstCounterBuffer, uint counterBufferCount, VkBuffer* pCounterBuffers, in ulong pCounterBufferOffsets);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, VkQueryControlFlags flags, uint index);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndQueryIndexedEXTDelegate(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint query, uint index);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndirectByteCountEXTDelegate(VkCommandBuffer commandBuffer, uint instanceCount, uint firstInstance, VkBuffer counterBuffer, ulong counterBufferOffset, uint counterOffset, uint vertexStride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateCuModuleNVXDelegate(VkDevice device, in VkCuModuleCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuModuleNVX pModule);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateCuFunctionNVXDelegate(VkDevice device, in VkCuFunctionCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuFunctionNVX pFunction);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyCuModuleNVXDelegate(VkDevice device, VkCuModuleNVX module, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyCuFunctionNVXDelegate(VkDevice device, VkCuFunctionNVX function, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCuLaunchKernelNVXDelegate(VkCommandBuffer commandBuffer, in VkCuLaunchInfoNVX pLaunchInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint vkGetImageViewHandleNVXDelegate(VkDevice device, in VkImageViewHandleInfoNVX pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetImageViewAddressNVXDelegate(VkDevice device, VkImageView imageView, ref VkImageViewAddressPropertiesNVX pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndirectCountAMDDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawIndexedIndirectCountAMDDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetShaderInfoAMDDelegate(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref ulong pInfoSize, void* pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNVDelegate(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, ref VkExternalImageFormatPropertiesNV pExternalImageFormatProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer, in VkConditionalRenderingBeginInfoEXT pConditionalRenderingBegin);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndConditionalRenderingEXTDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetViewportWScalingNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkViewportWScalingNV* pViewportWScalings);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkReleaseDisplayEXTDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXTDelegate(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, ref VkSurfaceCapabilities2EXT pSurfaceCapabilities);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkDisplayPowerControlEXTDelegate(VkDevice device, VkDisplayKHR display, in VkDisplayPowerInfoEXT pDisplayPowerInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkRegisterDeviceEventEXTDelegate(VkDevice device, in VkDeviceEventInfoEXT pDeviceEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkRegisterDisplayEventEXTDelegate(VkDevice device, VkDisplayKHR display, in VkDisplayEventInfoEXT pDisplayEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetSwapchainCounterEXTDelegate(VkDevice device, VkSwapchainKHR swapchain, VkSurfaceCounterFlagsEXT counter, ref ulong pCounterValue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetRefreshCycleDurationGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, ref VkRefreshCycleDurationGOOGLE pDisplayTimingProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPastPresentationTimingGOOGLEDelegate(VkDevice device, VkSwapchainKHR swapchain, ref uint pPresentationTimingCount, VkPastPresentationTimingGOOGLE* pPresentationTimings);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDiscardRectangleEXTDelegate(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkSetHdrMetadataEXTDelegate(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, in VkHdrMetadataEXT pMetadata);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSetDebugUtilsObjectNameEXTDelegate(VkDevice device, in VkDebugUtilsObjectNameInfoEXT pNameInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSetDebugUtilsObjectTagEXTDelegate(VkDevice device, in VkDebugUtilsObjectTagInfoEXT pTagInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkQueueBeginDebugUtilsLabelEXTDelegate(VkQueue queue, in VkDebugUtilsLabelEXT pLabelInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkQueueEndDebugUtilsLabelEXTDelegate(VkQueue queue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkQueueInsertDebugUtilsLabelEXTDelegate(VkQueue queue, in VkDebugUtilsLabelEXT pLabelInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBeginDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, in VkDebugUtilsLabelEXT pLabelInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdEndDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdInsertDebugUtilsLabelEXTDelegate(VkCommandBuffer commandBuffer, in VkDebugUtilsLabelEXT pLabelInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateDebugUtilsMessengerEXTDelegate(VkInstance instance, in VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDebugUtilsMessengerEXT pMessenger);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyDebugUtilsMessengerEXTDelegate(VkInstance instance, VkDebugUtilsMessengerEXT messenger, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkSubmitDebugUtilsMessageEXTDelegate(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, in VkDebugUtilsMessengerCallbackDataEXT pCallbackData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetSampleLocationsEXTDelegate(VkCommandBuffer commandBuffer, in VkSampleLocationsInfoEXT pSampleLocationsInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPhysicalDeviceMultisamplePropertiesEXTDelegate(VkPhysicalDevice physicalDevice, VkSampleCountFlags samples, ref VkMultisamplePropertiesEXT pMultisampleProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetImageDrmFormatModifierPropertiesEXTDelegate(VkDevice device, VkImage image, ref VkImageDrmFormatModifierPropertiesEXT pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateValidationCacheEXTDelegate(VkDevice device, in VkValidationCacheCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkValidationCacheEXT pValidationCache);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyValidationCacheEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkMergeValidationCachesEXTDelegate(VkDevice device, VkValidationCacheEXT dstCache, uint srcCacheCount, VkValidationCacheEXT* pSrcCaches);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetValidationCacheDataEXTDelegate(VkDevice device, VkValidationCacheEXT validationCache, ref ulong pDataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindShadingRateImageNVDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetViewportShadingRatePaletteNVDelegate(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetCoarseSampleOrderNVDelegate(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateAccelerationStructureNVDelegate(VkDevice device, in VkAccelerationStructureCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureNV pAccelerationStructure);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyAccelerationStructureNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetAccelerationStructureMemoryRequirementsNVDelegate(VkDevice device, in VkAccelerationStructureMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBindAccelerationStructureMemoryNVDelegate(VkDevice device, uint bindInfoCount, VkBindAccelerationStructureMemoryInfoNV* pBindInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBuildAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, in VkAccelerationStructureInfoNV pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyAccelerationStructureNVDelegate(VkCommandBuffer commandBuffer, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkCopyAccelerationStructureModeKHR mode);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdTraceRaysNVDelegate(VkCommandBuffer commandBuffer, VkBuffer raygenShaderBindingTableBuffer, ulong raygenShaderBindingOffset, VkBuffer missShaderBindingTableBuffer, ulong missShaderBindingOffset, ulong missShaderBindingStride, VkBuffer hitShaderBindingTableBuffer, ulong hitShaderBindingOffset, ulong hitShaderBindingStride, VkBuffer callableShaderBindingTableBuffer, ulong callableShaderBindingOffset, ulong callableShaderBindingStride, uint width, uint height, uint depth);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateRayTracingPipelinesNVDelegate(VkDevice device, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoNV* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetRayTracingShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetRayTracingShaderGroupHandlesNVDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetAccelerationStructureHandleNVDelegate(VkDevice device, VkAccelerationStructureNV accelerationStructure, ulong dataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteAccelerationStructuresPropertiesNVDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureNV* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCompileDeferredNVDelegate(VkDevice device, VkPipeline pipeline, uint shader);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetMemoryHostPointerPropertiesEXTDelegate(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, ref VkMemoryHostPointerPropertiesEXT pMemoryHostPointerProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteBufferMarkerAMDDelegate(VkCommandBuffer commandBuffer, VkPipelineStageFlags pipelineStage, VkBuffer dstBuffer, ulong dstOffset, uint marker);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXTDelegate(VkPhysicalDevice physicalDevice, ref uint pTimeDomainCount, VkTimeDomainEXT* pTimeDomains);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetCalibratedTimestampsEXTDelegate(VkDevice device, uint timestampCount, in VkCalibratedTimestampInfoEXT pTimestampInfos, ulong* pTimestamps, ref ulong pMaxDeviation);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawMeshTasksNVDelegate(VkCommandBuffer commandBuffer, uint taskCount, uint firstTask);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawMeshTasksIndirectNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, uint drawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawMeshTasksIndirectCountNVDelegate(VkCommandBuffer commandBuffer, VkBuffer buffer, ulong offset, VkBuffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetExclusiveScissorNVDelegate(VkCommandBuffer commandBuffer, uint firstExclusiveScissor, uint exclusiveScissorCount, VkRect2D* pExclusiveScissors);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetCheckpointNVDelegate(VkCommandBuffer commandBuffer, void* pCheckpointMarker);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetQueueCheckpointDataNVDelegate(VkQueue queue, ref uint pCheckpointDataCount, VkCheckpointDataNV* pCheckpointData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkInitializePerformanceApiINTELDelegate(VkDevice device, in VkInitializePerformanceApiInfoINTEL pInitializeInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkUninitializePerformanceApiINTELDelegate(VkDevice device);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCmdSetPerformanceMarkerINTELDelegate(VkCommandBuffer commandBuffer, in VkPerformanceMarkerInfoINTEL pMarkerInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCmdSetPerformanceStreamMarkerINTELDelegate(VkCommandBuffer commandBuffer, in VkPerformanceStreamMarkerInfoINTEL pMarkerInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCmdSetPerformanceOverrideINTELDelegate(VkCommandBuffer commandBuffer, in VkPerformanceOverrideInfoINTEL pOverrideInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquirePerformanceConfigurationINTELDelegate(VkDevice device, in VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkReleasePerformanceConfigurationINTELDelegate(VkDevice device, VkPerformanceConfigurationINTEL configuration);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkQueueSetPerformanceConfigurationINTELDelegate(VkQueue queue, VkPerformanceConfigurationINTEL configuration);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPerformanceParameterINTELDelegate(VkDevice device, VkPerformanceParameterTypeINTEL parameter, ref VkPerformanceValueINTEL pValue);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkSetLocalDimmingAMDDelegate(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetBufferDeviceAddressEXTDelegate(VkDevice device, in VkBufferDeviceAddressInfo pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceToolPropertiesEXTDelegate(VkPhysicalDevice physicalDevice, ref uint pToolCount, VkPhysicalDeviceToolPropertiesEXT* pToolProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNVDelegate(VkPhysicalDevice physicalDevice, ref uint pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNVDelegate(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateHeadlessSurfaceEXTDelegate(VkInstance instance, in VkHeadlessSurfaceCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetLineStippleEXTDelegate(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkResetQueryPoolEXTDelegate(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetCullModeEXTDelegate(VkCommandBuffer commandBuffer, VkCullModeFlags cullMode);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetFrontFaceEXTDelegate(VkCommandBuffer commandBuffer, VkFrontFace frontFace);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetPrimitiveTopologyEXTDelegate(VkCommandBuffer commandBuffer, VkPrimitiveTopology primitiveTopology);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetViewportWithCountEXTDelegate(VkCommandBuffer commandBuffer, uint viewportCount, VkViewport* pViewports);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetScissorWithCountEXTDelegate(VkCommandBuffer commandBuffer, uint scissorCount, VkRect2D* pScissors);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindVertexBuffers2EXTDelegate(VkCommandBuffer commandBuffer, uint firstBinding, uint bindingCount, VkBuffer* pBuffers, in ulong pOffsets, in ulong pSizes, in ulong pStrides);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthTestEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthWriteEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthWriteEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthCompareOpEXTDelegate(VkCommandBuffer commandBuffer, VkCompareOp depthCompareOp);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthBoundsTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBoundsTestEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetStencilTestEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 stencilTestEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetStencilOpEXTDelegate(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, VkStencilOp failOp, VkStencilOp passOp, VkStencilOp depthFailOp, VkCompareOp compareOp);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetGeneratedCommandsMemoryRequirementsNVDelegate(VkDevice device, in VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdPreprocessGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, in VkGeneratedCommandsInfoNV pGeneratedCommandsInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdExecuteGeneratedCommandsNVDelegate(VkCommandBuffer commandBuffer, VkBool32 isPreprocessed, in VkGeneratedCommandsInfoNV pGeneratedCommandsInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindPipelineShaderGroupNVDelegate(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline, uint groupIndex);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateIndirectCommandsLayoutNVDelegate(VkDevice device, in VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkIndirectCommandsLayoutNV pIndirectCommandsLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyIndirectCommandsLayoutNVDelegate(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquireDrmDisplayEXTDelegate(VkPhysicalDevice physicalDevice, int drmFd, VkDisplayKHR display);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDrmDisplayEXTDelegate(VkPhysicalDevice physicalDevice, int drmFd, uint connectorId, ref VkDisplayKHR display);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreatePrivateDataSlotEXTDelegate(VkDevice device, in VkPrivateDataSlotCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPrivateDataSlotEXT pPrivateDataSlot);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyPrivateDataSlotEXTDelegate(VkDevice device, VkPrivateDataSlotEXT privateDataSlot, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkSetPrivateDataEXTDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ulong data);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetPrivateDataEXTDelegate(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlotEXT privateDataSlot, ref ulong pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetFragmentShadingRateEnumNVDelegate(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkAcquireWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, VkDisplayKHR display);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetWinrtDisplayNVDelegate(VkPhysicalDevice physicalDevice, uint deviceRelativeId, ref VkDisplayKHR pDisplay);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetVertexInputEXTDelegate(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEIDelegate(VkDevice device, VkRenderPass renderpass, ref VkExtent2D pMaxWorkgroupSize);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSubpassShadingHUAWEIDelegate(VkCommandBuffer commandBuffer);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBindInvocationMaskHUAWEIDelegate(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetMemoryRemoteAddressNVDelegate(VkDevice device, in VkMemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, ref VkRemoteAddressNV pAddress);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetPatchControlPointsEXTDelegate(VkCommandBuffer commandBuffer, uint patchControlPoints);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetRasterizerDiscardEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetDepthBiasEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetLogicOpEXTDelegate(VkCommandBuffer commandBuffer, VkLogicOp logicOp);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetPrimitiveRestartEnableEXTDelegate(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetColorWriteEnableEXTDelegate(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawMultiEXTDelegate(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawInfoEXT* pVertexInfo, uint instanceCount, uint firstInstance, uint stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdDrawMultiIndexedEXTDelegate(VkCommandBuffer commandBuffer, uint drawCount, VkMultiDrawIndexedInfoEXT* pIndexInfo, uint instanceCount, uint firstInstance, uint stride, in int pVertexOffset);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkSetDeviceMemoryPriorityEXTDelegate(VkDevice device, VkDeviceMemory memory, float priority);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateAccelerationStructureKHRDelegate(VkDevice device, in VkAccelerationStructureCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureKHR pAccelerationStructure);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkDestroyAccelerationStructureKHRDelegate(VkDevice device, VkAccelerationStructureKHR accelerationStructure, in VkAllocationCallbacks pAllocator);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBuildAccelerationStructuresKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdBuildAccelerationStructuresIndirectKHRDelegate(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, in ulong pIndirectDeviceAddresses, in uint pIndirectStrides, in uint* ppMaxPrimitiveCounts);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkBuildAccelerationStructuresKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, VkAccelerationStructureBuildRangeInfoKHR** ppBuildRangeInfos);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCopyAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, in VkCopyAccelerationStructureInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCopyAccelerationStructureToMemoryKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, in VkCopyAccelerationStructureToMemoryInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCopyMemoryToAccelerationStructureKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, in VkCopyMemoryToAccelerationStructureInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkWriteAccelerationStructuresPropertiesKHRDelegate(VkDevice device, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, ulong dataSize, void* pData, ulong stride);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, in VkCopyAccelerationStructureInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyAccelerationStructureToMemoryKHRDelegate(VkCommandBuffer commandBuffer, in VkCopyAccelerationStructureToMemoryInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdCopyMemoryToAccelerationStructureKHRDelegate(VkCommandBuffer commandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetAccelerationStructureDeviceAddressKHRDelegate(VkDevice device, in VkAccelerationStructureDeviceAddressInfoKHR pInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdWriteAccelerationStructuresPropertiesKHRDelegate(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetDeviceAccelerationStructureCompatibilityKHRDelegate(VkDevice device, in VkAccelerationStructureVersionInfoKHR pVersionInfo, ref VkAccelerationStructureCompatibilityKHR pCompatibility);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkGetAccelerationStructureBuildSizesKHRDelegate(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, in VkAccelerationStructureBuildGeometryInfoKHR pBuildInfo, in uint pMaxPrimitiveCounts, ref VkAccelerationStructureBuildSizesInfoKHR pSizeInfo);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdTraceRaysKHRDelegate(VkCommandBuffer commandBuffer, in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, uint width, uint height, uint depth);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkCreateRayTracingPipelinesKHRDelegate(VkDevice device, VkDeferredOperationKHR deferredOperation, VkPipelineCache pipelineCache, uint createInfoCount, VkRayTracingPipelineCreateInfoKHR* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkPipeline pPipelines);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate VkResult vkGetRayTracingCaptureReplayShaderGroupHandlesKHRDelegate(VkDevice device, VkPipeline pipeline, uint firstGroup, uint groupCount, ulong dataSize, void* pData);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdTraceRaysIndirectKHRDelegate(VkCommandBuffer commandBuffer, in VkStridedDeviceAddressRegionKHR pRaygenShaderBindingTable, in VkStridedDeviceAddressRegionKHR pMissShaderBindingTable, in VkStridedDeviceAddressRegionKHR pHitShaderBindingTable, in VkStridedDeviceAddressRegionKHR pCallableShaderBindingTable, ulong indirectDeviceAddress);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ulong vkGetRayTracingShaderGroupStackSizeKHRDelegate(VkDevice device, VkPipeline pipeline, uint group, VkShaderGroupShaderKHR groupShader);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void vkCmdSetRayTracingPipelineStackSizeKHRDelegate(VkCommandBuffer commandBuffer, uint pipelineStackSize);
        
    }
}
