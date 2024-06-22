using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxBlockMatchWindow;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceImageProcessing2PropertiesQCOM Create()
        {
            return default;
        }
        
    }
}
