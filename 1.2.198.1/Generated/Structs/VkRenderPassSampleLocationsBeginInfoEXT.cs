using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRenderPassSampleLocationsBeginInfoEXT Create()
        {
            VkRenderPassSampleLocationsBeginInfoEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
