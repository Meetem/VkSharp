using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 primitiveTopologyListRestart;
        public VkBool32 primitiveTopologyPatchListRestart;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT Create()
        {
            VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
