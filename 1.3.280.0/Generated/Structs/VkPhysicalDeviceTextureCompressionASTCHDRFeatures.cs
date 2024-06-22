using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureCompressionASTC_HDR;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTextureCompressionASTCHDRFeatures Create()
        {
            return default;
        }
        
    }
}
