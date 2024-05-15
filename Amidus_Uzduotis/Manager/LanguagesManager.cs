using Amidus_Uzduotis.Gateway;
using Amidus_Uzduotis.Models;

namespace Amidus_Uzduotis.Manager
{
    public class LanguagesManager
    {
        private readonly LanguagesGateway languagesGateway = new();

        public List<String> GetLanguages()
        {
            return languagesGateway.GetLanguages();
        }

        public List<Language> GetAllLanguages()
        {
            return languagesGateway.GetAllLanguages();
        }

        public void SaveNewScore(string selectedLanguage, int score)
        {
            Language selectedLanguageStats = languagesGateway.GetLanguage(selectedLanguage);

            if (selectedLanguageStats != null)
            {
                int selectedLanguageMinScore = selectedLanguageStats.MinScore;
                int selectedLanguageMaxScore = selectedLanguageStats.MaxScore;
                double selectedLanguageAverageScore = selectedLanguageStats.AverageScore;
                int selectedLanguageNumberOfVotes = selectedLanguageStats.NumberOfVotes;

                if (score < selectedLanguageMinScore)
                {
                    selectedLanguageMinScore = score;
                }
                if (score > selectedLanguageMaxScore)
                {
                    selectedLanguageMaxScore = score;
                }

                double newAverageScore = Math.Round(((selectedLanguageAverageScore * selectedLanguageNumberOfVotes) + score) / (selectedLanguageNumberOfVotes + 1), 2);
                selectedLanguageNumberOfVotes++;

                selectedLanguageStats.MinScore = selectedLanguageMinScore;
                selectedLanguageStats.MaxScore = selectedLanguageMaxScore;
                selectedLanguageStats.AverageScore = newAverageScore;
                selectedLanguageStats.NumberOfVotes = selectedLanguageNumberOfVotes;

                languagesGateway.UpdateLanguageStats(selectedLanguageStats);
            }
            else 
            {
                Language newLanguageStats = new()
                {
                    Name = selectedLanguage,
                    MinScore = score,
                    MaxScore = score,
                    AverageScore = score,
                    NumberOfVotes = 1
                };
                languagesGateway.CreateNewLanguageStats(newLanguageStats);
            }
        }
    }
}
