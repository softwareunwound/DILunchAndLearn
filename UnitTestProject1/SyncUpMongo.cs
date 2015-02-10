using LunchAndLearnDI.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SyncUpMongo
    {
        [TestMethod]
        public void SyncMongo()
        {
            PopulateMongo();
        }

        public void PopulateMongo()
        {
            var mongoRepository = new MongoProductsRepository();
            mongoRepository.SeedMongoDb();
        }
    }
}
