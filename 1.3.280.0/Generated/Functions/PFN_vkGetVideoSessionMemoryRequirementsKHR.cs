using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetVideoSessionMemoryRequirementsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, ref uint, VkVideoSessionMemoryRequirementsKHR*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, ref uint, VkVideoSessionMemoryRequirementsKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetVideoSessionMemoryRequirementsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, ref uint, VkVideoSessionMemoryRequirementsKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetVideoSessionMemoryRequirementsKHR(delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, ref uint, VkVideoSessionMemoryRequirementsKHR*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetVideoSessionMemoryRequirementsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetVideoSessionMemoryRequirementsKHR(VkFunctionPointer v) => new PFN_vkGetVideoSessionMemoryRequirementsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetVideoSessionMemoryRequirementsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetVideoSessionMemoryRequirementsKHR(void* v) => new PFN_vkGetVideoSessionMemoryRequirementsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkVideoSessionKHR videoSession, ref uint pMemoryRequirementsCount, VkVideoSessionMemoryRequirementsKHR* pMemoryRequirements)
        {
            return this.ptr(device, videoSession, ref pMemoryRequirementsCount, pMemoryRequirements);
        }
    }
}
