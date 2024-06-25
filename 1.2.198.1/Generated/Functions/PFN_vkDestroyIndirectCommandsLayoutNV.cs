using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroyIndirectCommandsLayoutNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyIndirectCommandsLayoutNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyIndirectCommandsLayoutNV(delegate *unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroyIndirectCommandsLayoutNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyIndirectCommandsLayoutNV(VkFunctionPointer v) => new PFN_vkDestroyIndirectCommandsLayoutNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroyIndirectCommandsLayoutNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyIndirectCommandsLayoutNV(void* v) => new PFN_vkDestroyIndirectCommandsLayoutNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkIndirectCommandsLayoutNV indirectCommandsLayout, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, indirectCommandsLayout, in pAllocator);
        }
    }
}
