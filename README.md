# DILunchAndLearn
For a youtube walkthrough refer to:
https://www.youtube.com/watch?v=1rdklszOqQA&feature=youtu.be

-	1) Install mongodb and get it up and running http://docs.mongodb.org/manual/tutorial/install-mongodb-on-windows/
-	2) Clone repo or download as zip
-	3) Right click on solution and choose to restore nuget packages
-	4) Build project
-	5) Launch SQL Server Management Services, point to your local Sql instance and run the scripts found at: https://github.com/softwareunwound/DILunchAndLearn/tree/master/LunchAndLearnDI/DataAccess/DataPopulationScripts
- 6) Ensure that Mongodb is running locally on your machine
- 7) Run the unit test https://github.com/nemesek/DILunchAndLearn/blob/master/UnitTestProject1/SyncUpMongo.cs
This will populate mongo with the same data that is in your newly created DB from step 5.
https://github.com/softwareunwound/DILunchAndLearn/blob/master/LunchAndLearnDI/DataAccess/EFProductsRepository.cs and https://github.com/softwareunwound/DILunchAndLearn/blob/master/LunchAndLearnDI/DataAccess/MongoProductsRepository.cs

