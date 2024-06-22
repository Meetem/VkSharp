using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageViewAddressNVX : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkImageView, ref VkImageViewAddressPropertiesNVX, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImageView, ref VkImageViewAddressPropertiesNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageViewAddressNVX(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImageView, ref VkImageViewAddressPropertiesNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageViewAddressNVX(delegate *unmanaged[Cdecl]<VkDevice, VkImageView, ref VkImageViewAddressPropertiesNVX, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageViewAddressNVX v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageViewAddressNVX(VkFunctionPointer v) => new PFN_vkGetImageViewAddressNVX(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageViewAddressNVX v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageViewAddressNVX(void* v) => new PFN_vkGetImageViewAddressNVX(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkImageView imageView, ref VkImageViewAddressPropertiesNVX pProperties)
        {
            return this.ptr(device, imageView, ref pProperties);
        }
    }
}
