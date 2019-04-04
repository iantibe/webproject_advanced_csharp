using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.Interface;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.Services
{
    public class DatabaseService : iDatabaseService
    {

        List<HighScoreViewModel> TestData = new List<HighScoreViewModel>();

        public DatabaseService()
        {
            var Item1 = new HighScoreViewModel();

            Item1.HighScoreId = Guid.Parse("98e7a84f-1f5b-42d1-9edb-73eefb6b0b20");
            Item1.PersonId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a");
            Item1.Score = 5020;
            Item1.DateOfScore = new DateTime(2019, 2, 11);

            var Item2 = new HighScoreViewModel();

            Item2.HighScoreId = Guid.Parse("21b799e0-cef5-448e-8b8a-5212998b29c9");
            Item2.PersonId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a");
            Item2.Score = 7852;
            Item2.DateOfScore = new DateTime(2019, 2, 11);


            var Item3 = new HighScoreViewModel();

            Item3.HighScoreId = Guid.Parse("ea5c96d3-fd9d-46ab-8809-756a420623ce");
            Item3.PersonId = Guid.Parse("e4b62de3-d8ad-4439-b9da-b1e47956137a");
            Item3.Score = 6845;
            Item3.DateOfScore = new DateTime(2019, 2, 11);

            TestData.Add(Item1);
            TestData.Add(Item2);
            TestData.Add(Item3);
        }

        public List<HighScoreViewModel> GenerateData()
        {
            
            return TestData;
        }

        public void AddToDataBase(HighScoreViewModel ItemToAdd)
        {
            TestData.Add(ItemToAdd);

         }
    }
}
