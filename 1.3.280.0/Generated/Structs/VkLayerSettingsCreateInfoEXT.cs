using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkLayerSettingsCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint settingCount;
        public VkLayerSettingEXT* pSettings;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkLayerSettingsCreateInfoEXT Create()
        {
            VkLayerSettingsCreateInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
