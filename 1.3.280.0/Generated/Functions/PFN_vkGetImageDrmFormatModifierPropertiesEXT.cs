using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetImageDrmFormatModifierPropertiesEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref VkImageDrmFormatModifierPropertiesEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref VkImageDrmFormatModifierPropertiesEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageDrmFormatModifierPropertiesEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref VkImageDrmFormatModifierPropertiesEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetImageDrmFormatModifierPropertiesEXT(delegate *unmanaged[Cdecl]<VkDevice, VkImage, ref VkImageDrmFormatModifierPropertiesEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetImageDrmFormatModifierPropertiesEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageDrmFormatModifierPropertiesEXT(VkFunctionPointer v) => new PFN_vkGetImageDrmFormatModifierPropertiesEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetImageDrmFormatModifierPropertiesEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetImageDrmFormatModifierPropertiesEXT(void* v) => new PFN_vkGetImageDrmFormatModifierPropertiesEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkImage image, ref VkImageDrmFormatModifierPropertiesEXT pProperties)
        {
            return this.ptr(device, image, ref pProperties);
        }
    }
}
