using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroyDebugUtilsMessengerEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyDebugUtilsMessengerEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyDebugUtilsMessengerEXT(delegate *unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroyDebugUtilsMessengerEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyDebugUtilsMessengerEXT(VkFunctionPointer v) => new PFN_vkDestroyDebugUtilsMessengerEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroyDebugUtilsMessengerEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyDebugUtilsMessengerEXT(void* v) => new PFN_vkDestroyDebugUtilsMessengerEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkInstance instance, VkDebugUtilsMessengerEXT messenger, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(instance, messenger, in pAllocator);
        }
    }
}
