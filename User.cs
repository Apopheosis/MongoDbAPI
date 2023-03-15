using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("password")] public string? Password { get; set; }
    [BsonElement("age")] public int Age { get; set; }

    [BsonElement("clearance")] public string? Clearance { get; set; }
    
    [BsonElement("index")]
    public int Index { get; set; }

    
}
