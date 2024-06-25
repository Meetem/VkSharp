using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageViewHandleNVX : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewHandleInfoNVX, uint> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewHandleInfoNVX, uint>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageViewHandleNVX(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewHandleInfoNVX, uint>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageViewHandleNVX(delegate *unmanaged[Cdecl]<VkDevice, in VkImageViewHandleInfoNVX, uint> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageViewHandleNVX v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageViewHandleNVX(VkFunctionPointer v) => new PFN_vkGetImageViewHandleNVX(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageViewHandleNVX v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageViewHandleNVX(void* v) => new PFN_vkGetImageViewHandleNVX(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Call(VkDevice device, in VkImageViewHandleInfoNVX pInfo)
        {
            return this.ptr(device, in pInfo);
        }
    }
}
