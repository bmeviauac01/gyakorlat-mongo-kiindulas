using Mongo.Entitites;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;

namespace Mongo
{
    public static class Program
    {
        private static IMongoClient client;
        private static IMongoDatabase database;

        private static IMongoCollection<Termek> termekCollection;
        private static IMongoCollection<Megrendeles> megrendelesCollection;

        public static void Main(string[] args)
        {
            initialize();

            // TODO - feladatok megoldásai

            Console.ReadKey();
        }

        private static void initialize()
        {
            var pack = new ConventionPack
            {
                new AAFElementNameConvention(),
            };
            ConventionRegistry.Register("AAFConventions", pack, _ => true);

            client = new MongoClient("mongodb://localhost:27017/aaf");
            database = client.GetDatabase("aaf");

            termekCollection = database.GetCollection<Termek>("termekek");
            megrendelesCollection = database.GetCollection<Megrendeles>("megrendelesek");
        }
    }
}
