using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceFeatures : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref VkPhysicalDeviceFeatures, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref VkPhysicalDeviceFeatures, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceFeatures(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref VkPhysicalDeviceFeatures, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceFeatures(delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref VkPhysicalDeviceFeatures, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceFeatures v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceFeatures(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceFeatures(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceFeatures v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceFeatures(void* v) => new PFN_vkGetPhysicalDeviceFeatures(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, ref VkPhysicalDeviceFeatures pFeatures)
        {
            this.ptr(physicalDevice, ref pFeatures);
        }
    }
}
