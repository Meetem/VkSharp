# VkSharp
Vulkan bindings for C# (with Unity Burst support)
* For specific SDK version use different branches

## Features
* Unity Burst Support: Fully compatible with Unity's Burst compiler for optimized performance.
* Managed .NET Support: different .NET runtimes supported too. You need at least C# 9 to use uncompiled version of the code.
* Full unmanaged support: Utilizes unmanaged code through structs to ensure Burst support, and no additional marshalling.
* Flexible Initialization: Easy initialization with VkLoader.Initialize for providing function pointers.
* Multiple Calling Options: Several options for calling Vulkan functions to suit different preferences and use cases.
* Reflection Automation: Possibility to automate function loading using reflection.
* Vulkan function callers: `PFN_vk*` structs provide easy abstraction over Vulkan's function pointers. Fully binary compatible. There's also `vk*Delegate` managed delegates if you need. (for instance: to use with MonoPInvokeAttribute when hooking Vulkan in Unity)
### Initialization

Call `VkLoader.Initialize(vkGetInstanceProcAddr, vkGetDeviceProcAddr)` (from managed side) to provide function pointers to respective functions.

Then load needed function by calling `VkLoader.LoadDevice/InstanceFunction` or its generic counterpart.
For generic counterpart you need to either use PFN_vk* structures for easier calling (in that case function name will be deduced from the struct name)
or use non-generic version with name. 

Example:
```cs
void SomewhereInMyAppLoad(void *vkGetInstanceProcAddr, void *vkGetDeviceProcAddr)
{
  VkLoader.Initialize(
    new PFN_vkGetInstanceProcAddr(vkGetInstanceProcAddr),
    new PFN_vkGetDeviceProcAddr(vkGetDeviceProcAddr)
  );
  
  var createInstanceFunc = VkLoader.LoadInstanceFunction<PFN_vkCreateInstance>(default);
  VkInstance createdInstance = default;
  var vkResult = createInstanceFunc.Call(..., ref createdInstance);
  // handle errors etc.
  
  // Persistent mapped function (don't need a result)
  var tf = VkLoader.LoadInstanceFunction<PFN_vkEnumeratePhysicalDevices>(createdInstance);
  // TODO: Load other needed functions.
  // ...
  // ---


  //If using under Unity, you might need to call this.
  //VkLoader.UpdatePointersInBurst();
}
```

### Calling Vulkan functions
After you loaded all of needed functions, you can either store PFN_vk* outputs somewhere where you feel comfortable,
or use `VkLoader.GetFunctions().vkFunctionName` to access loaded functions if they are exist in `VkFunctions` struct.
*Note that not all functions are resided in VkFunctions.*
*You MUST load the function before you call it in any way*

Make sure the functions you need are not loaded with `null` result :)

Example:
```cs
  /*
    There are multiple options how you can call the resolved function,
    I prefer the first one.
    Note that all of the functions you are calling using first or second option
    MUST be loaded beforehand.
    You can do it automagically with reflection if you wish.
  */
  // Calling instance function option 1 (via handle):
  createdInstance.vkEnumeratePhysicalDevices.Call(...);
  // Calling instance function option 2 (via global functions):
  VkLoader.GetFunctions().vkEnumeratePhysicalDevices.Call(...);
  // Calling instance function option 3:
  var tf = VkLoader.LoadInstanceFunction<PFN_vkEnumeratePhysicalDevices>(createdInstance);
  tf.Call(...);
```

### Note about Burst
You might prefer calling functions via globals or via handle, because any other way of passing function pointers might introduce unnecessary indirect load.
If you manually use `VkFunction.SetFunction(id, ptr)` from managed side, make sure to call `VkLoader.UpdatePointersInBurst()` to sync changes.

## Missing Features
* You can't load new functions while using Burst just yet or initialize your app under Burst. Not sure if it's even needed.
* Feel free to file an issue if you want.
* 32-bit support.
