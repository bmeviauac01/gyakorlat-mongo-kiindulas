using MongoDB.Bson;

namespace Mongo.Entitites
{   
    public class MegrendelesTetel
    {
        public int? Mennyiseg { get; set; }
        public double? NettoAr { get; set; }
        public ObjectId TermekID { get; set; }
        public string Statusz { get; set; }
        public SzamlaTetel SzamlaTetel { get; set; }
    }
}
