using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceFaultInfoEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceFaultCountsEXT, ref VkDeviceFaultInfoEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceFaultCountsEXT, ref VkDeviceFaultInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceFaultInfoEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceFaultCountsEXT, ref VkDeviceFaultInfoEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceFaultInfoEXT(delegate *unmanaged[Cdecl]<VkDevice, ref VkDeviceFaultCountsEXT, ref VkDeviceFaultInfoEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceFaultInfoEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceFaultInfoEXT(VkFunctionPointer v) => new PFN_vkGetDeviceFaultInfoEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceFaultInfoEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceFaultInfoEXT(void* v) => new PFN_vkGetDeviceFaultInfoEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, ref VkDeviceFaultCountsEXT pFaultCounts, ref VkDeviceFaultInfoEXT pFaultInfo)
        {
            return this.ptr(device, ref pFaultCounts, ref pFaultInfo);
        }
    }
}
