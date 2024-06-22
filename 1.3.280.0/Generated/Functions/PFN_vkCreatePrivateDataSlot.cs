using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreatePrivateDataSlot : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfo, in VkAllocationCallbacks, ref VkPrivateDataSlot, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfo, in VkAllocationCallbacks, ref VkPrivateDataSlot, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePrivateDataSlot(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfo, in VkAllocationCallbacks, ref VkPrivateDataSlot, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePrivateDataSlot(delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfo, in VkAllocationCallbacks, ref VkPrivateDataSlot, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreatePrivateDataSlot v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePrivateDataSlot(VkFunctionPointer v) => new PFN_vkCreatePrivateDataSlot(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreatePrivateDataSlot v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePrivateDataSlot(void* v) => new PFN_vkCreatePrivateDataSlot(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPrivateDataSlotCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPrivateDataSlot pPrivateDataSlot)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pPrivateDataSlot);
        }
    }
}
