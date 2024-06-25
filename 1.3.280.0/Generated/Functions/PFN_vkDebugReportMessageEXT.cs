using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDebugReportMessageEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugReportMessageEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugReportMessageEXT(delegate *unmanaged[Cdecl]<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDebugReportMessageEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugReportMessageEXT(VkFunctionPointer v) => new PFN_vkDebugReportMessageEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDebugReportMessageEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugReportMessageEXT(void* v) => new PFN_vkDebugReportMessageEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkInstance instance, VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong _object, ulong location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            this.ptr(instance, flags, objectType, _object, location, messageCode, pLayerPrefix, pMessage);
        }
    }
}
