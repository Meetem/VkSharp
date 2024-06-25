using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDescriptorIndexingFeatures Create()
        {
            VkPhysicalDeviceDescriptorIndexingFeatures ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
