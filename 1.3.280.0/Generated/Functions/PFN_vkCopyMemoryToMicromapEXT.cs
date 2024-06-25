using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCopyMemoryToMicromapEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMemoryToMicromapInfoEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMemoryToMicromapInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCopyMemoryToMicromapEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMemoryToMicromapInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCopyMemoryToMicromapEXT(delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMemoryToMicromapInfoEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCopyMemoryToMicromapEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCopyMemoryToMicromapEXT(VkFunctionPointer v) => new PFN_vkCopyMemoryToMicromapEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCopyMemoryToMicromapEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCopyMemoryToMicromapEXT(void* v) => new PFN_vkCopyMemoryToMicromapEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeferredOperationKHR deferredOperation, in VkCopyMemoryToMicromapInfoEXT pInfo)
        {
            return this.ptr(device, deferredOperation, in pInfo);
        }
    }
}
