using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkOpticalFlowSessionCreatePrivateDataInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint id;
        public uint size;
        public void* pPrivateData;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkOpticalFlowSessionCreatePrivateDataInfoNV Create()
        {
            VkOpticalFlowSessionCreatePrivateDataInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
