using Microsoft.AspNetCore.Mvc;
using ContactDetailsApi.Models;

namespace ContactDetailsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactDetailsController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] ContactDetails contactDetails)
    {
        if (string.IsNullOrWhiteSpace(contactDetails.Firstname) ||
            string.IsNullOrWhiteSpace(contactDetails.Lastname) ||
            string.IsNullOrWhiteSpace(contactDetails.Email) ||
            string.IsNullOrWhiteSpace(contactDetails.Gender) ||
            string.IsNullOrWhiteSpace(contactDetails.Title))
            return BadRequest("All contact fields must be filled.");

        ProcessContactDetails(contactDetails);

        await Task.CompletedTask;

        return Ok();
    }

    private void ProcessContactDetails(ContactDetails contactDetails)
    {
        //Process contact details and save it to sql database


    }
}