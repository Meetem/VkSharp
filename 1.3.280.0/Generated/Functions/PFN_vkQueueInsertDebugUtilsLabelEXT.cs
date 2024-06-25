using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkQueueInsertDebugUtilsLabelEXT : IVkFuncPtr
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
        public PFN_vkQueueInsertDebugUtilsLabelEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkQueueInsertDebugUtilsLabelEXT(delegate *unmanaged[Cdecl]<VkQueue, in VkDebugUtilsLabelEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkQueueInsertDebugUtilsLabelEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueInsertDebugUtilsLabelEXT(VkFunctionPointer v) => new PFN_vkQueueInsertDebugUtilsLabelEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkQueueInsertDebugUtilsLabelEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkQueueInsertDebugUtilsLabelEXT(void* v) => new PFN_vkQueueInsertDebugUtilsLabelEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkQueue queue, in VkDebugUtilsLabelEXT pLabelInfo)
        {
            this.ptr(queue, in pLabelInfo);
        }
    }
}
