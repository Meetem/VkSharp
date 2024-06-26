using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetMemoryRemoteAddressNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryGetRemoteAddressInfoNV, ref VkRemoteAddressNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryGetRemoteAddressInfoNV, ref VkRemoteAddressNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryRemoteAddressNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryGetRemoteAddressInfoNV, ref VkRemoteAddressNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryRemoteAddressNV(delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryGetRemoteAddressInfoNV, ref VkRemoteAddressNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetMemoryRemoteAddressNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryRemoteAddressNV(VkFunctionPointer v) => new PFN_vkGetMemoryRemoteAddressNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetMemoryRemoteAddressNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryRemoteAddressNV(void* v) => new PFN_vkGetMemoryRemoteAddressNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkMemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, ref VkRemoteAddressNV pAddress)
        {
            return this.ptr(device, in pMemoryGetRemoteAddressInfo, ref pAddress);
        }
    }
}
