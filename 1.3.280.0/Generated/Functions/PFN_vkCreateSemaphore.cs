using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateSemaphore : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreCreateInfo, in VkAllocationCallbacks, ref VkSemaphore, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreCreateInfo, in VkAllocationCallbacks, ref VkSemaphore, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSemaphore(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreCreateInfo, in VkAllocationCallbacks, ref VkSemaphore, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateSemaphore(delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreCreateInfo, in VkAllocationCallbacks, ref VkSemaphore, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateSemaphore v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSemaphore(VkFunctionPointer v) => new PFN_vkCreateSemaphore(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateSemaphore v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateSemaphore(void* v) => new PFN_vkCreateSemaphore(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSemaphoreCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSemaphore pSemaphore)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pSemaphore);
        }
    }
}
