using FamilyMembers.API.Dtos;
using FamilyMembers.API.Models;

namespace FamilyMembers.API.Services
{
    public interface IFamilyMemberService
    {
        Task<IEnumerable<FamilyMember>> GetAllAsync();
        Task InsertOneAsync(FamilyMemberCreateDto familyMemberCreateDto);
    }
}