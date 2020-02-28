using AspMongo.Helpers;

namespace AspMongo.Models
{
    public class DBSettings : IDBSettings
    {
        public string StudentsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}