using System;

namespace VkSharp
{
    [AttributeUsage(AttributeTargets.Struct)]
    public class VkFunctionStructAttribute : Attribute
    {
        public VkFunctionOwner Owner { get; set; }
        
        public VkFunctionStructAttribute(VkFunctionOwner owner)
        {
            Owner = owner;
        }
    }
}