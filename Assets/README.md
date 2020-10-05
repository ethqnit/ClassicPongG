# AdColony SDK Unity Plugin
- Modified: Feb 2, 2018
- Unity Plugin Version: 3.3.0
- iOS SDK Version: 3.3.0
- Android SDK Version: 3.3.0

## Overview
AdColony delivers zero-buffering, [full-screen Instant-Play™ HD video](https://www.adcolony.com/technology/instant-play/), [interactive Aurora™ Video](https://www.adcolony.com/technology/auroravideo), and Aurora™ Playable ads that can be displayed anywhere within your application. Our advertising SDK is trusted by the world’s top gaming and non-gaming publishers, delivering them the highest monetization opportunities from brand and performance advertisers. AdColony’s SDK can monetize a wide range of ad formats including in-stream/pre-roll, out-stream/interstitial and V4VC™, a secure system for rewarding users of your app with virtual currency upon the completion of video and playable ads.

## Release Notes

#### Key Features of the SDK 3.3:
* Added Integral Ad Science (IAS) for viewability measurement.
* Better iPhone X compatibility
* Fixed storage overuse issue reported by a small number of publishers upgrading from 2.x -> 3.x
* Several bug fixes, memory usage optimizations, and stability improvements.

Here is the link to the [release notes](https://github.com/AdColony/AdColony-Unity-SDK-3/blob/master/CHANGELOG.md) for all the previous SDK versions.

## Getting Started

### Installation

1. In the Unity Editor, select "Assets"->"Import Package"->"Custom Package". Navigate to the location of the AdColony SDK Unity Plugin and select "AdColony.unitypackage".
1. Select "Import" to import all the assets into your project.
1. The AdColony SDK Unity Plugin includes Google's PlayServicesResolver to automatically pull in necessary Google Play Services libraries. If there are conflicts with this, the `play-services-ads` library is the only required. You can choose to ignore this PlayServicesResolver installation, remove the `AdColony/Editor/ADCDependencies.cs` file, and include the `play-services-ads` in another way.
1. The Plugins/Android/AdColony/AndroidManifest.xml file is automatically generated. To update manually, select "Tools"->"AdColony"->"Update AndroidManifest.xml".

Here is the link to [Unity SDK integration documentation](https://github.com/AdColony/AdColony-Unity-SDK-3/wiki).


## Upgrade

#### From SDK 3.0:
In order to support thin/fat Android builds, we moved the native .so files from the `Plugins/Android/AdColony/libs` folder to the `Plugins/Android/libs` folder. Removing the `Plugins/Android/AdColony` folder before importing is recommended. Otherwise, simply remove the `Plugins/Android/AdColony/libs/armeabi-v7a` and `Plugins/Android/AdColony/libs/x86` folders.

#### From SDK 2.x:
Please note that updating from our 2.x Unity Plugin is not a drag and drop update, but rather includes breaking API and process changes. In order to take advantage of the 3.x Unity Plugin, a complete re-integration is necessary. Please review our [documentation](https://github.com/AdColony/AdColony-Unity-SDK-3/wiki) to get a better idea on what changes will be necessary in your app.


## Legal Requirements
By downloading the AdColony SDK, you are granted a limited, non-commercial license to use and review the SDK solely for evaluation purposes.  If you wish to integrate the SDK into any commercial applications, you must register an account with AdColony and accept the terms and conditions on the AdColony website.

Note that U.S. based companies will need to complete the W-9 form and send it to us before publisher payments can be issued.

## Contact Us
For more information, please visit AdColony.com. For questions or assistance, please email us at support@adcolony.com.
