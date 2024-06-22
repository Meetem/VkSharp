using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCuLaunchInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuFunctionNVX function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public ulong paramCount;
        public void** pParams;
        public ulong extraCount;
        public void** pExtras;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCuLaunchInfoNVX Create()
        {
            VkCuLaunchInfoNVX ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
