using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CommBank.Models;

public class Goal
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string? Name { get; set; }

    [BsonElement("TargetAmount")]
    public ulong TargetAmount { get; set; } = 0;

    [BsonElement("TargetDate")]
    public DateTime TargetDate { get; set; }

    [BsonElement("Balance")]
    public double Balance { get; set; } = 0.00;

    [BsonElement("Created")]
    public DateTime Created { get; set; } = DateTime.Now;

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("TransactionIds")]
    public List<string>? TransactionIds { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("TagIds")]
    public List<string>? TagIds { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("UserId")]
    public string? UserId { get; set; }
    [BsonElement("Icon")]
    public string? Icon { get; set; }
}