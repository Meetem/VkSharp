using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkBuildMicromapsEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBuildMicromapsEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBuildMicromapsEXT(delegate *unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint, VkMicromapBuildInfoEXT*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkBuildMicromapsEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBuildMicromapsEXT(VkFunctionPointer v) => new PFN_vkBuildMicromapsEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkBuildMicromapsEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBuildMicromapsEXT(void* v) => new PFN_vkBuildMicromapsEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeferredOperationKHR deferredOperation, uint infoCount, VkMicromapBuildInfoEXT* pInfos)
        {
            return this.ptr(device, deferredOperation, infoCount, pInfos);
        }
    }
}
