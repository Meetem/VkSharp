using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceMicromapCompatibilityEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapVersionInfoEXT, ref VkAccelerationStructureCompatibilityKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapVersionInfoEXT, ref VkAccelerationStructureCompatibilityKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceMicromapCompatibilityEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapVersionInfoEXT, ref VkAccelerationStructureCompatibilityKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceMicromapCompatibilityEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapVersionInfoEXT, ref VkAccelerationStructureCompatibilityKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceMicromapCompatibilityEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceMicromapCompatibilityEXT(VkFunctionPointer v) => new PFN_vkGetDeviceMicromapCompatibilityEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceMicromapCompatibilityEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceMicromapCompatibilityEXT(void* v) => new PFN_vkGetDeviceMicromapCompatibilityEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkMicromapVersionInfoEXT pVersionInfo, ref VkAccelerationStructureCompatibilityKHR pCompatibility)
        {
            this.ptr(device, in pVersionInfo, ref pCompatibility);
        }
    }
}
