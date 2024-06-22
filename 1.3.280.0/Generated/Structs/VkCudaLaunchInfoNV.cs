using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkCudaLaunchInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaFunctionNV function;
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
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_CUDA_LAUNCH_INFO_NV;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkCudaLaunchInfoNV Create()
        {
            VkCudaLaunchInfoNV ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
