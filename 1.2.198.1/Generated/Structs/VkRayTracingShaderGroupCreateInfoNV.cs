using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkRayTracingShaderGroupCreateInfoNV Create()
        {
            VkRayTracingShaderGroupCreateInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
