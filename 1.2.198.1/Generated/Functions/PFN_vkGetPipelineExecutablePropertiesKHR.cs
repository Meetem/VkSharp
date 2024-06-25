using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPipelineExecutablePropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineInfoKHR, ref uint, VkPipelineExecutablePropertiesKHR*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineInfoKHR, ref uint, VkPipelineExecutablePropertiesKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPipelineExecutablePropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineInfoKHR, ref uint, VkPipelineExecutablePropertiesKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPipelineExecutablePropertiesKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkPipelineInfoKHR, ref uint, VkPipelineExecutablePropertiesKHR*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPipelineExecutablePropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPipelineExecutablePropertiesKHR(VkFunctionPointer v) => new PFN_vkGetPipelineExecutablePropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPipelineExecutablePropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPipelineExecutablePropertiesKHR(void* v) => new PFN_vkGetPipelineExecutablePropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPipelineInfoKHR pPipelineInfo, ref uint pExecutableCount, VkPipelineExecutablePropertiesKHR* pProperties)
        {
            return this.ptr(device, in pPipelineInfo, ref pExecutableCount, pProperties);
        }
    }
}
