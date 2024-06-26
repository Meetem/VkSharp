using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueNotifyOutOfBandNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, in VkOutOfBandQueueTypeInfoNV, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, in VkOutOfBandQueueTypeInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueNotifyOutOfBandNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, in VkOutOfBandQueueTypeInfoNV, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueNotifyOutOfBandNV(delegate *unmanaged[Cdecl]<VkQueue, in VkOutOfBandQueueTypeInfoNV, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueNotifyOutOfBandNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueNotifyOutOfBandNV(VkFunctionPointer v) => new PFN_vkQueueNotifyOutOfBandNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueNotifyOutOfBandNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueNotifyOutOfBandNV(void* v) => new PFN_vkQueueNotifyOutOfBandNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkQueue queue, in VkOutOfBandQueueTypeInfoNV pQueueTypeInfo)
        {
            this.ptr(queue, in pQueueTypeInfo);
        }
    }
}
