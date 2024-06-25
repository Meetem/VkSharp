using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceQueueInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceQueueInfo2 Create()
        {
            return default;
        }
        
    }
}
