using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 combinedImageSamplerDescriptorSingleArray;
        public VkBool32 bufferlessPushDescriptors;
        public VkBool32 allowSamplerImageViewPostSubmitCreation;
        public ulong descriptorBufferOffsetAlignment;
        public uint maxDescriptorBufferBindings;
        public uint maxResourceDescriptorBufferBindings;
        public uint maxSamplerDescriptorBufferBindings;
        public uint maxEmbeddedImmutableSamplerBindings;
        public uint maxEmbeddedImmutableSamplers;
        public ulong bufferCaptureReplayDescriptorDataSize;
        public ulong imageCaptureReplayDescriptorDataSize;
        public ulong imageViewCaptureReplayDescriptorDataSize;
        public ulong samplerCaptureReplayDescriptorDataSize;
        public ulong accelerationStructureCaptureReplayDescriptorDataSize;
        public ulong samplerDescriptorSize;
        public ulong combinedImageSamplerDescriptorSize;
        public ulong sampledImageDescriptorSize;
        public ulong storageImageDescriptorSize;
        public ulong uniformTexelBufferDescriptorSize;
        public ulong robustUniformTexelBufferDescriptorSize;
        public ulong storageTexelBufferDescriptorSize;
        public ulong robustStorageTexelBufferDescriptorSize;
        public ulong uniformBufferDescriptorSize;
        public ulong robustUniformBufferDescriptorSize;
        public ulong storageBufferDescriptorSize;
        public ulong robustStorageBufferDescriptorSize;
        public ulong inputAttachmentDescriptorSize;
        public ulong accelerationStructureDescriptorSize;
        public ulong maxSamplerDescriptorBufferRange;
        public ulong maxResourceDescriptorBufferRange;
        public ulong samplerDescriptorBufferAddressSpaceSize;
        public ulong resourceDescriptorBufferAddressSpaceSize;
        public ulong descriptorBufferAddressSpaceSize;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceDescriptorBufferPropertiesEXT Create()
        {
            VkPhysicalDeviceDescriptorBufferPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
