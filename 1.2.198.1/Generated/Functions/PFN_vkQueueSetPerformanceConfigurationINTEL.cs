using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueSetPerformanceConfigurationINTEL : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueSetPerformanceConfigurationINTEL(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueSetPerformanceConfigurationINTEL(delegate *unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueSetPerformanceConfigurationINTEL v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueSetPerformanceConfigurationINTEL(VkFunctionPointer v) => new PFN_vkQueueSetPerformanceConfigurationINTEL(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueSetPerformanceConfigurationINTEL v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueSetPerformanceConfigurationINTEL(void* v) => new PFN_vkQueueSetPerformanceConfigurationINTEL(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkQueue queue, VkPerformanceConfigurationINTEL configuration)
        {
            return this.ptr(queue, configuration);
        }
    }
}
