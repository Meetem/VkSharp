using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    public unsafe partial struct VkInstance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyInstance(in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyInstance(VkLoader.GetFunction(0));
            f.Call(this, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumeratePhysicalDevices(ref uint pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices)
        {
            var f = new PFN_vkEnumeratePhysicalDevices(VkLoader.GetFunction(1));
            return f.Call(this, ref pPhysicalDeviceCount, pPhysicalDevices);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkFunctionPointer vkGetInstanceProcAddr(byte* pName)
        {
            var f = new PFN_vkGetInstanceProcAddr(VkLoader.GetFunction(8));
            return f.Call(this, pName);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumeratePhysicalDeviceGroups(ref uint pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            var f = new PFN_vkEnumeratePhysicalDeviceGroups(VkLoader.GetFunction(140));
            return f.Call(this, ref pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroySurfaceKHR(VkSurfaceKHR surface, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroySurfaceKHR(VkLoader.GetFunction(175));
            f.Call(this, surface, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDisplayPlaneSurfaceKHR(in VkDisplaySurfaceCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface)
        {
            var f = new PFN_vkCreateDisplayPlaneSurfaceKHR(VkLoader.GetFunction(195));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSurface);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkEnumeratePhysicalDeviceGroupsKHR(ref uint pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
        {
            var f = new PFN_vkEnumeratePhysicalDeviceGroupsKHR(VkLoader.GetFunction(210));
            return f.Call(this, ref pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDebugReportCallbackEXT(in VkDebugReportCallbackCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDebugReportCallbackEXT pCallback)
        {
            var f = new PFN_vkCreateDebugReportCallbackEXT(VkLoader.GetFunction(284));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pCallback);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDebugReportCallbackEXT(VkDebugReportCallbackEXT callback, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDebugReportCallbackEXT(VkLoader.GetFunction(285));
            f.Call(this, callback, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDebugReportMessageEXT(VkDebugReportFlagsEXT flags, VkDebugReportObjectTypeEXT objectType, ulong _object, ulong location, int messageCode, byte* pLayerPrefix, byte* pMessage)
        {
            var f = new PFN_vkDebugReportMessageEXT(VkLoader.GetFunction(286));
            f.Call(this, flags, objectType, _object, location, messageCode, pLayerPrefix, pMessage);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateDebugUtilsMessengerEXT(in VkDebugUtilsMessengerCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDebugUtilsMessengerEXT pMessenger)
        {
            var f = new PFN_vkCreateDebugUtilsMessengerEXT(VkLoader.GetFunction(330));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pMessenger);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkDestroyDebugUtilsMessengerEXT(VkDebugUtilsMessengerEXT messenger, in VkAllocationCallbacks pAllocator)
        {
            var f = new PFN_vkDestroyDebugUtilsMessengerEXT(VkLoader.GetFunction(331));
            f.Call(this, messenger, in pAllocator);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void vkSubmitDebugUtilsMessageEXT(VkDebugUtilsMessageSeverityFlagsEXT messageSeverity, VkDebugUtilsMessageTypeFlagsEXT messageTypes, in VkDebugUtilsMessengerCallbackDataEXT pCallbackData)
        {
            var f = new PFN_vkSubmitDebugUtilsMessageEXT(VkLoader.GetFunction(332));
            f.Call(this, messageSeverity, messageTypes, in pCallbackData);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult vkCreateHeadlessSurfaceEXT(in VkHeadlessSurfaceCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface)
        {
            var f = new PFN_vkCreateHeadlessSurfaceEXT(VkLoader.GetFunction(380));
            return f.Call(this, in pCreateInfo, in pAllocator, ref pSurface);
        }
    }
}
