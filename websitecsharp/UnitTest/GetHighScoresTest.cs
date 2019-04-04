using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.orchestrators;
using websitecsharp.shared.Services;
using websitecsharp.shared.viewmodels;
using websitecsharp.web.api;

namespace UnitTest
{
    [TestClass]
    public class GetHighScoresTest
    {
        private readonly AutoMoqer _mock = new AutoMoqer();
        HighScoreViewModel NewItemoToadd = null;
       
        [TestMethod]
        public void ReturnProperData_GetHighScoresApi()
        {
            //arrange
            var Database =_mock.Create<DatabaseService>();
            var MockedController = _mock.Create<HighScoreOrchestrator>();

            var DataToTest = Database.GenerateData();

            //act
           var SortedDataToCheck = MockedController.GetScores(DataToTest);

            bool TestResult = false;

            if(SortedDataToCheck[0].Score >= SortedDataToCheck[1].Score && SortedDataToCheck[1].Score >= SortedDataToCheck[2].Score)
            {
                TestResult = true;
            }

            //assert
            Assert.IsTrue(TestResult);
            

            

        }

        [TestMethod]
        public void Positive_Unit_Test_Update_Scores()
        {
            
        var Database = _mock.Create<DatabaseService>();
            //arrange
             
             
            var MockedOrchestrator = _mock.Create<HighScoreOrchestrator>();
            
            decimal NewScore = 10000;
            Guid PersonToUpdate = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a");

            //act
            
            var UpdatedScore = MockedOrchestrator.UpdateScore(NewScore, PersonToUpdate, Database.GenerateData(), out NewItemoToadd);

            //assert
            Assert.IsTrue(UpdatedScore.Score == NewScore);
        }

        [TestMethod]
        public void Negative_unit_test_update_score()
        {
            //arrange

            var Database = _mock.Create<DatabaseService>();
            var MockedOrchestrator = _mock.Create<HighScoreOrchestrator>();

            decimal NewScore = 10;
            Guid PersonToUpdate = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a");

            //act

            var UpdatedScore = MockedOrchestrator.UpdateScore(NewScore, PersonToUpdate, Database.GenerateData(), out NewItemoToadd);

            //assert
            Assert.IsFalse(UpdatedScore.Score == NewScore);
        }

        [TestMethod]
        public void IntegrationTest()
        {

            var Database = _mock.Create<DatabaseService>();
            var MockedOrchestrator = _mock.Create<HighScoreOrchestrator>();
            int OrignialNumberOfItems = Database.GenerateData().Count;

            decimal NewScore = 10000;
            Guid PersonToAdd = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137b");

            var UpdatedScore = MockedOrchestrator.UpdateScore(NewScore, PersonToAdd, Database.GenerateData(), out NewItemoToadd);

           Database.AddToDataBase(NewItemoToadd);

            int NumberOfItemsAfterAdd = Database.GenerateData().Count;

            Assert.IsTrue(OrignialNumberOfItems + 1 == NumberOfItemsAfterAdd);

        }
    }
}
