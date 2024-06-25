using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSetDebugUtilsObjectNameEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDebugUtilsObjectNameInfoEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDebugUtilsObjectNameInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetDebugUtilsObjectNameEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDebugUtilsObjectNameInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetDebugUtilsObjectNameEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkDebugUtilsObjectNameInfoEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSetDebugUtilsObjectNameEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetDebugUtilsObjectNameEXT(VkFunctionPointer v) => new PFN_vkSetDebugUtilsObjectNameEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSetDebugUtilsObjectNameEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetDebugUtilsObjectNameEXT(void* v) => new PFN_vkSetDebugUtilsObjectNameEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkDebugUtilsObjectNameInfoEXT pNameInfo)
        {
            return this.ptr(device, in pNameInfo);
        }
    }
}
