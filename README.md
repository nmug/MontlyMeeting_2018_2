# MontlyMeeting_2018_2
NMUG February 2018 Monthly Meeting - Entity Framework Code First Discussion with Database Focus

Agenda:

* Review simple ORM.  
  * Review Raw Ado.net call with manual update of a complex business object.
* Review Database First Old School EDMX method
 * Update from database and review visual creation of EDMX file
* Review Database First using EntityFramework Reverse POCO Generator
 * Review how to deal with different database schemas
 * Review how to customize Generator to pull certain database objects using regex
* Review Database First using EntityFramework Core and it's built in database scaffolding
* Review Code First using Entity Framework Core
* Review Code First using Entity Framework 6+
 * Look at how convention can work great
   * Listen to DBA on some issues with navigation properties (FK column naming), etc.
 * Learn how to override convention if it's not to the standard that you want.
   * Receive feedback from DBA on best practice for naming, etc. and show how to override convention.
 * Use Data Annotations with models
 * Use Fluent API with Entity framework to specify relations, navigation properties, etc.
 * Learn how to process model changes to the database
   * Discuss with DBA how a Dev, QA, and Production environment might work with Code First stuff.
 * Learn how to set seeding of initial data
 * Learn how to manually update the up and down procedures for database updates
 * Discuss some gotchas for Code First like changing types on the key, etc.
