using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPrivateData : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ref ulong, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ref ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPrivateData(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ref ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPrivateData(delegate *unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ref ulong, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPrivateData v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPrivateData(VkFunctionPointer v) => new PFN_vkGetPrivateData(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPrivateData v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPrivateData(void* v) => new PFN_vkGetPrivateData(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ref ulong pData)
        {
            this.ptr(device, objectType, objectHandle, privateDataSlot, ref pData);
        }
    }
}
