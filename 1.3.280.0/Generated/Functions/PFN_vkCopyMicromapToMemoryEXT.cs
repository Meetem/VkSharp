using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCopyMicromapToMemoryEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMicromapToMemoryInfoEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMicromapToMemoryInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCopyMicromapToMemoryEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMicromapToMemoryInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCopyMicromapToMemoryEXT(delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, in VkCopyMicromapToMemoryInfoEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCopyMicromapToMemoryEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCopyMicromapToMemoryEXT(VkFunctionPointer v) => new PFN_vkCopyMicromapToMemoryEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCopyMicromapToMemoryEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCopyMicromapToMemoryEXT(void* v) => new PFN_vkCopyMicromapToMemoryEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeferredOperationKHR deferredOperation, in VkCopyMicromapToMemoryInfoEXT pInfo)
        {
            return this.ptr(device, deferredOperation, in pInfo);
        }
    }
}
