using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCaptureDescriptorDataInfoEXT, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCaptureDescriptorDataInfoEXT, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCaptureDescriptorDataInfoEXT, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCaptureDescriptorDataInfoEXT, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkFunctionPointer v) => new PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(void* v) => new PFN_vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkAccelerationStructureCaptureDescriptorDataInfoEXT pInfo, void* pData)
        {
            return this.ptr(device, in pInfo, pData);
        }
    }
}
