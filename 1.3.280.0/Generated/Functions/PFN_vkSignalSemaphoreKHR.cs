using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSignalSemaphoreKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreSignalInfo, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreSignalInfo, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSignalSemaphoreKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreSignalInfo, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSignalSemaphoreKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkSemaphoreSignalInfo, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSignalSemaphoreKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSignalSemaphoreKHR(VkFunctionPointer v) => new PFN_vkSignalSemaphoreKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSignalSemaphoreKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSignalSemaphoreKHR(void* v) => new PFN_vkSignalSemaphoreKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkSemaphoreSignalInfo pSignalInfo)
        {
            return this.ptr(device, in pSignalInfo);
        }
    }
}
