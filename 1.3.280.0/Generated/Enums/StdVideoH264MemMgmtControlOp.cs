using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum StdVideoH264MemMgmtControlOp
    {
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END = (int)(0),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM = (int)(1),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM = (int)(2),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM = (int)(3),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX = (int)(4),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL = (int)(5),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM = (int)(6),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID = (int)(2147483647),
        STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MAX_ENUM = (int)(2147483647),
    }
}
