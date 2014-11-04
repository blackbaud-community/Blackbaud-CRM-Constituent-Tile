Blackbaud-CRM-Constituent-Tile
==============================
This is a placeholder for a project to demonstrate how to create constituent tiles in Blackbaud CRM 4.0.



Starting in Blackbaud CRM 4.0, the constituent summary on the Constituent page  displays a series of interactive tiles. Each tile is a self-contained view data form that the summary  dynamically loads, and end users can select which tiles to display. The summary displays several out-of-the-box tiles, and third-party developers can create their own custom tiles.

This example will teach you the basics of building a custom tile to display in the Constituent page summary. To create a custom tile, you first create the view data from where you specify the data to display in the tile. Next, you create a UI Model for the view data form to modify the appearance of the tile. Finally, after you load the view data form and build the UI Model project, you designate the view data form as a tile by using a SQL statement to insert a row for the view form in the CONSTITUENTSUMMARYAVAILABLETILE table.

This code sample includes a Visual Studio solution with a catalog project and a UI Model project. The catalog project includes a view data form spec to display event registration information in  a custom tile. The UI Model project includes the UI Model that implements the tile interface for the view data form. The code sample also includes a SQL statement to insert a row for the view data form in the CONSTITUENTSUMMARYAVAILABLETILE table. 

Before you build this UI Model project, you must update the build output location to reflect your local environment. In Visual Studio, right-click the Blackbaud.CustomFx.EventsTile.UIModel project and select Properties. Then on the Compile tab, click Browse in the Build output path field and select the \bbappfx\vroot\bin\custom folder in your installation directory. After you update the build output location, you also need to update the xcopy path in the postbuild.bat file. In the Blackbaud.CustomFx.EventsTile.UIModel project, open the postbuild.bat. In the second line of the .bat file, update the path in the xcopy command to reflect the \bbappfx\vroot\bin\htmlforms folder in your installation directory.

##Resources##
* See the [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md). 
* [Step by Step Instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/ view-data-forms-tiles-sample.htm) for creating an event registrations tile
* [Data Forms](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/welcome-data-forms.htm) Chapter within Developer Guides


##Contributing##
If you would like to contribute to this code sample, please carefully read the [contributing documentation](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/CONTRIBUTING.md), which details the necessary workflow. Included in those requirements is [signing the Contributor License Agreement.](http://developer.blackbaud.com/cla/)