using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkBuffer : IEquatable<VkBuffer>
    {
        public const bool IsDispatchable = false;
        public static VkBuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkBuffer other) => value == other.value;
        public override bool Equals(object obj) => obj is VkBuffer other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkBuffer lhs, VkBuffer rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkBuffer lhs, VkBuffer rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkImage : IEquatable<VkImage>
    {
        public const bool IsDispatchable = false;
        public static VkImage Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkImage other) => value == other.value;
        public override bool Equals(object obj) => obj is VkImage other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkImage lhs, VkImage rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkImage lhs, VkImage rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkInstance : IEquatable<VkInstance>
    {
        public const bool IsDispatchable = true;
        public static VkInstance Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkInstance other) => value == other.value;
        public override bool Equals(object obj) => obj is VkInstance other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkInstance lhs, VkInstance rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkInstance lhs, VkInstance rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
    {
        public const bool IsDispatchable = true;
        public static VkPhysicalDevice Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPhysicalDevice other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPhysicalDevice other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPhysicalDevice lhs, VkPhysicalDevice rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPhysicalDevice lhs, VkPhysicalDevice rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkDevice : IEquatable<VkDevice>
    {
        public const bool IsDispatchable = true;
        public static VkDevice Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDevice other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDevice other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDevice lhs, VkDevice rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDevice lhs, VkDevice rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkQueue : IEquatable<VkQueue>
    {
        public const bool IsDispatchable = true;
        public static VkQueue Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkQueue other) => value == other.value;
        public override bool Equals(object obj) => obj is VkQueue other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkQueue lhs, VkQueue rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkQueue lhs, VkQueue rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSemaphore : IEquatable<VkSemaphore>
    {
        public const bool IsDispatchable = false;
        public static VkSemaphore Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkSemaphore other) => value == other.value;
        public override bool Equals(object obj) => obj is VkSemaphore other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkSemaphore lhs, VkSemaphore rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkSemaphore lhs, VkSemaphore rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe partial struct VkCommandBuffer : IEquatable<VkCommandBuffer>
    {
        public const bool IsDispatchable = true;
        public static VkCommandBuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCommandBuffer other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCommandBuffer other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCommandBuffer lhs, VkCommandBuffer rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCommandBuffer lhs, VkCommandBuffer rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkFence : IEquatable<VkFence>
    {
        public const bool IsDispatchable = false;
        public static VkFence Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkFence other) => value == other.value;
        public override bool Equals(object obj) => obj is VkFence other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkFence lhs, VkFence rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkFence lhs, VkFence rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDeviceMemory : IEquatable<VkDeviceMemory>
    {
        public const bool IsDispatchable = false;
        public static VkDeviceMemory Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDeviceMemory other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDeviceMemory other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDeviceMemory lhs, VkDeviceMemory rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDeviceMemory lhs, VkDeviceMemory rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkEvent : IEquatable<VkEvent>
    {
        public const bool IsDispatchable = false;
        public static VkEvent Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkEvent other) => value == other.value;
        public override bool Equals(object obj) => obj is VkEvent other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkEvent lhs, VkEvent rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkEvent lhs, VkEvent rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkQueryPool : IEquatable<VkQueryPool>
    {
        public const bool IsDispatchable = false;
        public static VkQueryPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkQueryPool other) => value == other.value;
        public override bool Equals(object obj) => obj is VkQueryPool other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkQueryPool lhs, VkQueryPool rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkQueryPool lhs, VkQueryPool rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkBufferView : IEquatable<VkBufferView>
    {
        public const bool IsDispatchable = false;
        public static VkBufferView Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkBufferView other) => value == other.value;
        public override bool Equals(object obj) => obj is VkBufferView other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkBufferView lhs, VkBufferView rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkBufferView lhs, VkBufferView rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkImageView : IEquatable<VkImageView>
    {
        public const bool IsDispatchable = false;
        public static VkImageView Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkImageView other) => value == other.value;
        public override bool Equals(object obj) => obj is VkImageView other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkImageView lhs, VkImageView rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkImageView lhs, VkImageView rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkShaderModule : IEquatable<VkShaderModule>
    {
        public const bool IsDispatchable = false;
        public static VkShaderModule Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkShaderModule other) => value == other.value;
        public override bool Equals(object obj) => obj is VkShaderModule other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkShaderModule lhs, VkShaderModule rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkShaderModule lhs, VkShaderModule rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipelineCache : IEquatable<VkPipelineCache>
    {
        public const bool IsDispatchable = false;
        public static VkPipelineCache Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPipelineCache other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPipelineCache other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPipelineCache lhs, VkPipelineCache rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPipelineCache lhs, VkPipelineCache rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipelineLayout : IEquatable<VkPipelineLayout>
    {
        public const bool IsDispatchable = false;
        public static VkPipelineLayout Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPipelineLayout other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPipelineLayout other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPipelineLayout lhs, VkPipelineLayout rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPipelineLayout lhs, VkPipelineLayout rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPipeline : IEquatable<VkPipeline>
    {
        public const bool IsDispatchable = false;
        public static VkPipeline Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPipeline other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPipeline other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPipeline lhs, VkPipeline rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPipeline lhs, VkPipeline rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkRenderPass : IEquatable<VkRenderPass>
    {
        public const bool IsDispatchable = false;
        public static VkRenderPass Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkRenderPass other) => value == other.value;
        public override bool Equals(object obj) => obj is VkRenderPass other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkRenderPass lhs, VkRenderPass rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkRenderPass lhs, VkRenderPass rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorSetLayout : IEquatable<VkDescriptorSetLayout>
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorSetLayout Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDescriptorSetLayout other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDescriptorSetLayout other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDescriptorSetLayout lhs, VkDescriptorSetLayout rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDescriptorSetLayout lhs, VkDescriptorSetLayout rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSampler : IEquatable<VkSampler>
    {
        public const bool IsDispatchable = false;
        public static VkSampler Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkSampler other) => value == other.value;
        public override bool Equals(object obj) => obj is VkSampler other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkSampler lhs, VkSampler rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkSampler lhs, VkSampler rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorSet : IEquatable<VkDescriptorSet>
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorSet Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDescriptorSet other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDescriptorSet other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDescriptorSet lhs, VkDescriptorSet rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDescriptorSet lhs, VkDescriptorSet rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorPool : IEquatable<VkDescriptorPool>
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDescriptorPool other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDescriptorPool other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDescriptorPool lhs, VkDescriptorPool rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDescriptorPool lhs, VkDescriptorPool rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkFramebuffer : IEquatable<VkFramebuffer>
    {
        public const bool IsDispatchable = false;
        public static VkFramebuffer Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkFramebuffer other) => value == other.value;
        public override bool Equals(object obj) => obj is VkFramebuffer other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkFramebuffer lhs, VkFramebuffer rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkFramebuffer lhs, VkFramebuffer rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCommandPool : IEquatable<VkCommandPool>
    {
        public const bool IsDispatchable = false;
        public static VkCommandPool Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCommandPool other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCommandPool other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCommandPool lhs, VkCommandPool rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCommandPool lhs, VkCommandPool rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSamplerYcbcrConversion : IEquatable<VkSamplerYcbcrConversion>
    {
        public const bool IsDispatchable = false;
        public static VkSamplerYcbcrConversion Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkSamplerYcbcrConversion other) => value == other.value;
        public override bool Equals(object obj) => obj is VkSamplerYcbcrConversion other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkSamplerYcbcrConversion lhs, VkSamplerYcbcrConversion rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkSamplerYcbcrConversion lhs, VkSamplerYcbcrConversion rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDescriptorUpdateTemplate : IEquatable<VkDescriptorUpdateTemplate>
    {
        public const bool IsDispatchable = false;
        public static VkDescriptorUpdateTemplate Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDescriptorUpdateTemplate other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDescriptorUpdateTemplate other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDescriptorUpdateTemplate lhs, VkDescriptorUpdateTemplate rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDescriptorUpdateTemplate lhs, VkDescriptorUpdateTemplate rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPrivateDataSlot : IEquatable<VkPrivateDataSlot>
    {
        public const bool IsDispatchable = false;
        public static VkPrivateDataSlot Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPrivateDataSlot other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPrivateDataSlot other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPrivateDataSlot lhs, VkPrivateDataSlot rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPrivateDataSlot lhs, VkPrivateDataSlot rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
    {
        public const bool IsDispatchable = false;
        public static VkSurfaceKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkSurfaceKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkSurfaceKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkSurfaceKHR lhs, VkSurfaceKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkSurfaceKHR lhs, VkSurfaceKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkSwapchainKHR : IEquatable<VkSwapchainKHR>
    {
        public const bool IsDispatchable = false;
        public static VkSwapchainKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkSwapchainKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkSwapchainKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkSwapchainKHR lhs, VkSwapchainKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkSwapchainKHR lhs, VkSwapchainKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDisplayKHR : IEquatable<VkDisplayKHR>
    {
        public const bool IsDispatchable = false;
        public static VkDisplayKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDisplayKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDisplayKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDisplayKHR lhs, VkDisplayKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDisplayKHR lhs, VkDisplayKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDisplayModeKHR : IEquatable<VkDisplayModeKHR>
    {
        public const bool IsDispatchable = false;
        public static VkDisplayModeKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDisplayModeKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDisplayModeKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDisplayModeKHR lhs, VkDisplayModeKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDisplayModeKHR lhs, VkDisplayModeKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkVideoSessionKHR : IEquatable<VkVideoSessionKHR>
    {
        public const bool IsDispatchable = false;
        public static VkVideoSessionKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkVideoSessionKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkVideoSessionKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkVideoSessionKHR lhs, VkVideoSessionKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkVideoSessionKHR lhs, VkVideoSessionKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkVideoSessionParametersKHR : IEquatable<VkVideoSessionParametersKHR>
    {
        public const bool IsDispatchable = false;
        public static VkVideoSessionParametersKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkVideoSessionParametersKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkVideoSessionParametersKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkVideoSessionParametersKHR lhs, VkVideoSessionParametersKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkVideoSessionParametersKHR lhs, VkVideoSessionParametersKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDeferredOperationKHR : IEquatable<VkDeferredOperationKHR>
    {
        public const bool IsDispatchable = false;
        public static VkDeferredOperationKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDeferredOperationKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDeferredOperationKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDeferredOperationKHR lhs, VkDeferredOperationKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDeferredOperationKHR lhs, VkDeferredOperationKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDebugReportCallbackEXT : IEquatable<VkDebugReportCallbackEXT>
    {
        public const bool IsDispatchable = false;
        public static VkDebugReportCallbackEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDebugReportCallbackEXT other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDebugReportCallbackEXT other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDebugReportCallbackEXT lhs, VkDebugReportCallbackEXT rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDebugReportCallbackEXT lhs, VkDebugReportCallbackEXT rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCuModuleNVX : IEquatable<VkCuModuleNVX>
    {
        public const bool IsDispatchable = false;
        public static VkCuModuleNVX Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCuModuleNVX other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCuModuleNVX other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCuModuleNVX lhs, VkCuModuleNVX rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCuModuleNVX lhs, VkCuModuleNVX rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCuFunctionNVX : IEquatable<VkCuFunctionNVX>
    {
        public const bool IsDispatchable = false;
        public static VkCuFunctionNVX Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCuFunctionNVX other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCuFunctionNVX other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCuFunctionNVX lhs, VkCuFunctionNVX rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCuFunctionNVX lhs, VkCuFunctionNVX rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkDebugUtilsMessengerEXT : IEquatable<VkDebugUtilsMessengerEXT>
    {
        public const bool IsDispatchable = false;
        public static VkDebugUtilsMessengerEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkDebugUtilsMessengerEXT other) => value == other.value;
        public override bool Equals(object obj) => obj is VkDebugUtilsMessengerEXT other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkDebugUtilsMessengerEXT lhs, VkDebugUtilsMessengerEXT rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkDebugUtilsMessengerEXT lhs, VkDebugUtilsMessengerEXT rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkValidationCacheEXT : IEquatable<VkValidationCacheEXT>
    {
        public const bool IsDispatchable = false;
        public static VkValidationCacheEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkValidationCacheEXT other) => value == other.value;
        public override bool Equals(object obj) => obj is VkValidationCacheEXT other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkValidationCacheEXT lhs, VkValidationCacheEXT rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkValidationCacheEXT lhs, VkValidationCacheEXT rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkAccelerationStructureNV : IEquatable<VkAccelerationStructureNV>
    {
        public const bool IsDispatchable = false;
        public static VkAccelerationStructureNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkAccelerationStructureNV other) => value == other.value;
        public override bool Equals(object obj) => obj is VkAccelerationStructureNV other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkAccelerationStructureNV lhs, VkAccelerationStructureNV rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkAccelerationStructureNV lhs, VkAccelerationStructureNV rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkPerformanceConfigurationINTEL : IEquatable<VkPerformanceConfigurationINTEL>
    {
        public const bool IsDispatchable = false;
        public static VkPerformanceConfigurationINTEL Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkPerformanceConfigurationINTEL other) => value == other.value;
        public override bool Equals(object obj) => obj is VkPerformanceConfigurationINTEL other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkPerformanceConfigurationINTEL lhs, VkPerformanceConfigurationINTEL rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkPerformanceConfigurationINTEL lhs, VkPerformanceConfigurationINTEL rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkIndirectCommandsLayoutNV : IEquatable<VkIndirectCommandsLayoutNV>
    {
        public const bool IsDispatchable = false;
        public static VkIndirectCommandsLayoutNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkIndirectCommandsLayoutNV other) => value == other.value;
        public override bool Equals(object obj) => obj is VkIndirectCommandsLayoutNV other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkIndirectCommandsLayoutNV lhs, VkIndirectCommandsLayoutNV rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkIndirectCommandsLayoutNV lhs, VkIndirectCommandsLayoutNV rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCudaModuleNV : IEquatable<VkCudaModuleNV>
    {
        public const bool IsDispatchable = false;
        public static VkCudaModuleNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCudaModuleNV other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCudaModuleNV other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCudaModuleNV lhs, VkCudaModuleNV rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCudaModuleNV lhs, VkCudaModuleNV rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkCudaFunctionNV : IEquatable<VkCudaFunctionNV>
    {
        public const bool IsDispatchable = false;
        public static VkCudaFunctionNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkCudaFunctionNV other) => value == other.value;
        public override bool Equals(object obj) => obj is VkCudaFunctionNV other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkCudaFunctionNV lhs, VkCudaFunctionNV rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkCudaFunctionNV lhs, VkCudaFunctionNV rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkAccelerationStructureKHR : IEquatable<VkAccelerationStructureKHR>
    {
        public const bool IsDispatchable = false;
        public static VkAccelerationStructureKHR Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkAccelerationStructureKHR other) => value == other.value;
        public override bool Equals(object obj) => obj is VkAccelerationStructureKHR other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkAccelerationStructureKHR lhs, VkAccelerationStructureKHR rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkAccelerationStructureKHR lhs, VkAccelerationStructureKHR rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkMicromapEXT : IEquatable<VkMicromapEXT>
    {
        public const bool IsDispatchable = false;
        public static VkMicromapEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkMicromapEXT other) => value == other.value;
        public override bool Equals(object obj) => obj is VkMicromapEXT other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkMicromapEXT lhs, VkMicromapEXT rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkMicromapEXT lhs, VkMicromapEXT rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkOpticalFlowSessionNV : IEquatable<VkOpticalFlowSessionNV>
    {
        public const bool IsDispatchable = false;
        public static VkOpticalFlowSessionNV Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkOpticalFlowSessionNV other) => value == other.value;
        public override bool Equals(object obj) => obj is VkOpticalFlowSessionNV other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkOpticalFlowSessionNV lhs, VkOpticalFlowSessionNV rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkOpticalFlowSessionNV lhs, VkOpticalFlowSessionNV rhs) => lhs.value != rhs.value;
    }
    
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkShaderEXT : IEquatable<VkShaderEXT>
    {
        public const bool IsDispatchable = false;
        public static VkShaderEXT Null => default;
        public bool IsNull => value == 0;
        public ulong value;
        
        public bool Equals(VkShaderEXT other) => value == other.value;
        public override bool Equals(object obj) => obj is VkShaderEXT other && Equals(other);
        public override int GetHashCode()
        {
            uint high = (uint)(value >> 32);
            uint low = (uint)(value & 0xFFFFFFFF);
            return high.GetHashCode() ^ low.GetHashCode();
        }
        public static bool operator ==(VkShaderEXT lhs, VkShaderEXT rhs) => lhs.value == rhs.value;
        public static bool operator !=(VkShaderEXT lhs, VkShaderEXT rhs) => lhs.value != rhs.value;
    }
    
}
