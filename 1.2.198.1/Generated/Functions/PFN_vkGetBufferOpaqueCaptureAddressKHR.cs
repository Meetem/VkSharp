using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetBufferOpaqueCaptureAddressKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferOpaqueCaptureAddressKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferOpaqueCaptureAddressKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetBufferOpaqueCaptureAddressKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferOpaqueCaptureAddressKHR(VkFunctionPointer v) => new PFN_vkGetBufferOpaqueCaptureAddressKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetBufferOpaqueCaptureAddressKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferOpaqueCaptureAddressKHR(void* v) => new PFN_vkGetBufferOpaqueCaptureAddressKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Call(VkDevice device, in VkBufferDeviceAddressInfo pInfo)
        {
            return this.ptr(device, in pInfo);
        }
    }
}
