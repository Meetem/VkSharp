using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateOpticalFlowSessionNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkOpticalFlowSessionCreateInfoNV, in VkAllocationCallbacks, ref VkOpticalFlowSessionNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkOpticalFlowSessionCreateInfoNV, in VkAllocationCallbacks, ref VkOpticalFlowSessionNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateOpticalFlowSessionNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkOpticalFlowSessionCreateInfoNV, in VkAllocationCallbacks, ref VkOpticalFlowSessionNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateOpticalFlowSessionNV(delegate *unmanaged[Cdecl]<VkDevice, in VkOpticalFlowSessionCreateInfoNV, in VkAllocationCallbacks, ref VkOpticalFlowSessionNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateOpticalFlowSessionNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateOpticalFlowSessionNV(VkFunctionPointer v) => new PFN_vkCreateOpticalFlowSessionNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateOpticalFlowSessionNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateOpticalFlowSessionNV(void* v) => new PFN_vkCreateOpticalFlowSessionNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkOpticalFlowSessionCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkOpticalFlowSessionNV pSession)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pSession);
        }
    }
}
