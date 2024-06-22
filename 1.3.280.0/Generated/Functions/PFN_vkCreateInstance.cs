using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateInstance : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<in VkInstanceCreateInfo, in VkAllocationCallbacks, ref VkInstance, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<in VkInstanceCreateInfo, in VkAllocationCallbacks, ref VkInstance, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateInstance(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<in VkInstanceCreateInfo, in VkAllocationCallbacks, ref VkInstance, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateInstance(delegate *unmanaged[Cdecl]<in VkInstanceCreateInfo, in VkAllocationCallbacks, ref VkInstance, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateInstance v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateInstance(VkFunctionPointer v) => new PFN_vkCreateInstance(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateInstance v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateInstance(void* v) => new PFN_vkCreateInstance(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(in VkInstanceCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkInstance pInstance)
        {
            return this.ptr(in pCreateInfo, in pAllocator, ref pInstance);
        }
    }
}
