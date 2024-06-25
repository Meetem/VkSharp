using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateIndirectCommandsLayoutNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkIndirectCommandsLayoutCreateInfoNV, in VkAllocationCallbacks, ref VkIndirectCommandsLayoutNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkIndirectCommandsLayoutCreateInfoNV, in VkAllocationCallbacks, ref VkIndirectCommandsLayoutNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateIndirectCommandsLayoutNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkIndirectCommandsLayoutCreateInfoNV, in VkAllocationCallbacks, ref VkIndirectCommandsLayoutNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateIndirectCommandsLayoutNV(delegate *unmanaged[Cdecl]<VkDevice, in VkIndirectCommandsLayoutCreateInfoNV, in VkAllocationCallbacks, ref VkIndirectCommandsLayoutNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateIndirectCommandsLayoutNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateIndirectCommandsLayoutNV(VkFunctionPointer v) => new PFN_vkCreateIndirectCommandsLayoutNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateIndirectCommandsLayoutNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateIndirectCommandsLayoutNV(void* v) => new PFN_vkCreateIndirectCommandsLayoutNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkIndirectCommandsLayoutCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkIndirectCommandsLayoutNV pIndirectCommandsLayout)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pIndirectCommandsLayout);
        }
    }
}
