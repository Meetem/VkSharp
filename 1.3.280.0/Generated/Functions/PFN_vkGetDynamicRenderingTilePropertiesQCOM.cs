using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDynamicRenderingTilePropertiesQCOM : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingInfo, ref VkTilePropertiesQCOM, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingInfo, ref VkTilePropertiesQCOM, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDynamicRenderingTilePropertiesQCOM(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingInfo, ref VkTilePropertiesQCOM, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDynamicRenderingTilePropertiesQCOM(delegate *unmanaged[Cdecl]<VkDevice, in VkRenderingInfo, ref VkTilePropertiesQCOM, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDynamicRenderingTilePropertiesQCOM v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDynamicRenderingTilePropertiesQCOM(VkFunctionPointer v) => new PFN_vkGetDynamicRenderingTilePropertiesQCOM(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDynamicRenderingTilePropertiesQCOM v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDynamicRenderingTilePropertiesQCOM(void* v) => new PFN_vkGetDynamicRenderingTilePropertiesQCOM(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkRenderingInfo pRenderingInfo, ref VkTilePropertiesQCOM pProperties)
        {
            return this.ptr(device, in pRenderingInfo, ref pProperties);
        }
    }
}
