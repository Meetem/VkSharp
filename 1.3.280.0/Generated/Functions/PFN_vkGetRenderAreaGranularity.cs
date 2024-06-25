using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetRenderAreaGranularity : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRenderAreaGranularity(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRenderAreaGranularity(delegate *unmanaged[Cdecl]<VkDevice, VkRenderPass, ref VkExtent2D, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetRenderAreaGranularity v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRenderAreaGranularity(VkFunctionPointer v) => new PFN_vkGetRenderAreaGranularity(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetRenderAreaGranularity v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRenderAreaGranularity(void* v) => new PFN_vkGetRenderAreaGranularity(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkRenderPass renderPass, ref VkExtent2D pGranularity)
        {
            this.ptr(device, renderPass, ref pGranularity);
        }
    }
}
