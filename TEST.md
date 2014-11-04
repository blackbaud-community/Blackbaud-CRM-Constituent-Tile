Blackbaud-CRM-Constituent-Tile
==============================
This is a placeholder for a project to demonstrate how to create constituent tiles in Blackbaud CRM 4.0.

TEst

Starting in Blackbaud CRM 4.0, the constituent summary on the Constituent page  displays a series of interactive tiles. Each tile is a self-contained view data form that the summary  dynamically loads, and end users can select which tiles to display. The summary displays several out-of-the-box tiles, and third-party developers can create their own custom tiles.

This code sample along with [step by step instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/ view-data-forms-tiles-sample.htm) will teach you the basics of building a custom tile to display in the Constituent page summary. 

## Prerequisites ##

Before you build this UI Model project, be sure to complete the following:



1. You will need a developer instance of Blackbaud CRM version 4.0 installed or higher. (4.0 is the latest at the time of writing this sample)
2. You will need the Blackbaud CRM SDK 4.0 installed.
3. If you have more than one version of the SDK installed, you will need to run the SetCurrentSDK.bat file located within your local 4.0 version SDK folder.  See our instructions for [setting up a developer environment](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/infintro-developer-help/Content/coBlackbaudCRMSDKDevEnvSetup.htm%3FTocPath%3DGet%20Started%7C_____6) for more details.
4. Within the Blackbaud.CustomFx.EventsTile.Catalog project, update the build output location to reflect your local environment. 
 - In Visual Studio, right-click the Blackbaud.CustomFx.EventsTile.UIModel project and select Properties. Then on the Compile tab, click Browse in the Build output path field and select the \bbappfx\vroot\bin\custom folder in your installation directory. 
 - Update the xcopy path in the postbuild.bat file. 


2. Within the In the Blackbaud.CustomFx.EventsTile.UIModel project
 - Open the postbuild.bat. In the second line of the .bat file, update the path in the xcopy command to reflect the \bbappfx\vroot\bin\htmlforms folder in your installation directory.

##Resources##
* See the [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md). 
* [Step by Step Instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/ view-data-forms-tiles-sample.htm) for creating an event registrations tile
* [Data Forms](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/welcome-data-forms.htm) Chapter within Developer Guides


##Contributing##
If you would like to contribute to this code sample, please carefully read the [contributing documentation](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/CONTRIBUTING.md), which details the necessary workflow. Included in those requirements is [signing the Contributor License Agreement.](http://developer.blackbaud.com/cla/)