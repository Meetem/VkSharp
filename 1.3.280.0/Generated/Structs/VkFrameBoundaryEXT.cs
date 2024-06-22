using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkFrameBoundaryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFrameBoundaryFlagsEXT flags;
        public ulong frameID;
        public uint imageCount;
        public VkImage* pImages;
        public uint bufferCount;
        public VkBuffer* pBuffers;
        public ulong tagName;
        public ulong tagSize;
        public void* pTag;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkFrameBoundaryEXT Create()
        {
            VkFrameBoundaryEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
