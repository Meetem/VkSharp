using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceMemoryOpaqueCaptureAddress : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceMemoryOpaqueCaptureAddressInfo, ulong> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceMemoryOpaqueCaptureAddressInfo, ulong>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceMemoryOpaqueCaptureAddress(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceMemoryOpaqueCaptureAddressInfo, ulong>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceMemoryOpaqueCaptureAddress(delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceMemoryOpaqueCaptureAddressInfo, ulong> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceMemoryOpaqueCaptureAddress v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceMemoryOpaqueCaptureAddress(VkFunctionPointer v) => new PFN_vkGetDeviceMemoryOpaqueCaptureAddress(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceMemoryOpaqueCaptureAddress v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceMemoryOpaqueCaptureAddress(void* v) => new PFN_vkGetDeviceMemoryOpaqueCaptureAddress(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Call(VkDevice device, in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo)
        {
            return this.ptr(device, in pInfo);
        }
    }
}
