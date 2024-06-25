using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateVideoSessionKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateVideoSessionKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateVideoSessionKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkVideoSessionCreateInfoKHR, in VkAllocationCallbacks, ref VkVideoSessionKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateVideoSessionKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateVideoSessionKHR(VkFunctionPointer v) => new PFN_vkCreateVideoSessionKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateVideoSessionKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateVideoSessionKHR(void* v) => new PFN_vkCreateVideoSessionKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkVideoSessionCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkVideoSessionKHR pVideoSession)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pVideoSession);
        }
    }
}
