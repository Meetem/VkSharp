using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDebugReportCallbackEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void*, VkBool32> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void*, VkBool32>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugReportCallbackEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void*, VkBool32>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugReportCallbackEXT(delegate *unmanaged[Cdecl]<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, ulong, int, byte*, byte*, void*, VkBool32> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDebugReportCallbackEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugReportCallbackEXT(VkFunctionPointer v) => new PFN_vkDebugReportCallbackEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDebugReportCallbackEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugReportCallbackEXT(void* v) => new PFN_vkDebugReportCallbackEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkBool32 Call(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong _object, ulong location, int messageCode, byte* pLayerPrefix, byte* pMessage, void* pUserData)
        {
            return this.ptr(flags, objectType, _object, location, messageCode, pLayerPrefix, pMessage, pUserData);
        }
    }
}
