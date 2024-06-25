using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkUpdateVideoSessionParametersKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkVideoSessionParametersUpdateInfoKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkVideoSessionParametersUpdateInfoKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkUpdateVideoSessionParametersKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkVideoSessionParametersUpdateInfoKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkUpdateVideoSessionParametersKHR(delegate *unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, in VkVideoSessionParametersUpdateInfoKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkUpdateVideoSessionParametersKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkUpdateVideoSessionParametersKHR(VkFunctionPointer v) => new PFN_vkUpdateVideoSessionParametersKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkUpdateVideoSessionParametersKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkUpdateVideoSessionParametersKHR(void* v) => new PFN_vkUpdateVideoSessionParametersKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkVideoSessionParametersKHR videoSessionParameters, in VkVideoSessionParametersUpdateInfoKHR pUpdateInfo)
        {
            return this.ptr(device, videoSessionParameters, in pUpdateInfo);
        }
    }
}
