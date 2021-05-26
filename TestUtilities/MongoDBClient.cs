using System;
using System.Collections.Generic;
using DataModelLibrary;
using DataModelLibrary.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TestUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDBCrud db = new MongoDBCrud();

            //db.InsertRecord("testconfigs", new TestConfig {
            //    Team = "SST",
            //    ConfigName = "SST_TIN_BaseConfig",
            //    BrowserType = BrowserType.Chrome,
            //    IsMobileEnabled = false,
            //    IsHeadless = false,
            //    MobileDevices = { "Pixel3AXL", "IPhone12" },
            //    StartUrl = "",
            //    Environment = "TIN",
            //    RunType = RunType.Local,
            //    TestCategories = {""},
            //    SeleniumCapabilities = {""},
            //    ViewPort =
            //    {
            //        Width = 1024,
            //        Height = 768
            //    }

            //});

            var records = db.GetSingleRecordById<TestConfig>("jhj");

            //foreach (var record in records)
            //{
            //    Console.WriteLine($"{record.Id} : {record.Team} {record.ConfigName}");

            //    if(record.StartUrl != null)
            //    {
            //        Console.WriteLine($"{record.Environment}");
            //    }
            //}

            Console.ReadLine();
        }
    }

    public class TestConfig
    {
        [BsonId]
        public Guid Id { get; set; }

        public string Team { get; set; }
        public string ConfigName { get; set; }

        public BrowserType BrowserType { get; set; }

        public bool IsMobileEnabled { get; set; }

        public bool IsHeadless { get; set; }

        public List<string> MobileDevices { get; set; }

        public string StartUrl { get; set; }

        public string Environment { get; set; }

        public RunType RunType { get; set; }

        public List<string> TestCategories { get; set; }

        public List<string> SeleniumCapabilities { get; set; }

        public ViewPort ViewPort { get; set; }
    }

    public class MongoDBCrud
    {
        private IMongoDatabase db;
        
        string MONGO_URI = "";
        string COLLECTION = "testconfigs";
        string DATABASE = "testautomation";

        public MongoDBCrud()
        {
            var client = new MongoClient(MONGO_URI);
            db = client.GetDatabase(DATABASE);
        }

        public void InsertRecord<T>(T record)
        {
            var collection = db.GetCollection<T>(COLLECTION);
            collection.InsertOne(record);
        }

        public T GetSingleRecordById<T>(string id)
        {
            var collection = db.GetCollection<T>(COLLECTION);
            var filter = Builders<T>.Filter.Eq("Id", id);

            return collection.Find(filter).First();
        }

        /// <summary>
        /// Looks for an existing record, if there it replaces the old record with new one, or if not there, it creates record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <param name="record"></param>
        public void UpsertRecord<T>(string id, T record)
        {
            var collection = db.GetCollection<T>(COLLECTION);

            var result = collection.ReplaceOne(
                    new BsonDocument("_id", id),
                    record,
                    new ReplaceOptions { IsUpsert = true });
        }

        public void UpdateSingleRecordById<T>(string id, T record)
        {
            var collection = db.GetCollection<T>(COLLECTION);

            var result = collection.ReplaceOne(
                    new BsonDocument("_id", id),
                    record,
                    new ReplaceOptions { IsUpsert = false });
        }

        public void DeleteRecord<T>(string id)
        {
            var collection = db.GetCollection<T>(COLLECTION);

            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

    }
}
