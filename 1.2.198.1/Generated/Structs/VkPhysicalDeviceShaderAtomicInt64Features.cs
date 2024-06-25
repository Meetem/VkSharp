using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferInt64Atomics;
        public VkBool32 shaderSharedInt64Atomics;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceShaderAtomicInt64Features Create()
        {
            VkPhysicalDeviceShaderAtomicInt64Features ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
