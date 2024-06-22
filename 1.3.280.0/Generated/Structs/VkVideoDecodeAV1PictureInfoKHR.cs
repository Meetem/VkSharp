using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkVideoDecodeAV1PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public StdVideoDecodeAV1PictureInfo* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[7];
        public uint frameHeaderOffset;
        public uint tileCount;
        public uint* pTileOffsets;
        public uint* pTileSizes;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkVideoDecodeAV1PictureInfoKHR Create()
        {
            VkVideoDecodeAV1PictureInfoKHR ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
