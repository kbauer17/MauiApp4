using MauiApp4.Views;
using SQLite;

namespace MauiApp4;

public class CatFactRepository
{
    string _dbPath;

    public string StatusMessage { get; set; }

    // Add variable for the SQLite connection
    private SQLiteConnection _conn;

    private void Init()
    {
        // Add code to initialize the repository 
        if (_conn != null)
            return;
        _conn = new SQLiteConnection(_dbPath);
        _conn.CreateTable<CatFact>();
    }

    public CatFactRepository(string dbPath)
    {
        _dbPath = dbPath;                        
    }

    public void AddNewCatFact(string fact)
    {            
        int result = 0;
        try
        {
            // Call Init()
            Init();

            // basic validation to ensure a name was entered
            if (string.IsNullOrEmpty(fact))
                throw new Exception("Valid name required");

            // Insert the new cat fact into the database
            result = _conn.Insert(new CatFact{Fact = fact});

            StatusMessage = string.Format("{0} record(s) added (Fact: {1})", result, fact);
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", fact, ex.Message);
        }

    }

    public List<CatFact> GetAllCatFacts()
    {
        // Init then retrieve a list of Person objects from the database into a list
        try
        {
            Init();
            return _conn.Table<CatFact>().ToList();
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<CatFact>();
    }
}
