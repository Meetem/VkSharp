using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceAccelerationStructureCompatibilityKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureVersionInfoKHR, ref VkAccelerationStructureCompatibilityKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureVersionInfoKHR, ref VkAccelerationStructureCompatibilityKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureVersionInfoKHR, ref VkAccelerationStructureCompatibilityKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureVersionInfoKHR, ref VkAccelerationStructureCompatibilityKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceAccelerationStructureCompatibilityKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(VkFunctionPointer v) => new PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceAccelerationStructureCompatibilityKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(void* v) => new PFN_vkGetDeviceAccelerationStructureCompatibilityKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkAccelerationStructureVersionInfoKHR pVersionInfo, ref VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            this.ptr(device, in pVersionInfo, ref pCompatibility);
        }
    }
}
