using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetMicromapBuildSizesEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkMicromapBuildInfoEXT, ref VkMicromapBuildSizesInfoEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkMicromapBuildInfoEXT, ref VkMicromapBuildSizesInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMicromapBuildSizesEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkMicromapBuildInfoEXT, ref VkMicromapBuildSizesInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMicromapBuildSizesEXT(delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureBuildTypeKHR, in VkMicromapBuildInfoEXT, ref VkMicromapBuildSizesInfoEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetMicromapBuildSizesEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMicromapBuildSizesEXT(VkFunctionPointer v) => new PFN_vkGetMicromapBuildSizesEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetMicromapBuildSizesEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMicromapBuildSizesEXT(void* v) => new PFN_vkGetMicromapBuildSizesEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkAccelerationStructureBuildTypeKHR buildType, in VkMicromapBuildInfoEXT pBuildInfo, ref VkMicromapBuildSizesInfoEXT pSizeInfo)
        {
            this.ptr(device, buildType, in pBuildInfo, ref pSizeInfo);
        }
    }
}
