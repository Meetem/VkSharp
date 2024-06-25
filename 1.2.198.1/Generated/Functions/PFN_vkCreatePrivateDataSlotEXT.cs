using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreatePrivateDataSlotEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfoEXT, in VkAllocationCallbacks, ref VkPrivateDataSlotEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfoEXT, in VkAllocationCallbacks, ref VkPrivateDataSlotEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePrivateDataSlotEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfoEXT, in VkAllocationCallbacks, ref VkPrivateDataSlotEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreatePrivateDataSlotEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkPrivateDataSlotCreateInfoEXT, in VkAllocationCallbacks, ref VkPrivateDataSlotEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreatePrivateDataSlotEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePrivateDataSlotEXT(VkFunctionPointer v) => new PFN_vkCreatePrivateDataSlotEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreatePrivateDataSlotEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreatePrivateDataSlotEXT(void* v) => new PFN_vkCreatePrivateDataSlotEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPrivateDataSlotCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkPrivateDataSlotEXT pPrivateDataSlot)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pPrivateDataSlot);
        }
    }
}
