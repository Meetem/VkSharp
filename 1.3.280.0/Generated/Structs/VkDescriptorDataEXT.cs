using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct VkDescriptorDataEXT
    {
        [FieldOffset(0)]
        public VkSampler* pSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pCombinedImageSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pInputAttachmentImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pSampledImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pStorageImage;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageBuffer;
        [FieldOffset(0)]
        public ulong accelerationStructure;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDescriptorDataEXT Create()
        {
            return default;
        }
        
    }
}
