Blackbaud-CRM-Constituent-Tile
==============================

Starting in Blackbaud CRM 4.0, the constituent summary on the Constituent page  displays a series of interactive tiles. Each tile is a self-contained view data form that the summary  dynamically loads, and end users can select which tiles to display. The summary displays several out-of-the-box tiles, and third-party developers can create their own custom tiles.

![](https://github.com/blackbaud-community/Blackbaud-CRM/blob/gh-pages/images/ConstituentTile.png)

## What You Will Build ##

This code sample and its [step by step instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/ view-data-forms-tiles-sample.htm) teach you the basics of how to build a custom tile to display in the Constituent page summary. 
You can use the code sample to create a tile that displays event registration information in the constituent summary.

![](https://github.com/blackbaud-community/Blackbaud-CRM/blob/gh-pages/images/ConstituentTileEvents.png)

The code sample demonstrates how to take advantage of some of the exciting features that are available for constituent tiles.
* Learn how to create a repeater tile that allow end users to page through multiple records within a single tile. The sample code follows an established pattern of retrieving records through a collection field when the tile loads. 
* Learn how to display features such as links and navigation options within a tile. The sample code creates UI actions on the tile's view data form spec for navigation buttons and for links to more information on the Constituent page's Events tab and on the Event Registrant page. Then the UI Model provides logic for how the navigation buttons work and indicates where to display the UI actions. 
* Learn how to modify the appearance of a tile through the UI Model's HTML file. The sample code uses HTML and CSS to control the styling. You can also create JavaScript files in the UI Model for a custom tile, but this sample does not use any JavaScript.

## Prerequisites ##

Before you build the UI Model project, be sure to complete the following:

0. You need a developer instance of Blackbaud CRM version 4.0 installed or higher. (4.0 is the most recent version at the time of writing this sample). You need the Blackbaud CRM SDK 4.0. If you have more than one version of the SDK, you need to run the SetCurrentSDK.bat file located in your local 4.0 version SDK folder. See our instructions to [set up a developer environment](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/infintro-developer-help/Content/coBlackbaudCRMSDKDevEnvSetup.htm%3FTocPath%3DGet%20Started%7C_____6) for more details. 
0. In the Blackbaud.CustomFx.EventsTile.UIModel project, update the build output location in Visual Studio to reflect your local environment. 
 - Right-click the Blackbaud.CustomFx.EventsTile.UIModel project and select Properties. Then on the Compile tab, click Browse in the Build output path field and select the \bbappfx\vroot\bin\custom folder in your installation directory. 
 - Open the postbuild.bat file and update the xcopy path in the second line to reflect the \bbappfx\vroot\bin\htmlforms folder in your installation directory.

##Resources##
* See the [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md). 
* [Step by Step Instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/view-data-forms-tiles-sample.htm) for creating an event registrations tile
* [Data Forms](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/welcome-data-forms.htm) Chapter within Developer Guides


##Contributing##
If you would like to contribute to this code sample, please carefully read the [contributing documentation](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/CONTRIBUTING.md), which details the necessary workflow. Included in those requirements is [signing the Contributor License Agreement.](http://developer.blackbaud.com/cla/)