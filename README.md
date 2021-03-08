# EntityCoreDemo

#Needed packages:
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Sqlserver
Microsoft.EntityFrameworkCore.Tools

#package manager console script
PM> add-migration MyInitialMigration
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
PM> update-database
Build started...
Build succeeded.
Done.
PM> add-migration "added navigation and collection properties, relationship"
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
PM> update-database
Build started...
Build succeeded.
Done.
PM> 
