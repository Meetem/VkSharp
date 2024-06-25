using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkEnumerateInstanceExtensionProperties : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<byte*, ref uint, VkExtensionProperties*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<byte*, ref uint, VkExtensionProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumerateInstanceExtensionProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<byte*, ref uint, VkExtensionProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumerateInstanceExtensionProperties(delegate *unmanaged[Cdecl]<byte*, ref uint, VkExtensionProperties*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkEnumerateInstanceExtensionProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumerateInstanceExtensionProperties(VkFunctionPointer v) => new PFN_vkEnumerateInstanceExtensionProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkEnumerateInstanceExtensionProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumerateInstanceExtensionProperties(void* v) => new PFN_vkEnumerateInstanceExtensionProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(byte* pLayerName, ref uint pPropertyCount, VkExtensionProperties* pProperties)
        {
            return this.ptr(pLayerName, ref pPropertyCount, pProperties);
        }
    }
}
