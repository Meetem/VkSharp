using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderSMBuiltinsPropertiesNV Create()
        {
            return default;
        }
        
    }
}
