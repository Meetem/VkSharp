using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDebugUtilsMessengerCallbackEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void*, VkBool32> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void*, VkBool32>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugUtilsMessengerCallbackEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void*, VkBool32>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDebugUtilsMessengerCallbackEXT(delegate *unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void*, VkBool32> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDebugUtilsMessengerCallbackEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugUtilsMessengerCallbackEXT(VkFunctionPointer v) => new PFN_vkDebugUtilsMessengerCallbackEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDebugUtilsMessengerCallbackEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDebugUtilsMessengerCallbackEXT(void* v) => new PFN_vkDebugUtilsMessengerCallbackEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkBool32 Call(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, in VkDebugUtilsMessengerCallbackDataEXT pCallbackData, void* pUserData)
        {
            return this.ptr(messageSeverity, messageTypes, in pCallbackData, pUserData);
        }
    }
}
