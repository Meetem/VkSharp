using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkFunctionPointer v) => new PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(void* v) => new PFN_vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkRenderPass renderpass, ref VkExtent2D pMaxWorkgroupSize)
        {
            return this.ptr(device, renderpass, ref pMaxWorkgroupSize);
        }
    }
}
