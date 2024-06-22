using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateVideoSessionParametersKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionParametersCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionParametersKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionParametersCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionParametersKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateVideoSessionParametersKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionParametersCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionParametersKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateVideoSessionParametersKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionParametersCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionParametersKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateVideoSessionParametersKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateVideoSessionParametersKHR(VkFunctionPointer v) => new PFN_vkCreateVideoSessionParametersKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateVideoSessionParametersKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateVideoSessionParametersKHR(void* v) => new PFN_vkCreateVideoSessionParametersKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkVideoSessionParametersCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkVideoSessionParametersKHR pVideoSessionParameters)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pVideoSessionParameters);
        }
    }
}
