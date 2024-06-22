using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetInstanceProcAddr : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, byte*, VkFunctionPointer> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, byte*, VkFunctionPointer>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetInstanceProcAddr(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, byte*, VkFunctionPointer>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetInstanceProcAddr(delegate *unmanaged[Cdecl]<VkInstance, byte*, VkFunctionPointer> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetInstanceProcAddr v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetInstanceProcAddr(VkFunctionPointer v) => new PFN_vkGetInstanceProcAddr(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetInstanceProcAddr v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetInstanceProcAddr(void* v) => new PFN_vkGetInstanceProcAddr(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkFunctionPointer Call(VkInstance instance, byte* pName)
        {
            return this.ptr(instance, pName);
        }
    }
}
