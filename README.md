# WinOps 2016 (http://www.winops.org)
Demos and slides from my session "Development and QA dilemmas in DevOps" at WinOps 2016.

## Feature Flags

The demo uses LaunchDarkly as a Feature Flags provider. You'll need to register and add the custom scripts from them in the _Layout.cshtml file.

There are two features (Sum and Subtract) available behind Feature Flags.

## Change

This sample is a modified version of the ToDoApp from the Azure App Service team.
The demo is made of four steps:

- add the URef column to the schema definition of the Azure SQL Database (Migrations\201504231007334_Initialize Database.cs)
- add the column to the Model (Models\Todoitem.cs)
- add the logic in the Controller (Controllers\ToDoItemsController.cs) by uncommenting line 89 and Counter() 
- add the URef values in the sample data (Migrations\Configuration.cs) to simulate the legacy data migration (data added after the previous step will keep working as expected)

Each step would be executed at the end of a sprint, so the change would be implemented across four sprints.
