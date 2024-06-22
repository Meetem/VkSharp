using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkFunctions
    {
        [VkFunctionId(0, true)]
        public PFN_vkDestroyInstance vkDestroyInstance;
        [VkFunctionId(1, true)]
        public PFN_vkEnumeratePhysicalDevices vkEnumeratePhysicalDevices;
        [VkFunctionId(2, true)]
        public PFN_vkGetPhysicalDeviceFeatures vkGetPhysicalDeviceFeatures;
        [VkFunctionId(3, true)]
        public PFN_vkGetPhysicalDeviceFormatProperties vkGetPhysicalDeviceFormatProperties;
        [VkFunctionId(4, true)]
        public PFN_vkGetPhysicalDeviceImageFormatProperties vkGetPhysicalDeviceImageFormatProperties;
        [VkFunctionId(5, true)]
        public PFN_vkGetPhysicalDeviceProperties vkGetPhysicalDeviceProperties;
        [VkFunctionId(6, true)]
        public PFN_vkGetPhysicalDeviceQueueFamilyProperties vkGetPhysicalDeviceQueueFamilyProperties;
        [VkFunctionId(7, true)]
        public PFN_vkGetPhysicalDeviceMemoryProperties vkGetPhysicalDeviceMemoryProperties;
        [VkFunctionId(8, true)]
        public PFN_vkGetInstanceProcAddr vkGetInstanceProcAddr;
        [VkFunctionId(9, true)]
        public PFN_vkGetDeviceProcAddr vkGetDeviceProcAddr;
        [VkFunctionId(10, true)]
        public PFN_vkCreateDevice vkCreateDevice;
        [VkFunctionId(11, true)]
        public PFN_vkDestroyDevice vkDestroyDevice;
        [VkFunctionId(12, true)]
        public PFN_vkEnumerateInstanceExtensionProperties vkEnumerateInstanceExtensionProperties;
        [VkFunctionId(13, true)]
        public PFN_vkEnumerateDeviceExtensionProperties vkEnumerateDeviceExtensionProperties;
        [VkFunctionId(14, true)]
        public PFN_vkEnumerateDeviceLayerProperties vkEnumerateDeviceLayerProperties;
        [VkFunctionId(15, true)]
        public PFN_vkGetDeviceQueue vkGetDeviceQueue;
        [VkFunctionId(16, true)]
        public PFN_vkQueueSubmit vkQueueSubmit;
        [VkFunctionId(17, true)]
        public PFN_vkQueueWaitIdle vkQueueWaitIdle;
        [VkFunctionId(18, true)]
        public PFN_vkDeviceWaitIdle vkDeviceWaitIdle;
        [VkFunctionId(19, true)]
        public PFN_vkAllocateMemory vkAllocateMemory;
        [VkFunctionId(20, true)]
        public PFN_vkFreeMemory vkFreeMemory;
        [VkFunctionId(21, true)]
        public PFN_vkMapMemory vkMapMemory;
        [VkFunctionId(22, true)]
        public PFN_vkUnmapMemory vkUnmapMemory;
        [VkFunctionId(23, true)]
        public PFN_vkFlushMappedMemoryRanges vkFlushMappedMemoryRanges;
        [VkFunctionId(24, true)]
        public PFN_vkInvalidateMappedMemoryRanges vkInvalidateMappedMemoryRanges;
        [VkFunctionId(25, true)]
        public PFN_vkGetDeviceMemoryCommitment vkGetDeviceMemoryCommitment;
        [VkFunctionId(26, true)]
        public PFN_vkBindBufferMemory vkBindBufferMemory;
        [VkFunctionId(27, true)]
        public PFN_vkBindImageMemory vkBindImageMemory;
        [VkFunctionId(28, true)]
        public PFN_vkGetBufferMemoryRequirements vkGetBufferMemoryRequirements;
        [VkFunctionId(29, true)]
        public PFN_vkGetImageMemoryRequirements vkGetImageMemoryRequirements;
        [VkFunctionId(30, true)]
        public PFN_vkGetImageSparseMemoryRequirements vkGetImageSparseMemoryRequirements;
        [VkFunctionId(31, true)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties vkGetPhysicalDeviceSparseImageFormatProperties;
        [VkFunctionId(32, true)]
        public PFN_vkQueueBindSparse vkQueueBindSparse;
        [VkFunctionId(33, true)]
        public PFN_vkCreateFence vkCreateFence;
        [VkFunctionId(34, true)]
        public PFN_vkDestroyFence vkDestroyFence;
        [VkFunctionId(35, true)]
        public PFN_vkResetFences vkResetFences;
        [VkFunctionId(36, true)]
        public PFN_vkGetFenceStatus vkGetFenceStatus;
        [VkFunctionId(37, true)]
        public PFN_vkWaitForFences vkWaitForFences;
        [VkFunctionId(38, true)]
        public PFN_vkCreateSemaphore vkCreateSemaphore;
        [VkFunctionId(39, true)]
        public PFN_vkDestroySemaphore vkDestroySemaphore;
        [VkFunctionId(40, true)]
        public PFN_vkCreateEvent vkCreateEvent;
        [VkFunctionId(41, true)]
        public PFN_vkDestroyEvent vkDestroyEvent;
        [VkFunctionId(42, true)]
        public PFN_vkGetEventStatus vkGetEventStatus;
        [VkFunctionId(43, true)]
        public PFN_vkSetEvent vkSetEvent;
        [VkFunctionId(44, true)]
        public PFN_vkResetEvent vkResetEvent;
        [VkFunctionId(45, true)]
        public PFN_vkCreateQueryPool vkCreateQueryPool;
        [VkFunctionId(46, true)]
        public PFN_vkDestroyQueryPool vkDestroyQueryPool;
        [VkFunctionId(47, true)]
        public PFN_vkGetQueryPoolResults vkGetQueryPoolResults;
        [VkFunctionId(48, true)]
        public PFN_vkCreateBuffer vkCreateBuffer;
        [VkFunctionId(49, true)]
        public PFN_vkDestroyBuffer vkDestroyBuffer;
        [VkFunctionId(50, true)]
        public PFN_vkCreateBufferView vkCreateBufferView;
        [VkFunctionId(51, true)]
        public PFN_vkDestroyBufferView vkDestroyBufferView;
        [VkFunctionId(52, true)]
        public PFN_vkCreateImage vkCreateImage;
        [VkFunctionId(53, true)]
        public PFN_vkDestroyImage vkDestroyImage;
        [VkFunctionId(54, true)]
        public PFN_vkGetImageSubresourceLayout vkGetImageSubresourceLayout;
        [VkFunctionId(55, true)]
        public PFN_vkCreateImageView vkCreateImageView;
        [VkFunctionId(56, true)]
        public PFN_vkDestroyImageView vkDestroyImageView;
        [VkFunctionId(57, true)]
        public PFN_vkCreateShaderModule vkCreateShaderModule;
        [VkFunctionId(58, true)]
        public PFN_vkDestroyShaderModule vkDestroyShaderModule;
        [VkFunctionId(59, true)]
        public PFN_vkCreatePipelineCache vkCreatePipelineCache;
        [VkFunctionId(60, true)]
        public PFN_vkDestroyPipelineCache vkDestroyPipelineCache;
        [VkFunctionId(61, true)]
        public PFN_vkGetPipelineCacheData vkGetPipelineCacheData;
        [VkFunctionId(62, true)]
        public PFN_vkMergePipelineCaches vkMergePipelineCaches;
        [VkFunctionId(63, true)]
        public PFN_vkCreateGraphicsPipelines vkCreateGraphicsPipelines;
        [VkFunctionId(64, true)]
        public PFN_vkCreateComputePipelines vkCreateComputePipelines;
        [VkFunctionId(65, true)]
        public PFN_vkDestroyPipeline vkDestroyPipeline;
        [VkFunctionId(66, true)]
        public PFN_vkCreatePipelineLayout vkCreatePipelineLayout;
        [VkFunctionId(67, true)]
        public PFN_vkDestroyPipelineLayout vkDestroyPipelineLayout;
        [VkFunctionId(68, true)]
        public PFN_vkCreateSampler vkCreateSampler;
        [VkFunctionId(69, true)]
        public PFN_vkDestroySampler vkDestroySampler;
        [VkFunctionId(70, true)]
        public PFN_vkCreateDescriptorSetLayout vkCreateDescriptorSetLayout;
        [VkFunctionId(71, true)]
        public PFN_vkDestroyDescriptorSetLayout vkDestroyDescriptorSetLayout;
        [VkFunctionId(72, true)]
        public PFN_vkCreateDescriptorPool vkCreateDescriptorPool;
        [VkFunctionId(73, true)]
        public PFN_vkDestroyDescriptorPool vkDestroyDescriptorPool;
        [VkFunctionId(74, true)]
        public PFN_vkResetDescriptorPool vkResetDescriptorPool;
        [VkFunctionId(75, true)]
        public PFN_vkAllocateDescriptorSets vkAllocateDescriptorSets;
        [VkFunctionId(76, true)]
        public PFN_vkFreeDescriptorSets vkFreeDescriptorSets;
        [VkFunctionId(77, true)]
        public PFN_vkUpdateDescriptorSets vkUpdateDescriptorSets;
        [VkFunctionId(78, true)]
        public PFN_vkCreateFramebuffer vkCreateFramebuffer;
        [VkFunctionId(79, true)]
        public PFN_vkDestroyFramebuffer vkDestroyFramebuffer;
        [VkFunctionId(80, true)]
        public PFN_vkCreateRenderPass vkCreateRenderPass;
        [VkFunctionId(81, true)]
        public PFN_vkDestroyRenderPass vkDestroyRenderPass;
        [VkFunctionId(82, true)]
        public PFN_vkGetRenderAreaGranularity vkGetRenderAreaGranularity;
        [VkFunctionId(83, true)]
        public PFN_vkCreateCommandPool vkCreateCommandPool;
        [VkFunctionId(84, true)]
        public PFN_vkDestroyCommandPool vkDestroyCommandPool;
        [VkFunctionId(85, true)]
        public PFN_vkResetCommandPool vkResetCommandPool;
        [VkFunctionId(86, true)]
        public PFN_vkAllocateCommandBuffers vkAllocateCommandBuffers;
        [VkFunctionId(87, true)]
        public PFN_vkFreeCommandBuffers vkFreeCommandBuffers;
        [VkFunctionId(88, true)]
        public PFN_vkBeginCommandBuffer vkBeginCommandBuffer;
        [VkFunctionId(89, true)]
        public PFN_vkEndCommandBuffer vkEndCommandBuffer;
        [VkFunctionId(90, true)]
        public PFN_vkResetCommandBuffer vkResetCommandBuffer;
        [VkFunctionId(91, true)]
        public PFN_vkCmdBindPipeline vkCmdBindPipeline;
        [VkFunctionId(92, true)]
        public PFN_vkCmdSetViewport vkCmdSetViewport;
        [VkFunctionId(93, true)]
        public PFN_vkCmdSetScissor vkCmdSetScissor;
        [VkFunctionId(94, true)]
        public PFN_vkCmdSetLineWidth vkCmdSetLineWidth;
        [VkFunctionId(95, true)]
        public PFN_vkCmdSetDepthBias vkCmdSetDepthBias;
        [VkFunctionId(96, true)]
        public PFN_vkCmdSetBlendConstants vkCmdSetBlendConstants;
        [VkFunctionId(97, true)]
        public PFN_vkCmdSetDepthBounds vkCmdSetDepthBounds;
        [VkFunctionId(98, true)]
        public PFN_vkCmdSetStencilCompareMask vkCmdSetStencilCompareMask;
        [VkFunctionId(99, true)]
        public PFN_vkCmdSetStencilWriteMask vkCmdSetStencilWriteMask;
        [VkFunctionId(100, true)]
        public PFN_vkCmdSetStencilReference vkCmdSetStencilReference;
        [VkFunctionId(101, true)]
        public PFN_vkCmdBindDescriptorSets vkCmdBindDescriptorSets;
        [VkFunctionId(102, true)]
        public PFN_vkCmdBindIndexBuffer vkCmdBindIndexBuffer;
        [VkFunctionId(103, true)]
        public PFN_vkCmdBindVertexBuffers vkCmdBindVertexBuffers;
        [VkFunctionId(104, true)]
        public PFN_vkCmdDraw vkCmdDraw;
        [VkFunctionId(105, true)]
        public PFN_vkCmdDrawIndexed vkCmdDrawIndexed;
        [VkFunctionId(106, true)]
        public PFN_vkCmdDrawIndirect vkCmdDrawIndirect;
        [VkFunctionId(107, true)]
        public PFN_vkCmdDrawIndexedIndirect vkCmdDrawIndexedIndirect;
        [VkFunctionId(108, true)]
        public PFN_vkCmdDispatch vkCmdDispatch;
        [VkFunctionId(109, true)]
        public PFN_vkCmdDispatchIndirect vkCmdDispatchIndirect;
        [VkFunctionId(110, true)]
        public PFN_vkCmdCopyBuffer vkCmdCopyBuffer;
        [VkFunctionId(111, true)]
        public PFN_vkCmdCopyImage vkCmdCopyImage;
        [VkFunctionId(112, true)]
        public PFN_vkCmdBlitImage vkCmdBlitImage;
        [VkFunctionId(113, true)]
        public PFN_vkCmdCopyBufferToImage vkCmdCopyBufferToImage;
        [VkFunctionId(114, true)]
        public PFN_vkCmdCopyImageToBuffer vkCmdCopyImageToBuffer;
        [VkFunctionId(115, true)]
        public PFN_vkCmdUpdateBuffer vkCmdUpdateBuffer;
        [VkFunctionId(116, true)]
        public PFN_vkCmdFillBuffer vkCmdFillBuffer;
        [VkFunctionId(117, true)]
        public PFN_vkCmdClearColorImage vkCmdClearColorImage;
        [VkFunctionId(118, true)]
        public PFN_vkCmdClearDepthStencilImage vkCmdClearDepthStencilImage;
        [VkFunctionId(119, true)]
        public PFN_vkCmdClearAttachments vkCmdClearAttachments;
        [VkFunctionId(120, true)]
        public PFN_vkCmdResolveImage vkCmdResolveImage;
        [VkFunctionId(121, true)]
        public PFN_vkCmdSetEvent vkCmdSetEvent;
        [VkFunctionId(122, true)]
        public PFN_vkCmdResetEvent vkCmdResetEvent;
        [VkFunctionId(123, true)]
        public PFN_vkCmdWaitEvents vkCmdWaitEvents;
        [VkFunctionId(124, true)]
        public PFN_vkCmdPipelineBarrier vkCmdPipelineBarrier;
        [VkFunctionId(125, true)]
        public PFN_vkCmdBeginQuery vkCmdBeginQuery;
        [VkFunctionId(126, true)]
        public PFN_vkCmdEndQuery vkCmdEndQuery;
        [VkFunctionId(127, true)]
        public PFN_vkCmdResetQueryPool vkCmdResetQueryPool;
        [VkFunctionId(128, true)]
        public PFN_vkCmdWriteTimestamp vkCmdWriteTimestamp;
        [VkFunctionId(129, true)]
        public PFN_vkCmdCopyQueryPoolResults vkCmdCopyQueryPoolResults;
        [VkFunctionId(130, true)]
        public PFN_vkCmdPushConstants vkCmdPushConstants;
        [VkFunctionId(131, true)]
        public PFN_vkCmdBeginRenderPass vkCmdBeginRenderPass;
        [VkFunctionId(132, true)]
        public PFN_vkCmdNextSubpass vkCmdNextSubpass;
        [VkFunctionId(133, true)]
        public PFN_vkCmdEndRenderPass vkCmdEndRenderPass;
        [VkFunctionId(134, true)]
        public PFN_vkCmdExecuteCommands vkCmdExecuteCommands;
        [VkFunctionId(135, true)]
        public PFN_vkBindBufferMemory2 vkBindBufferMemory2;
        [VkFunctionId(136, true)]
        public PFN_vkBindImageMemory2 vkBindImageMemory2;
        [VkFunctionId(137, true)]
        public PFN_vkGetDeviceGroupPeerMemoryFeatures vkGetDeviceGroupPeerMemoryFeatures;
        [VkFunctionId(138, true)]
        public PFN_vkCmdSetDeviceMask vkCmdSetDeviceMask;
        [VkFunctionId(139, true)]
        public PFN_vkCmdDispatchBase vkCmdDispatchBase;
        [VkFunctionId(140, true)]
        public PFN_vkEnumeratePhysicalDeviceGroups vkEnumeratePhysicalDeviceGroups;
        [VkFunctionId(141, true)]
        public PFN_vkGetImageMemoryRequirements2 vkGetImageMemoryRequirements2;
        [VkFunctionId(142, true)]
        public PFN_vkGetBufferMemoryRequirements2 vkGetBufferMemoryRequirements2;
        [VkFunctionId(143, true)]
        public PFN_vkGetImageSparseMemoryRequirements2 vkGetImageSparseMemoryRequirements2;
        [VkFunctionId(144, true)]
        public PFN_vkGetPhysicalDeviceFeatures2 vkGetPhysicalDeviceFeatures2;
        [VkFunctionId(145, true)]
        public PFN_vkGetPhysicalDeviceProperties2 vkGetPhysicalDeviceProperties2;
        [VkFunctionId(146, true)]
        public PFN_vkGetPhysicalDeviceFormatProperties2 vkGetPhysicalDeviceFormatProperties2;
        [VkFunctionId(147, true)]
        public PFN_vkGetPhysicalDeviceImageFormatProperties2 vkGetPhysicalDeviceImageFormatProperties2;
        [VkFunctionId(148, true)]
        public PFN_vkGetPhysicalDeviceQueueFamilyProperties2 vkGetPhysicalDeviceQueueFamilyProperties2;
        [VkFunctionId(149, true)]
        public PFN_vkGetPhysicalDeviceMemoryProperties2 vkGetPhysicalDeviceMemoryProperties2;
        [VkFunctionId(150, true)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2 vkGetPhysicalDeviceSparseImageFormatProperties2;
        [VkFunctionId(151, true)]
        public PFN_vkTrimCommandPool vkTrimCommandPool;
        [VkFunctionId(152, true)]
        public PFN_vkGetDeviceQueue2 vkGetDeviceQueue2;
        [VkFunctionId(153, true)]
        public PFN_vkCreateSamplerYcbcrConversion vkCreateSamplerYcbcrConversion;
        [VkFunctionId(154, true)]
        public PFN_vkDestroySamplerYcbcrConversion vkDestroySamplerYcbcrConversion;
        [VkFunctionId(155, true)]
        public PFN_vkCreateDescriptorUpdateTemplate vkCreateDescriptorUpdateTemplate;
        [VkFunctionId(156, true)]
        public PFN_vkDestroyDescriptorUpdateTemplate vkDestroyDescriptorUpdateTemplate;
        [VkFunctionId(157, true)]
        public PFN_vkUpdateDescriptorSetWithTemplate vkUpdateDescriptorSetWithTemplate;
        [VkFunctionId(158, true)]
        public PFN_vkGetPhysicalDeviceExternalBufferProperties vkGetPhysicalDeviceExternalBufferProperties;
        [VkFunctionId(159, true)]
        public PFN_vkGetPhysicalDeviceExternalFenceProperties vkGetPhysicalDeviceExternalFenceProperties;
        [VkFunctionId(160, true)]
        public PFN_vkGetPhysicalDeviceExternalSemaphoreProperties vkGetPhysicalDeviceExternalSemaphoreProperties;
        [VkFunctionId(161, true)]
        public PFN_vkGetDescriptorSetLayoutSupport vkGetDescriptorSetLayoutSupport;
        [VkFunctionId(162, true)]
        public PFN_vkCmdDrawIndirectCount vkCmdDrawIndirectCount;
        [VkFunctionId(163, true)]
        public PFN_vkCmdDrawIndexedIndirectCount vkCmdDrawIndexedIndirectCount;
        [VkFunctionId(164, true)]
        public PFN_vkCreateRenderPass2 vkCreateRenderPass2;
        [VkFunctionId(165, true)]
        public PFN_vkCmdBeginRenderPass2 vkCmdBeginRenderPass2;
        [VkFunctionId(166, true)]
        public PFN_vkCmdNextSubpass2 vkCmdNextSubpass2;
        [VkFunctionId(167, true)]
        public PFN_vkCmdEndRenderPass2 vkCmdEndRenderPass2;
        [VkFunctionId(168, true)]
        public PFN_vkResetQueryPool vkResetQueryPool;
        [VkFunctionId(169, true)]
        public PFN_vkGetSemaphoreCounterValue vkGetSemaphoreCounterValue;
        [VkFunctionId(170, true)]
        public PFN_vkWaitSemaphores vkWaitSemaphores;
        [VkFunctionId(171, true)]
        public PFN_vkSignalSemaphore vkSignalSemaphore;
        [VkFunctionId(172, true)]
        public PFN_vkGetBufferDeviceAddress vkGetBufferDeviceAddress;
        [VkFunctionId(173, true)]
        public PFN_vkGetBufferOpaqueCaptureAddress vkGetBufferOpaqueCaptureAddress;
        [VkFunctionId(174, true)]
        public PFN_vkGetDeviceMemoryOpaqueCaptureAddress vkGetDeviceMemoryOpaqueCaptureAddress;
        [VkFunctionId(175, true)]
        public PFN_vkGetPhysicalDeviceToolProperties vkGetPhysicalDeviceToolProperties;
        [VkFunctionId(176, true)]
        public PFN_vkCreatePrivateDataSlot vkCreatePrivateDataSlot;
        [VkFunctionId(177, true)]
        public PFN_vkDestroyPrivateDataSlot vkDestroyPrivateDataSlot;
        [VkFunctionId(178, true)]
        public PFN_vkSetPrivateData vkSetPrivateData;
        [VkFunctionId(179, true)]
        public PFN_vkGetPrivateData vkGetPrivateData;
        [VkFunctionId(180, true)]
        public PFN_vkCmdSetEvent2 vkCmdSetEvent2;
        [VkFunctionId(181, true)]
        public PFN_vkCmdResetEvent2 vkCmdResetEvent2;
        [VkFunctionId(182, true)]
        public PFN_vkCmdWaitEvents2 vkCmdWaitEvents2;
        [VkFunctionId(183, true)]
        public PFN_vkCmdPipelineBarrier2 vkCmdPipelineBarrier2;
        [VkFunctionId(184, true)]
        public PFN_vkCmdWriteTimestamp2 vkCmdWriteTimestamp2;
        [VkFunctionId(185, true)]
        public PFN_vkQueueSubmit2 vkQueueSubmit2;
        [VkFunctionId(186, true)]
        public PFN_vkCmdCopyBuffer2 vkCmdCopyBuffer2;
        [VkFunctionId(187, true)]
        public PFN_vkCmdCopyImage2 vkCmdCopyImage2;
        [VkFunctionId(188, true)]
        public PFN_vkCmdCopyBufferToImage2 vkCmdCopyBufferToImage2;
        [VkFunctionId(189, true)]
        public PFN_vkCmdCopyImageToBuffer2 vkCmdCopyImageToBuffer2;
        [VkFunctionId(190, true)]
        public PFN_vkCmdBlitImage2 vkCmdBlitImage2;
        [VkFunctionId(191, true)]
        public PFN_vkCmdResolveImage2 vkCmdResolveImage2;
        [VkFunctionId(192, true)]
        public PFN_vkCmdBeginRendering vkCmdBeginRendering;
        [VkFunctionId(193, true)]
        public PFN_vkCmdEndRendering vkCmdEndRendering;
        [VkFunctionId(194, true)]
        public PFN_vkCmdSetCullMode vkCmdSetCullMode;
        [VkFunctionId(195, true)]
        public PFN_vkCmdSetFrontFace vkCmdSetFrontFace;
        [VkFunctionId(196, true)]
        public PFN_vkCmdSetPrimitiveTopology vkCmdSetPrimitiveTopology;
        [VkFunctionId(197, true)]
        public PFN_vkCmdSetViewportWithCount vkCmdSetViewportWithCount;
        [VkFunctionId(198, true)]
        public PFN_vkCmdSetScissorWithCount vkCmdSetScissorWithCount;
        [VkFunctionId(199, true)]
        public PFN_vkCmdBindVertexBuffers2 vkCmdBindVertexBuffers2;
        [VkFunctionId(200, true)]
        public PFN_vkCmdSetDepthTestEnable vkCmdSetDepthTestEnable;
        [VkFunctionId(201, true)]
        public PFN_vkCmdSetDepthWriteEnable vkCmdSetDepthWriteEnable;
        [VkFunctionId(202, true)]
        public PFN_vkCmdSetDepthCompareOp vkCmdSetDepthCompareOp;
        [VkFunctionId(203, true)]
        public PFN_vkCmdSetDepthBoundsTestEnable vkCmdSetDepthBoundsTestEnable;
        [VkFunctionId(204, true)]
        public PFN_vkCmdSetStencilTestEnable vkCmdSetStencilTestEnable;
        [VkFunctionId(205, true)]
        public PFN_vkCmdSetStencilOp vkCmdSetStencilOp;
        [VkFunctionId(206, true)]
        public PFN_vkCmdSetRasterizerDiscardEnable vkCmdSetRasterizerDiscardEnable;
        [VkFunctionId(207, true)]
        public PFN_vkCmdSetDepthBiasEnable vkCmdSetDepthBiasEnable;
        [VkFunctionId(208, true)]
        public PFN_vkCmdSetPrimitiveRestartEnable vkCmdSetPrimitiveRestartEnable;
        [VkFunctionId(209, true)]
        public PFN_vkGetDeviceBufferMemoryRequirements vkGetDeviceBufferMemoryRequirements;
        [VkFunctionId(210, true)]
        public PFN_vkGetDeviceImageMemoryRequirements vkGetDeviceImageMemoryRequirements;
        [VkFunctionId(211, true)]
        public PFN_vkGetDeviceImageSparseMemoryRequirements vkGetDeviceImageSparseMemoryRequirements;
        [VkFunctionId(212, true)]
        public PFN_vkDestroySurfaceKHR vkDestroySurfaceKHR;
        [VkFunctionId(213, true)]
        public PFN_vkGetPhysicalDeviceSurfaceSupportKHR vkGetPhysicalDeviceSurfaceSupportKHR;
        [VkFunctionId(214, true)]
        public PFN_vkGetPhysicalDeviceSurfaceCapabilitiesKHR vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
        [VkFunctionId(215, true)]
        public PFN_vkGetPhysicalDeviceSurfaceFormatsKHR vkGetPhysicalDeviceSurfaceFormatsKHR;
        [VkFunctionId(216, true)]
        public PFN_vkGetPhysicalDeviceSurfacePresentModesKHR vkGetPhysicalDeviceSurfacePresentModesKHR;
        [VkFunctionId(217, true)]
        public PFN_vkCreateSwapchainKHR vkCreateSwapchainKHR;
        [VkFunctionId(218, true)]
        public PFN_vkDestroySwapchainKHR vkDestroySwapchainKHR;
        [VkFunctionId(219, true)]
        public PFN_vkGetSwapchainImagesKHR vkGetSwapchainImagesKHR;
        [VkFunctionId(220, true)]
        public PFN_vkAcquireNextImageKHR vkAcquireNextImageKHR;
        [VkFunctionId(221, true)]
        public PFN_vkQueuePresentKHR vkQueuePresentKHR;
        [VkFunctionId(222, true)]
        public PFN_vkGetDeviceGroupPresentCapabilitiesKHR vkGetDeviceGroupPresentCapabilitiesKHR;
        [VkFunctionId(223, true)]
        public PFN_vkGetDeviceGroupSurfacePresentModesKHR vkGetDeviceGroupSurfacePresentModesKHR;
        [VkFunctionId(224, true)]
        public PFN_vkGetPhysicalDevicePresentRectanglesKHR vkGetPhysicalDevicePresentRectanglesKHR;
        [VkFunctionId(225, true)]
        public PFN_vkAcquireNextImage2KHR vkAcquireNextImage2KHR;
        [VkFunctionId(226, true)]
        public PFN_vkGetPhysicalDeviceDisplayPropertiesKHR vkGetPhysicalDeviceDisplayPropertiesKHR;
        [VkFunctionId(227, true)]
        public PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
        [VkFunctionId(228, true)]
        public PFN_vkGetDisplayPlaneSupportedDisplaysKHR vkGetDisplayPlaneSupportedDisplaysKHR;
        [VkFunctionId(229, true)]
        public PFN_vkGetDisplayModePropertiesKHR vkGetDisplayModePropertiesKHR;
        [VkFunctionId(230, true)]
        public PFN_vkCreateDisplayModeKHR vkCreateDisplayModeKHR;
        [VkFunctionId(231, true)]
        public PFN_vkGetDisplayPlaneCapabilitiesKHR vkGetDisplayPlaneCapabilitiesKHR;
        [VkFunctionId(232, true)]
        public PFN_vkCreateDisplayPlaneSurfaceKHR vkCreateDisplayPlaneSurfaceKHR;
        [VkFunctionId(233, true)]
        public PFN_vkCreateSharedSwapchainsKHR vkCreateSharedSwapchainsKHR;
        [VkFunctionId(234, true)]
        public PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR vkGetPhysicalDeviceVideoCapabilitiesKHR;
        [VkFunctionId(235, true)]
        public PFN_vkGetPhysicalDeviceVideoFormatPropertiesKHR vkGetPhysicalDeviceVideoFormatPropertiesKHR;
        [VkFunctionId(236, true)]
        public PFN_vkCreateVideoSessionKHR vkCreateVideoSessionKHR;
        [VkFunctionId(237, true)]
        public PFN_vkDestroyVideoSessionKHR vkDestroyVideoSessionKHR;
        [VkFunctionId(238, true)]
        public PFN_vkGetVideoSessionMemoryRequirementsKHR vkGetVideoSessionMemoryRequirementsKHR;
        [VkFunctionId(239, true)]
        public PFN_vkBindVideoSessionMemoryKHR vkBindVideoSessionMemoryKHR;
        [VkFunctionId(240, true)]
        public PFN_vkCreateVideoSessionParametersKHR vkCreateVideoSessionParametersKHR;
        [VkFunctionId(241, true)]
        public PFN_vkUpdateVideoSessionParametersKHR vkUpdateVideoSessionParametersKHR;
        [VkFunctionId(242, true)]
        public PFN_vkDestroyVideoSessionParametersKHR vkDestroyVideoSessionParametersKHR;
        [VkFunctionId(243, true)]
        public PFN_vkCmdBeginVideoCodingKHR vkCmdBeginVideoCodingKHR;
        [VkFunctionId(244, true)]
        public PFN_vkCmdEndVideoCodingKHR vkCmdEndVideoCodingKHR;
        [VkFunctionId(245, true)]
        public PFN_vkCmdControlVideoCodingKHR vkCmdControlVideoCodingKHR;
        [VkFunctionId(246, true)]
        public PFN_vkCmdDecodeVideoKHR vkCmdDecodeVideoKHR;
        [VkFunctionId(247, true)]
        public PFN_vkCmdBeginRenderingKHR vkCmdBeginRenderingKHR;
        [VkFunctionId(248, true)]
        public PFN_vkCmdEndRenderingKHR vkCmdEndRenderingKHR;
        [VkFunctionId(249, true)]
        public PFN_vkGetPhysicalDeviceFeatures2KHR vkGetPhysicalDeviceFeatures2KHR;
        [VkFunctionId(250, true)]
        public PFN_vkGetPhysicalDeviceProperties2KHR vkGetPhysicalDeviceProperties2KHR;
        [VkFunctionId(251, true)]
        public PFN_vkGetPhysicalDeviceFormatProperties2KHR vkGetPhysicalDeviceFormatProperties2KHR;
        [VkFunctionId(252, true)]
        public PFN_vkGetPhysicalDeviceImageFormatProperties2KHR vkGetPhysicalDeviceImageFormatProperties2KHR;
        [VkFunctionId(253, true)]
        public PFN_vkGetPhysicalDeviceQueueFamilyProperties2KHR vkGetPhysicalDeviceQueueFamilyProperties2KHR;
        [VkFunctionId(254, true)]
        public PFN_vkGetPhysicalDeviceMemoryProperties2KHR vkGetPhysicalDeviceMemoryProperties2KHR;
        [VkFunctionId(255, true)]
        public PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR vkGetPhysicalDeviceSparseImageFormatProperties2KHR;
        [VkFunctionId(256, true)]
        public PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR vkGetDeviceGroupPeerMemoryFeaturesKHR;
        [VkFunctionId(257, true)]
        public PFN_vkCmdSetDeviceMaskKHR vkCmdSetDeviceMaskKHR;
        [VkFunctionId(258, true)]
        public PFN_vkCmdDispatchBaseKHR vkCmdDispatchBaseKHR;
        [VkFunctionId(259, true)]
        public PFN_vkTrimCommandPoolKHR vkTrimCommandPoolKHR;
        [VkFunctionId(260, true)]
        public PFN_vkEnumeratePhysicalDeviceGroupsKHR vkEnumeratePhysicalDeviceGroupsKHR;
        [VkFunctionId(261, true)]
        public PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR vkGetPhysicalDeviceExternalBufferPropertiesKHR;
        [VkFunctionId(262, true)]
        public PFN_vkGetMemoryFdKHR vkGetMemoryFdKHR;
        [VkFunctionId(263, true)]
        public PFN_vkGetMemoryFdPropertiesKHR vkGetMemoryFdPropertiesKHR;
        [VkFunctionId(264, true)]
        public PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR vkGetPhysicalDeviceExternalSemaphorePropertiesKHR;
        [VkFunctionId(265, true)]
        public PFN_vkImportSemaphoreFdKHR vkImportSemaphoreFdKHR;
        [VkFunctionId(266, true)]
        public PFN_vkGetSemaphoreFdKHR vkGetSemaphoreFdKHR;
        [VkFunctionId(267, true)]
        public PFN_vkCmdPushDescriptorSetKHR vkCmdPushDescriptorSetKHR;
        [VkFunctionId(268, true)]
        public PFN_vkCmdPushDescriptorSetWithTemplateKHR vkCmdPushDescriptorSetWithTemplateKHR;
        [VkFunctionId(269, true)]
        public PFN_vkCreateDescriptorUpdateTemplateKHR vkCreateDescriptorUpdateTemplateKHR;
        [VkFunctionId(270, true)]
        public PFN_vkDestroyDescriptorUpdateTemplateKHR vkDestroyDescriptorUpdateTemplateKHR;
        [VkFunctionId(271, true)]
        public PFN_vkUpdateDescriptorSetWithTemplateKHR vkUpdateDescriptorSetWithTemplateKHR;
        [VkFunctionId(272, true)]
        public PFN_vkCreateRenderPass2KHR vkCreateRenderPass2KHR;
        [VkFunctionId(273, true)]
        public PFN_vkCmdBeginRenderPass2KHR vkCmdBeginRenderPass2KHR;
        [VkFunctionId(274, true)]
        public PFN_vkCmdNextSubpass2KHR vkCmdNextSubpass2KHR;
        [VkFunctionId(275, true)]
        public PFN_vkCmdEndRenderPass2KHR vkCmdEndRenderPass2KHR;
        [VkFunctionId(276, true)]
        public PFN_vkGetSwapchainStatusKHR vkGetSwapchainStatusKHR;
        [VkFunctionId(277, true)]
        public PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR vkGetPhysicalDeviceExternalFencePropertiesKHR;
        [VkFunctionId(278, true)]
        public PFN_vkImportFenceFdKHR vkImportFenceFdKHR;
        [VkFunctionId(279, true)]
        public PFN_vkGetFenceFdKHR vkGetFenceFdKHR;
        [VkFunctionId(280, true)]
        public PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
        [VkFunctionId(281, true)]
        public PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
        [VkFunctionId(282, true)]
        public PFN_vkAcquireProfilingLockKHR vkAcquireProfilingLockKHR;
        [VkFunctionId(283, true)]
        public PFN_vkReleaseProfilingLockKHR vkReleaseProfilingLockKHR;
        [VkFunctionId(284, true)]
        public PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR vkGetPhysicalDeviceSurfaceCapabilities2KHR;
        [VkFunctionId(285, true)]
        public PFN_vkGetPhysicalDeviceSurfaceFormats2KHR vkGetPhysicalDeviceSurfaceFormats2KHR;
        [VkFunctionId(286, true)]
        public PFN_vkGetPhysicalDeviceDisplayProperties2KHR vkGetPhysicalDeviceDisplayProperties2KHR;
        [VkFunctionId(287, true)]
        public PFN_vkGetPhysicalDeviceDisplayPlaneProperties2KHR vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
        [VkFunctionId(288, true)]
        public PFN_vkGetDisplayModeProperties2KHR vkGetDisplayModeProperties2KHR;
        [VkFunctionId(289, true)]
        public PFN_vkGetDisplayPlaneCapabilities2KHR vkGetDisplayPlaneCapabilities2KHR;
        [VkFunctionId(290, true)]
        public PFN_vkGetImageMemoryRequirements2KHR vkGetImageMemoryRequirements2KHR;
        [VkFunctionId(291, true)]
        public PFN_vkGetBufferMemoryRequirements2KHR vkGetBufferMemoryRequirements2KHR;
        [VkFunctionId(292, true)]
        public PFN_vkGetImageSparseMemoryRequirements2KHR vkGetImageSparseMemoryRequirements2KHR;
        [VkFunctionId(293, true)]
        public PFN_vkCreateSamplerYcbcrConversionKHR vkCreateSamplerYcbcrConversionKHR;
        [VkFunctionId(294, true)]
        public PFN_vkDestroySamplerYcbcrConversionKHR vkDestroySamplerYcbcrConversionKHR;
        [VkFunctionId(295, true)]
        public PFN_vkBindBufferMemory2KHR vkBindBufferMemory2KHR;
        [VkFunctionId(296, true)]
        public PFN_vkBindImageMemory2KHR vkBindImageMemory2KHR;
        [VkFunctionId(297, true)]
        public PFN_vkGetDescriptorSetLayoutSupportKHR vkGetDescriptorSetLayoutSupportKHR;
        [VkFunctionId(298, true)]
        public PFN_vkCmdDrawIndirectCountKHR vkCmdDrawIndirectCountKHR;
        [VkFunctionId(299, true)]
        public PFN_vkCmdDrawIndexedIndirectCountKHR vkCmdDrawIndexedIndirectCountKHR;
        [VkFunctionId(300, true)]
        public PFN_vkGetSemaphoreCounterValueKHR vkGetSemaphoreCounterValueKHR;
        [VkFunctionId(301, true)]
        public PFN_vkWaitSemaphoresKHR vkWaitSemaphoresKHR;
        [VkFunctionId(302, true)]
        public PFN_vkSignalSemaphoreKHR vkSignalSemaphoreKHR;
        [VkFunctionId(303, true)]
        public PFN_vkGetPhysicalDeviceFragmentShadingRatesKHR vkGetPhysicalDeviceFragmentShadingRatesKHR;
        [VkFunctionId(304, true)]
        public PFN_vkCmdSetFragmentShadingRateKHR vkCmdSetFragmentShadingRateKHR;
        [VkFunctionId(305, true)]
        public PFN_vkCmdSetRenderingAttachmentLocationsKHR vkCmdSetRenderingAttachmentLocationsKHR;
        [VkFunctionId(306, true)]
        public PFN_vkCmdSetRenderingInputAttachmentIndicesKHR vkCmdSetRenderingInputAttachmentIndicesKHR;
        [VkFunctionId(307, true)]
        public PFN_vkWaitForPresentKHR vkWaitForPresentKHR;
        [VkFunctionId(308, true)]
        public PFN_vkGetBufferDeviceAddressKHR vkGetBufferDeviceAddressKHR;
        [VkFunctionId(309, true)]
        public PFN_vkGetBufferOpaqueCaptureAddressKHR vkGetBufferOpaqueCaptureAddressKHR;
        [VkFunctionId(310, true)]
        public PFN_vkGetDeviceMemoryOpaqueCaptureAddressKHR vkGetDeviceMemoryOpaqueCaptureAddressKHR;
        [VkFunctionId(311, true)]
        public PFN_vkCreateDeferredOperationKHR vkCreateDeferredOperationKHR;
        [VkFunctionId(312, true)]
        public PFN_vkDestroyDeferredOperationKHR vkDestroyDeferredOperationKHR;
        [VkFunctionId(313, true)]
        public PFN_vkGetDeferredOperationMaxConcurrencyKHR vkGetDeferredOperationMaxConcurrencyKHR;
        [VkFunctionId(314, true)]
        public PFN_vkGetDeferredOperationResultKHR vkGetDeferredOperationResultKHR;
        [VkFunctionId(315, true)]
        public PFN_vkDeferredOperationJoinKHR vkDeferredOperationJoinKHR;
        [VkFunctionId(316, true)]
        public PFN_vkGetPipelineExecutablePropertiesKHR vkGetPipelineExecutablePropertiesKHR;
        [VkFunctionId(317, true)]
        public PFN_vkGetPipelineExecutableStatisticsKHR vkGetPipelineExecutableStatisticsKHR;
        [VkFunctionId(318, true)]
        public PFN_vkGetPipelineExecutableInternalRepresentationsKHR vkGetPipelineExecutableInternalRepresentationsKHR;
        [VkFunctionId(319, true)]
        public PFN_vkMapMemory2KHR vkMapMemory2KHR;
        [VkFunctionId(320, true)]
        public PFN_vkUnmapMemory2KHR vkUnmapMemory2KHR;
        [VkFunctionId(321, true)]
        public PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR;
        [VkFunctionId(322, true)]
        public PFN_vkGetEncodedVideoSessionParametersKHR vkGetEncodedVideoSessionParametersKHR;
        [VkFunctionId(323, true)]
        public PFN_vkCmdEncodeVideoKHR vkCmdEncodeVideoKHR;
        [VkFunctionId(324, true)]
        public PFN_vkCmdSetEvent2KHR vkCmdSetEvent2KHR;
        [VkFunctionId(325, true)]
        public PFN_vkCmdResetEvent2KHR vkCmdResetEvent2KHR;
        [VkFunctionId(326, true)]
        public PFN_vkCmdWaitEvents2KHR vkCmdWaitEvents2KHR;
        [VkFunctionId(327, true)]
        public PFN_vkCmdPipelineBarrier2KHR vkCmdPipelineBarrier2KHR;
        [VkFunctionId(328, true)]
        public PFN_vkCmdWriteTimestamp2KHR vkCmdWriteTimestamp2KHR;
        [VkFunctionId(329, true)]
        public PFN_vkQueueSubmit2KHR vkQueueSubmit2KHR;
        [VkFunctionId(330, true)]
        public PFN_vkCmdWriteBufferMarker2AMD vkCmdWriteBufferMarker2AMD;
        [VkFunctionId(331, true)]
        public PFN_vkGetQueueCheckpointData2NV vkGetQueueCheckpointData2NV;
        [VkFunctionId(332, true)]
        public PFN_vkCmdCopyBuffer2KHR vkCmdCopyBuffer2KHR;
        [VkFunctionId(333, true)]
        public PFN_vkCmdCopyImage2KHR vkCmdCopyImage2KHR;
        [VkFunctionId(334, true)]
        public PFN_vkCmdCopyBufferToImage2KHR vkCmdCopyBufferToImage2KHR;
        [VkFunctionId(335, true)]
        public PFN_vkCmdCopyImageToBuffer2KHR vkCmdCopyImageToBuffer2KHR;
        [VkFunctionId(336, true)]
        public PFN_vkCmdBlitImage2KHR vkCmdBlitImage2KHR;
        [VkFunctionId(337, true)]
        public PFN_vkCmdResolveImage2KHR vkCmdResolveImage2KHR;
        [VkFunctionId(338, true)]
        public PFN_vkCmdTraceRaysIndirect2KHR vkCmdTraceRaysIndirect2KHR;
        [VkFunctionId(339, true)]
        public PFN_vkGetDeviceBufferMemoryRequirementsKHR vkGetDeviceBufferMemoryRequirementsKHR;
        [VkFunctionId(340, true)]
        public PFN_vkGetDeviceImageMemoryRequirementsKHR vkGetDeviceImageMemoryRequirementsKHR;
        [VkFunctionId(341, true)]
        public PFN_vkGetDeviceImageSparseMemoryRequirementsKHR vkGetDeviceImageSparseMemoryRequirementsKHR;
        [VkFunctionId(342, true)]
        public PFN_vkCmdBindIndexBuffer2KHR vkCmdBindIndexBuffer2KHR;
        [VkFunctionId(343, true)]
        public PFN_vkGetRenderingAreaGranularityKHR vkGetRenderingAreaGranularityKHR;
        [VkFunctionId(344, true)]
        public PFN_vkGetDeviceImageSubresourceLayoutKHR vkGetDeviceImageSubresourceLayoutKHR;
        [VkFunctionId(345, true)]
        public PFN_vkGetImageSubresourceLayout2KHR vkGetImageSubresourceLayout2KHR;
        [VkFunctionId(346, true)]
        public PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR;
        [VkFunctionId(347, true)]
        public PFN_vkCmdSetLineStippleKHR vkCmdSetLineStippleKHR;
        [VkFunctionId(348, true)]
        public PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsKHR vkGetPhysicalDeviceCalibrateableTimeDomainsKHR;
        [VkFunctionId(349, true)]
        public PFN_vkGetCalibratedTimestampsKHR vkGetCalibratedTimestampsKHR;
        [VkFunctionId(350, true)]
        public PFN_vkCmdBindDescriptorSets2KHR vkCmdBindDescriptorSets2KHR;
        [VkFunctionId(351, true)]
        public PFN_vkCmdPushConstants2KHR vkCmdPushConstants2KHR;
        [VkFunctionId(352, true)]
        public PFN_vkCmdPushDescriptorSet2KHR vkCmdPushDescriptorSet2KHR;
        [VkFunctionId(353, true)]
        public PFN_vkCmdPushDescriptorSetWithTemplate2KHR vkCmdPushDescriptorSetWithTemplate2KHR;
        [VkFunctionId(354, true)]
        public PFN_vkCmdSetDescriptorBufferOffsets2EXT vkCmdSetDescriptorBufferOffsets2EXT;
        [VkFunctionId(355, true)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplers2EXT vkCmdBindDescriptorBufferEmbeddedSamplers2EXT;
        [VkFunctionId(356, true)]
        public PFN_vkCreateDebugReportCallbackEXT vkCreateDebugReportCallbackEXT;
        [VkFunctionId(357, true)]
        public PFN_vkDestroyDebugReportCallbackEXT vkDestroyDebugReportCallbackEXT;
        [VkFunctionId(358, true)]
        public PFN_vkDebugReportMessageEXT vkDebugReportMessageEXT;
        [VkFunctionId(359, true)]
        public PFN_vkDebugMarkerSetObjectTagEXT vkDebugMarkerSetObjectTagEXT;
        [VkFunctionId(360, true)]
        public PFN_vkDebugMarkerSetObjectNameEXT vkDebugMarkerSetObjectNameEXT;
        [VkFunctionId(361, true)]
        public PFN_vkCmdDebugMarkerBeginEXT vkCmdDebugMarkerBeginEXT;
        [VkFunctionId(362, true)]
        public PFN_vkCmdDebugMarkerEndEXT vkCmdDebugMarkerEndEXT;
        [VkFunctionId(363, true)]
        public PFN_vkCmdDebugMarkerInsertEXT vkCmdDebugMarkerInsertEXT;
        [VkFunctionId(364, true)]
        public PFN_vkCmdBindTransformFeedbackBuffersEXT vkCmdBindTransformFeedbackBuffersEXT;
        [VkFunctionId(365, true)]
        public PFN_vkCmdBeginTransformFeedbackEXT vkCmdBeginTransformFeedbackEXT;
        [VkFunctionId(366, true)]
        public PFN_vkCmdEndTransformFeedbackEXT vkCmdEndTransformFeedbackEXT;
        [VkFunctionId(367, true)]
        public PFN_vkCmdBeginQueryIndexedEXT vkCmdBeginQueryIndexedEXT;
        [VkFunctionId(368, true)]
        public PFN_vkCmdEndQueryIndexedEXT vkCmdEndQueryIndexedEXT;
        [VkFunctionId(369, true)]
        public PFN_vkCmdDrawIndirectByteCountEXT vkCmdDrawIndirectByteCountEXT;
        [VkFunctionId(370, true)]
        public PFN_vkCreateCuModuleNVX vkCreateCuModuleNVX;
        [VkFunctionId(371, true)]
        public PFN_vkCreateCuFunctionNVX vkCreateCuFunctionNVX;
        [VkFunctionId(372, true)]
        public PFN_vkDestroyCuModuleNVX vkDestroyCuModuleNVX;
        [VkFunctionId(373, true)]
        public PFN_vkDestroyCuFunctionNVX vkDestroyCuFunctionNVX;
        [VkFunctionId(374, true)]
        public PFN_vkCmdCuLaunchKernelNVX vkCmdCuLaunchKernelNVX;
        [VkFunctionId(375, true)]
        public PFN_vkGetImageViewHandleNVX vkGetImageViewHandleNVX;
        [VkFunctionId(376, true)]
        public PFN_vkGetImageViewAddressNVX vkGetImageViewAddressNVX;
        [VkFunctionId(377, true)]
        public PFN_vkCmdDrawIndirectCountAMD vkCmdDrawIndirectCountAMD;
        [VkFunctionId(378, true)]
        public PFN_vkCmdDrawIndexedIndirectCountAMD vkCmdDrawIndexedIndirectCountAMD;
        [VkFunctionId(379, true)]
        public PFN_vkGetShaderInfoAMD vkGetShaderInfoAMD;
        [VkFunctionId(380, true)]
        public PFN_vkGetPhysicalDeviceExternalImageFormatPropertiesNV vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
        [VkFunctionId(381, true)]
        public PFN_vkCmdBeginConditionalRenderingEXT vkCmdBeginConditionalRenderingEXT;
        [VkFunctionId(382, true)]
        public PFN_vkCmdEndConditionalRenderingEXT vkCmdEndConditionalRenderingEXT;
        [VkFunctionId(383, true)]
        public PFN_vkCmdSetViewportWScalingNV vkCmdSetViewportWScalingNV;
        [VkFunctionId(384, true)]
        public PFN_vkReleaseDisplayEXT vkReleaseDisplayEXT;
        [VkFunctionId(385, true)]
        public PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT vkGetPhysicalDeviceSurfaceCapabilities2EXT;
        [VkFunctionId(386, true)]
        public PFN_vkDisplayPowerControlEXT vkDisplayPowerControlEXT;
        [VkFunctionId(387, true)]
        public PFN_vkRegisterDeviceEventEXT vkRegisterDeviceEventEXT;
        [VkFunctionId(388, true)]
        public PFN_vkRegisterDisplayEventEXT vkRegisterDisplayEventEXT;
        [VkFunctionId(389, true)]
        public PFN_vkGetSwapchainCounterEXT vkGetSwapchainCounterEXT;
        [VkFunctionId(390, true)]
        public PFN_vkGetRefreshCycleDurationGOOGLE vkGetRefreshCycleDurationGOOGLE;
        [VkFunctionId(391, true)]
        public PFN_vkGetPastPresentationTimingGOOGLE vkGetPastPresentationTimingGOOGLE;
        [VkFunctionId(392, true)]
        public PFN_vkCmdSetDiscardRectangleEXT vkCmdSetDiscardRectangleEXT;
        [VkFunctionId(393, true)]
        public PFN_vkCmdSetDiscardRectangleEnableEXT vkCmdSetDiscardRectangleEnableEXT;
        [VkFunctionId(394, true)]
        public PFN_vkCmdSetDiscardRectangleModeEXT vkCmdSetDiscardRectangleModeEXT;
        [VkFunctionId(395, true)]
        public PFN_vkSetHdrMetadataEXT vkSetHdrMetadataEXT;
        [VkFunctionId(396, true)]
        public PFN_vkSetDebugUtilsObjectNameEXT vkSetDebugUtilsObjectNameEXT;
        [VkFunctionId(397, true)]
        public PFN_vkSetDebugUtilsObjectTagEXT vkSetDebugUtilsObjectTagEXT;
        [VkFunctionId(398, true)]
        public PFN_vkQueueBeginDebugUtilsLabelEXT vkQueueBeginDebugUtilsLabelEXT;
        [VkFunctionId(399, true)]
        public PFN_vkQueueEndDebugUtilsLabelEXT vkQueueEndDebugUtilsLabelEXT;
        [VkFunctionId(400, true)]
        public PFN_vkQueueInsertDebugUtilsLabelEXT vkQueueInsertDebugUtilsLabelEXT;
        [VkFunctionId(401, true)]
        public PFN_vkCmdBeginDebugUtilsLabelEXT vkCmdBeginDebugUtilsLabelEXT;
        [VkFunctionId(402, true)]
        public PFN_vkCmdEndDebugUtilsLabelEXT vkCmdEndDebugUtilsLabelEXT;
        [VkFunctionId(403, true)]
        public PFN_vkCmdInsertDebugUtilsLabelEXT vkCmdInsertDebugUtilsLabelEXT;
        [VkFunctionId(404, true)]
        public PFN_vkCreateDebugUtilsMessengerEXT vkCreateDebugUtilsMessengerEXT;
        [VkFunctionId(405, true)]
        public PFN_vkDestroyDebugUtilsMessengerEXT vkDestroyDebugUtilsMessengerEXT;
        [VkFunctionId(406, true)]
        public PFN_vkSubmitDebugUtilsMessageEXT vkSubmitDebugUtilsMessageEXT;
        [VkFunctionId(407, true)]
        public PFN_vkCmdSetSampleLocationsEXT vkCmdSetSampleLocationsEXT;
        [VkFunctionId(408, true)]
        public PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT vkGetPhysicalDeviceMultisamplePropertiesEXT;
        [VkFunctionId(409, true)]
        public PFN_vkGetImageDrmFormatModifierPropertiesEXT vkGetImageDrmFormatModifierPropertiesEXT;
        [VkFunctionId(410, true)]
        public PFN_vkCreateValidationCacheEXT vkCreateValidationCacheEXT;
        [VkFunctionId(411, true)]
        public PFN_vkDestroyValidationCacheEXT vkDestroyValidationCacheEXT;
        [VkFunctionId(412, true)]
        public PFN_vkMergeValidationCachesEXT vkMergeValidationCachesEXT;
        [VkFunctionId(413, true)]
        public PFN_vkGetValidationCacheDataEXT vkGetValidationCacheDataEXT;
        [VkFunctionId(414, true)]
        public PFN_vkCmdBindShadingRateImageNV vkCmdBindShadingRateImageNV;
        [VkFunctionId(415, true)]
        public PFN_vkCmdSetViewportShadingRatePaletteNV vkCmdSetViewportShadingRatePaletteNV;
        [VkFunctionId(416, true)]
        public PFN_vkCmdSetCoarseSampleOrderNV vkCmdSetCoarseSampleOrderNV;
        [VkFunctionId(417, true)]
        public PFN_vkCreateAccelerationStructureNV vkCreateAccelerationStructureNV;
        [VkFunctionId(418, true)]
        public PFN_vkDestroyAccelerationStructureNV vkDestroyAccelerationStructureNV;
        [VkFunctionId(419, true)]
        public PFN_vkGetAccelerationStructureMemoryRequirementsNV vkGetAccelerationStructureMemoryRequirementsNV;
        [VkFunctionId(420, true)]
        public PFN_vkBindAccelerationStructureMemoryNV vkBindAccelerationStructureMemoryNV;
        [VkFunctionId(421, true)]
        public PFN_vkCmdBuildAccelerationStructureNV vkCmdBuildAccelerationStructureNV;
        [VkFunctionId(422, true)]
        public PFN_vkCmdCopyAccelerationStructureNV vkCmdCopyAccelerationStructureNV;
        [VkFunctionId(423, true)]
        public PFN_vkCmdTraceRaysNV vkCmdTraceRaysNV;
        [VkFunctionId(424, true)]
        public PFN_vkCreateRayTracingPipelinesNV vkCreateRayTracingPipelinesNV;
        [VkFunctionId(425, true)]
        public PFN_vkGetRayTracingShaderGroupHandlesKHR vkGetRayTracingShaderGroupHandlesKHR;
        [VkFunctionId(426, true)]
        public PFN_vkGetRayTracingShaderGroupHandlesNV vkGetRayTracingShaderGroupHandlesNV;
        [VkFunctionId(427, true)]
        public PFN_vkGetAccelerationStructureHandleNV vkGetAccelerationStructureHandleNV;
        [VkFunctionId(428, true)]
        public PFN_vkCmdWriteAccelerationStructuresPropertiesNV vkCmdWriteAccelerationStructuresPropertiesNV;
        [VkFunctionId(429, true)]
        public PFN_vkCompileDeferredNV vkCompileDeferredNV;
        [VkFunctionId(430, true)]
        public PFN_vkGetMemoryHostPointerPropertiesEXT vkGetMemoryHostPointerPropertiesEXT;
        [VkFunctionId(431, true)]
        public PFN_vkCmdWriteBufferMarkerAMD vkCmdWriteBufferMarkerAMD;
        [VkFunctionId(432, true)]
        public PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
        [VkFunctionId(433, true)]
        public PFN_vkGetCalibratedTimestampsEXT vkGetCalibratedTimestampsEXT;
        [VkFunctionId(434, true)]
        public PFN_vkCmdDrawMeshTasksNV vkCmdDrawMeshTasksNV;
        [VkFunctionId(435, true)]
        public PFN_vkCmdDrawMeshTasksIndirectNV vkCmdDrawMeshTasksIndirectNV;
        [VkFunctionId(436, true)]
        public PFN_vkCmdDrawMeshTasksIndirectCountNV vkCmdDrawMeshTasksIndirectCountNV;
        [VkFunctionId(437, true)]
        public PFN_vkCmdSetExclusiveScissorEnableNV vkCmdSetExclusiveScissorEnableNV;
        [VkFunctionId(438, true)]
        public PFN_vkCmdSetExclusiveScissorNV vkCmdSetExclusiveScissorNV;
        [VkFunctionId(439, true)]
        public PFN_vkCmdSetCheckpointNV vkCmdSetCheckpointNV;
        [VkFunctionId(440, true)]
        public PFN_vkGetQueueCheckpointDataNV vkGetQueueCheckpointDataNV;
        [VkFunctionId(441, true)]
        public PFN_vkInitializePerformanceApiINTEL vkInitializePerformanceApiINTEL;
        [VkFunctionId(442, true)]
        public PFN_vkUninitializePerformanceApiINTEL vkUninitializePerformanceApiINTEL;
        [VkFunctionId(443, true)]
        public PFN_vkCmdSetPerformanceMarkerINTEL vkCmdSetPerformanceMarkerINTEL;
        [VkFunctionId(444, true)]
        public PFN_vkCmdSetPerformanceStreamMarkerINTEL vkCmdSetPerformanceStreamMarkerINTEL;
        [VkFunctionId(445, true)]
        public PFN_vkCmdSetPerformanceOverrideINTEL vkCmdSetPerformanceOverrideINTEL;
        [VkFunctionId(446, true)]
        public PFN_vkAcquirePerformanceConfigurationINTEL vkAcquirePerformanceConfigurationINTEL;
        [VkFunctionId(447, true)]
        public PFN_vkReleasePerformanceConfigurationINTEL vkReleasePerformanceConfigurationINTEL;
        [VkFunctionId(448, true)]
        public PFN_vkQueueSetPerformanceConfigurationINTEL vkQueueSetPerformanceConfigurationINTEL;
        [VkFunctionId(449, true)]
        public PFN_vkGetPerformanceParameterINTEL vkGetPerformanceParameterINTEL;
        [VkFunctionId(450, true)]
        public PFN_vkSetLocalDimmingAMD vkSetLocalDimmingAMD;
        [VkFunctionId(451, true)]
        public PFN_vkGetBufferDeviceAddressEXT vkGetBufferDeviceAddressEXT;
        [VkFunctionId(452, true)]
        public PFN_vkGetPhysicalDeviceToolPropertiesEXT vkGetPhysicalDeviceToolPropertiesEXT;
        [VkFunctionId(453, true)]
        public PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesNV vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
        [VkFunctionId(454, true)]
        public PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
        [VkFunctionId(455, true)]
        public PFN_vkCreateHeadlessSurfaceEXT vkCreateHeadlessSurfaceEXT;
        [VkFunctionId(456, true)]
        public PFN_vkCmdSetLineStippleEXT vkCmdSetLineStippleEXT;
        [VkFunctionId(457, true)]
        public PFN_vkResetQueryPoolEXT vkResetQueryPoolEXT;
        [VkFunctionId(458, true)]
        public PFN_vkCmdSetCullModeEXT vkCmdSetCullModeEXT;
        [VkFunctionId(459, true)]
        public PFN_vkCmdSetFrontFaceEXT vkCmdSetFrontFaceEXT;
        [VkFunctionId(460, true)]
        public PFN_vkCmdSetPrimitiveTopologyEXT vkCmdSetPrimitiveTopologyEXT;
        [VkFunctionId(461, true)]
        public PFN_vkCmdSetViewportWithCountEXT vkCmdSetViewportWithCountEXT;
        [VkFunctionId(462, true)]
        public PFN_vkCmdSetScissorWithCountEXT vkCmdSetScissorWithCountEXT;
        [VkFunctionId(463, true)]
        public PFN_vkCmdBindVertexBuffers2EXT vkCmdBindVertexBuffers2EXT;
        [VkFunctionId(464, true)]
        public PFN_vkCmdSetDepthTestEnableEXT vkCmdSetDepthTestEnableEXT;
        [VkFunctionId(465, true)]
        public PFN_vkCmdSetDepthWriteEnableEXT vkCmdSetDepthWriteEnableEXT;
        [VkFunctionId(466, true)]
        public PFN_vkCmdSetDepthCompareOpEXT vkCmdSetDepthCompareOpEXT;
        [VkFunctionId(467, true)]
        public PFN_vkCmdSetDepthBoundsTestEnableEXT vkCmdSetDepthBoundsTestEnableEXT;
        [VkFunctionId(468, true)]
        public PFN_vkCmdSetStencilTestEnableEXT vkCmdSetStencilTestEnableEXT;
        [VkFunctionId(469, true)]
        public PFN_vkCmdSetStencilOpEXT vkCmdSetStencilOpEXT;
        [VkFunctionId(470, true)]
        public PFN_vkCopyMemoryToImageEXT vkCopyMemoryToImageEXT;
        [VkFunctionId(471, true)]
        public PFN_vkCopyImageToMemoryEXT vkCopyImageToMemoryEXT;
        [VkFunctionId(472, true)]
        public PFN_vkCopyImageToImageEXT vkCopyImageToImageEXT;
        [VkFunctionId(473, true)]
        public PFN_vkTransitionImageLayoutEXT vkTransitionImageLayoutEXT;
        [VkFunctionId(474, true)]
        public PFN_vkGetImageSubresourceLayout2EXT vkGetImageSubresourceLayout2EXT;
        [VkFunctionId(475, true)]
        public PFN_vkReleaseSwapchainImagesEXT vkReleaseSwapchainImagesEXT;
        [VkFunctionId(476, true)]
        public PFN_vkGetGeneratedCommandsMemoryRequirementsNV vkGetGeneratedCommandsMemoryRequirementsNV;
        [VkFunctionId(477, true)]
        public PFN_vkCmdPreprocessGeneratedCommandsNV vkCmdPreprocessGeneratedCommandsNV;
        [VkFunctionId(478, true)]
        public PFN_vkCmdExecuteGeneratedCommandsNV vkCmdExecuteGeneratedCommandsNV;
        [VkFunctionId(479, true)]
        public PFN_vkCmdBindPipelineShaderGroupNV vkCmdBindPipelineShaderGroupNV;
        [VkFunctionId(480, true)]
        public PFN_vkCreateIndirectCommandsLayoutNV vkCreateIndirectCommandsLayoutNV;
        [VkFunctionId(481, true)]
        public PFN_vkDestroyIndirectCommandsLayoutNV vkDestroyIndirectCommandsLayoutNV;
        [VkFunctionId(482, true)]
        public PFN_vkCmdSetDepthBias2EXT vkCmdSetDepthBias2EXT;
        [VkFunctionId(483, true)]
        public PFN_vkAcquireDrmDisplayEXT vkAcquireDrmDisplayEXT;
        [VkFunctionId(484, true)]
        public PFN_vkGetDrmDisplayEXT vkGetDrmDisplayEXT;
        [VkFunctionId(485, true)]
        public PFN_vkCreatePrivateDataSlotEXT vkCreatePrivateDataSlotEXT;
        [VkFunctionId(486, true)]
        public PFN_vkDestroyPrivateDataSlotEXT vkDestroyPrivateDataSlotEXT;
        [VkFunctionId(487, true)]
        public PFN_vkSetPrivateDataEXT vkSetPrivateDataEXT;
        [VkFunctionId(488, true)]
        public PFN_vkGetPrivateDataEXT vkGetPrivateDataEXT;
        [VkFunctionId(489, true)]
        public PFN_vkCreateCudaModuleNV vkCreateCudaModuleNV;
        [VkFunctionId(490, true)]
        public PFN_vkGetCudaModuleCacheNV vkGetCudaModuleCacheNV;
        [VkFunctionId(491, true)]
        public PFN_vkCreateCudaFunctionNV vkCreateCudaFunctionNV;
        [VkFunctionId(492, true)]
        public PFN_vkDestroyCudaModuleNV vkDestroyCudaModuleNV;
        [VkFunctionId(493, true)]
        public PFN_vkDestroyCudaFunctionNV vkDestroyCudaFunctionNV;
        [VkFunctionId(494, true)]
        public PFN_vkCmdCudaLaunchKernelNV vkCmdCudaLaunchKernelNV;
        [VkFunctionId(495, true)]
        public PFN_vkGetDescriptorSetLayoutSizeEXT vkGetDescriptorSetLayoutSizeEXT;
        [VkFunctionId(496, true)]
        public PFN_vkGetDescriptorSetLayoutBindingOffsetEXT vkGetDescriptorSetLayoutBindingOffsetEXT;
        [VkFunctionId(497, true)]
        public PFN_vkGetDescriptorEXT vkGetDescriptorEXT;
        [VkFunctionId(498, true)]
        public PFN_vkCmdBindDescriptorBuffersEXT vkCmdBindDescriptorBuffersEXT;
        [VkFunctionId(499, true)]
        public PFN_vkCmdSetDescriptorBufferOffsetsEXT vkCmdSetDescriptorBufferOffsetsEXT;
        [VkFunctionId(500, true)]
        public PFN_vkCmdBindDescriptorBufferEmbeddedSamplersEXT vkCmdBindDescriptorBufferEmbeddedSamplersEXT;
        [VkFunctionId(501, true)]
        public PFN_vkGetBufferOpaqueCaptureDescriptorDataEXT vkGetBufferOpaqueCaptureDescriptorDataEXT;
        [VkFunctionId(502, true)]
        public PFN_vkGetImageOpaqueCaptureDescriptorDataEXT vkGetImageOpaqueCaptureDescriptorDataEXT;
        [VkFunctionId(503, true)]
        public PFN_vkGetImageViewOpaqueCaptureDescriptorDataEXT vkGetImageViewOpaqueCaptureDescriptorDataEXT;
        [VkFunctionId(504, true)]
        public PFN_vkGetSamplerOpaqueCaptureDescriptorDataEXT vkGetSamplerOpaqueCaptureDescriptorDataEXT;
        [VkFunctionId(505, true)]
        public PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;
        [VkFunctionId(506, true)]
        public PFN_vkCmdSetFragmentShadingRateEnumNV vkCmdSetFragmentShadingRateEnumNV;
        [VkFunctionId(507, true)]
        public PFN_vkGetDeviceFaultInfoEXT vkGetDeviceFaultInfoEXT;
        [VkFunctionId(508, true)]
        public PFN_vkCmdSetVertexInputEXT vkCmdSetVertexInputEXT;
        [VkFunctionId(509, true)]
        public PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;
        [VkFunctionId(510, true)]
        public PFN_vkCmdSubpassShadingHUAWEI vkCmdSubpassShadingHUAWEI;
        [VkFunctionId(511, true)]
        public PFN_vkCmdBindInvocationMaskHUAWEI vkCmdBindInvocationMaskHUAWEI;
        [VkFunctionId(512, true)]
        public PFN_vkGetMemoryRemoteAddressNV vkGetMemoryRemoteAddressNV;
        [VkFunctionId(513, true)]
        public PFN_vkGetPipelinePropertiesEXT vkGetPipelinePropertiesEXT;
        [VkFunctionId(514, true)]
        public PFN_vkCmdSetPatchControlPointsEXT vkCmdSetPatchControlPointsEXT;
        [VkFunctionId(515, true)]
        public PFN_vkCmdSetRasterizerDiscardEnableEXT vkCmdSetRasterizerDiscardEnableEXT;
        [VkFunctionId(516, true)]
        public PFN_vkCmdSetDepthBiasEnableEXT vkCmdSetDepthBiasEnableEXT;
        [VkFunctionId(517, true)]
        public PFN_vkCmdSetLogicOpEXT vkCmdSetLogicOpEXT;
        [VkFunctionId(518, true)]
        public PFN_vkCmdSetPrimitiveRestartEnableEXT vkCmdSetPrimitiveRestartEnableEXT;
        [VkFunctionId(519, true)]
        public PFN_vkCmdSetColorWriteEnableEXT vkCmdSetColorWriteEnableEXT;
        [VkFunctionId(520, true)]
        public PFN_vkCmdDrawMultiEXT vkCmdDrawMultiEXT;
        [VkFunctionId(521, true)]
        public PFN_vkCmdDrawMultiIndexedEXT vkCmdDrawMultiIndexedEXT;
        [VkFunctionId(522, true)]
        public PFN_vkCreateMicromapEXT vkCreateMicromapEXT;
        [VkFunctionId(523, true)]
        public PFN_vkDestroyMicromapEXT vkDestroyMicromapEXT;
        [VkFunctionId(524, true)]
        public PFN_vkCmdBuildMicromapsEXT vkCmdBuildMicromapsEXT;
        [VkFunctionId(525, true)]
        public PFN_vkBuildMicromapsEXT vkBuildMicromapsEXT;
        [VkFunctionId(526, true)]
        public PFN_vkCopyMicromapEXT vkCopyMicromapEXT;
        [VkFunctionId(527, true)]
        public PFN_vkCopyMicromapToMemoryEXT vkCopyMicromapToMemoryEXT;
        [VkFunctionId(528, true)]
        public PFN_vkCopyMemoryToMicromapEXT vkCopyMemoryToMicromapEXT;
        [VkFunctionId(529, true)]
        public PFN_vkWriteMicromapsPropertiesEXT vkWriteMicromapsPropertiesEXT;
        [VkFunctionId(530, true)]
        public PFN_vkCmdCopyMicromapEXT vkCmdCopyMicromapEXT;
        [VkFunctionId(531, true)]
        public PFN_vkCmdCopyMicromapToMemoryEXT vkCmdCopyMicromapToMemoryEXT;
        [VkFunctionId(532, true)]
        public PFN_vkCmdCopyMemoryToMicromapEXT vkCmdCopyMemoryToMicromapEXT;
        [VkFunctionId(533, true)]
        public PFN_vkCmdWriteMicromapsPropertiesEXT vkCmdWriteMicromapsPropertiesEXT;
        [VkFunctionId(534, true)]
        public PFN_vkGetDeviceMicromapCompatibilityEXT vkGetDeviceMicromapCompatibilityEXT;
        [VkFunctionId(535, true)]
        public PFN_vkGetMicromapBuildSizesEXT vkGetMicromapBuildSizesEXT;
        [VkFunctionId(536, true)]
        public PFN_vkCmdDrawClusterHUAWEI vkCmdDrawClusterHUAWEI;
        [VkFunctionId(537, true)]
        public PFN_vkCmdDrawClusterIndirectHUAWEI vkCmdDrawClusterIndirectHUAWEI;
        [VkFunctionId(538, true)]
        public PFN_vkSetDeviceMemoryPriorityEXT vkSetDeviceMemoryPriorityEXT;
        [VkFunctionId(539, true)]
        public PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE vkGetDescriptorSetLayoutHostMappingInfoVALVE;
        [VkFunctionId(540, true)]
        public PFN_vkGetDescriptorSetHostMappingVALVE vkGetDescriptorSetHostMappingVALVE;
        [VkFunctionId(541, true)]
        public PFN_vkCmdCopyMemoryIndirectNV vkCmdCopyMemoryIndirectNV;
        [VkFunctionId(542, true)]
        public PFN_vkCmdCopyMemoryToImageIndirectNV vkCmdCopyMemoryToImageIndirectNV;
        [VkFunctionId(543, true)]
        public PFN_vkCmdDecompressMemoryNV vkCmdDecompressMemoryNV;
        [VkFunctionId(544, true)]
        public PFN_vkCmdDecompressMemoryIndirectCountNV vkCmdDecompressMemoryIndirectCountNV;
        [VkFunctionId(545, true)]
        public PFN_vkGetPipelineIndirectMemoryRequirementsNV vkGetPipelineIndirectMemoryRequirementsNV;
        [VkFunctionId(546, true)]
        public PFN_vkCmdUpdatePipelineIndirectBufferNV vkCmdUpdatePipelineIndirectBufferNV;
        [VkFunctionId(547, true)]
        public PFN_vkGetPipelineIndirectDeviceAddressNV vkGetPipelineIndirectDeviceAddressNV;
        [VkFunctionId(548, true)]
        public PFN_vkCmdSetDepthClampEnableEXT vkCmdSetDepthClampEnableEXT;
        [VkFunctionId(549, true)]
        public PFN_vkCmdSetPolygonModeEXT vkCmdSetPolygonModeEXT;
        [VkFunctionId(550, true)]
        public PFN_vkCmdSetRasterizationSamplesEXT vkCmdSetRasterizationSamplesEXT;
        [VkFunctionId(551, true)]
        public PFN_vkCmdSetSampleMaskEXT vkCmdSetSampleMaskEXT;
        [VkFunctionId(552, true)]
        public PFN_vkCmdSetAlphaToCoverageEnableEXT vkCmdSetAlphaToCoverageEnableEXT;
        [VkFunctionId(553, true)]
        public PFN_vkCmdSetAlphaToOneEnableEXT vkCmdSetAlphaToOneEnableEXT;
        [VkFunctionId(554, true)]
        public PFN_vkCmdSetLogicOpEnableEXT vkCmdSetLogicOpEnableEXT;
        [VkFunctionId(555, true)]
        public PFN_vkCmdSetColorBlendEnableEXT vkCmdSetColorBlendEnableEXT;
        [VkFunctionId(556, true)]
        public PFN_vkCmdSetColorBlendEquationEXT vkCmdSetColorBlendEquationEXT;
        [VkFunctionId(557, true)]
        public PFN_vkCmdSetColorWriteMaskEXT vkCmdSetColorWriteMaskEXT;
        [VkFunctionId(558, true)]
        public PFN_vkCmdSetTessellationDomainOriginEXT vkCmdSetTessellationDomainOriginEXT;
        [VkFunctionId(559, true)]
        public PFN_vkCmdSetRasterizationStreamEXT vkCmdSetRasterizationStreamEXT;
        [VkFunctionId(560, true)]
        public PFN_vkCmdSetConservativeRasterizationModeEXT vkCmdSetConservativeRasterizationModeEXT;
        [VkFunctionId(561, true)]
        public PFN_vkCmdSetExtraPrimitiveOverestimationSizeEXT vkCmdSetExtraPrimitiveOverestimationSizeEXT;
        [VkFunctionId(562, true)]
        public PFN_vkCmdSetDepthClipEnableEXT vkCmdSetDepthClipEnableEXT;
        [VkFunctionId(563, true)]
        public PFN_vkCmdSetSampleLocationsEnableEXT vkCmdSetSampleLocationsEnableEXT;
        [VkFunctionId(564, true)]
        public PFN_vkCmdSetColorBlendAdvancedEXT vkCmdSetColorBlendAdvancedEXT;
        [VkFunctionId(565, true)]
        public PFN_vkCmdSetProvokingVertexModeEXT vkCmdSetProvokingVertexModeEXT;
        [VkFunctionId(566, true)]
        public PFN_vkCmdSetLineRasterizationModeEXT vkCmdSetLineRasterizationModeEXT;
        [VkFunctionId(567, true)]
        public PFN_vkCmdSetLineStippleEnableEXT vkCmdSetLineStippleEnableEXT;
        [VkFunctionId(568, true)]
        public PFN_vkCmdSetDepthClipNegativeOneToOneEXT vkCmdSetDepthClipNegativeOneToOneEXT;
        [VkFunctionId(569, true)]
        public PFN_vkCmdSetViewportWScalingEnableNV vkCmdSetViewportWScalingEnableNV;
        [VkFunctionId(570, true)]
        public PFN_vkCmdSetViewportSwizzleNV vkCmdSetViewportSwizzleNV;
        [VkFunctionId(571, true)]
        public PFN_vkCmdSetCoverageToColorEnableNV vkCmdSetCoverageToColorEnableNV;
        [VkFunctionId(572, true)]
        public PFN_vkCmdSetCoverageToColorLocationNV vkCmdSetCoverageToColorLocationNV;
        [VkFunctionId(573, true)]
        public PFN_vkCmdSetCoverageModulationModeNV vkCmdSetCoverageModulationModeNV;
        [VkFunctionId(574, true)]
        public PFN_vkCmdSetCoverageModulationTableEnableNV vkCmdSetCoverageModulationTableEnableNV;
        [VkFunctionId(575, true)]
        public PFN_vkCmdSetCoverageModulationTableNV vkCmdSetCoverageModulationTableNV;
        [VkFunctionId(576, true)]
        public PFN_vkCmdSetShadingRateImageEnableNV vkCmdSetShadingRateImageEnableNV;
        [VkFunctionId(577, true)]
        public PFN_vkCmdSetRepresentativeFragmentTestEnableNV vkCmdSetRepresentativeFragmentTestEnableNV;
        [VkFunctionId(578, true)]
        public PFN_vkCmdSetCoverageReductionModeNV vkCmdSetCoverageReductionModeNV;
        [VkFunctionId(579, true)]
        public PFN_vkGetShaderModuleIdentifierEXT vkGetShaderModuleIdentifierEXT;
        [VkFunctionId(580, true)]
        public PFN_vkGetShaderModuleCreateInfoIdentifierEXT vkGetShaderModuleCreateInfoIdentifierEXT;
        [VkFunctionId(581, true)]
        public PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV vkGetPhysicalDeviceOpticalFlowImageFormatsNV;
        [VkFunctionId(582, true)]
        public PFN_vkCreateOpticalFlowSessionNV vkCreateOpticalFlowSessionNV;
        [VkFunctionId(583, true)]
        public PFN_vkDestroyOpticalFlowSessionNV vkDestroyOpticalFlowSessionNV;
        [VkFunctionId(584, true)]
        public PFN_vkBindOpticalFlowSessionImageNV vkBindOpticalFlowSessionImageNV;
        [VkFunctionId(585, true)]
        public PFN_vkCmdOpticalFlowExecuteNV vkCmdOpticalFlowExecuteNV;
        [VkFunctionId(586, true)]
        public PFN_vkCreateShadersEXT vkCreateShadersEXT;
        [VkFunctionId(587, true)]
        public PFN_vkDestroyShaderEXT vkDestroyShaderEXT;
        [VkFunctionId(588, true)]
        public PFN_vkGetShaderBinaryDataEXT vkGetShaderBinaryDataEXT;
        [VkFunctionId(589, true)]
        public PFN_vkCmdBindShadersEXT vkCmdBindShadersEXT;
        [VkFunctionId(590, true)]
        public PFN_vkGetFramebufferTilePropertiesQCOM vkGetFramebufferTilePropertiesQCOM;
        [VkFunctionId(591, true)]
        public PFN_vkGetDynamicRenderingTilePropertiesQCOM vkGetDynamicRenderingTilePropertiesQCOM;
        [VkFunctionId(592, true)]
        public PFN_vkSetLatencySleepModeNV vkSetLatencySleepModeNV;
        [VkFunctionId(593, true)]
        public PFN_vkLatencySleepNV vkLatencySleepNV;
        [VkFunctionId(594, true)]
        public PFN_vkSetLatencyMarkerNV vkSetLatencyMarkerNV;
        [VkFunctionId(595, true)]
        public PFN_vkGetLatencyTimingsNV vkGetLatencyTimingsNV;
        [VkFunctionId(596, true)]
        public PFN_vkQueueNotifyOutOfBandNV vkQueueNotifyOutOfBandNV;
        [VkFunctionId(597, true)]
        public PFN_vkCmdSetAttachmentFeedbackLoopEnableEXT vkCmdSetAttachmentFeedbackLoopEnableEXT;
        [VkFunctionId(598, true)]
        public PFN_vkCreateAccelerationStructureKHR vkCreateAccelerationStructureKHR;
        [VkFunctionId(599, true)]
        public PFN_vkDestroyAccelerationStructureKHR vkDestroyAccelerationStructureKHR;
        [VkFunctionId(600, true)]
        public PFN_vkCmdBuildAccelerationStructuresKHR vkCmdBuildAccelerationStructuresKHR;
        [VkFunctionId(601, true)]
        public PFN_vkCmdBuildAccelerationStructuresIndirectKHR vkCmdBuildAccelerationStructuresIndirectKHR;
        [VkFunctionId(602, true)]
        public PFN_vkBuildAccelerationStructuresKHR vkBuildAccelerationStructuresKHR;
        [VkFunctionId(603, true)]
        public PFN_vkCopyAccelerationStructureKHR vkCopyAccelerationStructureKHR;
        [VkFunctionId(604, true)]
        public PFN_vkCopyAccelerationStructureToMemoryKHR vkCopyAccelerationStructureToMemoryKHR;
        [VkFunctionId(605, true)]
        public PFN_vkCopyMemoryToAccelerationStructureKHR vkCopyMemoryToAccelerationStructureKHR;
        [VkFunctionId(606, true)]
        public PFN_vkWriteAccelerationStructuresPropertiesKHR vkWriteAccelerationStructuresPropertiesKHR;
        [VkFunctionId(607, true)]
        public PFN_vkCmdCopyAccelerationStructureKHR vkCmdCopyAccelerationStructureKHR;
        [VkFunctionId(608, true)]
        public PFN_vkCmdCopyAccelerationStructureToMemoryKHR vkCmdCopyAccelerationStructureToMemoryKHR;
        [VkFunctionId(609, true)]
        public PFN_vkCmdCopyMemoryToAccelerationStructureKHR vkCmdCopyMemoryToAccelerationStructureKHR;
        [VkFunctionId(610, true)]
        public PFN_vkGetAccelerationStructureDeviceAddressKHR vkGetAccelerationStructureDeviceAddressKHR;
        [VkFunctionId(611, true)]
        public PFN_vkCmdWriteAccelerationStructuresPropertiesKHR vkCmdWriteAccelerationStructuresPropertiesKHR;
        [VkFunctionId(612, true)]
        public PFN_vkGetDeviceAccelerationStructureCompatibilityKHR vkGetDeviceAccelerationStructureCompatibilityKHR;
        [VkFunctionId(613, true)]
        public PFN_vkGetAccelerationStructureBuildSizesKHR vkGetAccelerationStructureBuildSizesKHR;
        [VkFunctionId(614, true)]
        public PFN_vkCmdTraceRaysKHR vkCmdTraceRaysKHR;
        [VkFunctionId(615, true)]
        public PFN_vkCreateRayTracingPipelinesKHR vkCreateRayTracingPipelinesKHR;
        [VkFunctionId(616, true)]
        public PFN_vkGetRayTracingCaptureReplayShaderGroupHandlesKHR vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;
        [VkFunctionId(617, true)]
        public PFN_vkCmdTraceRaysIndirectKHR vkCmdTraceRaysIndirectKHR;
        [VkFunctionId(618, true)]
        public PFN_vkGetRayTracingShaderGroupStackSizeKHR vkGetRayTracingShaderGroupStackSizeKHR;
        [VkFunctionId(619, true)]
        public PFN_vkCmdSetRayTracingPipelineStackSizeKHR vkCmdSetRayTracingPipelineStackSizeKHR;
        [VkFunctionId(620, true)]
        public PFN_vkCmdDrawMeshTasksEXT vkCmdDrawMeshTasksEXT;
        [VkFunctionId(621, true)]
        public PFN_vkCmdDrawMeshTasksIndirectEXT vkCmdDrawMeshTasksIndirectEXT;
        [VkFunctionId(622, true)]
        public PFN_vkCmdDrawMeshTasksIndirectCountEXT vkCmdDrawMeshTasksIndirectCountEXT;
        [VkFunctionId(623, false)]
        public VkFunctionPointer PFN_aux_623;
        [VkFunctionId(624, false)]
        public VkFunctionPointer PFN_aux_624;
        [VkFunctionId(625, false)]
        public VkFunctionPointer PFN_aux_625;
        [VkFunctionId(626, false)]
        public VkFunctionPointer PFN_aux_626;
        [VkFunctionId(627, false)]
        public VkFunctionPointer PFN_aux_627;
        [VkFunctionId(628, false)]
        public VkFunctionPointer PFN_aux_628;
        [VkFunctionId(629, false)]
        public VkFunctionPointer PFN_aux_629;
        [VkFunctionId(630, false)]
        public VkFunctionPointer PFN_aux_630;
        [VkFunctionId(631, false)]
        public VkFunctionPointer PFN_aux_631;
        [VkFunctionId(632, false)]
        public VkFunctionPointer PFN_aux_632;
        [VkFunctionId(633, false)]
        public VkFunctionPointer PFN_aux_633;
        [VkFunctionId(634, false)]
        public VkFunctionPointer PFN_aux_634;
        [VkFunctionId(635, false)]
        public VkFunctionPointer PFN_aux_635;
        [VkFunctionId(636, false)]
        public VkFunctionPointer PFN_aux_636;
        [VkFunctionId(637, false)]
        public VkFunctionPointer PFN_aux_637;
        [VkFunctionId(638, false)]
        public VkFunctionPointer PFN_aux_638;
        [VkFunctionId(639, false)]
        public VkFunctionPointer PFN_aux_639;
        [VkFunctionId(640, false)]
        public VkFunctionPointer PFN_aux_640;
        [VkFunctionId(641, false)]
        public VkFunctionPointer PFN_aux_641;
        [VkFunctionId(642, false)]
        public VkFunctionPointer PFN_aux_642;
        [VkFunctionId(643, false)]
        public VkFunctionPointer PFN_aux_643;
        [VkFunctionId(644, false)]
        public VkFunctionPointer PFN_aux_644;
        [VkFunctionId(645, false)]
        public VkFunctionPointer PFN_aux_645;
        [VkFunctionId(646, false)]
        public VkFunctionPointer PFN_aux_646;
        [VkFunctionId(647, false)]
        public VkFunctionPointer PFN_aux_647;
        [VkFunctionId(648, false)]
        public VkFunctionPointer PFN_aux_648;
        [VkFunctionId(649, false)]
        public VkFunctionPointer PFN_aux_649;
        [VkFunctionId(650, false)]
        public VkFunctionPointer PFN_aux_650;
        [VkFunctionId(651, false)]
        public VkFunctionPointer PFN_aux_651;
        [VkFunctionId(652, false)]
        public VkFunctionPointer PFN_aux_652;
        [VkFunctionId(653, false)]
        public VkFunctionPointer PFN_aux_653;
        [VkFunctionId(654, false)]
        public VkFunctionPointer PFN_aux_654;
        [VkFunctionId(655, false)]
        public VkFunctionPointer PFN_aux_655;
        [VkFunctionId(656, false)]
        public VkFunctionPointer PFN_aux_656;
        [VkFunctionId(657, false)]
        public VkFunctionPointer PFN_aux_657;
        [VkFunctionId(658, false)]
        public VkFunctionPointer PFN_aux_658;
        [VkFunctionId(659, false)]
        public VkFunctionPointer PFN_aux_659;
        [VkFunctionId(660, false)]
        public VkFunctionPointer PFN_aux_660;
        [VkFunctionId(661, false)]
        public VkFunctionPointer PFN_aux_661;
        [VkFunctionId(662, false)]
        public VkFunctionPointer PFN_aux_662;
        [VkFunctionId(663, false)]
        public VkFunctionPointer PFN_aux_663;
        [VkFunctionId(664, false)]
        public VkFunctionPointer PFN_aux_664;
        [VkFunctionId(665, false)]
        public VkFunctionPointer PFN_aux_665;
        [VkFunctionId(666, false)]
        public VkFunctionPointer PFN_aux_666;
        [VkFunctionId(667, false)]
        public VkFunctionPointer PFN_aux_667;
        [VkFunctionId(668, false)]
        public VkFunctionPointer PFN_aux_668;
        [VkFunctionId(669, false)]
        public VkFunctionPointer PFN_aux_669;
        [VkFunctionId(670, false)]
        public VkFunctionPointer PFN_aux_670;
        [VkFunctionId(671, false)]
        public VkFunctionPointer PFN_aux_671;
        [VkFunctionId(672, false)]
        public VkFunctionPointer PFN_aux_672;
        [VkFunctionId(673, false)]
        public VkFunctionPointer PFN_aux_673;
        [VkFunctionId(674, false)]
        public VkFunctionPointer PFN_aux_674;
        [VkFunctionId(675, false)]
        public VkFunctionPointer PFN_aux_675;
        [VkFunctionId(676, false)]
        public VkFunctionPointer PFN_aux_676;
        [VkFunctionId(677, false)]
        public VkFunctionPointer PFN_aux_677;
        [VkFunctionId(678, false)]
        public VkFunctionPointer PFN_aux_678;
        [VkFunctionId(679, false)]
        public VkFunctionPointer PFN_aux_679;
        [VkFunctionId(680, false)]
        public VkFunctionPointer PFN_aux_680;
        [VkFunctionId(681, false)]
        public VkFunctionPointer PFN_aux_681;
        [VkFunctionId(682, false)]
        public VkFunctionPointer PFN_aux_682;
        [VkFunctionId(683, false)]
        public VkFunctionPointer PFN_aux_683;
        [VkFunctionId(684, false)]
        public VkFunctionPointer PFN_aux_684;
        [VkFunctionId(685, false)]
        public VkFunctionPointer PFN_aux_685;
        [VkFunctionId(686, false)]
        public VkFunctionPointer PFN_aux_686;
        [VkFunctionId(687, false)]
        public VkFunctionPointer PFN_aux_687;
        [VkFunctionId(688, false)]
        public VkFunctionPointer PFN_aux_688;
        [VkFunctionId(689, false)]
        public VkFunctionPointer PFN_aux_689;
        [VkFunctionId(690, false)]
        public VkFunctionPointer PFN_aux_690;
        [VkFunctionId(691, false)]
        public VkFunctionPointer PFN_aux_691;
        [VkFunctionId(692, false)]
        public VkFunctionPointer PFN_aux_692;
        [VkFunctionId(693, false)]
        public VkFunctionPointer PFN_aux_693;
        [VkFunctionId(694, false)]
        public VkFunctionPointer PFN_aux_694;
        [VkFunctionId(695, false)]
        public VkFunctionPointer PFN_aux_695;
        [VkFunctionId(696, false)]
        public VkFunctionPointer PFN_aux_696;
        [VkFunctionId(697, false)]
        public VkFunctionPointer PFN_aux_697;
        [VkFunctionId(698, false)]
        public VkFunctionPointer PFN_aux_698;
        [VkFunctionId(699, false)]
        public VkFunctionPointer PFN_aux_699;
        [VkFunctionId(700, false)]
        public VkFunctionPointer PFN_aux_700;
        [VkFunctionId(701, false)]
        public VkFunctionPointer PFN_aux_701;
        [VkFunctionId(702, false)]
        public VkFunctionPointer PFN_aux_702;
        [VkFunctionId(703, false)]
        public VkFunctionPointer PFN_aux_703;
        [VkFunctionId(704, false)]
        public VkFunctionPointer PFN_aux_704;
        [VkFunctionId(705, false)]
        public VkFunctionPointer PFN_aux_705;
        [VkFunctionId(706, false)]
        public VkFunctionPointer PFN_aux_706;
        [VkFunctionId(707, false)]
        public VkFunctionPointer PFN_aux_707;
        [VkFunctionId(708, false)]
        public VkFunctionPointer PFN_aux_708;
        [VkFunctionId(709, false)]
        public VkFunctionPointer PFN_aux_709;
        [VkFunctionId(710, false)]
        public VkFunctionPointer PFN_aux_710;
        [VkFunctionId(711, false)]
        public VkFunctionPointer PFN_aux_711;
        [VkFunctionId(712, false)]
        public VkFunctionPointer PFN_aux_712;
        [VkFunctionId(713, false)]
        public VkFunctionPointer PFN_aux_713;
        [VkFunctionId(714, false)]
        public VkFunctionPointer PFN_aux_714;
        [VkFunctionId(715, false)]
        public VkFunctionPointer PFN_aux_715;
        [VkFunctionId(716, false)]
        public VkFunctionPointer PFN_aux_716;
        [VkFunctionId(717, false)]
        public VkFunctionPointer PFN_aux_717;
        [VkFunctionId(718, false)]
        public VkFunctionPointer PFN_aux_718;
        [VkFunctionId(719, false)]
        public VkFunctionPointer PFN_aux_719;
        [VkFunctionId(720, false)]
        public VkFunctionPointer PFN_aux_720;
        [VkFunctionId(721, false)]
        public VkFunctionPointer PFN_aux_721;
        [VkFunctionId(722, false)]
        public VkFunctionPointer PFN_aux_722;
        [VkFunctionId(723, false)]
        public VkFunctionPointer PFN_aux_723;
        [VkFunctionId(724, false)]
        public VkFunctionPointer PFN_aux_724;
        [VkFunctionId(725, false)]
        public VkFunctionPointer PFN_aux_725;
        [VkFunctionId(726, false)]
        public VkFunctionPointer PFN_aux_726;
        [VkFunctionId(727, false)]
        public VkFunctionPointer PFN_aux_727;
        [VkFunctionId(728, false)]
        public VkFunctionPointer PFN_aux_728;
        [VkFunctionId(729, false)]
        public VkFunctionPointer PFN_aux_729;
        [VkFunctionId(730, false)]
        public VkFunctionPointer PFN_aux_730;
        [VkFunctionId(731, false)]
        public VkFunctionPointer PFN_aux_731;
        [VkFunctionId(732, false)]
        public VkFunctionPointer PFN_aux_732;
        [VkFunctionId(733, false)]
        public VkFunctionPointer PFN_aux_733;
        [VkFunctionId(734, false)]
        public VkFunctionPointer PFN_aux_734;
        [VkFunctionId(735, false)]
        public VkFunctionPointer PFN_aux_735;
        [VkFunctionId(736, false)]
        public VkFunctionPointer PFN_aux_736;
        [VkFunctionId(737, false)]
        public VkFunctionPointer PFN_aux_737;
        [VkFunctionId(738, false)]
        public VkFunctionPointer PFN_aux_738;
        [VkFunctionId(739, false)]
        public VkFunctionPointer PFN_aux_739;
        [VkFunctionId(740, false)]
        public VkFunctionPointer PFN_aux_740;
        [VkFunctionId(741, false)]
        public VkFunctionPointer PFN_aux_741;
        [VkFunctionId(742, false)]
        public VkFunctionPointer PFN_aux_742;
        [VkFunctionId(743, false)]
        public VkFunctionPointer PFN_aux_743;
        [VkFunctionId(744, false)]
        public VkFunctionPointer PFN_aux_744;
        [VkFunctionId(745, false)]
        public VkFunctionPointer PFN_aux_745;
        [VkFunctionId(746, false)]
        public VkFunctionPointer PFN_aux_746;
        [VkFunctionId(747, false)]
        public VkFunctionPointer PFN_aux_747;
        [VkFunctionId(748, false)]
        public VkFunctionPointer PFN_aux_748;
        [VkFunctionId(749, false)]
        public VkFunctionPointer PFN_aux_749;
        [VkFunctionId(750, false)]
        public VkFunctionPointer PFN_aux_750;
        [VkFunctionId(751, false)]
        public VkFunctionPointer PFN_aux_751;
        [VkFunctionId(752, false)]
        public VkFunctionPointer PFN_aux_752;
        [VkFunctionId(753, false)]
        public VkFunctionPointer PFN_aux_753;
        [VkFunctionId(754, false)]
        public VkFunctionPointer PFN_aux_754;
        [VkFunctionId(755, false)]
        public VkFunctionPointer PFN_aux_755;
        [VkFunctionId(756, false)]
        public VkFunctionPointer PFN_aux_756;
        [VkFunctionId(757, false)]
        public VkFunctionPointer PFN_aux_757;
        [VkFunctionId(758, false)]
        public VkFunctionPointer PFN_aux_758;
        [VkFunctionId(759, false)]
        public VkFunctionPointer PFN_aux_759;
        [VkFunctionId(760, false)]
        public VkFunctionPointer PFN_aux_760;
        [VkFunctionId(761, false)]
        public VkFunctionPointer PFN_aux_761;
        [VkFunctionId(762, false)]
        public VkFunctionPointer PFN_aux_762;
        [VkFunctionId(763, false)]
        public VkFunctionPointer PFN_aux_763;
        [VkFunctionId(764, false)]
        public VkFunctionPointer PFN_aux_764;
        [VkFunctionId(765, false)]
        public VkFunctionPointer PFN_aux_765;
        [VkFunctionId(766, false)]
        public VkFunctionPointer PFN_aux_766;
        [VkFunctionId(767, false)]
        public VkFunctionPointer PFN_aux_767;
        [VkFunctionId(768, false)]
        public VkFunctionPointer PFN_aux_768;
        [VkFunctionId(769, false)]
        public VkFunctionPointer PFN_aux_769;
        [VkFunctionId(770, false)]
        public VkFunctionPointer PFN_aux_770;
        [VkFunctionId(771, false)]
        public VkFunctionPointer PFN_aux_771;
        [VkFunctionId(772, false)]
        public VkFunctionPointer PFN_aux_772;
        [VkFunctionId(773, false)]
        public VkFunctionPointer PFN_aux_773;
        [VkFunctionId(774, false)]
        public VkFunctionPointer PFN_aux_774;
        [VkFunctionId(775, false)]
        public VkFunctionPointer PFN_aux_775;
        [VkFunctionId(776, false)]
        public VkFunctionPointer PFN_aux_776;
        [VkFunctionId(777, false)]
        public VkFunctionPointer PFN_aux_777;
        [VkFunctionId(778, false)]
        public VkFunctionPointer PFN_aux_778;
        [VkFunctionId(779, false)]
        public VkFunctionPointer PFN_aux_779;
        [VkFunctionId(780, false)]
        public VkFunctionPointer PFN_aux_780;
        [VkFunctionId(781, false)]
        public VkFunctionPointer PFN_aux_781;
        [VkFunctionId(782, false)]
        public VkFunctionPointer PFN_aux_782;
        [VkFunctionId(783, false)]
        public VkFunctionPointer PFN_aux_783;
        [VkFunctionId(784, false)]
        public VkFunctionPointer PFN_aux_784;
        [VkFunctionId(785, false)]
        public VkFunctionPointer PFN_aux_785;
        [VkFunctionId(786, false)]
        public VkFunctionPointer PFN_aux_786;
        [VkFunctionId(787, false)]
        public VkFunctionPointer PFN_aux_787;
        [VkFunctionId(788, false)]
        public VkFunctionPointer PFN_aux_788;
        [VkFunctionId(789, false)]
        public VkFunctionPointer PFN_aux_789;
        [VkFunctionId(790, false)]
        public VkFunctionPointer PFN_aux_790;
        [VkFunctionId(791, false)]
        public VkFunctionPointer PFN_aux_791;
        [VkFunctionId(792, false)]
        public VkFunctionPointer PFN_aux_792;
        [VkFunctionId(793, false)]
        public VkFunctionPointer PFN_aux_793;
        [VkFunctionId(794, false)]
        public VkFunctionPointer PFN_aux_794;
        [VkFunctionId(795, false)]
        public VkFunctionPointer PFN_aux_795;
        [VkFunctionId(796, false)]
        public VkFunctionPointer PFN_aux_796;
        [VkFunctionId(797, false)]
        public VkFunctionPointer PFN_aux_797;
        [VkFunctionId(798, false)]
        public VkFunctionPointer PFN_aux_798;
        [VkFunctionId(799, false)]
        public VkFunctionPointer PFN_aux_799;
        [VkFunctionId(800, false)]
        public VkFunctionPointer PFN_aux_800;
        [VkFunctionId(801, false)]
        public VkFunctionPointer PFN_aux_801;
        [VkFunctionId(802, false)]
        public VkFunctionPointer PFN_aux_802;
        [VkFunctionId(803, false)]
        public VkFunctionPointer PFN_aux_803;
        [VkFunctionId(804, false)]
        public VkFunctionPointer PFN_aux_804;
        [VkFunctionId(805, false)]
        public VkFunctionPointer PFN_aux_805;
        [VkFunctionId(806, false)]
        public VkFunctionPointer PFN_aux_806;
        [VkFunctionId(807, false)]
        public VkFunctionPointer PFN_aux_807;
        [VkFunctionId(808, false)]
        public VkFunctionPointer PFN_aux_808;
        [VkFunctionId(809, false)]
        public VkFunctionPointer PFN_aux_809;
        [VkFunctionId(810, false)]
        public VkFunctionPointer PFN_aux_810;
        [VkFunctionId(811, false)]
        public VkFunctionPointer PFN_aux_811;
        [VkFunctionId(812, false)]
        public VkFunctionPointer PFN_aux_812;
        [VkFunctionId(813, false)]
        public VkFunctionPointer PFN_aux_813;
        [VkFunctionId(814, false)]
        public VkFunctionPointer PFN_aux_814;
        [VkFunctionId(815, false)]
        public VkFunctionPointer PFN_aux_815;
        [VkFunctionId(816, false)]
        public VkFunctionPointer PFN_aux_816;
        [VkFunctionId(817, false)]
        public VkFunctionPointer PFN_aux_817;
        [VkFunctionId(818, false)]
        public VkFunctionPointer PFN_aux_818;
        [VkFunctionId(819, false)]
        public VkFunctionPointer PFN_aux_819;
        [VkFunctionId(820, false)]
        public VkFunctionPointer PFN_aux_820;
        [VkFunctionId(821, false)]
        public VkFunctionPointer PFN_aux_821;
        [VkFunctionId(822, false)]
        public VkFunctionPointer PFN_aux_822;
        [VkFunctionId(823, false)]
        public VkFunctionPointer PFN_aux_823;
        [VkFunctionId(824, false)]
        public VkFunctionPointer PFN_aux_824;
        [VkFunctionId(825, false)]
        public VkFunctionPointer PFN_aux_825;
        [VkFunctionId(826, false)]
        public VkFunctionPointer PFN_aux_826;
        [VkFunctionId(827, false)]
        public VkFunctionPointer PFN_aux_827;
        [VkFunctionId(828, false)]
        public VkFunctionPointer PFN_aux_828;
        [VkFunctionId(829, false)]
        public VkFunctionPointer PFN_aux_829;
        [VkFunctionId(830, false)]
        public VkFunctionPointer PFN_aux_830;
        [VkFunctionId(831, false)]
        public VkFunctionPointer PFN_aux_831;
        [VkFunctionId(832, false)]
        public VkFunctionPointer PFN_aux_832;
        [VkFunctionId(833, false)]
        public VkFunctionPointer PFN_aux_833;
        [VkFunctionId(834, false)]
        public VkFunctionPointer PFN_aux_834;
        [VkFunctionId(835, false)]
        public VkFunctionPointer PFN_aux_835;
        [VkFunctionId(836, false)]
        public VkFunctionPointer PFN_aux_836;
        [VkFunctionId(837, false)]
        public VkFunctionPointer PFN_aux_837;
        [VkFunctionId(838, false)]
        public VkFunctionPointer PFN_aux_838;
        [VkFunctionId(839, false)]
        public VkFunctionPointer PFN_aux_839;
        [VkFunctionId(840, false)]
        public VkFunctionPointer PFN_aux_840;
        [VkFunctionId(841, false)]
        public VkFunctionPointer PFN_aux_841;
        [VkFunctionId(842, false)]
        public VkFunctionPointer PFN_aux_842;
        [VkFunctionId(843, false)]
        public VkFunctionPointer PFN_aux_843;
        [VkFunctionId(844, false)]
        public VkFunctionPointer PFN_aux_844;
        [VkFunctionId(845, false)]
        public VkFunctionPointer PFN_aux_845;
        [VkFunctionId(846, false)]
        public VkFunctionPointer PFN_aux_846;
        [VkFunctionId(847, false)]
        public VkFunctionPointer PFN_aux_847;
        [VkFunctionId(848, false)]
        public VkFunctionPointer PFN_aux_848;
        [VkFunctionId(849, false)]
        public VkFunctionPointer PFN_aux_849;
        [VkFunctionId(850, false)]
        public VkFunctionPointer PFN_aux_850;
        [VkFunctionId(851, false)]
        public VkFunctionPointer PFN_aux_851;
        [VkFunctionId(852, false)]
        public VkFunctionPointer PFN_aux_852;
        [VkFunctionId(853, false)]
        public VkFunctionPointer PFN_aux_853;
        [VkFunctionId(854, false)]
        public VkFunctionPointer PFN_aux_854;
        [VkFunctionId(855, false)]
        public VkFunctionPointer PFN_aux_855;
        [VkFunctionId(856, false)]
        public VkFunctionPointer PFN_aux_856;
        [VkFunctionId(857, false)]
        public VkFunctionPointer PFN_aux_857;
        [VkFunctionId(858, false)]
        public VkFunctionPointer PFN_aux_858;
        [VkFunctionId(859, false)]
        public VkFunctionPointer PFN_aux_859;
        [VkFunctionId(860, false)]
        public VkFunctionPointer PFN_aux_860;
        [VkFunctionId(861, false)]
        public VkFunctionPointer PFN_aux_861;
        [VkFunctionId(862, false)]
        public VkFunctionPointer PFN_aux_862;
        [VkFunctionId(863, false)]
        public VkFunctionPointer PFN_aux_863;
        [VkFunctionId(864, false)]
        public VkFunctionPointer PFN_aux_864;
        [VkFunctionId(865, false)]
        public VkFunctionPointer PFN_aux_865;
        [VkFunctionId(866, false)]
        public VkFunctionPointer PFN_aux_866;
        [VkFunctionId(867, false)]
        public VkFunctionPointer PFN_aux_867;
        [VkFunctionId(868, false)]
        public VkFunctionPointer PFN_aux_868;
        [VkFunctionId(869, false)]
        public VkFunctionPointer PFN_aux_869;
        [VkFunctionId(870, false)]
        public VkFunctionPointer PFN_aux_870;
        [VkFunctionId(871, false)]
        public VkFunctionPointer PFN_aux_871;
        [VkFunctionId(872, false)]
        public VkFunctionPointer PFN_aux_872;
        [VkFunctionId(873, false)]
        public VkFunctionPointer PFN_aux_873;
        [VkFunctionId(874, false)]
        public VkFunctionPointer PFN_aux_874;
        [VkFunctionId(875, false)]
        public VkFunctionPointer PFN_aux_875;
        [VkFunctionId(876, false)]
        public VkFunctionPointer PFN_aux_876;
        [VkFunctionId(877, false)]
        public VkFunctionPointer PFN_aux_877;
        [VkFunctionId(878, false)]
        public VkFunctionPointer PFN_aux_878;
        [VkFunctionId(879, false)]
        public VkFunctionPointer PFN_aux_879;
        [VkFunctionId(880, false)]
        public VkFunctionPointer PFN_aux_880;
        [VkFunctionId(881, false)]
        public VkFunctionPointer PFN_aux_881;
        [VkFunctionId(882, false)]
        public VkFunctionPointer PFN_aux_882;
        [VkFunctionId(883, false)]
        public VkFunctionPointer PFN_aux_883;
        [VkFunctionId(884, false)]
        public VkFunctionPointer PFN_aux_884;
        [VkFunctionId(885, false)]
        public VkFunctionPointer PFN_aux_885;
        [VkFunctionId(886, false)]
        public VkFunctionPointer PFN_aux_886;
        [VkFunctionId(887, false)]
        public VkFunctionPointer PFN_aux_887;
        [VkFunctionId(888, false)]
        public VkFunctionPointer PFN_aux_888;
        [VkFunctionId(889, false)]
        public VkFunctionPointer PFN_aux_889;
        [VkFunctionId(890, false)]
        public VkFunctionPointer PFN_aux_890;
        [VkFunctionId(891, false)]
        public VkFunctionPointer PFN_aux_891;
        [VkFunctionId(892, false)]
        public VkFunctionPointer PFN_aux_892;
        [VkFunctionId(893, false)]
        public VkFunctionPointer PFN_aux_893;
        [VkFunctionId(894, false)]
        public VkFunctionPointer PFN_aux_894;
        [VkFunctionId(895, false)]
        public VkFunctionPointer PFN_aux_895;
        [VkFunctionId(896, false)]
        public VkFunctionPointer PFN_aux_896;
        [VkFunctionId(897, false)]
        public VkFunctionPointer PFN_aux_897;
        [VkFunctionId(898, false)]
        public VkFunctionPointer PFN_aux_898;
        [VkFunctionId(899, false)]
        public VkFunctionPointer PFN_aux_899;
        [VkFunctionId(900, false)]
        public VkFunctionPointer PFN_aux_900;
        [VkFunctionId(901, false)]
        public VkFunctionPointer PFN_aux_901;
        [VkFunctionId(902, false)]
        public VkFunctionPointer PFN_aux_902;
        [VkFunctionId(903, false)]
        public VkFunctionPointer PFN_aux_903;
        [VkFunctionId(904, false)]
        public VkFunctionPointer PFN_aux_904;
        [VkFunctionId(905, false)]
        public VkFunctionPointer PFN_aux_905;
        [VkFunctionId(906, false)]
        public VkFunctionPointer PFN_aux_906;
        [VkFunctionId(907, false)]
        public VkFunctionPointer PFN_aux_907;
        [VkFunctionId(908, false)]
        public VkFunctionPointer PFN_aux_908;
        [VkFunctionId(909, false)]
        public VkFunctionPointer PFN_aux_909;
        [VkFunctionId(910, false)]
        public VkFunctionPointer PFN_aux_910;
        [VkFunctionId(911, false)]
        public VkFunctionPointer PFN_aux_911;
        [VkFunctionId(912, false)]
        public VkFunctionPointer PFN_aux_912;
        [VkFunctionId(913, false)]
        public VkFunctionPointer PFN_aux_913;
        [VkFunctionId(914, false)]
        public VkFunctionPointer PFN_aux_914;
        [VkFunctionId(915, false)]
        public VkFunctionPointer PFN_aux_915;
        [VkFunctionId(916, false)]
        public VkFunctionPointer PFN_aux_916;
        [VkFunctionId(917, false)]
        public VkFunctionPointer PFN_aux_917;
        [VkFunctionId(918, false)]
        public VkFunctionPointer PFN_aux_918;
        [VkFunctionId(919, false)]
        public VkFunctionPointer PFN_aux_919;
        [VkFunctionId(920, false)]
        public VkFunctionPointer PFN_aux_920;
        [VkFunctionId(921, false)]
        public VkFunctionPointer PFN_aux_921;
        [VkFunctionId(922, false)]
        public VkFunctionPointer PFN_aux_922;
        [VkFunctionId(923, false)]
        public VkFunctionPointer PFN_aux_923;
        [VkFunctionId(924, false)]
        public VkFunctionPointer PFN_aux_924;
        [VkFunctionId(925, false)]
        public VkFunctionPointer PFN_aux_925;
        [VkFunctionId(926, false)]
        public VkFunctionPointer PFN_aux_926;
        [VkFunctionId(927, false)]
        public VkFunctionPointer PFN_aux_927;
        [VkFunctionId(928, false)]
        public VkFunctionPointer PFN_aux_928;
        [VkFunctionId(929, false)]
        public VkFunctionPointer PFN_aux_929;
        [VkFunctionId(930, false)]
        public VkFunctionPointer PFN_aux_930;
        [VkFunctionId(931, false)]
        public VkFunctionPointer PFN_aux_931;
        [VkFunctionId(932, false)]
        public VkFunctionPointer PFN_aux_932;
        [VkFunctionId(933, false)]
        public VkFunctionPointer PFN_aux_933;
        [VkFunctionId(934, false)]
        public VkFunctionPointer PFN_aux_934;
        [VkFunctionId(935, false)]
        public VkFunctionPointer PFN_aux_935;
        [VkFunctionId(936, false)]
        public VkFunctionPointer PFN_aux_936;
        [VkFunctionId(937, false)]
        public VkFunctionPointer PFN_aux_937;
        [VkFunctionId(938, false)]
        public VkFunctionPointer PFN_aux_938;
        [VkFunctionId(939, false)]
        public VkFunctionPointer PFN_aux_939;
        [VkFunctionId(940, false)]
        public VkFunctionPointer PFN_aux_940;
        [VkFunctionId(941, false)]
        public VkFunctionPointer PFN_aux_941;
        [VkFunctionId(942, false)]
        public VkFunctionPointer PFN_aux_942;
        [VkFunctionId(943, false)]
        public VkFunctionPointer PFN_aux_943;
        [VkFunctionId(944, false)]
        public VkFunctionPointer PFN_aux_944;
        [VkFunctionId(945, false)]
        public VkFunctionPointer PFN_aux_945;
        [VkFunctionId(946, false)]
        public VkFunctionPointer PFN_aux_946;
        [VkFunctionId(947, false)]
        public VkFunctionPointer PFN_aux_947;
        [VkFunctionId(948, false)]
        public VkFunctionPointer PFN_aux_948;
        [VkFunctionId(949, false)]
        public VkFunctionPointer PFN_aux_949;
        [VkFunctionId(950, false)]
        public VkFunctionPointer PFN_aux_950;
        [VkFunctionId(951, false)]
        public VkFunctionPointer PFN_aux_951;
        [VkFunctionId(952, false)]
        public VkFunctionPointer PFN_aux_952;
        [VkFunctionId(953, false)]
        public VkFunctionPointer PFN_aux_953;
        [VkFunctionId(954, false)]
        public VkFunctionPointer PFN_aux_954;
        [VkFunctionId(955, false)]
        public VkFunctionPointer PFN_aux_955;
        [VkFunctionId(956, false)]
        public VkFunctionPointer PFN_aux_956;
        [VkFunctionId(957, false)]
        public VkFunctionPointer PFN_aux_957;
        [VkFunctionId(958, false)]
        public VkFunctionPointer PFN_aux_958;
        [VkFunctionId(959, false)]
        public VkFunctionPointer PFN_aux_959;
        [VkFunctionId(960, false)]
        public VkFunctionPointer PFN_aux_960;
        [VkFunctionId(961, false)]
        public VkFunctionPointer PFN_aux_961;
        [VkFunctionId(962, false)]
        public VkFunctionPointer PFN_aux_962;
        [VkFunctionId(963, false)]
        public VkFunctionPointer PFN_aux_963;
        [VkFunctionId(964, false)]
        public VkFunctionPointer PFN_aux_964;
        [VkFunctionId(965, false)]
        public VkFunctionPointer PFN_aux_965;
        [VkFunctionId(966, false)]
        public VkFunctionPointer PFN_aux_966;
        [VkFunctionId(967, false)]
        public VkFunctionPointer PFN_aux_967;
        [VkFunctionId(968, false)]
        public VkFunctionPointer PFN_aux_968;
        [VkFunctionId(969, false)]
        public VkFunctionPointer PFN_aux_969;
        [VkFunctionId(970, false)]
        public VkFunctionPointer PFN_aux_970;
        [VkFunctionId(971, false)]
        public VkFunctionPointer PFN_aux_971;
        [VkFunctionId(972, false)]
        public VkFunctionPointer PFN_aux_972;
        [VkFunctionId(973, false)]
        public VkFunctionPointer PFN_aux_973;
        [VkFunctionId(974, false)]
        public VkFunctionPointer PFN_aux_974;
        [VkFunctionId(975, false)]
        public VkFunctionPointer PFN_aux_975;
        [VkFunctionId(976, false)]
        public VkFunctionPointer PFN_aux_976;
        [VkFunctionId(977, false)]
        public VkFunctionPointer PFN_aux_977;
        [VkFunctionId(978, false)]
        public VkFunctionPointer PFN_aux_978;
        [VkFunctionId(979, false)]
        public VkFunctionPointer PFN_aux_979;
        [VkFunctionId(980, false)]
        public VkFunctionPointer PFN_aux_980;
        [VkFunctionId(981, false)]
        public VkFunctionPointer PFN_aux_981;
        [VkFunctionId(982, false)]
        public VkFunctionPointer PFN_aux_982;
        [VkFunctionId(983, false)]
        public VkFunctionPointer PFN_aux_983;
        [VkFunctionId(984, false)]
        public VkFunctionPointer PFN_aux_984;
        [VkFunctionId(985, false)]
        public VkFunctionPointer PFN_aux_985;
        [VkFunctionId(986, false)]
        public VkFunctionPointer PFN_aux_986;
        [VkFunctionId(987, false)]
        public VkFunctionPointer PFN_aux_987;
        [VkFunctionId(988, false)]
        public VkFunctionPointer PFN_aux_988;
        [VkFunctionId(989, false)]
        public VkFunctionPointer PFN_aux_989;
        [VkFunctionId(990, false)]
        public VkFunctionPointer PFN_aux_990;
        [VkFunctionId(991, false)]
        public VkFunctionPointer PFN_aux_991;
        [VkFunctionId(992, false)]
        public VkFunctionPointer PFN_aux_992;
        [VkFunctionId(993, false)]
        public VkFunctionPointer PFN_aux_993;
        [VkFunctionId(994, false)]
        public VkFunctionPointer PFN_aux_994;
        [VkFunctionId(995, false)]
        public VkFunctionPointer PFN_aux_995;
        [VkFunctionId(996, false)]
        public VkFunctionPointer PFN_aux_996;
        [VkFunctionId(997, false)]
        public VkFunctionPointer PFN_aux_997;
        [VkFunctionId(998, false)]
        public VkFunctionPointer PFN_aux_998;
        [VkFunctionId(999, false)]
        public VkFunctionPointer PFN_aux_999;
        [VkFunctionId(1000, false)]
        public VkFunctionPointer PFN_aux_1000;
        [VkFunctionId(1001, false)]
        public VkFunctionPointer PFN_aux_1001;
        [VkFunctionId(1002, false)]
        public VkFunctionPointer PFN_aux_1002;
        [VkFunctionId(1003, false)]
        public VkFunctionPointer PFN_aux_1003;
        [VkFunctionId(1004, false)]
        public VkFunctionPointer PFN_aux_1004;
        [VkFunctionId(1005, false)]
        public VkFunctionPointer PFN_aux_1005;
        [VkFunctionId(1006, false)]
        public VkFunctionPointer PFN_aux_1006;
        [VkFunctionId(1007, false)]
        public VkFunctionPointer PFN_aux_1007;
        [VkFunctionId(1008, false)]
        public VkFunctionPointer PFN_aux_1008;
        [VkFunctionId(1009, false)]
        public VkFunctionPointer PFN_aux_1009;
        [VkFunctionId(1010, false)]
        public VkFunctionPointer PFN_aux_1010;
        [VkFunctionId(1011, false)]
        public VkFunctionPointer PFN_aux_1011;
        [VkFunctionId(1012, false)]
        public VkFunctionPointer PFN_aux_1012;
        [VkFunctionId(1013, false)]
        public VkFunctionPointer PFN_aux_1013;
        [VkFunctionId(1014, false)]
        public VkFunctionPointer PFN_aux_1014;
        [VkFunctionId(1015, false)]
        public VkFunctionPointer PFN_aux_1015;
        [VkFunctionId(1016, false)]
        public VkFunctionPointer PFN_aux_1016;
        [VkFunctionId(1017, false)]
        public VkFunctionPointer PFN_aux_1017;
        [VkFunctionId(1018, false)]
        public VkFunctionPointer PFN_aux_1018;
        [VkFunctionId(1019, false)]
        public VkFunctionPointer PFN_aux_1019;
        [VkFunctionId(1020, false)]
        public VkFunctionPointer PFN_aux_1020;
        [VkFunctionId(1021, false)]
        public VkFunctionPointer PFN_aux_1021;
        [VkFunctionId(1022, false)]
        public VkFunctionPointer PFN_aux_1022;
        [VkFunctionId(1023, false)]
        public VkFunctionPointer PFN_aux_1023;
        [VkFunctionId(1024, false)]
        public VkFunctionPointer PFN_aux_1024;
        [VkFunctionId(1025, false)]
        public VkFunctionPointer PFN_aux_1025;
        [VkFunctionId(1026, false)]
        public VkFunctionPointer PFN_aux_1026;
        [VkFunctionId(1027, false)]
        public VkFunctionPointer PFN_aux_1027;
        [VkFunctionId(1028, false)]
        public VkFunctionPointer PFN_aux_1028;
        [VkFunctionId(1029, false)]
        public VkFunctionPointer PFN_aux_1029;
        [VkFunctionId(1030, false)]
        public VkFunctionPointer PFN_aux_1030;
        [VkFunctionId(1031, false)]
        public VkFunctionPointer PFN_aux_1031;
        [VkFunctionId(1032, false)]
        public VkFunctionPointer PFN_aux_1032;
        [VkFunctionId(1033, false)]
        public VkFunctionPointer PFN_aux_1033;
        [VkFunctionId(1034, false)]
        public VkFunctionPointer PFN_aux_1034;
        [VkFunctionId(1035, false)]
        public VkFunctionPointer PFN_aux_1035;
        [VkFunctionId(1036, false)]
        public VkFunctionPointer PFN_aux_1036;
        [VkFunctionId(1037, false)]
        public VkFunctionPointer PFN_aux_1037;
        [VkFunctionId(1038, false)]
        public VkFunctionPointer PFN_aux_1038;
        [VkFunctionId(1039, false)]
        public VkFunctionPointer PFN_aux_1039;
        [VkFunctionId(1040, false)]
        public VkFunctionPointer PFN_aux_1040;
        [VkFunctionId(1041, false)]
        public VkFunctionPointer PFN_aux_1041;
        [VkFunctionId(1042, false)]
        public VkFunctionPointer PFN_aux_1042;
        [VkFunctionId(1043, false)]
        public VkFunctionPointer PFN_aux_1043;
        [VkFunctionId(1044, false)]
        public VkFunctionPointer PFN_aux_1044;
        [VkFunctionId(1045, false)]
        public VkFunctionPointer PFN_aux_1045;
        [VkFunctionId(1046, false)]
        public VkFunctionPointer PFN_aux_1046;
        [VkFunctionId(1047, false)]
        public VkFunctionPointer PFN_aux_1047;
        [VkFunctionId(1048, false)]
        public VkFunctionPointer PFN_aux_1048;
        [VkFunctionId(1049, false)]
        public VkFunctionPointer PFN_aux_1049;
        [VkFunctionId(1050, false)]
        public VkFunctionPointer PFN_aux_1050;
        [VkFunctionId(1051, false)]
        public VkFunctionPointer PFN_aux_1051;
        [VkFunctionId(1052, false)]
        public VkFunctionPointer PFN_aux_1052;
        [VkFunctionId(1053, false)]
        public VkFunctionPointer PFN_aux_1053;
        [VkFunctionId(1054, false)]
        public VkFunctionPointer PFN_aux_1054;
        [VkFunctionId(1055, false)]
        public VkFunctionPointer PFN_aux_1055;
        [VkFunctionId(1056, false)]
        public VkFunctionPointer PFN_aux_1056;
        [VkFunctionId(1057, false)]
        public VkFunctionPointer PFN_aux_1057;
        [VkFunctionId(1058, false)]
        public VkFunctionPointer PFN_aux_1058;
        [VkFunctionId(1059, false)]
        public VkFunctionPointer PFN_aux_1059;
        [VkFunctionId(1060, false)]
        public VkFunctionPointer PFN_aux_1060;
        [VkFunctionId(1061, false)]
        public VkFunctionPointer PFN_aux_1061;
        [VkFunctionId(1062, false)]
        public VkFunctionPointer PFN_aux_1062;
        [VkFunctionId(1063, false)]
        public VkFunctionPointer PFN_aux_1063;
        [VkFunctionId(1064, false)]
        public VkFunctionPointer PFN_aux_1064;
        [VkFunctionId(1065, false)]
        public VkFunctionPointer PFN_aux_1065;
        [VkFunctionId(1066, false)]
        public VkFunctionPointer PFN_aux_1066;
        [VkFunctionId(1067, false)]
        public VkFunctionPointer PFN_aux_1067;
        [VkFunctionId(1068, false)]
        public VkFunctionPointer PFN_aux_1068;
        [VkFunctionId(1069, false)]
        public VkFunctionPointer PFN_aux_1069;
        [VkFunctionId(1070, false)]
        public VkFunctionPointer PFN_aux_1070;
        [VkFunctionId(1071, false)]
        public VkFunctionPointer PFN_aux_1071;
        [VkFunctionId(1072, false)]
        public VkFunctionPointer PFN_aux_1072;
        [VkFunctionId(1073, false)]
        public VkFunctionPointer PFN_aux_1073;
        [VkFunctionId(1074, false)]
        public VkFunctionPointer PFN_aux_1074;
        [VkFunctionId(1075, false)]
        public VkFunctionPointer PFN_aux_1075;
        [VkFunctionId(1076, false)]
        public VkFunctionPointer PFN_aux_1076;
        [VkFunctionId(1077, false)]
        public VkFunctionPointer PFN_aux_1077;
        [VkFunctionId(1078, false)]
        public VkFunctionPointer PFN_aux_1078;
        [VkFunctionId(1079, false)]
        public VkFunctionPointer PFN_aux_1079;
        [VkFunctionId(1080, false)]
        public VkFunctionPointer PFN_aux_1080;
        [VkFunctionId(1081, false)]
        public VkFunctionPointer PFN_aux_1081;
        [VkFunctionId(1082, false)]
        public VkFunctionPointer PFN_aux_1082;
        [VkFunctionId(1083, false)]
        public VkFunctionPointer PFN_aux_1083;
        [VkFunctionId(1084, false)]
        public VkFunctionPointer PFN_aux_1084;
        [VkFunctionId(1085, false)]
        public VkFunctionPointer PFN_aux_1085;
        [VkFunctionId(1086, false)]
        public VkFunctionPointer PFN_aux_1086;
        [VkFunctionId(1087, false)]
        public VkFunctionPointer PFN_aux_1087;
        [VkFunctionId(1088, false)]
        public VkFunctionPointer PFN_aux_1088;
        [VkFunctionId(1089, false)]
        public VkFunctionPointer PFN_aux_1089;
        [VkFunctionId(1090, false)]
        public VkFunctionPointer PFN_aux_1090;
        [VkFunctionId(1091, false)]
        public VkFunctionPointer PFN_aux_1091;
        [VkFunctionId(1092, false)]
        public VkFunctionPointer PFN_aux_1092;
        [VkFunctionId(1093, false)]
        public VkFunctionPointer PFN_aux_1093;
        [VkFunctionId(1094, false)]
        public VkFunctionPointer PFN_aux_1094;
        [VkFunctionId(1095, false)]
        public VkFunctionPointer PFN_aux_1095;
        [VkFunctionId(1096, false)]
        public VkFunctionPointer PFN_aux_1096;
        [VkFunctionId(1097, false)]
        public VkFunctionPointer PFN_aux_1097;
        [VkFunctionId(1098, false)]
        public VkFunctionPointer PFN_aux_1098;
        [VkFunctionId(1099, false)]
        public VkFunctionPointer PFN_aux_1099;
        [VkFunctionId(1100, false)]
        public VkFunctionPointer PFN_aux_1100;
        [VkFunctionId(1101, false)]
        public VkFunctionPointer PFN_aux_1101;
        [VkFunctionId(1102, false)]
        public VkFunctionPointer PFN_aux_1102;
        [VkFunctionId(1103, false)]
        public VkFunctionPointer PFN_aux_1103;
        [VkFunctionId(1104, false)]
        public VkFunctionPointer PFN_aux_1104;
        [VkFunctionId(1105, false)]
        public VkFunctionPointer PFN_aux_1105;
        [VkFunctionId(1106, false)]
        public VkFunctionPointer PFN_aux_1106;
        [VkFunctionId(1107, false)]
        public VkFunctionPointer PFN_aux_1107;
        [VkFunctionId(1108, false)]
        public VkFunctionPointer PFN_aux_1108;
        [VkFunctionId(1109, false)]
        public VkFunctionPointer PFN_aux_1109;
        [VkFunctionId(1110, false)]
        public VkFunctionPointer PFN_aux_1110;
        [VkFunctionId(1111, false)]
        public VkFunctionPointer PFN_aux_1111;
        [VkFunctionId(1112, false)]
        public VkFunctionPointer PFN_aux_1112;
        [VkFunctionId(1113, false)]
        public VkFunctionPointer PFN_aux_1113;
        [VkFunctionId(1114, false)]
        public VkFunctionPointer PFN_aux_1114;
        [VkFunctionId(1115, false)]
        public VkFunctionPointer PFN_aux_1115;
        [VkFunctionId(1116, false)]
        public VkFunctionPointer PFN_aux_1116;
        [VkFunctionId(1117, false)]
        public VkFunctionPointer PFN_aux_1117;
        [VkFunctionId(1118, false)]
        public VkFunctionPointer PFN_aux_1118;
        [VkFunctionId(1119, false)]
        public VkFunctionPointer PFN_aux_1119;
        [VkFunctionId(1120, false)]
        public VkFunctionPointer PFN_aux_1120;
        [VkFunctionId(1121, false)]
        public VkFunctionPointer PFN_aux_1121;
        [VkFunctionId(1122, false)]
        public VkFunctionPointer PFN_aux_1122;
        [VkFunctionId(1123, false)]
        public VkFunctionPointer PFN_aux_1123;
        [VkFunctionId(1124, false)]
        public VkFunctionPointer PFN_aux_1124;
        [VkFunctionId(1125, false)]
        public VkFunctionPointer PFN_aux_1125;
        [VkFunctionId(1126, false)]
        public VkFunctionPointer PFN_aux_1126;
        [VkFunctionId(1127, false)]
        public VkFunctionPointer PFN_aux_1127;
        [VkFunctionId(1128, false)]
        public VkFunctionPointer PFN_aux_1128;
        [VkFunctionId(1129, false)]
        public VkFunctionPointer PFN_aux_1129;
        [VkFunctionId(1130, false)]
        public VkFunctionPointer PFN_aux_1130;
        [VkFunctionId(1131, false)]
        public VkFunctionPointer PFN_aux_1131;
        [VkFunctionId(1132, false)]
        public VkFunctionPointer PFN_aux_1132;
        [VkFunctionId(1133, false)]
        public VkFunctionPointer PFN_aux_1133;
        [VkFunctionId(1134, false)]
        public VkFunctionPointer PFN_aux_1134;
        [VkFunctionId(1135, false)]
        public VkFunctionPointer PFN_aux_1135;
        [VkFunctionId(1136, false)]
        public VkFunctionPointer PFN_aux_1136;
        [VkFunctionId(1137, false)]
        public VkFunctionPointer PFN_aux_1137;
        [VkFunctionId(1138, false)]
        public VkFunctionPointer PFN_aux_1138;
        [VkFunctionId(1139, false)]
        public VkFunctionPointer PFN_aux_1139;
        [VkFunctionId(1140, false)]
        public VkFunctionPointer PFN_aux_1140;
        [VkFunctionId(1141, false)]
        public VkFunctionPointer PFN_aux_1141;
        [VkFunctionId(1142, false)]
        public VkFunctionPointer PFN_aux_1142;
        [VkFunctionId(1143, false)]
        public VkFunctionPointer PFN_aux_1143;
        [VkFunctionId(1144, false)]
        public VkFunctionPointer PFN_aux_1144;
        [VkFunctionId(1145, false)]
        public VkFunctionPointer PFN_aux_1145;
        [VkFunctionId(1146, false)]
        public VkFunctionPointer PFN_aux_1146;
        [VkFunctionId(1147, false)]
        public VkFunctionPointer PFN_aux_1147;
        [VkFunctionId(1148, false)]
        public VkFunctionPointer PFN_aux_1148;
        [VkFunctionId(1149, false)]
        public VkFunctionPointer PFN_aux_1149;
        [VkFunctionId(1150, false)]
        public VkFunctionPointer PFN_aux_1150;
        [VkFunctionId(1151, false)]
        public VkFunctionPointer PFN_aux_1151;
        [VkFunctionId(1152, false)]
        public VkFunctionPointer PFN_aux_1152;
        [VkFunctionId(1153, false)]
        public VkFunctionPointer PFN_aux_1153;
        [VkFunctionId(1154, false)]
        public VkFunctionPointer PFN_aux_1154;
        [VkFunctionId(1155, false)]
        public VkFunctionPointer PFN_aux_1155;
        [VkFunctionId(1156, false)]
        public VkFunctionPointer PFN_aux_1156;
        [VkFunctionId(1157, false)]
        public VkFunctionPointer PFN_aux_1157;
        [VkFunctionId(1158, false)]
        public VkFunctionPointer PFN_aux_1158;
        [VkFunctionId(1159, false)]
        public VkFunctionPointer PFN_aux_1159;
        [VkFunctionId(1160, false)]
        public VkFunctionPointer PFN_aux_1160;
        [VkFunctionId(1161, false)]
        public VkFunctionPointer PFN_aux_1161;
        [VkFunctionId(1162, false)]
        public VkFunctionPointer PFN_aux_1162;
        [VkFunctionId(1163, false)]
        public VkFunctionPointer PFN_aux_1163;
        [VkFunctionId(1164, false)]
        public VkFunctionPointer PFN_aux_1164;
        [VkFunctionId(1165, false)]
        public VkFunctionPointer PFN_aux_1165;
        [VkFunctionId(1166, false)]
        public VkFunctionPointer PFN_aux_1166;
        [VkFunctionId(1167, false)]
        public VkFunctionPointer PFN_aux_1167;
        [VkFunctionId(1168, false)]
        public VkFunctionPointer PFN_aux_1168;
        [VkFunctionId(1169, false)]
        public VkFunctionPointer PFN_aux_1169;
        [VkFunctionId(1170, false)]
        public VkFunctionPointer PFN_aux_1170;
        [VkFunctionId(1171, false)]
        public VkFunctionPointer PFN_aux_1171;
        [VkFunctionId(1172, false)]
        public VkFunctionPointer PFN_aux_1172;
        [VkFunctionId(1173, false)]
        public VkFunctionPointer PFN_aux_1173;
        [VkFunctionId(1174, false)]
        public VkFunctionPointer PFN_aux_1174;
        [VkFunctionId(1175, false)]
        public VkFunctionPointer PFN_aux_1175;
        [VkFunctionId(1176, false)]
        public VkFunctionPointer PFN_aux_1176;
        [VkFunctionId(1177, false)]
        public VkFunctionPointer PFN_aux_1177;
        [VkFunctionId(1178, false)]
        public VkFunctionPointer PFN_aux_1178;
        [VkFunctionId(1179, false)]
        public VkFunctionPointer PFN_aux_1179;
        [VkFunctionId(1180, false)]
        public VkFunctionPointer PFN_aux_1180;
        [VkFunctionId(1181, false)]
        public VkFunctionPointer PFN_aux_1181;
        [VkFunctionId(1182, false)]
        public VkFunctionPointer PFN_aux_1182;
        [VkFunctionId(1183, false)]
        public VkFunctionPointer PFN_aux_1183;
        [VkFunctionId(1184, false)]
        public VkFunctionPointer PFN_aux_1184;
        [VkFunctionId(1185, false)]
        public VkFunctionPointer PFN_aux_1185;
        [VkFunctionId(1186, false)]
        public VkFunctionPointer PFN_aux_1186;
        [VkFunctionId(1187, false)]
        public VkFunctionPointer PFN_aux_1187;
        [VkFunctionId(1188, false)]
        public VkFunctionPointer PFN_aux_1188;
        [VkFunctionId(1189, false)]
        public VkFunctionPointer PFN_aux_1189;
        [VkFunctionId(1190, false)]
        public VkFunctionPointer PFN_aux_1190;
        [VkFunctionId(1191, false)]
        public VkFunctionPointer PFN_aux_1191;
        [VkFunctionId(1192, false)]
        public VkFunctionPointer PFN_aux_1192;
        [VkFunctionId(1193, false)]
        public VkFunctionPointer PFN_aux_1193;
        [VkFunctionId(1194, false)]
        public VkFunctionPointer PFN_aux_1194;
        [VkFunctionId(1195, false)]
        public VkFunctionPointer PFN_aux_1195;
        [VkFunctionId(1196, false)]
        public VkFunctionPointer PFN_aux_1196;
        [VkFunctionId(1197, false)]
        public VkFunctionPointer PFN_aux_1197;
        [VkFunctionId(1198, false)]
        public VkFunctionPointer PFN_aux_1198;
        [VkFunctionId(1199, false)]
        public VkFunctionPointer PFN_aux_1199;
        [VkFunctionId(1200, false)]
        public VkFunctionPointer PFN_aux_1200;
        [VkFunctionId(1201, false)]
        public VkFunctionPointer PFN_aux_1201;
        [VkFunctionId(1202, false)]
        public VkFunctionPointer PFN_aux_1202;
        [VkFunctionId(1203, false)]
        public VkFunctionPointer PFN_aux_1203;
        [VkFunctionId(1204, false)]
        public VkFunctionPointer PFN_aux_1204;
        [VkFunctionId(1205, false)]
        public VkFunctionPointer PFN_aux_1205;
        [VkFunctionId(1206, false)]
        public VkFunctionPointer PFN_aux_1206;
        [VkFunctionId(1207, false)]
        public VkFunctionPointer PFN_aux_1207;
        [VkFunctionId(1208, false)]
        public VkFunctionPointer PFN_aux_1208;
        [VkFunctionId(1209, false)]
        public VkFunctionPointer PFN_aux_1209;
        [VkFunctionId(1210, false)]
        public VkFunctionPointer PFN_aux_1210;
        [VkFunctionId(1211, false)]
        public VkFunctionPointer PFN_aux_1211;
        [VkFunctionId(1212, false)]
        public VkFunctionPointer PFN_aux_1212;
        [VkFunctionId(1213, false)]
        public VkFunctionPointer PFN_aux_1213;
        [VkFunctionId(1214, false)]
        public VkFunctionPointer PFN_aux_1214;
        [VkFunctionId(1215, false)]
        public VkFunctionPointer PFN_aux_1215;
        [VkFunctionId(1216, false)]
        public VkFunctionPointer PFN_aux_1216;
        [VkFunctionId(1217, false)]
        public VkFunctionPointer PFN_aux_1217;
        [VkFunctionId(1218, false)]
        public VkFunctionPointer PFN_aux_1218;
        [VkFunctionId(1219, false)]
        public VkFunctionPointer PFN_aux_1219;
        [VkFunctionId(1220, false)]
        public VkFunctionPointer PFN_aux_1220;
        [VkFunctionId(1221, false)]
        public VkFunctionPointer PFN_aux_1221;
        [VkFunctionId(1222, false)]
        public VkFunctionPointer PFN_aux_1222;
        [VkFunctionId(1223, false)]
        public VkFunctionPointer PFN_aux_1223;
        [VkFunctionId(1224, false)]
        public VkFunctionPointer PFN_aux_1224;
        [VkFunctionId(1225, false)]
        public VkFunctionPointer PFN_aux_1225;
        [VkFunctionId(1226, false)]
        public VkFunctionPointer PFN_aux_1226;
        [VkFunctionId(1227, false)]
        public VkFunctionPointer PFN_aux_1227;
        [VkFunctionId(1228, false)]
        public VkFunctionPointer PFN_aux_1228;
        [VkFunctionId(1229, false)]
        public VkFunctionPointer PFN_aux_1229;
        [VkFunctionId(1230, false)]
        public VkFunctionPointer PFN_aux_1230;
        [VkFunctionId(1231, false)]
        public VkFunctionPointer PFN_aux_1231;
        [VkFunctionId(1232, false)]
        public VkFunctionPointer PFN_aux_1232;
        [VkFunctionId(1233, false)]
        public VkFunctionPointer PFN_aux_1233;
        [VkFunctionId(1234, false)]
        public VkFunctionPointer PFN_aux_1234;
        [VkFunctionId(1235, false)]
        public VkFunctionPointer PFN_aux_1235;
        [VkFunctionId(1236, false)]
        public VkFunctionPointer PFN_aux_1236;
        [VkFunctionId(1237, false)]
        public VkFunctionPointer PFN_aux_1237;
        [VkFunctionId(1238, false)]
        public VkFunctionPointer PFN_aux_1238;
        [VkFunctionId(1239, false)]
        public VkFunctionPointer PFN_aux_1239;
        [VkFunctionId(1240, false)]
        public VkFunctionPointer PFN_aux_1240;
        [VkFunctionId(1241, false)]
        public VkFunctionPointer PFN_aux_1241;
        [VkFunctionId(1242, false)]
        public VkFunctionPointer PFN_aux_1242;
        [VkFunctionId(1243, false)]
        public VkFunctionPointer PFN_aux_1243;
        [VkFunctionId(1244, false)]
        public VkFunctionPointer PFN_aux_1244;
        [VkFunctionId(1245, false)]
        public VkFunctionPointer PFN_aux_1245;
        [VkFunctionId(1246, false)]
        public VkFunctionPointer PFN_aux_1246;
        [VkFunctionId(1247, false)]
        public VkFunctionPointer PFN_aux_1247;
        [VkFunctionId(1248, false)]
        public VkFunctionPointer PFN_aux_1248;
        [VkFunctionId(1249, false)]
        public VkFunctionPointer PFN_aux_1249;
        [VkFunctionId(1250, false)]
        public VkFunctionPointer PFN_aux_1250;
        [VkFunctionId(1251, false)]
        public VkFunctionPointer PFN_aux_1251;
        [VkFunctionId(1252, false)]
        public VkFunctionPointer PFN_aux_1252;
        [VkFunctionId(1253, false)]
        public VkFunctionPointer PFN_aux_1253;
        [VkFunctionId(1254, false)]
        public VkFunctionPointer PFN_aux_1254;
        [VkFunctionId(1255, false)]
        public VkFunctionPointer PFN_aux_1255;
        [VkFunctionId(1256, false)]
        public VkFunctionPointer PFN_aux_1256;
        [VkFunctionId(1257, false)]
        public VkFunctionPointer PFN_aux_1257;
        [VkFunctionId(1258, false)]
        public VkFunctionPointer PFN_aux_1258;
        [VkFunctionId(1259, false)]
        public VkFunctionPointer PFN_aux_1259;
        [VkFunctionId(1260, false)]
        public VkFunctionPointer PFN_aux_1260;
        [VkFunctionId(1261, false)]
        public VkFunctionPointer PFN_aux_1261;
        [VkFunctionId(1262, false)]
        public VkFunctionPointer PFN_aux_1262;
        [VkFunctionId(1263, false)]
        public VkFunctionPointer PFN_aux_1263;
        [VkFunctionId(1264, false)]
        public VkFunctionPointer PFN_aux_1264;
        [VkFunctionId(1265, false)]
        public VkFunctionPointer PFN_aux_1265;
        [VkFunctionId(1266, false)]
        public VkFunctionPointer PFN_aux_1266;
        [VkFunctionId(1267, false)]
        public VkFunctionPointer PFN_aux_1267;
        [VkFunctionId(1268, false)]
        public VkFunctionPointer PFN_aux_1268;
        [VkFunctionId(1269, false)]
        public VkFunctionPointer PFN_aux_1269;
        [VkFunctionId(1270, false)]
        public VkFunctionPointer PFN_aux_1270;
        [VkFunctionId(1271, false)]
        public VkFunctionPointer PFN_aux_1271;
        [VkFunctionId(1272, false)]
        public VkFunctionPointer PFN_aux_1272;
        [VkFunctionId(1273, false)]
        public VkFunctionPointer PFN_aux_1273;
        [VkFunctionId(1274, false)]
        public VkFunctionPointer PFN_aux_1274;
        [VkFunctionId(1275, false)]
        public VkFunctionPointer PFN_aux_1275;
        [VkFunctionId(1276, false)]
        public VkFunctionPointer PFN_aux_1276;
        [VkFunctionId(1277, false)]
        public VkFunctionPointer PFN_aux_1277;
        [VkFunctionId(1278, false)]
        public VkFunctionPointer PFN_aux_1278;
        [VkFunctionId(1279, false)]
        public VkFunctionPointer PFN_aux_1279;
        [VkFunctionId(1280, false)]
        public VkFunctionPointer PFN_aux_1280;
        [VkFunctionId(1281, false)]
        public VkFunctionPointer PFN_aux_1281;
        [VkFunctionId(1282, false)]
        public VkFunctionPointer PFN_aux_1282;
        [VkFunctionId(1283, false)]
        public VkFunctionPointer PFN_aux_1283;
        [VkFunctionId(1284, false)]
        public VkFunctionPointer PFN_aux_1284;
        [VkFunctionId(1285, false)]
        public VkFunctionPointer PFN_aux_1285;
        [VkFunctionId(1286, false)]
        public VkFunctionPointer PFN_aux_1286;
        [VkFunctionId(1287, false)]
        public VkFunctionPointer PFN_aux_1287;
        [VkFunctionId(1288, false)]
        public VkFunctionPointer PFN_aux_1288;
        [VkFunctionId(1289, false)]
        public VkFunctionPointer PFN_aux_1289;
        [VkFunctionId(1290, false)]
        public VkFunctionPointer PFN_aux_1290;
        [VkFunctionId(1291, false)]
        public VkFunctionPointer PFN_aux_1291;
        [VkFunctionId(1292, false)]
        public VkFunctionPointer PFN_aux_1292;
        [VkFunctionId(1293, false)]
        public VkFunctionPointer PFN_aux_1293;
        [VkFunctionId(1294, false)]
        public VkFunctionPointer PFN_aux_1294;
        [VkFunctionId(1295, false)]
        public VkFunctionPointer PFN_aux_1295;
        [VkFunctionId(1296, false)]
        public VkFunctionPointer PFN_aux_1296;
        [VkFunctionId(1297, false)]
        public VkFunctionPointer PFN_aux_1297;
        [VkFunctionId(1298, false)]
        public VkFunctionPointer PFN_aux_1298;
        [VkFunctionId(1299, false)]
        public VkFunctionPointer PFN_aux_1299;
        [VkFunctionId(1300, false)]
        public VkFunctionPointer PFN_aux_1300;
        [VkFunctionId(1301, false)]
        public VkFunctionPointer PFN_aux_1301;
        [VkFunctionId(1302, false)]
        public VkFunctionPointer PFN_aux_1302;
        [VkFunctionId(1303, false)]
        public VkFunctionPointer PFN_aux_1303;
        [VkFunctionId(1304, false)]
        public VkFunctionPointer PFN_aux_1304;
        [VkFunctionId(1305, false)]
        public VkFunctionPointer PFN_aux_1305;
        [VkFunctionId(1306, false)]
        public VkFunctionPointer PFN_aux_1306;
        [VkFunctionId(1307, false)]
        public VkFunctionPointer PFN_aux_1307;
        [VkFunctionId(1308, false)]
        public VkFunctionPointer PFN_aux_1308;
        [VkFunctionId(1309, false)]
        public VkFunctionPointer PFN_aux_1309;
        [VkFunctionId(1310, false)]
        public VkFunctionPointer PFN_aux_1310;
        [VkFunctionId(1311, false)]
        public VkFunctionPointer PFN_aux_1311;
        [VkFunctionId(1312, false)]
        public VkFunctionPointer PFN_aux_1312;
        [VkFunctionId(1313, false)]
        public VkFunctionPointer PFN_aux_1313;
        [VkFunctionId(1314, false)]
        public VkFunctionPointer PFN_aux_1314;
        [VkFunctionId(1315, false)]
        public VkFunctionPointer PFN_aux_1315;
        [VkFunctionId(1316, false)]
        public VkFunctionPointer PFN_aux_1316;
        [VkFunctionId(1317, false)]
        public VkFunctionPointer PFN_aux_1317;
        [VkFunctionId(1318, false)]
        public VkFunctionPointer PFN_aux_1318;
        [VkFunctionId(1319, false)]
        public VkFunctionPointer PFN_aux_1319;
        [VkFunctionId(1320, false)]
        public VkFunctionPointer PFN_aux_1320;
        [VkFunctionId(1321, false)]
        public VkFunctionPointer PFN_aux_1321;
        [VkFunctionId(1322, false)]
        public VkFunctionPointer PFN_aux_1322;
        [VkFunctionId(1323, false)]
        public VkFunctionPointer PFN_aux_1323;
        [VkFunctionId(1324, false)]
        public VkFunctionPointer PFN_aux_1324;
        [VkFunctionId(1325, false)]
        public VkFunctionPointer PFN_aux_1325;
        [VkFunctionId(1326, false)]
        public VkFunctionPointer PFN_aux_1326;
        [VkFunctionId(1327, false)]
        public VkFunctionPointer PFN_aux_1327;
        [VkFunctionId(1328, false)]
        public VkFunctionPointer PFN_aux_1328;
        [VkFunctionId(1329, false)]
        public VkFunctionPointer PFN_aux_1329;
        [VkFunctionId(1330, false)]
        public VkFunctionPointer PFN_aux_1330;
        [VkFunctionId(1331, false)]
        public VkFunctionPointer PFN_aux_1331;
        [VkFunctionId(1332, false)]
        public VkFunctionPointer PFN_aux_1332;
        [VkFunctionId(1333, false)]
        public VkFunctionPointer PFN_aux_1333;
        [VkFunctionId(1334, false)]
        public VkFunctionPointer PFN_aux_1334;
        [VkFunctionId(1335, false)]
        public VkFunctionPointer PFN_aux_1335;
        [VkFunctionId(1336, false)]
        public VkFunctionPointer PFN_aux_1336;
        [VkFunctionId(1337, false)]
        public VkFunctionPointer PFN_aux_1337;
        [VkFunctionId(1338, false)]
        public VkFunctionPointer PFN_aux_1338;
        [VkFunctionId(1339, false)]
        public VkFunctionPointer PFN_aux_1339;
        [VkFunctionId(1340, false)]
        public VkFunctionPointer PFN_aux_1340;
        [VkFunctionId(1341, false)]
        public VkFunctionPointer PFN_aux_1341;
        [VkFunctionId(1342, false)]
        public VkFunctionPointer PFN_aux_1342;
        [VkFunctionId(1343, false)]
        public VkFunctionPointer PFN_aux_1343;
        [VkFunctionId(1344, false)]
        public VkFunctionPointer PFN_aux_1344;
        [VkFunctionId(1345, false)]
        public VkFunctionPointer PFN_aux_1345;
        [VkFunctionId(1346, false)]
        public VkFunctionPointer PFN_aux_1346;
        [VkFunctionId(1347, false)]
        public VkFunctionPointer PFN_aux_1347;
        [VkFunctionId(1348, false)]
        public VkFunctionPointer PFN_aux_1348;
        [VkFunctionId(1349, false)]
        public VkFunctionPointer PFN_aux_1349;
        [VkFunctionId(1350, false)]
        public VkFunctionPointer PFN_aux_1350;
        [VkFunctionId(1351, false)]
        public VkFunctionPointer PFN_aux_1351;
        [VkFunctionId(1352, false)]
        public VkFunctionPointer PFN_aux_1352;
        [VkFunctionId(1353, false)]
        public VkFunctionPointer PFN_aux_1353;
        [VkFunctionId(1354, false)]
        public VkFunctionPointer PFN_aux_1354;
        [VkFunctionId(1355, false)]
        public VkFunctionPointer PFN_aux_1355;
        [VkFunctionId(1356, false)]
        public VkFunctionPointer PFN_aux_1356;
        [VkFunctionId(1357, false)]
        public VkFunctionPointer PFN_aux_1357;
        [VkFunctionId(1358, false)]
        public VkFunctionPointer PFN_aux_1358;
        [VkFunctionId(1359, false)]
        public VkFunctionPointer PFN_aux_1359;
        [VkFunctionId(1360, false)]
        public VkFunctionPointer PFN_aux_1360;
        [VkFunctionId(1361, false)]
        public VkFunctionPointer PFN_aux_1361;
        [VkFunctionId(1362, false)]
        public VkFunctionPointer PFN_aux_1362;
        [VkFunctionId(1363, false)]
        public VkFunctionPointer PFN_aux_1363;
        [VkFunctionId(1364, false)]
        public VkFunctionPointer PFN_aux_1364;
        [VkFunctionId(1365, false)]
        public VkFunctionPointer PFN_aux_1365;
        [VkFunctionId(1366, false)]
        public VkFunctionPointer PFN_aux_1366;
        [VkFunctionId(1367, false)]
        public VkFunctionPointer PFN_aux_1367;
        [VkFunctionId(1368, false)]
        public VkFunctionPointer PFN_aux_1368;
        [VkFunctionId(1369, false)]
        public VkFunctionPointer PFN_aux_1369;
        [VkFunctionId(1370, false)]
        public VkFunctionPointer PFN_aux_1370;
        [VkFunctionId(1371, false)]
        public VkFunctionPointer PFN_aux_1371;
        [VkFunctionId(1372, false)]
        public VkFunctionPointer PFN_aux_1372;
        [VkFunctionId(1373, false)]
        public VkFunctionPointer PFN_aux_1373;
        [VkFunctionId(1374, false)]
        public VkFunctionPointer PFN_aux_1374;
        [VkFunctionId(1375, false)]
        public VkFunctionPointer PFN_aux_1375;
        [VkFunctionId(1376, false)]
        public VkFunctionPointer PFN_aux_1376;
        [VkFunctionId(1377, false)]
        public VkFunctionPointer PFN_aux_1377;
        [VkFunctionId(1378, false)]
        public VkFunctionPointer PFN_aux_1378;
        [VkFunctionId(1379, false)]
        public VkFunctionPointer PFN_aux_1379;
        [VkFunctionId(1380, false)]
        public VkFunctionPointer PFN_aux_1380;
        [VkFunctionId(1381, false)]
        public VkFunctionPointer PFN_aux_1381;
        [VkFunctionId(1382, false)]
        public VkFunctionPointer PFN_aux_1382;
        [VkFunctionId(1383, false)]
        public VkFunctionPointer PFN_aux_1383;
        [VkFunctionId(1384, false)]
        public VkFunctionPointer PFN_aux_1384;
        [VkFunctionId(1385, false)]
        public VkFunctionPointer PFN_aux_1385;
        [VkFunctionId(1386, false)]
        public VkFunctionPointer PFN_aux_1386;
        [VkFunctionId(1387, false)]
        public VkFunctionPointer PFN_aux_1387;
        [VkFunctionId(1388, false)]
        public VkFunctionPointer PFN_aux_1388;
        [VkFunctionId(1389, false)]
        public VkFunctionPointer PFN_aux_1389;
        [VkFunctionId(1390, false)]
        public VkFunctionPointer PFN_aux_1390;
        [VkFunctionId(1391, false)]
        public VkFunctionPointer PFN_aux_1391;
        [VkFunctionId(1392, false)]
        public VkFunctionPointer PFN_aux_1392;
        [VkFunctionId(1393, false)]
        public VkFunctionPointer PFN_aux_1393;
        [VkFunctionId(1394, false)]
        public VkFunctionPointer PFN_aux_1394;
        [VkFunctionId(1395, false)]
        public VkFunctionPointer PFN_aux_1395;
        [VkFunctionId(1396, false)]
        public VkFunctionPointer PFN_aux_1396;
        [VkFunctionId(1397, false)]
        public VkFunctionPointer PFN_aux_1397;
        [VkFunctionId(1398, false)]
        public VkFunctionPointer PFN_aux_1398;
        [VkFunctionId(1399, false)]
        public VkFunctionPointer PFN_aux_1399;
        [VkFunctionId(1400, false)]
        public VkFunctionPointer PFN_aux_1400;
        [VkFunctionId(1401, false)]
        public VkFunctionPointer PFN_aux_1401;
        [VkFunctionId(1402, false)]
        public VkFunctionPointer PFN_aux_1402;
        [VkFunctionId(1403, false)]
        public VkFunctionPointer PFN_aux_1403;
        [VkFunctionId(1404, false)]
        public VkFunctionPointer PFN_aux_1404;
        [VkFunctionId(1405, false)]
        public VkFunctionPointer PFN_aux_1405;
        [VkFunctionId(1406, false)]
        public VkFunctionPointer PFN_aux_1406;
        [VkFunctionId(1407, false)]
        public VkFunctionPointer PFN_aux_1407;
        [VkFunctionId(1408, false)]
        public VkFunctionPointer PFN_aux_1408;
        [VkFunctionId(1409, false)]
        public VkFunctionPointer PFN_aux_1409;
        [VkFunctionId(1410, false)]
        public VkFunctionPointer PFN_aux_1410;
        [VkFunctionId(1411, false)]
        public VkFunctionPointer PFN_aux_1411;
        [VkFunctionId(1412, false)]
        public VkFunctionPointer PFN_aux_1412;
        [VkFunctionId(1413, false)]
        public VkFunctionPointer PFN_aux_1413;
        [VkFunctionId(1414, false)]
        public VkFunctionPointer PFN_aux_1414;
        [VkFunctionId(1415, false)]
        public VkFunctionPointer PFN_aux_1415;
        [VkFunctionId(1416, false)]
        public VkFunctionPointer PFN_aux_1416;
        [VkFunctionId(1417, false)]
        public VkFunctionPointer PFN_aux_1417;
        [VkFunctionId(1418, false)]
        public VkFunctionPointer PFN_aux_1418;
        [VkFunctionId(1419, false)]
        public VkFunctionPointer PFN_aux_1419;
        [VkFunctionId(1420, false)]
        public VkFunctionPointer PFN_aux_1420;
        [VkFunctionId(1421, false)]
        public VkFunctionPointer PFN_aux_1421;
        [VkFunctionId(1422, false)]
        public VkFunctionPointer PFN_aux_1422;
        [VkFunctionId(1423, false)]
        public VkFunctionPointer PFN_aux_1423;
        [VkFunctionId(1424, false)]
        public VkFunctionPointer PFN_aux_1424;
        [VkFunctionId(1425, false)]
        public VkFunctionPointer PFN_aux_1425;
        [VkFunctionId(1426, false)]
        public VkFunctionPointer PFN_aux_1426;
        [VkFunctionId(1427, false)]
        public VkFunctionPointer PFN_aux_1427;
        [VkFunctionId(1428, false)]
        public VkFunctionPointer PFN_aux_1428;
        [VkFunctionId(1429, false)]
        public VkFunctionPointer PFN_aux_1429;
        [VkFunctionId(1430, false)]
        public VkFunctionPointer PFN_aux_1430;
        [VkFunctionId(1431, false)]
        public VkFunctionPointer PFN_aux_1431;
        [VkFunctionId(1432, false)]
        public VkFunctionPointer PFN_aux_1432;
        [VkFunctionId(1433, false)]
        public VkFunctionPointer PFN_aux_1433;
        [VkFunctionId(1434, false)]
        public VkFunctionPointer PFN_aux_1434;
        [VkFunctionId(1435, false)]
        public VkFunctionPointer PFN_aux_1435;
        [VkFunctionId(1436, false)]
        public VkFunctionPointer PFN_aux_1436;
        [VkFunctionId(1437, false)]
        public VkFunctionPointer PFN_aux_1437;
        [VkFunctionId(1438, false)]
        public VkFunctionPointer PFN_aux_1438;
        [VkFunctionId(1439, false)]
        public VkFunctionPointer PFN_aux_1439;
        [VkFunctionId(1440, false)]
        public VkFunctionPointer PFN_aux_1440;
        [VkFunctionId(1441, false)]
        public VkFunctionPointer PFN_aux_1441;
        [VkFunctionId(1442, false)]
        public VkFunctionPointer PFN_aux_1442;
        [VkFunctionId(1443, false)]
        public VkFunctionPointer PFN_aux_1443;
        [VkFunctionId(1444, false)]
        public VkFunctionPointer PFN_aux_1444;
        [VkFunctionId(1445, false)]
        public VkFunctionPointer PFN_aux_1445;
        [VkFunctionId(1446, false)]
        public VkFunctionPointer PFN_aux_1446;
        [VkFunctionId(1447, false)]
        public VkFunctionPointer PFN_aux_1447;
        [VkFunctionId(1448, false)]
        public VkFunctionPointer PFN_aux_1448;
        [VkFunctionId(1449, false)]
        public VkFunctionPointer PFN_aux_1449;
        [VkFunctionId(1450, false)]
        public VkFunctionPointer PFN_aux_1450;
        [VkFunctionId(1451, false)]
        public VkFunctionPointer PFN_aux_1451;
        [VkFunctionId(1452, false)]
        public VkFunctionPointer PFN_aux_1452;
        [VkFunctionId(1453, false)]
        public VkFunctionPointer PFN_aux_1453;
        [VkFunctionId(1454, false)]
        public VkFunctionPointer PFN_aux_1454;
        [VkFunctionId(1455, false)]
        public VkFunctionPointer PFN_aux_1455;
        [VkFunctionId(1456, false)]
        public VkFunctionPointer PFN_aux_1456;
        [VkFunctionId(1457, false)]
        public VkFunctionPointer PFN_aux_1457;
        [VkFunctionId(1458, false)]
        public VkFunctionPointer PFN_aux_1458;
        [VkFunctionId(1459, false)]
        public VkFunctionPointer PFN_aux_1459;
        [VkFunctionId(1460, false)]
        public VkFunctionPointer PFN_aux_1460;
        [VkFunctionId(1461, false)]
        public VkFunctionPointer PFN_aux_1461;
        [VkFunctionId(1462, false)]
        public VkFunctionPointer PFN_aux_1462;
        [VkFunctionId(1463, false)]
        public VkFunctionPointer PFN_aux_1463;
        [VkFunctionId(1464, false)]
        public VkFunctionPointer PFN_aux_1464;
        [VkFunctionId(1465, false)]
        public VkFunctionPointer PFN_aux_1465;
        [VkFunctionId(1466, false)]
        public VkFunctionPointer PFN_aux_1466;
        [VkFunctionId(1467, false)]
        public VkFunctionPointer PFN_aux_1467;
        [VkFunctionId(1468, false)]
        public VkFunctionPointer PFN_aux_1468;
        [VkFunctionId(1469, false)]
        public VkFunctionPointer PFN_aux_1469;
        [VkFunctionId(1470, false)]
        public VkFunctionPointer PFN_aux_1470;
        [VkFunctionId(1471, false)]
        public VkFunctionPointer PFN_aux_1471;
        [VkFunctionId(1472, false)]
        public VkFunctionPointer PFN_aux_1472;
        [VkFunctionId(1473, false)]
        public VkFunctionPointer PFN_aux_1473;
        [VkFunctionId(1474, false)]
        public VkFunctionPointer PFN_aux_1474;
        [VkFunctionId(1475, false)]
        public VkFunctionPointer PFN_aux_1475;
        [VkFunctionId(1476, false)]
        public VkFunctionPointer PFN_aux_1476;
        [VkFunctionId(1477, false)]
        public VkFunctionPointer PFN_aux_1477;
        [VkFunctionId(1478, false)]
        public VkFunctionPointer PFN_aux_1478;
        [VkFunctionId(1479, false)]
        public VkFunctionPointer PFN_aux_1479;
        [VkFunctionId(1480, false)]
        public VkFunctionPointer PFN_aux_1480;
        [VkFunctionId(1481, false)]
        public VkFunctionPointer PFN_aux_1481;
        [VkFunctionId(1482, false)]
        public VkFunctionPointer PFN_aux_1482;
        [VkFunctionId(1483, false)]
        public VkFunctionPointer PFN_aux_1483;
        [VkFunctionId(1484, false)]
        public VkFunctionPointer PFN_aux_1484;
        [VkFunctionId(1485, false)]
        public VkFunctionPointer PFN_aux_1485;
        [VkFunctionId(1486, false)]
        public VkFunctionPointer PFN_aux_1486;
        [VkFunctionId(1487, false)]
        public VkFunctionPointer PFN_aux_1487;
        [VkFunctionId(1488, false)]
        public VkFunctionPointer PFN_aux_1488;
        [VkFunctionId(1489, false)]
        public VkFunctionPointer PFN_aux_1489;
        [VkFunctionId(1490, false)]
        public VkFunctionPointer PFN_aux_1490;
        [VkFunctionId(1491, false)]
        public VkFunctionPointer PFN_aux_1491;
        [VkFunctionId(1492, false)]
        public VkFunctionPointer PFN_aux_1492;
        [VkFunctionId(1493, false)]
        public VkFunctionPointer PFN_aux_1493;
        [VkFunctionId(1494, false)]
        public VkFunctionPointer PFN_aux_1494;
        [VkFunctionId(1495, false)]
        public VkFunctionPointer PFN_aux_1495;
        [VkFunctionId(1496, false)]
        public VkFunctionPointer PFN_aux_1496;
        [VkFunctionId(1497, false)]
        public VkFunctionPointer PFN_aux_1497;
        [VkFunctionId(1498, false)]
        public VkFunctionPointer PFN_aux_1498;
        [VkFunctionId(1499, false)]
        public VkFunctionPointer PFN_aux_1499;
        [VkFunctionId(1500, false)]
        public VkFunctionPointer PFN_aux_1500;
        [VkFunctionId(1501, false)]
        public VkFunctionPointer PFN_aux_1501;
        [VkFunctionId(1502, false)]
        public VkFunctionPointer PFN_aux_1502;
        [VkFunctionId(1503, false)]
        public VkFunctionPointer PFN_aux_1503;
        [VkFunctionId(1504, false)]
        public VkFunctionPointer PFN_aux_1504;
        [VkFunctionId(1505, false)]
        public VkFunctionPointer PFN_aux_1505;
        [VkFunctionId(1506, false)]
        public VkFunctionPointer PFN_aux_1506;
        [VkFunctionId(1507, false)]
        public VkFunctionPointer PFN_aux_1507;
        [VkFunctionId(1508, false)]
        public VkFunctionPointer PFN_aux_1508;
        [VkFunctionId(1509, false)]
        public VkFunctionPointer PFN_aux_1509;
        [VkFunctionId(1510, false)]
        public VkFunctionPointer PFN_aux_1510;
        [VkFunctionId(1511, false)]
        public VkFunctionPointer PFN_aux_1511;
        [VkFunctionId(1512, false)]
        public VkFunctionPointer PFN_aux_1512;
        [VkFunctionId(1513, false)]
        public VkFunctionPointer PFN_aux_1513;
        [VkFunctionId(1514, false)]
        public VkFunctionPointer PFN_aux_1514;
        [VkFunctionId(1515, false)]
        public VkFunctionPointer PFN_aux_1515;
        [VkFunctionId(1516, false)]
        public VkFunctionPointer PFN_aux_1516;
        [VkFunctionId(1517, false)]
        public VkFunctionPointer PFN_aux_1517;
        [VkFunctionId(1518, false)]
        public VkFunctionPointer PFN_aux_1518;
        [VkFunctionId(1519, false)]
        public VkFunctionPointer PFN_aux_1519;
        [VkFunctionId(1520, false)]
        public VkFunctionPointer PFN_aux_1520;
        [VkFunctionId(1521, false)]
        public VkFunctionPointer PFN_aux_1521;
        [VkFunctionId(1522, false)]
        public VkFunctionPointer PFN_aux_1522;
        [VkFunctionId(1523, false)]
        public VkFunctionPointer PFN_aux_1523;
        [VkFunctionId(1524, false)]
        public VkFunctionPointer PFN_aux_1524;
        [VkFunctionId(1525, false)]
        public VkFunctionPointer PFN_aux_1525;
        [VkFunctionId(1526, false)]
        public VkFunctionPointer PFN_aux_1526;
        [VkFunctionId(1527, false)]
        public VkFunctionPointer PFN_aux_1527;
        [VkFunctionId(1528, false)]
        public VkFunctionPointer PFN_aux_1528;
        [VkFunctionId(1529, false)]
        public VkFunctionPointer PFN_aux_1529;
        [VkFunctionId(1530, false)]
        public VkFunctionPointer PFN_aux_1530;
        [VkFunctionId(1531, false)]
        public VkFunctionPointer PFN_aux_1531;
        [VkFunctionId(1532, false)]
        public VkFunctionPointer PFN_aux_1532;
        [VkFunctionId(1533, false)]
        public VkFunctionPointer PFN_aux_1533;
        [VkFunctionId(1534, false)]
        public VkFunctionPointer PFN_aux_1534;
        [VkFunctionId(1535, false)]
        public VkFunctionPointer PFN_aux_1535;
        [VkFunctionId(1536, false)]
        public VkFunctionPointer PFN_aux_1536;
        [VkFunctionId(1537, false)]
        public VkFunctionPointer PFN_aux_1537;
        [VkFunctionId(1538, false)]
        public VkFunctionPointer PFN_aux_1538;
        [VkFunctionId(1539, false)]
        public VkFunctionPointer PFN_aux_1539;
        [VkFunctionId(1540, false)]
        public VkFunctionPointer PFN_aux_1540;
        [VkFunctionId(1541, false)]
        public VkFunctionPointer PFN_aux_1541;
        [VkFunctionId(1542, false)]
        public VkFunctionPointer PFN_aux_1542;
        [VkFunctionId(1543, false)]
        public VkFunctionPointer PFN_aux_1543;
        [VkFunctionId(1544, false)]
        public VkFunctionPointer PFN_aux_1544;
        [VkFunctionId(1545, false)]
        public VkFunctionPointer PFN_aux_1545;
        [VkFunctionId(1546, false)]
        public VkFunctionPointer PFN_aux_1546;
        [VkFunctionId(1547, false)]
        public VkFunctionPointer PFN_aux_1547;
        [VkFunctionId(1548, false)]
        public VkFunctionPointer PFN_aux_1548;
        [VkFunctionId(1549, false)]
        public VkFunctionPointer PFN_aux_1549;
        [VkFunctionId(1550, false)]
        public VkFunctionPointer PFN_aux_1550;
        [VkFunctionId(1551, false)]
        public VkFunctionPointer PFN_aux_1551;
        [VkFunctionId(1552, false)]
        public VkFunctionPointer PFN_aux_1552;
        [VkFunctionId(1553, false)]
        public VkFunctionPointer PFN_aux_1553;
        [VkFunctionId(1554, false)]
        public VkFunctionPointer PFN_aux_1554;
        [VkFunctionId(1555, false)]
        public VkFunctionPointer PFN_aux_1555;
        [VkFunctionId(1556, false)]
        public VkFunctionPointer PFN_aux_1556;
        [VkFunctionId(1557, false)]
        public VkFunctionPointer PFN_aux_1557;
        [VkFunctionId(1558, false)]
        public VkFunctionPointer PFN_aux_1558;
        [VkFunctionId(1559, false)]
        public VkFunctionPointer PFN_aux_1559;
        [VkFunctionId(1560, false)]
        public VkFunctionPointer PFN_aux_1560;
        [VkFunctionId(1561, false)]
        public VkFunctionPointer PFN_aux_1561;
        [VkFunctionId(1562, false)]
        public VkFunctionPointer PFN_aux_1562;
        [VkFunctionId(1563, false)]
        public VkFunctionPointer PFN_aux_1563;
        [VkFunctionId(1564, false)]
        public VkFunctionPointer PFN_aux_1564;
        [VkFunctionId(1565, false)]
        public VkFunctionPointer PFN_aux_1565;
        [VkFunctionId(1566, false)]
        public VkFunctionPointer PFN_aux_1566;
        [VkFunctionId(1567, false)]
        public VkFunctionPointer PFN_aux_1567;
        [VkFunctionId(1568, false)]
        public VkFunctionPointer PFN_aux_1568;
        [VkFunctionId(1569, false)]
        public VkFunctionPointer PFN_aux_1569;
        [VkFunctionId(1570, false)]
        public VkFunctionPointer PFN_aux_1570;
        [VkFunctionId(1571, false)]
        public VkFunctionPointer PFN_aux_1571;
        [VkFunctionId(1572, false)]
        public VkFunctionPointer PFN_aux_1572;
        [VkFunctionId(1573, false)]
        public VkFunctionPointer PFN_aux_1573;
        [VkFunctionId(1574, false)]
        public VkFunctionPointer PFN_aux_1574;
        [VkFunctionId(1575, false)]
        public VkFunctionPointer PFN_aux_1575;
        [VkFunctionId(1576, false)]
        public VkFunctionPointer PFN_aux_1576;
        [VkFunctionId(1577, false)]
        public VkFunctionPointer PFN_aux_1577;
        [VkFunctionId(1578, false)]
        public VkFunctionPointer PFN_aux_1578;
        [VkFunctionId(1579, false)]
        public VkFunctionPointer PFN_aux_1579;
        [VkFunctionId(1580, false)]
        public VkFunctionPointer PFN_aux_1580;
        [VkFunctionId(1581, false)]
        public VkFunctionPointer PFN_aux_1581;
        [VkFunctionId(1582, false)]
        public VkFunctionPointer PFN_aux_1582;
        [VkFunctionId(1583, false)]
        public VkFunctionPointer PFN_aux_1583;
        [VkFunctionId(1584, false)]
        public VkFunctionPointer PFN_aux_1584;
        [VkFunctionId(1585, false)]
        public VkFunctionPointer PFN_aux_1585;
        [VkFunctionId(1586, false)]
        public VkFunctionPointer PFN_aux_1586;
        [VkFunctionId(1587, false)]
        public VkFunctionPointer PFN_aux_1587;
        [VkFunctionId(1588, false)]
        public VkFunctionPointer PFN_aux_1588;
        [VkFunctionId(1589, false)]
        public VkFunctionPointer PFN_aux_1589;
        [VkFunctionId(1590, false)]
        public VkFunctionPointer PFN_aux_1590;
        [VkFunctionId(1591, false)]
        public VkFunctionPointer PFN_aux_1591;
        [VkFunctionId(1592, false)]
        public VkFunctionPointer PFN_aux_1592;
        [VkFunctionId(1593, false)]
        public VkFunctionPointer PFN_aux_1593;
        [VkFunctionId(1594, false)]
        public VkFunctionPointer PFN_aux_1594;
        [VkFunctionId(1595, false)]
        public VkFunctionPointer PFN_aux_1595;
        [VkFunctionId(1596, false)]
        public VkFunctionPointer PFN_aux_1596;
        [VkFunctionId(1597, false)]
        public VkFunctionPointer PFN_aux_1597;
        [VkFunctionId(1598, false)]
        public VkFunctionPointer PFN_aux_1598;
        [VkFunctionId(1599, false)]
        public VkFunctionPointer PFN_aux_1599;
        [VkFunctionId(1600, false)]
        public VkFunctionPointer PFN_aux_1600;
        [VkFunctionId(1601, false)]
        public VkFunctionPointer PFN_aux_1601;
        [VkFunctionId(1602, false)]
        public VkFunctionPointer PFN_aux_1602;
        [VkFunctionId(1603, false)]
        public VkFunctionPointer PFN_aux_1603;
        [VkFunctionId(1604, false)]
        public VkFunctionPointer PFN_aux_1604;
        [VkFunctionId(1605, false)]
        public VkFunctionPointer PFN_aux_1605;
        [VkFunctionId(1606, false)]
        public VkFunctionPointer PFN_aux_1606;
        [VkFunctionId(1607, false)]
        public VkFunctionPointer PFN_aux_1607;
        [VkFunctionId(1608, false)]
        public VkFunctionPointer PFN_aux_1608;
        [VkFunctionId(1609, false)]
        public VkFunctionPointer PFN_aux_1609;
        [VkFunctionId(1610, false)]
        public VkFunctionPointer PFN_aux_1610;
        [VkFunctionId(1611, false)]
        public VkFunctionPointer PFN_aux_1611;
        [VkFunctionId(1612, false)]
        public VkFunctionPointer PFN_aux_1612;
        [VkFunctionId(1613, false)]
        public VkFunctionPointer PFN_aux_1613;
        [VkFunctionId(1614, false)]
        public VkFunctionPointer PFN_aux_1614;
        [VkFunctionId(1615, false)]
        public VkFunctionPointer PFN_aux_1615;
        [VkFunctionId(1616, false)]
        public VkFunctionPointer PFN_aux_1616;
        [VkFunctionId(1617, false)]
        public VkFunctionPointer PFN_aux_1617;
        [VkFunctionId(1618, false)]
        public VkFunctionPointer PFN_aux_1618;
        [VkFunctionId(1619, false)]
        public VkFunctionPointer PFN_aux_1619;
        [VkFunctionId(1620, false)]
        public VkFunctionPointer PFN_aux_1620;
        [VkFunctionId(1621, false)]
        public VkFunctionPointer PFN_aux_1621;
        [VkFunctionId(1622, false)]
        public VkFunctionPointer PFN_aux_1622;
        [VkFunctionId(1623, false)]
        public VkFunctionPointer PFN_aux_1623;
        [VkFunctionId(1624, false)]
        public VkFunctionPointer PFN_aux_1624;
        [VkFunctionId(1625, false)]
        public VkFunctionPointer PFN_aux_1625;
        [VkFunctionId(1626, false)]
        public VkFunctionPointer PFN_aux_1626;
        [VkFunctionId(1627, false)]
        public VkFunctionPointer PFN_aux_1627;
        [VkFunctionId(1628, false)]
        public VkFunctionPointer PFN_aux_1628;
        [VkFunctionId(1629, false)]
        public VkFunctionPointer PFN_aux_1629;
        [VkFunctionId(1630, false)]
        public VkFunctionPointer PFN_aux_1630;
        [VkFunctionId(1631, false)]
        public VkFunctionPointer PFN_aux_1631;
        [VkFunctionId(1632, false)]
        public VkFunctionPointer PFN_aux_1632;
        [VkFunctionId(1633, false)]
        public VkFunctionPointer PFN_aux_1633;
        [VkFunctionId(1634, false)]
        public VkFunctionPointer PFN_aux_1634;
        [VkFunctionId(1635, false)]
        public VkFunctionPointer PFN_aux_1635;
        [VkFunctionId(1636, false)]
        public VkFunctionPointer PFN_aux_1636;
        [VkFunctionId(1637, false)]
        public VkFunctionPointer PFN_aux_1637;
        [VkFunctionId(1638, false)]
        public VkFunctionPointer PFN_aux_1638;
        [VkFunctionId(1639, false)]
        public VkFunctionPointer PFN_aux_1639;
        [VkFunctionId(1640, false)]
        public VkFunctionPointer PFN_aux_1640;
        [VkFunctionId(1641, false)]
        public VkFunctionPointer PFN_aux_1641;
        [VkFunctionId(1642, false)]
        public VkFunctionPointer PFN_aux_1642;
        [VkFunctionId(1643, false)]
        public VkFunctionPointer PFN_aux_1643;
        [VkFunctionId(1644, false)]
        public VkFunctionPointer PFN_aux_1644;
        [VkFunctionId(1645, false)]
        public VkFunctionPointer PFN_aux_1645;
        [VkFunctionId(1646, false)]
        public VkFunctionPointer PFN_aux_1646;
        [VkFunctionId(1647, false)]
        public VkFunctionPointer PFN_aux_1647;
        [VkFunctionId(1648, false)]
        public VkFunctionPointer PFN_aux_1648;
        [VkFunctionId(1649, false)]
        public VkFunctionPointer PFN_aux_1649;
        [VkFunctionId(1650, false)]
        public VkFunctionPointer PFN_aux_1650;
        [VkFunctionId(1651, false)]
        public VkFunctionPointer PFN_aux_1651;
        [VkFunctionId(1652, false)]
        public VkFunctionPointer PFN_aux_1652;
        [VkFunctionId(1653, false)]
        public VkFunctionPointer PFN_aux_1653;
        [VkFunctionId(1654, false)]
        public VkFunctionPointer PFN_aux_1654;
        [VkFunctionId(1655, false)]
        public VkFunctionPointer PFN_aux_1655;
        [VkFunctionId(1656, false)]
        public VkFunctionPointer PFN_aux_1656;
        [VkFunctionId(1657, false)]
        public VkFunctionPointer PFN_aux_1657;
        [VkFunctionId(1658, false)]
        public VkFunctionPointer PFN_aux_1658;
        [VkFunctionId(1659, false)]
        public VkFunctionPointer PFN_aux_1659;
        [VkFunctionId(1660, false)]
        public VkFunctionPointer PFN_aux_1660;
        [VkFunctionId(1661, false)]
        public VkFunctionPointer PFN_aux_1661;
        [VkFunctionId(1662, false)]
        public VkFunctionPointer PFN_aux_1662;
        [VkFunctionId(1663, false)]
        public VkFunctionPointer PFN_aux_1663;
        [VkFunctionId(1664, false)]
        public VkFunctionPointer PFN_aux_1664;
        [VkFunctionId(1665, false)]
        public VkFunctionPointer PFN_aux_1665;
        [VkFunctionId(1666, false)]
        public VkFunctionPointer PFN_aux_1666;
        [VkFunctionId(1667, false)]
        public VkFunctionPointer PFN_aux_1667;
        [VkFunctionId(1668, false)]
        public VkFunctionPointer PFN_aux_1668;
        [VkFunctionId(1669, false)]
        public VkFunctionPointer PFN_aux_1669;
        [VkFunctionId(1670, false)]
        public VkFunctionPointer PFN_aux_1670;
        [VkFunctionId(1671, false)]
        public VkFunctionPointer PFN_aux_1671;
        [VkFunctionId(1672, false)]
        public VkFunctionPointer PFN_aux_1672;
        [VkFunctionId(1673, false)]
        public VkFunctionPointer PFN_aux_1673;
        [VkFunctionId(1674, false)]
        public VkFunctionPointer PFN_aux_1674;
        [VkFunctionId(1675, false)]
        public VkFunctionPointer PFN_aux_1675;
        [VkFunctionId(1676, false)]
        public VkFunctionPointer PFN_aux_1676;
        [VkFunctionId(1677, false)]
        public VkFunctionPointer PFN_aux_1677;
        [VkFunctionId(1678, false)]
        public VkFunctionPointer PFN_aux_1678;
        [VkFunctionId(1679, false)]
        public VkFunctionPointer PFN_aux_1679;
        [VkFunctionId(1680, false)]
        public VkFunctionPointer PFN_aux_1680;
        [VkFunctionId(1681, false)]
        public VkFunctionPointer PFN_aux_1681;
        [VkFunctionId(1682, false)]
        public VkFunctionPointer PFN_aux_1682;
        [VkFunctionId(1683, false)]
        public VkFunctionPointer PFN_aux_1683;
        [VkFunctionId(1684, false)]
        public VkFunctionPointer PFN_aux_1684;
        [VkFunctionId(1685, false)]
        public VkFunctionPointer PFN_aux_1685;
        [VkFunctionId(1686, false)]
        public VkFunctionPointer PFN_aux_1686;
        [VkFunctionId(1687, false)]
        public VkFunctionPointer PFN_aux_1687;
        [VkFunctionId(1688, false)]
        public VkFunctionPointer PFN_aux_1688;
        [VkFunctionId(1689, false)]
        public VkFunctionPointer PFN_aux_1689;
        [VkFunctionId(1690, false)]
        public VkFunctionPointer PFN_aux_1690;
        [VkFunctionId(1691, false)]
        public VkFunctionPointer PFN_aux_1691;
        [VkFunctionId(1692, false)]
        public VkFunctionPointer PFN_aux_1692;
        [VkFunctionId(1693, false)]
        public VkFunctionPointer PFN_aux_1693;
        [VkFunctionId(1694, false)]
        public VkFunctionPointer PFN_aux_1694;
        [VkFunctionId(1695, false)]
        public VkFunctionPointer PFN_aux_1695;
        [VkFunctionId(1696, false)]
        public VkFunctionPointer PFN_aux_1696;
        [VkFunctionId(1697, false)]
        public VkFunctionPointer PFN_aux_1697;
        [VkFunctionId(1698, false)]
        public VkFunctionPointer PFN_aux_1698;
        [VkFunctionId(1699, false)]
        public VkFunctionPointer PFN_aux_1699;
        [VkFunctionId(1700, false)]
        public VkFunctionPointer PFN_aux_1700;
        [VkFunctionId(1701, false)]
        public VkFunctionPointer PFN_aux_1701;
        [VkFunctionId(1702, false)]
        public VkFunctionPointer PFN_aux_1702;
        [VkFunctionId(1703, false)]
        public VkFunctionPointer PFN_aux_1703;
        [VkFunctionId(1704, false)]
        public VkFunctionPointer PFN_aux_1704;
        [VkFunctionId(1705, false)]
        public VkFunctionPointer PFN_aux_1705;
        [VkFunctionId(1706, false)]
        public VkFunctionPointer PFN_aux_1706;
        [VkFunctionId(1707, false)]
        public VkFunctionPointer PFN_aux_1707;
        [VkFunctionId(1708, false)]
        public VkFunctionPointer PFN_aux_1708;
        [VkFunctionId(1709, false)]
        public VkFunctionPointer PFN_aux_1709;
        [VkFunctionId(1710, false)]
        public VkFunctionPointer PFN_aux_1710;
        [VkFunctionId(1711, false)]
        public VkFunctionPointer PFN_aux_1711;
        [VkFunctionId(1712, false)]
        public VkFunctionPointer PFN_aux_1712;
        [VkFunctionId(1713, false)]
        public VkFunctionPointer PFN_aux_1713;
        [VkFunctionId(1714, false)]
        public VkFunctionPointer PFN_aux_1714;
        [VkFunctionId(1715, false)]
        public VkFunctionPointer PFN_aux_1715;
        [VkFunctionId(1716, false)]
        public VkFunctionPointer PFN_aux_1716;
        [VkFunctionId(1717, false)]
        public VkFunctionPointer PFN_aux_1717;
        [VkFunctionId(1718, false)]
        public VkFunctionPointer PFN_aux_1718;
        [VkFunctionId(1719, false)]
        public VkFunctionPointer PFN_aux_1719;
        [VkFunctionId(1720, false)]
        public VkFunctionPointer PFN_aux_1720;
        [VkFunctionId(1721, false)]
        public VkFunctionPointer PFN_aux_1721;
        [VkFunctionId(1722, false)]
        public VkFunctionPointer PFN_aux_1722;
        [VkFunctionId(1723, false)]
        public VkFunctionPointer PFN_aux_1723;
        [VkFunctionId(1724, false)]
        public VkFunctionPointer PFN_aux_1724;
        [VkFunctionId(1725, false)]
        public VkFunctionPointer PFN_aux_1725;
        [VkFunctionId(1726, false)]
        public VkFunctionPointer PFN_aux_1726;
        [VkFunctionId(1727, false)]
        public VkFunctionPointer PFN_aux_1727;
        [VkFunctionId(1728, false)]
        public VkFunctionPointer PFN_aux_1728;
        [VkFunctionId(1729, false)]
        public VkFunctionPointer PFN_aux_1729;
        [VkFunctionId(1730, false)]
        public VkFunctionPointer PFN_aux_1730;
        [VkFunctionId(1731, false)]
        public VkFunctionPointer PFN_aux_1731;
        [VkFunctionId(1732, false)]
        public VkFunctionPointer PFN_aux_1732;
        [VkFunctionId(1733, false)]
        public VkFunctionPointer PFN_aux_1733;
        [VkFunctionId(1734, false)]
        public VkFunctionPointer PFN_aux_1734;
        [VkFunctionId(1735, false)]
        public VkFunctionPointer PFN_aux_1735;
        [VkFunctionId(1736, false)]
        public VkFunctionPointer PFN_aux_1736;
        [VkFunctionId(1737, false)]
        public VkFunctionPointer PFN_aux_1737;
        [VkFunctionId(1738, false)]
        public VkFunctionPointer PFN_aux_1738;
        [VkFunctionId(1739, false)]
        public VkFunctionPointer PFN_aux_1739;
        [VkFunctionId(1740, false)]
        public VkFunctionPointer PFN_aux_1740;
        [VkFunctionId(1741, false)]
        public VkFunctionPointer PFN_aux_1741;
        [VkFunctionId(1742, false)]
        public VkFunctionPointer PFN_aux_1742;
        [VkFunctionId(1743, false)]
        public VkFunctionPointer PFN_aux_1743;
        [VkFunctionId(1744, false)]
        public VkFunctionPointer PFN_aux_1744;
        [VkFunctionId(1745, false)]
        public VkFunctionPointer PFN_aux_1745;
        [VkFunctionId(1746, false)]
        public VkFunctionPointer PFN_aux_1746;
        [VkFunctionId(1747, false)]
        public VkFunctionPointer PFN_aux_1747;
        [VkFunctionId(1748, false)]
        public VkFunctionPointer PFN_aux_1748;
        [VkFunctionId(1749, false)]
        public VkFunctionPointer PFN_aux_1749;
        [VkFunctionId(1750, false)]
        public VkFunctionPointer PFN_aux_1750;
        [VkFunctionId(1751, false)]
        public VkFunctionPointer PFN_aux_1751;
        [VkFunctionId(1752, false)]
        public VkFunctionPointer PFN_aux_1752;
        [VkFunctionId(1753, false)]
        public VkFunctionPointer PFN_aux_1753;
        [VkFunctionId(1754, false)]
        public VkFunctionPointer PFN_aux_1754;
        [VkFunctionId(1755, false)]
        public VkFunctionPointer PFN_aux_1755;
        [VkFunctionId(1756, false)]
        public VkFunctionPointer PFN_aux_1756;
        [VkFunctionId(1757, false)]
        public VkFunctionPointer PFN_aux_1757;
        [VkFunctionId(1758, false)]
        public VkFunctionPointer PFN_aux_1758;
        [VkFunctionId(1759, false)]
        public VkFunctionPointer PFN_aux_1759;
        [VkFunctionId(1760, false)]
        public VkFunctionPointer PFN_aux_1760;
        [VkFunctionId(1761, false)]
        public VkFunctionPointer PFN_aux_1761;
        [VkFunctionId(1762, false)]
        public VkFunctionPointer PFN_aux_1762;
        [VkFunctionId(1763, false)]
        public VkFunctionPointer PFN_aux_1763;
        [VkFunctionId(1764, false)]
        public VkFunctionPointer PFN_aux_1764;
        [VkFunctionId(1765, false)]
        public VkFunctionPointer PFN_aux_1765;
        [VkFunctionId(1766, false)]
        public VkFunctionPointer PFN_aux_1766;
        [VkFunctionId(1767, false)]
        public VkFunctionPointer PFN_aux_1767;
        [VkFunctionId(1768, false)]
        public VkFunctionPointer PFN_aux_1768;
        [VkFunctionId(1769, false)]
        public VkFunctionPointer PFN_aux_1769;
        [VkFunctionId(1770, false)]
        public VkFunctionPointer PFN_aux_1770;
        [VkFunctionId(1771, false)]
        public VkFunctionPointer PFN_aux_1771;
        [VkFunctionId(1772, false)]
        public VkFunctionPointer PFN_aux_1772;
        [VkFunctionId(1773, false)]
        public VkFunctionPointer PFN_aux_1773;
        [VkFunctionId(1774, false)]
        public VkFunctionPointer PFN_aux_1774;
        [VkFunctionId(1775, false)]
        public VkFunctionPointer PFN_aux_1775;
        [VkFunctionId(1776, false)]
        public VkFunctionPointer PFN_aux_1776;
        [VkFunctionId(1777, false)]
        public VkFunctionPointer PFN_aux_1777;
        [VkFunctionId(1778, false)]
        public VkFunctionPointer PFN_aux_1778;
        [VkFunctionId(1779, false)]
        public VkFunctionPointer PFN_aux_1779;
        [VkFunctionId(1780, false)]
        public VkFunctionPointer PFN_aux_1780;
        [VkFunctionId(1781, false)]
        public VkFunctionPointer PFN_aux_1781;
        [VkFunctionId(1782, false)]
        public VkFunctionPointer PFN_aux_1782;
        [VkFunctionId(1783, false)]
        public VkFunctionPointer PFN_aux_1783;
        [VkFunctionId(1784, false)]
        public VkFunctionPointer PFN_aux_1784;
        [VkFunctionId(1785, false)]
        public VkFunctionPointer PFN_aux_1785;
        [VkFunctionId(1786, false)]
        public VkFunctionPointer PFN_aux_1786;
        [VkFunctionId(1787, false)]
        public VkFunctionPointer PFN_aux_1787;
        [VkFunctionId(1788, false)]
        public VkFunctionPointer PFN_aux_1788;
        [VkFunctionId(1789, false)]
        public VkFunctionPointer PFN_aux_1789;
        [VkFunctionId(1790, false)]
        public VkFunctionPointer PFN_aux_1790;
        [VkFunctionId(1791, false)]
        public VkFunctionPointer PFN_aux_1791;
        [VkFunctionId(1792, false)]
        public VkFunctionPointer PFN_aux_1792;
        [VkFunctionId(1793, false)]
        public VkFunctionPointer PFN_aux_1793;
        [VkFunctionId(1794, false)]
        public VkFunctionPointer PFN_aux_1794;
        [VkFunctionId(1795, false)]
        public VkFunctionPointer PFN_aux_1795;
        [VkFunctionId(1796, false)]
        public VkFunctionPointer PFN_aux_1796;
        [VkFunctionId(1797, false)]
        public VkFunctionPointer PFN_aux_1797;
        [VkFunctionId(1798, false)]
        public VkFunctionPointer PFN_aux_1798;
        [VkFunctionId(1799, false)]
        public VkFunctionPointer PFN_aux_1799;
        [VkFunctionId(1800, false)]
        public VkFunctionPointer PFN_aux_1800;
        [VkFunctionId(1801, false)]
        public VkFunctionPointer PFN_aux_1801;
        [VkFunctionId(1802, false)]
        public VkFunctionPointer PFN_aux_1802;
        [VkFunctionId(1803, false)]
        public VkFunctionPointer PFN_aux_1803;
        [VkFunctionId(1804, false)]
        public VkFunctionPointer PFN_aux_1804;
        [VkFunctionId(1805, false)]
        public VkFunctionPointer PFN_aux_1805;
        [VkFunctionId(1806, false)]
        public VkFunctionPointer PFN_aux_1806;
        [VkFunctionId(1807, false)]
        public VkFunctionPointer PFN_aux_1807;
        [VkFunctionId(1808, false)]
        public VkFunctionPointer PFN_aux_1808;
        [VkFunctionId(1809, false)]
        public VkFunctionPointer PFN_aux_1809;
        [VkFunctionId(1810, false)]
        public VkFunctionPointer PFN_aux_1810;
        [VkFunctionId(1811, false)]
        public VkFunctionPointer PFN_aux_1811;
        [VkFunctionId(1812, false)]
        public VkFunctionPointer PFN_aux_1812;
        [VkFunctionId(1813, false)]
        public VkFunctionPointer PFN_aux_1813;
        [VkFunctionId(1814, false)]
        public VkFunctionPointer PFN_aux_1814;
        [VkFunctionId(1815, false)]
        public VkFunctionPointer PFN_aux_1815;
        [VkFunctionId(1816, false)]
        public VkFunctionPointer PFN_aux_1816;
        [VkFunctionId(1817, false)]
        public VkFunctionPointer PFN_aux_1817;
        [VkFunctionId(1818, false)]
        public VkFunctionPointer PFN_aux_1818;
        [VkFunctionId(1819, false)]
        public VkFunctionPointer PFN_aux_1819;
        [VkFunctionId(1820, false)]
        public VkFunctionPointer PFN_aux_1820;
        [VkFunctionId(1821, false)]
        public VkFunctionPointer PFN_aux_1821;
        [VkFunctionId(1822, false)]
        public VkFunctionPointer PFN_aux_1822;
        [VkFunctionId(1823, false)]
        public VkFunctionPointer PFN_aux_1823;
        [VkFunctionId(1824, false)]
        public VkFunctionPointer PFN_aux_1824;
        [VkFunctionId(1825, false)]
        public VkFunctionPointer PFN_aux_1825;
        [VkFunctionId(1826, false)]
        public VkFunctionPointer PFN_aux_1826;
        [VkFunctionId(1827, false)]
        public VkFunctionPointer PFN_aux_1827;
        [VkFunctionId(1828, false)]
        public VkFunctionPointer PFN_aux_1828;
        [VkFunctionId(1829, false)]
        public VkFunctionPointer PFN_aux_1829;
        [VkFunctionId(1830, false)]
        public VkFunctionPointer PFN_aux_1830;
        [VkFunctionId(1831, false)]
        public VkFunctionPointer PFN_aux_1831;
        [VkFunctionId(1832, false)]
        public VkFunctionPointer PFN_aux_1832;
        [VkFunctionId(1833, false)]
        public VkFunctionPointer PFN_aux_1833;
        [VkFunctionId(1834, false)]
        public VkFunctionPointer PFN_aux_1834;
        [VkFunctionId(1835, false)]
        public VkFunctionPointer PFN_aux_1835;
        [VkFunctionId(1836, false)]
        public VkFunctionPointer PFN_aux_1836;
        [VkFunctionId(1837, false)]
        public VkFunctionPointer PFN_aux_1837;
        [VkFunctionId(1838, false)]
        public VkFunctionPointer PFN_aux_1838;
        [VkFunctionId(1839, false)]
        public VkFunctionPointer PFN_aux_1839;
        [VkFunctionId(1840, false)]
        public VkFunctionPointer PFN_aux_1840;
        [VkFunctionId(1841, false)]
        public VkFunctionPointer PFN_aux_1841;
        [VkFunctionId(1842, false)]
        public VkFunctionPointer PFN_aux_1842;
        [VkFunctionId(1843, false)]
        public VkFunctionPointer PFN_aux_1843;
        [VkFunctionId(1844, false)]
        public VkFunctionPointer PFN_aux_1844;
        [VkFunctionId(1845, false)]
        public VkFunctionPointer PFN_aux_1845;
        [VkFunctionId(1846, false)]
        public VkFunctionPointer PFN_aux_1846;
        [VkFunctionId(1847, false)]
        public VkFunctionPointer PFN_aux_1847;
        [VkFunctionId(1848, false)]
        public VkFunctionPointer PFN_aux_1848;
        [VkFunctionId(1849, false)]
        public VkFunctionPointer PFN_aux_1849;
        [VkFunctionId(1850, false)]
        public VkFunctionPointer PFN_aux_1850;
        [VkFunctionId(1851, false)]
        public VkFunctionPointer PFN_aux_1851;
        [VkFunctionId(1852, false)]
        public VkFunctionPointer PFN_aux_1852;
        [VkFunctionId(1853, false)]
        public VkFunctionPointer PFN_aux_1853;
        [VkFunctionId(1854, false)]
        public VkFunctionPointer PFN_aux_1854;
        [VkFunctionId(1855, false)]
        public VkFunctionPointer PFN_aux_1855;
        [VkFunctionId(1856, false)]
        public VkFunctionPointer PFN_aux_1856;
        [VkFunctionId(1857, false)]
        public VkFunctionPointer PFN_aux_1857;
        [VkFunctionId(1858, false)]
        public VkFunctionPointer PFN_aux_1858;
        [VkFunctionId(1859, false)]
        public VkFunctionPointer PFN_aux_1859;
        [VkFunctionId(1860, false)]
        public VkFunctionPointer PFN_aux_1860;
        [VkFunctionId(1861, false)]
        public VkFunctionPointer PFN_aux_1861;
        [VkFunctionId(1862, false)]
        public VkFunctionPointer PFN_aux_1862;
        [VkFunctionId(1863, false)]
        public VkFunctionPointer PFN_aux_1863;
        [VkFunctionId(1864, false)]
        public VkFunctionPointer PFN_aux_1864;
        [VkFunctionId(1865, false)]
        public VkFunctionPointer PFN_aux_1865;
        [VkFunctionId(1866, false)]
        public VkFunctionPointer PFN_aux_1866;
        [VkFunctionId(1867, false)]
        public VkFunctionPointer PFN_aux_1867;
        [VkFunctionId(1868, false)]
        public VkFunctionPointer PFN_aux_1868;
        [VkFunctionId(1869, false)]
        public VkFunctionPointer PFN_aux_1869;
        [VkFunctionId(1870, false)]
        public VkFunctionPointer PFN_aux_1870;
        [VkFunctionId(1871, false)]
        public VkFunctionPointer PFN_aux_1871;
        [VkFunctionId(1872, false)]
        public VkFunctionPointer PFN_aux_1872;
        [VkFunctionId(1873, false)]
        public VkFunctionPointer PFN_aux_1873;
        [VkFunctionId(1874, false)]
        public VkFunctionPointer PFN_aux_1874;
        [VkFunctionId(1875, false)]
        public VkFunctionPointer PFN_aux_1875;
        [VkFunctionId(1876, false)]
        public VkFunctionPointer PFN_aux_1876;
        [VkFunctionId(1877, false)]
        public VkFunctionPointer PFN_aux_1877;
        [VkFunctionId(1878, false)]
        public VkFunctionPointer PFN_aux_1878;
        [VkFunctionId(1879, false)]
        public VkFunctionPointer PFN_aux_1879;
        [VkFunctionId(1880, false)]
        public VkFunctionPointer PFN_aux_1880;
        [VkFunctionId(1881, false)]
        public VkFunctionPointer PFN_aux_1881;
        [VkFunctionId(1882, false)]
        public VkFunctionPointer PFN_aux_1882;
        [VkFunctionId(1883, false)]
        public VkFunctionPointer PFN_aux_1883;
        [VkFunctionId(1884, false)]
        public VkFunctionPointer PFN_aux_1884;
        [VkFunctionId(1885, false)]
        public VkFunctionPointer PFN_aux_1885;
        [VkFunctionId(1886, false)]
        public VkFunctionPointer PFN_aux_1886;
        [VkFunctionId(1887, false)]
        public VkFunctionPointer PFN_aux_1887;
        [VkFunctionId(1888, false)]
        public VkFunctionPointer PFN_aux_1888;
        [VkFunctionId(1889, false)]
        public VkFunctionPointer PFN_aux_1889;
        [VkFunctionId(1890, false)]
        public VkFunctionPointer PFN_aux_1890;
        [VkFunctionId(1891, false)]
        public VkFunctionPointer PFN_aux_1891;
        [VkFunctionId(1892, false)]
        public VkFunctionPointer PFN_aux_1892;
        [VkFunctionId(1893, false)]
        public VkFunctionPointer PFN_aux_1893;
        [VkFunctionId(1894, false)]
        public VkFunctionPointer PFN_aux_1894;
        [VkFunctionId(1895, false)]
        public VkFunctionPointer PFN_aux_1895;
        [VkFunctionId(1896, false)]
        public VkFunctionPointer PFN_aux_1896;
        [VkFunctionId(1897, false)]
        public VkFunctionPointer PFN_aux_1897;
        [VkFunctionId(1898, false)]
        public VkFunctionPointer PFN_aux_1898;
        [VkFunctionId(1899, false)]
        public VkFunctionPointer PFN_aux_1899;
        [VkFunctionId(1900, false)]
        public VkFunctionPointer PFN_aux_1900;
        [VkFunctionId(1901, false)]
        public VkFunctionPointer PFN_aux_1901;
        [VkFunctionId(1902, false)]
        public VkFunctionPointer PFN_aux_1902;
        [VkFunctionId(1903, false)]
        public VkFunctionPointer PFN_aux_1903;
        [VkFunctionId(1904, false)]
        public VkFunctionPointer PFN_aux_1904;
        [VkFunctionId(1905, false)]
        public VkFunctionPointer PFN_aux_1905;
        [VkFunctionId(1906, false)]
        public VkFunctionPointer PFN_aux_1906;
        [VkFunctionId(1907, false)]
        public VkFunctionPointer PFN_aux_1907;
        [VkFunctionId(1908, false)]
        public VkFunctionPointer PFN_aux_1908;
        [VkFunctionId(1909, false)]
        public VkFunctionPointer PFN_aux_1909;
        [VkFunctionId(1910, false)]
        public VkFunctionPointer PFN_aux_1910;
        [VkFunctionId(1911, false)]
        public VkFunctionPointer PFN_aux_1911;
        [VkFunctionId(1912, false)]
        public VkFunctionPointer PFN_aux_1912;
        [VkFunctionId(1913, false)]
        public VkFunctionPointer PFN_aux_1913;
        [VkFunctionId(1914, false)]
        public VkFunctionPointer PFN_aux_1914;
        [VkFunctionId(1915, false)]
        public VkFunctionPointer PFN_aux_1915;
        [VkFunctionId(1916, false)]
        public VkFunctionPointer PFN_aux_1916;
        [VkFunctionId(1917, false)]
        public VkFunctionPointer PFN_aux_1917;
        [VkFunctionId(1918, false)]
        public VkFunctionPointer PFN_aux_1918;
        [VkFunctionId(1919, false)]
        public VkFunctionPointer PFN_aux_1919;
        [VkFunctionId(1920, false)]
        public VkFunctionPointer PFN_aux_1920;
        [VkFunctionId(1921, false)]
        public VkFunctionPointer PFN_aux_1921;
        [VkFunctionId(1922, false)]
        public VkFunctionPointer PFN_aux_1922;
        [VkFunctionId(1923, false)]
        public VkFunctionPointer PFN_aux_1923;
        [VkFunctionId(1924, false)]
        public VkFunctionPointer PFN_aux_1924;
        [VkFunctionId(1925, false)]
        public VkFunctionPointer PFN_aux_1925;
        [VkFunctionId(1926, false)]
        public VkFunctionPointer PFN_aux_1926;
        [VkFunctionId(1927, false)]
        public VkFunctionPointer PFN_aux_1927;
        [VkFunctionId(1928, false)]
        public VkFunctionPointer PFN_aux_1928;
        [VkFunctionId(1929, false)]
        public VkFunctionPointer PFN_aux_1929;
        [VkFunctionId(1930, false)]
        public VkFunctionPointer PFN_aux_1930;
        [VkFunctionId(1931, false)]
        public VkFunctionPointer PFN_aux_1931;
        [VkFunctionId(1932, false)]
        public VkFunctionPointer PFN_aux_1932;
        [VkFunctionId(1933, false)]
        public VkFunctionPointer PFN_aux_1933;
        [VkFunctionId(1934, false)]
        public VkFunctionPointer PFN_aux_1934;
        [VkFunctionId(1935, false)]
        public VkFunctionPointer PFN_aux_1935;
        [VkFunctionId(1936, false)]
        public VkFunctionPointer PFN_aux_1936;
        [VkFunctionId(1937, false)]
        public VkFunctionPointer PFN_aux_1937;
        [VkFunctionId(1938, false)]
        public VkFunctionPointer PFN_aux_1938;
        [VkFunctionId(1939, false)]
        public VkFunctionPointer PFN_aux_1939;
        [VkFunctionId(1940, false)]
        public VkFunctionPointer PFN_aux_1940;
        [VkFunctionId(1941, false)]
        public VkFunctionPointer PFN_aux_1941;
        [VkFunctionId(1942, false)]
        public VkFunctionPointer PFN_aux_1942;
        [VkFunctionId(1943, false)]
        public VkFunctionPointer PFN_aux_1943;
        [VkFunctionId(1944, false)]
        public VkFunctionPointer PFN_aux_1944;
        [VkFunctionId(1945, false)]
        public VkFunctionPointer PFN_aux_1945;
        [VkFunctionId(1946, false)]
        public VkFunctionPointer PFN_aux_1946;
        [VkFunctionId(1947, false)]
        public VkFunctionPointer PFN_aux_1947;
        [VkFunctionId(1948, false)]
        public VkFunctionPointer PFN_aux_1948;
        [VkFunctionId(1949, false)]
        public VkFunctionPointer PFN_aux_1949;
        [VkFunctionId(1950, false)]
        public VkFunctionPointer PFN_aux_1950;
        [VkFunctionId(1951, false)]
        public VkFunctionPointer PFN_aux_1951;
        [VkFunctionId(1952, false)]
        public VkFunctionPointer PFN_aux_1952;
        [VkFunctionId(1953, false)]
        public VkFunctionPointer PFN_aux_1953;
        [VkFunctionId(1954, false)]
        public VkFunctionPointer PFN_aux_1954;
        [VkFunctionId(1955, false)]
        public VkFunctionPointer PFN_aux_1955;
        [VkFunctionId(1956, false)]
        public VkFunctionPointer PFN_aux_1956;
        [VkFunctionId(1957, false)]
        public VkFunctionPointer PFN_aux_1957;
        [VkFunctionId(1958, false)]
        public VkFunctionPointer PFN_aux_1958;
        [VkFunctionId(1959, false)]
        public VkFunctionPointer PFN_aux_1959;
        [VkFunctionId(1960, false)]
        public VkFunctionPointer PFN_aux_1960;
        [VkFunctionId(1961, false)]
        public VkFunctionPointer PFN_aux_1961;
        [VkFunctionId(1962, false)]
        public VkFunctionPointer PFN_aux_1962;
        [VkFunctionId(1963, false)]
        public VkFunctionPointer PFN_aux_1963;
        [VkFunctionId(1964, false)]
        public VkFunctionPointer PFN_aux_1964;
        [VkFunctionId(1965, false)]
        public VkFunctionPointer PFN_aux_1965;
        [VkFunctionId(1966, false)]
        public VkFunctionPointer PFN_aux_1966;
        [VkFunctionId(1967, false)]
        public VkFunctionPointer PFN_aux_1967;
        [VkFunctionId(1968, false)]
        public VkFunctionPointer PFN_aux_1968;
        [VkFunctionId(1969, false)]
        public VkFunctionPointer PFN_aux_1969;
        [VkFunctionId(1970, false)]
        public VkFunctionPointer PFN_aux_1970;
        [VkFunctionId(1971, false)]
        public VkFunctionPointer PFN_aux_1971;
        [VkFunctionId(1972, false)]
        public VkFunctionPointer PFN_aux_1972;
        [VkFunctionId(1973, false)]
        public VkFunctionPointer PFN_aux_1973;
        [VkFunctionId(1974, false)]
        public VkFunctionPointer PFN_aux_1974;
        [VkFunctionId(1975, false)]
        public VkFunctionPointer PFN_aux_1975;
        [VkFunctionId(1976, false)]
        public VkFunctionPointer PFN_aux_1976;
        [VkFunctionId(1977, false)]
        public VkFunctionPointer PFN_aux_1977;
        [VkFunctionId(1978, false)]
        public VkFunctionPointer PFN_aux_1978;
        [VkFunctionId(1979, false)]
        public VkFunctionPointer PFN_aux_1979;
        [VkFunctionId(1980, false)]
        public VkFunctionPointer PFN_aux_1980;
        [VkFunctionId(1981, false)]
        public VkFunctionPointer PFN_aux_1981;
        [VkFunctionId(1982, false)]
        public VkFunctionPointer PFN_aux_1982;
        [VkFunctionId(1983, false)]
        public VkFunctionPointer PFN_aux_1983;
        [VkFunctionId(1984, false)]
        public VkFunctionPointer PFN_aux_1984;
        [VkFunctionId(1985, false)]
        public VkFunctionPointer PFN_aux_1985;
        [VkFunctionId(1986, false)]
        public VkFunctionPointer PFN_aux_1986;
        [VkFunctionId(1987, false)]
        public VkFunctionPointer PFN_aux_1987;
        [VkFunctionId(1988, false)]
        public VkFunctionPointer PFN_aux_1988;
        [VkFunctionId(1989, false)]
        public VkFunctionPointer PFN_aux_1989;
        [VkFunctionId(1990, false)]
        public VkFunctionPointer PFN_aux_1990;
        [VkFunctionId(1991, false)]
        public VkFunctionPointer PFN_aux_1991;
        [VkFunctionId(1992, false)]
        public VkFunctionPointer PFN_aux_1992;
        [VkFunctionId(1993, false)]
        public VkFunctionPointer PFN_aux_1993;
        [VkFunctionId(1994, false)]
        public VkFunctionPointer PFN_aux_1994;
        [VkFunctionId(1995, false)]
        public VkFunctionPointer PFN_aux_1995;
        [VkFunctionId(1996, false)]
        public VkFunctionPointer PFN_aux_1996;
        [VkFunctionId(1997, false)]
        public VkFunctionPointer PFN_aux_1997;
        [VkFunctionId(1998, false)]
        public VkFunctionPointer PFN_aux_1998;
        [VkFunctionId(1999, false)]
        public VkFunctionPointer PFN_aux_1999;
        [VkFunctionId(2000, false)]
        public VkFunctionPointer PFN_aux_2000;
        [VkFunctionId(2001, false)]
        public VkFunctionPointer PFN_aux_2001;
        [VkFunctionId(2002, false)]
        public VkFunctionPointer PFN_aux_2002;
        [VkFunctionId(2003, false)]
        public VkFunctionPointer PFN_aux_2003;
        [VkFunctionId(2004, false)]
        public VkFunctionPointer PFN_aux_2004;
        [VkFunctionId(2005, false)]
        public VkFunctionPointer PFN_aux_2005;
        [VkFunctionId(2006, false)]
        public VkFunctionPointer PFN_aux_2006;
        [VkFunctionId(2007, false)]
        public VkFunctionPointer PFN_aux_2007;
        [VkFunctionId(2008, false)]
        public VkFunctionPointer PFN_aux_2008;
        [VkFunctionId(2009, false)]
        public VkFunctionPointer PFN_aux_2009;
        [VkFunctionId(2010, false)]
        public VkFunctionPointer PFN_aux_2010;
        [VkFunctionId(2011, false)]
        public VkFunctionPointer PFN_aux_2011;
        [VkFunctionId(2012, false)]
        public VkFunctionPointer PFN_aux_2012;
        [VkFunctionId(2013, false)]
        public VkFunctionPointer PFN_aux_2013;
        [VkFunctionId(2014, false)]
        public VkFunctionPointer PFN_aux_2014;
        [VkFunctionId(2015, false)]
        public VkFunctionPointer PFN_aux_2015;
        [VkFunctionId(2016, false)]
        public VkFunctionPointer PFN_aux_2016;
        [VkFunctionId(2017, false)]
        public VkFunctionPointer PFN_aux_2017;
        [VkFunctionId(2018, false)]
        public VkFunctionPointer PFN_aux_2018;
        [VkFunctionId(2019, false)]
        public VkFunctionPointer PFN_aux_2019;
        [VkFunctionId(2020, false)]
        public VkFunctionPointer PFN_aux_2020;
        [VkFunctionId(2021, false)]
        public VkFunctionPointer PFN_aux_2021;
        [VkFunctionId(2022, false)]
        public VkFunctionPointer PFN_aux_2022;
        [VkFunctionId(2023, false)]
        public VkFunctionPointer PFN_aux_2023;
        [VkFunctionId(2024, false)]
        public VkFunctionPointer PFN_aux_2024;
        [VkFunctionId(2025, false)]
        public VkFunctionPointer PFN_aux_2025;
        [VkFunctionId(2026, false)]
        public VkFunctionPointer PFN_aux_2026;
        [VkFunctionId(2027, false)]
        public VkFunctionPointer PFN_aux_2027;
        [VkFunctionId(2028, false)]
        public VkFunctionPointer PFN_aux_2028;
        [VkFunctionId(2029, false)]
        public VkFunctionPointer PFN_aux_2029;
        [VkFunctionId(2030, false)]
        public VkFunctionPointer PFN_aux_2030;
        [VkFunctionId(2031, false)]
        public VkFunctionPointer PFN_aux_2031;
        [VkFunctionId(2032, false)]
        public VkFunctionPointer PFN_aux_2032;
        [VkFunctionId(2033, false)]
        public VkFunctionPointer PFN_aux_2033;
        [VkFunctionId(2034, false)]
        public VkFunctionPointer PFN_aux_2034;
        [VkFunctionId(2035, false)]
        public VkFunctionPointer PFN_aux_2035;
        [VkFunctionId(2036, false)]
        public VkFunctionPointer PFN_aux_2036;
        [VkFunctionId(2037, false)]
        public VkFunctionPointer PFN_aux_2037;
        [VkFunctionId(2038, false)]
        public VkFunctionPointer PFN_aux_2038;
        [VkFunctionId(2039, false)]
        public VkFunctionPointer PFN_aux_2039;
        [VkFunctionId(2040, false)]
        public VkFunctionPointer PFN_aux_2040;
        [VkFunctionId(2041, false)]
        public VkFunctionPointer PFN_aux_2041;
        [VkFunctionId(2042, false)]
        public VkFunctionPointer PFN_aux_2042;
        [VkFunctionId(2043, false)]
        public VkFunctionPointer PFN_aux_2043;
        [VkFunctionId(2044, false)]
        public VkFunctionPointer PFN_aux_2044;
        [VkFunctionId(2045, false)]
        public VkFunctionPointer PFN_aux_2045;
        [VkFunctionId(2046, false)]
        public VkFunctionPointer PFN_aux_2046;
        [VkFunctionId(2047, false)]
        public VkFunctionPointer PFN_aux_2047;
        public const int Capacity = 2048;
        public const int FunctionCount = 623;
        public const int vkGetInstanceProcAddrId = 8;
        public const int vkGetDeviceProcAddrId = 9;
    }
}
