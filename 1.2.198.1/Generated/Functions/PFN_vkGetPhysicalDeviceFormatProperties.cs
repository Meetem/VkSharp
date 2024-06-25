using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceFormatProperties : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, ref VkFormatProperties, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, ref VkFormatProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceFormatProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, ref VkFormatProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceFormatProperties(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, ref VkFormatProperties, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceFormatProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceFormatProperties(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceFormatProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceFormatProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceFormatProperties(void* v) => new PFN_vkGetPhysicalDeviceFormatProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, VkFormat format, ref VkFormatProperties pFormatProperties)
        {
            this.ptr(physicalDevice, format, ref pFormatProperties);
        }
    }
}
