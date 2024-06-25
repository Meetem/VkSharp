using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateDebugUtilsMessengerEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, in VkDebugUtilsMessengerCreateInfoEXT, in VkAllocationCallbacks, ref VkDebugUtilsMessengerEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkDebugUtilsMessengerCreateInfoEXT, in VkAllocationCallbacks, ref VkDebugUtilsMessengerEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDebugUtilsMessengerEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkDebugUtilsMessengerCreateInfoEXT, in VkAllocationCallbacks, ref VkDebugUtilsMessengerEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDebugUtilsMessengerEXT(delegate *unmanaged[Cdecl]<VkInstance, in VkDebugUtilsMessengerCreateInfoEXT, in VkAllocationCallbacks, ref VkDebugUtilsMessengerEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateDebugUtilsMessengerEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDebugUtilsMessengerEXT(VkFunctionPointer v) => new PFN_vkCreateDebugUtilsMessengerEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateDebugUtilsMessengerEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDebugUtilsMessengerEXT(void* v) => new PFN_vkCreateDebugUtilsMessengerEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkInstance instance, in VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDebugUtilsMessengerEXT pMessenger)
        {
            return this.ptr(instance, in pCreateInfo, in pAllocator, ref pMessenger);
        }
    }
}
