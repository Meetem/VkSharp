using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
        public VkBool32 layeredShadingRateAttachments;
        public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D maxFragmentSize;
        public uint maxFragmentSizeAspectRatio;
        public uint maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
        public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
        public VkBool32 fragmentShadingRateWithSampleMask;
        public VkBool32 fragmentShadingRateWithShaderSampleMask;
        public VkBool32 fragmentShadingRateWithConservativeRasterization;
        public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
        public VkBool32 fragmentShadingRateWithCustomSampleLocations;
        public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceFragmentShadingRatePropertiesKHR Create()
        {
            VkPhysicalDeviceFragmentShadingRatePropertiesKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
