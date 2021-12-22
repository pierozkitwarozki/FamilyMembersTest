using System.Security.Authentication;
using FamilyMembers.API.Dtos;
using FamilyMembers.API.Models;
using FamilyMembers.API.Repos;

namespace FamilyMembers.API.Services
{
    public class FamilyMemberService : IFamilyMemberService
    {
        private readonly IMongoDbRepository<FamilyMember> _familyMemberRepo;

        public FamilyMemberService(IMongoDbRepository<FamilyMember> familyMemberRepo)
        {
            _familyMemberRepo = familyMemberRepo;
        }

        public async Task InsertOneAsync(FamilyMemberCreateDto familyMemberCreateDto)
        {
            var entity = new FamilyMember 
            {
                FirstName = familyMemberCreateDto.FirstName,
                LastName = familyMemberCreateDto.LastName
            };

            await _familyMemberRepo.InsertOneAsync(entity);
        }

        public async Task<IEnumerable<FamilyMember>> GetAllAsync()
        {
            return await _familyMemberRepo.GetAllAsync();
        }
    }
}