using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueBeginDebugUtilsLabelEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueBeginDebugUtilsLabelEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueBeginDebugUtilsLabelEXT(delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueBeginDebugUtilsLabelEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueBeginDebugUtilsLabelEXT(VkFunctionPointer v) => new PFN_vkQueueBeginDebugUtilsLabelEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueBeginDebugUtilsLabelEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueBeginDebugUtilsLabelEXT(void* v) => new PFN_vkQueueBeginDebugUtilsLabelEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkQueue queue, in VkDebugUtilsLabelEXT pLabelInfo)
        {
            this.ptr(queue, in pLabelInfo);
        }
    }
}
