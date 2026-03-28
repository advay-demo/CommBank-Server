using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace CommBank.Models;

public class Account
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Number")]
    public long? Number { get; set; }

    [BsonElement("Name")]
    public string? Name { get; set; }

    [BsonElement("Balance")]
    public double Balance { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [BsonRepresentation(BsonType.String)]
    [BsonElement("AccountType")]
    public AccountType AccountType { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("TransactionIds")]
    public List<string>? TransactionIds { get; set; }
}