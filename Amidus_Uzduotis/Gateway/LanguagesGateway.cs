using Amidus_Uzduotis.Models;

namespace Amidus_Uzduotis.Gateway
{
    public class LanguagesGateway
    {
        private readonly ApplicationDbContext dbContext = new();

        public List<String> GetLanguages()
        {
           return dbContext.Languages.Select(l => l.Name).ToList();
        }

        public List<Language> GetAllLanguages()
        {
            return dbContext.Languages.ToList();
        }

        public Language GetLanguage(string languageName) 
        {
            return dbContext.Languages.FirstOrDefault(l => l.Name.Equals(languageName));
        }

        public void CreateNewLanguageStats(Language language)
        {
            dbContext.Languages.Add(language);
            dbContext.SaveChanges();
            
        }

        public void UpdateLanguageStats(Language language)
        {
            dbContext.Languages.Update(language);
        }
    }
}
