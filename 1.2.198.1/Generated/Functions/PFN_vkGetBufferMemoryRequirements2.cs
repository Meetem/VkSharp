using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetBufferMemoryRequirements2 : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferMemoryRequirements2(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferMemoryRequirements2(delegate *unmanaged[Cdecl]<VkDevice, in VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetBufferMemoryRequirements2 v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferMemoryRequirements2(VkFunctionPointer v) => new PFN_vkGetBufferMemoryRequirements2(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetBufferMemoryRequirements2 v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferMemoryRequirements2(void* v) => new PFN_vkGetBufferMemoryRequirements2(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkBufferMemoryRequirementsInfo2 pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pMemoryRequirements);
        }
    }
}
