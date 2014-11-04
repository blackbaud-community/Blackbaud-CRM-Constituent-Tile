Blackbaud-CRM-Constituent-Tile
==============================
This is a placeholder for a project to demonstrate how to create constituent tiles in Blackbaud CRM 4.0.

Starting in Blackbaud CRM 4.0, the constituent summary on the Constituent page now displays a series of interactive tiles. Each tile is a self-contained view form that the summary view form dynamically loads, and end users can select which tiles to display. The summary displays several out-of-the-box tiles, and third-party developers can create their own view data forms to display as tiles in the summary.

This example will teach you the basisc of building a custom tile to display in the Constituent page summary. To create a custom tile, you first create a view data from and specify the data to display in the tile. Next, you create a UI Model for the view data form and use it to modify the appearance of the tile. Finally, after you load the view data form and build the UI Model project, you designate the view data form as a tile by using a SQL statement to insert a row for the view form in the CONSTITUENTSUMMARYAVAILABLETILE table.

This code sample includes a Visual Studio solution with a catalog project and a UI Model project. The catalog project includes a view data form spec to display event registration information in  a custom tile. The UI Model project includes the UI Model that implements the tile interface for the view data form. The code sample also includes a SQL statement to insert a row for the view data form in the CONSTITUENTSUMMARYAVAILABLETILE table. 

##Resources##
* See the [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md). 

* [Step by Step Instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/ view-data-forms-tiles-sample.htm)

* [Data Forms](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/data-forms/Content/data-forms/welcome-data-forms.htm) Chapter within Developer Guides


##Contributing##

If you would like to contribute your own code sample, please read the following resources:

* [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md)
* [Contributing to the blackbaud-community](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/contributing.md)
