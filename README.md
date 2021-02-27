Vulkan for dotnet
================

Overview
--------
A Khronos Vulkan API wrapper for .NET 5.0+ environment, without any abstraction but with only just the Vulkan API itself.
All of the managed abstractions are in the project VulkanManaged. More information is in (./VulkanManaged/README.md, here)

Status
------
This wrapper was artlessly generated. Most of the functions, the enums, and the structs have not been tested by public. Please report or make pull request when you found a bug even if it is very minor one.

Note
----
Some features of extension might lack due to the fail of crawling the specification. But, the core features of the Vulkan API itself and most of the extensions are supported.