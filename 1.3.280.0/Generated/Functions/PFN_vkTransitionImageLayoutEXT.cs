using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkTransitionImageLayoutEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkTransitionImageLayoutEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkTransitionImageLayoutEXT(delegate *unmanaged[Cdecl]<VkDevice, uint, VkHostImageLayoutTransitionInfoEXT*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkTransitionImageLayoutEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkTransitionImageLayoutEXT(VkFunctionPointer v) => new PFN_vkTransitionImageLayoutEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkTransitionImageLayoutEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkTransitionImageLayoutEXT(void* v) => new PFN_vkTransitionImageLayoutEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint transitionCount, VkHostImageLayoutTransitionInfoEXT* pTransitions)
        {
            return this.ptr(device, transitionCount, pTransitions);
        }
    }
}
