using SQLite;

namespace MauiApp4.Views
{
    [Table("catFacts")]
    public class CatFact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;  }
        
        [MaxLength(250), Unique]
        public string Fact { get; set;  }
    }
}