using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetRenderingAreaGranularityKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingAreaInfoKHR, ref VkExtent2D, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingAreaInfoKHR, ref VkExtent2D, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRenderingAreaGranularityKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingAreaInfoKHR, ref VkExtent2D, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetRenderingAreaGranularityKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingAreaInfoKHR, ref VkExtent2D, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetRenderingAreaGranularityKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRenderingAreaGranularityKHR(VkFunctionPointer v) => new PFN_vkGetRenderingAreaGranularityKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetRenderingAreaGranularityKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetRenderingAreaGranularityKHR(void* v) => new PFN_vkGetRenderingAreaGranularityKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkRenderingAreaInfoKHR pRenderingAreaInfo, ref VkExtent2D pGranularity)
        {
            this.ptr(device, in pRenderingAreaInfo, ref pGranularity);
        }
    }
}
