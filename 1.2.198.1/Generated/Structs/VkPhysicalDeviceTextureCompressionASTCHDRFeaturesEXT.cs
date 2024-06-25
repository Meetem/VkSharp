using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureCompressionASTC_HDR;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT Create()
        {
            return default;
        }
        
    }
}
