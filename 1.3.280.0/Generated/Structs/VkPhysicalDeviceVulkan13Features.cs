using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceVulkan13Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustImageAccess;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
        public VkBool32 pipelineCreationCacheControl;
        public VkBool32 privateData;
        public VkBool32 shaderDemoteToHelperInvocation;
        public VkBool32 shaderTerminateInvocation;
        public VkBool32 subgroupSizeControl;
        public VkBool32 computeFullSubgroups;
        public VkBool32 synchronization2;
        public VkBool32 textureCompressionASTC_HDR;
        public VkBool32 shaderZeroInitializeWorkgroupMemory;
        public VkBool32 dynamicRendering;
        public VkBool32 shaderIntegerDotProduct;
        public VkBool32 maintenance4;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceVulkan13Features Create()
        {
            return default;
        }
        
    }
}
