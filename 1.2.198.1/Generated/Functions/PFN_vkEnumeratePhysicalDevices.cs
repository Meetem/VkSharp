using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkEnumeratePhysicalDevices : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDevice*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDevice*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDevices(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDevice*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDevices(delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDevice*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkEnumeratePhysicalDevices v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDevices(VkFunctionPointer v) => new PFN_vkEnumeratePhysicalDevices(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkEnumeratePhysicalDevices v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDevices(void* v) => new PFN_vkEnumeratePhysicalDevices(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkInstance instance, ref uint pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            return this.ptr(instance, ref pPhysicalDeviceCount, pPhysicalDevices);
        }
    }
}
