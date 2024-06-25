using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceGroupSurfacePresentModesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, ref VkDeviceGroupPresentModeFlagsKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, ref VkDeviceGroupPresentModeFlagsKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupSurfacePresentModesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, ref VkDeviceGroupPresentModeFlagsKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupSurfacePresentModesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, ref VkDeviceGroupPresentModeFlagsKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceGroupSurfacePresentModesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupSurfacePresentModesKHR(VkFunctionPointer v) => new PFN_vkGetDeviceGroupSurfacePresentModesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceGroupSurfacePresentModesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupSurfacePresentModesKHR(void* v) => new PFN_vkGetDeviceGroupSurfacePresentModesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkSurfaceKHR surface, ref VkDeviceGroupPresentModeFlagsKHR pModes)
        {
            return this.ptr(device, surface, ref pModes);
        }
    }
}
