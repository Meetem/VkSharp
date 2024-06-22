using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetBufferMemoryRequirements : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkBuffer, ref VkMemoryRequirements, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkBuffer, ref VkMemoryRequirements, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferMemoryRequirements(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkBuffer, ref VkMemoryRequirements, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetBufferMemoryRequirements(delegate *unmanaged[Cdecl]<VkDevice, VkBuffer, ref VkMemoryRequirements, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetBufferMemoryRequirements v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferMemoryRequirements(VkFunctionPointer v) => new PFN_vkGetBufferMemoryRequirements(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetBufferMemoryRequirements v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetBufferMemoryRequirements(void* v) => new PFN_vkGetBufferMemoryRequirements(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkBuffer buffer, ref VkMemoryRequirements pMemoryRequirements)
        {
            this.ptr(device, buffer, ref pMemoryRequirements);
        }
    }
}
