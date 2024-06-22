using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkPhysicalDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFeatures(ref VkPhysicalDeviceFeatures pFeatures)
        {
            var f = new PFN_vkGetPhysicalDeviceFeatures(VkLoader.GetFunction(2));
            f.Call(this, ref pFeatures);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFormatProperties(VkFormat format, ref VkFormatProperties pFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceFormatProperties(VkLoader.GetFunction(3));
            f.Call(this, format, ref pFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceImageFormatProperties(VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, ref VkImageFormatProperties pImageFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceImageFormatProperties(VkLoader.GetFunction(4));
            return f.Call(this, format, type, tiling, usage, flags, ref pImageFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceProperties(ref VkPhysicalDeviceProperties pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceProperties(VkLoader.GetFunction(5));
            f.Call(this, ref pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceQueueFamilyProperties(ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceQueueFamilyProperties(VkLoader.GetFunction(6));
            f.Call(this, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceMemoryProperties(ref VkPhysicalDeviceMemoryProperties pMemoryProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceMemoryProperties(VkLoader.GetFunction(7));
            f.Call(this, ref pMemoryProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDevice(in VkDeviceCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDevice pDevice)
        {
            var f = new PFN_vkCreateDevice(VkLoader.GetFunction(10));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pDevice);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumerateDeviceExtensionProperties(byte* pLayerName, ref uint pPropertyCount, VkExtensionProperties* pProperties)
        {
            var f = new PFN_vkEnumerateDeviceExtensionProperties(VkLoader.GetFunction(13));
            return f.Call(this, pLayerName, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumerateDeviceLayerProperties(ref uint pPropertyCount, VkLayerProperties* pProperties)
        {
            var f = new PFN_vkEnumerateDeviceLayerProperties(VkLoader.GetFunction(14));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceSparseImageFormatProperties(VkFormat format, VkImageType type, VkSampleCountFlags samples, VkImageUsageFlags usage, VkImageTiling tiling, ref uint pPropertyCount, VkSparseImageFormatProperties* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceSparseImageFormatProperties(VkLoader.GetFunction(31));
            f.Call(this, format, type, samples, usage, tiling, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFeatures2(ref VkPhysicalDeviceFeatures2 pFeatures)
        {
            var f = new PFN_vkGetPhysicalDeviceFeatures2(VkLoader.GetFunction(144));
            f.Call(this, ref pFeatures);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceProperties2(ref VkPhysicalDeviceProperties2 pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceProperties2(VkLoader.GetFunction(145));
            f.Call(this, ref pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFormatProperties2(VkFormat format, ref VkFormatProperties2 pFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceFormatProperties2(VkLoader.GetFunction(146));
            f.Call(this, format, ref pFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceImageFormatProperties2(in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, ref VkImageFormatProperties2 pImageFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceImageFormatProperties2(VkLoader.GetFunction(147));
            return f.Call(this, in pImageFormatInfo, ref pImageFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceQueueFamilyProperties2(ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceQueueFamilyProperties2(VkLoader.GetFunction(148));
            f.Call(this, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceMemoryProperties2(ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceMemoryProperties2(VkLoader.GetFunction(149));
            f.Call(this, ref pMemoryProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceSparseImageFormatProperties2(in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, ref uint pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceSparseImageFormatProperties2(VkLoader.GetFunction(150));
            f.Call(this, in pFormatInfo, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalBufferProperties(in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, ref VkExternalBufferProperties pExternalBufferProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalBufferProperties(VkLoader.GetFunction(158));
            f.Call(this, in pExternalBufferInfo, ref pExternalBufferProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalFenceProperties(in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, ref VkExternalFenceProperties pExternalFenceProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalFenceProperties(VkLoader.GetFunction(159));
            f.Call(this, in pExternalFenceInfo, ref pExternalFenceProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalSemaphoreProperties(in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalSemaphoreProperties(VkLoader.GetFunction(160));
            f.Call(this, in pExternalSemaphoreInfo, ref pExternalSemaphoreProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceToolProperties(ref uint pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceToolProperties(VkLoader.GetFunction(175));
            return f.Call(this, ref pToolCount, pToolProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceSupportKHR(uint queueFamilyIndex, VkSurfaceKHR surface, ref VkBool32 pSupported)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceSupportKHR(VkLoader.GetFunction(213));
            return f.Call(this, queueFamilyIndex, surface, ref pSupported);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkSurfaceKHR surface, ref VkSurfaceCapabilitiesKHR pSurfaceCapabilities)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceCapabilitiesKHR(VkLoader.GetFunction(214));
            return f.Call(this, surface, ref pSurfaceCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(VkSurfaceKHR surface, ref uint pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceFormatsKHR(VkLoader.GetFunction(215));
            return f.Call(this, surface, ref pSurfaceFormatCount, pSurfaceFormats);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(VkSurfaceKHR surface, ref uint pPresentModeCount, VkPresentModeKHR* pPresentModes)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfacePresentModesKHR(VkLoader.GetFunction(216));
            return f.Call(this, surface, ref pPresentModeCount, pPresentModes);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDevicePresentRectanglesKHR(VkSurfaceKHR surface, ref uint pRectCount, VkRect2D* pRects)
        {
            var f = new PFN_vkGetPhysicalDevicePresentRectanglesKHR(VkLoader.GetFunction(224));
            return f.Call(this, surface, ref pRectCount, pRects);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(ref uint pPropertyCount, VkDisplayPropertiesKHR* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceDisplayPropertiesKHR(VkLoader.GetFunction(226));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(ref uint pPropertyCount, VkDisplayPlanePropertiesKHR* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceDisplayPlanePropertiesKHR(VkLoader.GetFunction(227));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDisplayPlaneSupportedDisplaysKHR(uint planeIndex, ref uint pDisplayCount, VkDisplayKHR* pDisplays)
        {
            var f = new PFN_vkGetDisplayPlaneSupportedDisplaysKHR(VkLoader.GetFunction(228));
            return f.Call(this, planeIndex, ref pDisplayCount, pDisplays);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDisplayModePropertiesKHR(VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModePropertiesKHR* pProperties)
        {
            var f = new PFN_vkGetDisplayModePropertiesKHR(VkLoader.GetFunction(229));
            return f.Call(this, display, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDisplayModeKHR(VkDisplayKHR display, in VkDisplayModeCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDisplayModeKHR pMode)
        {
            var f = new PFN_vkCreateDisplayModeKHR(VkLoader.GetFunction(230));
            return f.Call(this, display, in pCreateInfo, in pAllocator, ref pMode);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDisplayPlaneCapabilitiesKHR(VkDisplayModeKHR mode, uint planeIndex, ref VkDisplayPlaneCapabilitiesKHR pCapabilities)
        {
            var f = new PFN_vkGetDisplayPlaneCapabilitiesKHR(VkLoader.GetFunction(231));
            return f.Call(this, mode, planeIndex, ref pCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(in VkVideoProfileInfoKHR pVideoProfile, ref VkVideoCapabilitiesKHR pCapabilities)
        {
            var f = new PFN_vkGetPhysicalDeviceVideoCapabilitiesKHR(VkLoader.GetFunction(234));
            return f.Call(this, in pVideoProfile, ref pCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(in VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo, ref uint pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceVideoFormatPropertiesKHR(VkLoader.GetFunction(235));
            return f.Call(this, in pVideoFormatInfo, ref pVideoFormatPropertyCount, pVideoFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFeatures2KHR(ref VkPhysicalDeviceFeatures2 pFeatures)
        {
            var f = new PFN_vkGetPhysicalDeviceFeatures2KHR(VkLoader.GetFunction(249));
            f.Call(this, ref pFeatures);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceProperties2KHR(ref VkPhysicalDeviceProperties2 pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceProperties2KHR(VkLoader.GetFunction(250));
            f.Call(this, ref pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceFormatProperties2KHR(VkFormat format, ref VkFormatProperties2 pFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceFormatProperties2KHR(VkLoader.GetFunction(251));
            f.Call(this, format, ref pFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceImageFormatProperties2KHR(in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, ref VkImageFormatProperties2 pImageFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceImageFormatProperties2KHR(VkLoader.GetFunction(252));
            return f.Call(this, in pImageFormatInfo, ref pImageFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceQueueFamilyProperties2KHR(ref uint pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceQueueFamilyProperties2KHR(VkLoader.GetFunction(253));
            f.Call(this, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceMemoryProperties2KHR(ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceMemoryProperties2KHR(VkLoader.GetFunction(254));
            f.Call(this, ref pMemoryProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, ref uint pPropertyCount, VkSparseImageFormatProperties2* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceSparseImageFormatProperties2KHR(VkLoader.GetFunction(255));
            f.Call(this, in pFormatInfo, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalBufferPropertiesKHR(in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, ref VkExternalBufferProperties pExternalBufferProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalBufferPropertiesKHR(VkLoader.GetFunction(261));
            f.Call(this, in pExternalBufferInfo, ref pExternalBufferProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, ref VkExternalSemaphoreProperties pExternalSemaphoreProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(VkLoader.GetFunction(264));
            f.Call(this, in pExternalSemaphoreInfo, ref pExternalSemaphoreProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceExternalFencePropertiesKHR(in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, ref VkExternalFenceProperties pExternalFenceProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalFencePropertiesKHR(VkLoader.GetFunction(277));
            f.Call(this, in pExternalFenceInfo, ref pExternalFenceProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(uint queueFamilyIndex, ref uint pCounterCount, VkPerformanceCounterKHR* pCounters, ref VkPerformanceCounterDescriptionKHR pCounterDescriptions)
        {
            var f = new PFN_vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(VkLoader.GetFunction(280));
            return f.Call(this, queueFamilyIndex, ref pCounterCount, pCounters, ref pCounterDescriptions);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(in VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, ref uint pNumPasses)
        {
            var f = new PFN_vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(VkLoader.GetFunction(281));
            f.Call(this, in pPerformanceQueryCreateInfo, ref pNumPasses);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref VkSurfaceCapabilities2KHR pSurfaceCapabilities)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceCapabilities2KHR(VkLoader.GetFunction(284));
            return f.Call(this, in pSurfaceInfo, ref pSurfaceCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, ref uint pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceFormats2KHR(VkLoader.GetFunction(285));
            return f.Call(this, in pSurfaceInfo, ref pSurfaceFormatCount, pSurfaceFormats);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceDisplayProperties2KHR(ref uint pPropertyCount, VkDisplayProperties2KHR* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceDisplayProperties2KHR(VkLoader.GetFunction(286));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(ref uint pPropertyCount, VkDisplayPlaneProperties2KHR* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceDisplayPlaneProperties2KHR(VkLoader.GetFunction(287));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDisplayModeProperties2KHR(VkDisplayKHR display, ref uint pPropertyCount, VkDisplayModeProperties2KHR* pProperties)
        {
            var f = new PFN_vkGetDisplayModeProperties2KHR(VkLoader.GetFunction(288));
            return f.Call(this, display, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDisplayPlaneCapabilities2KHR(in VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, ref VkDisplayPlaneCapabilities2KHR pCapabilities)
        {
            var f = new PFN_vkGetDisplayPlaneCapabilities2KHR(VkLoader.GetFunction(289));
            return f.Call(this, in pDisplayPlaneInfo, ref pCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(ref uint pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates)
        {
            var f = new PFN_vkGetPhysicalDeviceFragmentShadingRatesKHR(VkLoader.GetFunction(303));
            return f.Call(this, ref pFragmentShadingRateCount, pFragmentShadingRates);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo, ref VkVideoEncodeQualityLevelPropertiesKHR pQualityLevelProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkLoader.GetFunction(321));
            return f.Call(this, in pQualityLevelInfo, ref pQualityLevelProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(ref uint pPropertyCount, VkCooperativeMatrixPropertiesKHR* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(VkLoader.GetFunction(346));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsKHR(ref uint pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            var f = new PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsKHR(VkLoader.GetFunction(348));
            return f.Call(this, ref pTimeDomainCount, pTimeDomains);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkExternalMemoryHandleTypeFlagsNV externalHandleType, ref VkExternalImageFormatPropertiesNV pExternalImageFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceExternalImageFormatPropertiesNV(VkLoader.GetFunction(380));
            return f.Call(this, format, type, tiling, usage, flags, externalHandleType, ref pExternalImageFormatProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkReleaseDisplayEXT(VkDisplayKHR display)
        {
            var f = new PFN_vkReleaseDisplayEXT(VkLoader.GetFunction(384));
            return f.Call(this, display);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkSurfaceKHR surface, ref VkSurfaceCapabilities2EXT pSurfaceCapabilities)
        {
            var f = new PFN_vkGetPhysicalDeviceSurfaceCapabilities2EXT(VkLoader.GetFunction(385));
            return f.Call(this, surface, ref pSurfaceCapabilities);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkGetPhysicalDeviceMultisamplePropertiesEXT(VkSampleCountFlags samples, ref VkMultisamplePropertiesEXT pMultisampleProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceMultisamplePropertiesEXT(VkLoader.GetFunction(408));
            f.Call(this, samples, ref pMultisampleProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(ref uint pTimeDomainCount, VkTimeDomainKHR* pTimeDomains)
        {
            var f = new PFN_vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(VkLoader.GetFunction(432));
            return f.Call(this, ref pTimeDomainCount, pTimeDomains);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceToolPropertiesEXT(ref uint pToolCount, VkPhysicalDeviceToolProperties* pToolProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceToolPropertiesEXT(VkLoader.GetFunction(452));
            return f.Call(this, ref pToolCount, pToolProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(ref uint pPropertyCount, VkCooperativeMatrixPropertiesNV* pProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(VkLoader.GetFunction(453));
            return f.Call(this, ref pPropertyCount, pProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(ref uint pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            var f = new PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkLoader.GetFunction(454));
            return f.Call(this, ref pCombinationCount, pCombinations);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkAcquireDrmDisplayEXT(int drmFd, VkDisplayKHR display)
        {
            var f = new PFN_vkAcquireDrmDisplayEXT(VkLoader.GetFunction(483));
            return f.Call(this, drmFd, display);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetDrmDisplayEXT(int drmFd, uint connectorId, ref VkDisplayKHR display)
        {
            var f = new PFN_vkGetDrmDisplayEXT(VkLoader.GetFunction(484));
            return f.Call(this, drmFd, connectorId, ref display);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(in VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo, ref uint pFormatCount, VkOpticalFlowImageFormatPropertiesNV* pImageFormatProperties)
        {
            var f = new PFN_vkGetPhysicalDeviceOpticalFlowImageFormatsNV(VkLoader.GetFunction(581));
            return f.Call(this, in pOpticalFlowImageFormatInfo, ref pFormatCount, pImageFormatProperties);
        }
    }
}
