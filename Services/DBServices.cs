using AspMongo.Helpers;
using AspMongo.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AspMongo.Services
{
    public class DBServices
    {
        private readonly IMongoCollection<Student> _db;
        public DBServices(IDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _db = database.GetCollection<Student>(settings.StudentsCollectionName);
            // var client = new MongoClient("mongodb://localhost:27017");
            // var database = client.GetDatabase("CollegeDB");
            // _db = database.GetCollection<Student>("Students");
        }

        public List<Student> Get() => _db.Find(student => true).ToList();
        public Student Get(string id) => _db.Find(Student => Student.Id == id).FirstOrDefault();
        public bool Create(Student stu)
        {
            try
            {
                _db.InsertOne(stu);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }            
        }

    }
}