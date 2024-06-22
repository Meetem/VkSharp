using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDeviceMemoryReportCallbackEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<in VkDeviceMemoryReportCallbackDataEXT, void*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<in VkDeviceMemoryReportCallbackDataEXT, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDeviceMemoryReportCallbackEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<in VkDeviceMemoryReportCallbackDataEXT, void*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDeviceMemoryReportCallbackEXT(delegate *unmanaged[Cdecl]<in VkDeviceMemoryReportCallbackDataEXT, void*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDeviceMemoryReportCallbackEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDeviceMemoryReportCallbackEXT(VkFunctionPointer v) => new PFN_vkDeviceMemoryReportCallbackEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDeviceMemoryReportCallbackEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDeviceMemoryReportCallbackEXT(void* v) => new PFN_vkDeviceMemoryReportCallbackEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(in VkDeviceMemoryReportCallbackDataEXT pCallbackData, void* pUserData)
        {
            this.ptr(in pCallbackData, pUserData);
        }
    }
}
