using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateCommandPool : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCommandPoolCreateInfo, in VkAllocationCallbacks, ref VkCommandPool, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCommandPoolCreateInfo, in VkAllocationCallbacks, ref VkCommandPool, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCommandPool(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCommandPoolCreateInfo, in VkAllocationCallbacks, ref VkCommandPool, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCommandPool(delegate *unmanaged[Cdecl]<VkDevice, in VkCommandPoolCreateInfo, in VkAllocationCallbacks, ref VkCommandPool, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateCommandPool v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCommandPool(VkFunctionPointer v) => new PFN_vkCreateCommandPool(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateCommandPool v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCommandPool(void* v) => new PFN_vkCreateCommandPool(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCommandPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCommandPool pCommandPool)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pCommandPool);
        }
    }
}
