using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public enum VkIndirectCommandsTokenTypeNV
    {
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = (int)(0),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = (int)(1),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = (int)(2),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = (int)(3),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = (int)(4),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = (int)(5),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = (int)(6),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = (int)(7),
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_MAX_ENUM_NV = (int)(2147483647),
    }
}
