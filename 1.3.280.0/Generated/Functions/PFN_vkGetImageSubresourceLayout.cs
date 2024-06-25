using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageSubresourceLayout : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource, ref VkSubresourceLayout, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource, ref VkSubresourceLayout, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSubresourceLayout(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource, ref VkSubresourceLayout, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSubresourceLayout(delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource, ref VkSubresourceLayout, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageSubresourceLayout v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSubresourceLayout(VkFunctionPointer v) => new PFN_vkGetImageSubresourceLayout(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageSubresourceLayout v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSubresourceLayout(void* v) => new PFN_vkGetImageSubresourceLayout(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkImage image, in VkImageSubresource pSubresource, ref VkSubresourceLayout pLayout)
        {
            this.ptr(device, image, in pSubresource, ref pLayout);
        }
    }
}
