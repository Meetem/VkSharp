using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkValidationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkValidationFeaturesEXT Create()
        {
            VkValidationFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
