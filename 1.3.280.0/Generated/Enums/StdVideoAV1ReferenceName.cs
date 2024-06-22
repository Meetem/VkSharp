using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoAV1ReferenceName
    {
        STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME = (int)(0),
        STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME = (int)(1),
        STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME = (int)(2),
        STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME = (int)(3),
        STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME = (int)(4),
        STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME = (int)(5),
        STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME = (int)(6),
        STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME = (int)(7),
        STD_VIDEO_AV1_REFERENCE_NAME_INVALID = (int)(2147483647),
        STD_VIDEO_AV1_REFERENCE_NAME_MAX_ENUM = (int)(2147483647),
    }
}
