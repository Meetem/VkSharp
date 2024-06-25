using System;

namespace VkSharp
{
    [AttributeUsage(AttributeTargets.Field)]
    public class VkFunctionIdAttribute : Attribute
    {
        public int Id { get; set; }
        public bool IsResolvable { get; set; }
        public VkFunctionOwner Owner { get; set; }

        public VkFunctionIdAttribute(int id, bool isResolvable, VkFunctionOwner owner)
        {
            Id = id;
            IsResolvable = isResolvable;
            Owner = owner;
        }
    }
}