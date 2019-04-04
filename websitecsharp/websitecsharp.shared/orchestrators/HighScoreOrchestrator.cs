using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.domain;
using websitecsharp.shared.Interface;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.orchestrators
{
    public class HighScoreOrchestrator : iHighScore
    {
        private readonly scorecontext _scorecontext = new scorecontext();

        public List<HighScoreViewModel> GetData()
        {
            var score = _scorecontext.HighScore.Select(x => new HighScoreViewModel
            {
                Score = x.score,
                DateOfScore = x.dateAttained,
                HighScoreId = x.highScoreId,
                PersonId = x.personId

            }).ToList();

            return score;
        }

        public List<HighScoreViewModel> GetScores(List<HighScoreViewModel> score)
        {

            //var score = _scorecontext.HighScore.Select(x => new HighScoreViewModel
            //{
            //    Score = x.score,
            //    DateOfScore = x.dateAttained,
            //    HighScoreId = x.highScoreId,
            //    PersonId = x.personId

            //}).ToList();

            var sortedlist = new List<HighScoreViewModel>();


            while (score.Count != 0)
            {
                decimal highest = score[0].Score;
                int highindex = 0;

                for (int index = 1; index < score.Count; index++)
                {

                    if (score[index].Score >= highest)
                    {
                        highindex = index;
                        highest = score[highindex].Score;
                    }

                    
                }
                var item = new HighScoreViewModel();

                item.DateOfScore = score[highindex].DateOfScore;
                item.HighScoreId = score[highindex].HighScoreId;
                item.PersonId = score[highindex].PersonId;
                item.Score = score[highindex].Score;

                sortedlist.Add(item);
                score.RemoveAt(highindex);
            }
                       

            return sortedlist;

        }

        

        public HighScoreViewModel UpdateScore(Decimal score, Guid name, List<HighScoreViewModel> Databaseresults, out HighScoreViewModel newperson)
        {
           

            var PersonToChange = Databaseresults.Find(x => x.PersonId == name);

            if (PersonToChange == null)
            {
                var NewPerson = new HighScoreViewModel();

                NewPerson.DateOfScore = DateTime.Now;
                NewPerson.HighScoreId = Guid.NewGuid();
                NewPerson.Score = score;
                NewPerson.PersonId = name;

                newperson = NewPerson;

                return NewPerson;
            }
            else
            {
                if (PersonToChange.Score < score)
                {

                    var updateEntity = new HighScoreViewModel();

                    updateEntity.PersonId = PersonToChange.PersonId;
                    updateEntity.Score = (int)score;
                    updateEntity.DateOfScore = DateTime.Now;
                    updateEntity.HighScoreId = PersonToChange.HighScoreId;

                    newperson = null;

                    return updateEntity;


                }
                else
                {
                    newperson = null;

                    return PersonToChange;
                }

            }



        }

        public async Task<bool> UpdateDatabase(HighScoreViewModel ItemToAdd)
        {
           var Update = await _scorecontext.HighScore.FindAsync(ItemToAdd.PersonId);

            if (Update == null)
            {
                return false;
            }

            Update.score = (int) ItemToAdd.Score;
            Update.personId = ItemToAdd.PersonId;
            Update.highScoreId = ItemToAdd.HighScoreId;
            Update.dateAttained = ItemToAdd.DateOfScore;

            await _scorecontext.SaveChangesAsync();

            return true;
        }

    }

}
