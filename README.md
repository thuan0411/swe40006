# SWE40006 Deployment Portfolio Task 1

Deployment Toolbox - a small WinForms app used to demonstrate WiX Toolset
packaging for SWE40006 (Software Deployment and Evolution).

## Structure

- `src/DeploymentToolbox/` - main WinForms app (.NET Framework 4.8)
- `src/DeploymentToolbox.MathEngine/` - class library DLL (arithmetic)
- `src/DeploymentToolbox.TextUtils/` - class library DLL (text helpers)
- `wix/Product.wxs` - WiX v3 source authoring the installer, including
  both dependency DLLs as explicit Components (Distinction requirement)

## Target level

Distinction: custom-built app (Credit) with multiple external DLL
dependencies correctly authored in the .wxs and bundled into the final
.msi (Distinction).

## Build

Open the solution in Visual Studio 2022 (x64) with the WiX Toolset v3.14
build tools and the WiX Toolset Visual Studio 2022 Extension installed,
build in Release, then build the DeploymentToolboxSetup project to
produce DeploymentToolbox.msi.
