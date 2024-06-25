using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer8BitAccess;
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        public VkBool32 storagePushConstant8;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevice8BitStorageFeatures Create()
        {
            return default;
        }
        
    }
}
