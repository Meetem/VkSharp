using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceQueueShaderCoreControlCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderCoreCount;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceQueueShaderCoreControlCreateInfoARM Create()
        {
            VkDeviceQueueShaderCoreControlCreateInfoARM ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
