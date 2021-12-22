using FamilyMembers.API.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FamilyMembers.API.Models
{
    [BsonCollection("FamilyMembers")]
    public class FamilyMember
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [BsonElement("firstName")]
        public string FirstName { get; set; } = string.Empty;

        [BsonElement("lastName")]
        public string LastName { get; set; } = string.Empty;
    }
}