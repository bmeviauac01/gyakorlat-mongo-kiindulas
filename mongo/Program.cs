using System;
using System.Collections.Generic;
using System.Linq;
using BME.DataDriven.Mongo.Entitites;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace BME.DataDriven.Mongo
{
    public static class Program
    {
        private static IMongoClient client;
        private static IMongoDatabase database;

        private static IMongoCollection<Product> productsCollection;
        private static IMongoCollection<Order> ordersCollection;

        public static void Main(string[] args)
        {
            initialize();

            // TODO

            Console.ReadKey();
        }

        private static void initialize()
        {
            var pack = new ConventionPack
            {
                new ElementNameConvention(),
            };
            ConventionRegistry.Register("MyConventions", pack, _ => true);

            client = new MongoClient("mongodb://localhost:27017/datadriven");
            database = client.GetDatabase("datadriven");

            productsCollection = database.GetCollection<Product>("products");
            ordersCollection = database.GetCollection<Order>("orders");
        }
    }
}
