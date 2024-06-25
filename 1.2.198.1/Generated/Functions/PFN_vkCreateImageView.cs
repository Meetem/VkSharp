using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateImageView : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewCreateInfo, in VkAllocationCallbacks, ref VkImageView, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewCreateInfo, in VkAllocationCallbacks, ref VkImageView, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateImageView(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewCreateInfo, in VkAllocationCallbacks, ref VkImageView, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateImageView(delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewCreateInfo, in VkAllocationCallbacks, ref VkImageView, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateImageView v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateImageView(VkFunctionPointer v) => new PFN_vkCreateImageView(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateImageView v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateImageView(void* v) => new PFN_vkCreateImageView(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkImageViewCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkImageView pView)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pView);
        }
    }
}
