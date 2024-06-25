using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceImageMemoryRequirementsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirementsKHR, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirementsKHR, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageMemoryRequirementsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirementsKHR, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceImageMemoryRequirementsKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceImageMemoryRequirementsKHR, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceImageMemoryRequirementsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageMemoryRequirementsKHR(VkFunctionPointer v) => new PFN_vkGetDeviceImageMemoryRequirementsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceImageMemoryRequirementsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceImageMemoryRequirementsKHR(void* v) => new PFN_vkGetDeviceImageMemoryRequirementsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDeviceImageMemoryRequirementsKHR pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pMemoryRequirements);
        }
    }
}
