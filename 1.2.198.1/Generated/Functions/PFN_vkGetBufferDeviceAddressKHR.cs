using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetBufferDeviceAddressKHR : IVkFuncPtr
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
        public PFN_vkGetBufferDeviceAddressKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferDeviceAddressKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkBufferDeviceAddressInfo, ulong> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetBufferDeviceAddressKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferDeviceAddressKHR(VkFunctionPointer v) => new PFN_vkGetBufferDeviceAddressKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetBufferDeviceAddressKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferDeviceAddressKHR(void* v) => new PFN_vkGetBufferDeviceAddressKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Call(VkDevice device, in VkBufferDeviceAddressInfo pInfo)
        {
            return this.ptr(device, in pInfo);
        }
    }
}
