using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageMemoryRequirements2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageMemoryRequirements2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageMemoryRequirements2KHR(delegate *unmanaged[Cdecl]<VkDevice, in VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageMemoryRequirements2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageMemoryRequirements2KHR(VkFunctionPointer v) => new PFN_vkGetImageMemoryRequirements2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageMemoryRequirements2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageMemoryRequirements2KHR(void* v) => new PFN_vkGetImageMemoryRequirements2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkImageMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pMemoryRequirements);
        }
    }
}
