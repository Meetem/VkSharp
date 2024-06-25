using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceImageSparseMemoryRequirementsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirements, ref uint, VkSparseImageMemoryRequirements2*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirements, ref uint, VkSparseImageMemoryRequirements2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirements, ref uint, VkSparseImageMemoryRequirements2*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirements, ref uint, VkSparseImageMemoryRequirements2*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceImageSparseMemoryRequirementsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(VkFunctionPointer v) => new PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceImageSparseMemoryRequirementsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(void* v) => new PFN_vkGetDeviceImageSparseMemoryRequirementsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDeviceImageMemoryRequirements pInfo, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
    }
}
