using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSubmitDebugUtilsMessageEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSubmitDebugUtilsMessageEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSubmitDebugUtilsMessageEXT(delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, in VkDebugUtilsMessengerCallbackDataEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSubmitDebugUtilsMessageEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSubmitDebugUtilsMessageEXT(VkFunctionPointer v) => new PFN_vkSubmitDebugUtilsMessageEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSubmitDebugUtilsMessageEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSubmitDebugUtilsMessageEXT(void* v) => new PFN_vkSubmitDebugUtilsMessageEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkInstance instance, VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, in VkDebugUtilsMessengerCallbackDataEXT pCallbackData)
        {
            this.ptr(instance, messageSeverity, messageTypes, in pCallbackData);
        }
    }
}
