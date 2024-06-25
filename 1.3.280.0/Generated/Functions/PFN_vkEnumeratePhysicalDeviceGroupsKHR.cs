using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkEnumeratePhysicalDeviceGroupsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDeviceGroupProperties*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDeviceGroupProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDeviceGroupsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDeviceGroupProperties*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkEnumeratePhysicalDeviceGroupsKHR(delegate *unmanaged[Cdecl]<VkInstance, ref uint, VkPhysicalDeviceGroupProperties*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkEnumeratePhysicalDeviceGroupsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDeviceGroupsKHR(VkFunctionPointer v) => new PFN_vkEnumeratePhysicalDeviceGroupsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkEnumeratePhysicalDeviceGroupsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkEnumeratePhysicalDeviceGroupsKHR(void* v) => new PFN_vkEnumeratePhysicalDeviceGroupsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkInstance instance, ref uint pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            return this.ptr(instance, ref pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
    }
}
