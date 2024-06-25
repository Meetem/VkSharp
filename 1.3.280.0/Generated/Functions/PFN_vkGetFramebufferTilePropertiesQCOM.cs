using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetFramebufferTilePropertiesQCOM : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkFramebuffer, ref uint, VkTilePropertiesQCOM*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkFramebuffer, ref uint, VkTilePropertiesQCOM*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetFramebufferTilePropertiesQCOM(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkFramebuffer, ref uint, VkTilePropertiesQCOM*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetFramebufferTilePropertiesQCOM(delegate *unmanaged[Cdecl]<VkDevice, VkFramebuffer, ref uint, VkTilePropertiesQCOM*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetFramebufferTilePropertiesQCOM v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetFramebufferTilePropertiesQCOM(VkFunctionPointer v) => new PFN_vkGetFramebufferTilePropertiesQCOM(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetFramebufferTilePropertiesQCOM v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetFramebufferTilePropertiesQCOM(void* v) => new PFN_vkGetFramebufferTilePropertiesQCOM(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkFramebuffer framebuffer, ref uint pPropertiesCount, VkTilePropertiesQCOM* pProperties)
        {
            return this.ptr(device, framebuffer, ref pPropertiesCount, pProperties);
        }
    }
}
