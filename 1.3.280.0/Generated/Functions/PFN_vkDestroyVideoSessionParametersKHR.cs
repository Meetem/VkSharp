using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroyVideoSessionParametersKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyVideoSessionParametersKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyVideoSessionParametersKHR(delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroyVideoSessionParametersKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyVideoSessionParametersKHR(VkFunctionPointer v) => new PFN_vkDestroyVideoSessionParametersKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroyVideoSessionParametersKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyVideoSessionParametersKHR(void* v) => new PFN_vkDestroyVideoSessionParametersKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, videoSessionParameters, in pAllocator);
        }
    }
}
