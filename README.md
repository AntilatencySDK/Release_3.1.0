# Antilatency SDK for Unreal Engine 3.1.0

Git command to clone this subset: `git clone --branch subset-1ac6c7c5ece415159eed0695e85c1a1e0559f063 --single-branch https://github.com/AntilatencySDK/Release_3.1.0.git AntilatencySDK`

## Content description

This is a subset of Antilatency SDK release v.3.1.0. You can find all settings for it using this [link](https://developers.antilatency.com/Sdk/Configurator_en.html#{"Libraries":{"AltEnvironmentHorizontalGrid":true,"AltEnvironmentPillars":true,"AltEnvironmentSelector":true,"AltTracking":true,"Bracer":true,"DeviceNetwork":true,"HardwareExtensionInterface":true,"RadioMetrics":true,"StorageClient":true,"TrackingAlignment":true},"OS":{"Android":{"aar":true},"Windows":{"x64":true,"x86":true}},"Release":"3.1.0","Target":"UnrealEngine","TargetSettings":{"MathTypes":"Default","UnrealEngineBlueprintsSamples":true,"UnrealEngineVersion":"4.26"}}). If you need to add or remove some feature to this subset, you can use the link above to make another subset that will match your requirements.

## Installation guide

There are 2 ways of installing plugin to the Unreal Engine:

- as project plugin
- as engine plugin

In first case this plugin will be available only in project where it is installed, in second - in every project.

### Building the plugin

This plugin is supplied with source code only, so it should be compiled before using it. If you plan to use this plugin as project plugin and your project is configured as source project, you can skip this part and just copy it to the `Plugins` folder as described below.

In other cases you need to build plugin manually:

- create a new source project using the engine version you need to
- copy plugin to the `Plugins` folder of this project
- open this project in Unreal Engine
- open Plugins window using the Edit/Plugins menu item
- find and select Antilatency SDK plugin
- click on `Package...` link
- select a directory where the compiled plugin will be put and press `Select Folder`
- wait for end of the build progress

### Installing the plugin

#### Installing as project plugin

Place the plugin's content to the `<path_to_your_project>/Plugins` directory, so the path to the AntilatencySDK.uplugin will be `<path_to_your_project>/Plugins/AntilatencySDK/AntilatencySDK.uplugin`

#### Installing as engine plugin

Place the plugin's content to the `<path_to_unreal_engine_istallation_dir>/Engine/Plugins/Runtime` directory, so the path to the AntilatencySDK.uplugin will be `<path_to_unreal_engine_istallation_dir>/Engine/Plugins/Runtime/AntilatencySDK/AntilatencySDK.uplugin`
