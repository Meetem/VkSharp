using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkSubpassMergeStatusEXT
    {
        VK_SUBPASS_MERGE_STATUS_MERGED_EXT = (int)(0),
        VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT = (int)(1),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT = (int)(2),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT = (int)(3),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT = (int)(4),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT = (int)(5),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT = (int)(6),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT = (int)(7),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT = (int)(8),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT = (int)(9),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT = (int)(10),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT = (int)(11),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT = (int)(12),
        VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT = (int)(13),
        VK_SUBPASS_MERGE_STATUS_MAX_ENUM_EXT = (int)(2147483647),
    }
}