namespace VkSharp
{
    public static class VkConstants
    {
        public const uint VK_UUID_SIZE = 16u;
        public const uint VK_ATTACHMENT_UNUSED = 0xFFFFFFFFu;
        public const uint VK_FALSE = 0;
        public const uint VK_TRUE = 1;
        public const float VK_LOD_CLAMP_NONE = 1000.0f;
        public const uint VK_QUEUE_FAMILY_IGNORED = 0xFFFFFFFFu;
        public const uint VK_REMAINING_ARRAY_LAYERS = 0xFFFFFFFFu;
        public const uint VK_REMAINING_MIP_LEVELS = 0xFFFFFFFFu;
        public const uint VK_SUBPASS_EXTERNAL = 0xFFFFFFFFu;
        public const ulong VK_WHOLE_SIZE = 0xFFFFFFFFFFFFFFFFul;
        public const uint VK_MAX_MEMORY_TYPES = 32;
        public const uint VK_MAX_MEMORY_HEAPS = 16;
        public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;
        public const uint VK_MAX_EXTENSION_NAME_SIZE = 256;
        public const uint VK_MAX_DESCRIPTION_SIZE = 256;

        public static uint VK_MAKE_API_VERSION(uint variant, uint major, uint minor, uint patch)
        {
            return
                ((((uint)(variant)) << 29) | (((uint)(major)) << 22) | (((uint)(minor)) << 12) | ((uint)(patch)));
        }

        public static uint VK_API_VERSION_VARIANT(uint version) => ((uint)(version) >> 29);
        public static uint VK_API_VERSION_MAJOR(uint version) => (((uint)(version) >> 22) & 0x7FU);
        public static uint VK_API_VERSION_MINOR(uint version) => (((uint)(version) >> 12) & 0x3FFU);
        public static uint VK_API_VERSION_PATCH(uint version) => ((uint)(version) & 0xFFFU);
    }
}