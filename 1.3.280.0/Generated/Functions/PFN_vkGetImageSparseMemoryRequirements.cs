using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageSparseMemoryRequirements : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref uint, VkSparseImageMemoryRequirements*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref uint, VkSparseImageMemoryRequirements*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSparseMemoryRequirements(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref uint, VkSparseImageMemoryRequirements*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageSparseMemoryRequirements(delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref uint, VkSparseImageMemoryRequirements*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageSparseMemoryRequirements v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSparseMemoryRequirements(VkFunctionPointer v) => new PFN_vkGetImageSparseMemoryRequirements(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageSparseMemoryRequirements v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageSparseMemoryRequirements(void* v) => new PFN_vkGetImageSparseMemoryRequirements(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkImage image, ref uint pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements)
        {
            this.ptr(device, image, ref pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }
    }
}
