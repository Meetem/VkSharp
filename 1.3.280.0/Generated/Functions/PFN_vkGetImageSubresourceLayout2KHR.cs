using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageSubresourceLayout2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource2KHR, ref VkSubresourceLayout2KHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource2KHR, ref VkSubresourceLayout2KHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSubresourceLayout2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource2KHR, ref VkSubresourceLayout2KHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSubresourceLayout2KHR(delegate *unmanaged[Cdecl]<VkDevice, VkImage, in VkImageSubresource2KHR, ref VkSubresourceLayout2KHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageSubresourceLayout2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSubresourceLayout2KHR(VkFunctionPointer v) => new PFN_vkGetImageSubresourceLayout2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageSubresourceLayout2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSubresourceLayout2KHR(void* v) => new PFN_vkGetImageSubresourceLayout2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkImage image, in VkImageSubresource2KHR pSubresource, ref VkSubresourceLayout2KHR pLayout)
        {
            this.ptr(device, image, in pSubresource, ref pLayout);
        }
    }
}
