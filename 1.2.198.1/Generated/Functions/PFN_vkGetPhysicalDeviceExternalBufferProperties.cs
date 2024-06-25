using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceExternalBufferProperties : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalBufferProperties(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceExternalBufferProperties(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceExternalBufferProperties v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalBufferProperties(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceExternalBufferProperties(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceExternalBufferProperties v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceExternalBufferProperties(void* v) => new PFN_vkGetPhysicalDeviceExternalBufferProperties(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkPhysicalDevice physicalDevice, in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, ref VkExternalBufferProperties pExternalBufferProperties)
        {
            this.ptr(physicalDevice, in pExternalBufferInfo, ref pExternalBufferProperties);
        }
    }
}
