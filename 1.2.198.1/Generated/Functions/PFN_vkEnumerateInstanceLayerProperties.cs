using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkEnumerateInstanceLayerProperties : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<ref uint, VkLayerProperties*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<ref uint, VkLayerProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumerateInstanceLayerProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<ref uint, VkLayerProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumerateInstanceLayerProperties(delegate *unmanaged[Cdecl]<ref uint, VkLayerProperties*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkEnumerateInstanceLayerProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumerateInstanceLayerProperties(VkFunctionPointer v) => new PFN_vkEnumerateInstanceLayerProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkEnumerateInstanceLayerProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumerateInstanceLayerProperties(void* v) => new PFN_vkEnumerateInstanceLayerProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(ref uint pPropertyCount, VkLayerProperties* pProperties)
        {
            return this.ptr(ref pPropertyCount, pProperties);
        }
    }
}
