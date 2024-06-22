using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkBuffer
    {
        public const bool IsDispatchable = false;
        public static VkBuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkImage
    {
        public const bool IsDispatchable = false;
        public static VkImage Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkInstance
    {
        public const bool IsDispatchable = true;
        public static VkInstance Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkPhysicalDevice
    {
        public const bool IsDispatchable = true;
        public static VkPhysicalDevice Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkDevice
    {
        public const bool IsDispatchable = true;
        public static VkDevice Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkQueue
    {
        public const bool IsDispatchable = true;
        public static VkQueue Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSemaphore
    {
        public const bool IsDispatchable = false;
        public static VkSemaphore Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkCommandBuffer
    {
        public const bool IsDispatchable = true;
        public static VkCommandBuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkFence
    {
        public const bool IsDispatchable = false;
        public static VkFence Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDeviceMemory
    {
        public const bool IsDispatchable = false;
        public static VkDeviceMemory Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkEvent
    {
        public const bool IsDispatchable = false;
        public static VkEvent Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkQueryPool
    {
        public const bool IsDispatchable = false;
        public static VkQueryPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkBufferView
    {
        public const bool IsDispatchable = false;
        public static VkBufferView Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkImageView
    {
        public const bool IsDispatchable = false;
        public static VkImageView Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkShaderModule
    {
        public const bool IsDispatchable = false;
        public static VkShaderModule Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipelineCache
    {
        public const bool IsDispatchable = false;
        public static VkPipelineCache Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipelineLayout
    {
        public const bool IsDispatchable = false;
        public static VkPipelineLayout Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipeline
    {
        public const bool IsDispatchable = false;
        public static VkPipeline Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkRenderPass
    {
        public const bool IsDispatchable = false;
        public static VkRenderPass Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorSetLayout
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorSetLayout Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSampler
    {
        public const bool IsDispatchable = false;
        public static VkSampler Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorSet
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorSet Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorPool
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkFramebuffer
    {
        public const bool IsDispatchable = false;
        public static VkFramebuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCommandPool
    {
        public const bool IsDispatchable = false;
        public static VkCommandPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSamplerYcbcrConversion
    {
        public const bool IsDispatchable = false;
        public static VkSamplerYcbcrConversion Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorUpdateTemplate
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorUpdateTemplate Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPrivateDataSlot
    {
        public const bool IsDispatchable = false;
        public static VkPrivateDataSlot Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSurfaceKHR
    {
        public const bool IsDispatchable = false;
        public static VkSurfaceKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSwapchainKHR
    {
        public const bool IsDispatchable = false;
        public static VkSwapchainKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDisplayKHR
    {
        public const bool IsDispatchable = false;
        public static VkDisplayKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDisplayModeKHR
    {
        public const bool IsDispatchable = false;
        public static VkDisplayModeKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkVideoSessionKHR
    {
        public const bool IsDispatchable = false;
        public static VkVideoSessionKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkVideoSessionParametersKHR
    {
        public const bool IsDispatchable = false;
        public static VkVideoSessionParametersKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDeferredOperationKHR
    {
        public const bool IsDispatchable = false;
        public static VkDeferredOperationKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDebugReportCallbackEXT
    {
        public const bool IsDispatchable = false;
        public static VkDebugReportCallbackEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCuModuleNVX
    {
        public const bool IsDispatchable = false;
        public static VkCuModuleNVX Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCuFunctionNVX
    {
        public const bool IsDispatchable = false;
        public static VkCuFunctionNVX Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDebugUtilsMessengerEXT
    {
        public const bool IsDispatchable = false;
        public static VkDebugUtilsMessengerEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkValidationCacheEXT
    {
        public const bool IsDispatchable = false;
        public static VkValidationCacheEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkAccelerationStructureNV
    {
        public const bool IsDispatchable = false;
        public static VkAccelerationStructureNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPerformanceConfigurationINTEL
    {
        public const bool IsDispatchable = false;
        public static VkPerformanceConfigurationINTEL Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkIndirectCommandsLayoutNV
    {
        public const bool IsDispatchable = false;
        public static VkIndirectCommandsLayoutNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCudaModuleNV
    {
        public const bool IsDispatchable = false;
        public static VkCudaModuleNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCudaFunctionNV
    {
        public const bool IsDispatchable = false;
        public static VkCudaFunctionNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkAccelerationStructureKHR
    {
        public const bool IsDispatchable = false;
        public static VkAccelerationStructureKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkMicromapEXT
    {
        public const bool IsDispatchable = false;
        public static VkMicromapEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkOpticalFlowSessionNV
    {
        public const bool IsDispatchable = false;
        public static VkOpticalFlowSessionNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkShaderEXT
    {
        public const bool IsDispatchable = false;
        public static VkShaderEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
    }
    
}
