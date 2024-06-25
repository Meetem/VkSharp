using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetShaderModuleCreateInfoIdentifierEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, ref VkShaderModuleIdentifierEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, ref VkShaderModuleIdentifierEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetShaderModuleCreateInfoIdentifierEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, ref VkShaderModuleIdentifierEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetShaderModuleCreateInfoIdentifierEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, ref VkShaderModuleIdentifierEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetShaderModuleCreateInfoIdentifierEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetShaderModuleCreateInfoIdentifierEXT(VkFunctionPointer v) => new PFN_vkGetShaderModuleCreateInfoIdentifierEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetShaderModuleCreateInfoIdentifierEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetShaderModuleCreateInfoIdentifierEXT(void* v) => new PFN_vkGetShaderModuleCreateInfoIdentifierEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkShaderModuleCreateInfo pCreateInfo, ref VkShaderModuleIdentifierEXT pIdentifier)
        {
            this.ptr(device, in pCreateInfo, ref pIdentifier);
        }
    }
}
