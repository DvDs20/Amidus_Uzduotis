
using SQLite;

namespace Amidus_Uzduotis.Models
{
    public class Language
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
        public double AverageScore { get; set; }
        public int NumberOfVotes { get; set; }
    }
}
