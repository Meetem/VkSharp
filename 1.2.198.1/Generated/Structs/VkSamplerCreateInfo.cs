using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkSamplerCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerCreateFlags flags;
        public VkFilter magFilter;
        public VkFilter minFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float mipLodBias;
        public VkBool32 anisotropyEnable;
        public float maxAnisotropy;
        public VkBool32 compareEnable;
        public VkCompareOp compareOp;
        public float minLod;
        public float maxLod;
        public VkBorderColor borderColor;
        public VkBool32 unnormalizedCoordinates;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkSamplerCreateInfo Create()
        {
            VkSamplerCreateInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
