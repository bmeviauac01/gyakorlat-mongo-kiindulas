using MongoDB.Bson;

namespace BME.DataDriven.Mongo.Entitites
{
    public class OrderItem
    {
        public int? Amount { get; set; }
        public double? Price { get; set; }
        public ObjectId ProductID { get; set; }
        public string Status { get; set; }
        public InvoiceItem InvoiceItem { get; set; }
    }
}
