using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateQueryPool : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkQueryPoolCreateInfo, in VkAllocationCallbacks, ref VkQueryPool, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkQueryPoolCreateInfo, in VkAllocationCallbacks, ref VkQueryPool, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateQueryPool(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkQueryPoolCreateInfo, in VkAllocationCallbacks, ref VkQueryPool, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateQueryPool(delegate *unmanaged[Cdecl]<VkDevice, in VkQueryPoolCreateInfo, in VkAllocationCallbacks, ref VkQueryPool, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateQueryPool v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateQueryPool(VkFunctionPointer v) => new PFN_vkCreateQueryPool(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateQueryPool v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateQueryPool(void* v) => new PFN_vkCreateQueryPool(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkQueryPoolCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkQueryPool pQueryPool)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pQueryPool);
        }
    }
}
