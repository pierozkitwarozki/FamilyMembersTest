using FamilyMembers.API.Dtos;
using FamilyMembers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FamilyMembers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FamilyMemberController : ControllerBase
{
    private readonly IFamilyMemberService _familyMemberService;

    public FamilyMemberController(IFamilyMemberService familyMemberService)
    {
        _familyMemberService = familyMemberService;
    }

    [HttpPost]
    public async Task<IActionResult> InsertOneAsync(FamilyMemberCreateDto familyMemberCreateDto)
    {
        try 
        {
            await _familyMemberService.InsertOneAsync(familyMemberCreateDto);

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        try 
        {
            var members = await _familyMemberService.GetAllAsync();

            return Ok(members);
        }
        catch
        {
            return NotFound();
        }
    }
}
